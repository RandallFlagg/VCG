' VisualCodeGrepper - Code security scanner
' Copyright (C) 2012-2014 Nick Dunn and John Murray
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Option Explicit On
Imports System.IO
Imports System.Text.RegularExpressions

Friend Module modMain

    '== Array to be used when sorting on multiple coilumns ==
    Friend dicColumns As New Dictionary(Of String, Integer)

    '== Class instance to hold app settings ==
    Friend asAppSettings As New AppSettings

    '== Class instances to track details of file/code scanning operations ==
    Friend ctCodeTracker As New CodeTracker
    Friend rtResultsTracker As New ResultsTracker

    '== Used for sharing data between main chart and individual charts ==
    Friend strCurrentFileName As String = ""
    Friend intComments As Integer = 0
    Friend intCodeIssues As Integer = 0

    '== Placeholder to be used when modifying severity levels ==
    Friend intNewSeverity As Integer = -1

    Friend Function ParseArgs() As Integer
        ' Read any command line args and start application as appropriate
        '================================================================
        Dim intIndex As Integer
        Dim arrArgs() As String = Environment.GetCommandLineArgs()
        Dim exportFlagSet = False

        '== Deal with any command line options ==
        If arrArgs.Count <> 1 Then
            intIndex = 1
            Dim showHelpAndExit = False

            'TODO: Test me to make sure the new condition in the while is correct
            While intIndex < arrArgs.Count() And Not showHelpAndExit

                Select Case arrArgs(intIndex)

                    Case "-t", "--target"
                        ' Set target
                        intIndex += 1
                        If intIndex < arrArgs.Count() Then
                            rtResultsTracker.TargetDirectory = arrArgs(intIndex)

                            If String.IsNullOrWhiteSpace(rtResultsTracker.TargetDirectory) Then
                                LogError("No target specified (-t)")
                                showHelpAndExit = True
                            ElseIf (Directory.Exists(rtResultsTracker.TargetDirectory) = False) Then
                                LogError("Target does not exist: {0}", rtResultsTracker.TargetDirectory)
                                showHelpAndExit = True
                            End If
                        End If
                    Case "-l", "--language"
                        ' Set language
                        intIndex += 1
                        If intIndex < arrArgs.Count() Then
                            Dim language = arrArgs(intIndex)
                            If Not SetLanguage(language) Then
                                LogError("Unrecognised language: {0}", language)
                                showHelpAndExit = True
                            End If

                            ' Set up associated extensions with language
                            SetSuffixes(asAppSettings.TestType)
                        Else
                            LogError("No language specified (-l)")
                            showHelpAndExit = True
                        End If

                    Case "-e", "--extensions"
                        ' Set file extensions
                        intIndex += 1
                        If intIndex < arrArgs.Count() Then
                            asAppSettings.FileSuffixes = arrArgs(intIndex).Split("|")
                        Else
                            LogError("No extensions provided (-e)")
                            showHelpAndExit = True
                        End If
#If FIX_ME Then
                    Case "-i", "--import"
                        ' Import XML results
                        intIndex += 1
                        If intIndex < arrArgs.Count() Then
                            If arrArgs(intIndex).ToLower.EndsWith(".xml") Then
                                If File.Exists(arrArgs(intIndex)) = False Then
                                    LogError("Import XML file does not exist: {0}", arrArgs(intIndex))
                                    showHelpAndExit = True
                                End If

                                asAppSettings.IsXmlInputFile = True
                                asAppSettings.XmlInputFile = arrArgs(intIndex)
                                frmMain.ImportResultsXML(asAppSettings.XmlInputFile)
                            ElseIf arrArgs(intIndex).ToLower.EndsWith(".csv") Then

                                If File.Exists(arrArgs(intIndex)) = False Then
                                    LogError("Import CSV file does not exist: {0}", arrArgs(intIndex))
                                    showHelpAndExit = True
                                End If

                                asAppSettings.IsCsvInputFile = True
                                asAppSettings.CsvInputFile = arrArgs(intIndex)
                                frmMain.ImportResultsCSV(asAppSettings.CsvInputFile)
                            End If

                            ' If results are being imported for inspection then console-only mode must be off and we should not have a target!
                            asAppSettings.IsConsole = False
                            Dim strTarget As String = ""
                            Exit While
                        Else
                            LogError("No input filename provided (-i)")
                        End If
#End If
                    Case "-x", "--export"
                        ' Automatically export XML results
                        intIndex += 1
                        If intIndex < arrArgs.Count() Then
                            asAppSettings.XmlOutputFile = arrArgs(intIndex)
                            asAppSettings.IsXmlOutputFile = True
                            exportFlagSet = True
                        Else
                            LogError("No XML results filename provided (-x)")
                            showHelpAndExit = True
                        End If

                    Case "-f", "--csv-export"
                        ' Automatically export CSV results
                        intIndex += 1
                        If intIndex < arrArgs.Count() Then
                            asAppSettings.CsvOutputFile = arrArgs(intIndex)
                            asAppSettings.IsCsvOutputFile = True
                            exportFlagSet = True
                        Else
                            LogError("No CSV results filename provided (-f)")
                            showHelpAndExit = True
                        End If

                    Case "-r", "--results"
                        ' Automatically export flat text results
                        intIndex += 1
                        If intIndex < arrArgs.Count() Then
                            asAppSettings.OutputFile = arrArgs(intIndex)
                            asAppSettings.IsOutputFile = True
                            exportFlagSet = True
                        Else
                            LogError("No results filename provided (-r)")
                            showHelpAndExit = True
                        End If

                    Case "-c", "--console"
                        AttachProcessToConsole()
                        asAppSettings.IsConsole = True
                        'frmMain.Visible = False 'TODO: This is not the concern of this module but of who ever starts the console or the form
                        asAppSettings.DisplayBreakdownOption = False
                        asAppSettings.VisualBreakdownEnabled = False

                        ' Stops error messages being printed after the Console command
                        LogBlank()

                    Case "-v", "--verbose"
                        ' Verbose mode
                        asAppSettings.IsVerbose = True
                    Case "--help", "/?", "-h"
                        showHelpAndExit = True
                    Case "--debug"
                        ' Expected flag, dealt with in AttachDebugger.. function
                    Case Else
                        ' Help
                        LogError($"Unknown option {arrArgs(intIndex)}")
                        showHelpAndExit = True
                End Select

                intIndex += 1
            End While
        End If

#If FIX_ME Then
        If showHelpAndExit Then
            HelpText()
            If asAppSettings.IsConsole Then
                LogBlank(strHelp)
            Else
                MessageBox.Show(strHelp, "Help", MessageBoxButtons.OK)
            End If
            Return EXIT_CODE
        End If

        If asAppSettings.IsConsole = True Then
            If exportFlagSet = False Then
                LogError("ERROR: No output flag set (i.e. XML, CSV, Flat), so no results will be generated. Exiting...")
                Return -1
            End If
            frmMain.Hide()
        End If
#End If
        Return intIndex

    End Function



    Private Function HelpText()
        ' Display help and show usage
        '============================

        Return "Visual Code Grepper (VCG) 2.0 (C) Nick Dunn And John Murray, 2012-2014.
            Usage:  VisualCodeGrepper [OPTIONS]       
    
            STARTUP:
            Set desired starting point for GUI. If using console mode these options will set target(s) to be scanned.

             -t, --target <Filename|DirectoryName>:      Set target file or directory. Use this option either to load target 
                                                         immediately into GUI or to provide the target for console mode.
             -l, --language <CPP|PLSQL|JAVA|CS|VB|PHP>   Set target language (Default is C/C++).
             -e, --extensions <ext1|ext2|ext3>           Set file extensions to be analysed (See ReadMe or Options screen for language-specific defaults).
             -i, --import <Filename>                     Import XML/CSV results to GUI.

            OUTPUT:
            Automagically export results to a file in the specified format. Use XML output if you wish to reload results into the GUI later on.

             -x, --export <Filename>                     Automatically export results to XML file.
             -f, --csv-export <Filename>                 Automatically export results to CSV file.
             -r, --results <Filename>                    Automatically export results to flat text file.

            CONSOLE OPTIONS:
             -c, --console                               Run application in console only (hide GUI).
             -v, --verbose                               Set console output to verbose mode.
             -h, --help                                  Show (this) help.

            EXAMPLES:

            > VisualCodeGrepper.exe -t c:\code\mycodebase -lang VB
    
                Loads the UI with the Target Directory pre-filled, and language pre-selected

            > VisualCodeGrepper --console -t c:\code\mycodebase -lang VB -r c:\code\results.txt  

                Supresses the UI, scans Target Directory for VB files, and saves output to a Flat File."

    End Function

    Private Function SetLanguage(NewLanguage As String) As Boolean
        ' Get new langauge from command line
        '===================================
        Dim blnRetVal As Boolean = True

        NewLanguage = NewLanguage.ToUpper

        Select Case NewLanguage
            Case "C", "C++", "CPP"
                asAppSettings.TestType = AppSettings.C
            Case "JAVA"
                asAppSettings.TestType = AppSettings.JAVA
            Case "PL/SQL", "PLSQL", "SQL"
                asAppSettings.TestType = AppSettings.SQL
            Case "C#", "C-SHARP", "CS", "CSHARP"
                asAppSettings.TestType = AppSettings.CSHARP
            Case "VB", "VISUALBASIC", "VISUAL-BASIC"
                asAppSettings.TestType = AppSettings.VB
            Case "PHP"
                asAppSettings.TestType = AppSettings.PHP
            Case "COBOL"
                asAppSettings.TestType = AppSettings.COBOL
            Case "R"
                asAppSettings.TestType = AppSettings.R
            Case Else
                blnRetVal = False
        End Select

        Return blnRetVal

    End Function

    Friend Sub LaunchNPP(FileName As String, Optional LineNumber As Integer = 1)
        ' Launch NPP if available, launch Notepad if not
        '===============================================

        Try
            ' If we're trying to open a file on a specific line in Notepad++ then the filename *must* be quoted to avoid erratic behaviour from Windows
            System.Diagnostics.Process.Start("notepad++.exe", $"-n{LineNumber} ""{FileName}""")
        Catch ex As Exception
            System.Diagnostics.Process.Start("Notepad.exe", """" & FileName & """")
        End Try

    End Sub

    <Obsolete("Not currently integrated. Coming soon!", True)>
    Private Sub LaunchVSCode(FileName As String, Optional LineNumber As Integer = 1)
        ' Launch VS Codeif available, launch Notepad if not
        '===============================================

        Try
            ' If we're trying to open a file on a specific line in Notepad++ then the filename *must* be quoted to avoid erratic behaviour from Windows
            System.Diagnostics.Process.Start("code.exe", $"--goto {LineNumber} ""{FileName}""")
        Catch ex As Exception
            System.Diagnostics.Process.Start("Notepad.exe", $"""{FileName}\""")
        End Try

    End Sub


    Friend Sub SetSuffixes(Language As Integer)
        ' Set the filetypes to scan
        '==========================

        asAppSettings.IsAllFileTypes = False

        '== Check if wildcard/all files has been specified == 
        If asAppSettings.CSuffixes.Contains(".*") Or asAppSettings.CSuffixes.Trim = "" Then
            asAppSettings.IsAllFileTypes = True
        Else
            Select Case Language
                Case AppSettings.C
                    asAppSettings.FileSuffixes = asAppSettings.CSuffixes.Split("|")
                Case AppSettings.JAVA
                    asAppSettings.FileSuffixes = asAppSettings.JavaSuffixes.Split("|")
                Case AppSettings.SQL
                    asAppSettings.FileSuffixes = asAppSettings.PLSQLSuffixes.Split("|")
                Case AppSettings.CSHARP
                    asAppSettings.FileSuffixes = asAppSettings.CSharpSuffixes.Split("|")
                Case AppSettings.VB
                    asAppSettings.FileSuffixes = asAppSettings.VBSuffixes.Split("|")
                Case AppSettings.PHP
                    asAppSettings.FileSuffixes = asAppSettings.PHPSuffixes.Split("|")
                Case AppSettings.COBOL
                    asAppSettings.FileSuffixes = asAppSettings.COBOLSuffixes.Split("|")
                Case AppSettings.R
                    asAppSettings.FileSuffixes = asAppSettings.RSuffixes.Split("|")
            End Select

            asAppSettings.NumSuffixes = asAppSettings.FileSuffixes.Length - 1
        End If

    End Sub

    Friend Sub LoadUnsafeFunctionList(CurrentLanguage As Integer)
        ' Load appropriate list of bad functions from file (dependent on selected language)
        '==================================================================================

        Dim strDescription As String = ""
        Dim strConfFile As String = ""
        Dim arrFuncList As String()


        asAppSettings.BadFunctions.Clear()


        'ToDo: check these against their safe equivalents, make sure not flagging any false positives or false negatives, might be worthwhile to do a check (later) if it is flagged as _
        'eg. sprintf its not u_vsprintf, etc.

        ' Check file exists 
        If Not File.Exists(asAppSettings.BadFuncFile) Then

            'TODO: Should AppSettings.ApplicationDirectory be changed to a different value?
            ' Restore default file in case of bad registry entries, user placing non-existent file in Options dialog, etc.
            Select Case CurrentLanguage
                Case AppSettings.C
                    asAppSettings.BadFuncFile = Path.Combine(AppSettings.ApplicationDirectory, "config\cppfunctions.conf")
                Case AppSettings.JAVA
                    asAppSettings.BadFuncFile = Path.Combine(AppSettings.ApplicationDirectory, "javafunctions.conf")
                Case AppSettings.SQL
                    asAppSettings.BadFuncFile = Path.Combine(AppSettings.ApplicationDirectory, "plsqlfunctions.conf")
                Case AppSettings.CSHARP
                    asAppSettings.BadFuncFile = Path.Combine(AppSettings.ApplicationDirectory, "config\csfunctions.conf")
                Case AppSettings.VB
                    asAppSettings.BadFuncFile = Path.Combine(AppSettings.ApplicationDirectory, "vbfunctions.conf")
                Case AppSettings.PHP
                    asAppSettings.BadFuncFile = Path.Combine(AppSettings.ApplicationDirectory, "phpfunctions.conf")
                Case AppSettings.COBOL
                    asAppSettings.BadFuncFile = Path.Combine(AppSettings.ApplicationDirectory, "cobolfunctions.conf")
                Case AppSettings.R
                    asAppSettings.BadFuncFile = Path.Combine(AppSettings.ApplicationDirectory, "rfunctions.conf")
            End Select

            If Not File.Exists(asAppSettings.BadFuncFile) Then
                MsgBox("No config file found for bad functions.", MsgBoxStyle.Critical, "Error")
            End If

        Else
            Try
                For Each strLine In File.ReadLines(asAppSettings.BadFuncFile)

                    ' Check for comments/whitespace
                    If (strLine.Trim() <> Nothing) And (Not strLine.Trim().StartsWith("//")) Then

                        Dim ciCodeIssue As New CodeIssue

                        ' Build up array of bad functions and any associated descriptions
                        If strLine.Contains("=>") Then
                            arrFuncList = Regex.Split(strLine, "=>")
                            ciCodeIssue.FunctionName = arrFuncList.First

                            strDescription = arrFuncList.Last.Trim

                            ' Extract severity level from description (if present)
                            If strDescription.StartsWith("[0]") Or strDescription.StartsWith("[1]") Or strDescription.StartsWith("[2]") Or strDescription.StartsWith("[3]") Then
                                ciCodeIssue.Severity = CInt(strDescription.Substring(1, 1))
                                strDescription = strDescription.Substring(3).Trim
                            End If

                            ciCodeIssue.Description = strDescription
                        Else
                            ciCodeIssue.FunctionName = strLine
                            ciCodeIssue.Description = ""
                        End If

                        If Not asAppSettings.BadFunctions.Contains(ciCodeIssue) Then asAppSettings.BadFunctions.Add(ciCodeIssue)
                    End If
                Next

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

        ' Fix to stop temp content being wiped at start of scan
        If asAppSettings.TempGrepText <> "" Then
            SharedCode.LoadTempGrepContent(asAppSettings.TempGrepText)
        End If

    End Sub

    Friend Sub LoadBadComments()
        ' Get list of bad comments from config file
        '==========================================

        Try
            For Each strLine In File.ReadLines("./config/" & asAppSettings.BadCommentFile)

                ' Check for comments/whitespace
                If (strLine.Trim() <> Nothing) And (Not strLine.Trim().StartsWith("//")) Then
                    asAppSettings.BadComments.Add(strLine)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Friend Sub CheckCode(CodeLine As String, FileName As String)
        ' Scan line of code for anything requiring attention and return results
        '======================================================================

        Dim intIndex As Integer
        Dim strCleanName As String = ""
        Dim strTidyFuncName As String = ""

        '== Locate any unsafe functions for the language in question ==
        If asAppSettings.BadFunctions.Count > 0 Then
            For intIndex = 0 To asAppSettings.BadFunctions.Count - 1

                '== Sanitise the expression ready for insertion into regex ==
                strTidyFuncName = asAppSettings.BadFunctions(intIndex).FunctionName.Trim

                '== Important - comparison MUST be case-sensitive for everything except PL/SQL, where it MUST be case-insenstive ==
                If asAppSettings.TestType = AppSettings.SQL Then strTidyFuncName = strTidyFuncName.ToUpper

                '== Add word boundaries ONLY IF the expression does not contain whitespace or dots ==
                If ((Not Regex.IsMatch(strTidyFuncName, "\s+")) And (Not strTidyFuncName.Contains("."))) Then strCleanName = "\b" & Regex.Escape(strTidyFuncName) & "\b"

                '== Important - comparison MUST be case-sensitive for everything except PL/SQL, where it MUST be case-insenstive ==
                If asAppSettings.TestType = AppSettings.SQL Then
                    'TODO: Fix the cast so it will be a string
                    If (strCleanName <> "" And Regex.IsMatch(CodeLine.ToUpper, strCleanName)) Or (strCleanName = "" And CodeLine.ToUpper.Contains(CType(asAppSettings.BadFunctions(intIndex).FunctionName.toupper, String))) Then
                        overFlowArg = New CheckOverFlowArg(asAppSettings.BadFunctions(intIndex).FunctionName, asAppSettings.BadFunctions(intIndex).Description, FileName, asAppSettings.BadFunctions(intIndex).Severity, CodeLine)
                    End If
                Else
                    'If CodeLine.Contains(asAppSettings.BadFunctions(intIndex).FunctionName) Then
                    'TODO: Fix the cast so it will be a string
                    If (strCleanName <> "" And Regex.IsMatch(CodeLine, strCleanName)) Or (strCleanName = "" And CodeLine.Contains(CType(asAppSettings.BadFunctions(intIndex).FunctionName, String))) Then
                        overFlowArg = New CheckOverFlowArg(strTidyFuncName, asAppSettings.BadFunctions(intIndex).Description, FileName, asAppSettings.BadFunctions(intIndex).Severity, CodeLine)
                    End If
                End If
                strCleanName = ""
            Next intIndex
        End If

        '== Only carry out further code checks if required by user ==
        If asAppSettings.IsConfigOnly = False Then

            '== Carry out any language-specific tests ==
            Select Case asAppSettings.TestType
                Case AppSettings.C
                    CheckCPPCode(CodeLine, FileName)
                Case AppSettings.JAVA
                    CheckJavaCode(CodeLine, FileName)
                Case AppSettings.SQL
                    CheckPLSQLCode(CodeLine.ToUpper, FileName)
                Case AppSettings.CSHARP
                    CheckCSharpCode(CodeLine, FileName)
                Case AppSettings.VB
                    CheckVBCode(CodeLine, FileName)
                Case AppSettings.PHP
                    CheckPHPCode(CodeLine, FileName)
                Case AppSettings.COBOL
                    CheckCobolCode(CodeLine, FileName)
                Case AppSettings.R
                    CheckRCode(CodeLine, FileName)
            End Select

            '== Check for possible hard-coded passwords ==
            If CodeLine.ToLower().Contains("password ") And (InStr(CodeLine.ToLower(), "password") < InStr(CodeLine, "= """)) And Not (CodeLine.Contains("''") Or CodeLine.Contains("""""")) Then
                overFlowArg = New CheckOverFlowArg("Code Appears to Contain Hard-Coded Password", "The code may contain a hard-coded password which an attacker could obtain from the source or by dis-assembling the executable. Please manually review the code:", FileName, CodeIssue.MEDIUM, CodeLine)
            End If
        End If

    End Sub
    Friend Function GetVarName(CodeLine As String, Optional SplitOnEquals As Boolean = False) As String
        ' Extract the variable name from a line of code
        '==============================================
        Dim strVarName As String = ""
        Dim arrFragments As String()


        If CodeLine.Contains("=") Or SplitOnEquals Then
            arrFragments = CodeLine.Trim.Split("=")
            strVarName = arrFragments.First
        Else
            arrFragments = CodeLine.Trim.Split(";")
            strVarName = arrFragments.First
        End If

        strVarName = GetLastItem(strVarName)

        '== Be careful of anything which may break the regex ==
        strVarName = strVarName.TrimStart("(").Trim()
        strVarName = strVarName.TrimEnd(")").Trim()

        If asAppSettings.TestType = AppSettings.PHP Then strVarName = "\" & strVarName

        Return strVarName

    End Function

    Friend Function GetLastItem(ListString As String, Optional Separator As String = " ") As String
        'Split string on specified character (default: space) and return last item
        '=========================================================================
        Dim strRetVal As String = ""
        Dim arrStrings As String()

        ListString = ListString.Trim()

        Select Case Separator
            Case " "
                ' This regex prevents a split on space from returning empty strings
                arrStrings = Regex.Split(ListString, "\s+")
            Case Else
                arrStrings = ListString.Split(Separator)
        End Select

        ' Return final item
        strRetVal = arrStrings.Last.Trim

        Return strRetVal

    End Function

    Friend Function GetFirstItem(ListString As String, Optional Separator As String = " ") As String
        'Split string on specified character (default: space) and return first item
        '=========================================================================
        Dim strRetVal As String = ""
        Dim arrStrings As String()

        ListString = ListString.Trim()

        Select Case Separator
            Case " "
                ' This regex prevents a split on space from returning empty strings
                arrStrings = Regex.Split(ListString, "\s+")
            Case Else
                arrStrings = ListString.Split(Separator)
        End Select

        ' Return first item
        strRetVal = arrStrings.First.Trim

        Return strRetVal

    End Function


End Module

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
Imports System.Reflection
Imports System.Text.RegularExpressions

Public Module modMain

    '== Array to be used when sorting on multiple coilumns ==
    Public dicColumns As New Dictionary(Of String, Integer)

    '== Class instance to hold app settings ==
    Public asAppSettings As New AppSettings

    '== Class instances to track details of file/code scanning operations ==
    Public ctCodeTracker As New CodeTracker
    Public rtResultsTracker As New ResultsTracker

    '== Used for sharing data between main chart and individual charts ==
    Public strCurrentFileName As String = ""
    Public intComments As Integer = 0
    Public intCodeIssues As Integer = 0

    '== Placeholder to be used when modifying severity levels ==
    Public intNewSeverity As Integer = -1

    Public Function ParseArgs(arrArgs As IEnumerable(Of String)) As Integer
        ' Read any command line args and start application as appropriate
        '================================================================
        Dim intIndex = 0
        Dim exportFlagSet = False
        Dim showHelpAndExit = False

        '== Deal with any command line options ==
        If arrArgs.Count <> 1 Then
            intIndex = 1

            While intIndex < arrArgs.Count AndAlso Not showHelpAndExit

                Select Case arrArgs(intIndex)

                    Case "-t", "--target"
                        ' Set target
                        intIndex += 1
                        If intIndex < arrArgs.Count Then
                            rtResultsTracker.TargetDirectory = arrArgs(intIndex)

                            If String.IsNullOrWhiteSpace(rtResultsTracker.TargetDirectory) Then
                                LogError("No target specified (-t)")
                                showHelpAndExit = True
                            ElseIf Not Directory.Exists(rtResultsTracker.TargetDirectory) Then
                                LogError("Target does not exist: {0}", rtResultsTracker.TargetDirectory)
                                showHelpAndExit = True
                            End If
                        Else
                            LogError("No target specified (-t)")
                            showHelpAndExit = True
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
                        If intIndex < arrArgs.Count Then
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
                            asAppSettings.OutputFile = arrArgs(intIndex) 'TODO: Fix this code to support any location and not only relative to the running app on Windows and on Linux e.g. App is in C:\VCG and output is in D:\VCG\out.txt
                            asAppSettings.IsOutputFile = True
                            exportFlagSet = True
                        Else
                            LogError("No results filename provided (-r)")
                            showHelpAndExit = True
                        End If

                    Case "-c", "--console"
#If WINDOWS Then
                        AttachProcessToConsole()
#End If
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

        'TODO: All the logic from here on should be taken out and be handled by the consumer and not by the LIB?
        If showHelpAndExit Then
            Dim strHelp = HelpText()
            '#If CONSOLE Then
            If asAppSettings.IsConsole Then
                LogBlank(strHelp)
            Else
                '#ElseIf WINDOWS Then
#If FIX_ME Then
                'MessageBox.Show(strHelp, "Help", MessageBoxButtons.OK)
#End If
            End If
            '#End If

            Return EXIT_CODE
        End If

        If asAppSettings.IsConsole Then
            If Not exportFlagSet Then
                LogError("ERROR: No output flag set (i.e. XML, CSV, Flat), so no results will be generated. Exiting...")
                Return EXIT_CODE
            End If
            'frmMain.Hide() 'This is the responsability of who ever is calling the windows or console application
        End If

        Return intIndex

    End Function



    Private Function HelpText()
        ' Display help and show usage
        '============================

        Return "Visual Code Grepper (VCG) 2.0 (C) Nick Dunn And John Murray, 2012-2014.
            Visual Code Grepper (VCG) 2.0 (C) RandallFlagg O@G, 2023.
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

        Select Case NewLanguage.ToUpper
            Case "C", "C++", "CPP"
                asAppSettings.TestType = Language.C
            Case "JAVA"
                asAppSettings.TestType = Language.JAVA
            Case "PL/SQL", "PLSQL", "SQL"
                asAppSettings.TestType = Language.SQL
            Case "C#", "C-SHARP", "CS", "CSHARP"
                asAppSettings.TestType = Language.CSHARP
            Case "VB", "VISUALBASIC", "VISUAL-BASIC"
                asAppSettings.TestType = Language.VB
            Case "PHP"
                asAppSettings.TestType = Language.PHP
            Case "COBOL"
                asAppSettings.TestType = Language.COBOL
            Case "R"
                asAppSettings.TestType = Language.R
            Case Else
                blnRetVal = False
        End Select

        Return blnRetVal

    End Function

    'TODO: DELETE this method
    Private Sub LaunchNPP_ORIG(FileName As String, Optional LineNumber As Integer = 1)
        ' Launch NPP if available, launch Notepad if not
        '===============================================

        Try
            ' If we're trying to open a file on a specific line in Notepad++ then the filename *must* be quoted to avoid erratic behaviour from Windows
            System.Diagnostics.Process.Start("notepad++.exe", $"-n{LineNumber} ""{FileName}""")
        Catch ex As Exception
            System.Diagnostics.Process.Start("Notepad.exe", """" & FileName & """")
        End Try

    End Sub

    Public Sub LaunchNPP(FileName As String, Optional LineNumber As Integer = 1)
        If asAppSettings.TestType <> FileName Then
            Throw New Exception("Why Like this? Check me please and understand what is the right behaviour")
        End If

        LaunchNPP()
    End Sub

    Public Sub LaunchNPP(Optional LineNumber As Integer = 1)
        ' Launch NPP if available, launch Notepad if not
        '===============================================
        Dim FileName ' As String
        Select Case asAppSettings.TestType
            Case Language.C
                FileName = asAppSettings.CConfFile
            Case Language.JAVA
                FileName = asAppSettings.JavaConfFile
            Case Language.SQL
                FileName = asAppSettings.PLSQLConfFile
            Case Language.CSHARP
                FileName = AppSettings.CSharpConfFile
            Case Language.PHP
                FileName = asAppSettings.PHPConfFile
            Case Language.VB
                FileName = asAppSettings.VBConfFile
            Case Language.COBOL
                FileName = asAppSettings.COBOLConfFile
            Case Language.R
                FileName = asAppSettings.RConfFile
            Case Else
                Exit Sub
        End Select

        Try
            ' If we're trying to open a file on a specific line in Notepad++ then the filename *must* be quoted to avoid erratic behaviour from Windows
            Process.Start("notepad++.exe", $"-n{LineNumber} ""{FileName}""")
        Catch ex As Exception
            Process.Start("Notepad.exe", """" & FileName & """")
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


    Private Sub SetSuffixes(lang As Integer)
        ' Set the filetypes to scan
        '==========================

        asAppSettings.IsAllFileTypes = False

        '== Check if wildcard/all files has been specified == 
        If asAppSettings.CSuffixes.Contains(".*") Or asAppSettings.CSuffixes.Trim = "" Then
            asAppSettings.IsAllFileTypes = True
        Else
            Select Case lang
                Case Language.C
                    asAppSettings.FileSuffixes = asAppSettings.CSuffixes.Split("|")
                Case Language.JAVA
                    asAppSettings.FileSuffixes = asAppSettings.JavaSuffixes.Split("|")
                Case Language.SQL
                    asAppSettings.FileSuffixes = asAppSettings.PLSQLSuffixes.Split("|")
                Case Language.CSHARP
                    asAppSettings.FileSuffixes = asAppSettings.CSharpSuffixes.Split("|")
                Case Language.VB
                    asAppSettings.FileSuffixes = asAppSettings.VBSuffixes.Split("|")
                Case Language.PHP
                    asAppSettings.FileSuffixes = asAppSettings.PHPSuffixes.Split("|")
                Case Language.COBOL
                    asAppSettings.FileSuffixes = asAppSettings.COBOLSuffixes.Split("|")
                Case Language.R
                    asAppSettings.FileSuffixes = asAppSettings.RSuffixes.Split("|")
            End Select

            asAppSettings.NumSuffixes = asAppSettings.FileSuffixes.Length - 1
        End If

    End Sub

    Public Sub SelectLanguage(mode As IAppMode, lang As Integer)
        ' Set language and characteristics 
        '=================================

        ' Set language type
        asAppSettings.TestType = lang

        '== Set the file types/suffixes for the chosen language ==
        SetSuffixes(lang)

        ' This covers most languages - the different ones will be set individually, below
        asAppSettings.SingleLineComment = "//"
        asAppSettings.AltSingleLineComment = ""

        ' Load list of unsafe functions
        'TODO: Change to the following code instead of the rest of this sub: LoadUnsafeFunctionList(mode, lang)
        Select Case lang
            Case Language.C
                asAppSettings.BadFuncFile = asAppSettings.CConfFile
                LoadUnsafeFunctionList(mode, Language.C)
            Case Language.JAVA
                asAppSettings.BadFuncFile = asAppSettings.JavaConfFile
                LoadUnsafeFunctionList(mode, Language.JAVA)
            Case Language.SQL
                asAppSettings.BadFuncFile = asAppSettings.PLSQLConfFile
                LoadUnsafeFunctionList(mode, Language.SQL)
                asAppSettings.SingleLineComment = "--"
            Case Language.CSHARP
                asAppSettings.BadFuncFile = AppSettings.CSharpConfFile
                LoadUnsafeFunctionList(mode, Language.CSHARP)
            Case Language.VB
                asAppSettings.BadFuncFile = asAppSettings.VBConfFile
                LoadUnsafeFunctionList(mode, Language.VB)
                asAppSettings.SingleLineComment = "'"
                asAppSettings.AltSingleLineComment = "REM"
            Case Language.PHP
                asAppSettings.BadFuncFile = asAppSettings.PHPConfFile
                LoadUnsafeFunctionList(mode, Language.PHP)
                asAppSettings.SingleLineComment = "//"
                asAppSettings.AltSingleLineComment = "\#"   ' This will be used in a regex so it must be escaped
            Case Language.COBOL
                asAppSettings.BadFuncFile = asAppSettings.COBOLConfFile
                LoadUnsafeFunctionList(mode, Language.COBOL)
                asAppSettings.SingleLineComment = "*"
                asAppSettings.AltSingleLineComment = "\/"   ' This will be used in a regex so it must be escaped
            Case Language.R
                asAppSettings.BadFuncFile = asAppSettings.RConfFile
                LoadUnsafeFunctionList(mode, Language.R)
                asAppSettings.SingleLineComment = "#"
        End Select

    End Sub

    Public Sub LoadUnsafeFunctionList(mode As IAppMode, CurrentLanguage As Integer) 'TODO: Change this to private
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
                Case Language.C
                    asAppSettings.BadFuncFile = "config\cppfunctions.conf"'Path.Combine(asAppSettings.ApplicationDirectory, "config\cppfunctions.conf")
                Case Language.JAVA
                    asAppSettings.BadFuncFile = Path.Combine(AppSettings.ConfigPath, "javafunctions.conf")
                Case Language.SQL
                    asAppSettings.BadFuncFile = Path.Combine(AppSettings.ConfigPath, "plsqlfunctions.conf")
                Case Language.CSHARP
                    asAppSettings.BadFuncFile = Path.Combine(AppSettings.ConfigPath, AppSettings.CSharpConfFile)
                Case Language.VB
                    asAppSettings.BadFuncFile = Path.Combine(AppSettings.ConfigPath, "vbfunctions.conf")
                Case Language.PHP
                    asAppSettings.BadFuncFile = Path.Combine(AppSettings.ConfigPath, "phpfunctions.conf")
                Case Language.COBOL
                    asAppSettings.BadFuncFile = Path.Combine(AppSettings.ConfigPath, "cobolfunctions.conf")
                Case Language.R
                    asAppSettings.BadFuncFile = Path.Combine(AppSettings.ConfigPath, "rfunctions.conf")
            End Select

            If Not File.Exists(asAppSettings.BadFuncFile) Then
                DisplayError(mode, $"The config file {asAppSettings.BadFuncFile} wasn't found for bad functions.", "Error", MsgBoxStyle.Critical) 'TODO: Check how it looks in Windows
            End If

        End If
        'TODO: When do we get here?
        'Throw New Exception("How did we get here? Do we need this path?")
        If Not File.Exists(asAppSettings.BadFuncFile) Then
            Throw New Exception($"The file {asAppSettings.BadFuncFile} doesn't exist. Please fix and run again.")
        End If

        Try
            For Each strLine In File.ReadLines(asAppSettings.BadFuncFile)

                ' Check for comments/whitespace
                'TODO: Rewrite the condition with String.IsNullOrWhitespace
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
            DisplayError(mode, ex.ToString) 'TODO: Check how it looks in Windows
        End Try


        ' Fix to stop temp content being wiped at start of scan
        If asAppSettings.TempGrepText <> "" Then
            SharedCode.LoadTempGrepContent(mode, asAppSettings.TempGrepText)
        End If

    End Sub

    Public Sub LoadBadComments(mode As IAppMode)
        ' Get list of bad comments from config file
        '==========================================

        Try
            For Each strLine In File.ReadLines(AppSettings.BadCommentFilePath)

                ' Check for comments/whitespace
                If (strLine.Trim() <> Nothing) And (Not strLine.Trim().StartsWith("//")) Then
                    asAppSettings.BadComments.Add(strLine)
                End If
            Next
        Catch ex As Exception
            DisplayError(mode, ex.ToString)
        End Try

    End Sub

    Public Function ScanLine(mode As IAppMode, CommentScan As Boolean, CodeScan As Boolean, CodeLine As String, FileName As String, Comment As String, ByRef IsColoured As Boolean) As Boolean
        If (mode Is Nothing) Then Throw New Exception("mode must be initialized")
        ' Split the line into comments and code before carrying out the relevant checks
        ' N.B. - InStr has been used as Split requires a single character
        '==============================================================================

        Dim strCode As String = ""
        Dim strComment As String = ""

        Dim blnRetVal As Boolean = False

        Dim arrSubStrings() As String = {}
        Dim arrTemp() As String = {}

        Dim intPos As Integer


        '== Split line into comments and code ==
        If Comment = "both" Then
            intPos = InStr(CodeLine, asAppSettings.BlockStartComment)
            arrSubStrings = {CodeLine.Substring(0, intPos - 1), CodeLine.Substring(intPos + 1)}
            intPos = InStr(arrSubStrings(1), asAppSettings.BlockEndComment)
            arrTemp = {arrSubStrings(1).Substring(0, intPos - 1), arrSubStrings(1).Substring(intPos + 1)}
        Else
            intPos = InStr(CodeLine, Comment)
            If CodeLine.Length > intPos Then
                arrSubStrings = {CodeLine.Substring(0, intPos - 1), CodeLine.Substring(intPos + Comment.Length - 1)}
            Else
                arrSubStrings = {CodeLine.Substring(0, intPos - 1), ""}
            End If
        End If

        '== The position of code and comments in the array depends on type of comment ==
        If Comment = asAppSettings.SingleLineComment Or Comment = asAppSettings.BlockStartComment Then
            strCode = arrSubStrings(0).Trim()
            strComment = arrSubStrings(1).Trim()
        ElseIf Comment = asAppSettings.BlockEndComment Then
            strCode = arrSubStrings(1).Trim()
            strComment = arrSubStrings(0).Trim()
        ElseIf Comment = "both" Then
            strCode = arrSubStrings(0).Trim() + arrTemp(1).Trim()
            strComment = arrSubStrings(1).Trim()
        End If

        '== Check comment content ==
        If CommentScan And strComment.Length > 0 Then blnRetVal = mode.CheckComment(strComment, FileName, IsColoured)

        '== Scan code for dangerous functions ==
        If CodeScan And strCode.Length > 0 Then CheckCode(strCode, FileName)

        Return blnRetVal

    End Function

    Public Sub CheckCode(CodeLine As String, FileName As String)
        ' Scan line of code for anything requiring attention and return results
        '======================================================================

        '== Locate any unsafe functions for the language in question ==
        If asAppSettings.BadFunctions.Count > 0 Then
            For intIndex = 0 To asAppSettings.BadFunctions.Count - 1
                Dim strTidyFuncName As String
                Dim strCleanName As String = "" 'TODO: Change to Nothing?

                '== Sanitise the expression ready for insertion into regex ==
                strTidyFuncName = asAppSettings.BadFunctions(intIndex).FunctionName.Trim

                '== Important - comparison MUST be case-sensitive for everything except PL/SQL, where it MUST be case-insenstive ==
                If asAppSettings.TestType = Language.SQL Then strTidyFuncName = strTidyFuncName.ToUpper

                '== Add word boundaries ONLY IF the expression does not contain whitespace or dots ==
                If ((Not Regex.IsMatch(strTidyFuncName, "\s+")) And (Not strTidyFuncName.Contains("."))) Then strCleanName = "\b" & Regex.Escape(strTidyFuncName) & "\b"

                '== Important - comparison MUST be case-sensitive for everything except PL/SQL, where it MUST be case-insenstive ==
                If asAppSettings.TestType = Language.SQL Then
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
        If Not asAppSettings.IsConfigOnly Then
            'TODO: Write this the OOP way
            '== Carry out any language-specific tests ==
            Select Case asAppSettings.TestType
                Case Language.C
                    CheckCPPCode(CodeLine, FileName)
                Case Language.JAVA
                    CheckJavaCode(CodeLine, FileName)
                Case Language.SQL
                    CheckPLSQLCode(CodeLine.ToUpper, FileName)
                Case Language.CSHARP
                    CheckCSharpCode(CodeLine, FileName)
                Case Language.VB
                    CheckVBCode(CodeLine, FileName)
                Case Language.PHP
                    CheckPHPCode(CodeLine, FileName)
                Case Language.COBOL
                    CheckCobolCode(CodeLine, FileName)
                Case Language.R
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

        If asAppSettings.TestType = Language.PHP Then strVarName = "\" & strVarName

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

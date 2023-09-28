Imports System.IO
Imports System.Net.Mime.MediaTypeNames
Imports VisualCodeGrepper.NETCore.Lib

Class Program
    Implements IAppMode

    Friend Sub LoadFiles(targetFolder As String, clearPrevious As Boolean) Implements IAppMode.LoadFiles
        'Private Sub LoadFiles(ByVal TargetFolder As String, Optional ByVal ClearPrevious As Boolean = True)
        'Load files to be scanned
        '========================
        Dim objResults As Object
        Dim intIndex As Integer
        Dim intFileCount As Integer = 0
        Dim intPreviousDirCount = 0
        Dim blnIsPrevious = False

        'If TargetFolder.Count = 0 Then Exit Sub

        targetFolder = targetFolder.Trim

        If targetFolder = "" Or targetFolder = rtResultsTracker.TargetDirectory Then Exit Sub
        'TODO: Check what happens beyond this point as curentlly the codes exits because of the if above
        Try
            ' Check whether we have a file or directory
            If Directory.Exists(targetFolder) Then
                ' Iterate through files from target directory and obtain all relevant filenames
                objResults = Directory.EnumerateFiles(targetFolder, "*.*", SearchOption.AllDirectories)

                Dim lstResults As List(Of String) = New List(Of String)(Directory.EnumerateFiles(targetFolder, "*.*", SearchOption.AllDirectories))

                Console.WriteLine("Loading files from target directory...")
                Console.WriteLine()
            Else
                objResults = New Collection From {
                    targetFolder
                }
            End If

            For Each objTargetFile In objResults
                If asAppSettings.IsAllFileTypes Or CheckFileType(objTargetFile) = True Then
                    rtResultsTracker.FileList.Add(objTargetFile)

                    If asAppSettings.IsVerbose = True Then
                        Console.WriteLine("Checking file: " & objTargetFile)
                    End If

                End If
            Next


            Console.WriteLine()
            Console.WriteLine("Loaded " & rtResultsTracker.FileList.Count & " files from target directory.")
            Console.WriteLine()



            If rtResultsTracker.FileList.Count = 0 Then
                DisplayError("No target files for the selected language could be found in this location", "Error", MsgBoxStyle.Exclamation)
            End If

        Catch exError As Exception
            DisplayError(exError.Message, "Error", MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub IAppMode_ScanFiles(CommentScan As Boolean, CodeScan As Boolean) Implements IAppMode.ScanFiles
        ' Iterate through the files in the directory and compile the results
        '===================================================================

        Dim arrShortName() As String
        Dim strLine As String
        Dim strTrimmedComment = ""

        Dim blnIsCommented As Boolean = False
        Dim blnIsColoured As Boolean = False

        Dim swOutputFile As StreamWriter


        If (CommentScan = False And CodeScan = False) Then Exit Sub

        ' Initialise variables before proceeding
        rtResultsTracker.Reset()

        LogInfo("Running scans...")



        '== Open output files as required ==
        If asAppSettings.IsOutputFile Then
            swOutputFile = New StreamWriter(asAppSettings.OutputFile)
        End If

        ' Ensure progress is reported correctly.
        'frmLoading.pbProgressBar.Value = 0 'TODO: Do something also for console

        '== Iterate through files in selected directory and perform selected scans ==
        If rtResultsTracker.FileList.Count <> Nothing Then

            If asAppSettings.AltSingleLineComment.StartsWith("\") Then
                strTrimmedComment = asAppSettings.AltSingleLineComment.TrimStart("\")
            End If

            ctCodeTracker.ResetCDictionaries()

            For Each strItem As String In rtResultsTracker.FileList

                If asAppSettings.AbortCurrentOperation Then
                    asAppSettings.AbortCurrentOperation = False
                    Console.WriteLine("Operation aborted. The results shown may be incomplete.")
                    Exit For
                End If

                ' Check that file is valid and exists 
                ' This covers a potential issue when user selects a previously scanned file from dropdown list that no longer exists
                If (File.Exists(strItem) <> True) Then Continue For

                arrShortName = strItem.Split("\")
                modMain.ctCodeTracker.Reset()

                ' Check for php.ini file and handle this separately
                If (asAppSettings.TestType = AppSettings.PHP And arrShortName.Last.ToLower() = "php.ini") And asAppSettings.IsConfigOnly = False Then

                    ctCodeTracker.HasDisableFunctions = False

                    For Each strLine In File.ReadAllLines(strItem)
                        CheckPhpIni(strLine, strItem)
                    Next

                    If ctCodeTracker.HasDisableFunctions = True Then
                        Throw New NotImplementedException
                        'TODO: This code was created to help seperate the gui and is implementing events. Need to register also in this console app for the events.
                        'ListCodeIssue(Me, New CheckOverFlowArg("Failure to use 'disable_functions'", "The ini file fails to use the 'disable_functions' feature, greatly increasing the segverity of a successful compromise.", strItem))
                    End If


                Else

                    rtResultsTracker.LineCount = 0

                    ' Otherwise split the line into code and comments and scan each part
                    For Each strLine In File.ReadAllLines(strItem)

                        rtResultsTracker.OverallLineCount += 1
                        rtResultsTracker.LineCount += 1

                        '== If this is a COBOL program then we need to trim the specified number of characters from start of line ==
                        '== These represent line numbers, name of copybook, etc. ==
                        If asAppSettings.TestType = AppSettings.COBOL And asAppSettings.COBOLStartColumn > 1 Then
                            If asAppSettings.COBOLStartColumn > strLine.Length Then
                                strLine = ""
                            Else
                                strLine = strLine.Substring(asAppSettings.COBOLStartColumn - 1, strLine.Length - asAppSettings.COBOLStartColumn + 1)
                            End If
                        End If

                        If strLine.Trim() <> "" Then            ' Check that it's not a blank line
                            Dim strScanResult As String
                            If blnIsCommented = False Then      ' Check whether we're already inside a comment block

                                ' Multiple conditions for single line comments.
                                ' A lot of the difficulties caused by VB, COBOL and PHP which have two types of single line comment 
                                ' and VB/COBOL which have no multiple line comment.

                                If asAppSettings.TestType = AppSettings.COBOL And (strLine.Substring(0, 1) = asAppSettings.SingleLineComment) Then
                                    ' COBOL's system for whole-line comments is simpler than other languages
                                    strScanResult = ScanLine(CommentScan, CodeScan, strLine, strItem, asAppSettings.SingleLineComment, blnIsColoured)
                                ElseIf asAppSettings.TestType = AppSettings.COBOL And (strLine.Substring(0, 1) = strTrimmedComment And asAppSettings.IsZOS) Then
                                    ' COBOL's system for whole-line comments is simpler than other languages. IBM allows single line comments with '/'
                                    strScanResult = ScanLine(CommentScan, CodeScan, strLine, strItem, strTrimmedComment, blnIsColoured)
                                ElseIf asAppSettings.TestType = AppSettings.COBOL Then
                                    ' If line of COBOL has no comment in column 1, then it's all code
                                    rtResultsTracker.OverallCodeCount += 1
                                    rtResultsTracker.CodeCount += 1
                                    CheckCode(strLine, strItem)
                                ElseIf ((strLine.Contains(asAppSettings.SingleLineComment) And asAppSettings.SingleLineComment = "//" And Not strLine.ToLower.Contains("http:" + asAppSettings.SingleLineComment))) _
                                    Or (asAppSettings.TestType = AppSettings.R And strLine.Contains(asAppSettings.SingleLineComment)) _
                                    Or (asAppSettings.TestType = AppSettings.SQL And strLine.Contains(asAppSettings.SingleLineComment)) Or (asAppSettings.TestType = AppSettings.VB And strLine.Contains(asAppSettings.SingleLineComment) And Not (strLine.Contains(""""c) And (InStr(strLine, """") < InStr(strLine, "'")))) Then
                                    strScanResult = ScanLine(CommentScan, CodeScan, strLine, strItem, asAppSettings.SingleLineComment, blnIsColoured)

                                ElseIf ((Not asAppSettings.TestType = AppSettings.VB And Not asAppSettings.TestType = AppSettings.COBOL And Not asAppSettings.TestType = AppSettings.R) And (strLine.Contains(asAppSettings.BlockStartComment) And strLine.Contains(asAppSettings.BlockEndComment)) And (InStr(strLine, asAppSettings.BlockStartComment) < InStr(strLine, asAppSettings.BlockEndComment)) And Not (strLine.Contains("/*/"))) Then
                                    strScanResult = ScanLine(CommentScan, CodeScan, strLine, strItem, "both", blnIsColoured)
                                ElseIf (Not asAppSettings.TestType = AppSettings.VB And Not asAppSettings.TestType = AppSettings.COBOL And Not asAppSettings.TestType = AppSettings.R) And (strLine.Contains(asAppSettings.BlockStartComment) And Not (strLine.Contains("/*/")) And Not (strLine.Contains("print") And (InStr(strLine, asAppSettings.BlockStartComment) > InStr(strLine, "print")))) Then
                                    blnIsCommented = True
                                    strScanResult = ScanLine(CommentScan, CodeScan, strLine, strItem, asAppSettings.BlockStartComment, blnIsColoured)
                                Else
                                    rtResultsTracker.OverallCodeCount += 1
                                    rtResultsTracker.CodeCount += 1

                                    ' Scan code for dangerous functions
                                    CheckCode(strLine, strItem)
                                End If

                            ElseIf (Not asAppSettings.TestType = AppSettings.VB And Not asAppSettings.TestType = AppSettings.COBOL And Not asAppSettings.TestType = AppSettings.R) And strLine.Contains(asAppSettings.BlockEndComment) Then    ' End of a comment block
                                blnIsCommented = False
                                strScanResult = ScanLine(CommentScan, CodeScan, strLine, strItem, asAppSettings.BlockEndComment, blnIsColoured)
                            Else
                                rtResultsTracker.CommentCount += 1
                                rtResultsTracker.OverallCommentCount += 1
                            End If

                        Else
                            '== If we have whitespace then add it to the whitespace count ==
                            rtResultsTracker.OverallWhitespaceCount += 1
                            rtResultsTracker.WhitespaceCount += 1
                        End If
                    Next

                    '== List any file-level code issues (mis-matched deletes, mallocs, etc.) ==
                    If (asAppSettings.TestType = AppSettings.C Or asAppSettings.TestType = AppSettings.JAVA Or asAppSettings.TestType = AppSettings.COBOL) Then
                        Throw New NotImplementedException
                        'CheckFileLevelIssues(strItem) 'TODO: Interface
                    End If
                End If

                rtResultsTracker.FileCount += 1

            Next
        End If

        ' Blank line so incrementing lines get a \n
        LogInfo("")

        '== Close output files if required ==
        If asAppSettings.IsOutputFile Then swOutputFile.Close()

        '== Export CSV results if required ==
        If asAppSettings.IsCsvOutputFile Then
            Throw New NotImplementedException
            'TODO: Currentlly do an interface hack
            'ExportResultsCSV(intFilterMin, intFilterMax, asAppSettings.CsvOutputFile) 'TODO: Unify with the terminal version
        End If

        '== Export XML results if required ==
        If asAppSettings.IsXmlOutputFile Then
            Throw New NotImplementedException
            'TODO: Currentlly do an interface hack
            'ExportResultsXML(intFilterMin, intFilterMax, asAppSettings.XmlOutputFile) 'TODO: Unify with the terminal version
        End If

        If asAppSettings.IsConsole Then
            LogInfo("Finished scanning...")
            LogInfo("Closing VCG.")
        End If

    End Sub

    Public Sub DisplayError(exception As Exception, Optional Caption As String = "Error", Optional MsgBoxStyle As Integer = 64) Implements IAppMode.DisplayError
        ' Display error message to user, depending on GUI/Console mode
        '=============================================================

        LogError($"{exception}")
        DisplayError(exception.Message, Caption, MsgBoxStyle) 'TODO: Only Forms?
    End Sub

    Public Sub DisplayError(message As String, Optional Caption As String = "Error", Optional MsgBoxStyle As Integer = 64) Implements IAppMode.DisplayError
        ' Display error message to user, depending on GUI/Console mode
        '=============================================================

        LogError(message)
        MsgBox(message, MsgBoxStyle, Caption) 'TODO: Only Forms?
    End Sub

    Public Function ScanLine(CommentScan As Boolean, CodeScan As Boolean, CodeLine As String, FileName As String, Comment As String, ByRef IsColoured As Boolean) As Boolean
        Throw New NotImplementedException
    End Function
End Class
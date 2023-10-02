Imports System.Drawing
Imports System.IO
Imports System.Text.RegularExpressions
Imports VisualCodeGrepper.NETCore.Lib

Class Program
    Implements IAppMode
    Implements IDisposable

    Private _swOutputFile As StreamWriter 'TODO: Check if we cn get rid of this and put it inside a method
    Private disposedValue As Boolean

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

        If targetFolder = "" Or targetFolder = rtResultsTracker.TargetDirectory Then
            'TODO: If we are comming to here again what should happen?
            'Exit Sub
        End If
        'TODO: Check what happens beyond this point as curentlly the codes exits because of the if above
        Try
            ' Check whether we have a file or directory
            If Directory.Exists(targetFolder) Then
                ' Iterate through files from target directory and obtain all relevant filenames
                objResults = Directory.EnumerateFiles(targetFolder, "*.*", SearchOption.AllDirectories)

                'Dim lstResults As List(Of String) = New List(Of String)(Directory.EnumerateFiles(targetFolder, "*.*", SearchOption.AllDirectories))

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

    'TODO: This is a classic OOP pattern and it should be implemented for each language type.
    'TODO: The languages scan should be inherited and implemented OOP style.
    Public Sub IAppMode_ScanFiles(CommentScan As Boolean, CodeScan As Boolean) Implements IAppMode.ScanFiles
        ' Iterate through the files in the directory and compile the results
        '===================================================================

        'Dim arrShortName() As String
        Dim strLine As String
        Dim strTrimmedComment = ""

        Dim blnIsCommented As Boolean = False
        Dim blnIsColoured As Boolean = False

        If (CommentScan = False And CodeScan = False) Then Exit Sub

        ' Initialise variables before proceeding
        rtResultsTracker.Reset()

        LogInfo("Running scans...")

        '== Open output files as required ==
        If asAppSettings.IsOutputFile Then
            _swOutputFile = New StreamWriter(asAppSettings.OutputFile)
        End If

        ' Ensure progress is reported correctly.
        'frmLoading.pbProgressBar.Value = 0 'TODO: Do something also for console

        '== Iterate through files in selected directory and perform selected scans ==
        If rtResultsTracker.FileList.Count <> Nothing Then
            'TODO: Check what this code does
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

                Dim arrShortName = strItem.Split("\")
                modMain.ctCodeTracker.Reset()

                ' Check for php.ini file and handle this separately
                If (asAppSettings.TestType = Language.PHP And arrShortName.Last.ToLower() = "php.ini") And asAppSettings.IsConfigOnly = False Then

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
                        If asAppSettings.TestType = Language.COBOL And asAppSettings.COBOLStartColumn > 1 Then
                            If asAppSettings.COBOLStartColumn > strLine.Length Then
                                strLine = ""
                            Else
                                strLine = strLine.Substring(asAppSettings.COBOLStartColumn - 1, strLine.Length - asAppSettings.COBOLStartColumn + 1)
                            End If
                        End If

                        ' Check that it's not a blank line
                        If strLine.Trim() <> "" Then 'TODO: Change to String.IsNullOrWhiteSpace?
                            Dim strScanResult As String
                            If Not blnIsCommented Then      ' Check whether we're already inside a comment block

                                ' Multiple conditions for single line comments.
                                ' A lot of the difficulties caused by VB, COBOL and PHP which have two types of single line comment 
                                ' and VB/COBOL which have no multiple line comment.

                                If asAppSettings.TestType = Language.COBOL And (strLine.Substring(0, 1) = asAppSettings.SingleLineComment) Then
                                    ' COBOL's system for whole-line comments is simpler than other languages
                                    strScanResult = ScanLine(Me, CommentScan, CodeScan, strLine, strItem, asAppSettings.SingleLineComment, blnIsColoured)
                                ElseIf asAppSettings.TestType = Language.COBOL And (strLine.Substring(0, 1) = strTrimmedComment And asAppSettings.IsZOS) Then
                                    ' COBOL's system for whole-line comments is simpler than other languages. IBM allows single line comments with '/'
                                    strScanResult = ScanLine(Me, CommentScan, CodeScan, strLine, strItem, strTrimmedComment, blnIsColoured)
                                ElseIf asAppSettings.TestType = Language.COBOL Then
                                    ' If line of COBOL has no comment in column 1, then it's all code
                                    rtResultsTracker.OverallCodeCount += 1
                                    rtResultsTracker.CodeCount += 1
                                    CheckCode(strLine, strItem)
                                ElseIf ((strLine.Contains(asAppSettings.SingleLineComment) And asAppSettings.SingleLineComment = "//" And Not strLine.ToLower.Contains("http:" + asAppSettings.SingleLineComment))) _
                                    Or (asAppSettings.TestType = Language.R And strLine.Contains(asAppSettings.SingleLineComment)) _
                                    Or (asAppSettings.TestType = Language.SQL And strLine.Contains(asAppSettings.SingleLineComment)) Or (asAppSettings.TestType = Language.VB And strLine.Contains(asAppSettings.SingleLineComment) And Not (strLine.Contains(""""c) And (InStr(strLine, """") < InStr(strLine, "'")))) Then
                                    strScanResult = ScanLine(Me, CommentScan, CodeScan, strLine, strItem, asAppSettings.SingleLineComment, blnIsColoured)

                                ElseIf ((Not asAppSettings.TestType = Language.VB And Not asAppSettings.TestType = Language.COBOL And Not asAppSettings.TestType = Language.R) And (strLine.Contains(asAppSettings.BlockStartComment) And strLine.Contains(asAppSettings.BlockEndComment)) And (InStr(strLine, asAppSettings.BlockStartComment) < InStr(strLine, asAppSettings.BlockEndComment)) And Not (strLine.Contains("/*/"))) Then
                                    strScanResult = ScanLine(Me, CommentScan, CodeScan, strLine, strItem, "both", blnIsColoured)
                                ElseIf (Not asAppSettings.TestType = Language.VB And Not asAppSettings.TestType = Language.COBOL And Not asAppSettings.TestType = Language.R) And (strLine.Contains(asAppSettings.BlockStartComment) And Not (strLine.Contains("/*/")) And Not (strLine.Contains("print") And (InStr(strLine, asAppSettings.BlockStartComment) > InStr(strLine, "print")))) Then
                                    blnIsCommented = True
                                    strScanResult = ScanLine(Me, CommentScan, CodeScan, strLine, strItem, asAppSettings.BlockStartComment, blnIsColoured)
                                Else
                                    rtResultsTracker.OverallCodeCount += 1
                                    rtResultsTracker.CodeCount += 1

                                    ' Scan code for dangerous functions
                                    CheckCode(strLine, strItem)
                                End If

                            ElseIf (Not asAppSettings.TestType = Language.VB And Not asAppSettings.TestType = Language.COBOL And Not asAppSettings.TestType = Language.R) And strLine.Contains(asAppSettings.BlockEndComment) Then    ' End of a comment block
                                blnIsCommented = False
                                strScanResult = ScanLine(Me, CommentScan, CodeScan, strLine, strItem, asAppSettings.BlockEndComment, blnIsColoured)
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
                    If (asAppSettings.TestType = Language.C Or asAppSettings.TestType = Language.JAVA Or asAppSettings.TestType = Language.COBOL) Then
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
        If asAppSettings.IsOutputFile Then _swOutputFile.Close()

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

    Private Sub WriteResult(Title As String, Description As String, CodeLine As String, Optional Severity As Integer = CodeIssue.STANDARD)
        ' Write results out to main screen in appropriate format
        '=======================================================

        If asAppSettings.OutputLevel < Severity Then Exit Sub

        '== Write details to output files if required ==
        If asAppSettings.IsOutputFile Then
            _swOutputFile.Write(Title)
            _swOutputFile.Write(Description)
        End If

    End Sub

    Private Sub AddToResultCollection(Title As String, Description As String, FileName As String, Optional Severity As Integer = CodeIssue.STANDARD, Optional LineNumber As Integer = 0, Optional CodeLine As String = "", Optional IsChecked As Boolean = False, Optional CheckColour As String = "LawnGreen")
        ' Build results collection and add into results listbox
        '======================================================

        Dim srScanResult As New ScanResult
        'TODO: Convert this to a data structure?
#If FIX_ME Then
        Dim lviItem As New ListViewItem
#End If
        Dim colOriginalColour As Color = asAppSettings.ListItemColour
        Dim fgFileGroup As New FileGroup
        Dim igIssueGroup As New IssueGroup
        Dim ccConverter As New ColorConverter

        Dim arrInts As String()
        Dim intR, intG, intB As Integer     ' For colour represented as RGB components

        If asAppSettings.OutputLevel < Severity Then Exit Sub


        '== Add to results collection ==
        srScanResult.ItemKey = rtResultsTracker.CurrentIndex
        srScanResult.Title = Title
        srScanResult.Description = Description
        srScanResult.FileName = FileName
        srScanResult.SetSeverity(Severity)
        srScanResult.LineNumber = LineNumber
        srScanResult.CodeLine = CodeLine
        srScanResult.IsChecked = IsChecked

        If CheckColour.Contains(","c) Then
            arrInts = CheckColour.Split(",")
            intR = CInt(arrInts(0))
            intG = CInt(arrInts(1))
            intB = CInt(arrInts(2))
            srScanResult.CheckColour = Color.FromArgb(intR, intG, intB)
        Else
            srScanResult.CheckColour = ccConverter.ConvertFromString(CheckColour)
        End If


        rtResultsTracker.ScanResults.Add(srScanResult)

        '== If this is a 'fix me' comment then add it to the comments collection ==
        If Severity = CodeIssue.INFO Then
            rtResultsTracker.FixMeList.Add(srScanResult)
        End If

        'TODO: Convert this to a data structure?
#If FIX_ME Then
        If Not asAppSettings.IsConsole Then
            '== Add to listview ==
            lviItem.Name = rtResultsTracker.CurrentIndex
            lviItem.Text = srScanResult.Severity
            lviItem.SubItems.Add(srScanResult.SeverityDesc)
            lviItem.SubItems.Add(Title)
            lviItem.SubItems.Add(Description)
            lviItem.SubItems.Add(FileName)
            lviItem.SubItems.Add(LineNumber)

            lvResults.Items.Add(lviItem)
            If srScanResult.IsChecked = True Then SetCheckState(lviItem.Name, True, srScanResult.CheckColour)
        End If
#End If

        '== Add to results groups ==
        If rtResultsTracker.FileGroups.ContainsKey(FileName) Then
            ' Add the issue to the array in dictionary entry for this file
            rtResultsTracker.FileGroups.Item(FileName).AddDetail(rtResultsTracker.CurrentIndex, Severity, Title, Description, LineNumber, CodeLine)
        Else
            ' Create a new file group and add the first issue
            fgFileGroup.FileName = FileName
            fgFileGroup.AddDetail(rtResultsTracker.CurrentIndex, Severity, Title, Description, LineNumber, CodeLine)
            rtResultsTracker.FileGroups.Add(FileName, fgFileGroup)
        End If

        If rtResultsTracker.IssueGroups.ContainsKey(Title) Then
            ' Add the issue to the array in dictionary entry for this general issue title
            rtResultsTracker.IssueGroups.Item(Title).AddDetail(rtResultsTracker.CurrentIndex, FileName, LineNumber, CodeLine)
        Else
            ' Create a new issue title group and add the first issue
            igIssueGroup.Title = Title
            igIssueGroup.SetSeverity(Severity)
            igIssueGroup.AddDetail(rtResultsTracker.CurrentIndex, FileName, LineNumber, CodeLine)
            rtResultsTracker.IssueGroups.Add(Title, igIssueGroup)
        End If

        rtResultsTracker.CurrentIndex += 1

        asAppSettings.ListItemColour = colOriginalColour

    End Sub

    Private Function IAppMode_CheckComment(CodeLine As String, FileName As String, ByRef IsColoured As Boolean) As Boolean Implements IAppMode.CheckComment
        ' Scan comment content for anything requiring attention and return results
        '=========================================================================
        ' First two params used for the scan, and to create return val
        ' Final param passed by reference, solely to be altered for the purposes of calling func
        '-------------------------------------------------------------------------

        Dim blnRetVal As Boolean = False

        Dim strTitle As String
        Dim strDescription As String


        rtResultsTracker.OverallCommentCount += 1
        rtResultsTracker.CommentCount += 1

        '== Look through comments for anything indicating unfixed or shoddy code ==
        For Each strComment As String In asAppSettings.BadComments
            If CodeLine.ToLower.Contains(strComment) Then
                blnRetVal = True

                strTitle = "Comment Indicates Potentially Unfinished Code - " & Environment.NewLine
                strDescription = " Line: " & rtResultsTracker.LineCount & " - " & FileName & Environment.NewLine
                WriteResult(strTitle, strDescription, CodeLine, CodeIssue.INFO)

                rtResultsTracker.FixMeCount += 1
                rtResultsTracker.OverallFixMeCount += 1
                IsColoured = True

                ' Update collection and listbox
                AddToResultCollection("Comment Indicates Potentially Unfinished Code", "The comment includes some wording which indicates that the developer regards it as unfinished or does not trust it to work correctly.", FileName, CodeIssue.INFO, rtResultsTracker.LineCount, CodeLine)

                Exit For
            End If
        Next

        '== Check for any passwords included in comments ==
        If Regex.IsMatch(CodeLine, "password\s*=") Then
            ' Update collection and listbox
            AddToResultCollection("Comment Appears to Contain Password", "The comment appears to include a password. If the password is valid then it could allow access to unauthorised users.", FileName, CodeIssue.HIGH, rtResultsTracker.LineCount, CodeLine)
            blnRetVal = True
        End If

        Return blnRetVal
    End Function

    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects)
                Try
                    ' Write any remaining data to the file.
                    _swOutputFile.Flush()
                Finally
                    ' Close the file.
                    _swOutputFile.Close()
                End Try
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override finalizer
            ' TODO: set large fields to null
            disposedValue = True
        End If
    End Sub

    ' ' TODO: override finalizer only if 'Dispose(disposing As Boolean)' has code to free unmanaged resources
    ' Protected Overrides Sub Finalize()
    '     ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
    '     Dispose(disposing:=False)
    '     MyBase.Finalize()
    ' End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
        Dispose(disposing:=True)
        GC.SuppressFinalize(Me)
    End Sub
End Class
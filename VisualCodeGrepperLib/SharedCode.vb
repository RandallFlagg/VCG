Imports System.IO
Imports System.Text.RegularExpressions

Public Module CHANGE_THE_CODE
    Public overFlowArg As CheckOverFlowArg
    Public EXIT_CODE = -1
End Module

'Namespace SharedCode

'TODO: If this will be changed to class all methods here should be Friend Shared
Public Module SharedCode
    Private Event CheckOverFlow_Event(sender As Object, args As CheckOverFlowArg)

    Public Sub FireEvent(sender As Object, overFlowArg As CheckOverFlowArg)
        RaiseEvent CheckOverFlow_Event(sender, overFlowArg)
    End Sub

    Public Function CheckFileType(TargetFile As String) As Boolean
        ' Check file type is consistent with required language
        ' This includes extensions, and exact filenames
        '=====================================================
        'TODO: Check if TargerFile changes because of the following line. It should not but I don't know VB so... :)
        TargetFile = TargetFile.ToLower()

        Dim ext = Path.GetExtension(TargetFile)
        Dim fileName = Path.GetFileName(TargetFile)

        If asAppSettings.FileSuffixes.Contains(ext) Then
            Return True
        ElseIf asAppSettings.FileSuffixes.Contains(fileName) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub LoadTempGrepContent(mode As IAppMode, TempGrepText As String)
        ' Take content of temp grep box and add to the list of bad functions
        '===================================================================
        Dim arrTempGrepContent As String()
        Dim strDescription As String = ""
        Dim arrFuncList As String()


        arrTempGrepContent = TempGrepText.Split(Environment.NewLine)

        Try
            For Each strLine In arrTempGrepContent

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
            DisplayError(mode, ex.ToString) 'TODO: Check how it looks in Windows
        End Try

    End Sub

    Public Sub LoadFiles(mode As IAppMode, TargetFolder As String, Optional ClearPrevious As Boolean = True)
        If (mode Is Nothing) Then Throw New Exception("mode must be initialized")
        mode.LoadFiles(TargetFolder, ClearPrevious)
    End Sub
    Private Sub DisplayError(mode As IAppMode, exception As Exception, Optional Caption As String = "Error", Optional MsgBoxStyle As Integer = MsgBoxStyle.Information)
        If (mode Is Nothing) Then Throw New Exception("mode must be initialized")
        mode.DisplayError(exception, Caption, MsgBoxStyle)
    End Sub

    Public Sub DisplayError(mode As IAppMode, message As String, Optional Caption As String = "Error", Optional MsgBoxStyle As Integer = MsgBoxStyle.Information)
        If (mode Is Nothing) Then Throw New Exception("mode must be initialized")
        mode.DisplayError(message, Caption, MsgBoxStyle)
    End Sub

    Public Sub ScanFiles(mode As IAppMode, CommentScan As Boolean, CodeScan As Boolean)
        If (mode Is Nothing) Then Throw New Exception("mode must be initialized")
        mode.ScanFiles(CommentScan, CodeScan)
    End Sub

End Module
'End Namespace
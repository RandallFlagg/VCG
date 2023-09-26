Imports System.Text.RegularExpressions

Module CHANGE_THE_CODE
    Friend overFlowArg As CheckOverFlowArg
End Module

Namespace SharedCode

    'TODO: If this will be changed to class all methods here should be Friend Shared
    Friend Module SharedCode
        Friend Event CheckOverFlow_Event(sender As Object, args As CheckOverFlowArg)

        Friend Sub FireEvent(sender As Object, overFlowArg As CheckOverFlowArg)
            RaiseEvent CheckOverFlow_Event(sender, overFlowArg)
        End Sub

        Friend Sub LoadTempGrepContent(TempGrepText As String)
            ' Take content of temp grep box and add to the list of bad functions
            '===================================================================
            Dim arrTempGrepContent As String()
            Dim strDescription As String = ""
            Dim arrFuncList As String()


            arrTempGrepContent = TempGrepText.Split(vbNewLine)

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
                MsgBox(ex.ToString)
            End Try

        End Sub
    End Module
End Namespace
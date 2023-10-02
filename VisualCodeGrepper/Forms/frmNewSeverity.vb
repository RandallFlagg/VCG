Imports VisualCodeGrepper.NETCore.Lib

Public Class frmNewSeverity

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Set severity marker to 'do nothing' and close form
        '===================================================

        intNewSeverity = -1
        Me.Close()

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        ' Set new severity marker and close form
        '=======================================

        intNewSeverity = 7 - cboNewLevel.SelectedIndex
        Me.Close()

    End Sub

    Private Sub frmNewSeverity_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cboNewLevel.SelectedIndex = CodeIssue.STANDARD

    End Sub

End Class
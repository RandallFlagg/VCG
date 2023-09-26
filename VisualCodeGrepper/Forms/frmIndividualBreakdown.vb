﻿' VisualCodeGrepper - Code security scanner
' Copyright (C) 2012-2013 Nick Dunn and John Murray
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

Imports VisualCodeGrepper.NETCore.Lib
Public Class frmIndividualBreakdown

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub OpenWithNotepadToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenWithNotepadToolStripMenuItem.Click
        LaunchNPP(strCurrentFileName)
    End Sub

    Private Sub CopyUnsafeMethodsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CopyUnsafeMethodsToolStripMenuItem.Click
        ' Loop throught comments, format them and add to clipboard
        '=========================================================
        Dim strCode As String = ""


        If intCodeIssues > 0 Then
            For Each srItem As ScanResult In rtResultsTracker.ScanResults
                If srItem.FileName = strCurrentFileName And srItem.Severity <> CodeIssue.INFO Then
                    strCode &= "File: " & srItem.FileName & Environment.NewLine
                    strCode &= "Line: " & srItem.LineNumber & Environment.NewLine
                    strCode &= "Issue: " & srItem.Title & Environment.NewLine & srItem.Description & Environment.NewLine & srItem.CodeLine & Environment.NewLine & Environment.NewLine
                End If
            Next
            Clipboard.SetText(strCode)
        End If

    End Sub

    Private Sub CopyCommentsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CopyCommentsToolStripMenuItem.Click
        ' Loop throught comments, format them and add to clipboard
        '=========================================================
        Dim strComments As String = ""


        If intComments > 0 Then
            For Each srItem As ScanResult In rtResultsTracker.FixMeList
                If srItem.FileName = strCurrentFileName Then
                    strComments &= "File: " & srItem.FileName & Environment.NewLine
                    strComments &= "Line: " & srItem.LineNumber & Environment.NewLine & "Contains: '" & srItem.CodeLine & "'" & Environment.NewLine & Environment.NewLine
                End If
            Next
            Clipboard.SetText(strComments)
        End If

    End Sub

End Class
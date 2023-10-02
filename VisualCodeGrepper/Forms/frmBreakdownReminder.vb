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

Public Class frmBreakdownReminder

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        ' Write user choice to registry
        '==============================

        If chkNotAgain.Checked Then
            SaveSetting("VisualCodeGrepper", "DisplayOptions", "BreakdownReminder", "0")
            asAppSettings.DisplayBreakdownOption = False
        End If

        If chkAlwaysShow.Checked Then
            SaveSetting("VisualCodeGrepper", "DisplayOptions", "ShowBreakdown", "1")
            asAppSettings.VisualBreakdownEnabled = True
        End If

        Me.Hide()

    End Sub

End Class
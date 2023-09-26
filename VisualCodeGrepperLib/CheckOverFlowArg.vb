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

Public Class CheckOverFlowArg
    Property FunctionName As String
    Property Description As String
    Property FileName As String
    Property Severity As Integer
    Property CodeLine As String
    Property LineNumber As Integer
    Sub New(FunctionName As String, Description As String, FileName As String, Optional Severity As Integer = CodeIssue.STANDARD, Optional CodeLine As String = "", Optional LineNumber As Integer = 0)
        Me.FunctionName = FunctionName
        Me.Description = Description
        Me.FileName = FileName
        Me.Severity = Severity
        Me.CodeLine = CodeLine
        Me.LineNumber = LineNumber
    End Sub
End Class

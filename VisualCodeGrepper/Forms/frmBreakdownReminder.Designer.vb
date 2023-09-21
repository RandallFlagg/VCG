<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBreakdownReminder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        chkNotAgain = New CheckBox()
        lblReminder = New Label()
        btnOK = New Button()
        chkAlwaysShow = New CheckBox()
        SuspendLayout()
        ' 
        ' chkNotAgain
        ' 
        chkNotAgain.AutoSize = True
        chkNotAgain.Location = New Point(7, 137)
        chkNotAgain.Margin = New Padding(4, 5, 4, 5)
        chkNotAgain.Name = "chkNotAgain"
        chkNotAgain.Size = New Size(250, 24)
        chkNotAgain.TabIndex = 5
        chkNotAgain.Text = "Do not show this reminder again."
        chkNotAgain.UseVisualStyleBackColor = True
        ' 
        ' lblReminder
        ' 
        lblReminder.Location = New Point(3, 14)
        lblReminder.Margin = New Padding(4, 0, 4, 0)
        lblReminder.Name = "lblReminder"
        lblReminder.Size = New Size(489, 62)
        lblReminder.TabIndex = 4
        lblReminder.Text = "To see a visual breakdown of the LOC, number of comments, number of potential issues, etc. select 'Visual Code/Comment Breakdown' from the 'Scan' menu or or click the 'Always display' option below."
        ' 
        ' btnOK
        ' 
        btnOK.Location = New Point(383, 171)
        btnOK.Margin = New Padding(4, 5, 4, 5)
        btnOK.Name = "btnOK"
        btnOK.Size = New Size(100, 35)
        btnOK.TabIndex = 3
        btnOK.Text = "OK"
        btnOK.UseVisualStyleBackColor = True
        ' 
        ' chkAlwaysShow
        ' 
        chkAlwaysShow.AutoSize = True
        chkAlwaysShow.Location = New Point(7, 102)
        chkAlwaysShow.Margin = New Padding(4, 5, 4, 5)
        chkAlwaysShow.Name = "chkAlwaysShow"
        chkAlwaysShow.Size = New Size(359, 24)
        chkAlwaysShow.TabIndex = 6
        chkAlwaysShow.Text = "Always display Visual Breakdown after every scan."
        chkAlwaysShow.UseVisualStyleBackColor = True
        ' 
        ' frmBreakdownReminder
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(492, 215)
        ControlBox = False
        Controls.Add(chkAlwaysShow)
        Controls.Add(chkNotAgain)
        Controls.Add(lblReminder)
        Controls.Add(btnOK)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 5, 4, 5)
        Name = "frmBreakdownReminder"
        Text = "Visual Breakdown"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents chkNotAgain As CheckBox
    Friend WithEvents lblReminder As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents chkAlwaysShow As CheckBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewTargetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewTargetFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearResultsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportResultsXMLMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportXmlResultsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportCsvResultsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportCsvResultsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportMetaDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator()
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupRichTextResultsByIssueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupRichTextResultsByFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowIndividualRichTextResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem16 = New System.Windows.Forms.ToolStripSeparator()
        Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartScanningToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.VisualCodeBreakdownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualSecurityBreakdownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualBadFuncBreakdownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualCommentBreakdownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportFixMeCommentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripSeparator()
        Me.SortRichTextResultsOnSeverityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortRichTextResultsOnFileNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripSeparator()
        Me.FilterResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BannedFunctionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JavaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PLSQLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PHPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COBOLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutVCGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.fbFolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.ssStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.sslLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.spMain = New System.Windows.Forms.SplitContainer()
        Me.scTarget = New System.Windows.Forms.SplitContainer()
        Me.cboTargetDir = New System.Windows.Forms.ComboBox()
        Me.cboLanguage = New System.Windows.Forms.ComboBox()
        Me.tcMain = New System.Windows.Forms.TabControl()
        Me.tabTargetFiles = New System.Windows.Forms.TabPage()
        Me.lbTargets = New System.Windows.Forms.ListBox()
        Me.tabResults = New System.Windows.Forms.TabPage()
        Me.rtbResults = New System.Windows.Forms.RichTextBox()
        Me.tabResultsTable = New System.Windows.Forms.TabPage()
        Me.lvResults = New System.Windows.Forms.ListView()
        Me.chSeverityRanking = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chSeverity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chFileName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chLine = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sfdSaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.ofdOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.cdColorDialog = New System.Windows.Forms.ColorDialog()
        Me.mnuMain.SuspendLayout()
        Me.ssStatusStrip.SuspendLayout()
        CType(Me.spMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spMain.Panel1.SuspendLayout()
        Me.spMain.Panel2.SuspendLayout()
        Me.spMain.SuspendLayout()
        CType(Me.scTarget, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scTarget.Panel1.SuspendLayout()
        Me.scTarget.Panel2.SuspendLayout()
        Me.scTarget.SuspendLayout()
        Me.tcMain.SuspendLayout()
        Me.tabTargetFiles.SuspendLayout()
        Me.tabResults.SuspendLayout()
        Me.tabResultsTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ScanToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(1304, 28)
        Me.mnuMain.TabIndex = 0
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewTargetToolStripMenuItem, Me.NewTargetFileToolStripMenuItem, Me.SaveResultsToolStripMenuItem, Me.ToolStripMenuItem5, Me.ClearResultsMenuItem, Me.ToolStripMenuItem1, Me.ExportResultsXMLMenuItem, Me.ImportXmlResultsMenuItem, Me.ToolStripSeparator1, Me.ExportCsvResultsMenuItem, Me.ImportCsvResultsMenuItem, Me.ToolStripSeparator4, Me.ExportMetaDataToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewTargetToolStripMenuItem
        '
        Me.NewTargetToolStripMenuItem.Name = "NewTargetToolStripMenuItem"
        Me.NewTargetToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewTargetToolStripMenuItem.Size = New System.Drawing.Size(302, 26)
        Me.NewTargetToolStripMenuItem.Text = "New Target Directory..."
        '
        'NewTargetFileToolStripMenuItem
        '
        Me.NewTargetFileToolStripMenuItem.Name = "NewTargetFileToolStripMenuItem"
        Me.NewTargetFileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.NewTargetFileToolStripMenuItem.Size = New System.Drawing.Size(302, 26)
        Me.NewTargetFileToolStripMenuItem.Text = "New Target File..."
        '
        'SaveResultsToolStripMenuItem
        '
        Me.SaveResultsToolStripMenuItem.Name = "SaveResultsToolStripMenuItem"
        Me.SaveResultsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveResultsToolStripMenuItem.Size = New System.Drawing.Size(302, 26)
        Me.SaveResultsToolStripMenuItem.Text = "Save Results as Text..."
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(299, 6)
        '
        'ClearResultsMenuItem
        '
        Me.ClearResultsMenuItem.Name = "ClearResultsMenuItem"
        Me.ClearResultsMenuItem.Size = New System.Drawing.Size(302, 26)
        Me.ClearResultsMenuItem.Text = "Clear"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(299, 6)
        '
        'ExportResultsXMLMenuItem
        '
        Me.ExportResultsXMLMenuItem.Name = "ExportResultsXMLMenuItem"
        Me.ExportResultsXMLMenuItem.Size = New System.Drawing.Size(302, 26)
        Me.ExportResultsXMLMenuItem.Text = "Export Results as XML..."
        '
        'ImportXmlResultsMenuItem
        '
        Me.ImportXmlResultsMenuItem.Name = "ImportXmlResultsMenuItem"
        Me.ImportXmlResultsMenuItem.Size = New System.Drawing.Size(302, 26)
        Me.ImportXmlResultsMenuItem.Text = "Import Results from XML File..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(299, 6)
        '
        'ExportCsvResultsMenuItem
        '
        Me.ExportCsvResultsMenuItem.Name = "ExportCsvResultsMenuItem"
        Me.ExportCsvResultsMenuItem.Size = New System.Drawing.Size(302, 26)
        Me.ExportCsvResultsMenuItem.Text = "Export Results to CSV File.."
        '
        'ImportCsvResultsMenuItem
        '
        Me.ImportCsvResultsMenuItem.Name = "ImportCsvResultsMenuItem"
        Me.ImportCsvResultsMenuItem.Size = New System.Drawing.Size(302, 26)
        Me.ImportCsvResultsMenuItem.Text = "Import Results from CSV File..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(299, 6)
        '
        'ExportMetaDataToolStripMenuItem
        '
        Me.ExportMetaDataToolStripMenuItem.Name = "ExportMetaDataToolStripMenuItem"
        Me.ExportMetaDataToolStripMenuItem.Size = New System.Drawing.Size(302, 26)
        Me.ExportMetaDataToolStripMenuItem.Text = "Export Code Metadata as XML..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(299, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(302, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.ToolStripMenuItem8, Me.FindToolStripMenuItem, Me.ToolStripMenuItem6, Me.SelectAllToolStripMenuItem})
        Me.EditToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(49, 24)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(151, 6)
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.FindToolStripMenuItem.Text = "Find"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(151, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GroupRichTextResultsByIssueToolStripMenuItem, Me.GroupRichTextResultsByFileToolStripMenuItem, Me.ShowIndividualRichTextResultsToolStripMenuItem, Me.ToolStripMenuItem16, Me.StatusBarToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'GroupRichTextResultsByIssueToolStripMenuItem
        '
        Me.GroupRichTextResultsByIssueToolStripMenuItem.CheckOnClick = True
        Me.GroupRichTextResultsByIssueToolStripMenuItem.Name = "GroupRichTextResultsByIssueToolStripMenuItem"
        Me.GroupRichTextResultsByIssueToolStripMenuItem.Size = New System.Drawing.Size(310, 26)
        Me.GroupRichTextResultsByIssueToolStripMenuItem.Text = "Group Rich Text Results by Issue"
        '
        'GroupRichTextResultsByFileToolStripMenuItem
        '
        Me.GroupRichTextResultsByFileToolStripMenuItem.CheckOnClick = True
        Me.GroupRichTextResultsByFileToolStripMenuItem.Name = "GroupRichTextResultsByFileToolStripMenuItem"
        Me.GroupRichTextResultsByFileToolStripMenuItem.Size = New System.Drawing.Size(310, 26)
        Me.GroupRichTextResultsByFileToolStripMenuItem.Text = "Group Rich Text Results by File"
        '
        'ShowIndividualRichTextResultsToolStripMenuItem
        '
        Me.ShowIndividualRichTextResultsToolStripMenuItem.Checked = True
        Me.ShowIndividualRichTextResultsToolStripMenuItem.CheckOnClick = True
        Me.ShowIndividualRichTextResultsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ShowIndividualRichTextResultsToolStripMenuItem.Name = "ShowIndividualRichTextResultsToolStripMenuItem"
        Me.ShowIndividualRichTextResultsToolStripMenuItem.Size = New System.Drawing.Size(310, 26)
        Me.ShowIndividualRichTextResultsToolStripMenuItem.Text = "Show Individual Rich Text Results"
        '
        'ToolStripMenuItem16
        '
        Me.ToolStripMenuItem16.Name = "ToolStripMenuItem16"
        Me.ToolStripMenuItem16.Size = New System.Drawing.Size(307, 6)
        '
        'StatusBarToolStripMenuItem
        '
        Me.StatusBarToolStripMenuItem.Checked = True
        Me.StatusBarToolStripMenuItem.CheckOnClick = True
        Me.StatusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        Me.StatusBarToolStripMenuItem.Size = New System.Drawing.Size(310, 26)
        Me.StatusBarToolStripMenuItem.Text = "Status Bar"
        '
        'ScanToolStripMenuItem
        '
        Me.ScanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartScanningToolStripMenuItem, Me.ToolStripMenuItem4, Me.VisualCodeBreakdownToolStripMenuItem, Me.VisualSecurityBreakdownToolStripMenuItem, Me.VisualBadFuncBreakdownToolStripMenuItem, Me.VisualCommentBreakdownToolStripMenuItem, Me.ToolStripMenuItem7, Me.ExportFixMeCommentsToolStripMenuItem, Me.ToolStripMenuItem12, Me.SortRichTextResultsOnSeverityToolStripMenuItem, Me.SortRichTextResultsOnFileNameToolStripMenuItem, Me.ToolStripMenuItem13, Me.FilterResultsToolStripMenuItem, Me.ToolStripSeparator3, Me.DeleteItemToolStripMenuItem})
        Me.ScanToolStripMenuItem.Name = "ScanToolStripMenuItem"
        Me.ScanToolStripMenuItem.Size = New System.Drawing.Size(54, 24)
        Me.ScanToolStripMenuItem.Text = "Scan"
        '
        'StartScanningToolStripMenuItem
        '
        Me.StartScanningToolStripMenuItem.Enabled = False
        Me.StartScanningToolStripMenuItem.Name = "StartScanningToolStripMenuItem"
        Me.StartScanningToolStripMenuItem.Size = New System.Drawing.Size(456, 26)
        Me.StartScanningToolStripMenuItem.Text = "Full Scan"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(453, 6)
        '
        'VisualCodeBreakdownToolStripMenuItem
        '
        Me.VisualCodeBreakdownToolStripMenuItem.Enabled = False
        Me.VisualCodeBreakdownToolStripMenuItem.Name = "VisualCodeBreakdownToolStripMenuItem"
        Me.VisualCodeBreakdownToolStripMenuItem.Size = New System.Drawing.Size(456, 26)
        Me.VisualCodeBreakdownToolStripMenuItem.Text = "Visual Code/Comment Breakdown"
        '
        'VisualSecurityBreakdownToolStripMenuItem
        '
        Me.VisualSecurityBreakdownToolStripMenuItem.Enabled = False
        Me.VisualSecurityBreakdownToolStripMenuItem.Name = "VisualSecurityBreakdownToolStripMenuItem"
        Me.VisualSecurityBreakdownToolStripMenuItem.Size = New System.Drawing.Size(456, 26)
        Me.VisualSecurityBreakdownToolStripMenuItem.Text = "Scan Code Only (Ignore Comments)"
        '
        'VisualBadFuncBreakdownToolStripMenuItem
        '
        Me.VisualBadFuncBreakdownToolStripMenuItem.Enabled = False
        Me.VisualBadFuncBreakdownToolStripMenuItem.Name = "VisualBadFuncBreakdownToolStripMenuItem"
        Me.VisualBadFuncBreakdownToolStripMenuItem.Size = New System.Drawing.Size(456, 26)
        Me.VisualBadFuncBreakdownToolStripMenuItem.Text = "Scan For Bad Functions Only (As Defined in Config File)"
        '
        'VisualCommentBreakdownToolStripMenuItem
        '
        Me.VisualCommentBreakdownToolStripMenuItem.Enabled = False
        Me.VisualCommentBreakdownToolStripMenuItem.Name = "VisualCommentBreakdownToolStripMenuItem"
        Me.VisualCommentBreakdownToolStripMenuItem.Size = New System.Drawing.Size(456, 26)
        Me.VisualCommentBreakdownToolStripMenuItem.Text = "Scan Comments Only"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(453, 6)
        '
        'ExportFixMeCommentsToolStripMenuItem
        '
        Me.ExportFixMeCommentsToolStripMenuItem.Enabled = False
        Me.ExportFixMeCommentsToolStripMenuItem.Name = "ExportFixMeCommentsToolStripMenuItem"
        Me.ExportFixMeCommentsToolStripMenuItem.Size = New System.Drawing.Size(456, 26)
        Me.ExportFixMeCommentsToolStripMenuItem.Text = "Show All 'FixMe' Comments"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(453, 6)
        '
        'SortRichTextResultsOnSeverityToolStripMenuItem
        '
        Me.SortRichTextResultsOnSeverityToolStripMenuItem.Name = "SortRichTextResultsOnSeverityToolStripMenuItem"
        Me.SortRichTextResultsOnSeverityToolStripMenuItem.Size = New System.Drawing.Size(456, 26)
        Me.SortRichTextResultsOnSeverityToolStripMenuItem.Text = "Sort Rich Text Results on Severity"
        '
        'SortRichTextResultsOnFileNameToolStripMenuItem
        '
        Me.SortRichTextResultsOnFileNameToolStripMenuItem.Name = "SortRichTextResultsOnFileNameToolStripMenuItem"
        Me.SortRichTextResultsOnFileNameToolStripMenuItem.Size = New System.Drawing.Size(456, 26)
        Me.SortRichTextResultsOnFileNameToolStripMenuItem.Text = "Sort Rich Text Results on FileName"
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(453, 6)
        '
        'FilterResultsToolStripMenuItem
        '
        Me.FilterResultsToolStripMenuItem.Name = "FilterResultsToolStripMenuItem"
        Me.FilterResultsToolStripMenuItem.Size = New System.Drawing.Size(456, 26)
        Me.FilterResultsToolStripMenuItem.Text = "Filter Results..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(453, 6)
        '
        'DeleteItemToolStripMenuItem
        '
        Me.DeleteItemToolStripMenuItem.Name = "DeleteItemToolStripMenuItem"
        Me.DeleteItemToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.DeleteItemToolStripMenuItem.Size = New System.Drawing.Size(456, 26)
        Me.DeleteItemToolStripMenuItem.Text = "Delete Selected Item(s)"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BannedFunctionsToolStripMenuItem, Me.ToolStripMenuItem2, Me.CCToolStripMenuItem, Me.JavaToolStripMenuItem, Me.PLSQLToolStripMenuItem, Me.CSToolStripMenuItem, Me.VBToolStripMenuItem, Me.PHPToolStripMenuItem, Me.COBOLToolStripMenuItem, Me.ToolStripMenuItem3, Me.OptionsToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'BannedFunctionsToolStripMenuItem
        '
        Me.BannedFunctionsToolStripMenuItem.Name = "BannedFunctionsToolStripMenuItem"
        Me.BannedFunctionsToolStripMenuItem.Size = New System.Drawing.Size(277, 26)
        Me.BannedFunctionsToolStripMenuItem.Text = "Banned/Insecure Functions..."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(274, 6)
        Me.ToolStripMenuItem2.Visible = False
        '
        'CCToolStripMenuItem
        '
        Me.CCToolStripMenuItem.Checked = True
        Me.CCToolStripMenuItem.CheckOnClick = True
        Me.CCToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CCToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CCToolStripMenuItem.Name = "CCToolStripMenuItem"
        Me.CCToolStripMenuItem.Size = New System.Drawing.Size(277, 26)
        Me.CCToolStripMenuItem.Text = "C/C++"
        Me.CCToolStripMenuItem.Visible = False
        '
        'JavaToolStripMenuItem
        '
        Me.JavaToolStripMenuItem.CheckOnClick = True
        Me.JavaToolStripMenuItem.Name = "JavaToolStripMenuItem"
        Me.JavaToolStripMenuItem.Size = New System.Drawing.Size(277, 26)
        Me.JavaToolStripMenuItem.Text = "Java"
        Me.JavaToolStripMenuItem.Visible = False
        '
        'PLSQLToolStripMenuItem
        '
        Me.PLSQLToolStripMenuItem.CheckOnClick = True
        Me.PLSQLToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PLSQLToolStripMenuItem.Name = "PLSQLToolStripMenuItem"
        Me.PLSQLToolStripMenuItem.Size = New System.Drawing.Size(277, 26)
        Me.PLSQLToolStripMenuItem.Text = "PL/SQL"
        Me.PLSQLToolStripMenuItem.Visible = False
        '
        'CSToolStripMenuItem
        '
        Me.CSToolStripMenuItem.CheckOnClick = True
        Me.CSToolStripMenuItem.Name = "CSToolStripMenuItem"
        Me.CSToolStripMenuItem.Size = New System.Drawing.Size(277, 26)
        Me.CSToolStripMenuItem.Text = "C#"
        Me.CSToolStripMenuItem.Visible = False
        '
        'VBToolStripMenuItem
        '
        Me.VBToolStripMenuItem.CheckOnClick = True
        Me.VBToolStripMenuItem.Name = "VBToolStripMenuItem"
        Me.VBToolStripMenuItem.Size = New System.Drawing.Size(277, 26)
        Me.VBToolStripMenuItem.Text = "VB"
        Me.VBToolStripMenuItem.Visible = False
        '
        'PHPToolStripMenuItem
        '
        Me.PHPToolStripMenuItem.CheckOnClick = True
        Me.PHPToolStripMenuItem.Name = "PHPToolStripMenuItem"
        Me.PHPToolStripMenuItem.Size = New System.Drawing.Size(277, 26)
        Me.PHPToolStripMenuItem.Text = "PHP"
        Me.PHPToolStripMenuItem.Visible = False
        '
        'COBOLToolStripMenuItem
        '
        Me.COBOLToolStripMenuItem.CheckOnClick = True
        Me.COBOLToolStripMenuItem.Name = "COBOLToolStripMenuItem"
        Me.COBOLToolStripMenuItem.Size = New System.Drawing.Size(277, 26)
        Me.COBOLToolStripMenuItem.Text = "COBOL"
        Me.COBOLToolStripMenuItem.Visible = False
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(274, 6)
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(277, 26)
        Me.OptionsToolStripMenuItem.Text = "Options..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutVCGToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutVCGToolStripMenuItem
        '
        Me.AboutVCGToolStripMenuItem.Name = "AboutVCGToolStripMenuItem"
        Me.AboutVCGToolStripMenuItem.Size = New System.Drawing.Size(165, 26)
        Me.AboutVCGToolStripMenuItem.Text = "About VCG"
        '
        'ssStatusStrip
        '
        Me.ssStatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ssStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sslLabel})
        Me.ssStatusStrip.Location = New System.Drawing.Point(0, 603)
        Me.ssStatusStrip.Name = "ssStatusStrip"
        Me.ssStatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.ssStatusStrip.Size = New System.Drawing.Size(1304, 26)
        Me.ssStatusStrip.TabIndex = 1
        '
        'sslLabel
        '
        Me.sslLabel.Name = "sslLabel"
        Me.sslLabel.Size = New System.Drawing.Size(125, 20)
        Me.sslLabel.Text = "Language: C/C++"
        '
        'spMain
        '
        Me.spMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.spMain.IsSplitterFixed = True
        Me.spMain.Location = New System.Drawing.Point(0, 30)
        Me.spMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.spMain.Name = "spMain"
        Me.spMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spMain.Panel1
        '
        Me.spMain.Panel1.Controls.Add(Me.scTarget)
        Me.spMain.Panel1MinSize = 0
        '
        'spMain.Panel2
        '
        Me.spMain.Panel2.Controls.Add(Me.tcMain)
        Me.spMain.Panel2MinSize = 0
        Me.spMain.Size = New System.Drawing.Size(1304, 572)
        Me.spMain.SplitterDistance = 39
        Me.spMain.SplitterWidth = 5
        Me.spMain.TabIndex = 2
        '
        'scTarget
        '
        Me.scTarget.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scTarget.Location = New System.Drawing.Point(0, 0)
        Me.scTarget.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.scTarget.Name = "scTarget"
        '
        'scTarget.Panel1
        '
        Me.scTarget.Panel1.Controls.Add(Me.cboTargetDir)
        '
        'scTarget.Panel2
        '
        Me.scTarget.Panel2.Controls.Add(Me.cboLanguage)
        Me.scTarget.Size = New System.Drawing.Size(1304, 39)
        Me.scTarget.SplitterDistance = 1057
        Me.scTarget.SplitterWidth = 5
        Me.scTarget.TabIndex = 0
        '
        'cboTargetDir
        '
        Me.cboTargetDir.AllowDrop = True
        Me.cboTargetDir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTargetDir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.cboTargetDir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboTargetDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cboTargetDir.IntegralHeight = False
        Me.cboTargetDir.ItemHeight = 17
        Me.cboTargetDir.Location = New System.Drawing.Point(0, 0)
        Me.cboTargetDir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboTargetDir.MaxDropDownItems = 5
        Me.cboTargetDir.Name = "cboTargetDir"
        Me.cboTargetDir.Size = New System.Drawing.Size(1057, 25)
        Me.cboTargetDir.TabIndex = 4
        '
        'cboLanguage
        '
        Me.cboLanguage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboLanguage.DropDownWidth = 155
        Me.cboLanguage.FormattingEnabled = True
        Me.cboLanguage.Location = New System.Drawing.Point(0, 0)
        Me.cboLanguage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboLanguage.Name = "cboLanguage"
        Me.cboLanguage.Size = New System.Drawing.Size(242, 24)
        Me.cboLanguage.TabIndex = 6
        '
        'tcMain
        '
        Me.tcMain.Controls.Add(Me.tabTargetFiles)
        Me.tcMain.Controls.Add(Me.tabResults)
        Me.tcMain.Controls.Add(Me.tabResultsTable)
        Me.tcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcMain.Location = New System.Drawing.Point(0, 0)
        Me.tcMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tcMain.Name = "tcMain"
        Me.tcMain.SelectedIndex = 0
        Me.tcMain.Size = New System.Drawing.Size(1304, 528)
        Me.tcMain.TabIndex = 0
        '
        'tabTargetFiles
        '
        Me.tabTargetFiles.Controls.Add(Me.lbTargets)
        Me.tabTargetFiles.Location = New System.Drawing.Point(4, 25)
        Me.tabTargetFiles.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabTargetFiles.Name = "tabTargetFiles"
        Me.tabTargetFiles.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabTargetFiles.Size = New System.Drawing.Size(1296, 499)
        Me.tabTargetFiles.TabIndex = 0
        Me.tabTargetFiles.Text = "Target Files"
        Me.tabTargetFiles.UseVisualStyleBackColor = True
        '
        'lbTargets
        '
        Me.lbTargets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbTargets.FormattingEnabled = True
        Me.lbTargets.ItemHeight = 16
        Me.lbTargets.Location = New System.Drawing.Point(4, 4)
        Me.lbTargets.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbTargets.Name = "lbTargets"
        Me.lbTargets.Size = New System.Drawing.Size(1288, 491)
        Me.lbTargets.TabIndex = 0
        '
        'tabResults
        '
        Me.tabResults.Controls.Add(Me.rtbResults)
        Me.tabResults.Location = New System.Drawing.Point(4, 25)
        Me.tabResults.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabResults.Name = "tabResults"
        Me.tabResults.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabResults.Size = New System.Drawing.Size(1296, 499)
        Me.tabResults.TabIndex = 1
        Me.tabResults.Text = "Results"
        Me.tabResults.UseVisualStyleBackColor = True
        '
        'rtbResults
        '
        Me.rtbResults.DetectUrls = False
        Me.rtbResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbResults.Location = New System.Drawing.Point(4, 4)
        Me.rtbResults.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rtbResults.Name = "rtbResults"
        Me.rtbResults.Size = New System.Drawing.Size(1288, 491)
        Me.rtbResults.TabIndex = 0
        Me.rtbResults.Text = ""
        '
        'tabResultsTable
        '
        Me.tabResultsTable.Controls.Add(Me.lvResults)
        Me.tabResultsTable.Location = New System.Drawing.Point(4, 25)
        Me.tabResultsTable.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabResultsTable.Name = "tabResultsTable"
        Me.tabResultsTable.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabResultsTable.Size = New System.Drawing.Size(1296, 499)
        Me.tabResultsTable.TabIndex = 2
        Me.tabResultsTable.Text = "Summary Table"
        Me.tabResultsTable.UseVisualStyleBackColor = True
        '
        'lvResults
        '
        Me.lvResults.AllowColumnReorder = True
        Me.lvResults.CheckBoxes = True
        Me.lvResults.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chSeverityRanking, Me.chSeverity, Me.chTitle, Me.chDescription, Me.chFileName, Me.chLine})
        Me.lvResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvResults.FullRowSelect = True
        Me.lvResults.HideSelection = False
        Me.lvResults.LabelWrap = False
        Me.lvResults.Location = New System.Drawing.Point(4, 4)
        Me.lvResults.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lvResults.Name = "lvResults"
        Me.lvResults.Size = New System.Drawing.Size(1288, 491)
        Me.lvResults.TabIndex = 0
        Me.lvResults.UseCompatibleStateImageBehavior = False
        Me.lvResults.View = System.Windows.Forms.View.Details
        '
        'chSeverityRanking
        '
        Me.chSeverityRanking.Text = "Priority"
        Me.chSeverityRanking.Width = 43
        '
        'chSeverity
        '
        Me.chSeverity.Text = "Severity"
        Me.chSeverity.Width = 75
        '
        'chTitle
        '
        Me.chTitle.Text = "Title"
        Me.chTitle.Width = 229
        '
        'chDescription
        '
        Me.chDescription.Text = "Description"
        Me.chDescription.Width = 399
        '
        'chFileName
        '
        Me.chFileName.Text = "FileName"
        Me.chFileName.Width = 378
        '
        'chLine
        '
        Me.chLine.Text = "Line"
        '
        'ofdOpenFileDialog
        '
        Me.ofdOpenFileDialog.FileName = "XmlResults"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1304, 629)
        Me.Controls.Add(Me.spMain)
        Me.Controls.Add(Me.ssStatusStrip)
        Me.Controls.Add(Me.mnuMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuMain
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMain"
        Me.Text = "VCG"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ssStatusStrip.ResumeLayout(False)
        Me.ssStatusStrip.PerformLayout()
        Me.spMain.Panel1.ResumeLayout(False)
        Me.spMain.Panel2.ResumeLayout(False)
        CType(Me.spMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spMain.ResumeLayout(False)
        Me.scTarget.Panel1.ResumeLayout(False)
        Me.scTarget.Panel2.ResumeLayout(False)
        CType(Me.scTarget, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scTarget.ResumeLayout(False)
        Me.tcMain.ResumeLayout(False)
        Me.tabTargetFiles.ResumeLayout(False)
        Me.tabResults.ResumeLayout(False)
        Me.tabResultsTable.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewTargetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveResultsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BannedFunctionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents CCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JavaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PLSQLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutVCGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents fbFolderBrowser As FolderBrowserDialog
    Friend WithEvents ssStatusStrip As StatusStrip
    Friend WithEvents spMain As SplitContainer
    Friend WithEvents ScanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartScanningToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents VisualCodeBreakdownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisualSecurityBreakdownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripSeparator
    Friend WithEvents ExportFixMeCommentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents sslLabel As ToolStripStatusLabel
    Friend WithEvents sfdSaveFileDialog As SaveFileDialog
    Friend WithEvents ToolStripMenuItem8 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem5 As ToolStripSeparator
    Friend WithEvents ClearResultsMenuItem As ToolStripMenuItem
    Friend WithEvents ofdOpenFileDialog As OpenFileDialog
    Friend WithEvents ExportResultsXMLMenuItem As ToolStripMenuItem
    Friend WithEvents ImportXmlResultsMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem12 As ToolStripSeparator
    Friend WithEvents SortRichTextResultsOnSeverityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SortRichTextResultsOnFileNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem13 As ToolStripSeparator
    Friend WithEvents FilterResultsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PHPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COBOLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisualCommentBreakdownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewTargetFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cdColorDialog As ColorDialog
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupRichTextResultsByIssueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupRichTextResultsByFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportCsvResultsMenuItem As ToolStripMenuItem
    Friend WithEvents ImportCsvResultsMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ShowIndividualRichTextResultsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents DeleteItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem16 As ToolStripSeparator
    Friend WithEvents StatusBarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisualBadFuncBreakdownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ExportMetaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tcMain As TabControl
    Friend WithEvents tabTargetFiles As TabPage
    Friend WithEvents lbTargets As ListBox
    Friend WithEvents tabResults As TabPage
    Friend WithEvents rtbResults As RichTextBox
    Friend WithEvents tabResultsTable As TabPage
    Friend WithEvents lvResults As ListView
    Friend WithEvents chSeverityRanking As ColumnHeader
    Friend WithEvents chSeverity As ColumnHeader
    Friend WithEvents chTitle As ColumnHeader
    Friend WithEvents chDescription As ColumnHeader
    Friend WithEvents chFileName As ColumnHeader
    Friend WithEvents chLine As ColumnHeader
    Friend WithEvents scTarget As SplitContainer
    Friend WithEvents cboTargetDir As ComboBox
    Friend WithEvents cboLanguage As ComboBox
End Class

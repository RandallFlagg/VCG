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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmMain))
        mnuMain = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewTargetToolStripMenuItem = New ToolStripMenuItem()
        NewTargetFileToolStripMenuItem = New ToolStripMenuItem()
        SaveResultsToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem5 = New ToolStripSeparator()
        ClearResultsMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripSeparator()
        ExportResultsXMLMenuItem = New ToolStripMenuItem()
        ImportXmlResultsMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        ExportCsvResultsMenuItem = New ToolStripMenuItem()
        ImportCsvResultsMenuItem = New ToolStripMenuItem()
        ToolStripSeparator4 = New ToolStripSeparator()
        ExportMetaDataToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        CutToolStripMenuItem = New ToolStripMenuItem()
        CopyToolStripMenuItem = New ToolStripMenuItem()
        PasteToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem8 = New ToolStripSeparator()
        FindToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem6 = New ToolStripSeparator()
        SelectAllToolStripMenuItem = New ToolStripMenuItem()
        ViewToolStripMenuItem = New ToolStripMenuItem()
        GroupRichTextResultsByIssueToolStripMenuItem = New ToolStripMenuItem()
        GroupRichTextResultsByFileToolStripMenuItem = New ToolStripMenuItem()
        ShowIndividualRichTextResultsToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem16 = New ToolStripSeparator()
        StatusBarToolStripMenuItem = New ToolStripMenuItem()
        ScanToolStripMenuItem = New ToolStripMenuItem()
        StartScanningToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem4 = New ToolStripSeparator()
        VisualCodeBreakdownToolStripMenuItem = New ToolStripMenuItem()
        VisualSecurityBreakdownToolStripMenuItem = New ToolStripMenuItem()
        VisualBadFuncBreakdownToolStripMenuItem = New ToolStripMenuItem()
        VisualCommentBreakdownToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem7 = New ToolStripSeparator()
        ExportFixMeCommentsToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem12 = New ToolStripSeparator()
        SortRichTextResultsOnSeverityToolStripMenuItem = New ToolStripMenuItem()
        SortRichTextResultsOnFileNameToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem13 = New ToolStripSeparator()
        FilterResultsToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator3 = New ToolStripSeparator()
        DeleteItemToolStripMenuItem = New ToolStripMenuItem()
        SettingsToolStripMenuItem = New ToolStripMenuItem()
        BannedFunctionsToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripSeparator()
        CCToolStripMenuItem = New ToolStripMenuItem()
        JavaToolStripMenuItem = New ToolStripMenuItem()
        PLSQLToolStripMenuItem = New ToolStripMenuItem()
        CSToolStripMenuItem = New ToolStripMenuItem()
        VBToolStripMenuItem = New ToolStripMenuItem()
        PHPToolStripMenuItem = New ToolStripMenuItem()
        COBOLToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripSeparator()
        OptionsToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        AboutVCGToolStripMenuItem = New ToolStripMenuItem()
        fbFolderBrowser = New FolderBrowserDialog()
        ssStatusStrip = New StatusStrip()
        sslLabel = New ToolStripStatusLabel()
        spMain = New SplitContainer()
        scTarget = New SplitContainer()
        cboTargetDir = New ComboBox()
        cboLanguage = New ComboBox()
        tcMain = New TabControl()
        tabTargetFiles = New TabPage()
        lbTargets = New ListBox()
        tabResults = New TabPage()
        rtbResults = New RichTextBox()
        tabResultsTable = New TabPage()
        lvResults = New ListView()
        chSeverityRanking = New ColumnHeader()
        chSeverity = New ColumnHeader()
        chTitle = New ColumnHeader()
        chDescription = New ColumnHeader()
        chFileName = New ColumnHeader()
        chLine = New ColumnHeader()
        sfdSaveFileDialog = New SaveFileDialog()
        ofdOpenFileDialog = New OpenFileDialog()
        cdColorDialog = New ColorDialog()
        mnuMain.SuspendLayout()
        ssStatusStrip.SuspendLayout()
        CType(spMain, ComponentModel.ISupportInitialize).BeginInit()
        spMain.Panel1.SuspendLayout()
        spMain.Panel2.SuspendLayout()
        spMain.SuspendLayout()
        CType(scTarget, ComponentModel.ISupportInitialize).BeginInit()
        scTarget.Panel1.SuspendLayout()
        scTarget.Panel2.SuspendLayout()
        scTarget.SuspendLayout()
        tcMain.SuspendLayout()
        tabTargetFiles.SuspendLayout()
        tabResults.SuspendLayout()
        tabResultsTable.SuspendLayout()
        SuspendLayout()
        ' 
        ' mnuMain
        ' 
        mnuMain.ImageScalingSize = New Size(20, 20)
        mnuMain.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem, ViewToolStripMenuItem, ScanToolStripMenuItem, SettingsToolStripMenuItem, HelpToolStripMenuItem})
        mnuMain.Location = New Point(0, 0)
        mnuMain.Name = "mnuMain"
        mnuMain.Padding = New Padding(8, 3, 0, 3)
        mnuMain.Size = New Size(1304, 30)
        mnuMain.TabIndex = 0
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewTargetToolStripMenuItem, NewTargetFileToolStripMenuItem, SaveResultsToolStripMenuItem, ToolStripMenuItem5, ClearResultsMenuItem, ToolStripMenuItem1, ExportResultsXMLMenuItem, ImportXmlResultsMenuItem, ToolStripSeparator1, ExportCsvResultsMenuItem, ImportCsvResultsMenuItem, ToolStripSeparator4, ExportMetaDataToolStripMenuItem, ToolStripSeparator2, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' NewTargetToolStripMenuItem
        ' 
        NewTargetToolStripMenuItem.Name = "NewTargetToolStripMenuItem"
        NewTargetToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.N
        NewTargetToolStripMenuItem.Size = New Size(302, 26)
        NewTargetToolStripMenuItem.Text = "New Target Directory..."
        ' 
        ' NewTargetFileToolStripMenuItem
        ' 
        NewTargetFileToolStripMenuItem.Name = "NewTargetFileToolStripMenuItem"
        NewTargetFileToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.T
        NewTargetFileToolStripMenuItem.Size = New Size(302, 26)
        NewTargetFileToolStripMenuItem.Text = "New Target File..."
        ' 
        ' SaveResultsToolStripMenuItem
        ' 
        SaveResultsToolStripMenuItem.Name = "SaveResultsToolStripMenuItem"
        SaveResultsToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.S
        SaveResultsToolStripMenuItem.Size = New Size(302, 26)
        SaveResultsToolStripMenuItem.Text = "Save Results as Text..."
        ' 
        ' ToolStripMenuItem5
        ' 
        ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        ToolStripMenuItem5.Size = New Size(299, 6)
        ' 
        ' ClearResultsMenuItem
        ' 
        ClearResultsMenuItem.Name = "ClearResultsMenuItem"
        ClearResultsMenuItem.Size = New Size(302, 26)
        ClearResultsMenuItem.Text = "Clear"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(299, 6)
        ' 
        ' ExportResultsXMLMenuItem
        ' 
        ExportResultsXMLMenuItem.Name = "ExportResultsXMLMenuItem"
        ExportResultsXMLMenuItem.Size = New Size(302, 26)
        ExportResultsXMLMenuItem.Text = "Export Results as XML..."
        ' 
        ' ImportXmlResultsMenuItem
        ' 
        ImportXmlResultsMenuItem.Name = "ImportXmlResultsMenuItem"
        ImportXmlResultsMenuItem.Size = New Size(302, 26)
        ImportXmlResultsMenuItem.Text = "Import Results from XML File..."
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(299, 6)
        ' 
        ' ExportCsvResultsMenuItem
        ' 
        ExportCsvResultsMenuItem.Name = "ExportCsvResultsMenuItem"
        ExportCsvResultsMenuItem.Size = New Size(302, 26)
        ExportCsvResultsMenuItem.Text = "Export Results to CSV File.."
        ' 
        ' ImportCsvResultsMenuItem
        ' 
        ImportCsvResultsMenuItem.Name = "ImportCsvResultsMenuItem"
        ImportCsvResultsMenuItem.Size = New Size(302, 26)
        ImportCsvResultsMenuItem.Text = "Import Results from CSV File..."
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(299, 6)
        ' 
        ' ExportMetaDataToolStripMenuItem
        ' 
        ExportMetaDataToolStripMenuItem.Name = "ExportMetaDataToolStripMenuItem"
        ExportMetaDataToolStripMenuItem.Size = New Size(302, 26)
        ExportMetaDataToolStripMenuItem.Text = "Export Code Metadata as XML..."
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(299, 6)
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.ShortcutKeys = Keys.Alt Or Keys.F4
        ExitToolStripMenuItem.Size = New Size(302, 26)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CutToolStripMenuItem, CopyToolStripMenuItem, PasteToolStripMenuItem, ToolStripMenuItem8, FindToolStripMenuItem, ToolStripMenuItem6, SelectAllToolStripMenuItem})
        EditToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(49, 24)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' CutToolStripMenuItem
        ' 
        CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        CutToolStripMenuItem.Size = New Size(154, 26)
        CutToolStripMenuItem.Text = "Cut"
        ' 
        ' CopyToolStripMenuItem
        ' 
        CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        CopyToolStripMenuItem.Size = New Size(154, 26)
        CopyToolStripMenuItem.Text = "Copy"
        ' 
        ' PasteToolStripMenuItem
        ' 
        PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        PasteToolStripMenuItem.Size = New Size(154, 26)
        PasteToolStripMenuItem.Text = "Paste"
        ' 
        ' ToolStripMenuItem8
        ' 
        ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        ToolStripMenuItem8.Size = New Size(151, 6)
        ' 
        ' FindToolStripMenuItem
        ' 
        FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        FindToolStripMenuItem.Size = New Size(154, 26)
        FindToolStripMenuItem.Text = "Find"
        ' 
        ' ToolStripMenuItem6
        ' 
        ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        ToolStripMenuItem6.Size = New Size(151, 6)
        ' 
        ' SelectAllToolStripMenuItem
        ' 
        SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        SelectAllToolStripMenuItem.Size = New Size(154, 26)
        SelectAllToolStripMenuItem.Text = "Select All"
        ' 
        ' ViewToolStripMenuItem
        ' 
        ViewToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {GroupRichTextResultsByIssueToolStripMenuItem, GroupRichTextResultsByFileToolStripMenuItem, ShowIndividualRichTextResultsToolStripMenuItem, ToolStripMenuItem16, StatusBarToolStripMenuItem})
        ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        ViewToolStripMenuItem.Size = New Size(55, 24)
        ViewToolStripMenuItem.Text = "View"
        ' 
        ' GroupRichTextResultsByIssueToolStripMenuItem
        ' 
        GroupRichTextResultsByIssueToolStripMenuItem.CheckOnClick = True
        GroupRichTextResultsByIssueToolStripMenuItem.Name = "GroupRichTextResultsByIssueToolStripMenuItem"
        GroupRichTextResultsByIssueToolStripMenuItem.Size = New Size(310, 26)
        GroupRichTextResultsByIssueToolStripMenuItem.Text = "Group Rich Text Results by Issue"
        ' 
        ' GroupRichTextResultsByFileToolStripMenuItem
        ' 
        GroupRichTextResultsByFileToolStripMenuItem.CheckOnClick = True
        GroupRichTextResultsByFileToolStripMenuItem.Name = "GroupRichTextResultsByFileToolStripMenuItem"
        GroupRichTextResultsByFileToolStripMenuItem.Size = New Size(310, 26)
        GroupRichTextResultsByFileToolStripMenuItem.Text = "Group Rich Text Results by File"
        ' 
        ' ShowIndividualRichTextResultsToolStripMenuItem
        ' 
        ShowIndividualRichTextResultsToolStripMenuItem.Checked = True
        ShowIndividualRichTextResultsToolStripMenuItem.CheckOnClick = True
        ShowIndividualRichTextResultsToolStripMenuItem.CheckState = CheckState.Checked
        ShowIndividualRichTextResultsToolStripMenuItem.Name = "ShowIndividualRichTextResultsToolStripMenuItem"
        ShowIndividualRichTextResultsToolStripMenuItem.Size = New Size(310, 26)
        ShowIndividualRichTextResultsToolStripMenuItem.Text = "Show Individual Rich Text Results"
        ' 
        ' ToolStripMenuItem16
        ' 
        ToolStripMenuItem16.Name = "ToolStripMenuItem16"
        ToolStripMenuItem16.Size = New Size(307, 6)
        ' 
        ' StatusBarToolStripMenuItem
        ' 
        StatusBarToolStripMenuItem.Checked = True
        StatusBarToolStripMenuItem.CheckOnClick = True
        StatusBarToolStripMenuItem.CheckState = CheckState.Checked
        StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        StatusBarToolStripMenuItem.Size = New Size(310, 26)
        StatusBarToolStripMenuItem.Text = "Status Bar"
        ' 
        ' ScanToolStripMenuItem
        ' 
        ScanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {StartScanningToolStripMenuItem, ToolStripMenuItem4, VisualCodeBreakdownToolStripMenuItem, VisualSecurityBreakdownToolStripMenuItem, VisualBadFuncBreakdownToolStripMenuItem, VisualCommentBreakdownToolStripMenuItem, ToolStripMenuItem7, ExportFixMeCommentsToolStripMenuItem, ToolStripMenuItem12, SortRichTextResultsOnSeverityToolStripMenuItem, SortRichTextResultsOnFileNameToolStripMenuItem, ToolStripMenuItem13, FilterResultsToolStripMenuItem, ToolStripSeparator3, DeleteItemToolStripMenuItem})
        ScanToolStripMenuItem.Name = "ScanToolStripMenuItem"
        ScanToolStripMenuItem.Size = New Size(54, 24)
        ScanToolStripMenuItem.Text = "Scan"
        ' 
        ' StartScanningToolStripMenuItem
        ' 
        StartScanningToolStripMenuItem.Enabled = False
        StartScanningToolStripMenuItem.Name = "StartScanningToolStripMenuItem"
        StartScanningToolStripMenuItem.Size = New Size(456, 26)
        StartScanningToolStripMenuItem.Text = "Full Scan"
        ' 
        ' ToolStripMenuItem4
        ' 
        ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        ToolStripMenuItem4.Size = New Size(453, 6)
        ' 
        ' VisualCodeBreakdownToolStripMenuItem
        ' 
        VisualCodeBreakdownToolStripMenuItem.Enabled = False
        VisualCodeBreakdownToolStripMenuItem.Name = "VisualCodeBreakdownToolStripMenuItem"
        VisualCodeBreakdownToolStripMenuItem.Size = New Size(456, 26)
        VisualCodeBreakdownToolStripMenuItem.Text = "Visual Code/Comment Breakdown"
        ' 
        ' VisualSecurityBreakdownToolStripMenuItem
        ' 
        VisualSecurityBreakdownToolStripMenuItem.Enabled = False
        VisualSecurityBreakdownToolStripMenuItem.Name = "VisualSecurityBreakdownToolStripMenuItem"
        VisualSecurityBreakdownToolStripMenuItem.Size = New Size(456, 26)
        VisualSecurityBreakdownToolStripMenuItem.Text = "Scan Code Only (Ignore Comments)"
        ' 
        ' VisualBadFuncBreakdownToolStripMenuItem
        ' 
        VisualBadFuncBreakdownToolStripMenuItem.Enabled = False
        VisualBadFuncBreakdownToolStripMenuItem.Name = "VisualBadFuncBreakdownToolStripMenuItem"
        VisualBadFuncBreakdownToolStripMenuItem.Size = New Size(456, 26)
        VisualBadFuncBreakdownToolStripMenuItem.Text = "Scan For Bad Functions Only (As Defined in Config File)"
        ' 
        ' VisualCommentBreakdownToolStripMenuItem
        ' 
        VisualCommentBreakdownToolStripMenuItem.Enabled = False
        VisualCommentBreakdownToolStripMenuItem.Name = "VisualCommentBreakdownToolStripMenuItem"
        VisualCommentBreakdownToolStripMenuItem.Size = New Size(456, 26)
        VisualCommentBreakdownToolStripMenuItem.Text = "Scan Comments Only"
        ' 
        ' ToolStripMenuItem7
        ' 
        ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        ToolStripMenuItem7.Size = New Size(453, 6)
        ' 
        ' ExportFixMeCommentsToolStripMenuItem
        ' 
        ExportFixMeCommentsToolStripMenuItem.Enabled = False
        ExportFixMeCommentsToolStripMenuItem.Name = "ExportFixMeCommentsToolStripMenuItem"
        ExportFixMeCommentsToolStripMenuItem.Size = New Size(456, 26)
        ExportFixMeCommentsToolStripMenuItem.Text = "Show All 'FixMe' Comments"
        ' 
        ' ToolStripMenuItem12
        ' 
        ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        ToolStripMenuItem12.Size = New Size(453, 6)
        ' 
        ' SortRichTextResultsOnSeverityToolStripMenuItem
        ' 
        SortRichTextResultsOnSeverityToolStripMenuItem.Name = "SortRichTextResultsOnSeverityToolStripMenuItem"
        SortRichTextResultsOnSeverityToolStripMenuItem.Size = New Size(456, 26)
        SortRichTextResultsOnSeverityToolStripMenuItem.Text = "Sort Rich Text Results on Severity"
        ' 
        ' SortRichTextResultsOnFileNameToolStripMenuItem
        ' 
        SortRichTextResultsOnFileNameToolStripMenuItem.Name = "SortRichTextResultsOnFileNameToolStripMenuItem"
        SortRichTextResultsOnFileNameToolStripMenuItem.Size = New Size(456, 26)
        SortRichTextResultsOnFileNameToolStripMenuItem.Text = "Sort Rich Text Results on FileName"
        ' 
        ' ToolStripMenuItem13
        ' 
        ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        ToolStripMenuItem13.Size = New Size(453, 6)
        ' 
        ' FilterResultsToolStripMenuItem
        ' 
        FilterResultsToolStripMenuItem.Name = "FilterResultsToolStripMenuItem"
        FilterResultsToolStripMenuItem.Size = New Size(456, 26)
        FilterResultsToolStripMenuItem.Text = "Filter Results..."
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(453, 6)
        ' 
        ' DeleteItemToolStripMenuItem
        ' 
        DeleteItemToolStripMenuItem.Name = "DeleteItemToolStripMenuItem"
        DeleteItemToolStripMenuItem.ShortcutKeys = Keys.Delete
        DeleteItemToolStripMenuItem.Size = New Size(456, 26)
        DeleteItemToolStripMenuItem.Text = "Delete Selected Item(s)"
        ' 
        ' SettingsToolStripMenuItem
        ' 
        SettingsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BannedFunctionsToolStripMenuItem, ToolStripMenuItem2, CCToolStripMenuItem, JavaToolStripMenuItem, PLSQLToolStripMenuItem, CSToolStripMenuItem, VBToolStripMenuItem, PHPToolStripMenuItem, COBOLToolStripMenuItem, ToolStripMenuItem3, OptionsToolStripMenuItem})
        SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        SettingsToolStripMenuItem.Size = New Size(76, 24)
        SettingsToolStripMenuItem.Text = "Settings"
        ' 
        ' BannedFunctionsToolStripMenuItem
        ' 
        BannedFunctionsToolStripMenuItem.Name = "BannedFunctionsToolStripMenuItem"
        BannedFunctionsToolStripMenuItem.Size = New Size(277, 26)
        BannedFunctionsToolStripMenuItem.Text = "Banned/Insecure Functions..."
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(274, 6)
        ToolStripMenuItem2.Visible = False
        ' 
        ' CCToolStripMenuItem
        ' 
        CCToolStripMenuItem.Checked = True
        CCToolStripMenuItem.CheckOnClick = True
        CCToolStripMenuItem.CheckState = CheckState.Checked
        CCToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        CCToolStripMenuItem.Name = "CCToolStripMenuItem"
        CCToolStripMenuItem.Size = New Size(277, 26)
        CCToolStripMenuItem.Text = "C/C++"
        CCToolStripMenuItem.Visible = False
        ' 
        ' JavaToolStripMenuItem
        ' 
        JavaToolStripMenuItem.CheckOnClick = True
        JavaToolStripMenuItem.Name = "JavaToolStripMenuItem"
        JavaToolStripMenuItem.Size = New Size(277, 26)
        JavaToolStripMenuItem.Text = "Java"
        JavaToolStripMenuItem.Visible = False
        ' 
        ' PLSQLToolStripMenuItem
        ' 
        PLSQLToolStripMenuItem.CheckOnClick = True
        PLSQLToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        PLSQLToolStripMenuItem.Name = "PLSQLToolStripMenuItem"
        PLSQLToolStripMenuItem.Size = New Size(277, 26)
        PLSQLToolStripMenuItem.Text = "PL/SQL"
        PLSQLToolStripMenuItem.Visible = False
        ' 
        ' CSToolStripMenuItem
        ' 
        CSToolStripMenuItem.CheckOnClick = True
        CSToolStripMenuItem.Name = "CSToolStripMenuItem"
        CSToolStripMenuItem.Size = New Size(277, 26)
        CSToolStripMenuItem.Text = "C#"
        CSToolStripMenuItem.Visible = False
        ' 
        ' VBToolStripMenuItem
        ' 
        VBToolStripMenuItem.CheckOnClick = True
        VBToolStripMenuItem.Name = "VBToolStripMenuItem"
        VBToolStripMenuItem.Size = New Size(277, 26)
        VBToolStripMenuItem.Text = "VB"
        VBToolStripMenuItem.Visible = False
        ' 
        ' PHPToolStripMenuItem
        ' 
        PHPToolStripMenuItem.CheckOnClick = True
        PHPToolStripMenuItem.Name = "PHPToolStripMenuItem"
        PHPToolStripMenuItem.Size = New Size(277, 26)
        PHPToolStripMenuItem.Text = "PHP"
        PHPToolStripMenuItem.Visible = False
        ' 
        ' COBOLToolStripMenuItem
        ' 
        COBOLToolStripMenuItem.CheckOnClick = True
        COBOLToolStripMenuItem.Name = "COBOLToolStripMenuItem"
        COBOLToolStripMenuItem.Size = New Size(277, 26)
        COBOLToolStripMenuItem.Text = "COBOL"
        COBOLToolStripMenuItem.Visible = False
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(274, 6)
        ' 
        ' OptionsToolStripMenuItem
        ' 
        OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        OptionsToolStripMenuItem.Size = New Size(277, 26)
        OptionsToolStripMenuItem.Text = "Options..."
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutVCGToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(55, 24)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' AboutVCGToolStripMenuItem
        ' 
        AboutVCGToolStripMenuItem.Name = "AboutVCGToolStripMenuItem"
        AboutVCGToolStripMenuItem.Size = New Size(165, 26)
        AboutVCGToolStripMenuItem.Text = "About VCG"
        ' 
        ' ssStatusStrip
        ' 
        ssStatusStrip.ImageScalingSize = New Size(20, 20)
        ssStatusStrip.Items.AddRange(New ToolStripItem() {sslLabel})
        ssStatusStrip.Location = New Point(0, 760)
        ssStatusStrip.Name = "ssStatusStrip"
        ssStatusStrip.Padding = New Padding(1, 0, 19, 0)
        ssStatusStrip.Size = New Size(1304, 26)
        ssStatusStrip.TabIndex = 1
        ' 
        ' sslLabel
        ' 
        sslLabel.Name = "sslLabel"
        sslLabel.Size = New Size(125, 20)
        sslLabel.Text = "Language: C/C++"
        ' 
        ' spMain
        ' 
        spMain.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        spMain.IsSplitterFixed = True
        spMain.Location = New Point(0, 37)
        spMain.Margin = New Padding(4, 5, 4, 5)
        spMain.Name = "spMain"
        spMain.Orientation = Orientation.Horizontal
        ' 
        ' spMain.Panel1
        ' 
        spMain.Panel1.Controls.Add(scTarget)
        spMain.Panel1MinSize = 0
        ' 
        ' spMain.Panel2
        ' 
        spMain.Panel2.Controls.Add(tcMain)
        spMain.Panel2MinSize = 0
        spMain.Size = New Size(1304, 715)
        spMain.SplitterDistance = 49
        spMain.SplitterWidth = 6
        spMain.TabIndex = 2
        ' 
        ' scTarget
        ' 
        scTarget.Dock = DockStyle.Fill
        scTarget.Location = New Point(0, 0)
        scTarget.Margin = New Padding(4, 5, 4, 5)
        scTarget.Name = "scTarget"
        ' 
        ' scTarget.Panel1
        ' 
        scTarget.Panel1.Controls.Add(cboTargetDir)
        ' 
        ' scTarget.Panel2
        ' 
        scTarget.Panel2.Controls.Add(cboLanguage)
        scTarget.Size = New Size(1304, 49)
        scTarget.SplitterDistance = 1057
        scTarget.SplitterWidth = 5
        scTarget.TabIndex = 0
        ' 
        ' cboTargetDir
        ' 
        cboTargetDir.AllowDrop = True
        cboTargetDir.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cboTargetDir.AutoCompleteSource = AutoCompleteSource.FileSystem
        cboTargetDir.Dock = DockStyle.Fill
        cboTargetDir.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        cboTargetDir.IntegralHeight = False
        cboTargetDir.ItemHeight = 17
        cboTargetDir.Location = New Point(0, 0)
        cboTargetDir.Margin = New Padding(4, 5, 4, 5)
        cboTargetDir.MaxDropDownItems = 5
        cboTargetDir.Name = "cboTargetDir"
        cboTargetDir.Size = New Size(1057, 25)
        cboTargetDir.TabIndex = 4
        ' 
        ' cboLanguage
        ' 
        cboLanguage.Dock = DockStyle.Fill
        cboLanguage.DropDownWidth = 155
        cboLanguage.FormattingEnabled = True
        cboLanguage.Location = New Point(0, 0)
        cboLanguage.Margin = New Padding(4, 5, 4, 5)
        cboLanguage.Name = "cboLanguage"
        cboLanguage.Size = New Size(242, 28)
        cboLanguage.TabIndex = 6
        ' 
        ' tcMain
        ' 
        tcMain.Controls.Add(tabTargetFiles)
        tcMain.Controls.Add(tabResults)
        tcMain.Controls.Add(tabResultsTable)
        tcMain.Dock = DockStyle.Fill
        tcMain.Location = New Point(0, 0)
        tcMain.Margin = New Padding(4, 5, 4, 5)
        tcMain.Name = "tcMain"
        tcMain.SelectedIndex = 0
        tcMain.Size = New Size(1304, 660)
        tcMain.TabIndex = 0
        ' 
        ' tabTargetFiles
        ' 
        tabTargetFiles.Controls.Add(lbTargets)
        tabTargetFiles.Location = New Point(4, 29)
        tabTargetFiles.Margin = New Padding(4, 5, 4, 5)
        tabTargetFiles.Name = "tabTargetFiles"
        tabTargetFiles.Padding = New Padding(4, 5, 4, 5)
        tabTargetFiles.Size = New Size(1296, 627)
        tabTargetFiles.TabIndex = 0
        tabTargetFiles.Text = "Target Files"
        tabTargetFiles.UseVisualStyleBackColor = True
        ' 
        ' lbTargets
        ' 
        lbTargets.Dock = DockStyle.Fill
        lbTargets.FormattingEnabled = True
        lbTargets.ItemHeight = 20
        lbTargets.Location = New Point(4, 5)
        lbTargets.Margin = New Padding(4, 5, 4, 5)
        lbTargets.Name = "lbTargets"
        lbTargets.Size = New Size(1288, 617)
        lbTargets.TabIndex = 0
        ' 
        ' tabResults
        ' 
        tabResults.Controls.Add(rtbResults)
        tabResults.Location = New Point(4, 29)
        tabResults.Margin = New Padding(4, 5, 4, 5)
        tabResults.Name = "tabResults"
        tabResults.Padding = New Padding(4, 5, 4, 5)
        tabResults.Size = New Size(1296, 627)
        tabResults.TabIndex = 1
        tabResults.Text = "Results"
        tabResults.UseVisualStyleBackColor = True
        ' 
        ' rtbResults
        ' 
        rtbResults.DetectUrls = False
        rtbResults.Dock = DockStyle.Fill
        rtbResults.Location = New Point(4, 5)
        rtbResults.Margin = New Padding(4, 5, 4, 5)
        rtbResults.Name = "rtbResults"
        rtbResults.Size = New Size(1288, 617)
        rtbResults.TabIndex = 0
        rtbResults.Text = ""
        ' 
        ' tabResultsTable
        ' 
        tabResultsTable.Controls.Add(lvResults)
        tabResultsTable.Location = New Point(4, 29)
        tabResultsTable.Margin = New Padding(4, 5, 4, 5)
        tabResultsTable.Name = "tabResultsTable"
        tabResultsTable.Padding = New Padding(4, 5, 4, 5)
        tabResultsTable.Size = New Size(1296, 627)
        tabResultsTable.TabIndex = 2
        tabResultsTable.Text = "Summary Table"
        tabResultsTable.UseVisualStyleBackColor = True
        ' 
        ' lvResults
        ' 
        lvResults.AllowColumnReorder = True
        lvResults.CheckBoxes = True
        lvResults.Columns.AddRange(New ColumnHeader() {chSeverityRanking, chSeverity, chTitle, chDescription, chFileName, chLine})
        lvResults.Dock = DockStyle.Fill
        lvResults.FullRowSelect = True
        lvResults.LabelWrap = False
        lvResults.Location = New Point(4, 5)
        lvResults.Margin = New Padding(4, 5, 4, 5)
        lvResults.Name = "lvResults"
        lvResults.Size = New Size(1288, 617)
        lvResults.TabIndex = 0
        lvResults.UseCompatibleStateImageBehavior = False
        lvResults.View = View.Details
        ' 
        ' chSeverityRanking
        ' 
        chSeverityRanking.Text = "Priority"
        chSeverityRanking.Width = 43
        ' 
        ' chSeverity
        ' 
        chSeverity.Text = "Severity"
        chSeverity.Width = 75
        ' 
        ' chTitle
        ' 
        chTitle.Text = "Title"
        chTitle.Width = 229
        ' 
        ' chDescription
        ' 
        chDescription.Text = "Description"
        chDescription.Width = 399
        ' 
        ' chFileName
        ' 
        chFileName.Text = "FileName"
        chFileName.Width = 378
        ' 
        ' chLine
        ' 
        chLine.Text = "Line"
        ' 
        ' ofdOpenFileDialog
        ' 
        ofdOpenFileDialog.FileName = "XmlResults"
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1304, 786)
        Controls.Add(spMain)
        Controls.Add(ssStatusStrip)
        Controls.Add(mnuMain)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = mnuMain
        Margin = New Padding(4, 5, 4, 5)
        Name = "frmMain"
        Text = "VCG"
        mnuMain.ResumeLayout(False)
        mnuMain.PerformLayout()
        ssStatusStrip.ResumeLayout(False)
        ssStatusStrip.PerformLayout()
        spMain.Panel1.ResumeLayout(False)
        spMain.Panel2.ResumeLayout(False)
        CType(spMain, ComponentModel.ISupportInitialize).EndInit()
        spMain.ResumeLayout(False)
        scTarget.Panel1.ResumeLayout(False)
        scTarget.Panel2.ResumeLayout(False)
        CType(scTarget, ComponentModel.ISupportInitialize).EndInit()
        scTarget.ResumeLayout(False)
        tcMain.ResumeLayout(False)
        tabTargetFiles.ResumeLayout(False)
        tabResults.ResumeLayout(False)
        tabResultsTable.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
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

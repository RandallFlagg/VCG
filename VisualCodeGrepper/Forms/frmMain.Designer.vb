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
        components = New ComponentModel.Container()
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
        cmFullContextMenu = New ContextMenuStrip(components)
        menuItem1Cut = New ToolStripMenuItem()
        menuItem2Copy = New ToolStripMenuItem()
        menuItem3Paste = New ToolStripMenuItem()
        menuItem4Divider = New ToolStripMenuItem()
        menuItem5SelectAll = New ToolStripMenuItem()
        menuItem6Copy = New ToolStripMenuItem()
        menuItem9Divider = New ToolStripMenuItem()
        menuItem10SelectAll = New ToolStripMenuItem()
        menuItem7Divider = New ToolStripMenuItem()
        menuItem8Find = New ToolStripMenuItem()
        menuItem13Divider = New ToolStripMenuItem()
        menuItem11Sort = New ToolStripMenuItem()
        menuItem12Sort = New ToolStripMenuItem()
        menuItem18Divider = New ToolStripMenuItem()
        menuItem19FilterResults = New ToolStripMenuItem()
        menuItem20ExportFiltered = New ToolStripMenuItem()
        menuItem14OpenFile = New ToolStripMenuItem()
        menuItem15OpenAtLine = New ToolStripMenuItem()
        menuItem16Divider = New ToolStripMenuItem()
        menuItem17Order = New ToolStripMenuItem()
        menuItem21Divider = New ToolStripMenuItem()
        menuItem22FilterResults = New ToolStripMenuItem()
        menuItem23ExportFiltered = New ToolStripMenuItem()
        menuItem24Divider = New ToolStripMenuItem()
        menuItem25SelectColour = New ToolStripMenuItem()
        menuItem28ChangeSeverity = New ToolStripMenuItem()
        menuItem26Divider = New ToolStripMenuItem()
        menuItem27DeleteItem = New ToolStripMenuItem()
        cmResultsContextMenu = New ContextMenuStrip(components)
        cmResultsListContextMenu = New ContextMenuStrip(components)
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
        cmFullContextMenu.SuspendLayout()
        cmResultsContextMenu.SuspendLayout()
        cmResultsListContextMenu.SuspendLayout()
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
        mnuMain.Size = New Size(1304, 28)
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
        ' cmFullContextMenu
        ' 
        cmFullContextMenu.ImageScalingSize = New Size(20, 20)
        cmFullContextMenu.Items.AddRange(New ToolStripItem() {menuItem1Cut, menuItem2Copy, menuItem3Paste, menuItem4Divider, menuItem5SelectAll})
        cmFullContextMenu.Name = "cmFullContextMenu"
        cmFullContextMenu.Size = New Size(141, 124)
        ' 
        ' menuItem1Cut
        ' 
        menuItem1Cut.Name = "menuItem1Cut"
        menuItem1Cut.Size = New Size(140, 24)
        menuItem1Cut.Text = "Cut"
        ' 
        ' menuItem2Copy
        ' 
        menuItem2Copy.Name = "menuItem2Copy"
        menuItem2Copy.Size = New Size(140, 24)
        menuItem2Copy.Text = "Copy"
        ' 
        ' menuItem3Paste
        ' 
        menuItem3Paste.Name = "menuItem3Paste"
        menuItem3Paste.Size = New Size(140, 24)
        menuItem3Paste.Text = "Paste"
        ' 
        ' menuItem4Divider
        ' 
        menuItem4Divider.Name = "menuItem4Divider"
        menuItem4Divider.Size = New Size(140, 24)
        menuItem4Divider.Text = "-"
        ' 
        ' menuItem5SelectAll
        ' 
        menuItem5SelectAll.Name = "menuItem5SelectAll"
        menuItem5SelectAll.Size = New Size(140, 24)
        menuItem5SelectAll.Text = "Select All"
        ' 
        ' menuItem6Copy
        ' 
        menuItem6Copy.Name = "menuItem6Copy"
        menuItem6Copy.Size = New Size(267, 24)
        menuItem6Copy.Text = "Copy"
        ' 
        ' menuItem9Divider
        ' 
        menuItem9Divider.Name = "menuItem9Divider"
        menuItem9Divider.Size = New Size(267, 24)
        menuItem9Divider.Text = "-"
        ' 
        ' menuItem10SelectAll
        ' 
        menuItem10SelectAll.Name = "menuItem10SelectAll"
        menuItem10SelectAll.Size = New Size(267, 24)
        menuItem10SelectAll.Text = "Select All"
        ' 
        ' menuItem7Divider
        ' 
        menuItem7Divider.Name = "menuItem7Divider"
        menuItem7Divider.Size = New Size(267, 24)
        menuItem7Divider.Text = "-"
        ' 
        ' menuItem8Find
        ' 
        menuItem8Find.Name = "menuItem8Find"
        menuItem8Find.Size = New Size(267, 24)
        menuItem8Find.Text = "Find"
        ' 
        ' menuItem13Divider
        ' 
        menuItem13Divider.Name = "menuItem13Divider"
        menuItem13Divider.Size = New Size(267, 24)
        menuItem13Divider.Text = "-"
        ' 
        ' menuItem11Sort
        ' 
        menuItem11Sort.Name = "menuItem11Sort"
        menuItem11Sort.Size = New Size(267, 24)
        menuItem11Sort.Text = "Sort on Severity"
        ' 
        ' menuItem12Sort
        ' 
        menuItem12Sort.Name = "menuItem12Sort"
        menuItem12Sort.Size = New Size(267, 24)
        menuItem12Sort.Text = "Sort on FileName"
        ' 
        ' menuItem18Divider
        ' 
        menuItem18Divider.Name = "menuItem18Divider"
        menuItem18Divider.Size = New Size(267, 24)
        menuItem18Divider.Text = "-"
        ' 
        ' menuItem19FilterResults
        ' 
        menuItem19FilterResults.Name = "menuItem19FilterResults"
        menuItem19FilterResults.Size = New Size(267, 24)
        menuItem19FilterResults.Text = "Filter Results..."
        ' 
        ' menuItem20ExportFiltered
        ' 
        menuItem20ExportFiltered.Name = "menuItem20ExportFiltered"
        menuItem20ExportFiltered.Size = New Size(267, 24)
        menuItem20ExportFiltered.Text = "Export Filtered XML Results..."
        ' 
        ' menuItem14OpenFile
        ' 
        menuItem14OpenFile.Name = "menuItem14OpenFile"
        menuItem14OpenFile.Size = New Size(330, 24)
        menuItem14OpenFile.Text = "Open Code in Associated Editor"
        ' 
        ' menuItem15OpenAtLine
        ' 
        menuItem15OpenAtLine.Name = "menuItem15OpenAtLine"
        menuItem15OpenAtLine.Size = New Size(330, 24)
        menuItem15OpenAtLine.Text = "Open Code at This Line in Notepad++"
        ' 
        ' menuItem16Divider
        ' 
        menuItem16Divider.Name = "menuItem16Divider"
        menuItem16Divider.Size = New Size(330, 24)
        menuItem16Divider.Text = "-"
        ' 
        ' menuItem17Order
        ' 
        menuItem17Order.Name = "menuItem17Order"
        menuItem17Order.Size = New Size(330, 24)
        menuItem17Order.Text = "Order on Multiple Columns..."
        ' 
        ' menuItem21Divider
        ' 
        menuItem21Divider.Name = "menuItem21Divider"
        menuItem21Divider.Size = New Size(330, 24)
        menuItem21Divider.Text = "-"
        ' 
        ' menuItem22FilterResults
        ' 
        menuItem22FilterResults.Name = "menuItem22FilterResults"
        menuItem22FilterResults.Size = New Size(330, 24)
        menuItem22FilterResults.Text = "Filter Results..."
        ' 
        ' menuItem23ExportFiltered
        ' 
        menuItem23ExportFiltered.Name = "menuItem23ExportFiltered"
        menuItem23ExportFiltered.Size = New Size(330, 24)
        menuItem23ExportFiltered.Text = "Export Filtered XML Results..."
        ' 
        ' menuItem24Divider
        ' 
        menuItem24Divider.Name = "menuItem24Divider"
        menuItem24Divider.Size = New Size(330, 24)
        menuItem24Divider.Text = "-"
        ' 
        ' menuItem25SelectColour
        ' 
        menuItem25SelectColour.Name = "menuItem25SelectColour"
        menuItem25SelectColour.Size = New Size(330, 24)
        menuItem25SelectColour.Text = "Select Colour When Checked..."
        ' 
        ' menuItem28ChangeSeverity
        ' 
        menuItem28ChangeSeverity.Name = "menuItem28ChangeSeverity"
        menuItem28ChangeSeverity.Size = New Size(330, 24)
        menuItem28ChangeSeverity.Text = "Change Severity..."
        ' 
        ' menuItem26Divider
        ' 
        menuItem26Divider.Name = "menuItem26Divider"
        menuItem26Divider.Size = New Size(330, 24)
        menuItem26Divider.Text = "-"
        ' 
        ' menuItem27DeleteItem
        ' 
        menuItem27DeleteItem.Name = "menuItem27DeleteItem"
        menuItem27DeleteItem.Size = New Size(330, 24)
        menuItem27DeleteItem.Text = "Delete Selected Item(s)"
        ' 
        ' cmResultsContextMenu
        ' 
        cmResultsContextMenu.ImageScalingSize = New Size(20, 20)
        cmResultsContextMenu.Items.AddRange(New ToolStripItem() {menuItem6Copy, menuItem9Divider, menuItem10SelectAll, menuItem7Divider, menuItem8Find, menuItem13Divider, menuItem11Sort, menuItem12Sort, menuItem18Divider, menuItem19FilterResults, menuItem20ExportFiltered})
        cmResultsContextMenu.Name = "cmResultsContextMenu"
        cmResultsContextMenu.Size = New Size(268, 268)
        ' 
        ' cmResultsListContextMenu
        ' 
        cmResultsListContextMenu.ImageScalingSize = New Size(20, 20)
        cmResultsListContextMenu.Items.AddRange(New ToolStripItem() {menuItem14OpenFile, menuItem15OpenAtLine, menuItem16Divider, menuItem17Order, menuItem21Divider, menuItem22FilterResults, menuItem23ExportFiltered, menuItem24Divider, menuItem25SelectColour, menuItem28ChangeSeverity, menuItem26Divider, menuItem27DeleteItem})
        cmResultsListContextMenu.Name = "cmResultsListContextMenu"
        cmResultsListContextMenu.Size = New Size(331, 292)
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
        spMain.Location = New Point(0, 38)
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
        spMain.SplitterDistance = 48
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
        scTarget.Size = New Size(1304, 48)
        scTarget.SplitterDistance = 1057
        scTarget.SplitterWidth = 5
        scTarget.TabIndex = 0
        ' 
        ' cboTargetDir
        ' 
        cboTargetDir.AllowDrop = True
        cboTargetDir.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cboTargetDir.AutoCompleteSource = AutoCompleteSource.FileSystem
        cboTargetDir.ContextMenuStrip = cmFullContextMenu
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
        tcMain.Size = New Size(1304, 661)
        tcMain.TabIndex = 0
        ' 
        ' tabTargetFiles
        ' 
        tabTargetFiles.Controls.Add(lbTargets)
        tabTargetFiles.Location = New Point(4, 29)
        tabTargetFiles.Margin = New Padding(4, 5, 4, 5)
        tabTargetFiles.Name = "tabTargetFiles"
        tabTargetFiles.Padding = New Padding(4, 5, 4, 5)
        tabTargetFiles.Size = New Size(1296, 628)
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
        lbTargets.Size = New Size(1288, 618)
        lbTargets.TabIndex = 0
        ' 
        ' tabResults
        ' 
        tabResults.Controls.Add(rtbResults)
        tabResults.Location = New Point(4, 29)
        tabResults.Margin = New Padding(4, 5, 4, 5)
        tabResults.Name = "tabResults"
        tabResults.Padding = New Padding(4, 5, 4, 5)
        tabResults.Size = New Size(1296, 628)
        tabResults.TabIndex = 1
        tabResults.Text = "Results"
        tabResults.UseVisualStyleBackColor = True
        ' 
        ' rtbResults
        ' 
        rtbResults.ContextMenuStrip = cmResultsContextMenu
        rtbResults.DetectUrls = False
        rtbResults.Dock = DockStyle.Fill
        rtbResults.Location = New Point(4, 5)
        rtbResults.Margin = New Padding(4, 5, 4, 5)
        rtbResults.Name = "rtbResults"
        rtbResults.Size = New Size(1288, 618)
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
        tabResultsTable.Size = New Size(1296, 628)
        tabResultsTable.TabIndex = 2
        tabResultsTable.Text = "Summary Table"
        tabResultsTable.UseVisualStyleBackColor = True
        ' 
        ' lvResults
        ' 
        lvResults.AllowColumnReorder = True
        lvResults.CheckBoxes = True
        lvResults.Columns.AddRange(New ColumnHeader() {chSeverityRanking, chSeverity, chTitle, chDescription, chFileName, chLine})
        lvResults.ContextMenuStrip = cmResultsListContextMenu
        lvResults.Dock = DockStyle.Fill
        lvResults.FullRowSelect = True
        lvResults.LabelWrap = False
        lvResults.Location = New Point(4, 5)
        lvResults.Margin = New Padding(4, 5, 4, 5)
        lvResults.Name = "lvResults"
        lvResults.Size = New Size(1288, 618)
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
        cmFullContextMenu.ResumeLayout(False)
        cmResultsContextMenu.ResumeLayout(False)
        cmResultsListContextMenu.ResumeLayout(False)
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

    Private WithEvents mnuMain As MenuStrip
    Private WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Private WithEvents NewTargetToolStripMenuItem As ToolStripMenuItem
    Private WithEvents SaveResultsToolStripMenuItem As ToolStripMenuItem
    Private WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Private WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Private WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Private WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Private WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Private WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Private WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Private WithEvents BannedFunctionsToolStripMenuItem As ToolStripMenuItem
    Private WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Private WithEvents CCToolStripMenuItem As ToolStripMenuItem
    Private WithEvents JavaToolStripMenuItem As ToolStripMenuItem
    Private WithEvents PLSQLToolStripMenuItem As ToolStripMenuItem
    Private WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Private WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Private WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Private WithEvents AboutVCGToolStripMenuItem As ToolStripMenuItem
    Private WithEvents fbFolderBrowser As FolderBrowserDialog
    Private WithEvents ssStatusStrip As StatusStrip
    Private WithEvents spMain As SplitContainer
    Private WithEvents ScanToolStripMenuItem As ToolStripMenuItem
    Private WithEvents StartScanningToolStripMenuItem As ToolStripMenuItem
    Private WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Private WithEvents VisualCodeBreakdownToolStripMenuItem As ToolStripMenuItem
    Private WithEvents VisualSecurityBreakdownToolStripMenuItem As ToolStripMenuItem
    Private WithEvents FindToolStripMenuItem As ToolStripMenuItem
    Private WithEvents ToolStripMenuItem6 As ToolStripSeparator
    Private WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Private WithEvents ToolStripMenuItem7 As ToolStripSeparator
    Private WithEvents ExportFixMeCommentsToolStripMenuItem As ToolStripMenuItem
    Private WithEvents sslLabel As ToolStripStatusLabel
    Private WithEvents sfdSaveFileDialog As SaveFileDialog
    Private WithEvents ToolStripMenuItem8 As ToolStripSeparator
    Private WithEvents ToolStripMenuItem5 As ToolStripSeparator
    Private WithEvents ClearResultsMenuItem As ToolStripMenuItem
    Private WithEvents ofdOpenFileDialog As OpenFileDialog
    Private WithEvents ExportResultsXMLMenuItem As ToolStripMenuItem
    Private WithEvents ImportXmlResultsMenuItem As ToolStripMenuItem
    Private WithEvents ToolStripSeparator1 As ToolStripSeparator
    Private WithEvents ToolStripMenuItem12 As ToolStripSeparator
    Private WithEvents SortRichTextResultsOnSeverityToolStripMenuItem As ToolStripMenuItem
    Private WithEvents SortRichTextResultsOnFileNameToolStripMenuItem As ToolStripMenuItem
    Private WithEvents CSToolStripMenuItem As ToolStripMenuItem
    Private WithEvents ToolStripMenuItem13 As ToolStripSeparator
    Private WithEvents FilterResultsToolStripMenuItem As ToolStripMenuItem
    Private WithEvents VBToolStripMenuItem As ToolStripMenuItem
    Private WithEvents PHPToolStripMenuItem As ToolStripMenuItem
    Private WithEvents COBOLToolStripMenuItem As ToolStripMenuItem
    Private WithEvents VisualCommentBreakdownToolStripMenuItem As ToolStripMenuItem
    Private WithEvents NewTargetFileToolStripMenuItem As ToolStripMenuItem
    Private WithEvents cdColorDialog As ColorDialog
    Private WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Private WithEvents GroupRichTextResultsByIssueToolStripMenuItem As ToolStripMenuItem
    Private WithEvents GroupRichTextResultsByFileToolStripMenuItem As ToolStripMenuItem
    Private WithEvents ExportCsvResultsMenuItem As ToolStripMenuItem
    Private WithEvents ImportCsvResultsMenuItem As ToolStripMenuItem
    Private WithEvents ToolStripSeparator2 As ToolStripSeparator
    Private WithEvents ShowIndividualRichTextResultsToolStripMenuItem As ToolStripMenuItem
    Private WithEvents ToolStripSeparator3 As ToolStripSeparator
    Private WithEvents DeleteItemToolStripMenuItem As ToolStripMenuItem
    Private WithEvents ToolStripMenuItem16 As ToolStripSeparator
    Private WithEvents StatusBarToolStripMenuItem As ToolStripMenuItem
    Private WithEvents VisualBadFuncBreakdownToolStripMenuItem As ToolStripMenuItem
    Private WithEvents ToolStripSeparator4 As ToolStripSeparator
    Private WithEvents ExportMetaDataToolStripMenuItem As ToolStripMenuItem
    Private WithEvents tcMain As TabControl
    Private WithEvents tabTargetFiles As TabPage
    Private WithEvents lbTargets As ListBox
    Private WithEvents tabResults As TabPage
    Friend WithEvents rtbResults As RichTextBox
    Private WithEvents tabResultsTable As TabPage
    Private WithEvents lvResults As ListView
    Private WithEvents chSeverityRanking As ColumnHeader
    Private WithEvents chSeverity As ColumnHeader
    Private WithEvents chTitle As ColumnHeader
    Private WithEvents chDescription As ColumnHeader
    Private WithEvents chFileName As ColumnHeader
    Private WithEvents chLine As ColumnHeader
    Private WithEvents scTarget As SplitContainer
    Private WithEvents cboTargetDir As ComboBox
    Private WithEvents cboLanguage As ComboBox
    Private WithEvents cmFullContextMenu As ContextMenuStrip        ' The filenames combobox allows cut/copy/paste
    Private WithEvents cmResultsContextMenu As ContextMenuStrip     ' The results are just for copying, not modification
    Private WithEvents cmResultsListContextMenu As ContextMenuStrip ' The results table allows a file to be opened in its associated app or Notepad++

    ' ComboBox Context Menu Items
    Private WithEvents menuItem1Cut As ToolStripMenuItem
    Private WithEvents menuItem2Copy As ToolStripMenuItem
    Private WithEvents menuItem3Paste As ToolStripMenuItem
    Private WithEvents menuItem4Divider As ToolStripMenuItem
    Private WithEvents menuItem5SelectAll As ToolStripMenuItem

    ' RichTextBox Context Menu Items
    Private WithEvents menuItem6Copy As ToolStripMenuItem
    Private WithEvents menuItem9Divider As ToolStripMenuItem
    Private WithEvents menuItem10SelectAll As ToolStripMenuItem
    Private WithEvents menuItem7Divider As ToolStripMenuItem
    Private WithEvents menuItem8Find As ToolStripMenuItem
    Private WithEvents menuItem13Divider As ToolStripMenuItem
    Private WithEvents menuItem11Sort As ToolStripMenuItem
    Private WithEvents menuItem12Sort As ToolStripMenuItem
    Private WithEvents menuItem18Divider As ToolStripMenuItem
    Private WithEvents menuItem19FilterResults As ToolStripMenuItem
    Private WithEvents menuItem20ExportFiltered As ToolStripMenuItem

    ' ListBox Context Menu Items
    Private WithEvents menuItem14OpenFile As ToolStripMenuItem
    Private WithEvents menuItem15OpenAtLine As ToolStripMenuItem
    Private WithEvents menuItem16Divider As ToolStripMenuItem
    Private WithEvents menuItem17Order As ToolStripMenuItem
    Private WithEvents menuItem21Divider As ToolStripMenuItem
    Private WithEvents menuItem22FilterResults As ToolStripMenuItem
    Private WithEvents menuItem23ExportFiltered As ToolStripMenuItem
    Private WithEvents menuItem24Divider As ToolStripMenuItem
    Private WithEvents menuItem25SelectColour As ToolStripMenuItem
    Private WithEvents menuItem28ChangeSeverity As ToolStripMenuItem
    Private WithEvents menuItem26Divider As ToolStripMenuItem
    Private WithEvents menuItem27DeleteItem As ToolStripMenuItem
End Class

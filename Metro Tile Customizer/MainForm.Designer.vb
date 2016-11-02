<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits MetroFramework.Forms.MetroForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Tab_Main = New MetroFramework.Controls.MetroTabControl()
        Me.TabPage_Main = New MetroFramework.Controls.MetroTabPage()
        Me.HexColor = New MetroFramework.Controls.MetroTextBox()
        Me.LinkPath = New System.Windows.Forms.TextBox()
        Me.TilePreview = New MetroFramework.Controls.MetroTile()
        Me.TileMenu = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.OpenFileLocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenTargetFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.opt_Text_Light = New MetroFramework.Controls.MetroRadioButton()
        Me.opt_Text_Dark = New MetroFramework.Controls.MetroRadioButton()
        Me.Button2_Restore = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.Button1_Colorize = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.Switch_NameOnTile = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.ComboBox = New MetroFramework.Controls.MetroComboBox()
        Me.HiddenComboBox = New MetroFramework.Controls.MetroComboBox()
        Me.TabPage_About = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.TabPage_License = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.Tab_Colors = New MetroFramework.Controls.MetroTabControl()
        Me.TabPage_Color = New MetroFramework.Controls.MetroTabPage()
        Me.MainColorPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.TabPage_ColorOther = New MetroFramework.Controls.MetroTabPage()
        Me.OtherColorPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.TabPage_Accent = New MetroFramework.Controls.MetroTabPage()
        Me.AccentPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.ThemeManager = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.Tab_Main.SuspendLayout()
        Me.TabPage_Main.SuspendLayout()
        Me.TileMenu.SuspendLayout()
        Me.TabPage_About.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_License.SuspendLayout()
        Me.Tab_Colors.SuspendLayout()
        Me.TabPage_Color.SuspendLayout()
        Me.TabPage_ColorOther.SuspendLayout()
        Me.TabPage_Accent.SuspendLayout()
        CType(Me.ThemeManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tab_Main
        '
        Me.Tab_Main.Controls.Add(Me.TabPage_Main)
        Me.Tab_Main.Controls.Add(Me.TabPage_About)
        Me.Tab_Main.Controls.Add(Me.TabPage_License)
        Me.Tab_Main.Dock = System.Windows.Forms.DockStyle.Left
        Me.Tab_Main.Location = New System.Drawing.Point(20, 60)
        Me.Tab_Main.Name = "Tab_Main"
        Me.Tab_Main.SelectedIndex = 1
        Me.Tab_Main.Size = New System.Drawing.Size(411, 342)
        Me.Tab_Main.TabIndex = 3
        Me.Tab_Main.UseSelectable = True
        '
        'TabPage_Main
        '
        Me.TabPage_Main.Controls.Add(Me.HexColor)
        Me.TabPage_Main.Controls.Add(Me.LinkPath)
        Me.TabPage_Main.Controls.Add(Me.TilePreview)
        Me.TabPage_Main.Controls.Add(Me.MetroLabel5)
        Me.TabPage_Main.Controls.Add(Me.opt_Text_Light)
        Me.TabPage_Main.Controls.Add(Me.opt_Text_Dark)
        Me.TabPage_Main.Controls.Add(Me.Button2_Restore)
        Me.TabPage_Main.Controls.Add(Me.Button1_Colorize)
        Me.TabPage_Main.Controls.Add(Me.MetroLabel4)
        Me.TabPage_Main.Controls.Add(Me.MetroLabel3)
        Me.TabPage_Main.Controls.Add(Me.Switch_NameOnTile)
        Me.TabPage_Main.Controls.Add(Me.MetroLabel2)
        Me.TabPage_Main.Controls.Add(Me.MetroLabel1)
        Me.TabPage_Main.Controls.Add(Me.ComboBox)
        Me.TabPage_Main.Controls.Add(Me.HiddenComboBox)
        Me.TabPage_Main.HorizontalScrollbarBarColor = True
        Me.TabPage_Main.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage_Main.HorizontalScrollbarSize = 10
        Me.TabPage_Main.Location = New System.Drawing.Point(4, 38)
        Me.TabPage_Main.Name = "TabPage_Main"
        Me.TabPage_Main.Size = New System.Drawing.Size(403, 300)
        Me.TabPage_Main.TabIndex = 0
        Me.TabPage_Main.Text = "Main Page"
        Me.TabPage_Main.VerticalScrollbarBarColor = True
        Me.TabPage_Main.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage_Main.VerticalScrollbarSize = 10
        '
        'HexColor
        '
        Me.HexColor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.HexColor.CustomButton.Image = Nothing
        Me.HexColor.CustomButton.Location = New System.Drawing.Point(-20, 2)
        Me.HexColor.CustomButton.Name = ""
        Me.HexColor.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.HexColor.CustomButton.Style = MetroFramework.MetroColorStyle.Green
        Me.HexColor.CustomButton.TabIndex = 1
        Me.HexColor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.HexColor.CustomButton.UseSelectable = True
        Me.HexColor.CustomButton.Visible = False
        Me.HexColor.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.HexColor.Lines = New String(-1) {}
        Me.HexColor.Location = New System.Drawing.Point(141, 146)
        Me.HexColor.MaxLength = 32767
        Me.HexColor.Name = "HexColor"
        Me.HexColor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.HexColor.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.HexColor.SelectedText = ""
        Me.HexColor.SelectionLength = 0
        Me.HexColor.SelectionStart = 0
        Me.HexColor.Size = New System.Drawing.Size(70, 22)
        Me.HexColor.TabIndex = 2
        Me.HexColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.HexColor.UseSelectable = True
        Me.HexColor.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.HexColor.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'LinkPath
        '
        Me.LinkPath.BackColor = System.Drawing.Color.White
        Me.LinkPath.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LinkPath.Enabled = False
        Me.LinkPath.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkPath.Location = New System.Drawing.Point(3, 67)
        Me.LinkPath.Multiline = True
        Me.LinkPath.Name = "LinkPath"
        Me.LinkPath.ReadOnly = True
        Me.LinkPath.Size = New System.Drawing.Size(397, 30)
        Me.LinkPath.TabIndex = 21
        '
        'TilePreview
        '
        Me.TilePreview.ActiveControl = Nothing
        Me.TilePreview.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.TilePreview.ContextMenuStrip = Me.TileMenu
        Me.TilePreview.ForeColor = System.Drawing.Color.White
        Me.TilePreview.Location = New System.Drawing.Point(4, 119)
        Me.TilePreview.Name = "TilePreview"
        Me.TilePreview.Size = New System.Drawing.Size(105, 100)
        Me.TilePreview.TabIndex = 18
        Me.TilePreview.Text = "Name"
        Me.TilePreview.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.TilePreview.TileTextFontSize = MetroFramework.MetroTileTextSize.Small
        Me.TilePreview.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.TilePreview.UseCustomBackColor = True
        Me.TilePreview.UseCustomForeColor = True
        Me.TilePreview.UseSelectable = True
        Me.TilePreview.UseTileImage = True
        '
        'TileMenu
        '
        Me.TileMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.TileMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TileMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenFileLocationToolStripMenuItem, Me.OpenTargetFileToolStripMenuItem})
        Me.TileMenu.Name = "TileMenu"
        Me.TileMenu.Size = New System.Drawing.Size(184, 48)
        Me.TileMenu.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TileMenu.UseStyleColors = True
        '
        'OpenFileLocationToolStripMenuItem
        '
        Me.OpenFileLocationToolStripMenuItem.Name = "OpenFileLocationToolStripMenuItem"
        Me.OpenFileLocationToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.OpenFileLocationToolStripMenuItem.Text = "Open file location"
        '
        'OpenTargetFileToolStripMenuItem
        '
        Me.OpenTargetFileToolStripMenuItem.Name = "OpenTargetFileToolStripMenuItem"
        Me.OpenTargetFileToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.OpenTargetFileToolStripMenuItem.Text = "Open target location"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel5.Location = New System.Drawing.Point(3, 100)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(45, 15)
        Me.MetroLabel5.TabIndex = 14
        Me.MetroLabel5.Text = "Preview"
        '
        'opt_Text_Light
        '
        Me.opt_Text_Light.AutoSize = True
        Me.opt_Text_Light.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.opt_Text_Light.Location = New System.Drawing.Point(221, 200)
        Me.opt_Text_Light.Name = "opt_Text_Light"
        Me.opt_Text_Light.Size = New System.Drawing.Size(56, 19)
        Me.opt_Text_Light.TabIndex = 13
        Me.opt_Text_Light.Text = "Light"
        Me.opt_Text_Light.UseSelectable = True
        '
        'opt_Text_Dark
        '
        Me.opt_Text_Dark.AutoSize = True
        Me.opt_Text_Dark.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.opt_Text_Dark.Location = New System.Drawing.Point(294, 200)
        Me.opt_Text_Dark.Name = "opt_Text_Dark"
        Me.opt_Text_Dark.Size = New System.Drawing.Size(54, 19)
        Me.opt_Text_Dark.TabIndex = 12
        Me.opt_Text_Dark.Text = "Dark"
        Me.opt_Text_Dark.UseSelectable = True
        '
        'Button2_Restore
        '
        Me.Button2_Restore.Image = Nothing
        Me.Button2_Restore.Location = New System.Drawing.Point(3, 254)
        Me.Button2_Restore.Name = "Button2_Restore"
        Me.Button2_Restore.Size = New System.Drawing.Size(189, 37)
        Me.Button2_Restore.Style = MetroFramework.MetroColorStyle.Green
        Me.Button2_Restore.TabIndex = 11
        Me.Button2_Restore.Text = "Restore Defaults"
        Me.Button2_Restore.UseCustomBackColor = True
        Me.Button2_Restore.UseSelectable = True
        Me.Button2_Restore.UseStyleColors = True
        Me.Button2_Restore.UseVisualStyleBackColor = True
        '
        'Button1_Colorize
        '
        Me.Button1_Colorize.Image = Nothing
        Me.Button1_Colorize.Location = New System.Drawing.Point(211, 254)
        Me.Button1_Colorize.Name = "Button1_Colorize"
        Me.Button1_Colorize.Size = New System.Drawing.Size(189, 37)
        Me.Button1_Colorize.Style = MetroFramework.MetroColorStyle.Green
        Me.Button1_Colorize.TabIndex = 10
        Me.Button1_Colorize.Text = "Apply"
        Me.Button1_Colorize.UseCustomBackColor = True
        Me.Button1_Colorize.UseSelectable = True
        Me.Button1_Colorize.UseStyleColors = True
        Me.Button1_Colorize.UseVisualStyleBackColor = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(141, 200)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(72, 19)
        Me.MetroLabel4.TabIndex = 7
        Me.MetroLabel4.Text = "Text Color:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(270, 125)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(83, 19)
        Me.MetroLabel3.TabIndex = 4
        Me.MetroLabel3.Text = "Show Name:"
        '
        'Switch_NameOnTile
        '
        Me.Switch_NameOnTile.AutoSize = True
        Me.Switch_NameOnTile.Location = New System.Drawing.Point(270, 151)
        Me.Switch_NameOnTile.Name = "Switch_NameOnTile"
        Me.Switch_NameOnTile.Size = New System.Drawing.Size(80, 17)
        Me.Switch_NameOnTile.TabIndex = 6
        Me.Switch_NameOnTile.Text = "Off"
        Me.Switch_NameOnTile.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(141, 125)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(70, 19)
        Me.MetroLabel2.TabIndex = 5
        Me.MetroLabel2.Text = "Tile Color:"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(3, 14)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(155, 19)
        Me.MetroLabel1.TabIndex = 3
        Me.MetroLabel1.Text = "Choose Start Menu Item:"
        '
        'ComboBox
        '
        Me.ComboBox.DropDownHeight = 200
        Me.ComboBox.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.ComboBox.FormattingEnabled = True
        Me.ComboBox.IntegralHeight = False
        Me.ComboBox.ItemHeight = 19
        Me.ComboBox.Location = New System.Drawing.Point(3, 36)
        Me.ComboBox.Name = "ComboBox"
        Me.ComboBox.Size = New System.Drawing.Size(397, 25)
        Me.ComboBox.TabIndex = 2
        Me.ComboBox.UseSelectable = True
        '
        'HiddenComboBox
        '
        Me.HiddenComboBox.DropDownHeight = 200
        Me.HiddenComboBox.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.HiddenComboBox.FormattingEnabled = True
        Me.HiddenComboBox.IntegralHeight = False
        Me.HiddenComboBox.ItemHeight = 19
        Me.HiddenComboBox.Location = New System.Drawing.Point(3, 36)
        Me.HiddenComboBox.Name = "HiddenComboBox"
        Me.HiddenComboBox.Size = New System.Drawing.Size(397, 25)
        Me.HiddenComboBox.TabIndex = 19
        Me.HiddenComboBox.UseSelectable = True
        Me.HiddenComboBox.Visible = False
        '
        'TabPage_About
        '
        Me.TabPage_About.Controls.Add(Me.MetroLabel12)
        Me.TabPage_About.Controls.Add(Me.Logo)
        Me.TabPage_About.Controls.Add(Me.MetroLabel11)
        Me.TabPage_About.Controls.Add(Me.MetroLabel10)
        Me.TabPage_About.Controls.Add(Me.MetroLabel9)
        Me.TabPage_About.Controls.Add(Me.MetroLabel8)
        Me.TabPage_About.Controls.Add(Me.MetroLabel6)
        Me.TabPage_About.HorizontalScrollbarBarColor = True
        Me.TabPage_About.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage_About.HorizontalScrollbarSize = 10
        Me.TabPage_About.Location = New System.Drawing.Point(4, 38)
        Me.TabPage_About.Name = "TabPage_About"
        Me.TabPage_About.Size = New System.Drawing.Size(403, 300)
        Me.TabPage_About.TabIndex = 1
        Me.TabPage_About.Text = "About"
        Me.TabPage_About.VerticalScrollbarBarColor = True
        Me.TabPage_About.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage_About.VerticalScrollbarSize = 10
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel12.Location = New System.Drawing.Point(3, 192)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(175, 30)
        Me.MetroLabel12.TabIndex = 8
        Me.MetroLabel12.Text = "Credits:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dennis Magno's MetroFramework"
        Me.MetroLabel12.WrapToLine = True
        '
        'Logo
        '
        Me.Logo.BackColor = System.Drawing.Color.Transparent
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(206, 92)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(167, 170)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo.TabIndex = 7
        Me.Logo.TabStop = False
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel11.Location = New System.Drawing.Point(3, 259)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(197, 15)
        Me.MetroLabel11.TabIndex = 6
        Me.MetroLabel11.Text = "Copyright (c) 2016. All Rights Reserved"
        Me.MetroLabel11.WrapToLine = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel10.Location = New System.Drawing.Point(3, 152)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(137, 15)
        Me.MetroLabel10.TabIndex = 5
        Me.MetroLabel10.Text = "gmbalaoro@outlook.com"
        Me.MetroLabel10.WrapToLine = True
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel9.Location = New System.Drawing.Point(3, 127)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(130, 25)
        Me.MetroLabel9.TabIndex = 4
        Me.MetroLabel9.Text = "Gerard Balaoro"
        Me.MetroLabel9.WrapToLine = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(3, 108)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(93, 19)
        Me.MetroLabel8.TabIndex = 3
        Me.MetroLabel8.Text = "Developed by:"
        Me.MetroLabel8.WrapToLine = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(3, 19)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(367, 57)
        Me.MetroLabel6.TabIndex = 2
        Me.MetroLabel6.Text = "Metro Tile Changer v1.0 is a tool designed to enable users to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "customize start m" &
    "enu tiles. This product only works on " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Windows 8, 8.1, and 10 and runs on .NET " &
    "Framework 4.5.2"
        Me.MetroLabel6.WrapToLine = True
        '
        'TabPage_License
        '
        Me.TabPage_License.Controls.Add(Me.MetroLabel7)
        Me.TabPage_License.HorizontalScrollbarBarColor = True
        Me.TabPage_License.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage_License.HorizontalScrollbarSize = 10
        Me.TabPage_License.Location = New System.Drawing.Point(4, 38)
        Me.TabPage_License.Name = "TabPage_License"
        Me.TabPage_License.Size = New System.Drawing.Size(403, 300)
        Me.TabPage_License.TabIndex = 2
        Me.TabPage_License.Text = "License"
        Me.TabPage_License.VerticalScrollbarBarColor = True
        Me.TabPage_License.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage_License.VerticalScrollbarSize = 10
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel7.Location = New System.Drawing.Point(0, 0)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(417, 285)
        Me.MetroLabel7.TabIndex = 4
        Me.MetroLabel7.Text = resources.GetString("MetroLabel7.Text")
        Me.MetroLabel7.WrapToLine = True
        '
        'Tab_Colors
        '
        Me.Tab_Colors.Controls.Add(Me.TabPage_Color)
        Me.Tab_Colors.Controls.Add(Me.TabPage_ColorOther)
        Me.Tab_Colors.Controls.Add(Me.TabPage_Accent)
        Me.Tab_Colors.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Colors.Location = New System.Drawing.Point(431, 60)
        Me.Tab_Colors.Name = "Tab_Colors"
        Me.Tab_Colors.SelectedIndex = 0
        Me.Tab_Colors.Size = New System.Drawing.Size(233, 342)
        Me.Tab_Colors.TabIndex = 4
        Me.Tab_Colors.UseSelectable = True
        '
        'TabPage_Color
        '
        Me.TabPage_Color.Controls.Add(Me.MainColorPanel)
        Me.TabPage_Color.HorizontalScrollbarBarColor = True
        Me.TabPage_Color.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage_Color.HorizontalScrollbarSize = 10
        Me.TabPage_Color.Location = New System.Drawing.Point(4, 38)
        Me.TabPage_Color.Name = "TabPage_Color"
        Me.TabPage_Color.Size = New System.Drawing.Size(225, 300)
        Me.TabPage_Color.TabIndex = 0
        Me.TabPage_Color.Text = "Colors"
        Me.TabPage_Color.VerticalScrollbarBarColor = True
        Me.TabPage_Color.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage_Color.VerticalScrollbarSize = 10
        '
        'MainColorPanel
        '
        Me.MainColorPanel.BackColor = System.Drawing.Color.Transparent
        Me.MainColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainColorPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainColorPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainColorPanel.Name = "MainColorPanel"
        Me.MainColorPanel.Padding = New System.Windows.Forms.Padding(3)
        Me.MainColorPanel.Size = New System.Drawing.Size(225, 300)
        Me.MainColorPanel.TabIndex = 7
        '
        'TabPage_ColorOther
        '
        Me.TabPage_ColorOther.Controls.Add(Me.OtherColorPanel)
        Me.TabPage_ColorOther.HorizontalScrollbarBarColor = True
        Me.TabPage_ColorOther.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage_ColorOther.HorizontalScrollbarSize = 10
        Me.TabPage_ColorOther.Location = New System.Drawing.Point(4, 38)
        Me.TabPage_ColorOther.Name = "TabPage_ColorOther"
        Me.TabPage_ColorOther.Size = New System.Drawing.Size(225, 300)
        Me.TabPage_ColorOther.TabIndex = 1
        Me.TabPage_ColorOther.Text = "More Colors"
        Me.TabPage_ColorOther.VerticalScrollbarBarColor = True
        Me.TabPage_ColorOther.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage_ColorOther.VerticalScrollbarSize = 10
        '
        'OtherColorPanel
        '
        Me.OtherColorPanel.BackColor = System.Drawing.Color.Transparent
        Me.OtherColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OtherColorPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OtherColorPanel.Location = New System.Drawing.Point(0, 0)
        Me.OtherColorPanel.Name = "OtherColorPanel"
        Me.OtherColorPanel.Padding = New System.Windows.Forms.Padding(3)
        Me.OtherColorPanel.Size = New System.Drawing.Size(225, 300)
        Me.OtherColorPanel.TabIndex = 8
        '
        'TabPage_Accent
        '
        Me.TabPage_Accent.Controls.Add(Me.AccentPanel)
        Me.TabPage_Accent.HorizontalScrollbarBarColor = True
        Me.TabPage_Accent.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage_Accent.HorizontalScrollbarSize = 10
        Me.TabPage_Accent.Location = New System.Drawing.Point(4, 38)
        Me.TabPage_Accent.Name = "TabPage_Accent"
        Me.TabPage_Accent.Size = New System.Drawing.Size(225, 300)
        Me.TabPage_Accent.TabIndex = 2
        Me.TabPage_Accent.Text = "Accents"
        Me.TabPage_Accent.VerticalScrollbarBarColor = True
        Me.TabPage_Accent.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage_Accent.VerticalScrollbarSize = 10
        '
        'AccentPanel
        '
        Me.AccentPanel.BackColor = System.Drawing.Color.Transparent
        Me.AccentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AccentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccentPanel.Location = New System.Drawing.Point(0, 0)
        Me.AccentPanel.Name = "AccentPanel"
        Me.AccentPanel.Padding = New System.Windows.Forms.Padding(3)
        Me.AccentPanel.Size = New System.Drawing.Size(225, 300)
        Me.AccentPanel.TabIndex = 9
        '
        'ThemeManager
        '
        Me.ThemeManager.Owner = Me
        Me.ThemeManager.Style = MetroFramework.MetroColorStyle.Green
        '
        'ColorDialog
        '
        Me.ColorDialog.AnyColor = True
        Me.ColorDialog.FullOpen = True
        Me.ColorDialog.ShowHelp = True
        Me.ColorDialog.SolidColorOnly = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 422)
        Me.Controls.Add(Me.Tab_Colors)
        Me.Controls.Add(Me.Tab_Main)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.[Default]
        Me.Text = "Metro Tile Customizer"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.Tab_Main.ResumeLayout(False)
        Me.TabPage_Main.ResumeLayout(False)
        Me.TabPage_Main.PerformLayout()
        Me.TileMenu.ResumeLayout(False)
        Me.TabPage_About.ResumeLayout(False)
        Me.TabPage_About.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_License.ResumeLayout(False)
        Me.TabPage_License.PerformLayout()
        Me.Tab_Colors.ResumeLayout(False)
        Me.TabPage_Color.ResumeLayout(False)
        Me.TabPage_ColorOther.ResumeLayout(False)
        Me.TabPage_Accent.ResumeLayout(False)
        CType(Me.ThemeManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tab_Main As MetroFramework.Controls.MetroTabControl
    Friend WithEvents TabPage_Main As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TilePreview As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents opt_Text_Light As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents opt_Text_Dark As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents Button2_Restore As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents Button1_Colorize As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Switch_NameOnTile As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ComboBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents HiddenComboBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents TabPage_About As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Logo As PictureBox
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TabPage_License As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Tab_Colors As MetroFramework.Controls.MetroTabControl
    Friend WithEvents TabPage_Color As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MainColorPanel As FlowLayoutPanel
    Friend WithEvents TabPage_ColorOther As MetroFramework.Controls.MetroTabPage
    Friend WithEvents OtherColorPanel As FlowLayoutPanel
    Friend WithEvents TabPage_Accent As MetroFramework.Controls.MetroTabPage
    Friend WithEvents AccentPanel As FlowLayoutPanel
    Friend WithEvents ThemeManager As MetroFramework.Components.MetroStyleManager
    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents LinkPath As TextBox
    Friend WithEvents TileMenu As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents OpenFileLocationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenTargetFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HexColor As MetroFramework.Controls.MetroTextBox
End Class

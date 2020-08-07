using System.Windows.Forms;
using MetroFramework.Forms;
using WindowsTileCustomizer.Properties;

namespace WindowsTileCustomizer.Forms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MenuItemDropdownLabel = new MetroFramework.Controls.MetroLabel();
            this.MainTabControl = new MetroFramework.Controls.MetroTabControl();
            this.CustomizeTabPage = new MetroFramework.Controls.MetroTabPage();
            this.SuggestColorButton = new MetroFramework.Controls.MetroButton();
            this.PickColorButton = new MetroFramework.Controls.MetroButton();
            this.ForegroundDropdown = new MetroFramework.Controls.MetroComboBox();
            this.BackgroundLabel = new MetroFramework.Controls.MetroLabel();
            this.SmallLogoBrowseButton = new MetroFramework.Controls.MetroButton();
            this.SmallLogoTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ShowNameLabel = new MetroFramework.Controls.MetroLabel();
            this.SmallLogoLabel = new MetroFramework.Controls.MetroLabel();
            this.MediumLogoBrowseButton = new MetroFramework.Controls.MetroButton();
            this.MediumLogoTextBox = new MetroFramework.Controls.MetroTextBox();
            this.MediumPreviewLabel = new MetroFramework.Controls.MetroLabel();
            this.BackgroundTextBox = new MetroFramework.Controls.MetroTextBox();
            this.MediumLogoLabel = new MetroFramework.Controls.MetroLabel();
            this.ForegroundLabel = new MetroFramework.Controls.MetroLabel();
            this.ShowNameToggle = new MetroFramework.Controls.MetroToggle();
            this.ApplyButton = new MetroFramework.Controls.MetroButton();
            this.ResetButton = new MetroFramework.Controls.MetroButton();
            this.MediumTilePreview = new MetroFramework.Controls.MetroTile();
            this.TargetLabel = new MetroFramework.Controls.MetroLink();
            this.RefreshButton = new MetroFramework.Controls.MetroButton();
            this.StartMenuDropdown = new MetroFramework.Controls.MetroComboBox();
            this.AboutTabPage = new MetroFramework.Controls.MetroTabPage();
            this.AuthorLabel = new MetroFramework.Controls.MetroLabel();
            this.DevelopedByLabel = new MetroFramework.Controls.MetroLabel();
            this.VersionLabel = new MetroFramework.Controls.MetroLabel();
            this.VersionIconPictureBox = new System.Windows.Forms.PictureBox();
            this.LicenseLabel = new MetroFramework.Controls.MetroLabel();
            this.LicenseIconPictureBox = new System.Windows.Forms.PictureBox();
            this.WebsiteLabel = new MetroFramework.Controls.MetroLabel();
            this.WebsiteIconPictureBox = new System.Windows.Forms.PictureBox();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.DescriptionLabel = new MetroFramework.Controls.MetroLabel();
            this.SecondaryTabControl = new MetroFramework.Controls.MetroTabControl();
            this.ColorsTabPage = new MetroFramework.Controls.MetroTabPage();
            this.ColorsFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.ManifestTabPage = new MetroFramework.Controls.MetroTabPage();
            this.ManifestTextBox = new MetroFramework.Controls.MetroTextBox();
            this.OpenImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.PickColorDialog = new System.Windows.Forms.ColorDialog();
            this.MainToolTip = new MetroFramework.Components.MetroToolTip();
            this.MainTabControl.SuspendLayout();
            this.CustomizeTabPage.SuspendLayout();
            this.AboutTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VersionIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LicenseIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebsiteIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SecondaryTabControl.SuspendLayout();
            this.ColorsTabPage.SuspendLayout();
            this.ManifestTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuItemDropdownLabel
            // 
            this.MenuItemDropdownLabel.AutoSize = true;
            this.MenuItemDropdownLabel.Location = new System.Drawing.Point(3, 16);
            this.MenuItemDropdownLabel.Name = "MenuItemDropdownLabel";
            this.MenuItemDropdownLabel.Size = new System.Drawing.Size(155, 19);
            this.MenuItemDropdownLabel.TabIndex = 2;
            this.MenuItemDropdownLabel.Text = "Choose Start Menu Item:";
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.CustomizeTabPage);
            this.MainTabControl.Controls.Add(this.AboutTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainTabControl.Location = new System.Drawing.Point(20, 60);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(518, 416);
            this.MainTabControl.TabIndex = 4;
            this.MainTabControl.UseSelectable = true;
            // 
            // CustomizeTabPage
            // 
            this.CustomizeTabPage.Controls.Add(this.SuggestColorButton);
            this.CustomizeTabPage.Controls.Add(this.PickColorButton);
            this.CustomizeTabPage.Controls.Add(this.ForegroundDropdown);
            this.CustomizeTabPage.Controls.Add(this.BackgroundLabel);
            this.CustomizeTabPage.Controls.Add(this.SmallLogoBrowseButton);
            this.CustomizeTabPage.Controls.Add(this.SmallLogoTextBox);
            this.CustomizeTabPage.Controls.Add(this.ShowNameLabel);
            this.CustomizeTabPage.Controls.Add(this.SmallLogoLabel);
            this.CustomizeTabPage.Controls.Add(this.MediumLogoBrowseButton);
            this.CustomizeTabPage.Controls.Add(this.MediumLogoTextBox);
            this.CustomizeTabPage.Controls.Add(this.MediumPreviewLabel);
            this.CustomizeTabPage.Controls.Add(this.BackgroundTextBox);
            this.CustomizeTabPage.Controls.Add(this.MediumLogoLabel);
            this.CustomizeTabPage.Controls.Add(this.ForegroundLabel);
            this.CustomizeTabPage.Controls.Add(this.ShowNameToggle);
            this.CustomizeTabPage.Controls.Add(this.ApplyButton);
            this.CustomizeTabPage.Controls.Add(this.ResetButton);
            this.CustomizeTabPage.Controls.Add(this.MediumTilePreview);
            this.CustomizeTabPage.Controls.Add(this.TargetLabel);
            this.CustomizeTabPage.Controls.Add(this.RefreshButton);
            this.CustomizeTabPage.Controls.Add(this.StartMenuDropdown);
            this.CustomizeTabPage.Controls.Add(this.MenuItemDropdownLabel);
            this.CustomizeTabPage.HorizontalScrollbarBarColor = true;
            this.CustomizeTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.CustomizeTabPage.HorizontalScrollbarSize = 10;
            this.CustomizeTabPage.Location = new System.Drawing.Point(4, 38);
            this.CustomizeTabPage.Name = "CustomizeTabPage";
            this.CustomizeTabPage.Size = new System.Drawing.Size(510, 374);
            this.CustomizeTabPage.TabIndex = 0;
            this.CustomizeTabPage.Text = "Customize Tile";
            this.CustomizeTabPage.VerticalScrollbarBarColor = true;
            this.CustomizeTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.CustomizeTabPage.VerticalScrollbarSize = 10;
            // 
            // SuggestColorButton
            // 
            this.SuggestColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SuggestColorButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SuggestColorButton.BackgroundImage")));
            this.SuggestColorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SuggestColorButton.Location = new System.Drawing.Point(280, 261);
            this.SuggestColorButton.Name = "SuggestColorButton";
            this.SuggestColorButton.Size = new System.Drawing.Size(23, 23);
            this.SuggestColorButton.TabIndex = 31;
            this.SuggestColorButton.UseSelectable = true;
            this.SuggestColorButton.Click += new System.EventHandler(this.SuggestColorButton_Click);
            // 
            // PickColorButton
            // 
            this.PickColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PickColorButton.BackgroundImage = global::WindowsTileCustomizer.Properties.Resources.ionicons_palette;
            this.PickColorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PickColorButton.Location = new System.Drawing.Point(251, 261);
            this.PickColorButton.Name = "PickColorButton";
            this.PickColorButton.Size = new System.Drawing.Size(23, 23);
            this.PickColorButton.TabIndex = 30;
            this.PickColorButton.UseSelectable = true;
            this.PickColorButton.Click += new System.EventHandler(this.PickColorButton_Click);
            // 
            // ForegroundDropdown
            // 
            this.ForegroundDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ForegroundDropdown.DisplayMember = "Name";
            this.ForegroundDropdown.DropDownHeight = 160;
            this.ForegroundDropdown.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.ForegroundDropdown.FormattingEnabled = true;
            this.ForegroundDropdown.IntegralHeight = false;
            this.ForegroundDropdown.ItemHeight = 19;
            this.ForegroundDropdown.Location = new System.Drawing.Point(370, 261);
            this.ForegroundDropdown.Name = "ForegroundDropdown";
            this.ForegroundDropdown.Size = new System.Drawing.Size(135, 25);
            this.ForegroundDropdown.TabIndex = 29;
            this.ForegroundDropdown.UseSelectable = true;
            this.ForegroundDropdown.ValueMember = "Value";
            // 
            // BackgroundLabel
            // 
            this.BackgroundLabel.AutoSize = true;
            this.BackgroundLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.BackgroundLabel.Location = new System.Drawing.Point(167, 243);
            this.BackgroundLabel.Name = "BackgroundLabel";
            this.BackgroundLabel.Size = new System.Drawing.Size(97, 15);
            this.BackgroundLabel.TabIndex = 28;
            this.BackgroundLabel.Text = "Background Color";
            // 
            // SmallLogoBrowseButton
            // 
            this.SmallLogoBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SmallLogoBrowseButton.Location = new System.Drawing.Point(447, 195);
            this.SmallLogoBrowseButton.Name = "SmallLogoBrowseButton";
            this.SmallLogoBrowseButton.Size = new System.Drawing.Size(58, 23);
            this.SmallLogoBrowseButton.TabIndex = 27;
            this.SmallLogoBrowseButton.Text = "Browse";
            this.SmallLogoBrowseButton.UseSelectable = true;
            // 
            // SmallLogoTextBox
            // 
            // 
            // 
            // 
            this.SmallLogoTextBox.CustomButton.Image = null;
            this.SmallLogoTextBox.CustomButton.Location = new System.Drawing.Point(252, 1);
            this.SmallLogoTextBox.CustomButton.Name = "";
            this.SmallLogoTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SmallLogoTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SmallLogoTextBox.CustomButton.TabIndex = 1;
            this.SmallLogoTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SmallLogoTextBox.CustomButton.UseSelectable = true;
            this.SmallLogoTextBox.CustomButton.Visible = false;
            this.SmallLogoTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.SmallLogoTextBox.Lines = new string[0];
            this.SmallLogoTextBox.Location = new System.Drawing.Point(167, 195);
            this.SmallLogoTextBox.MaxLength = 32767;
            this.SmallLogoTextBox.Name = "SmallLogoTextBox";
            this.SmallLogoTextBox.PasswordChar = '\0';
            this.SmallLogoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SmallLogoTextBox.SelectedText = "";
            this.SmallLogoTextBox.SelectionLength = 0;
            this.SmallLogoTextBox.SelectionStart = 0;
            this.SmallLogoTextBox.ShortcutsEnabled = true;
            this.SmallLogoTextBox.Size = new System.Drawing.Size(274, 23);
            this.SmallLogoTextBox.TabIndex = 26;
            this.SmallLogoTextBox.UseSelectable = true;
            this.SmallLogoTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SmallLogoTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ShowNameLabel
            // 
            this.ShowNameLabel.AutoSize = true;
            this.ShowNameLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.ShowNameLabel.Location = new System.Drawing.Point(188, 317);
            this.ShowNameLabel.Name = "ShowNameLabel";
            this.ShowNameLabel.Size = new System.Drawing.Size(147, 15);
            this.ShowNameLabel.TabIndex = 19;
            this.ShowNameLabel.Text = "Show Name on Medium Tile";
            // 
            // SmallLogoLabel
            // 
            this.SmallLogoLabel.AutoSize = true;
            this.SmallLogoLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.SmallLogoLabel.Location = new System.Drawing.Point(167, 177);
            this.SmallLogoLabel.Name = "SmallLogoLabel";
            this.SmallLogoLabel.Size = new System.Drawing.Size(87, 15);
            this.SmallLogoLabel.TabIndex = 25;
            this.SmallLogoLabel.Text = "Small Tile Image";
            // 
            // MediumLogoBrowseButton
            // 
            this.MediumLogoBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MediumLogoBrowseButton.Location = new System.Drawing.Point(447, 141);
            this.MediumLogoBrowseButton.Name = "MediumLogoBrowseButton";
            this.MediumLogoBrowseButton.Size = new System.Drawing.Size(58, 23);
            this.MediumLogoBrowseButton.TabIndex = 24;
            this.MediumLogoBrowseButton.Text = "Browse";
            this.MediumLogoBrowseButton.UseSelectable = true;
            // 
            // MediumLogoTextBox
            // 
            // 
            // 
            // 
            this.MediumLogoTextBox.CustomButton.Image = null;
            this.MediumLogoTextBox.CustomButton.Location = new System.Drawing.Point(252, 1);
            this.MediumLogoTextBox.CustomButton.Name = "";
            this.MediumLogoTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MediumLogoTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MediumLogoTextBox.CustomButton.TabIndex = 1;
            this.MediumLogoTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MediumLogoTextBox.CustomButton.UseSelectable = true;
            this.MediumLogoTextBox.CustomButton.Visible = false;
            this.MediumLogoTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.MediumLogoTextBox.Lines = new string[0];
            this.MediumLogoTextBox.Location = new System.Drawing.Point(167, 141);
            this.MediumLogoTextBox.MaxLength = 32767;
            this.MediumLogoTextBox.Name = "MediumLogoTextBox";
            this.MediumLogoTextBox.PasswordChar = '\0';
            this.MediumLogoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MediumLogoTextBox.SelectedText = "";
            this.MediumLogoTextBox.SelectionLength = 0;
            this.MediumLogoTextBox.SelectionStart = 0;
            this.MediumLogoTextBox.ShortcutsEnabled = true;
            this.MediumLogoTextBox.Size = new System.Drawing.Size(274, 23);
            this.MediumLogoTextBox.TabIndex = 23;
            this.MediumLogoTextBox.UseSelectable = true;
            this.MediumLogoTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MediumLogoTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MediumPreviewLabel
            // 
            this.MediumPreviewLabel.AutoSize = true;
            this.MediumPreviewLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.MediumPreviewLabel.Location = new System.Drawing.Point(28, 230);
            this.MediumPreviewLabel.Name = "MediumPreviewLabel";
            this.MediumPreviewLabel.Size = new System.Drawing.Size(45, 15);
            this.MediumPreviewLabel.TabIndex = 20;
            this.MediumPreviewLabel.Text = "Preview";
            this.MediumPreviewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackgroundTextBox
            // 
            // 
            // 
            // 
            this.BackgroundTextBox.CustomButton.Image = null;
            this.BackgroundTextBox.CustomButton.Location = new System.Drawing.Point(56, 1);
            this.BackgroundTextBox.CustomButton.Name = "";
            this.BackgroundTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BackgroundTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BackgroundTextBox.CustomButton.TabIndex = 1;
            this.BackgroundTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BackgroundTextBox.CustomButton.UseSelectable = true;
            this.BackgroundTextBox.CustomButton.Visible = false;
            this.BackgroundTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.BackgroundTextBox.Lines = new string[0];
            this.BackgroundTextBox.Location = new System.Drawing.Point(167, 261);
            this.BackgroundTextBox.MaxLength = 32767;
            this.BackgroundTextBox.Name = "BackgroundTextBox";
            this.BackgroundTextBox.PasswordChar = '\0';
            this.BackgroundTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BackgroundTextBox.SelectedText = "";
            this.BackgroundTextBox.SelectionLength = 0;
            this.BackgroundTextBox.SelectionStart = 0;
            this.BackgroundTextBox.ShortcutsEnabled = true;
            this.BackgroundTextBox.Size = new System.Drawing.Size(78, 23);
            this.BackgroundTextBox.TabIndex = 16;
            this.BackgroundTextBox.UseSelectable = true;
            this.BackgroundTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BackgroundTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MediumLogoLabel
            // 
            this.MediumLogoLabel.AutoSize = true;
            this.MediumLogoLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.MediumLogoLabel.Location = new System.Drawing.Point(167, 123);
            this.MediumLogoLabel.Name = "MediumLogoLabel";
            this.MediumLogoLabel.Size = new System.Drawing.Size(102, 15);
            this.MediumLogoLabel.TabIndex = 17;
            this.MediumLogoLabel.Text = "Medium Tile Image";
            // 
            // ForegroundLabel
            // 
            this.ForegroundLabel.AutoSize = true;
            this.ForegroundLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.ForegroundLabel.Location = new System.Drawing.Point(370, 243);
            this.ForegroundLabel.Name = "ForegroundLabel";
            this.ForegroundLabel.Size = new System.Drawing.Size(89, 15);
            this.ForegroundLabel.TabIndex = 15;
            this.ForegroundLabel.Text = "Foreground Text";
            // 
            // ShowNameToggle
            // 
            this.ShowNameToggle.AutoSize = true;
            this.ShowNameToggle.Location = new System.Drawing.Point(379, 315);
            this.ShowNameToggle.Name = "ShowNameToggle";
            this.ShowNameToggle.Size = new System.Drawing.Size(80, 17);
            this.ShowNameToggle.TabIndex = 13;
            this.ShowNameToggle.Text = "Off";
            this.ShowNameToggle.UseSelectable = true;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(3, 275);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(103, 34);
            this.ApplyButton.TabIndex = 9;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseSelectable = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(3, 315);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(103, 34);
            this.ResetButton.TabIndex = 8;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseSelectable = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // MediumTilePreview
            // 
            this.MediumTilePreview.ActiveControl = null;
            this.MediumTilePreview.Enabled = false;
            this.MediumTilePreview.ForeColor = System.Drawing.Color.White;
            this.MediumTilePreview.Location = new System.Drawing.Point(3, 123);
            this.MediumTilePreview.Name = "MediumTilePreview";
            this.MediumTilePreview.Size = new System.Drawing.Size(100, 100);
            this.MediumTilePreview.TabIndex = 7;
            this.MediumTilePreview.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MediumTilePreview.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.MediumTilePreview.UseCustomForeColor = true;
            this.MediumTilePreview.UseSelectable = true;
            this.MediumTilePreview.UseTileImage = true;
            // 
            // TargetLabel
            // 
            this.TargetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TargetLabel.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.TargetLabel.Location = new System.Drawing.Point(3, 82);
            this.TargetLabel.Name = "TargetLabel";
            this.TargetLabel.Size = new System.Drawing.Size(423, 23);
            this.TargetLabel.TabIndex = 6;
            this.TargetLabel.Text = "C:\\Path\\to\\Application Executable";
            this.TargetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TargetLabel.UseSelectable = true;
            this.TargetLabel.Click += new System.EventHandler(this.TargetLabel_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshButton.Location = new System.Drawing.Point(432, 47);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 29);
            this.RefreshButton.TabIndex = 4;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseSelectable = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // StartMenuDropdown
            // 
            this.StartMenuDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartMenuDropdown.DisplayMember = "Name";
            this.StartMenuDropdown.DropDownHeight = 160;
            this.StartMenuDropdown.FormattingEnabled = true;
            this.StartMenuDropdown.IntegralHeight = false;
            this.StartMenuDropdown.ItemHeight = 23;
            this.StartMenuDropdown.Location = new System.Drawing.Point(3, 47);
            this.StartMenuDropdown.Name = "StartMenuDropdown";
            this.StartMenuDropdown.Size = new System.Drawing.Size(423, 29);
            this.StartMenuDropdown.TabIndex = 3;
            this.StartMenuDropdown.UseSelectable = true;
            this.StartMenuDropdown.ValueMember = "Path";
            // 
            // AboutTabPage
            // 
            this.AboutTabPage.Controls.Add(this.AuthorLabel);
            this.AboutTabPage.Controls.Add(this.DevelopedByLabel);
            this.AboutTabPage.Controls.Add(this.VersionLabel);
            this.AboutTabPage.Controls.Add(this.VersionIconPictureBox);
            this.AboutTabPage.Controls.Add(this.LicenseLabel);
            this.AboutTabPage.Controls.Add(this.LicenseIconPictureBox);
            this.AboutTabPage.Controls.Add(this.WebsiteLabel);
            this.AboutTabPage.Controls.Add(this.WebsiteIconPictureBox);
            this.AboutTabPage.Controls.Add(this.LogoPictureBox);
            this.AboutTabPage.Controls.Add(this.DescriptionLabel);
            this.AboutTabPage.HorizontalScrollbarBarColor = true;
            this.AboutTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.AboutTabPage.HorizontalScrollbarSize = 10;
            this.AboutTabPage.Location = new System.Drawing.Point(4, 38);
            this.AboutTabPage.Name = "AboutTabPage";
            this.AboutTabPage.Size = new System.Drawing.Size(510, 374);
            this.AboutTabPage.TabIndex = 1;
            this.AboutTabPage.Text = "About";
            this.AboutTabPage.VerticalScrollbarBarColor = true;
            this.AboutTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.AboutTabPage.VerticalScrollbarSize = 10;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.AuthorLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.AuthorLabel.Location = new System.Drawing.Point(170, 130);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(67, 25);
            this.AuthorLabel.TabIndex = 12;
            this.AuthorLabel.Text = "Author";
            // 
            // DevelopedByLabel
            // 
            this.DevelopedByLabel.AutoSize = true;
            this.DevelopedByLabel.Location = new System.Drawing.Point(170, 111);
            this.DevelopedByLabel.Name = "DevelopedByLabel";
            this.DevelopedByLabel.Size = new System.Drawing.Size(90, 19);
            this.DevelopedByLabel.TabIndex = 11;
            this.DevelopedByLabel.Text = "Developed by";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.VersionLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.VersionLabel.Location = new System.Drawing.Point(40, 277);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(34, 15);
            this.VersionLabel.TabIndex = 10;
            this.VersionLabel.Text = "v1.0.0";
            // 
            // VersionIconPictureBox
            // 
            this.VersionIconPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.VersionIconPictureBox.Location = new System.Drawing.Point(14, 274);
            this.VersionIconPictureBox.Name = "VersionIconPictureBox";
            this.VersionIconPictureBox.Size = new System.Drawing.Size(20, 20);
            this.VersionIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VersionIconPictureBox.TabIndex = 9;
            this.VersionIconPictureBox.TabStop = false;
            // 
            // LicenseLabel
            // 
            this.LicenseLabel.AutoSize = true;
            this.LicenseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LicenseLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.LicenseLabel.Location = new System.Drawing.Point(40, 333);
            this.LicenseLabel.Name = "LicenseLabel";
            this.LicenseLabel.Size = new System.Drawing.Size(85, 15);
            this.LicenseLabel.TabIndex = 8;
            this.LicenseLabel.Text = "The MIT License";
            // 
            // LicenseIconPictureBox
            // 
            this.LicenseIconPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.LicenseIconPictureBox.Location = new System.Drawing.Point(14, 330);
            this.LicenseIconPictureBox.Name = "LicenseIconPictureBox";
            this.LicenseIconPictureBox.Size = new System.Drawing.Size(20, 20);
            this.LicenseIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LicenseIconPictureBox.TabIndex = 7;
            this.LicenseIconPictureBox.TabStop = false;
            // 
            // WebsiteLabel
            // 
            this.WebsiteLabel.AutoSize = true;
            this.WebsiteLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WebsiteLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.WebsiteLabel.Location = new System.Drawing.Point(40, 305);
            this.WebsiteLabel.Name = "WebsiteLabel";
            this.WebsiteLabel.Size = new System.Drawing.Size(64, 15);
            this.WebsiteLabel.TabIndex = 6;
            this.WebsiteLabel.Text = "github.com";
            // 
            // WebsiteIconPictureBox
            // 
            this.WebsiteIconPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.WebsiteIconPictureBox.Location = new System.Drawing.Point(14, 302);
            this.WebsiteIconPictureBox.Name = "WebsiteIconPictureBox";
            this.WebsiteIconPictureBox.Size = new System.Drawing.Size(20, 20);
            this.WebsiteIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WebsiteIconPictureBox.TabIndex = 5;
            this.WebsiteIconPictureBox.TabStop = false;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.LogoPictureBox.Location = new System.Drawing.Point(14, 25);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(139, 130);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 4;
            this.LogoPictureBox.TabStop = false;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Location = new System.Drawing.Point(170, 25);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(316, 66);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = "WindowsTileCustomizer is a tool for customizing start menu tiles for Windows Desk" +
    "top Applications.";
            this.DescriptionLabel.WrapToLine = true;
            // 
            // SecondaryTabControl
            // 
            this.SecondaryTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondaryTabControl.Controls.Add(this.ColorsTabPage);
            this.SecondaryTabControl.Controls.Add(this.ManifestTabPage);
            this.SecondaryTabControl.Location = new System.Drawing.Point(544, 60);
            this.SecondaryTabControl.Name = "SecondaryTabControl";
            this.SecondaryTabControl.SelectedIndex = 0;
            this.SecondaryTabControl.Size = new System.Drawing.Size(345, 416);
            this.SecondaryTabControl.TabIndex = 5;
            this.SecondaryTabControl.UseSelectable = true;
            // 
            // ColorsTabPage
            // 
            this.ColorsTabPage.Controls.Add(this.ColorsFlowLayout);
            this.ColorsTabPage.HorizontalScrollbarBarColor = true;
            this.ColorsTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.ColorsTabPage.HorizontalScrollbarSize = 10;
            this.ColorsTabPage.Location = new System.Drawing.Point(4, 38);
            this.ColorsTabPage.Name = "ColorsTabPage";
            this.ColorsTabPage.Size = new System.Drawing.Size(337, 374);
            this.ColorsTabPage.TabIndex = 0;
            this.ColorsTabPage.Text = "Colors";
            this.ColorsTabPage.VerticalScrollbarBarColor = true;
            this.ColorsTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.ColorsTabPage.VerticalScrollbarSize = 10;
            // 
            // ColorsFlowLayout
            // 
            this.ColorsFlowLayout.AutoScroll = true;
            this.ColorsFlowLayout.BackColor = System.Drawing.Color.Transparent;
            this.ColorsFlowLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorsFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorsFlowLayout.Location = new System.Drawing.Point(0, 0);
            this.ColorsFlowLayout.Name = "ColorsFlowLayout";
            this.ColorsFlowLayout.Padding = new System.Windows.Forms.Padding(5);
            this.ColorsFlowLayout.Size = new System.Drawing.Size(337, 374);
            this.ColorsFlowLayout.TabIndex = 2;
            // 
            // ManifestTabPage
            // 
            this.ManifestTabPage.Controls.Add(this.ManifestTextBox);
            this.ManifestTabPage.HorizontalScrollbarBarColor = false;
            this.ManifestTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.ManifestTabPage.HorizontalScrollbarSize = 0;
            this.ManifestTabPage.Location = new System.Drawing.Point(4, 38);
            this.ManifestTabPage.Name = "ManifestTabPage";
            this.ManifestTabPage.Size = new System.Drawing.Size(337, 374);
            this.ManifestTabPage.TabIndex = 1;
            this.ManifestTabPage.Text = "Manifest Preview";
            this.ManifestTabPage.VerticalScrollbarBarColor = false;
            this.ManifestTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.ManifestTabPage.VerticalScrollbarSize = 0;
            // 
            // ManifestTextBox
            // 
            // 
            // 
            // 
            this.ManifestTextBox.CustomButton.Image = null;
            this.ManifestTextBox.CustomButton.Location = new System.Drawing.Point(-35, 2);
            this.ManifestTextBox.CustomButton.Name = "";
            this.ManifestTextBox.CustomButton.Size = new System.Drawing.Size(369, 369);
            this.ManifestTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ManifestTextBox.CustomButton.TabIndex = 1;
            this.ManifestTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ManifestTextBox.CustomButton.UseSelectable = true;
            this.ManifestTextBox.CustomButton.Visible = false;
            this.ManifestTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManifestTextBox.Lines = new string[] {
        "metroTextBox1"};
            this.ManifestTextBox.Location = new System.Drawing.Point(0, 0);
            this.ManifestTextBox.MaxLength = 32767;
            this.ManifestTextBox.Multiline = true;
            this.ManifestTextBox.Name = "ManifestTextBox";
            this.ManifestTextBox.PasswordChar = '\0';
            this.ManifestTextBox.ReadOnly = true;
            this.ManifestTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ManifestTextBox.SelectedText = "";
            this.ManifestTextBox.SelectionLength = 0;
            this.ManifestTextBox.SelectionStart = 0;
            this.ManifestTextBox.ShortcutsEnabled = true;
            this.ManifestTextBox.Size = new System.Drawing.Size(337, 374);
            this.ManifestTextBox.TabIndex = 2;
            this.ManifestTextBox.Text = "metroTextBox1";
            this.ManifestTextBox.UseSelectable = true;
            this.ManifestTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ManifestTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // OpenImageDialog
            // 
            this.OpenImageDialog.Filter = "Images|*.png;*.jpg;*.jpeg;*.bmp";
            // 
            // PickColorDialog
            // 
            this.PickColorDialog.AnyColor = true;
            this.PickColorDialog.FullOpen = true;
            this.PickColorDialog.SolidColorOnly = true;
            // 
            // MainToolTip
            // 
            this.MainToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.MainToolTip.StyleManager = null;
            this.MainToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 496);
            this.Controls.Add(this.SecondaryTabControl);
            this.Controls.Add(this.MainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.Text = "Windows Tile Customizer";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Main_Load);
            this.MainTabControl.ResumeLayout(false);
            this.CustomizeTabPage.ResumeLayout(false);
            this.CustomizeTabPage.PerformLayout();
            this.AboutTabPage.ResumeLayout(false);
            this.AboutTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VersionIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LicenseIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebsiteIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.SecondaryTabControl.ResumeLayout(false);
            this.ColorsTabPage.ResumeLayout(false);
            this.ManifestTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel MenuItemDropdownLabel;
        private MetroFramework.Controls.MetroTabControl MainTabControl;
        private MetroFramework.Controls.MetroTabPage CustomizeTabPage;
        private MetroFramework.Controls.MetroComboBox StartMenuDropdown;
        private MetroFramework.Controls.MetroButton RefreshButton;
        private MetroFramework.Controls.MetroLink TargetLabel;
        private MetroFramework.Controls.MetroTile MediumTilePreview;
        private MetroFramework.Controls.MetroTabControl SecondaryTabControl;
        private MetroFramework.Controls.MetroTabPage ColorsTabPage;
        private MetroFramework.Controls.MetroButton ApplyButton;
        private MetroFramework.Controls.MetroButton ResetButton;
        private MetroFramework.Controls.MetroToggle ShowNameToggle;
        private MetroFramework.Controls.MetroTextBox BackgroundTextBox;
        private MetroFramework.Controls.MetroLabel MediumLogoLabel;
        private MetroFramework.Controls.MetroLabel MediumPreviewLabel;
        private MetroFramework.Controls.MetroLabel ShowNameLabel;
        private MetroFramework.Controls.MetroButton SmallLogoBrowseButton;
        private MetroFramework.Controls.MetroTextBox SmallLogoTextBox;
        private MetroFramework.Controls.MetroLabel SmallLogoLabel;
        private MetroFramework.Controls.MetroButton MediumLogoBrowseButton;
        private MetroFramework.Controls.MetroTextBox MediumLogoTextBox;
        private MetroFramework.Controls.MetroComboBox ForegroundDropdown;
        private MetroFramework.Controls.MetroLabel BackgroundLabel;
        private MetroFramework.Controls.MetroLabel ForegroundLabel;
        private OpenFileDialog OpenImageDialog;
        private ColorDialog PickColorDialog;
        private FlowLayoutPanel ColorsFlowLayout;
        private MetroFramework.Controls.MetroButton PickColorButton;
        private MetroFramework.Controls.MetroTabPage ManifestTabPage;
        private MetroFramework.Controls.MetroTextBox ManifestTextBox;
        private MetroFramework.Controls.MetroTabPage AboutTabPage;
        internal MetroFramework.Controls.MetroLabel DescriptionLabel;
        private PictureBox LogoPictureBox;
        private PictureBox WebsiteIconPictureBox;
        private MetroFramework.Controls.MetroLabel WebsiteLabel;
        private PictureBox LicenseIconPictureBox;
        private MetroFramework.Controls.MetroLabel LicenseLabel;
        private MetroFramework.Controls.MetroLabel VersionLabel;
        private PictureBox VersionIconPictureBox;
        private MetroFramework.Controls.MetroLabel AuthorLabel;
        private MetroFramework.Controls.MetroLabel DevelopedByLabel;
        private MetroFramework.Controls.MetroButton SuggestColorButton;
        private MetroFramework.Components.MetroToolTip MainToolTip;
    }
}
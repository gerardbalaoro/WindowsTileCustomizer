using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Drawing;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using WindowsTileCustomizer.Core;
using WindowsTileCustomizer.Properties;
using WindowsTileCustomizer.Utils;

namespace WindowsTileCustomizer.Forms
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        private StartMenu[] StartMenuItems;

        public StartMenu CurrentMenuItem {
            get { return StartMenuItems[StartMenuDropdown.SelectedIndex]; }
        }

        public VisualElements CurrentVisualElements;

        public Main()
        {
            InitializeComponent();
        }

        private void LoadStartMenuItems()
        {
            StartMenuItems = StartMenu.GetAllItems().ToArray().OrderBy(i => i.Name).ToArray();
            StartMenuDropdown.DataSource = StartMenuItems;
        }

        private void LoadSelectedItem()
        {
            CurrentVisualElements = new VisualElements(CurrentMenuItem.ManifestPath);
            TargetLabel.Text = CurrentMenuItem.Target;
            MediumTilePreview.Text = CurrentMenuItem.Name;
            BackgroundTextBox.Text = CurrentVisualElements.BackgroundColor != Color.Empty ? ColorTranslator.ToHtml(CurrentVisualElements.BackgroundColor) : "";
            ForegroundDropdown.SelectedItem = CurrentVisualElements.ForegroundText;
            MediumTilePreview.TileImage = CurrentMenuItem.Icon;
            MediumLogoTextBox.Text = CurrentVisualElements.MediumLogo;
            SmallLogoTextBox.Text = CurrentVisualElements.SmallLogo;
            ShowNameToggle.Checked = CurrentVisualElements.ShowNameOnMediumLogo;
            ResetButton.Enabled = CurrentVisualElements.UserGenerated;
        }

        private void LoadForegroundStyles()
        {
            foreach (VisualElements.ForegroundTextStyle style in (VisualElements.ForegroundTextStyle[])Enum.GetValues(typeof(VisualElements.ForegroundTextStyle))) {
                ForegroundDropdown.Items.Add(style);
            }
        }
        
        private void LoadColors()
        {
            foreach (var color in ResUtils.LoadColors()) {
                Panel colorPanel = new Panel();
                colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                colorPanel.BackColor = ColorTranslator.FromHtml(color);
                colorPanel.Size = new Size(30, 30);
                colorPanel.Click += new System.EventHandler((s, args) => {
                    BackgroundTextBox.Text = ColorTranslator.ToHtml((s as Panel).BackColor);
                });
                ColorsFlowLayout.Controls.Add(colorPanel);
            }
        }

        private void LoadAbout()
        {
            DescriptionLabel.Text = Resources.AboutDescription;
            AuthorLabel.Text = Resources.AboutAuthor;

            Version version = new Version(Application.ProductVersion);
            VersionLabel.Text = $"v{version.Major}.{version.Minor}.{version.Build}";

            Uri website = new Uri(Resources.AboutWebsite);
            WebsiteLabel.Text = $"{website.Host}{website.LocalPath}";
            WebsiteLabel.Click += new EventHandler((s, a) => {
                System.Diagnostics.Process.Start(website.AbsoluteUri);
            });

            LicenseLabel.Text = Resources.AboutLicense;
            LicenseLabel.Click += new EventHandler((s, a) => {
                System.Diagnostics.Process.Start(Resources.AboutLicenseUrl);
            });
        }

        private void UpdateForegroundColor()
        {
            CurrentVisualElements.ForegroundText = (VisualElements.ForegroundTextStyle)ForegroundDropdown.SelectedItem;
            MediumTilePreview.ForeColor = CurrentVisualElements.ForegroundText == VisualElements.ForegroundTextStyle.Dark ? Color.Black : Color.White;
        }

        private void UpdateBackgroundColor()
        {
            try {
                Color color = ColorTranslator.FromHtml(BackgroundTextBox.Text);
                CurrentVisualElements.BackgroundColor = color;
                MediumTilePreview.BackColor = color;
                if (color != Color.Empty) {
                    MediumTilePreview.UseCustomBackColor = true;
                    PickColorDialog.Color = color;
                    return;
                }
            } catch (Exception) {
                CurrentVisualElements.BackgroundColor = Color.Empty;
            }

            MediumTilePreview.UseCustomBackColor = false;
        }

        private void UpdateShowName()
        {
            CurrentVisualElements.ShowNameOnMediumLogo = ShowNameToggle.Checked;
            MediumTilePreview.Text = ShowNameToggle.Checked ? CurrentMenuItem.Name : "";
        }

        private void UpdateMediumLogo()
        {
            MediumLogoTextBox.WithError = false;
            if (string.IsNullOrEmpty(MediumLogoTextBox.Text)) {
                CurrentVisualElements.MediumLogo = null;
                MediumTilePreview.TileImage = CurrentMenuItem.Icon;
            } else {
                Image image = CurrentVisualElements.GetLogoImage(MediumLogoTextBox.Text, 100);
                if (image != null) {
                    CurrentVisualElements.MediumLogo = PathUtils.GetRelativePath(MediumLogoTextBox.Text, CurrentVisualElements.Directory);
                    MediumTilePreview.TileImage = new Bitmap(image, new Size(100, 100));
                } else {
                    CurrentVisualElements.MediumLogo = null;
                    MediumTilePreview.TileImage = null;
                    MediumLogoTextBox.WithError = true;
                }
            }
            MediumTilePreview.BackColor = MediumTilePreview.BackColor;
        }

        private void UpdateSmallLogo()
        {
            SmallLogoTextBox.WithError = false;
            Image image = CurrentVisualElements.GetLogoImage(SmallLogoTextBox.Text, 80);
            if (image != null) {
                CurrentVisualElements.SmallLogo = PathUtils.GetRelativePath(SmallLogoTextBox.Text, CurrentVisualElements.Directory);
            } else {
                if (!string.IsNullOrEmpty(SmallLogoTextBox.Text)) SmallLogoTextBox.WithError = true;
                CurrentVisualElements.SmallLogo = null;
            }
        }

        private void UpdateManifestPreview()
        {
            ManifestTextBox.Text = CurrentVisualElements.ToString();
        }

        private void SetDynamicTooltip(Control control, string caption)
        {
            MetroToolTip toolTip = new MetroToolTip();
            toolTip.SetToolTip(control, caption);
        }

        private void BrowseTileLogo(ref MetroTextBox textBox)
        {
            OpenImageDialog.InitialDirectory = CurrentMenuItem.TargetDirectory;
            OpenImageDialog.FileName = textBox.Text;
            if (OpenImageDialog.ShowDialog() == DialogResult.OK) {
                textBox.Text = PathUtils.GetRelativePath(OpenImageDialog.FileName, CurrentMenuItem.TargetDirectory);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            MainToolTip.SetToolTip(PickColorButton, "Color Picker");
            MainToolTip.SetToolTip(SuggestColorButton, "Get Dominant Color");

            MediumLogoBrowseButton.Click += new EventHandler((s, args) => {
                BrowseTileLogo(ref MediumLogoTextBox);
            });

            SmallLogoBrowseButton.Click += new EventHandler((s, args) => {
                BrowseTileLogo(ref SmallLogoTextBox);
            });

            StartMenuDropdown.SelectedIndexChanged += new EventHandler((s, args) => {
                LoadSelectedItem();
                UpdateManifestPreview();
            });

            ForegroundDropdown.SelectedIndexChanged += new EventHandler((s, args) => {
                UpdateForegroundColor();
                UpdateManifestPreview();
            });

            BackgroundTextBox.TextChanged += new EventHandler((s, args) => {
                UpdateBackgroundColor();
                UpdateManifestPreview();
            });

            MediumLogoTextBox.TextChanged += new EventHandler((s, args) => {
                UpdateMediumLogo();
                UpdateManifestPreview();
            });

            SmallLogoTextBox.TextChanged += new EventHandler((s, args) => {
                UpdateSmallLogo();
                UpdateManifestPreview();
            });

            ShowNameToggle.CheckedChanged += new EventHandler((s, args) => {
                UpdateShowName();
                UpdateManifestPreview();
            });

            LoadForegroundStyles();
            LoadStartMenuItems();
            LoadColors();
            LoadAbout();
        }

        private void TargetLabel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CurrentMenuItem.Target)) {
                System.Diagnostics.Process.Start(CurrentMenuItem.TargetDirectory);
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            CurrentVisualElements.Save();
            CurrentMenuItem.Refresh();
            LoadSelectedItem();
            MetroMessageBox.Show(
                this,
                "It might take a few seconds for changes to be visible.",
                "Tile Customized!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            CurrentVisualElements.Restore();
            CurrentMenuItem.Refresh();
            LoadSelectedItem();
            MetroMessageBox.Show(
                this,
                "It might take a few seconds for changes to be visible.",
                "Tile Defaults Restored!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadStartMenuItems();
        }

        private void PickColorButton_Click(object sender, EventArgs e)
        {
            PickColorDialog.Color = MediumTilePreview.BackColor;
            if (PickColorDialog.ShowDialog() == DialogResult.OK) {
                BackgroundTextBox.Text = ColorTranslator.ToHtml(PickColorDialog.Color);
            }
        }

        private void SuggestColorButton_Click(object sender, EventArgs e)
        {
            if (MediumTilePreview.TileImage != null) {
                ColorThiefDotNet.ColorThief colorThief = new ColorThiefDotNet.ColorThief();
                var quantizedColor = colorThief.GetColor((Bitmap)MediumTilePreview.TileImage);
                BackgroundTextBox.Text = quantizedColor.Color.ToHexString();
            }
        }
    }
}

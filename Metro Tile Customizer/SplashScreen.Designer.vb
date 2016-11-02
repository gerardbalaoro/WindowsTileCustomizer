<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
    Inherits MetroFramework.Forms.MetroForm

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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.Title = New MetroFramework.Controls.MetroLabel()
        Me.Version = New MetroFramework.Controls.MetroLabel()
        Me.Developer = New MetroFramework.Controls.MetroLabel()
        Me.Email = New MetroFramework.Controls.MetroLabel()
        Me.Spinner = New MetroFramework.Controls.MetroProgressSpinner()
        Me.Loading = New MetroFramework.Controls.MetroLabel()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Logo
        '
        Me.Logo.Dock = System.Windows.Forms.DockStyle.Left
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(20, 30)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(147, 147)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo.TabIndex = 4
        Me.Logo.TabStop = False
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Title.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Title.Location = New System.Drawing.Point(173, 36)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(177, 25)
        Me.Title.TabIndex = 5
        Me.Title.Text = "Metro Tile Cutomizer"
        '
        'Version
        '
        Me.Version.AutoSize = True
        Me.Version.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Version.Location = New System.Drawing.Point(176, 61)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(43, 15)
        Me.Version.TabIndex = 6
        Me.Version.Text = "Version"
        '
        'Developer
        '
        Me.Developer.AutoSize = True
        Me.Developer.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Developer.Location = New System.Drawing.Point(173, 84)
        Me.Developer.Name = "Developer"
        Me.Developer.Size = New System.Drawing.Size(101, 19)
        Me.Developer.TabIndex = 8
        Me.Developer.Text = "Gerard Balaoro"
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Email.Location = New System.Drawing.Point(173, 103)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(161, 19)
        Me.Email.TabIndex = 9
        Me.Email.Text = "gmbalaoro@outlook.com"
        '
        'Spinner
        '
        Me.Spinner.Location = New System.Drawing.Point(174, 139)
        Me.Spinner.Maximum = 100
        Me.Spinner.Name = "Spinner"
        Me.Spinner.Size = New System.Drawing.Size(25, 25)
        Me.Spinner.Speed = 3.0!
        Me.Spinner.Style = MetroFramework.MetroColorStyle.Green
        Me.Spinner.TabIndex = 10
        Me.Spinner.UseSelectable = True
        Me.Spinner.Value = 50
        '
        'Loading
        '
        Me.Loading.AutoSize = True
        Me.Loading.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Loading.Location = New System.Drawing.Point(206, 144)
        Me.Loading.Name = "Loading"
        Me.Loading.Size = New System.Drawing.Size(56, 15)
        Me.Loading.TabIndex = 11
        Me.Loading.Text = "Loading..."
        '
        'Timer
        '
        Me.Timer.Interval = 500
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 197)
        Me.ControlBox = False
        Me.Controls.Add(Me.Loading)
        Me.Controls.Add(Me.Spinner)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Developer)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Logo)
        Me.DisplayHeader = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreen"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Logo As PictureBox
    Friend WithEvents Title As MetroFramework.Controls.MetroLabel
    Friend WithEvents Version As MetroFramework.Controls.MetroLabel
    Friend WithEvents Developer As MetroFramework.Controls.MetroLabel
    Friend WithEvents Email As MetroFramework.Controls.MetroLabel
    Friend WithEvents Spinner As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents Loading As MetroFramework.Controls.MetroLabel
    Friend WithEvents Timer As Timer
End Class

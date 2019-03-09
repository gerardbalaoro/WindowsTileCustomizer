<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StartForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartForm))
        Me.Title = New System.Windows.Forms.Label()
        Me.Version = New System.Windows.Forms.Label()
        Me.Bar = New System.Windows.Forms.Panel()
        Me.Worker = New System.ComponentModel.BackgroundWorker()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.Author = New System.Windows.Forms.Label()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.Black
        Me.Title.Location = New System.Drawing.Point(140, 30)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(274, 37)
        Me.Title.TabIndex = 0
        Me.Title.Text = "MetroTileCustomizer"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Version
        '
        Me.Version.AutoSize = True
        Me.Version.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.ForeColor = System.Drawing.Color.Black
        Me.Version.Location = New System.Drawing.Point(147, 67)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(82, 21)
        Me.Version.TabIndex = 2
        Me.Version.Text = "Version 2.0"
        Me.Version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Bar
        '
        Me.Bar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Bar.Location = New System.Drawing.Point(-11, 150)
        Me.Bar.Name = "Bar"
        Me.Bar.Size = New System.Drawing.Size(469, 5)
        Me.Bar.TabIndex = 5
        '
        'Worker
        '
        Me.Worker.WorkerReportsProgress = True
        '
        'Logo
        '
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(30, 30)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(104, 107)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo.TabIndex = 6
        Me.Logo.TabStop = False
        '
        'Author
        '
        Me.Author.AutoSize = True
        Me.Author.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Author.ForeColor = System.Drawing.Color.Black
        Me.Author.Location = New System.Drawing.Point(148, 111)
        Me.Author.Name = "Author"
        Me.Author.Size = New System.Drawing.Size(166, 17)
        Me.Author.TabIndex = 7
        Me.Author.Text = "Developed by GerardBalaoro"
        Me.Author.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(433, 174)
        Me.ControlBox = False
        Me.Controls.Add(Me.Author)
        Me.Controls.Add(Me.Bar)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Logo)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StartForm"
        Me.Padding = New System.Windows.Forms.Padding(30)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents Version As Label
    Friend WithEvents Bar As Panel
    Friend WithEvents Worker As System.ComponentModel.BackgroundWorker
    Friend WithEvents Logo As PictureBox
    Friend WithEvents Author As Label
End Class

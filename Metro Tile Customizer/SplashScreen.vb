Imports System.IO
Imports System.Security.Principal
Imports MetroFramework

Public NotInheritable Class SplashScreen

    Dim ProgramDataItems = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu) & "\Programs", "*.lnk", SearchOption.AllDirectories)
    Dim AppDataItems = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) & "\Programs", "*.lnk", SearchOption.AllDirectories)
    Dim ColorBox As New Panel
    Dim AppData = My.Computer.FileSystem.SpecialDirectories.Temp & "\MetroTileChanger"

    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If My.Application.Info.Title <> "" Then
            Title.Text = My.Application.Info.Title
        Else

            Title.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Version.Text = "Version " & My.Application.Info.Version.ToString
    End Sub

    Private Sub SplashScreen_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Timer.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Dim identity = WindowsIdentity.GetCurrent()
        Dim principal = New WindowsPrincipal(identity)
        Dim isElevated As Boolean = principal.IsInRole(WindowsBuiltInRole.Administrator)
        If isElevated = False Then
            MetroMessageBox.Show(Me, "Administrative rights is required for the software to run properly. Please close and run the program as administrator.",
                                 "Insufficient Permissions", MessageBoxButtons.OK, MessageBoxIcon.Warning, 150)
        End If
        Try
            For Each Item In AppDataItems
                MainForm.ComboBox.Items.Add(Path.GetFileNameWithoutExtension(Item))
                MainForm.HiddenComboBox.Items.Add(Item)
            Next
            For Each Item In ProgramDataItems
                MainForm.ComboBox.Items.Add(Path.GetFileNameWithoutExtension(Item))
                MainForm.HiddenComboBox.Items.Add(Item)
            Next
            Directory.CreateDirectory(AppData)
            IO.File.WriteAllBytes(AppData & "\Colors_Main.txt", My.Resources.Colors_Main)
            IO.File.WriteAllBytes(AppData & "\Colors_Other.txt", My.Resources.Colors_Other)
            IO.File.WriteAllBytes(AppData & "\Colors_Accent.txt", My.Resources.Colors_Accent)
            For Each line As String In File.ReadAllLines(AppData & "\Colors_Main.txt")
                Dim ColorBox As New Panel
                ColorBox.BackColor = ColorTranslator.FromHtml(line)
                ColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                ColorBox.Size = New Size(30, 30)
                AddHandler ColorBox.Click, AddressOf DynamicClick
                MainForm.MainColorPanel.Controls.Add(ColorBox)
            Next
            For Each line As String In File.ReadAllLines(AppData & "\Colors_Other.txt")
                Dim ColorBox As New Panel
                ColorBox.BackColor = ColorTranslator.FromHtml(line)
                ColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                ColorBox.Size = New Size(30, 30)
                AddHandler ColorBox.Click, AddressOf DynamicClick
                MainForm.OtherColorPanel.Controls.Add(ColorBox)
            Next
            For Each line As String In File.ReadAllLines(AppData & "\Colors_Accent.txt")
                Dim ColorBox As New Panel
                ColorBox.BackColor = ColorTranslator.FromHtml(line)
                ColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                ColorBox.Size = New Size(30, 30)
                AddHandler ColorBox.Click, AddressOf DynamicClick
                MainForm.AccentPanel.Controls.Add(ColorBox)
            Next
            Dim AddNewColor As New PictureBox
            AddNewColor.Size = New Size(30, 30)
            AddNewColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            AddNewColor.Image = My.Resources.appbar_add
            AddNewColor.SizeMode = PictureBoxSizeMode.Zoom
            AddHandler AddNewColor.Click, AddressOf OpenColorDialog
            MainForm.AccentPanel.Controls.Add(AddNewColor)
            MainForm.Show()
            Me.Close()
        Catch Err As Exception
            If MetroMessageBox.Show(Me, vbNewLine & Err.Message & vbNewLine & "Do you wish to continue?", "Application Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) _
                = DialogResult.Yes Then
                MainForm.Show()
                Me.Close()
            Else
                Me.Close()
            End If
        End Try
    End Sub
    Private Sub DynamicClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim ColorBox As Panel = CType(sender, Panel)
        MainForm.HexColor.Text = ColorTranslator.ToHtml(ColorBox.BackColor)
    End Sub

    Private Sub SplashScreen_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Timer.Stop()
    End Sub
    Private Sub OpenColorDialog(sender As Object, e As EventArgs)
        Try
            MainForm.ColorDialog.Color = ColorTranslator.FromHtml(MainForm.HexColor.Text)
        Catch ex As Exception
        End Try
        If MainForm.ColorDialog.ShowDialog = DialogResult.OK Then
            MainForm.TilePreview.BackColor = MainForm.ColorDialog.Color
            MainForm.HexColor.Text = ColorTranslator.ToHtml(MainForm.ColorDialog.Color)
        End If
    End Sub
End Class

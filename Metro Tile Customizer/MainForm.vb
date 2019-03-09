Imports System.IO
Imports Shell32
Imports System.Drawing
Imports MetroFramework
Imports System.Security.Principal
Imports System.Drawing.Icon
Imports System.Xml

Public Class MainForm

#Region "Declarations"
    Private Lnk As LnkFile
#End Region

#Region "Event Handlers"
    Public Sub Startup(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox.DataSource = Core.StartMenuItems
        For Each Line As String In File.ReadLines(AppData("Colors_Main.txt"))
            MakeColorBox(Line, MainColorPanel)
        Next
        For Each Line As String In File.ReadLines(AppData("Colors_Other.txt"))
            MakeColorBox(Line, OtherColorPanel)
        Next
        For Each Line As String In File.ReadLines(AppData("Colors_Accent.txt"))
            MakeColorBox(Line, AccentPanel)
        Next
    End Sub

    Private Sub Shutdown(sender As Object, e As EventArgs) Handles MyBase.Closing
        Try
            Directory.Delete(AppData, True)
        Catch ex As Exception
            Close()
        End Try
    End Sub

    Private Sub FormReady(sender As Object, e As EventArgs) Handles Me.Shown
        Dim identity = WindowsIdentity.GetCurrent()
        Dim principal = New WindowsPrincipal(identity)
        Dim isElevated As Boolean = principal.IsInRole(WindowsBuiltInRole.Administrator)
        If isElevated = False Then
            MetroMessageBox.Show(Me, "Administrative rights Is required For the software To run properly. Please close And run the program As administrator.",
                                 "Insufficient Permissions", MessageBoxButtons.OK, MessageBoxIcon.Warning, 150)
        End If
    End Sub

    Public Sub SelectApplication(sender As Object, e As EventArgs) Handles ComboBox.SelectedIndexChanged
        Lnk = New LnkFile(ComboBox.SelectedValue)
        LinkPath.Text = Lnk.Target
        TilePreview.TileImage = Lnk.TargetIcon
        TilePreview.Text = ComboBox.Text
        Dim Config As String = Lnk.VisualManifest
        If IO.File.Exists(Config) Then
            Dim Tile As New MetroTile(Config)
            HexColor.Text = If(Tile.BackgroundColor <> Nothing, ColorTranslator.ToHtml(Tile.BackgroundColor), Nothing)
            TilePreview.BackColor = If(Tile.BackgroundColor <> Nothing, Tile.BackgroundColor, MetroColors.Green)
            TilePreview.ForeColor = If(Tile.ForegroundText = 0, Color.White, Color.Black)
            TilePreview.Text = Lnk.Name
            Switch_NameOnTile.Checked = Tile.ShowNameOnSquare
            opt_Text_Light.Checked = If(Tile.ForegroundText = 0, True, False)
            opt_Text_Dark.Checked = If(Tile.ForegroundText = 1, True, False)
        Else
            TilePreview.Text = ComboBox.Text
            TilePreview.BackColor = MetroColors.Green
            TilePreview.ForeColor = Color.White
            HexColor.Text = ""
            Switch_NameOnTile.Checked = True
            opt_Text_Light.Checked = True
        End If
    End Sub

    Public Sub ApplyButtonClick(sender As Object, e As EventArgs) Handles Colorize.Click
        If CheckData() = True Then
            ApplyChanges()
            Lnk.Refresh()
            MetroMessageBox.Show(Me, "Tile Customized! It may take a few seconds For the changes To be visible.", "Action Completed Succefully", MessageBoxButtons.OK, MessageBoxIcon.Question, 150)
        ElseIf LinkPath.Text = Nothing Then
            MetroMessageBox.Show(Me, "Please Select an item.", "Unable To Complete Action", MessageBoxButtons.OK, MessageBoxIcon.Error, 150)
        End If
    End Sub

    Private Sub HexColorChanged(sender As Object, e As EventArgs) Handles HexColor.TextChanged
        Dim Input = HexColor.Text
        Try
            TilePreview.BackColor = ColorTranslator.FromHtml(Input)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ToggleDarkText(sender As Object, e As EventArgs) Handles opt_Text_Dark.CheckedChanged
        TilePreview.ForeColor = Color.Black
    End Sub

    Private Sub ToggelLightText(sender As Object, e As EventArgs) Handles opt_Text_Light.CheckedChanged
        TilePreview.ForeColor = Color.White
    End Sub

    Private Sub RestoreButtonClick(sender As Object, e As EventArgs) Handles Restore.Click
        If CheckData() = True Then
            File.Delete(Lnk.VisualManifest)
            Lnk.Refresh()
            Me.Refresh()
            MetroMessageBox.Show(Me, "Tile Restored! It may take a few seconds For the changes To be visible.", "Action Completed Succefully", MessageBoxButtons.OK, MessageBoxIcon.Question, 150)
        Else
            MetroMessageBox.Show(Me, "Please Select an item.", "Unable To Complete Action", MessageBoxButtons.OK, MessageBoxIcon.Error, 150)
        End If
    End Sub

    Private Sub Shutdown(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing, MyBase.Closing
        If Directory.Exists(AppData) Then
            Directory.Delete(AppData, True)
        End If
    End Sub

    Private Sub ToogleName(sender As Object, e As EventArgs) Handles Switch_NameOnTile.CheckedChanged
        If Switch_NameOnTile.CheckState = CheckState.Checked Then
            TilePreview.Text = ComboBox.Text
        Else
            TilePreview.Text = Nothing
        End If
    End Sub

    Private Sub OpenFileLocationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileLocationToolStripMenuItem.Click
        If ComboBox.Text <> Nothing Then
            Dim folder = Path.GetDirectoryName(ComboBox.SelectedValue)
            Process.Start(folder)

        Else
            MetroMessageBox.Show(Me, "Please Select an item.", "Unable To Complete Action", MessageBoxButtons.OK, MessageBoxIcon.Error, 150)
        End If
    End Sub

    Private Sub OpentargetfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenTargetFileToolStripMenuItem.Click
        If ComboBox.Text <> Nothing Then
            Process.Start(Path.GetDirectoryName(LinkPath.Text))
        Else
            MetroMessageBox.Show(Me, "Please Select an item.", "Unable To Complete Action", MessageBoxButtons.OK, MessageBoxIcon.Error, 150)
        End If
    End Sub

    Private Sub OpenColorDialog(sender As Object, e As EventArgs) Handles AddColor.Click
        Try
            ColorDialog.Color = ColorTranslator.FromHtml(HexColor.Text)
        Catch ex As Exception
        End Try
        If ColorDialog.ShowDialog = DialogResult.OK Then
            TilePreview.BackColor = ColorDialog.Color
            HexColor.Text = ColorTranslator.ToHtml(ColorDialog.Color)
        End If
    End Sub

    Public Sub ChangeColor(ByVal sender As Object, ByVal e As EventArgs)
        Dim ColorBox As Panel = CType(sender, Panel)
        HexColor.Text = ColorTranslator.ToHtml(ColorBox.BackColor)
    End Sub
#End Region

#Region "Methods"
    Public Sub ReadConfiguration(ByVal defaultconfig)
        Try
            Using reader As XmlReader = XmlReader.Create(defaultconfig)
                While reader.Read()
                    If reader.IsStartElement() Then
                        If reader.Name = "VisualElements" Then
                            Dim backcolor As String = reader("BackgroundColor")
                            If backcolor IsNot Nothing Then
                                HexColor.Text = backcolor
                                TilePreview.BackColor = ColorTranslator.FromHtml(backcolor)
                            Else
                                TilePreview.BackColor = Color.MediumSeaGreen
                            End If
                            Dim showname As String = reader("ShowNameOnSquare150x150Logo")
                            If showname IsNot Nothing Then
                                If showname = "On" Then
                                    Switch_NameOnTile.CheckState = CheckState.Checked
                                    TilePreview.Text = ComboBox.Text
                                ElseIf showname = "off" Then
                                    Switch_NameOnTile.CheckState = CheckState.Unchecked
                                End If
                            End If
                            Dim textcolor As String = reader("ForegroundText")
                            If textcolor IsNot Nothing Then
                                If textcolor = "light" Then
                                    opt_Text_Light.Checked = True
                                    TilePreview.ForeColor = Color.White
                                ElseIf textcolor = "dark" Then
                                    opt_Text_Dark.Checked = True
                                    TilePreview.ForeColor = Color.Black
                                Else
                                    opt_Text_Light.Checked = True
                                    TilePreview.ForeColor = Color.White
                                End If

                            End If
                        End If
                    End If
                End While
            End Using
        Catch ex As Exception
            TilePreview.BackColor = Color.MediumSeaGreen
            Switch_NameOnTile.CheckState = CheckState.Checked
            TilePreview.Text = ComboBox.Text
            opt_Text_Light.Checked = True
            TilePreview.ForeColor = Color.White
        End Try
    End Sub

    Public Sub ApplyChanges()
        Dim saveloc As String = LinkPath.Text.Replace(".exe", ".visualelementsmanifest.xml")
        Dim i As Integer
        Dim aryText(5) As String
        aryText(0) = "<Application xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">"
        aryText(1) = "<VisualElements"
        If HexColor.Text = Nothing Then
            aryText(2) = "BackgroundColor=""" & Nothing & """"
        Else
            aryText(2) = "BackgroundColor=""" & ColorTranslator.ToHtml(TilePreview.BackColor) & """"
        End If
        If Switch_NameOnTile.CheckState = CheckState.Checked Then
            aryText(3) = "ShowNameOnSquare150x150Logo=""on"""
        ElseIf Switch_NameOnTile.CheckState = CheckState.Unchecked Then
            aryText(3) = "ShowNameOnSquare150x150Logo=""off"""
        End If
        If opt_Text_Light.Checked = True Then
            aryText(4) = "ForegroundText=""light""/>"
        ElseIf opt_Text_Dark.Checked = True Then
            aryText(4) = "ForegroundText=""dark""/>"
        End If
        aryText(5) = "</Application>"
        Dim objWriter As New System.IO.StreamWriter(saveloc)
        For i = 0 To 5
            objWriter.WriteLine(aryText(i))
        Next
        objWriter.Close()
    End Sub

    Function CheckData() As Boolean
        Dim Pre2, Pre3 As Boolean
        If ComboBox.SelectedValue <> Nothing AndAlso File.Exists(ComboBox.SelectedValue) Then
            Pre2 = True
        Else
            Pre2 = False
        End If
        If LinkPath.Text <> Nothing AndAlso File.Exists(LinkPath.Text) Then
            Pre3 = True
        Else
            Pre3 = False
        End If
        If Pre2 = True And Pre3 = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub MakeColorBox(ByVal line As String, ByVal Parent As FlowLayoutPanel)
        Dim ColorBox As New Panel
        ColorBox.BackColor = ColorTranslator.FromHtml(line)
        ColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        ColorBox.Size = New Size(30, 30)
        AddHandler ColorBox.Click, AddressOf ChangeColor
        Parent.Controls.Add(ColorBox)
    End Sub
#End Region

End Class
Imports System.IO
Imports Shell32
Imports System.Drawing
Imports MetroFramework
Imports System.Security.Principal
Imports System.Drawing.Icon
Imports System.Xml

Public Class MainForm

#Region "Declarations"
    Dim ProgramDataItems = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu) & "\Programs", "*.lnk", SearchOption.AllDirectories)
    Dim AppDataItems = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) & "\Programs", "*.lnk", SearchOption.AllDirectories)
    Dim ItemPath As String
    Dim ColorBox As New Panel
    Dim AppData = My.Computer.FileSystem.SpecialDirectories.Temp & "\MetroTileChanger"
#End Region

#Region "Event Handlers"
    Public Sub Startup(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Style = MetroColorStyle.Green
        If Directory.Exists(AppData) = False Then
            Directory.CreateDirectory(AppData)
        End If
    End Sub

    Private Sub Shutdown(sender As Object, e As EventArgs) Handles MyBase.Closing
        Try
            Directory.Delete(AppData, True)
        Catch ex As Exception
            Me.Close()
        End Try
    End Sub

    Private Sub StartupCheck(sender As Object, e As EventArgs) Handles Me.Shown
        Dim identity = WindowsIdentity.GetCurrent()
        Dim principal = New WindowsPrincipal(identity)
        Dim isElevated As Boolean = principal.IsInRole(WindowsBuiltInRole.Administrator)
        If isElevated = False Then
            MetroMessageBox.Show(Me, "Administrative rights Is required For the software To run properly. Please close And run the program As administrator.",
                                 "Insufficient Permissions", MessageBoxButtons.OK, MessageBoxIcon.Warning, 150)
        End If
    End Sub

    Public Sub SelectApplication(sender As Object, e As EventArgs) Handles ComboBox.SelectedIndexChanged
        HiddenComboBox.SelectedIndex = ComboBox.SelectedIndex
        LinkPath.Text = GetTargetPath(HiddenComboBox.Text)
        ItemPath = Path.GetDirectoryName(HiddenComboBox.SelectedItem.ToString)
        TilePreview.TileImage = ExtractAssociatedIcon(LinkPath.Text).ToBitmap()
        TilePreview.Text = ComboBox.Text
        Try
            Dim defaultconfig As String = LinkPath.Text.Replace(".exe", ".visualelementsmanifest.xml")
            If IO.File.Exists(defaultconfig) Then
                ReadConfiguration(defaultconfig)
            Else
                TilePreview.Text = ComboBox.Text
                TilePreview.BackColor = Color.MediumSeaGreen
                TilePreview.ForeColor = Color.White
                HexColor.Text = ""
                Switch_NameOnTile.Checked = True
                opt_Text_Light.Checked = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub ApplyButtonClick(sender As Object, e As EventArgs) Handles Button1_Colorize.Click
        If CheckData() = True Then
            ApplyChanges()
            RefreshStartMenu()
            MetroMessageBox.Show(Me, "Tile Customized! It may take a few seconds For the changes To be visible.", "Action Completed Succefully", MessageBoxButtons.OK, MessageBoxIcon.Question, 150)
        ElseIf LinkPath.Text = Nothing
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

    Private Sub RestoreButtonClick(sender As Object, e As EventArgs) Handles Button2_Restore.Click
        If CheckData() = True Then
            Dim defaultconfig As String = LinkPath.Text.Replace(".exe", ".visualelementsmanifest.xml")
            File.Delete(defaultconfig)
            RefreshStartMenu()
            Me.Refresh()
            MetroMessageBox.Show(Me, "Tile Restored! It may take a few seconds For the changes To be visible.", "Action Completed Succefully", MessageBoxButtons.OK, MessageBoxIcon.Question, 150)
        Else
            MetroMessageBox.Show(Me, "Please Select an item.", "Unable To Complete Action", MessageBoxButtons.OK, MessageBoxIcon.Error, 150)
        End If
    End Sub

    Private Sub Shutdown(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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
            Dim folder = Path.GetDirectoryName(HiddenComboBox.Text)
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

#End Region

#Region "Sub Methods"
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

    Function GetTargetPath(ByVal lnkpath As String)
        Dim guid As System.Guid = New System.Guid("13709620-C279-11CE-A49E-444553540000")
        Dim shl As Shell = DirectCast(Activator.CreateInstance(Type.GetTypeFromCLSID(guid)), Shell)
        lnkpath = Path.GetFullPath(lnkpath)
        Dim dir As Folder = shl.[NameSpace](Path.GetDirectoryName(lnkpath))
        Dim itm As FolderItem = dir.Items().Item(Path.GetFileName(lnkpath))
        Dim filename = (DirectCast(itm.GetLink, ShellLinkObject)).Target.Name
        Dim folder = (DirectCast(itm.GetLink, ShellLinkObject)).WorkingDirectory
        Dim filepath = (DirectCast(itm.GetLink, ShellLinkObject)).Target.Path
        Dim workaround = filepath.Replace("Program Files (x86)", "Program Files")
        If File.Exists(folder & "\" & filename) = True Then
            Return folder & "\" & filename
        ElseIf File.Exists(filepath) = True
            Return filepath
        ElseIf File.Exists(workaround)
            Return workaround
        Else
            Return Nothing
        End If
    End Function

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
        RefreshStartMenu()
    End Sub

    Private Sub RefreshStartMenu()
        Dim CMDThread As New Threading.Thread(AddressOf CMD_RefreshStart)
        CMDThread.Start()
    End Sub

    Private Sub CMD_RefreshStart()
        Dim myprocess As New Process
        Dim StartInfo As New System.Diagnostics.ProcessStartInfo
        StartInfo.FileName = "cmd.exe"
        StartInfo.RedirectStandardInput = True
        StartInfo.UseShellExecute = False
        StartInfo.CreateNoWindow = True
        myprocess.StartInfo = StartInfo
        myprocess.Start()
        Dim SW As System.IO.StreamWriter = myprocess.StandardInput
        SW.WriteLine("cd " & ItemPath)
        SW.WriteLine("For %f In (*.lnk) Do copy /b ""%f"" +,,")
        SW.WriteLine("exit")
        SW.Close()
    End Sub

    Function CheckData() As Boolean
        Dim Pre1, Pre2, Pre3 As Boolean
        If ComboBox.Text <> Nothing Or ComboBox.SelectedItem <> Nothing Then
            Pre1 = True
        Else
            Pre1 = False
        End If
        If HiddenComboBox.SelectedItem <> Nothing AndAlso File.Exists(HiddenComboBox.Text) Then
            Pre2 = True
        Else
            Pre2 = False
        End If
        If LinkPath.Text <> Nothing AndAlso File.Exists(LinkPath.Text) Then
            Pre3 = True
        Else
            Pre3 = False
        End If
        If Pre1 = True And Pre2 = True And Pre3 = True Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

End Class
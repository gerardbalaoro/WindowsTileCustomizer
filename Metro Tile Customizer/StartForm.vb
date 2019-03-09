Imports System.IO

Public NotInheritable Class StartForm
    Private Sub StartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Title.Text = My.Application.Info.Title
        Version.Text = "Version " & My.Application.Info.Version.ToString
        Worker.RunWorkerAsync()
    End Sub

    Private Sub Worker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Worker.DoWork
        Worker.ReportProgress(25, "Loading Temporary Files")
        Directory.CreateDirectory(AppData)
        File.WriteAllBytes(AppData("Colors_Main.txt"), My.Resources.Colors_Main)
        File.WriteAllBytes(AppData("Colors_Other.txt"), My.Resources.Colors_Other)
        File.WriteAllBytes(AppData("Colors_Accent.txt"), My.Resources.Colors_Accent)
        Worker.ReportProgress(50, "Retrieving Start Menu Items")
        GetStartMenuItems()
        Worker.ReportProgress(100, "Starting")
    End Sub
End Class

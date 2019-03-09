Imports System.IO
Imports System.Xml

Module ColorBoxes
    Public Main As New List(Of Control)
    Public Accents As New List(Of Control)
    Public Other As New List(Of Control)
End Module

Module Core
    Public ProgramDataItems = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu) & "\Programs", "*.lnk", SearchOption.AllDirectories)
    Public AppDataItems = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) & "\Programs", "*.lnk", SearchOption.AllDirectories)
    Public StartMenuItems As New DataTable

    Sub New()
        StartMenuItems.Columns.Add("path")
        StartMenuItems.Columns.Add("name")
    End Sub

    Public Function AppData(Optional Path As String = Nothing)
        Return String.Join("\", My.Computer.FileSystem.SpecialDirectories.Temp & "\MetroTileChanger", Path)
    End Function

    Public Sub GetStartMenuItems()
        StartMenuItems.Rows.Clear()

        For Each Item In AppDataItems
            StartMenuItems.Rows.Add(Item, Path.GetFileNameWithoutExtension(Item))
        Next
        For Each Item In ProgramDataItems
            StartMenuItems.Rows.Add(Item, Path.GetFileNameWithoutExtension(Item))
        Next
        StartMenuItems.DefaultView.Sort = "name asc"
    End Sub
End Module

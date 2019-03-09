Imports Shell32
Imports System.IO
Imports System.IO.Path
Imports System.Text.RegularExpressions

Public Class LnkFile
    Public Property Path As String

    Public ReadOnly Property Target As String
        Get
            Dim Obj As Object
            Obj = CreateObject("WScript.Shell")
            Dim Shortcut As Object
            Shortcut = Obj.CreateShortcut(Path)
            Dim TargetPath As String = Shortcut.TargetPath
            If File.Exists(TargetPath) Then
                Return TargetPath
            Else
                Return TargetPath.Replace("Program Files (x86)", "Program Files")
            End If
        End Get
    End Property

    Public ReadOnly Property TargetIcon
        Get
            Try
                Return Icon.ExtractAssociatedIcon(Target).ToBitmap()
            Catch ex As Exception
                Return Nothing
            End Try
        End Get
    End Property

    Public ReadOnly Property VisualManifest As String
        Get
            Return Regex.Replace(Target, "\.[E|e][X|x][E|e]", ".visualelementsmanifest.xml")
        End Get
    End Property

    Public ReadOnly Property Name As String
        Get
            Return GetFileNameWithoutExtension(Path)
        End Get
    End Property

    Public Sub New(Path As String)
        Me.Path = Path
    End Sub

    Public Sub Refresh()
        File.SetLastWriteTime(Path, Now)
    End Sub
End Class

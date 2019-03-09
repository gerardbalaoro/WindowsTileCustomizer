Imports System.IO
Imports System.Xml

Public Class MetroTile
    Public Enum ForeColor
        light
        dark
    End Enum

    Public BackgroundColor As Color = Nothing
    Public ForegroundText As ForeColor = ForeColor.dark
    Public ShowNameOnSquare As Boolean = True
    Public Location As String = Nothing

    Public Sub New(Optional Path As String = Nothing)
        If Path IsNot Nothing Then
            If File.Exists(Path) Then
                Read(Path)
            Else
                Location = Path
            End If
        End If
    End Sub

    Public Sub Read(Optional Path As String = Nothing)
        If File.Exists(If(Path, Location)) Then
            Try
                Using Reader As XmlReader = XmlReader.Create(If(Path, Location))
                    While Reader.Read()
                        If Reader.IsStartElement() Then
                            If Reader.Name = "VisualElements" Then
                                Dim BackColor = Reader("BackgroundColor")
                                Dim ShowName As String = Reader("ShowNameOnSquare150x150Logo")
                                Dim TextColor As String = Reader("ForegroundText")
                                BackgroundColor = If(BackColor <> Nothing, ColorTranslator.FromHtml(BackColor), Nothing)
                                ShowNameOnSquare = If(ShowName.ToLower = "off", False, True)
                                ForegroundText = If(TextColor = "dark", ForeColor.dark, ForeColor.light)
                            End If
                        End If
                    End While
                End Using
            Catch Err As Exception

            End Try
        End If
    End Sub

    Public Sub Write(Optional Path As String = Nothing)
        Dim Document As XDocument = <?xml version="1.0" encoding="UTF-8"?>
                                    <Application xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
                                        <VisualElements
                                            BackgroundColor=<%= ColorTranslator.ToHtml(BackgroundColor) %>
                                            ShowNameOnSquare150x150Logo=<%= If(ShowNameOnSquare = True, "on", "off") %>
                                            ForegroundText=<%= ForegroundText %>
                                        />
                                    </Application>
        Document.Save(If(Path, Location))
    End Sub
End Class

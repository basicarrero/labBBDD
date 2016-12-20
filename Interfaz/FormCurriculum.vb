Imports System.IO

Public Class formCurriculum
    Private inv As Investigador

    Private Sub depForm_Load() Handles Me.Load
        webBrMain.DocumentText = cvToHtm(inv)
    End Sub

    Public WriteOnly Property Investigador() As Investigador
        Set(val As Investigador)
            inv = val
        End Set
    End Property

    Public Function cvToHtm(ByRef inv As Investigador) As String
        Dim cvpage As String = "<html><head><meta content=""text/html; charset=UTF-8"" http-equiv=""content-type""><title>CV</title></head>" & _
            "<body><br>" & _
            "<div class=""WordSection1"">" & _
            "<p style=""LINE-HEIGHT: 0cm; MARGIN-BOTTOM: 1pt""><span style=""FONT-FAMILY: 'Tahoma','sans-serif'; FONT-SIZE: 9pt"">" & inv.Departamento.Nombre & ": <span style=""mso-tab-count: 1""></span>Edificio " & inv.Edificio & ", Despacho " & inv.Despacho & "</span></p>" & _
            "<p style=""LINE-HEIGHT: 0cm; MARGIN-BOTTOM: 1pt""><span style=""FONT-FAMILY: 'Tahoma','sans-serif'; FONT-SIZE: 9pt"">" & inv.Telefono & "</span></p>" & _
            "<p style=""LINE-HEIGHT: 0cm; MARGIN-BOTTOM: 30pt""><span style=""FONT-FAMILY: 'Tahoma','sans-serif'; FONT-SIZE: 9pt"">" & inv.Email & "</span></p>" & _
            "<p style=""LINE-HEIGHT: 0cm; MARGIN-BOTTOM: 20pt""><span style=""LINE-HEIGHT: 120%; FONT-FAMILY: 'Tahoma','sans-serif'; COLOR: gray; FONT-SIZE: 24pt"">" & inv.ToString & "</span></p>" & _
            "<p style=""MARGIN-BOTTOM: 0pt""><span style=""FONT-FAMILY: 'Tahoma','sans-serif'; FONT-SIZE: 9pt"">Artículos:</span></p>" & _
            "<div style=""TEXT-ALIGN: center; LINE-HEIGHT: normal; MARGIN-BOTTOM: 0pt"" align=""center""><span style=""FONT-FAMILY: 'Tahoma','sans-serif'; FONT-SIZE: 9pt""><hr align=""center"" size=""2"" width=""100%""></span></div>" & _
            "<p style=""LINE-HEIGHT: normal; MARGIN: 0cm 0cm 0pt 120.5pt""><span style=""FONT-FAMILY: 'Tahoma','sans-serif'; FONT-SIZE: 9pt"">" & _
            artList(inv) & "</span></p>" & _
            "<p style=""MARGIN-BOTTOM: 0pt""><span style=""FONT-FAMILY: 'Tahoma','sans-serif'; FONT-SIZE: 9pt"">Conferencias como Asistente:</span></p>" & _
            "<div style=""TEXT-ALIGN: center; LINE-HEIGHT: normal; MARGIN-BOTTOM: 0pt"" align=""center""><span style=""FONT-FAMILY: 'Tahoma','sans-serif'; FONT-SIZE: 9pt""><hr align=""center"" size=""2"" width=""100%""></span></div>" & _
            "<p style=""LINE-HEIGHT: normal; MARGIN: 0cm 0cm 0pt 120.5pt""><span style=""FONT-FAMILY: 'Tahoma','sans-serif'; FONT-SIZE: 9pt"">" & _
            confList(inv) & "</span></p>" & _
            "</div>" & _
            "</body>" & _
            "</html>"
        Return cvpage
    End Function

    Private Function artList(ByRef inv As Investigador) As String
        Dim str As String = ""
        For Each art As Articulo In inv.GetArticulos(formMain.conferencias)
            If art.Autoria.Count > 0 Then
                art.Autoria.Sort()
                For Each aut In art.Autoria
                    str = str & aut.Apellidos & ", " & aut.Nombre & "; "
                Next
                str = str.Substring(0, str.Length - 2) & "."
            End If
            str = str & " <i>" & art.Titulo.ToString & ".</i>"
            str = str & " " & art.Conferencia.Nombre.ToString & "."
            str = str & " (" & art.Conferencia.Siglas & ")"
            str = str & " pp. " & art.PagInicio.ToString & "-" & art.PagFin & "."
            str = str & " " & art.Conferencia.Lugar.ToString & "."
            str = str & " " & art.Conferencia.fechaInicio.Year.ToString & "."
            str = str & "<br>" & "<br>"
        Next
        Return str
    End Function

    Private Function confList(ByRef inv As Investigador) As String
        Dim str As String = ""
        Dim asis As List(Of Conferencia) = inv.GetAsistencia(formMain.conferencias)
        asis.Sort()
        For Each conf In asis
            If conf.fechaFin < Today Then
                str = str & conf.Nombre.ToString & "<br>"
            Else
                str = str & "<font color=""grey"">" & conf.Nombre.ToString & "</font><br>"
            End If
        Next
        Return str
    End Function

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs)
        Dim fname As String
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "HTM file (*.htm)|*.htm *.html"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        saveFileDialog1.FileName = "CV_" & inv.ToString & ".htm"
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                fname = saveFileDialog1.FileName
                If (fname IsNot Nothing) Then
                    Dim writer As TextWriter = File.CreateText(fname)
                    writer.Write(webBrMain.DocumentText)
                    writer.Close()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class
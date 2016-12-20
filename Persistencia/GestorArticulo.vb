Imports System.Data.OleDb

Public Class GestorArticulo
    Public Shared Function readArt(ByVal conf As Conferencia) As List(Of Articulo)
        Dim reader As OleDbDataReader = AgenteBD.getInstancia.read _
            ("SELECT * FROM Articulos WHERE Conferencia LIKE '" & conf.ID & "'")
        Dim articulos As List(Of Articulo) = New List(Of Articulo)
        Dim id As String
        Dim titulo As String
        Dim pagInicio As UInteger
        Dim pagFin As UInteger
        Dim read As Boolean
        If reader.Read() = True Then
            Do
                id = reader.GetValue(reader.GetOrdinal("idArticulo"))
                titulo = reader.GetValue(reader.GetOrdinal("Titulo"))
                pagInicio = reader.GetValue(reader.GetOrdinal("pag_inicio"))
                pagFin = reader.GetValue(reader.GetOrdinal("pag_fin"))
                articulos.Add(New Articulo(id, titulo, pagInicio, pagFin, conf))
                read = reader.Read()
            Loop While read = True
        End If
        Return articulos
    End Function

    Public Shared Function insArt(ByRef art As Articulo) As Integer
        Dim count As Integer = 0
        If art IsNot Nothing Then
            count = AgenteBD.getInstancia().create _
                ("INSERT INTO Articulos (IdArticulo, Titulo, Conferencia, pag_inicio, pag_fin) " & _
                 "VALUES ('" & art.ID & "','" & art.Titulo & "','" & art.Conferencia.ID & "'," & _
                 art.PagInicio & "," & art.PagFin & ")")
            count += GestorAutoria.insAutores(art)
        End If
        Return count
    End Function

    Public Shared Function modArt(ByRef art As Articulo) As Integer
        Dim count As Integer = 0
        If art IsNot Nothing Then
            count = AgenteBD.getInstancia().update _
                ("UPDATE Articulos SET Titulo = '" & art.Titulo & "', Conferencia = '" & art.Conferencia.ID & _
                 "', pag_Inicio = " & art.PagInicio & ", pag_Fin = " & art.PagFin & " WHERE IdArticulo = '" & art.ID & "'")
            count += GestorAutoria.modAutores(art)
        End If
        Return count
    End Function

    Public Shared Function delArt(ByRef art As Articulo) As Integer
        Dim count As Integer = 0
        If art IsNot Nothing Then
            count = AgenteBD.getInstancia().delete("DELETE FROM Autor WHERE Articulo = '" & art.ID & "'")
            count += AgenteBD.getInstancia().delete("DELETE FROM Articulos WHERE IdArticulo = '" & art.ID & "'")
        End If
        Return count
    End Function

    Public Shared Function delArticulos(ByRef artLst As List(Of Articulo)) As Integer
        Dim count As Integer = 0
        For Each art In artLst
            count += delArt(art)
        Next
        Return count
    End Function
End Class
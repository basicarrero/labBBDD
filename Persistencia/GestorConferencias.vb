Imports System.Data.OleDb

Public Class GestorConferencias
    Public Shared Function readConf() As List(Of Conferencia)
        Dim reader As OleDbDataReader = AgenteBD.getInstancia.read("SELECT * FROM Conferencias")
        Dim conferencias As List(Of Conferencia) = New List(Of Conferencia)
        Dim conf As Conferencia
        Dim id As String
        Dim siglas As String
        Dim nombre As String
        Dim lugar As String
        Dim inicio As Date
        Dim fin As Date
        Dim read As Boolean
        If reader.Read() = True Then
            Do
                id = reader.GetValue(reader.GetOrdinal("idConferencia"))
                nombre = reader.GetValue(reader.GetOrdinal("Nombre"))
                siglas = reader.GetValue(reader.GetOrdinal("Siglas"))
                lugar = reader.GetValue(reader.GetOrdinal("Lugar"))
                inicio = reader.GetValue(reader.GetOrdinal("Fecha_inicio"))
                fin = reader.GetValue(reader.GetOrdinal("Fecha_fin"))
                conf = New Conferencia(id, nombre, siglas, lugar, inicio, fin, Nothing)
                conf.Articulos = GestorArticulo.readArt(conf)
                conferencias.Add(conf)
                read = reader.Read()
            Loop While read = True
        End If
        Return conferencias
    End Function

    Public Shared Function insConf(ByRef conf As Conferencia) As Integer
        Dim count As Integer = 0
        If conf IsNot Nothing Then
            count = AgenteBD.getInstancia().create _
                ("INSERT INTO Conferencias (IdConferencia, Siglas, Nombre, Lugar, Fecha_inicio, Fecha_fin) " & _
                 "VALUES ('" & conf.ID & "','" & conf.Siglas & "','" & conf.Nombre & "','" & conf.Lugar & "','" & _
                conf.fechaInicio.ToShortDateString & "','" & conf.fechaFin.ToShortDateString & "')")
            count += GestorAsistentes.insAsistentes(conf)
            For Each art In conf.Articulos
                count += AgenteBD.getInstancia().update _
                    ("UPDATE Articulos SET Conferencia = '" & conf.ID & "' WHERE IdArticulo = '" & art.ID & "'")
            Next
        End If
        Return count
    End Function

    Public Shared Function modConf(ByRef conf As Conferencia) As Integer
        Dim count As Integer = 0
        If conf IsNot Nothing Then
            count = AgenteBD.getInstancia().update _
                ("UPDATE Conferencias SET Siglas = '" & conf.Siglas & _
                 "', Nombre = '" & conf.Nombre & _
                 "', Lugar = '" & conf.Lugar & _
                 "', Fecha_inicio = '" & conf.fechaInicio.ToShortDateString & _
                 "', Fecha_fin = '" & conf.fechaFin.ToShortDateString & "' WHERE IdConferencia = '" & conf.ID & "'")
            count += GestorAsistentes.delAsistentes(conf) - GestorAsistentes.insAsistentes(conf)
            Dim ddbbConfArts As List(Of Articulo) = GestorArticulo.readArt(conf)
            For Each ddbbArt In ddbbConfArts
                If Not conf.Articulos.Contains(ddbbArt) Then
                    count += GestorArticulo.delArt(ddbbArt)
                End If
            Next
            For Each art In conf.Articulos
                If Not ddbbConfArts.Contains(art) Then
                    count += AgenteBD.getInstancia().update _
                    ("UPDATE Articulos SET Conferencia = '" & conf.ID & "' WHERE IdArticulo = '" & art.ID & "'")
                End If
            Next
        End If
        Return count
    End Function

    Public Shared Function delConf(ByRef conf As Conferencia) As Integer
        Dim count As Integer = 0
        If conf IsNot Nothing Then
            count += GestorAsistentes.delAsistentes(conf)
            count += GestorArticulo.delArticulos(conf.Articulos)
            count += AgenteBD.getInstancia().delete("DELETE FROM Conferencias WHERE IdConferencia = '" & conf.ID & "'")
        End If
        Return count
    End Function
End Class
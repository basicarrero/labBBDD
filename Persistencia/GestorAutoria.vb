Imports System.Data.OleDb

Public Class GestorAutoria
    Public Shared Function readAutoria(ByVal artID As String, ByRef departamentos As List(Of Departamento)) As List(Of Investigador)
        Dim reader As OleDbDataReader = AgenteBD.getInstancia.read _
            ("SELECT Invest, Orden FROM Autor WHERE Articulo LIKE '" & artID & "' ORDER BY Orden")
        Dim autores As List(Of Investigador) = New List(Of Investigador)
        Dim invest As Investigador
        Dim read As Boolean
        If reader.Read() = True Then
            Do
                invest = GestorBBDD.getRefInvest(reader.GetValue(reader.GetOrdinal("Invest")), departamentos)
                autores.Add(invest)
                read = reader.Read()
            Loop While read = True
        End If
        Return autores
    End Function

    Public Shared Function insAutores(ByRef art As Articulo) As Integer
        Dim count As Integer = 0
        If art IsNot Nothing Then
            For Each aut In art.Autoria
                count += AgenteBD.getInstancia().create _
                ("INSERT INTO Autor (Invest, Articulo, Orden) VALUES " & _
                 "('" & aut.ID & "','" & art.ID & "','" & art.Autoria.IndexOf(aut) + 1 & "')")
            Next
        Else
            count = -1
        End If
        Return count
    End Function

    Public Shared Function modAutores(ByRef art As Articulo) As Integer
        Dim count As Integer = 0
        count += delAllAutor(art)
        count += insAutores(art)
        Return count
    End Function

    Public Shared Function delAllAutor(ByRef art As Articulo) As Integer
        If art IsNot Nothing Then
            Return AgenteBD.getInstancia().delete("DELETE FROM Autor WHERE Articulo = '" & art.ID & "'")
        Else
            Return -1
        End If
    End Function

    Public Shared Function delAutor(ByRef art As Articulo, ByRef inv As Investigador) As Integer
        If art IsNot Nothing And inv IsNot Nothing Then
            Return AgenteBD.getInstancia().delete("DELETE FROM Autor WHERE Invest = " & _
                                                  "'" & inv.ID & "' AND Articulo = '" & art.ID & "'")
        Else
            Return -1
        End If
    End Function
End Class
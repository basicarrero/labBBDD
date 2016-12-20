Imports System.Data.OleDb

Public Class GestorAsistentes
    Public Shared Function readAsistentes(ByVal confID As String, ByRef departamentos As List(Of Departamento)) As List(Of Investigador)
        Dim reader As OleDbDataReader = AgenteBD.getInstancia.read _
            ("SELECT Invest FROM Asiste WHERE Conferencia LIKE '" & confID & "'")
        Dim asistentes As List(Of Investigador) = New List(Of Investigador)
        Dim investigador As Investigador
        Dim read As Boolean
        If reader.Read() = True Then
            Do
                investigador = GestorBBDD.getRefInvest(reader.GetValue(reader.GetOrdinal("Invest")), departamentos)
                asistentes.Add(investigador)
                read = reader.Read()
            Loop While read = True
        End If
        Return asistentes
    End Function

    Public Shared Function insAsistentes(ByRef conf As Conferencia) As Integer
        Dim count As Integer = 0
        If conf IsNot Nothing Then
            For Each invest In conf.Asistentes
                count = GestorAsistentes.insAsistencia(conf, invest)
            Next
        End If
        Return count
    End Function

    Public Shared Function insAsistencia(ByRef conf As Conferencia, ByRef invest As Investigador) As Integer
        Return AgenteBD.getInstancia().create _
                ("INSERT INTO Asiste (Conferencia, Invest) VALUES ('" & conf.ID & "','" & invest.ID & "')")
    End Function

    Public Shared Function delAsistencia(ByRef conf As Conferencia, ByRef invest As Investigador) As Integer
        Return AgenteBD.getInstancia().delete("DELETE FROM Asiste WHERE Conferencia = '" & _
                                              conf.ID & "' AND Invest = '" & invest.ID & "'")
    End Function

    Public Shared Function delAsistentes(ByRef conf As Conferencia) As Integer
        Return AgenteBD.getInstancia().delete("DELETE FROM Asiste WHERE Conferencia = '" & conf.ID & "'")
    End Function
End Class
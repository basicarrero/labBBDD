Imports System.Data.OleDb

Public Class GestorDepartamentos
    Public Shared Function readDep() As List(Of Departamento)
        Dim reader As OleDbDataReader = AgenteBD.getInstancia.read("SELECT * FROM Departamentos")
        Dim departamentos As List(Of Departamento) = New List(Of Departamento)
        Dim dep As Departamento
        Dim id As String
        Dim nombre As String
        Dim read As Boolean
        If reader.Read() = True Then
            Do
                id = reader.GetValue(reader.GetOrdinal("idDepartamento"))
                nombre = reader.GetValue(reader.GetOrdinal("Nombre"))
                dep = New Departamento(id, nombre, Nothing)
                dep.Investigadores = GestorInvestigadores.readInves(dep)
                departamentos.Add(dep)
                read = reader.Read()
            Loop While read = True
        End If
        Return departamentos
    End Function

    Public Shared Function insDep(ByRef dep As Departamento) As Integer
        If dep IsNot Nothing Then
            Return AgenteBD.getInstancia().create _
                ("INSERT INTO Departamentos (IdDepartamento, Nombre) VALUES ('" + dep.ID + "','" + dep.Nombre + "')")
        Else
            Return -1
        End If
    End Function

    Public Shared Function modDep(ByRef dep As Departamento) As Integer
        If dep IsNot Nothing Then
            Return AgenteBD.getInstancia().update _
                ("UPDATE Departamentos SET Nombre = '" & dep.Nombre & "' WHERE IdDepartamento = '" & dep.ID & "'")
        Else
            Return -1
        End If
    End Function

    Public Shared Function delDep(ByRef dep As Departamento) As Integer
        Dim count As Integer = 0
        If dep IsNot Nothing Then
            count += AgenteBD.getInstancia().delete("DELETE FROM Departamentos WHERE IdDepartamento = '" & dep.ID & "'")
            For Each invest In dep.Investigadores
                count += GestorInvestigadores.delInvest(invest)
            Next
        End If
        Return count
    End Function
End Class
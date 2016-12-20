Imports System.Data.OleDb

Public Class GestorInvestigadores
    Public Shared Function readInves(ByRef dep As Departamento) As List(Of Investigador)
        Dim reader As OleDbDataReader = AgenteBD.getInstancia.read _
            ("SELECT * FROM Investigadores WHERE Departamento LIKE '" & dep.ID & "'")
        Dim investigadores As List(Of Investigador) = New List(Of Investigador)
        Dim id As String
        Dim nombre As String
        Dim apellidos As String
        Dim edificio As String
        Dim mail As String
        Dim telf As ULong
        Dim despacho As Integer
        Dim read As Boolean
        If reader.Read() = True Then
            Do
                id = reader.GetValue(reader.GetOrdinal("idInvest"))
                nombre = reader.GetValue(reader.GetOrdinal("Nombre"))
                apellidos = reader.GetValue(reader.GetOrdinal("Apellidos"))
                edificio = reader.GetValue(reader.GetOrdinal("Edificio"))
                telf = reader.GetValue(reader.GetOrdinal("Telefono"))
                despacho = reader.GetValue(reader.GetOrdinal("Despacho"))
                mail = reader.GetValue(reader.GetOrdinal("Email"))
                investigadores.Add(New Investigador(id, nombre, apellidos, edificio, mail, telf, despacho, dep))
                read = reader.Read()
            Loop While read = True
        End If
        Return investigadores
    End Function

    Public Shared Function insInvest(ByRef invest As Investigador) As Integer
        If invest IsNot Nothing Then
            Return AgenteBD.getInstancia().create _
                ("INSERT INTO Investigadores (IdInvest, Nombre, Apellidos, Despacho, Edificio, Departamento, Telefono, Email)" _
                & "VALUES ('" & invest.ID & "','" & invest.Nombre & "','" & invest.Apellidos & "','" _
                & invest.Despacho & "','" & invest.Edificio & "','" & invest.Departamento.ID & "','" _
                & invest.Telefono & "','" & invest.Email & "')")
        Else
            Return -1
        End If
    End Function

    Public Shared Function modInvest(ByRef invest As Investigador) As Integer
        If invest IsNot Nothing Then
            Return AgenteBD.getInstancia().create _
                ("UPDATE Investigadores SET Nombre = '" & invest.Nombre & _
                 "', Apellidos = '" & invest.Apellidos & _
                 "', Despacho = " & invest.Despacho & _
                 ", Edificio = '" & invest.Edificio & _
                 "', Departamento = '" & invest.Departamento.ID & _
                 "', Telefono = " & invest.Telefono & _
                 ", Email = '" & invest.Email & "' WHERE IdInvest = '" & invest.ID & "'")
        Else
            Return -1
        End If
    End Function

    Public Shared Function delInvest(ByRef invest As Investigador) As Integer
        Dim count As Integer = 0
        If invest IsNot Nothing Then
            count += AgenteBD.getInstancia().delete("DELETE FROM Investigadores WHERE IdInvest = '" & invest.ID & "'")
            count += AgenteBD.getInstancia().delete("DELETE FROM Asiste WHERE Invest = '" & invest.ID & "'")
            count += AgenteBD.getInstancia().delete("DELETE FROM Autor WHERE Invest = '" & invest.ID & "'")
        End If
        Return count
    End Function
End Class
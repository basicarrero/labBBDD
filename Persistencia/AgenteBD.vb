Imports System.Data.OleDb

Public Class AgenteBD
    Private Shared instancia As AgenteBD = Nothing
    Private Shared mConexion As OleDbConnection

    Public Sub conectar(ByVal CadConexion As String)
        AgenteBD.mConexion = New OleDbConnection
        AgenteBD.mConexion.ConnectionString = CadConexion
        Try
            AgenteBD.mConexion.Open()
        Catch ex As Exception
            Throw New Exception("Error al conectar con datos" & ControlChars.CrLf & ex.Message)
        End Try
    End Sub

    Public Sub desconectar()
        Try
            AgenteBD.mConexion.Close()
        Catch ex As Exception
            Throw New Exception("Error al conectar con datos" & ControlChars.CrLf & ex.Message)
        End Try
    End Sub

    ' IMPLEMENTACIÓN DEL PATRÓN DE DISEÑO SINGLETON
    Public Shared Function getInstancia() As AgenteBD
        If instancia Is Nothing Then
            instancia = New AgenteBD()
        End If
        Return instancia
    End Function

    Public Function read(ByVal sql As String) As OleDbDataReader
        Dim com As New OleDbCommand(sql, mConexion)
        Return com.ExecuteReader()
    End Function

    Public Function executeSQL(ByVal sql As String) As Integer
        Dim com As New OleDbCommand(sql, mConexion)
        Return com.ExecuteNonQuery()
    End Function

    Public Function update(ByVal sql As String)
        Return executeSQL(sql)
    End Function

    Public Function delete(ByVal sql As String)
        Return executeSQL(sql)
    End Function

    Public Function create(ByVal sql As String)
        Return executeSQL(sql)
    End Function
End Class
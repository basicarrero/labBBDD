Public Class Departamento
    Private _ID As String
    Private _Nombre As String
    Private _Investigadores As List(Of Investigador)

    Public Sub New(ByVal ID As String, ByVal nombre As String, ByRef investigadores As List(Of Investigador))
        _ID = ID
        _Nombre = nombre
        If investigadores IsNot Nothing Then
            _Investigadores = investigadores
        Else
            _Investigadores = New List(Of Investigador)
        End If
    End Sub

    Public Overrides Function ToString() As String
        Return _Nombre
    End Function ' ToString

    Public Property ID() As String
        Get
            Return _ID
        End Get
        Set(val As String)
            _ID = val
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(val As String)
            _Nombre = val
        End Set
    End Property

    Public Property Investigadores() As List(Of Investigador)
        Get
            Return _Investigadores
        End Get
        Set(val As List(Of Investigador))
            _Investigadores = val
        End Set
    End Property
End Class
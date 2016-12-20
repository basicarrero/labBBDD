Public Class Conferencia
    Implements IComparable(Of Conferencia)
    Private _id As String = Nothing
    Private _nombre As String = Nothing
    Private _siglas As String = Nothing
    Private _lugar As String = Nothing
    Private _fechaInicio As Date
    Private _fechaFin As Date
    Private _asistentes As List(Of Investigador)
    Private _articulos As List(Of Articulo)

    Public Sub New(ByVal id As String, ByVal nombre As String, ByVal siglas As String, _
                   ByVal lugar As String, ByVal fechaInicio As Date, ByVal fechaFin As Date, _
                   ByRef articulos As List(Of Articulo))
        _id = id
        _nombre = nombre
        _siglas = siglas
        _lugar = lugar
        _fechaInicio = fechaInicio
        _fechaFin = fechaFin
        _articulos = articulos
    End Sub

    Public Overrides Function ToString() As String
        Return _nombre & " (" & _siglas & ")"
    End Function ' ToString

    Public Overloads Function CompareTo(ByVal other As Conferencia) As Integer _
        Implements IComparable(Of Conferencia).CompareTo
        Return other._fechaInicio.CompareTo(Me._fechaInicio)
    End Function

    Public Property ID() As String
        Get
            Return _id
        End Get
        Set(val As String)
            _id = val
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(val As String)
            _nombre = val
        End Set
    End Property

    Public Property Siglas() As String
        Get
            Return _siglas
        End Get
        Set(val As String)
            _siglas = val
        End Set
    End Property

    Public Property Lugar() As String
        Get
            Return _lugar
        End Get
        Set(val As String)
            _lugar = val
        End Set
    End Property

    Public Property fechaInicio As Date
        Get
            Return _fechaInicio
        End Get
        Set(val As Date)
            _fechaInicio = val
        End Set
    End Property

    Public Property fechaFin As Date
        Get
            Return _fechaFin
        End Get
        Set(val As Date)
            _fechaFin = val
        End Set
    End Property

    Public Property Articulos As List(Of Articulo)
        Get
            Return _articulos
        End Get
        Set(val As List(Of Articulo))
            _articulos = val
        End Set
    End Property

    Public Property Asistentes As List(Of Investigador)
        Get
            Return _asistentes
        End Get
        Set(val As List(Of Investigador))
            _asistentes = val
        End Set
    End Property
End Class
Public Class Articulo
    Implements IComparable(Of Articulo)
    Private _id As String
    Private _titulo As String
    Private _pagInicio As UInteger
    Private _pagFin As UInteger
    Private _conferencia As Conferencia
    Private _Autoria As List(Of Investigador)

    Public Sub New(ByVal id As String, ByVal titulo As String, _
                   ByRef pagInicio As UInteger, ByVal pagFin As UInteger, ByRef conferencia As Conferencia)
        _id = id
        _titulo = titulo
        _pagInicio = pagInicio
        _pagFin = pagFin
        _conferencia = conferencia
        _Autoria = New List(Of Investigador)
    End Sub

    Public Overloads Overrides Function Equals(obj As Object) As Boolean
        ' Check for null values and compare run-time types.
        If obj Is Nothing Or Not Me.GetType() Is obj.GetType() Then
            Return False
        End If
        Dim other As Articulo = CType(obj, Articulo)
        Return Me.ID.Equals(other.ID)
    End Function

    Public Overloads Function CompareTo(ByVal other As Articulo) As Integer _
        Implements IComparable(Of Articulo).CompareTo
        Return _id.CompareTo(other._id)
    End Function

    Public Overrides Function ToString() As String
        Return _titulo
    End Function ' ToString

    Public Property ID() As String
        Get
            Return _id
        End Get
        Set(val As String)
            _id = val
        End Set
    End Property

    Public Property Titulo() As String
        Get
            Return _titulo
        End Get
        Set(val As String)
            _titulo = val
        End Set
    End Property

    Public Property PagInicio() As Integer
        Get
            Return _pagInicio
        End Get
        Set(val As Integer)
            _pagInicio = val
        End Set
    End Property

    Public Property PagFin() As Integer
        Get
            Return _pagFin
        End Get
        Set(val As Integer)
            _pagFin = val
        End Set
    End Property

    Public Property Conferencia() As Conferencia
        Get
            Return _conferencia
        End Get
        Set(val As Conferencia)
            _conferencia = val
        End Set
    End Property

    Public Property Autoria As List(Of Investigador)
        Get
            Return _Autoria
        End Get
        Set(val As List(Of Investigador))
            _Autoria = val
        End Set
    End Property
End Class
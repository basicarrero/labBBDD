Public Class Investigador
    Implements IComparable(Of Investigador)
    Implements ICloneable
    Private _Id As String
    Private _Nombre As String
    Private _Apellidos As String
    Private _Edificio As String
    Private _Mail As String
    Private _Telf As ULong
    Private _Despacho As Integer
    Private _Departamento As Departamento

    Public Sub New(ByVal ID As String, ByVal nombre As String, ByVal apellidos As String, _
                   ByVal edificio As String, ByVal mail As String, ByVal telf As ULong, ByVal despacho As Integer, _
                   ByRef departamento As Departamento)
        _Id = ID
        _Nombre = nombre
        _Apellidos = apellidos
        _Edificio = edificio
        _Mail = mail
        _Telf = telf
        _Despacho = despacho
        _Departamento = departamento
    End Sub

    Public Function Clone() As Object Implements ICloneable.Clone
        Return DirectCast(MemberwiseClone(), Object)
    End Function

    Public Overrides Function ToString() As String
        Return _Apellidos & " - " & _Nombre
    End Function ' ToString

    ' Public Overloads Overrides Function Equals(obj As Object) As Boolean
    'Check for null values and compare run-time types.
    '      If obj Is Nothing Or Not Me.GetType() Is obj.GetType() Then
    'Return False
    'End If
    'Dim other As Investigador = CType(obj, Investigador)
    'Return Me.ID.Equals(other.ID)
    'End Function

    Public Overloads Function CompareTo(ByVal other As Investigador) As Integer _
    Implements IComparable(Of Investigador).CompareTo
        Dim comp As Integer
        comp = _Departamento.ID.CompareTo(other.Departamento.ID)
        If comp = 0 Then
            comp = ToString.CompareTo(other.ToString)
        End If
        Return comp
    End Function

    Public Function GetAsistencia(ByRef conferencias As List(Of Conferencia)) As List(Of Conferencia)
        Dim asistencia As List(Of Conferencia) = New List(Of Conferencia)
        If conferencias IsNot Nothing Then
            For Each conf In conferencias
                If conf.Asistentes.Contains(Me) Then
                    asistencia.Add(conf)
                End If
            Next
        End If
        Return asistencia
    End Function

    Public Function GetArticulos(ByRef conferencias As List(Of Conferencia)) As List(Of Articulo)
        Dim articulos As List(Of Articulo) = New List(Of Articulo)
        If conferencias IsNot Nothing Then
            For Each conf In conferencias
                For Each art In conf.Articulos
                    For Each aut In art.Autoria
                        If aut.Equals(Me) Then
                            articulos.Add(art)
                            Exit For
                        End If
                    Next
                Next
            Next
        End If
        Return articulos
    End Function

    Public Property ID() As String
        Get
            Return _Id
        End Get
        Set(val As String)
            _Id = val
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

    Public Property Apellidos() As String
        Get
            Return _Apellidos
        End Get
        Set(val As String)
            _Apellidos = val
        End Set
    End Property

    Public Property Edificio() As String
        Get
            Return _Edificio
        End Get
        Set(val As String)
            _Edificio = val
        End Set
    End Property

    Public Property Email() As String
        Get
            Return _Mail
        End Get
        Set(val As String)
            _Mail = val
        End Set
    End Property

    Public Property Telefono() As ULong
        Get
            Return _Telf
        End Get
        Set(val As ULong)
            _Telf = val
        End Set
    End Property

    Public Property Despacho() As Integer
        Get
            Return _Despacho
        End Get
        Set(val As Integer)
            _Despacho = val
        End Set
    End Property

    Public Property Departamento() As Departamento
        Get
            Return _Departamento
        End Get
        Set(val As Departamento)
            _Departamento = val
        End Set
    End Property
End Class
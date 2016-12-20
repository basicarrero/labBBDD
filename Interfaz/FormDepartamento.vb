Public Class formDepartamento
    Private incoming As Departamento = Nothing
    Private outcoming As Departamento
    Private valid As Boolean

    Private Sub depForm_Load() Handles Me.Load
        Me.AcceptButton = btnOK
        Me.CancelButton = btnCancel
        If incoming IsNot Nothing Then
            lblTitulo.Text = "Modificar Departamento:"
            Me.Icon = My.Resources.formedit
            txtBoxID.Text = incoming.ID
            txtBoxID.Enabled = False
            txtBoxNombre.Text = incoming.Nombre
        Else
            lblTitulo.Text = "Nuevo Departamento:"
            Me.Icon = My.Resources.formnew
        End If
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If Not formMain.chkEmpty(lyPan1) Then
            outcoming = New Departamento(txtBoxID.Text.ToUpperInvariant, txtBoxNombre.Text, Nothing)
            If incoming IsNot Nothing Then outcoming.Investigadores = incoming.Investigadores
            valid = True
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        outcoming = Nothing
        valid = False
    End Sub

    Public Property Entrada() As Departamento
        Get
            Return incoming
        End Get
        Set(val As Departamento)
            incoming = val
        End Set
    End Property

    Public ReadOnly Property Salida() As Departamento
        Get
            Return outcoming
        End Get
    End Property

    Public ReadOnly Property ValidData() As Boolean
        Get
            Return valid
        End Get
    End Property
End Class
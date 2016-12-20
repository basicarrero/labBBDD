Public Class formInvestigador
    Private incoming As Investigador = Nothing
    Private defaultDep As Departamento = Nothing
    Private outcoming As Investigador
    Private valid As Boolean

    Private Sub depForm_Load() Handles Me.Load
        'Sets cmdOK as the button control that is clicked when the user presses the Enter key.
        Me.AcceptButton = btnOK
        'Sets cmdCancel as the button control that is clicked when the user presses the ESC key.
        Me.CancelButton = btnCancel
        If incoming IsNot Nothing Then
            lblTitulo.Text = "Modificar Investigador:"
            Me.Icon = My.Resources.formedit
            txtBoxID.Text = incoming.ID
            txtBoxID.Enabled = False
            defaultDep = incoming.Departamento
            txtBoxNombre.Text = incoming.Nombre
            txtBoxApellidos.Text = incoming.Apellidos
            txtBoxEdificio.Text = incoming.Edificio
            txtBoxEmail.Text = incoming.Email
            txtBoxTelefono.Text = incoming.Telefono
            txtBoxDespacho.Text = incoming.Despacho
        Else
            lblTitulo.Text = "Nuevo Investigador:"
            Me.Icon = My.Resources.formnew
        End If
        cmBoxDep.DataSource = formMain.departamentos
        cmBoxDep.SelectedItem = defaultDep
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If Not FormMain.chkEmpty(lyPan1) And cmBoxDep.SelectedItem IsNot Nothing Then
            outcoming = New Investigador(txtBoxID.Text.ToUpperInvariant, txtBoxNombre.Text, txtBoxApellidos.Text, _
                                         txtBoxEdificio.Text, txtBoxEmail.Text, ULong.Parse(txtBoxTelefono.Text), _
                                         Integer.Parse(txtBoxDespacho.Text), cmBoxDep.SelectedItem)
            valid = True
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        outcoming = Nothing
        valid = False
    End Sub

    Public Property defaultDepOption() As Departamento
        Get
            Return defaultDep
        End Get
        Set(val As Departamento)
            defaultDep = val
        End Set
    End Property

    Public Property Entrada() As Investigador
        Get
            Return incoming
        End Get
        Set(val As Investigador)
            incoming = val
        End Set
    End Property

    Public ReadOnly Property Salida() As Investigador
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
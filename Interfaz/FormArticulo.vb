Public Class formArticulo
    Private incoming As Articulo = Nothing
    Private outcoming As Articulo
    Private valid As Boolean

    Private Sub depForm_Load() Handles Me.Load
        Me.AcceptButton = btnOK
        Me.CancelButton = btnCancel
        txtBoxArticuloTitulo.Select()
        If incoming IsNot Nothing Then
            lblTitulo.Text = "Modificar Articulo:"
            Me.Icon = My.Resources.formedit
            txtBoxID.Text = incoming.ID
            txtBoxID.Enabled = False
            txtBoxArticuloTitulo.Text = incoming.Titulo
            txtBoxPagInicio.Text = incoming.PagInicio.ToString
            txtBoxPagFin.Text = incoming.PagFin.ToString
            cmBoxConferencia.DataSource = formMain.conferencias
            cmBoxConferencia.SelectedItem = incoming.Conferencia
            For Each aut In incoming.Autoria
                lstBoxAutores.Items.Add(aut)
            Next
            For Each dep In formMain.departamentos
                For Each inv In dep.Investigadores
                    If Not incoming.Autoria.Contains(inv) Then
                        cmBoxNewAut.Items.Add(inv)
                    End If
                Next
            Next
        Else
            lblTitulo.Text = "Nuevo Articulo:"
            Me.Icon = My.Resources.formnew
            For Each dep In formMain.departamentos
                For Each inv In dep.Investigadores
                    cmBoxNewAut.Items.Add(inv)
                Next
            Next
        End If
        NumUDOrderNewAut.Maximum = lstBoxAutores.Items.Count + 1
        If cmBoxNewAut.Items.Count > 0 Then cmBoxNewAut.SelectedItem = cmBoxNewAut.Items(0)
        cmBoxConferencia.DataSource = formMain.conferencias
    End Sub

    Private Sub btnDelAut_Click(sender As System.Object, e As System.EventArgs) Handles btnDelAut.Click
        Dim aut As Investigador = lstBoxAutores.SelectedItem
        cmBoxNewAut.Items.Add(aut)
        cmBoxNewAut.SelectedItem = aut
        Dim idx As Integer = lstBoxAutores.Items.IndexOf(lstBoxAutores.SelectedItem)
        lstBoxAutores.Items.RemoveAt(idx)
        NumUDOrderNewAut.Maximum = lstBoxAutores.Items.Count + 1
        If idx > lstBoxAutores.Items.Count - 1 Then idx = idx - 1
        If idx >= 0 Then
            lstBoxAutores.SelectedItem = lstBoxAutores.Items.Item(idx)
            lstBoxAutores.Select()
        Else
            cmBoxNewAut.Select()
        End If
    End Sub

    Private Sub btnAddAut_Click(sender As System.Object, e As System.EventArgs) Handles btnAddAut.Click
        If cmBoxNewAut.SelectedItem IsNot Nothing Then
            lstBoxAutores.Items.Insert(NumUDOrderNewAut.Value - 1, cmBoxNewAut.SelectedItem)
            If cmBoxNewAut.Items.Count <= 1 Then
                cmBoxNewAut.Items.Clear()
                cmBoxNewAut.Text = ""
            Else
                Dim idx As Integer = cmBoxNewAut.SelectedIndex
                cmBoxNewAut.Items.Remove(cmBoxNewAut.SelectedItem)
                If idx > cmBoxNewAut.Items.Count - 1 Then idx = idx - 1
                cmBoxNewAut.SelectedItem = cmBoxNewAut.Items(idx)
                cmBoxNewAut.Select()
                NumUDOrderNewAut.Maximum = lstBoxAutores.Items.Count + 1
            End If
        End If
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If Not formMain.chkEmpty(lyPan1) Then
            outcoming = New Articulo(txtBoxID.Text, txtBoxArticuloTitulo.Text, UInteger.Parse(txtBoxPagInicio.Text), _
                         UInteger.Parse(txtBoxPagFin.Text), cmBoxConferencia.SelectedItem)
            For Each aut In lstBoxAutores.Items
                outcoming.Autoria.Add(aut)
            Next
            valid = True
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        outcoming = Nothing
        valid = False
    End Sub

    Private Sub lstBoxAutores_SelectedValueChanged(sender As System.Object, e As System.EventArgs) _
    Handles lstBoxAutores.SelectedValueChanged
        Static Dim lastLstSelected As Object = Nothing
        If lstBoxAutores.SelectedItem IsNot Nothing Then
            If lstBoxAutores.SelectedItem.Equals(lastLstSelected) Then
                lstBoxAutores.SelectedItem = Nothing
                btnDelAut.Enabled = False
            Else
                btnDelAut.Enabled = True
            End If
        Else
            btnDelAut.Enabled = False
        End If
        lastLstSelected = lstBoxAutores.SelectedItem
    End Sub

    Private Sub nums_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) _
        Handles txtBoxPagInicio.KeyPress, txtBoxPagFin.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then e.Handled = False Else e.Handled = True
    End Sub

    Public Property Entrada() As Articulo
        Set(val As Articulo)
            incoming = val
        End Set
        Get
            Return incoming
        End Get
    End Property

    Public ReadOnly Property Salida() As Articulo
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
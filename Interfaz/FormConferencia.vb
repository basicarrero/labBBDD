Public Class formConferencia
    Private incoming As Conferencia = Nothing
    Private outcoming As Conferencia
    Private valid As Boolean

    Private Sub depForm_Load() Handles Me.Load
        Me.AcceptButton = btnOK
        Me.CancelButton = btnCancel
        timePickerFechaInicio.Format = DateTimePickerFormat.Custom
        timePickerFechaFin.Format = DateTimePickerFormat.Custom
        timePickerFechaInicio.CustomFormat = "dd'/'MMM'/'yyyy'      'hh':'mm tt"
        timePickerFechaFin.CustomFormat = "dd'/'MMM'/'yyyy'      'hh':'mm tt"
        chkLstBoxArticulos.DataSource = getallArticulos()
        chkLstBoxAsistentes.DataSource = getallInvest()
        If incoming IsNot Nothing Then
            lblTitulo.Text = "Modificar Conferencia:"
            Me.Icon = My.Resources.formedit
            txtBoxID.Text = incoming.ID
            txtBoxID.Enabled = False
            txtBoxNombre.Text = incoming.Nombre
            txtBoxSiglas.Text = incoming.Siglas
            txtBoxLugar.Text = incoming.Lugar
            timePickerFechaInicio.Value = incoming.fechaInicio
            timePickerFechaFin.Value = incoming.fechaFin
            For Each asistente In incoming.Asistentes
                chkLstBoxAsistentes.SetItemChecked(chkLstBoxAsistentes.Items.IndexOf(asistente), True)
            Next
            For Each articulo In incoming.Articulos
                chkLstBoxArticulos.SetItemChecked(chkLstBoxArticulos.Items.IndexOf(articulo), True)
            Next
        Else
            lblTitulo.Text = "Nueva Conferencia:"
            Me.Icon = My.Resources.formnew
            timePickerFechaInicio.Value = Now
            timePickerFechaFin.Value = DateAdd(DateInterval.Hour, 1, timePickerFechaInicio.Value)
        End If
    End Sub

    Private Sub chkLstBoxArticulos_ItemCheck(sender As System.Object, e As ItemCheckEventArgs) Handles chkLstBoxArticulos.ItemCheck
        Static Dim notificado As Boolean = False
        If incoming IsNot Nothing And notificado = False And e.CurrentValue = CheckState.Checked And e.NewValue = CheckState.Unchecked Then
            If incoming.Articulos.Contains(chkLstBoxArticulos.Items(e.Index)) Then
                Dim reply As DialogResult = MessageBox.Show _
                    ("La bbdd no admite campos nulos, esto significa que cada artículo debe pertenecer a una sola Conferencia." & _
                     ControlChars.NewLine & ControlChars.NewLine & "Los Artículos desmarcados se eliminarán del sistema, para evitarlo, " & _
                     "edite primero dicho artículo en la pestaña correspondiente.", "Confirmar Eliminación", _
                     MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                notificado = True
                If reply = DialogResult.Cancel Then chkLstBoxArticulos.SetItemChecked(chkLstBoxArticulos.Items(e.Index), True)
            End If
        End If
    End Sub

    Private Function getallArticulos() As List(Of Articulo)
        Dim lst As List(Of Articulo) = New List(Of Articulo)
        For Each conf In formMain.conferencias
            For Each art In conf.Articulos
                lst.Add(art)
            Next
        Next
        Return lst
    End Function

    Private Function getallInvest() As List(Of Investigador)
        Dim lst As List(Of Investigador) = New List(Of Investigador)
        For Each dep In formMain.departamentos
            For Each inv In dep.Investigadores
                lst.Add(inv)
            Next
        Next
        Return lst
    End Function

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If Not formMain.chkEmpty(lyPan1) Then
            If timePickerFechaFin.Value > timePickerFechaInicio.Value Then
                outcoming = New Conferencia(txtBoxID.Text, txtBoxNombre.Text, txtBoxSiglas.Text, txtBoxLugar.Text, _
                                timePickerFechaInicio.Value, timePickerFechaFin.Value, Nothing)
                outcoming.Articulos = New List(Of Articulo)
                outcoming.Asistentes = New List(Of Investigador)
                For Each item As Articulo In chkLstBoxArticulos.CheckedItems
                    outcoming.Articulos.Add(item)
                Next
                For Each item As Investigador In chkLstBoxAsistentes.CheckedItems
                    outcoming.Asistentes.Add(item)
                Next
                valid = True
                Me.Close()
            Else
                Dim reply As DialogResult = MessageBox.Show("La Fecha de finalización debe ser posterior a la de inicio!", _
                    "Advertencia", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                If reply = DialogResult.Cancel Then btnCancel_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        outcoming = Nothing
        valid = False
    End Sub

    Public Property Entrada() As Conferencia
        Set(val As Conferencia)
            incoming = val
        End Set
        Get
            Return incoming
        End Get
    End Property

    Public ReadOnly Property Salida() As Conferencia
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
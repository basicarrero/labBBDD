Public Class FormMain
#If DEBUG Then
    Private DATAPATH As String = "C:\Users\Basi\Desktop"
#Else
    Private DATAPATH As String = Application.StartupPath
#End If

    Private Const ddbbpFile As String = "LabBBDD.accdb"
    Public departamentos As List(Of Departamento) = New List(Of Departamento)
    Public conferencias As List(Of Conferencia) = New List(Of Conferencia)

    'On load
    Private Sub Presentacion_Load() Handles Me.Load
        Application.EnableVisualStyles()
        calendarConferencias.MaxSelectionCount = 31
        Try
            AgenteBD.getInstancia.conectar("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & DATAPATH & "\" & ddbbpFile)
            gestorBBDD.readData(departamentos, conferencias)
            For Each dep In departamentos
                lstBoxDep.Items.Add(dep)
                For Each inv In dep.Investigadores
                    lstBoxInvest.Items.Add(inv)
                Next
            Next
            For Each conf In conferencias
                lstBoxConfs.Items.Add(conf)
                For Each art In conf.Articulos
                    lstBoxArts.Items.Add(art)
                Next
            Next
            If lstBoxInvest.Items.Count > 0 Then lstBoxInvest.SelectedIndex = 0
            If lstBoxArts.Items.Count > 0 Then lstBoxArts.SelectedIndex = 0
            If lstBoxDep.Items.Count > 0 Then lstBoxDep.SelectedIndex = 0
            If lstBoxConfs.Items.Count > 0 Then lstBoxConfs.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("Error Desconocido:" & ControlChars.CrLf & ex.Message & ControlChars.CrLf & ex.Source)
        End Try
    End Sub

    'Visualizadores
    Private Sub showDep(sender As System.Object, e As System.EventArgs) Handles lstBoxDep.SelectedIndexChanged
        Dim dep As Departamento = DirectCast(sender, System.Windows.Forms.ListBox).SelectedItem
        lblDepNombreTag.Text = dep.ID & ": " & dep.Nombre
        lstBoxDepMiembros.DataSource = dep.Investigadores
    End Sub

    Private Sub showInvest(sender As System.Object, e As System.EventArgs) Handles lstBoxInvest.SelectedIndexChanged
        Dim invest As Investigador = DirectCast(sender, System.Windows.Forms.ListBox).SelectedItem
        If invest IsNot Nothing Then
            lblInvestNombreTag.Text = invest.ToString
            lblInvestIDTag.Text = invest.ID
            lblInvestDepTag.Text = invest.Departamento.Nombre
            lblInvestDespachoTag.Text = invest.Despacho
            lblInvestEdificioTag.Text = invest.Edificio
            lblInvestTelfTag.Text = invest.Telefono
            lblInvestMailTag.Text = invest.Email
            lstBoxInvestAsistencia.DataSource = invest.GetAsistencia(conferencias)
        End If
    End Sub

    Private Sub lstBoxConfs_Painter(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles lstBoxConfs.DrawItem
        Try
            Dim conf As Conferencia = lstBoxConfs.Items(e.Index)
            Dim pincel As Brush = Brushes.Black
            If conf.fechaFin < Today Then
                pincel = Brushes.DarkSlateGray
            ElseIf conf.fechaInicio > Today Then
                pincel = Brushes.Blue
            Else
                pincel = Brushes.Red
            End If
            e.DrawBackground()
            e.Graphics.DrawString(conf.ToString, e.Font, pincel, e.Bounds)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub showConf(sender As System.Object, e As System.EventArgs) Handles lstBoxConfs.SelectedIndexChanged
        Dim conf As Conferencia = DirectCast(sender, System.Windows.Forms.ListBox).SelectedItem
        If conf IsNot Nothing Then
            lblConfNombreTag.Text = conf.Nombre
            lblConfLugarTag.Text = conf.Lugar
            lblConfFechaInicioTag.Text = conf.fechaInicio.ToShortDateString
            lblConfFechaFinTag.Text = conf.fechaFin.ToShortDateString
            lstBoxConfAsistencia.DataSource = conf.Asistentes
            calendarConferencias.SetSelectionRange(conf.fechaInicio, conf.fechaFin)
        End If
    End Sub

    Private Sub showArt(sender As System.Object, e As System.EventArgs) Handles lstBoxArts.SelectedIndexChanged
        Dim art As Articulo = DirectCast(sender, System.Windows.Forms.ListBox).SelectedItem
        If art IsNot Nothing Then
            lblArtTituloTag.Text = art.Titulo
            lblArtIDTag.Text = art.ID
            lblArtPagsTag.Text = art.PagInicio & "-" & art.PagFin
            lblArtConfTag.Text = art.Conferencia.Nombre
            lstBoxAutores.DataSource = art.Autoria
        End If
    End Sub

    'Eventos de Botones
    Private Sub btnInvestGetCurriculum_Click(sender As System.Object, e As System.EventArgs) Handles btnInvestGetCurriculum.Click
        If lstBoxInvest.SelectedItem IsNot Nothing Then
            Dim formCurriculum As New formCurriculum
            formCurriculum.Investigador = lstBoxInvest.SelectedItem
            formCurriculum.ShowDialog()
        End If
    End Sub

    Private Sub newDep_Click(sender As System.Object, e As System.EventArgs) Handles btnDepAdd.Click
        Try
            Dim Dep As New formDepartamento
            Dep.ShowDialog()
            If Dep.ValidData Then
                GestorDepartamentos.insDep(Dep.Salida)
                departamentos.Add(Dep.Salida)
                lstBoxDep.DataSource = departamentos
                lstBoxDep.SelectedItem = Dep.Salida
            End If
        Catch ex As Exception
            MessageBox.Show("Error al Crear Departamento" & ControlChars.CrLf & ex.Message & ControlChars.CrLf & ex.Source)
        End Try
    End Sub

    Private Sub newInvest_Click(sender As System.Object, e As System.EventArgs) Handles btnInvestAdd.Click
        Try
            Dim Invest As New formInvestigador
            Invest.ShowDialog()
            If Invest.ValidData Then
                GestorInvestigadores.insInvest(Invest.Salida)
                Invest.Salida.Departamento.Investigadores.Add(Invest.Salida)
                lstBoxInvest.Items.Add(Invest.Salida)
                lstBoxInvest.SelectedItem = Invest.Salida
            End If
        Catch ex As Exception
            MessageBox.Show("Error al Crear Investigador" & ControlChars.CrLf & ex.Message & ControlChars.CrLf & ex.Source)
        End Try
    End Sub

    Private Sub newConf_Click(sender As System.Object, e As System.EventArgs) Handles btnConfAdd.Click
        Try
            Dim Conf As New formConferencia
            Conf.ShowDialog()
            If Conf.ValidData Then
                GestorConferencias.insConf(Conf.Salida)
                updateArtRefs(Conf.Salida)
                conferencias.Add(Conf.Salida)
                lstBoxConfs.DataSource = conferencias
                lstBoxConfs.SelectedItem = Conf.Salida
            End If
        Catch ex As Exception
            MessageBox.Show("Error al Crear Conferencia" & ControlChars.CrLf & ex.Message & ControlChars.CrLf & ex.Source)
        End Try
    End Sub

    Private Sub newArt_Click(sender As System.Object, e As System.EventArgs) Handles btnArtAdd.Click
        Try
            Dim Art As New formArticulo
            Art.ShowDialog()
            If Art.ValidData Then
                GestorArticulo.insArt(Art.Salida)
                Art.Salida.Conferencia.Articulos.Add(Art.Salida)
                lstBoxConfs.DataSource = conferencias
                lstBoxArts.SelectedItem = Art.Salida
            End If
        Catch ex As Exception
            MessageBox.Show("Error al Crear Artículo" & ControlChars.CrLf & ex.Message & ControlChars.CrLf & ex.Source)
        End Try
    End Sub

    Public Sub editDep_Click(sender As System.Object, e As System.EventArgs) Handles btnDepEdit.Click
        Try
            Dim formDep As New formDepartamento
            formDep.Entrada = lstBoxDep.SelectedItem
            formDep.ShowDialog()
            If formDep.ValidData Then
                GestorDepartamentos.modDep(formDep.Salida)
                Dim idx As Integer = departamentos.IndexOf(formDep.Entrada)
                departamentos.Item(idx) = formDep.Salida
                lstBoxDep.DataSource = departamentos
                lstBoxDep.SelectedItem = formDep.Salida
            End If
        Catch ex As Exception
            MessageBox.Show("Error al editar Departamento" & ControlChars.CrLf & ex.Message & ControlChars.CrLf & ex.Source)
        End Try
    End Sub

    Public Sub editInvest_Click(sender As System.Object, e As System.EventArgs) Handles btnInvestEdit.Click
        Try
            Dim formInvest As New formInvestigador
            formInvest.Entrada = lstBoxInvest.SelectedItem
            formInvest.ShowDialog()
            If formInvest.ValidData Then
                GestorInvestigadores.modInvest(formInvest.Salida)
                For Each conf As Conferencia In formInvest.Entrada.GetAsistencia(conferencias)
                    conf.Asistentes(conf.Asistentes.IndexOf(formInvest.Entrada)) = formInvest.Salida
                Next
                Dim dep As Departamento = formInvest.Entrada.Departamento
                Dim newDep As Departamento = formInvest.Salida.Departamento
                dep.Investigadores.Remove(formInvest.Entrada)
                lstBoxInvest.Items.Remove(formInvest.Entrada)
                If dep.ID.Equals(newDep.ID) Then
                    dep.Investigadores.Add(formInvest.Salida)
                Else
                    newDep.Investigadores.Add(formInvest.Salida)
                End If
                lstBoxInvest.Items.Add(formInvest.Salida)
                lstBoxInvest.SelectedItem = formInvest.Salida
            End If
        Catch ex As Exception
            MessageBox.Show("Error al editar Investigador" & ControlChars.CrLf & ex.Message & ControlChars.CrLf & ex.Source)
        End Try
    End Sub

    Private Sub editConf_Click(sender As System.Object, e As System.EventArgs) Handles btnConfEdit.Click
        Try
            Dim formConf As New formConferencia
            Dim selectedConf As Conferencia = lstBoxConfs.SelectedItem
            formConf.Entrada = selectedConf
            formConf.ShowDialog()
            If formConf.ValidData Then
                GestorConferencias.modConf(formConf.Salida)
                Dim idx As Integer
                For Each art As Articulo In formConf.Salida.Articulos
                    If Not selectedConf.Articulos.Contains(art) Then
                        idx = conferencias.IndexOf(art.Conferencia)
                        conferencias.Item(idx).Articulos.Remove(art)
                    End If
                Next
                updateArtRefs(formConf.Salida)
                idx = conferencias.IndexOf(selectedConf)
                conferencias.Item(idx) = formConf.Salida
                lstBoxConfs.DataSource = conferencias
                lstBoxConfs.SelectedItem = formConf.Salida
                showConf(lstBoxConfs, New System.EventArgs)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al editar Conferencia" & ControlChars.CrLf & ex.Message & ControlChars.CrLf & ex.Source)
        End Try
    End Sub

    Public Sub editArt_Click(sender As System.Object, e As System.EventArgs) Handles btnArtEdit.Click
        Try
            Dim formArt As New formArticulo
            formArt.Entrada = lstBoxArts.SelectedItem
            formArt.ShowDialog()
            If formArt.ValidData Then
                GestorArticulo.modArt(formArt.Salida)
                Dim conf As Conferencia = formArt.Entrada.Conferencia
                Dim newConf As Conferencia = formArt.Salida.Conferencia
                conf.Articulos.Remove(formArt.Entrada)
                lstBoxArts.Items.Remove(formArt.Entrada)
                If conf.Equals(newConf) Then
                    conf.Articulos.Add(formArt.Salida)
                Else
                    newConf.Articulos.Add(formArt.Salida)
                End If
                lstBoxArts.Items.Add(formArt.Salida)
                lstBoxArts.SelectedItem = formArt.Salida
            End If
        Catch ex As Exception
            MessageBox.Show("Error al editar Artículo" & ControlChars.CrLf & ex.Message & ControlChars.CrLf & ex.Source)
        End Try
    End Sub

    Private Sub delDep_Click(sender As System.Object, e As System.EventArgs) Handles btnDepDel.Click
        Try
            Dim dep As Departamento = lstBoxDep.SelectedItem
            Dim reply As DialogResult = MessageBox.Show _
                   ("¿Está seguro de que desea eliminar el Departamento """ & dep.Nombre & _
                    """? Si continua se eliminarán también los investigadores asociados al departamento", _
                    "Confirmar Eliminación", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If reply = DialogResult.Yes Then
                GestorDepartamentos.delDep(dep)
                delDep(dep)
                lstBoxDep.Items.Clear()
                lstBoxInvest.Items.Clear()
                For Each dep In departamentos
                    lstBoxDep.Items.Add(dep)
                    For Each inv In dep.Investigadores
                        lstBoxInvest.Items.Add(inv)
                    Next
                Next
                If lstBoxDep.Items.Count > 0 Then lstBoxDep.SelectedItem = lstBoxDep.Items.Item(0)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al Eliminar Departamento" & ControlChars.CrLf & ex.Message & ControlChars.CrLf & ex.Source)
        End Try
    End Sub

    Public Sub delDep(ByRef dep As Departamento)
        Dim invLst As List(Of Investigador) = New List(Of Investigador)
        If dep.Investigadores IsNot Nothing Then
            For Each inv In dep.Investigadores
                invLst.Add(inv)
            Next
            For Each inv In invLst
                delInvest(inv)
            Next
        End If
        departamentos.Remove(dep)
    End Sub

    Private Sub delInvest_Click(sender As System.Object, e As System.EventArgs) Handles btnInvestDel.Click
        Try
            Dim inv As Investigador = lstBoxInvest.SelectedItem
            Dim reply As DialogResult = MessageBox.Show _
                   ("¿Está seguro de que desea eliminar el Investigador """ & inv.Nombre & """?", _
                    "Confirmar Eliminación", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If reply = DialogResult.Yes Then
                GestorInvestigadores.delInvest(inv)
                delInvest(inv)
                lstBoxInvest.Items.Remove(inv)
                If lstBoxInvest.Items.Count > 0 Then lstBoxInvest.SelectedItem = lstBoxInvest.Items.Item(0)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al Eliminar Investigador" & ControlChars.CrLf & ex.Message & ControlChars.CrLf & ex.Source)
        End Try
    End Sub

    Public Sub delInvest(ByRef inv As Investigador)
        For Each conf In conferencias
            If conf.Asistentes.Contains(inv) Then conf.Asistentes.Remove(inv)
            For Each art In conf.Articulos
                For Each aut In art.Autoria
                    If aut.Equals(inv) Then
                        art.Autoria.Remove(aut)
                        Exit For
                    End If
                Next
            Next
        Next
        inv.Departamento.Investigadores.Remove(inv)
    End Sub

    Private Sub delConf_Click(sender As System.Object, e As System.EventArgs) Handles btnConfDel.Click
        Try
            If lstBoxConfs.SelectedItem IsNot Nothing Then
                Dim selectedConf As Conferencia = lstBoxConfs.SelectedItem
                Dim reply As DialogResult = MessageBox.Show _
                        ("¿Está seguro de que desea eliminar la Conferencia:" & ControlChars.NewLine & """" & _
                         selectedConf.Nombre & """?" & ControlChars.NewLine & ControlChars.NewLine & ControlChars.NewLine & _
                         "El diseño de la BBDD no permite Campos nulos, por tanto se eliminarán" & _
                         " también los artículos asociados a esta conferencia.", "Confirmar Eliminación", _
                         MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                If reply = DialogResult.Yes Then
                    GestorConferencias.delConf(selectedConf)
                    conferencias.Remove(selectedConf)
                    lstBoxConfs.Items.Clear()
                    lstBoxArts.Items.Clear()
                    For Each conf In conferencias
                        lstBoxConfs.Items.Add(conf)
                        For Each art In conf.Articulos
                            lstBoxArts.Items.Add(art)
                        Next
                    Next
                    If lstBoxConfs.Items.Count > 0 Then lstBoxConfs.SelectedItem = lstBoxConfs.Items.Item(0)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error al Eliminar Conferencia" & ControlChars.CrLf & ex.Message & ControlChars.CrLf & ex.Source)
        End Try
    End Sub

    Private Sub delArt_Click(sender As System.Object, e As System.EventArgs) Handles btnArtDel.Click
        Try
            Dim art As Articulo = lstBoxArts.SelectedItem
            Dim reply As DialogResult = MessageBox.Show _
                    ("¿Está seguro de que desea eliminar el Artículo? """ & art.Titulo & """?", _
                    "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If reply = DialogResult.Yes Then
                GestorArticulo.delArt(art)
                For Each conf In conferencias
                    If conf.Articulos.Contains(art) Then conf.Articulos.Remove(art)
                Next
                lstBoxArts.Items.Remove(art)
                If lstBoxArts.Items.Count > 0 Then lstBoxArts.SelectedItem = lstBoxArts.Items.Item(0)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al Eliminar Artículo" & ControlChars.CrLf & ex.Message & ControlChars.CrLf & ex.Source)
        End Try
    End Sub

    'Utilería
    Private Sub updateArtRefs(ByRef conf As Conferencia)
        For Each art In conf.Articulos
            art.Conferencia = conf
        Next
    End Sub

    Public Function chkEmpty(ByRef table As TableLayoutPanel) As Boolean
        For Each ctrl As Control In table.Controls
            If TypeOf ctrl Is TextBox Then
                Dim txt As TextBox = ctrl
                If String.IsNullOrEmpty(txt.Text) Then
                    MessageBox.Show("La B.B.D.D. no admite campos nulos, rellene todos los campos!", "Advertencia", _
                                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Return True
                End If
            End If
        Next
        Return False
    End Function
End Class
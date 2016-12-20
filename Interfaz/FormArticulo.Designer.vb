<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formArticulo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formArticulo))
        Me.lyPan1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblConderencia = New System.Windows.Forms.Label()
        Me.cmBoxConferencia = New System.Windows.Forms.ComboBox()
        Me.lblPagFin = New System.Windows.Forms.Label()
        Me.txtBoxPagFin = New System.Windows.Forms.TextBox()
        Me.lblPagInicio = New System.Windows.Forms.Label()
        Me.txtBoxPagInicio = New System.Windows.Forms.TextBox()
        Me.txtBoxArticuloTitulo = New System.Windows.Forms.TextBox()
        Me.lblArticuloTitulo = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtBoxID = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.NumUDOrderNewAut = New System.Windows.Forms.NumericUpDown()
        Me.cmBoxNewAut = New System.Windows.Forms.ComboBox()
        Me.grpBoxAutores = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDelAut = New System.Windows.Forms.Button()
        Me.lblAutoresDisponibles = New System.Windows.Forms.Label()
        Me.lblSeleccioneOrden = New System.Windows.Forms.Label()
        Me.btnAddAut = New System.Windows.Forms.Button()
        Me.lstBoxAutores = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lyPan1.SuspendLayout()
        CType(Me.NumUDOrderNewAut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBoxAutores.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lyPan1
        '
        Me.lyPan1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lyPan1.ColumnCount = 2
        Me.lyPan1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.lyPan1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.lyPan1.Controls.Add(Me.lblConderencia, 0, 4)
        Me.lyPan1.Controls.Add(Me.cmBoxConferencia, 1, 4)
        Me.lyPan1.Controls.Add(Me.lblPagFin, 0, 3)
        Me.lyPan1.Controls.Add(Me.txtBoxPagFin, 1, 3)
        Me.lyPan1.Controls.Add(Me.lblPagInicio, 0, 2)
        Me.lyPan1.Controls.Add(Me.txtBoxPagInicio, 1, 2)
        Me.lyPan1.Controls.Add(Me.txtBoxArticuloTitulo, 1, 0)
        Me.lyPan1.Controls.Add(Me.lblArticuloTitulo, 0, 0)
        Me.lyPan1.Controls.Add(Me.lblID, 0, 1)
        Me.lyPan1.Controls.Add(Me.txtBoxID, 1, 1)
        Me.lyPan1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lyPan1.Location = New System.Drawing.Point(17, 37)
        Me.lyPan1.Name = "lyPan1"
        Me.lyPan1.RowCount = 5
        Me.lyPan1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.lyPan1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.lyPan1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.lyPan1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.lyPan1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.lyPan1.Size = New System.Drawing.Size(649, 202)
        Me.lyPan1.TabIndex = 23
        '
        'lblConderencia
        '
        Me.lblConderencia.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblConderencia.AutoSize = True
        Me.lblConderencia.Location = New System.Drawing.Point(3, 173)
        Me.lblConderencia.Name = "lblConderencia"
        Me.lblConderencia.Size = New System.Drawing.Size(76, 15)
        Me.lblConderencia.TabIndex = 50
        Me.lblConderencia.Text = "Conferencia:"
        '
        'cmBoxConferencia
        '
        Me.cmBoxConferencia.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmBoxConferencia.FormattingEnabled = True
        Me.cmBoxConferencia.Location = New System.Drawing.Point(85, 169)
        Me.cmBoxConferencia.Name = "cmBoxConferencia"
        Me.cmBoxConferencia.Size = New System.Drawing.Size(516, 23)
        Me.cmBoxConferencia.TabIndex = 4
        '
        'lblPagFin
        '
        Me.lblPagFin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblPagFin.AutoSize = True
        Me.lblPagFin.Location = New System.Drawing.Point(27, 132)
        Me.lblPagFin.Name = "lblPagFin"
        Me.lblPagFin.Size = New System.Drawing.Size(52, 15)
        Me.lblPagFin.TabIndex = 5
        Me.lblPagFin.Text = "Pag Fin:"
        '
        'txtBoxPagFin
        '
        Me.txtBoxPagFin.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtBoxPagFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxPagFin.Location = New System.Drawing.Point(85, 129)
        Me.txtBoxPagFin.Name = "txtBoxPagFin"
        Me.txtBoxPagFin.Size = New System.Drawing.Size(75, 21)
        Me.txtBoxPagFin.TabIndex = 3
        '
        'lblPagInicio
        '
        Me.lblPagInicio.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblPagInicio.AutoSize = True
        Me.lblPagInicio.Location = New System.Drawing.Point(15, 92)
        Me.lblPagInicio.Name = "lblPagInicio"
        Me.lblPagInicio.Size = New System.Drawing.Size(64, 15)
        Me.lblPagInicio.TabIndex = 50
        Me.lblPagInicio.Text = "Pag Inicio:"
        '
        'txtBoxPagInicio
        '
        Me.txtBoxPagInicio.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtBoxPagInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxPagInicio.Location = New System.Drawing.Point(85, 89)
        Me.txtBoxPagInicio.Name = "txtBoxPagInicio"
        Me.txtBoxPagInicio.Size = New System.Drawing.Size(75, 21)
        Me.txtBoxPagInicio.TabIndex = 2
        '
        'txtBoxArticuloTitulo
        '
        Me.txtBoxArticuloTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtBoxArticuloTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxArticuloTitulo.Location = New System.Drawing.Point(85, 9)
        Me.txtBoxArticuloTitulo.Name = "txtBoxArticuloTitulo"
        Me.txtBoxArticuloTitulo.Size = New System.Drawing.Size(516, 21)
        Me.txtBoxArticuloTitulo.TabIndex = 0
        '
        'lblArticuloTitulo
        '
        Me.lblArticuloTitulo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblArticuloTitulo.AutoSize = True
        Me.lblArticuloTitulo.Location = New System.Drawing.Point(39, 12)
        Me.lblArticuloTitulo.Name = "lblArticuloTitulo"
        Me.lblArticuloTitulo.Size = New System.Drawing.Size(40, 15)
        Me.lblArticuloTitulo.TabIndex = 50
        Me.lblArticuloTitulo.Text = "Título:"
        '
        'lblID
        '
        Me.lblID.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(50, 52)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(29, 15)
        Me.lblID.TabIndex = 50
        Me.lblID.Text = "#ID:"
        '
        'txtBoxID
        '
        Me.txtBoxID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtBoxID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxID.Location = New System.Drawing.Point(85, 49)
        Me.txtBoxID.Name = "txtBoxID"
        Me.txtBoxID.Size = New System.Drawing.Size(75, 21)
        Me.txtBoxID.TabIndex = 1
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(158, 25)
        Me.lblTitulo.TabIndex = 50
        Me.lblTitulo.Text = "Nuevo Artículo:"
        '
        'NumUDOrderNewAut
        '
        Me.NumUDOrderNewAut.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NumUDOrderNewAut.Location = New System.Drawing.Point(437, 10)
        Me.NumUDOrderNewAut.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.NumUDOrderNewAut.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumUDOrderNewAut.Name = "NumUDOrderNewAut"
        Me.NumUDOrderNewAut.Size = New System.Drawing.Size(120, 20)
        Me.NumUDOrderNewAut.TabIndex = 8
        Me.NumUDOrderNewAut.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cmBoxNewAut
        '
        Me.cmBoxNewAut.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmBoxNewAut.FormattingEnabled = True
        Me.cmBoxNewAut.Location = New System.Drawing.Point(112, 9)
        Me.cmBoxNewAut.Name = "cmBoxNewAut"
        Me.cmBoxNewAut.Size = New System.Drawing.Size(218, 21)
        Me.cmBoxNewAut.Sorted = True
        Me.cmBoxNewAut.TabIndex = 7
        '
        'grpBoxAutores
        '
        Me.grpBoxAutores.Controls.Add(Me.TableLayoutPanel1)
        Me.grpBoxAutores.Controls.Add(Me.lstBoxAutores)
        Me.grpBoxAutores.Location = New System.Drawing.Point(12, 245)
        Me.grpBoxAutores.Name = "grpBoxAutores"
        Me.grpBoxAutores.Size = New System.Drawing.Size(654, 192)
        Me.grpBoxAutores.TabIndex = 5
        Me.grpBoxAutores.TabStop = False
        Me.grpBoxAutores.Text = "Añadir Autor"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.btnDelAut, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblAutoresDisponibles, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSeleccioneOrden, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.NumUDOrderNewAut, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmBoxNewAut, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAddAut, 4, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(5, 22)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(643, 40)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'btnDelAut
        '
        Me.btnDelAut.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelAut.AutoSize = True
        Me.btnDelAut.Enabled = False
        Me.btnDelAut.Image = Global.PractLabBBDD.My.Resources.Resources.del
        Me.btnDelAut.Location = New System.Drawing.Point(601, 5)
        Me.btnDelAut.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDelAut.Name = "btnDelAut"
        Me.btnDelAut.Size = New System.Drawing.Size(37, 30)
        Me.btnDelAut.TabIndex = 10
        Me.btnDelAut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelAut.UseVisualStyleBackColor = True
        '
        'lblAutoresDisponibles
        '
        Me.lblAutoresDisponibles.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblAutoresDisponibles.AutoSize = True
        Me.lblAutoresDisponibles.Location = New System.Drawing.Point(3, 13)
        Me.lblAutoresDisponibles.Name = "lblAutoresDisponibles"
        Me.lblAutoresDisponibles.Size = New System.Drawing.Size(103, 13)
        Me.lblAutoresDisponibles.TabIndex = 50
        Me.lblAutoresDisponibles.Text = "Autores Disponibles:"
        Me.lblAutoresDisponibles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSeleccioneOrden
        '
        Me.lblSeleccioneOrden.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblSeleccioneOrden.AutoSize = True
        Me.lblSeleccioneOrden.Location = New System.Drawing.Point(336, 13)
        Me.lblSeleccioneOrden.Name = "lblSeleccioneOrden"
        Me.lblSeleccioneOrden.Size = New System.Drawing.Size(95, 13)
        Me.lblSeleccioneOrden.TabIndex = 50
        Me.lblSeleccioneOrden.Text = "Seleccione Orden:"
        Me.lblSeleccioneOrden.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAddAut
        '
        Me.btnAddAut.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddAut.AutoSize = True
        Me.btnAddAut.Image = Global.PractLabBBDD.My.Resources.Resources.down
        Me.btnAddAut.Location = New System.Drawing.Point(560, 5)
        Me.btnAddAut.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAddAut.Name = "btnAddAut"
        Me.btnAddAut.Size = New System.Drawing.Size(37, 30)
        Me.btnAddAut.TabIndex = 9
        Me.btnAddAut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddAut.UseVisualStyleBackColor = True
        '
        'lstBoxAutores
        '
        Me.lstBoxAutores.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lstBoxAutores.FormattingEnabled = True
        Me.lstBoxAutores.Location = New System.Drawing.Point(3, 68)
        Me.lstBoxAutores.Name = "lstBoxAutores"
        Me.lstBoxAutores.Size = New System.Drawing.Size(648, 121)
        Me.lstBoxAutores.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PractLabBBDD.My.Resources.Resources.article
        Me.PictureBox1.Location = New System.Drawing.Point(672, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(210, 270)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackgroundImage = CType(resources.GetObject("btnCancel.BackgroundImage"), System.Drawing.Image)
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCancel.Location = New System.Drawing.Point(780, 401)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(102, 36)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.BackgroundImage = CType(resources.GetObject("btnOK.BackgroundImage"), System.Drawing.Image)
        Me.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnOK.Location = New System.Drawing.Point(672, 401)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(102, 36)
        Me.btnOK.TabIndex = 12
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'formArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 449)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grpBoxAutores)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lyPan1)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "formArticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Artículo"
        Me.lyPan1.ResumeLayout(False)
        Me.lyPan1.PerformLayout()
        CType(Me.NumUDOrderNewAut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBoxAutores.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lyPan1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblArticuloTitulo As System.Windows.Forms.Label
    Friend WithEvents txtBoxArticuloTitulo As System.Windows.Forms.TextBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents txtBoxPagInicio As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxID As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblPagInicio As System.Windows.Forms.Label
    Friend WithEvents lblPagFin As System.Windows.Forms.Label
    Friend WithEvents txtBoxPagFin As System.Windows.Forms.TextBox
    Friend WithEvents cmBoxConferencia As System.Windows.Forms.ComboBox
    Friend WithEvents lblConderencia As System.Windows.Forms.Label
    Friend WithEvents NumUDOrderNewAut As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmBoxNewAut As System.Windows.Forms.ComboBox
    Friend WithEvents grpBoxAutores As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblAutoresDisponibles As System.Windows.Forms.Label
    Friend WithEvents lblSeleccioneOrden As System.Windows.Forms.Label
    Friend WithEvents lstBoxAutores As System.Windows.Forms.ListBox
    Friend WithEvents btnAddAut As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnDelAut As System.Windows.Forms.Button
End Class
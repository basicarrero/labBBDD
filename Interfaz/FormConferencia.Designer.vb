<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formConferencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formConferencia))
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lyPan1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtBoxID = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtBoxNombre = New System.Windows.Forms.TextBox()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.timePickerFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.timePickerFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.lblLugar = New System.Windows.Forms.Label()
        Me.txtBoxLugar = New System.Windows.Forms.TextBox()
        Me.lblSiglas = New System.Windows.Forms.Label()
        Me.txtBoxSiglas = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.grpBoxAsistentes = New System.Windows.Forms.GroupBox()
        Me.chkLstBoxAsistentes = New System.Windows.Forms.CheckedListBox()
        Me.grpBoxArticulos = New System.Windows.Forms.GroupBox()
        Me.chkLstBoxArticulos = New System.Windows.Forms.CheckedListBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lyPan1.SuspendLayout()
        Me.grpBoxAsistentes.SuspendLayout()
        Me.grpBoxArticulos.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCancel.Image = Global.PractLabBBDD.My.Resources.Resources.bad
        Me.btnCancel.Location = New System.Drawing.Point(641, 442)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(102, 36)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lyPan1
        '
        Me.lyPan1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lyPan1.ColumnCount = 2
        Me.lyPan1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.lyPan1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.lyPan1.Controls.Add(Me.txtBoxID, 1, 0)
        Me.lyPan1.Controls.Add(Me.lblNombre, 0, 1)
        Me.lyPan1.Controls.Add(Me.lblID, 0, 0)
        Me.lyPan1.Controls.Add(Me.txtBoxNombre, 1, 1)
        Me.lyPan1.Controls.Add(Me.lblFechaFin, 0, 5)
        Me.lyPan1.Controls.Add(Me.timePickerFechaFin, 1, 5)
        Me.lyPan1.Controls.Add(Me.timePickerFechaInicio, 1, 4)
        Me.lyPan1.Controls.Add(Me.lblFechaInicio, 0, 4)
        Me.lyPan1.Controls.Add(Me.lblLugar, 0, 3)
        Me.lyPan1.Controls.Add(Me.txtBoxLugar, 1, 3)
        Me.lyPan1.Controls.Add(Me.lblSiglas, 0, 2)
        Me.lyPan1.Controls.Add(Me.txtBoxSiglas, 1, 2)
        Me.lyPan1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lyPan1.Location = New System.Drawing.Point(17, 37)
        Me.lyPan1.Name = "lyPan1"
        Me.lyPan1.RowCount = 6
        Me.lyPan1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.lyPan1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.lyPan1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.lyPan1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.lyPan1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.lyPan1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.lyPan1.Size = New System.Drawing.Size(392, 222)
        Me.lyPan1.TabIndex = 11
        '
        'txtBoxID
        '
        Me.txtBoxID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtBoxID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxID.Location = New System.Drawing.Point(85, 7)
        Me.txtBoxID.Name = "txtBoxID"
        Me.txtBoxID.Size = New System.Drawing.Size(75, 21)
        Me.txtBoxID.TabIndex = 17
        '
        'lblNombre
        '
        Me.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(24, 46)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(55, 15)
        Me.lblNombre.TabIndex = 14
        Me.lblNombre.Text = "Nombre:"
        '
        'lblID
        '
        Me.lblID.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(50, 10)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(29, 15)
        Me.lblID.TabIndex = 5
        Me.lblID.Text = "#ID:"
        '
        'txtBoxNombre
        '
        Me.txtBoxNombre.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtBoxNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxNombre.Location = New System.Drawing.Point(85, 43)
        Me.txtBoxNombre.Name = "txtBoxNombre"
        Me.txtBoxNombre.Size = New System.Drawing.Size(277, 21)
        Me.txtBoxNombre.TabIndex = 18
        '
        'lblFechaFin
        '
        Me.lblFechaFin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(15, 193)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(64, 15)
        Me.lblFechaFin.TabIndex = 16
        Me.lblFechaFin.Text = "Fecha Fin:"
        '
        'timePickerFechaFin
        '
        Me.timePickerFechaFin.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.timePickerFechaFin.Location = New System.Drawing.Point(85, 190)
        Me.timePickerFechaFin.Name = "timePickerFechaFin"
        Me.timePickerFechaFin.Size = New System.Drawing.Size(245, 21)
        Me.timePickerFechaFin.TabIndex = 21
        '
        'timePickerFechaInicio
        '
        Me.timePickerFechaInicio.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.timePickerFechaInicio.Location = New System.Drawing.Point(85, 151)
        Me.timePickerFechaInicio.Name = "timePickerFechaInicio"
        Me.timePickerFechaInicio.Size = New System.Drawing.Size(245, 21)
        Me.timePickerFechaInicio.TabIndex = 14
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New System.Drawing.Point(3, 154)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(76, 15)
        Me.lblFechaInicio.TabIndex = 15
        Me.lblFechaInicio.Text = "Fecha Inicio:"
        '
        'lblLugar
        '
        Me.lblLugar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblLugar.AutoSize = True
        Me.lblLugar.Location = New System.Drawing.Point(37, 118)
        Me.lblLugar.Name = "lblLugar"
        Me.lblLugar.Size = New System.Drawing.Size(42, 15)
        Me.lblLugar.TabIndex = 14
        Me.lblLugar.Text = "Lugar:"
        '
        'txtBoxLugar
        '
        Me.txtBoxLugar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtBoxLugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxLugar.Location = New System.Drawing.Point(85, 115)
        Me.txtBoxLugar.Name = "txtBoxLugar"
        Me.txtBoxLugar.Size = New System.Drawing.Size(277, 21)
        Me.txtBoxLugar.TabIndex = 20
        '
        'lblSiglas
        '
        Me.lblSiglas.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblSiglas.AutoSize = True
        Me.lblSiglas.Location = New System.Drawing.Point(38, 82)
        Me.lblSiglas.Name = "lblSiglas"
        Me.lblSiglas.Size = New System.Drawing.Size(41, 15)
        Me.lblSiglas.TabIndex = 14
        Me.lblSiglas.Text = "Siglas"
        '
        'txtBoxSiglas
        '
        Me.txtBoxSiglas.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtBoxSiglas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxSiglas.Location = New System.Drawing.Point(85, 79)
        Me.txtBoxSiglas.Name = "txtBoxSiglas"
        Me.txtBoxSiglas.Size = New System.Drawing.Size(75, 21)
        Me.txtBoxSiglas.TabIndex = 19
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(0, 25)
        Me.lblTitulo.TabIndex = 10
        '
        'grpBoxAsistentes
        '
        Me.grpBoxAsistentes.Controls.Add(Me.chkLstBoxAsistentes)
        Me.grpBoxAsistentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBoxAsistentes.Location = New System.Drawing.Point(17, 265)
        Me.grpBoxAsistentes.Name = "grpBoxAsistentes"
        Me.grpBoxAsistentes.Size = New System.Drawing.Size(333, 171)
        Me.grpBoxAsistentes.TabIndex = 14
        Me.grpBoxAsistentes.TabStop = False
        Me.grpBoxAsistentes.Text = "Investigadores asistentes:"
        '
        'chkLstBoxAsistentes
        '
        Me.chkLstBoxAsistentes.CheckOnClick = True
        Me.chkLstBoxAsistentes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkLstBoxAsistentes.Location = New System.Drawing.Point(3, 17)
        Me.chkLstBoxAsistentes.Name = "chkLstBoxAsistentes"
        Me.chkLstBoxAsistentes.Size = New System.Drawing.Size(327, 151)
        Me.chkLstBoxAsistentes.Sorted = True
        Me.chkLstBoxAsistentes.TabIndex = 0
        '
        'grpBoxArticulos
        '
        Me.grpBoxArticulos.Controls.Add(Me.chkLstBoxArticulos)
        Me.grpBoxArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBoxArticulos.Location = New System.Drawing.Point(356, 265)
        Me.grpBoxArticulos.Name = "grpBoxArticulos"
        Me.grpBoxArticulos.Size = New System.Drawing.Size(390, 171)
        Me.grpBoxArticulos.TabIndex = 15
        Me.grpBoxArticulos.TabStop = False
        Me.grpBoxArticulos.Text = "Artículos:"
        '
        'chkLstBoxArticulos
        '
        Me.chkLstBoxArticulos.CheckOnClick = True
        Me.chkLstBoxArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkLstBoxArticulos.Location = New System.Drawing.Point(3, 17)
        Me.chkLstBoxArticulos.Name = "chkLstBoxArticulos"
        Me.chkLstBoxArticulos.Size = New System.Drawing.Size(384, 151)
        Me.chkLstBoxArticulos.Sorted = True
        Me.chkLstBoxArticulos.TabIndex = 0
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnOK.Image = Global.PractLabBBDD.My.Resources.Resources.good
        Me.btnOK.Location = New System.Drawing.Point(533, 442)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(102, 36)
        Me.btnOK.TabIndex = 12
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(489, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 176)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'formConferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 493)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grpBoxArticulos)
        Me.Controls.Add(Me.grpBoxAsistentes)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lyPan1)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "formConferencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conferencia"
        Me.lyPan1.ResumeLayout(False)
        Me.lyPan1.PerformLayout()
        Me.grpBoxAsistentes.ResumeLayout(False)
        Me.grpBoxArticulos.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lyPan1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblLugar As System.Windows.Forms.Label
    Friend WithEvents lblSiglas As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents timePickerFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtBoxID As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxSiglas As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxLugar As System.Windows.Forms.TextBox
    Friend WithEvents timePickerFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents grpBoxAsistentes As System.Windows.Forms.GroupBox
    Friend WithEvents chkLstBoxAsistentes As System.Windows.Forms.CheckedListBox
    Friend WithEvents grpBoxArticulos As System.Windows.Forms.GroupBox
    Friend WithEvents chkLstBoxArticulos As System.Windows.Forms.CheckedListBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
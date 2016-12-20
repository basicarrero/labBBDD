<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formInvestigador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formInvestigador))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lyPan1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblDespacho = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblEdificio = New System.Windows.Forms.Label()
        Me.txtBoxID = New System.Windows.Forms.TextBox()
        Me.txtBoxApellidos = New System.Windows.Forms.TextBox()
        Me.txtBoxNombre = New System.Windows.Forms.TextBox()
        Me.txtBoxEdificio = New System.Windows.Forms.TextBox()
        Me.txtBoxTelefono = New System.Windows.Forms.TextBox()
        Me.txtBoxEmail = New System.Windows.Forms.TextBox()
        Me.txtBoxDespacho = New System.Windows.Forms.TextBox()
        Me.cmBoxDep = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lyPan1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(0, 25)
        Me.lblTitulo.TabIndex = 1
        '
        'lyPan1
        '
        Me.lyPan1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lyPan1.ColumnCount = 4
        Me.lyPan1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.lyPan1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.lyPan1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.lyPan1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.lyPan1.Controls.Add(Me.lblDepartamento, 2, 0)
        Me.lyPan1.Controls.Add(Me.lblEmail, 2, 3)
        Me.lyPan1.Controls.Add(Me.lblTelefono, 0, 3)
        Me.lyPan1.Controls.Add(Me.lblDespacho, 2, 2)
        Me.lyPan1.Controls.Add(Me.lblApellidos, 0, 1)
        Me.lyPan1.Controls.Add(Me.lblNombre, 2, 1)
        Me.lyPan1.Controls.Add(Me.lblID, 0, 0)
        Me.lyPan1.Controls.Add(Me.lblEdificio, 0, 2)
        Me.lyPan1.Controls.Add(Me.txtBoxID, 1, 0)
        Me.lyPan1.Controls.Add(Me.txtBoxApellidos, 1, 1)
        Me.lyPan1.Controls.Add(Me.txtBoxNombre, 3, 1)
        Me.lyPan1.Controls.Add(Me.txtBoxEdificio, 1, 2)
        Me.lyPan1.Controls.Add(Me.txtBoxTelefono, 1, 3)
        Me.lyPan1.Controls.Add(Me.txtBoxEmail, 3, 3)
        Me.lyPan1.Controls.Add(Me.txtBoxDespacho, 3, 2)
        Me.lyPan1.Controls.Add(Me.cmBoxDep, 3, 0)
        Me.lyPan1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lyPan1.Location = New System.Drawing.Point(17, 37)
        Me.lyPan1.Name = "lyPan1"
        Me.lyPan1.RowCount = 4
        Me.lyPan1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.lyPan1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.lyPan1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.lyPan1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.lyPan1.Size = New System.Drawing.Size(736, 144)
        Me.lyPan1.TabIndex = 2
        '
        'lblDepartamento
        '
        Me.lblDepartamento.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Location = New System.Drawing.Point(352, 10)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(89, 15)
        Me.lblDepartamento.TabIndex = 14
        Me.lblDepartamento.Text = "Departamento:"
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(396, 118)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(45, 15)
        Me.lblEmail.TabIndex = 6
        Me.lblEmail.Text = "e-Mail:"
        '
        'lblTelefono
        '
        Me.lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(5, 118)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(58, 15)
        Me.lblTelefono.TabIndex = 6
        Me.lblTelefono.Text = "Teléfono:"
        '
        'lblDespacho
        '
        Me.lblDespacho.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDespacho.AutoSize = True
        Me.lblDespacho.Location = New System.Drawing.Point(375, 82)
        Me.lblDespacho.Name = "lblDespacho"
        Me.lblDespacho.Size = New System.Drawing.Size(66, 15)
        Me.lblDespacho.TabIndex = 6
        Me.lblDespacho.Text = "Despacho:"
        '
        'lblApellidos
        '
        Me.lblApellidos.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidos.Location = New System.Drawing.Point(3, 46)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(60, 15)
        Me.lblApellidos.TabIndex = 0
        Me.lblApellidos.Text = "Apellidos:"
        '
        'lblNombre
        '
        Me.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(386, 46)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(55, 15)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre:"
        '
        'lblID
        '
        Me.lblID.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(34, 10)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(29, 15)
        Me.lblID.TabIndex = 4
        Me.lblID.Text = "#ID:"
        '
        'lblEdificio
        '
        Me.lblEdificio.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblEdificio.AutoSize = True
        Me.lblEdificio.Location = New System.Drawing.Point(13, 82)
        Me.lblEdificio.Name = "lblEdificio"
        Me.lblEdificio.Size = New System.Drawing.Size(50, 15)
        Me.lblEdificio.TabIndex = 5
        Me.lblEdificio.Text = "Edificio:"
        '
        'txtBoxID
        '
        Me.txtBoxID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtBoxID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxID.Location = New System.Drawing.Point(69, 7)
        Me.txtBoxID.Name = "txtBoxID"
        Me.txtBoxID.Size = New System.Drawing.Size(75, 21)
        Me.txtBoxID.TabIndex = 2
        '
        'txtBoxApellidos
        '
        Me.txtBoxApellidos.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtBoxApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxApellidos.Location = New System.Drawing.Point(69, 43)
        Me.txtBoxApellidos.Name = "txtBoxApellidos"
        Me.txtBoxApellidos.Size = New System.Drawing.Size(277, 21)
        Me.txtBoxApellidos.TabIndex = 7
        '
        'txtBoxNombre
        '
        Me.txtBoxNombre.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtBoxNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxNombre.Location = New System.Drawing.Point(447, 43)
        Me.txtBoxNombre.Name = "txtBoxNombre"
        Me.txtBoxNombre.Size = New System.Drawing.Size(207, 21)
        Me.txtBoxNombre.TabIndex = 8
        '
        'txtBoxEdificio
        '
        Me.txtBoxEdificio.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtBoxEdificio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxEdificio.Location = New System.Drawing.Point(69, 79)
        Me.txtBoxEdificio.Name = "txtBoxEdificio"
        Me.txtBoxEdificio.Size = New System.Drawing.Size(277, 21)
        Me.txtBoxEdificio.TabIndex = 9
        '
        'txtBoxTelefono
        '
        Me.txtBoxTelefono.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtBoxTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxTelefono.Location = New System.Drawing.Point(69, 115)
        Me.txtBoxTelefono.Name = "txtBoxTelefono"
        Me.txtBoxTelefono.Size = New System.Drawing.Size(132, 21)
        Me.txtBoxTelefono.TabIndex = 11
        '
        'txtBoxEmail
        '
        Me.txtBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtBoxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxEmail.Location = New System.Drawing.Point(447, 115)
        Me.txtBoxEmail.Name = "txtBoxEmail"
        Me.txtBoxEmail.Size = New System.Drawing.Size(207, 21)
        Me.txtBoxEmail.TabIndex = 12
        '
        'txtBoxDespacho
        '
        Me.txtBoxDespacho.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtBoxDespacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxDespacho.Location = New System.Drawing.Point(447, 79)
        Me.txtBoxDespacho.Name = "txtBoxDespacho"
        Me.txtBoxDespacho.Size = New System.Drawing.Size(71, 21)
        Me.txtBoxDespacho.TabIndex = 10
        '
        'cmBoxDep
        '
        Me.cmBoxDep.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmBoxDep.FormattingEnabled = True
        Me.cmBoxDep.Location = New System.Drawing.Point(447, 7)
        Me.cmBoxDep.Name = "cmBoxDep"
        Me.cmBoxDep.Size = New System.Drawing.Size(207, 23)
        Me.cmBoxDep.TabIndex = 13
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackgroundImage = CType(resources.GetObject("btnCancel.BackgroundImage"), System.Drawing.Image)
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCancel.Location = New System.Drawing.Point(651, 190)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(102, 36)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.BackgroundImage = CType(resources.GetObject("btnOK.BackgroundImage"), System.Drawing.Image)
        Me.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnOK.Location = New System.Drawing.Point(543, 190)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(102, 36)
        Me.btnOK.TabIndex = 4
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'formInvestigador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 238)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lyPan1)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "formInvestigador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Investigador"
        Me.lyPan1.ResumeLayout(False)
        Me.lyPan1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lyPan1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblApellidos As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtBoxID As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents lblDespacho As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblEdificio As System.Windows.Forms.Label
    Friend WithEvents txtBoxApellidos As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxEdificio As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxDespacho As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxEmail As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents cmBoxDep As System.Windows.Forms.ComboBox
    Friend WithEvents lblDepartamento As System.Windows.Forms.Label
End Class

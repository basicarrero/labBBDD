<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDepartamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formDepartamento))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lyPan1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtBoxID = New System.Windows.Forms.TextBox()
        Me.txtBoxNombre = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
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
        Me.lblTitulo.TabIndex = 0
        '
        'lyPan1
        '
        Me.lyPan1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lyPan1.ColumnCount = 2
        Me.lyPan1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.lyPan1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.lyPan1.Controls.Add(Me.lblID, 0, 0)
        Me.lyPan1.Controls.Add(Me.lblNombre, 0, 1)
        Me.lyPan1.Controls.Add(Me.txtBoxID, 1, 0)
        Me.lyPan1.Controls.Add(Me.txtBoxNombre, 1, 1)
        Me.lyPan1.Location = New System.Drawing.Point(17, 37)
        Me.lyPan1.Name = "lyPan1"
        Me.lyPan1.RowCount = 2
        Me.lyPan1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.lyPan1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.lyPan1.Size = New System.Drawing.Size(300, 79)
        Me.lyPan1.TabIndex = 1
        '
        'lblID
        '
        Me.lblID.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(29, 10)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(29, 15)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "#ID:"
        '
        'lblNombre
        '
        Me.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(3, 50)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(55, 15)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre:"
        '
        'txtBoxID
        '
        Me.txtBoxID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtBoxID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxID.Location = New System.Drawing.Point(64, 7)
        Me.txtBoxID.Name = "txtBoxID"
        Me.txtBoxID.Size = New System.Drawing.Size(118, 21)
        Me.txtBoxID.TabIndex = 2
        '
        'txtBoxNombre
        '
        Me.txtBoxNombre.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtBoxNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxNombre.Location = New System.Drawing.Point(64, 47)
        Me.txtBoxNombre.Name = "txtBoxNombre"
        Me.txtBoxNombre.Size = New System.Drawing.Size(118, 21)
        Me.txtBoxNombre.TabIndex = 3
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.BackgroundImage = CType(resources.GetObject("btnOK.BackgroundImage"), System.Drawing.Image)
        Me.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnOK.Location = New System.Drawing.Point(107, 126)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(102, 36)
        Me.btnOK.TabIndex = 2
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackgroundImage = CType(resources.GetObject("btnCancel.BackgroundImage"), System.Drawing.Image)
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCancel.Location = New System.Drawing.Point(215, 126)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(102, 36)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'formDepartamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 174)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lyPan1)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "formDepartamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Departamento"
        Me.lyPan1.ResumeLayout(False)
        Me.lyPan1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lyPan1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtBoxID As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class

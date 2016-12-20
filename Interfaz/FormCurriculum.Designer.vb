<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCurriculum
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formCurriculum))
        Me.webBrMain = New System.Windows.Forms.WebBrowser()
        Me.ToolStripCV = New System.Windows.Forms.ToolStrip()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStripCV.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'webBrMain
        '
        Me.webBrMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webBrMain.Location = New System.Drawing.Point(0, 0)
        Me.webBrMain.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webBrMain.Name = "webBrMain"
        Me.webBrMain.Size = New System.Drawing.Size(785, 462)
        Me.webBrMain.TabIndex = 0
        '
        'ToolStripCV
        '
        Me.ToolStripCV.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSave})
        Me.ToolStripCV.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripCV.Name = "ToolStripCV"
        Me.ToolStripCV.Size = New System.Drawing.Size(785, 38)
        Me.ToolStripCV.TabIndex = 0
        Me.ToolStripCV.Text = "ToolStripCV"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.PractLabBBDD.My.Resources.Resources.save
        Me.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(154, 28)
        Me.btnSave.Text = "Guardar a archivo"
        Me.btnSave.ToolTipText = "Save to a File"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.webBrMain)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(785, 462)
        Me.Panel1.TabIndex = 1
        '
        'formCurriculum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 500)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStripCV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formCurriculum"
        Me.Text = "Curriculum"
        Me.ToolStripCV.ResumeLayout(False)
        Me.ToolStripCV.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents webBrMain As System.Windows.Forms.WebBrowser
    Friend WithEvents ToolStripCV As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class

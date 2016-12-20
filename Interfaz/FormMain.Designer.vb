<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.tabPagInvest = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lstBoxInvest = New System.Windows.Forms.ListBox()
        Me.grpBoxInvestAsisteA = New System.Windows.Forms.GroupBox()
        Me.lstBoxInvestAsistencia = New System.Windows.Forms.ListBox()
        Me.lyPanInvestigadores = New System.Windows.Forms.TableLayoutPanel()
        Me.lblInvestMailTag = New System.Windows.Forms.Label()
        Me.lblInvestID = New System.Windows.Forms.Label()
        Me.lblInvestEdificio = New System.Windows.Forms.Label()
        Me.lblInvestTelefono = New System.Windows.Forms.Label()
        Me.lblInvestDepartamento = New System.Windows.Forms.Label()
        Me.lblInvestDespacho = New System.Windows.Forms.Label()
        Me.lblInvestEmail = New System.Windows.Forms.Label()
        Me.lblInvestIDTag = New System.Windows.Forms.Label()
        Me.lblInvestEdificioTag = New System.Windows.Forms.Label()
        Me.lblInvestTelfTag = New System.Windows.Forms.Label()
        Me.lblInvestDepTag = New System.Windows.Forms.Label()
        Me.lblInvestDespachoTag = New System.Windows.Forms.Label()
        Me.lblInvestNombreTag = New System.Windows.Forms.Label()
        Me.ToolStripInvest = New System.Windows.Forms.ToolStrip()
        Me.btnInvestAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnInvestEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnInvestDel = New System.Windows.Forms.ToolStripButton()
        Me.stripSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnInvestGetCurriculum = New System.Windows.Forms.ToolStripButton()
        Me.lblFirma = New System.Windows.Forms.ToolStripLabel()
        Me.tabPagConf = New System.Windows.Forms.TabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.lstBoxConfs = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblConfFechaFin = New System.Windows.Forms.Label()
        Me.lblConfLugarTag = New System.Windows.Forms.Label()
        Me.lblConfFechaFinTag = New System.Windows.Forms.Label()
        Me.lblConfLugar = New System.Windows.Forms.Label()
        Me.lblConfFechaInicioTag = New System.Windows.Forms.Label()
        Me.lblConfFechaInicio = New System.Windows.Forms.Label()
        Me.lblConfNombreTag = New System.Windows.Forms.Label()
        Me.calendarConferencias = New System.Windows.Forms.MonthCalendar()
        Me.grpBoxConfAsistentes = New System.Windows.Forms.GroupBox()
        Me.lstBoxConfAsistencia = New System.Windows.Forms.ListBox()
        Me.ToolStripConfs = New System.Windows.Forms.ToolStrip()
        Me.btnConfAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnConfEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnConfDel = New System.Windows.Forms.ToolStripButton()
        Me.tabPagDep = New System.Windows.Forms.TabPage()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.lstBoxDep = New System.Windows.Forms.ListBox()
        Me.grpBoxDepMember = New System.Windows.Forms.GroupBox()
        Me.lstBoxDepMiembros = New System.Windows.Forms.ListBox()
        Me.lblDepNombreTag = New System.Windows.Forms.Label()
        Me.ToolStripDep = New System.Windows.Forms.ToolStrip()
        Me.btnDepAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnDepEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnDepDel = New System.Windows.Forms.ToolStripButton()
        Me.tabPagArts = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.lstBoxArts = New System.Windows.Forms.ListBox()
        Me.grpBoxAutores = New System.Windows.Forms.GroupBox()
        Me.lstBoxAutores = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblArtID = New System.Windows.Forms.Label()
        Me.lblArtConf = New System.Windows.Forms.Label()
        Me.lblArtPags = New System.Windows.Forms.Label()
        Me.lblArtConfTag = New System.Windows.Forms.Label()
        Me.lblArtPagsTag = New System.Windows.Forms.Label()
        Me.lblArtIDTag = New System.Windows.Forms.Label()
        Me.lblArtTituloTag = New System.Windows.Forms.Label()
        Me.ToolStripArts = New System.Windows.Forms.ToolStrip()
        Me.btnArtAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnArtEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnArtDel = New System.Windows.Forms.ToolStripButton()
        Me.stripPanAyuda = New System.Windows.Forms.ToolStripPanel()
        Me.stripPanTopAyuda = New System.Windows.Forms.ToolStripPanel()
        Me.stripPanRightInvest = New System.Windows.Forms.ToolStripPanel()
        Me.stripPanLeftInvest = New System.Windows.Forms.ToolStripPanel()
        Me.stripCntPanInvestigadores = New System.Windows.Forms.ToolStripContentPanel()
        Me.tabControl.SuspendLayout()
        Me.tabPagInvest.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.grpBoxInvestAsisteA.SuspendLayout()
        Me.lyPanInvestigadores.SuspendLayout()
        Me.ToolStripInvest.SuspendLayout()
        Me.tabPagConf.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.grpBoxConfAsistentes.SuspendLayout()
        Me.ToolStripConfs.SuspendLayout()
        Me.tabPagDep.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.grpBoxDepMember.SuspendLayout()
        Me.ToolStripDep.SuspendLayout()
        Me.tabPagArts.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.grpBoxAutores.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.ToolStripArts.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.tabPagInvest)
        Me.tabControl.Controls.Add(Me.tabPagConf)
        Me.tabControl.Controls.Add(Me.tabPagDep)
        Me.tabControl.Controls.Add(Me.tabPagArts)
        Me.tabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl.Location = New System.Drawing.Point(0, 0)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(816, 399)
        Me.tabControl.TabIndex = 0
        '
        'tabPagInvest
        '
        Me.tabPagInvest.Controls.Add(Me.SplitContainer1)
        Me.tabPagInvest.Controls.Add(Me.ToolStripInvest)
        Me.tabPagInvest.Location = New System.Drawing.Point(4, 22)
        Me.tabPagInvest.Name = "tabPagInvest"
        Me.tabPagInvest.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPagInvest.Size = New System.Drawing.Size(808, 373)
        Me.tabPagInvest.TabIndex = 2
        Me.tabPagInvest.Text = "Investigadores"
        Me.tabPagInvest.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 28)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lstBoxInvest)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackgroundImage = Global.PractLabBBDD.My.Resources.Resources.stack
        Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel2.Controls.Add(Me.grpBoxInvestAsisteA)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lyPanInvestigadores)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblInvestNombreTag)
        Me.SplitContainer1.Size = New System.Drawing.Size(802, 342)
        Me.SplitContainer1.SplitterDistance = 265
        Me.SplitContainer1.TabIndex = 1
        '
        'lstBoxInvest
        '
        Me.lstBoxInvest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstBoxInvest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBoxInvest.FormattingEnabled = True
        Me.lstBoxInvest.ItemHeight = 16
        Me.lstBoxInvest.Location = New System.Drawing.Point(0, 0)
        Me.lstBoxInvest.Name = "lstBoxInvest"
        Me.lstBoxInvest.Size = New System.Drawing.Size(265, 342)
        Me.lstBoxInvest.Sorted = True
        Me.lstBoxInvest.TabIndex = 0
        '
        'grpBoxInvestAsisteA
        '
        Me.grpBoxInvestAsisteA.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpBoxInvestAsisteA.Controls.Add(Me.lstBoxInvestAsistencia)
        Me.grpBoxInvestAsisteA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBoxInvestAsisteA.Location = New System.Drawing.Point(8, 143)
        Me.grpBoxInvestAsisteA.Name = "grpBoxInvestAsisteA"
        Me.grpBoxInvestAsisteA.Size = New System.Drawing.Size(275, 194)
        Me.grpBoxInvestAsisteA.TabIndex = 17
        Me.grpBoxInvestAsisteA.TabStop = False
        Me.grpBoxInvestAsisteA.Text = "Asiste a:"
        '
        'lstBoxInvestAsistencia
        '
        Me.lstBoxInvestAsistencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstBoxInvestAsistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBoxInvestAsistencia.FormattingEnabled = True
        Me.lstBoxInvestAsistencia.ItemHeight = 15
        Me.lstBoxInvestAsistencia.Location = New System.Drawing.Point(3, 17)
        Me.lstBoxInvestAsistencia.Name = "lstBoxInvestAsistencia"
        Me.lstBoxInvestAsistencia.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstBoxInvestAsistencia.Size = New System.Drawing.Size(269, 174)
        Me.lstBoxInvestAsistencia.Sorted = True
        Me.lstBoxInvestAsistencia.TabIndex = 0
        '
        'lyPanInvestigadores
        '
        Me.lyPanInvestigadores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lyPanInvestigadores.BackColor = System.Drawing.Color.Transparent
        Me.lyPanInvestigadores.ColumnCount = 4
        Me.lyPanInvestigadores.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.lyPanInvestigadores.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.lyPanInvestigadores.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.lyPanInvestigadores.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.lyPanInvestigadores.Controls.Add(Me.lblInvestMailTag, 3, 2)
        Me.lyPanInvestigadores.Controls.Add(Me.lblInvestID, 0, 0)
        Me.lyPanInvestigadores.Controls.Add(Me.lblInvestEdificio, 0, 1)
        Me.lyPanInvestigadores.Controls.Add(Me.lblInvestTelefono, 0, 2)
        Me.lyPanInvestigadores.Controls.Add(Me.lblInvestDepartamento, 2, 0)
        Me.lyPanInvestigadores.Controls.Add(Me.lblInvestDespacho, 2, 1)
        Me.lyPanInvestigadores.Controls.Add(Me.lblInvestEmail, 2, 2)
        Me.lyPanInvestigadores.Controls.Add(Me.lblInvestIDTag, 1, 0)
        Me.lyPanInvestigadores.Controls.Add(Me.lblInvestEdificioTag, 1, 1)
        Me.lyPanInvestigadores.Controls.Add(Me.lblInvestTelfTag, 1, 2)
        Me.lyPanInvestigadores.Controls.Add(Me.lblInvestDepTag, 3, 0)
        Me.lyPanInvestigadores.Controls.Add(Me.lblInvestDespachoTag, 3, 1)
        Me.lyPanInvestigadores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lyPanInvestigadores.Location = New System.Drawing.Point(8, 43)
        Me.lyPanInvestigadores.Name = "lyPanInvestigadores"
        Me.lyPanInvestigadores.RowCount = 3
        Me.lyPanInvestigadores.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.lyPanInvestigadores.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.lyPanInvestigadores.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.lyPanInvestigadores.Size = New System.Drawing.Size(524, 94)
        Me.lyPanInvestigadores.TabIndex = 15
        '
        'lblInvestMailTag
        '
        Me.lblInvestMailTag.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblInvestMailTag.AutoSize = True
        Me.lblInvestMailTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvestMailTag.Location = New System.Drawing.Point(228, 70)
        Me.lblInvestMailTag.Name = "lblInvestMailTag"
        Me.lblInvestMailTag.Size = New System.Drawing.Size(45, 16)
        Me.lblInvestMailTag.TabIndex = 14
        Me.lblInvestMailTag.Text = "empty"
        Me.lblInvestMailTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInvestID
        '
        Me.lblInvestID.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblInvestID.AutoSize = True
        Me.lblInvestID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvestID.Location = New System.Drawing.Point(37, 7)
        Me.lblInvestID.Name = "lblInvestID"
        Me.lblInvestID.Size = New System.Drawing.Size(31, 16)
        Me.lblInvestID.TabIndex = 0
        Me.lblInvestID.Text = "#ID:"
        Me.lblInvestID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInvestEdificio
        '
        Me.lblInvestEdificio.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblInvestEdificio.AutoSize = True
        Me.lblInvestEdificio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvestEdificio.Location = New System.Drawing.Point(13, 38)
        Me.lblInvestEdificio.Name = "lblInvestEdificio"
        Me.lblInvestEdificio.Size = New System.Drawing.Size(55, 16)
        Me.lblInvestEdificio.TabIndex = 2
        Me.lblInvestEdificio.Text = "Edificio:"
        Me.lblInvestEdificio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInvestTelefono
        '
        Me.lblInvestTelefono.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblInvestTelefono.AutoSize = True
        Me.lblInvestTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvestTelefono.Location = New System.Drawing.Point(3, 70)
        Me.lblInvestTelefono.Name = "lblInvestTelefono"
        Me.lblInvestTelefono.Size = New System.Drawing.Size(65, 16)
        Me.lblInvestTelefono.TabIndex = 3
        Me.lblInvestTelefono.Text = "Teléfono:"
        Me.lblInvestTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInvestDepartamento
        '
        Me.lblInvestDepartamento.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblInvestDepartamento.AutoSize = True
        Me.lblInvestDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvestDepartamento.Location = New System.Drawing.Point(125, 7)
        Me.lblInvestDepartamento.Name = "lblInvestDepartamento"
        Me.lblInvestDepartamento.Size = New System.Drawing.Size(97, 16)
        Me.lblInvestDepartamento.TabIndex = 1
        Me.lblInvestDepartamento.Text = "Departamento:"
        Me.lblInvestDepartamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInvestDespacho
        '
        Me.lblInvestDespacho.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblInvestDespacho.AutoSize = True
        Me.lblInvestDespacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvestDespacho.Location = New System.Drawing.Point(148, 38)
        Me.lblInvestDespacho.Name = "lblInvestDespacho"
        Me.lblInvestDespacho.Size = New System.Drawing.Size(74, 16)
        Me.lblInvestDespacho.TabIndex = 8
        Me.lblInvestDespacho.Text = "Despacho:"
        Me.lblInvestDespacho.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInvestEmail
        '
        Me.lblInvestEmail.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblInvestEmail.AutoSize = True
        Me.lblInvestEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvestEmail.Location = New System.Drawing.Point(174, 70)
        Me.lblInvestEmail.Name = "lblInvestEmail"
        Me.lblInvestEmail.Size = New System.Drawing.Size(48, 16)
        Me.lblInvestEmail.TabIndex = 9
        Me.lblInvestEmail.Text = "e-Mail:"
        Me.lblInvestEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInvestIDTag
        '
        Me.lblInvestIDTag.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblInvestIDTag.AutoSize = True
        Me.lblInvestIDTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvestIDTag.Location = New System.Drawing.Point(74, 7)
        Me.lblInvestIDTag.Name = "lblInvestIDTag"
        Me.lblInvestIDTag.Size = New System.Drawing.Size(45, 16)
        Me.lblInvestIDTag.TabIndex = 11
        Me.lblInvestIDTag.Text = "empty"
        Me.lblInvestIDTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInvestEdificioTag
        '
        Me.lblInvestEdificioTag.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblInvestEdificioTag.AutoSize = True
        Me.lblInvestEdificioTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvestEdificioTag.Location = New System.Drawing.Point(74, 38)
        Me.lblInvestEdificioTag.Name = "lblInvestEdificioTag"
        Me.lblInvestEdificioTag.Size = New System.Drawing.Size(45, 16)
        Me.lblInvestEdificioTag.TabIndex = 12
        Me.lblInvestEdificioTag.Text = "empty"
        Me.lblInvestEdificioTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInvestTelfTag
        '
        Me.lblInvestTelfTag.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblInvestTelfTag.AutoSize = True
        Me.lblInvestTelfTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvestTelfTag.Location = New System.Drawing.Point(74, 70)
        Me.lblInvestTelfTag.Name = "lblInvestTelfTag"
        Me.lblInvestTelfTag.Size = New System.Drawing.Size(45, 16)
        Me.lblInvestTelfTag.TabIndex = 13
        Me.lblInvestTelfTag.Text = "empty"
        Me.lblInvestTelfTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInvestDepTag
        '
        Me.lblInvestDepTag.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblInvestDepTag.AutoSize = True
        Me.lblInvestDepTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvestDepTag.Location = New System.Drawing.Point(228, 7)
        Me.lblInvestDepTag.Name = "lblInvestDepTag"
        Me.lblInvestDepTag.Size = New System.Drawing.Size(45, 16)
        Me.lblInvestDepTag.TabIndex = 14
        Me.lblInvestDepTag.Text = "empty"
        Me.lblInvestDepTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInvestDespachoTag
        '
        Me.lblInvestDespachoTag.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblInvestDespachoTag.AutoSize = True
        Me.lblInvestDespachoTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvestDespachoTag.Location = New System.Drawing.Point(228, 38)
        Me.lblInvestDespachoTag.Name = "lblInvestDespachoTag"
        Me.lblInvestDespachoTag.Size = New System.Drawing.Size(45, 16)
        Me.lblInvestDespachoTag.TabIndex = 15
        Me.lblInvestDespachoTag.Text = "empty"
        Me.lblInvestDespachoTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInvestNombreTag
        '
        Me.lblInvestNombreTag.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblInvestNombreTag.AutoSize = True
        Me.lblInvestNombreTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvestNombreTag.Location = New System.Drawing.Point(3, 11)
        Me.lblInvestNombreTag.Name = "lblInvestNombreTag"
        Me.lblInvestNombreTag.Size = New System.Drawing.Size(80, 29)
        Me.lblInvestNombreTag.TabIndex = 16
        Me.lblInvestNombreTag.Text = "Empty"
        '
        'ToolStripInvest
        '
        Me.ToolStripInvest.CanOverflow = False
        Me.ToolStripInvest.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripInvest.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnInvestAdd, Me.btnInvestEdit, Me.btnInvestDel, Me.stripSep2, Me.btnInvestGetCurriculum, Me.lblFirma})
        Me.ToolStripInvest.Location = New System.Drawing.Point(3, 3)
        Me.ToolStripInvest.Name = "ToolStripInvest"
        Me.ToolStripInvest.Size = New System.Drawing.Size(802, 25)
        Me.ToolStripInvest.TabIndex = 0
        Me.ToolStripInvest.Text = "ToolStrip1"
        '
        'btnInvestAdd
        '
        Me.btnInvestAdd.AutoSize = False
        Me.btnInvestAdd.Image = CType(resources.GetObject("btnInvestAdd.Image"), System.Drawing.Image)
        Me.btnInvestAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInvestAdd.Name = "btnInvestAdd"
        Me.btnInvestAdd.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.btnInvestAdd.Size = New System.Drawing.Size(149, 22)
        Me.btnInvestAdd.Text = "Añadir Investigador"
        Me.btnInvestAdd.ToolTipText = "Añadir Investigador"
        '
        'btnInvestEdit
        '
        Me.btnInvestEdit.AutoSize = False
        Me.btnInvestEdit.Image = CType(resources.GetObject("btnInvestEdit.Image"), System.Drawing.Image)
        Me.btnInvestEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInvestEdit.Name = "btnInvestEdit"
        Me.btnInvestEdit.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.btnInvestEdit.Size = New System.Drawing.Size(149, 22)
        Me.btnInvestEdit.Text = "Editar Investigador"
        Me.btnInvestEdit.ToolTipText = "Editar Investigador"
        '
        'btnInvestDel
        '
        Me.btnInvestDel.AutoSize = False
        Me.btnInvestDel.Image = CType(resources.GetObject("btnInvestDel.Image"), System.Drawing.Image)
        Me.btnInvestDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInvestDel.Name = "btnInvestDel"
        Me.btnInvestDel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.btnInvestDel.Size = New System.Drawing.Size(149, 22)
        Me.btnInvestDel.Text = "Eliminar Investigador"
        Me.btnInvestDel.ToolTipText = "Eliminar Investigador"
        '
        'stripSep2
        '
        Me.stripSep2.Name = "stripSep2"
        Me.stripSep2.Size = New System.Drawing.Size(6, 25)
        '
        'btnInvestGetCurriculum
        '
        Me.btnInvestGetCurriculum.AutoSize = False
        Me.btnInvestGetCurriculum.Image = CType(resources.GetObject("btnInvestGetCurriculum.Image"), System.Drawing.Image)
        Me.btnInvestGetCurriculum.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInvestGetCurriculum.Name = "btnInvestGetCurriculum"
        Me.btnInvestGetCurriculum.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.btnInvestGetCurriculum.Size = New System.Drawing.Size(149, 22)
        Me.btnInvestGetCurriculum.Text = "Generar Currículum"
        '
        'lblFirma
        '
        Me.lblFirma.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirma.Margin = New System.Windows.Forms.Padding(70, 1, 0, 2)
        Me.lblFirma.Name = "lblFirma"
        Me.lblFirma.Size = New System.Drawing.Size(124, 22)
        Me.lblFirma.Text = "Basilio Carrero Nevado"
        Me.lblFirma.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'tabPagConf
        '
        Me.tabPagConf.Controls.Add(Me.SplitContainer3)
        Me.tabPagConf.Controls.Add(Me.ToolStripConfs)
        Me.tabPagConf.Location = New System.Drawing.Point(4, 22)
        Me.tabPagConf.Name = "tabPagConf"
        Me.tabPagConf.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPagConf.Size = New System.Drawing.Size(808, 373)
        Me.tabPagConf.TabIndex = 3
        Me.tabPagConf.Text = "Conferencias"
        Me.tabPagConf.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(3, 28)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.lstBoxConfs)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.BackgroundImage = Global.PractLabBBDD.My.Resources.Resources.stack
        Me.SplitContainer3.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer3.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer3.Panel2.Controls.Add(Me.lblConfNombreTag)
        Me.SplitContainer3.Panel2.Controls.Add(Me.calendarConferencias)
        Me.SplitContainer3.Panel2.Controls.Add(Me.grpBoxConfAsistentes)
        Me.SplitContainer3.Size = New System.Drawing.Size(802, 342)
        Me.SplitContainer3.SplitterDistance = 265
        Me.SplitContainer3.TabIndex = 2
        '
        'lstBoxConfs
        '
        Me.lstBoxConfs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstBoxConfs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.lstBoxConfs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBoxConfs.FormattingEnabled = True
        Me.lstBoxConfs.ItemHeight = 16
        Me.lstBoxConfs.Location = New System.Drawing.Point(0, 0)
        Me.lstBoxConfs.Margin = New System.Windows.Forms.Padding(0)
        Me.lstBoxConfs.Name = "lstBoxConfs"
        Me.lstBoxConfs.Size = New System.Drawing.Size(265, 342)
        Me.lstBoxConfs.Sorted = True
        Me.lstBoxConfs.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 465.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblConfFechaFin, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblConfLugarTag, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblConfFechaFinTag, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblConfLugar, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblConfFechaInicioTag, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblConfFechaInicio, 0, 1)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(8, 43)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(524, 94)
        Me.TableLayoutPanel1.TabIndex = 18
        '
        'lblConfFechaFin
        '
        Me.lblConfFechaFin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblConfFechaFin.AutoSize = True
        Me.lblConfFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfFechaFin.Location = New System.Drawing.Point(16, 70)
        Me.lblConfFechaFin.Name = "lblConfFechaFin"
        Me.lblConfFechaFin.Size = New System.Drawing.Size(70, 16)
        Me.lblConfFechaFin.TabIndex = 5
        Me.lblConfFechaFin.Text = "Fecha Fin:"
        '
        'lblConfLugarTag
        '
        Me.lblConfLugarTag.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblConfLugarTag.AutoSize = True
        Me.lblConfLugarTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfLugarTag.Location = New System.Drawing.Point(92, 7)
        Me.lblConfLugarTag.Name = "lblConfLugarTag"
        Me.lblConfLugarTag.Size = New System.Drawing.Size(45, 16)
        Me.lblConfLugarTag.TabIndex = 7
        Me.lblConfLugarTag.Text = "empty"
        Me.lblConfLugarTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblConfFechaFinTag
        '
        Me.lblConfFechaFinTag.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblConfFechaFinTag.AutoSize = True
        Me.lblConfFechaFinTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfFechaFinTag.Location = New System.Drawing.Point(92, 70)
        Me.lblConfFechaFinTag.Name = "lblConfFechaFinTag"
        Me.lblConfFechaFinTag.Size = New System.Drawing.Size(45, 16)
        Me.lblConfFechaFinTag.TabIndex = 9
        Me.lblConfFechaFinTag.Text = "empty"
        Me.lblConfFechaFinTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblConfLugar
        '
        Me.lblConfLugar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblConfLugar.AutoSize = True
        Me.lblConfLugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfLugar.Location = New System.Drawing.Point(41, 7)
        Me.lblConfLugar.Name = "lblConfLugar"
        Me.lblConfLugar.Size = New System.Drawing.Size(45, 16)
        Me.lblConfLugar.TabIndex = 0
        Me.lblConfLugar.Text = "Lugar:"
        '
        'lblConfFechaInicioTag
        '
        Me.lblConfFechaInicioTag.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblConfFechaInicioTag.AutoSize = True
        Me.lblConfFechaInicioTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfFechaInicioTag.Location = New System.Drawing.Point(92, 38)
        Me.lblConfFechaInicioTag.Name = "lblConfFechaInicioTag"
        Me.lblConfFechaInicioTag.Size = New System.Drawing.Size(45, 16)
        Me.lblConfFechaInicioTag.TabIndex = 8
        Me.lblConfFechaInicioTag.Text = "empty"
        Me.lblConfFechaInicioTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblConfFechaInicio
        '
        Me.lblConfFechaInicio.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblConfFechaInicio.AutoSize = True
        Me.lblConfFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfFechaInicio.Location = New System.Drawing.Point(3, 38)
        Me.lblConfFechaInicio.Name = "lblConfFechaInicio"
        Me.lblConfFechaInicio.Size = New System.Drawing.Size(83, 16)
        Me.lblConfFechaInicio.TabIndex = 1
        Me.lblConfFechaInicio.Text = "Fecha Inicio:"
        '
        'lblConfNombreTag
        '
        Me.lblConfNombreTag.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblConfNombreTag.AutoSize = True
        Me.lblConfNombreTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfNombreTag.Location = New System.Drawing.Point(3, 11)
        Me.lblConfNombreTag.Name = "lblConfNombreTag"
        Me.lblConfNombreTag.Size = New System.Drawing.Size(80, 29)
        Me.lblConfNombreTag.TabIndex = 17
        Me.lblConfNombreTag.Text = "Empty"
        '
        'calendarConferencias
        '
        Me.calendarConferencias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.calendarConferencias.Location = New System.Drawing.Point(300, 163)
        Me.calendarConferencias.Name = "calendarConferencias"
        Me.calendarConferencias.TabIndex = 7
        '
        'grpBoxConfAsistentes
        '
        Me.grpBoxConfAsistentes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpBoxConfAsistentes.Controls.Add(Me.lstBoxConfAsistencia)
        Me.grpBoxConfAsistentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBoxConfAsistentes.Location = New System.Drawing.Point(8, 151)
        Me.grpBoxConfAsistentes.Name = "grpBoxConfAsistentes"
        Me.grpBoxConfAsistentes.Size = New System.Drawing.Size(289, 174)
        Me.grpBoxConfAsistentes.TabIndex = 9
        Me.grpBoxConfAsistentes.TabStop = False
        Me.grpBoxConfAsistentes.Text = "Asistentes:"
        '
        'lstBoxConfAsistencia
        '
        Me.lstBoxConfAsistencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstBoxConfAsistencia.FormattingEnabled = True
        Me.lstBoxConfAsistencia.ItemHeight = 15
        Me.lstBoxConfAsistencia.Location = New System.Drawing.Point(3, 17)
        Me.lstBoxConfAsistencia.Name = "lstBoxConfAsistencia"
        Me.lstBoxConfAsistencia.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstBoxConfAsistencia.Size = New System.Drawing.Size(283, 154)
        Me.lstBoxConfAsistencia.Sorted = True
        Me.lstBoxConfAsistencia.TabIndex = 5
        '
        'ToolStripConfs
        '
        Me.ToolStripConfs.CanOverflow = False
        Me.ToolStripConfs.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripConfs.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnConfAdd, Me.btnConfEdit, Me.btnConfDel})
        Me.ToolStripConfs.Location = New System.Drawing.Point(3, 3)
        Me.ToolStripConfs.Name = "ToolStripConfs"
        Me.ToolStripConfs.Size = New System.Drawing.Size(802, 25)
        Me.ToolStripConfs.TabIndex = 1
        Me.ToolStripConfs.Text = "ToolStrip3"
        '
        'btnConfAdd
        '
        Me.btnConfAdd.AutoSize = False
        Me.btnConfAdd.Image = CType(resources.GetObject("btnConfAdd.Image"), System.Drawing.Image)
        Me.btnConfAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConfAdd.Name = "btnConfAdd"
        Me.btnConfAdd.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.btnConfAdd.Size = New System.Drawing.Size(149, 22)
        Me.btnConfAdd.Text = "Añadir Conferencia"
        Me.btnConfAdd.ToolTipText = "Añadir Conferencia"
        '
        'btnConfEdit
        '
        Me.btnConfEdit.AutoSize = False
        Me.btnConfEdit.Image = CType(resources.GetObject("btnConfEdit.Image"), System.Drawing.Image)
        Me.btnConfEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConfEdit.Name = "btnConfEdit"
        Me.btnConfEdit.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.btnConfEdit.Size = New System.Drawing.Size(149, 22)
        Me.btnConfEdit.Text = "Editar Conferencia"
        '
        'btnConfDel
        '
        Me.btnConfDel.AutoSize = False
        Me.btnConfDel.Image = CType(resources.GetObject("btnConfDel.Image"), System.Drawing.Image)
        Me.btnConfDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConfDel.Name = "btnConfDel"
        Me.btnConfDel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.btnConfDel.Size = New System.Drawing.Size(149, 22)
        Me.btnConfDel.Text = "Eliminar Conferencia"
        Me.btnConfDel.ToolTipText = "Eliminar Conferencia"
        '
        'tabPagDep
        '
        Me.tabPagDep.Controls.Add(Me.SplitContainer4)
        Me.tabPagDep.Controls.Add(Me.ToolStripDep)
        Me.tabPagDep.Location = New System.Drawing.Point(4, 22)
        Me.tabPagDep.Name = "tabPagDep"
        Me.tabPagDep.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPagDep.Size = New System.Drawing.Size(808, 373)
        Me.tabPagDep.TabIndex = 4
        Me.tabPagDep.Text = "Departamentos"
        Me.tabPagDep.UseVisualStyleBackColor = True
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(3, 28)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.lstBoxDep)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.BackgroundImage = Global.PractLabBBDD.My.Resources.Resources.stack
        Me.SplitContainer4.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer4.Panel2.Controls.Add(Me.grpBoxDepMember)
        Me.SplitContainer4.Panel2.Controls.Add(Me.lblDepNombreTag)
        Me.SplitContainer4.Size = New System.Drawing.Size(802, 342)
        Me.SplitContainer4.SplitterDistance = 265
        Me.SplitContainer4.TabIndex = 3
        '
        'lstBoxDep
        '
        Me.lstBoxDep.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstBoxDep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBoxDep.FormattingEnabled = True
        Me.lstBoxDep.ItemHeight = 16
        Me.lstBoxDep.Location = New System.Drawing.Point(0, 0)
        Me.lstBoxDep.Name = "lstBoxDep"
        Me.lstBoxDep.Size = New System.Drawing.Size(265, 342)
        Me.lstBoxDep.Sorted = True
        Me.lstBoxDep.TabIndex = 0
        '
        'grpBoxDepMember
        '
        Me.grpBoxDepMember.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpBoxDepMember.Controls.Add(Me.lstBoxDepMiembros)
        Me.grpBoxDepMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBoxDepMember.Location = New System.Drawing.Point(8, 63)
        Me.grpBoxDepMember.Name = "grpBoxDepMember"
        Me.grpBoxDepMember.Size = New System.Drawing.Size(305, 274)
        Me.grpBoxDepMember.TabIndex = 19
        Me.grpBoxDepMember.TabStop = False
        Me.grpBoxDepMember.Text = "Miembros:"
        '
        'lstBoxDepMiembros
        '
        Me.lstBoxDepMiembros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstBoxDepMiembros.FormattingEnabled = True
        Me.lstBoxDepMiembros.ItemHeight = 15
        Me.lstBoxDepMiembros.Location = New System.Drawing.Point(3, 17)
        Me.lstBoxDepMiembros.Name = "lstBoxDepMiembros"
        Me.lstBoxDepMiembros.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstBoxDepMiembros.Size = New System.Drawing.Size(299, 254)
        Me.lstBoxDepMiembros.Sorted = True
        Me.lstBoxDepMiembros.TabIndex = 5
        '
        'lblDepNombreTag
        '
        Me.lblDepNombreTag.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDepNombreTag.AutoSize = True
        Me.lblDepNombreTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepNombreTag.Location = New System.Drawing.Point(3, 11)
        Me.lblDepNombreTag.Name = "lblDepNombreTag"
        Me.lblDepNombreTag.Size = New System.Drawing.Size(80, 29)
        Me.lblDepNombreTag.TabIndex = 17
        Me.lblDepNombreTag.Text = "Empty"
        '
        'ToolStripDep
        '
        Me.ToolStripDep.CanOverflow = False
        Me.ToolStripDep.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripDep.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnDepAdd, Me.btnDepEdit, Me.btnDepDel})
        Me.ToolStripDep.Location = New System.Drawing.Point(3, 3)
        Me.ToolStripDep.Name = "ToolStripDep"
        Me.ToolStripDep.Size = New System.Drawing.Size(802, 25)
        Me.ToolStripDep.TabIndex = 2
        Me.ToolStripDep.Text = "ToolStrip3"
        '
        'btnDepAdd
        '
        Me.btnDepAdd.AutoSize = False
        Me.btnDepAdd.Image = CType(resources.GetObject("btnDepAdd.Image"), System.Drawing.Image)
        Me.btnDepAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDepAdd.Name = "btnDepAdd"
        Me.btnDepAdd.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.btnDepAdd.Size = New System.Drawing.Size(149, 22)
        Me.btnDepAdd.Text = "Añadir Departamento"
        Me.btnDepAdd.ToolTipText = "Añadir Departamento"
        '
        'btnDepEdit
        '
        Me.btnDepEdit.AutoSize = False
        Me.btnDepEdit.Image = CType(resources.GetObject("btnDepEdit.Image"), System.Drawing.Image)
        Me.btnDepEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDepEdit.Name = "btnDepEdit"
        Me.btnDepEdit.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.btnDepEdit.Size = New System.Drawing.Size(149, 22)
        Me.btnDepEdit.Text = "Editar Departamento"
        Me.btnDepEdit.ToolTipText = "Editar Departamento"
        '
        'btnDepDel
        '
        Me.btnDepDel.AutoSize = False
        Me.btnDepDel.Image = CType(resources.GetObject("btnDepDel.Image"), System.Drawing.Image)
        Me.btnDepDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDepDel.Name = "btnDepDel"
        Me.btnDepDel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.btnDepDel.Size = New System.Drawing.Size(149, 22)
        Me.btnDepDel.Text = "Eliminar Departamento"
        Me.btnDepDel.ToolTipText = "Eliminar Departamento"
        '
        'tabPagArts
        '
        Me.tabPagArts.Controls.Add(Me.SplitContainer2)
        Me.tabPagArts.Controls.Add(Me.ToolStripArts)
        Me.tabPagArts.Location = New System.Drawing.Point(4, 22)
        Me.tabPagArts.Name = "tabPagArts"
        Me.tabPagArts.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPagArts.Size = New System.Drawing.Size(808, 373)
        Me.tabPagArts.TabIndex = 5
        Me.tabPagArts.Text = "Artículos"
        Me.tabPagArts.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 28)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.lstBoxArts)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.BackgroundImage = Global.PractLabBBDD.My.Resources.Resources.stack
        Me.SplitContainer2.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer2.Panel2.Controls.Add(Me.grpBoxAutores)
        Me.SplitContainer2.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lblArtTituloTag)
        Me.SplitContainer2.Size = New System.Drawing.Size(802, 342)
        Me.SplitContainer2.SplitterDistance = 265
        Me.SplitContainer2.TabIndex = 3
        '
        'lstBoxArts
        '
        Me.lstBoxArts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstBoxArts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBoxArts.FormattingEnabled = True
        Me.lstBoxArts.ItemHeight = 16
        Me.lstBoxArts.Location = New System.Drawing.Point(0, 0)
        Me.lstBoxArts.Name = "lstBoxArts"
        Me.lstBoxArts.Size = New System.Drawing.Size(265, 342)
        Me.lstBoxArts.TabIndex = 1
        '
        'grpBoxAutores
        '
        Me.grpBoxAutores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpBoxAutores.Controls.Add(Me.lstBoxAutores)
        Me.grpBoxAutores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBoxAutores.Location = New System.Drawing.Point(8, 143)
        Me.grpBoxAutores.Name = "grpBoxAutores"
        Me.grpBoxAutores.Size = New System.Drawing.Size(305, 194)
        Me.grpBoxAutores.TabIndex = 20
        Me.grpBoxAutores.TabStop = False
        Me.grpBoxAutores.Text = "Autores"
        '
        'lstBoxAutores
        '
        Me.lstBoxAutores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstBoxAutores.FormattingEnabled = True
        Me.lstBoxAutores.ItemHeight = 15
        Me.lstBoxAutores.Location = New System.Drawing.Point(3, 17)
        Me.lstBoxAutores.Name = "lstBoxAutores"
        Me.lstBoxAutores.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstBoxAutores.Size = New System.Drawing.Size(299, 174)
        Me.lstBoxAutores.TabIndex = 5
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblArtID, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblArtConf, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblArtPags, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblArtConfTag, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblArtPagsTag, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblArtIDTag, 1, 1)
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(8, 43)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(524, 94)
        Me.TableLayoutPanel2.TabIndex = 19
        '
        'lblArtID
        '
        Me.lblArtID.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblArtID.AutoSize = True
        Me.lblArtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtID.Location = New System.Drawing.Point(52, 38)
        Me.lblArtID.Name = "lblArtID"
        Me.lblArtID.Size = New System.Drawing.Size(31, 16)
        Me.lblArtID.TabIndex = 0
        Me.lblArtID.Text = "#ID:"
        Me.lblArtID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblArtConf
        '
        Me.lblArtConf.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblArtConf.AutoSize = True
        Me.lblArtConf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtConf.Location = New System.Drawing.Point(3, 7)
        Me.lblArtConf.Name = "lblArtConf"
        Me.lblArtConf.Size = New System.Drawing.Size(80, 16)
        Me.lblArtConf.TabIndex = 3
        Me.lblArtConf.Text = "Conferencia"
        Me.lblArtConf.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblArtPags
        '
        Me.lblArtPags.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblArtPags.AutoSize = True
        Me.lblArtPags.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtPags.Location = New System.Drawing.Point(56, 70)
        Me.lblArtPags.Name = "lblArtPags"
        Me.lblArtPags.Size = New System.Drawing.Size(27, 16)
        Me.lblArtPags.TabIndex = 2
        Me.lblArtPags.Text = "pp."
        Me.lblArtPags.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblArtConfTag
        '
        Me.lblArtConfTag.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblArtConfTag.AutoSize = True
        Me.lblArtConfTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtConfTag.Location = New System.Drawing.Point(89, 7)
        Me.lblArtConfTag.Name = "lblArtConfTag"
        Me.lblArtConfTag.Size = New System.Drawing.Size(45, 16)
        Me.lblArtConfTag.TabIndex = 13
        Me.lblArtConfTag.Text = "empty"
        Me.lblArtConfTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblArtPagsTag
        '
        Me.lblArtPagsTag.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblArtPagsTag.AutoSize = True
        Me.lblArtPagsTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtPagsTag.Location = New System.Drawing.Point(89, 70)
        Me.lblArtPagsTag.Name = "lblArtPagsTag"
        Me.lblArtPagsTag.Size = New System.Drawing.Size(45, 16)
        Me.lblArtPagsTag.TabIndex = 12
        Me.lblArtPagsTag.Text = "empty"
        Me.lblArtPagsTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblArtIDTag
        '
        Me.lblArtIDTag.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblArtIDTag.AutoSize = True
        Me.lblArtIDTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtIDTag.Location = New System.Drawing.Point(89, 38)
        Me.lblArtIDTag.Name = "lblArtIDTag"
        Me.lblArtIDTag.Size = New System.Drawing.Size(45, 16)
        Me.lblArtIDTag.TabIndex = 11
        Me.lblArtIDTag.Text = "empty"
        Me.lblArtIDTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblArtTituloTag
        '
        Me.lblArtTituloTag.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblArtTituloTag.AutoSize = True
        Me.lblArtTituloTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtTituloTag.Location = New System.Drawing.Point(3, 11)
        Me.lblArtTituloTag.Name = "lblArtTituloTag"
        Me.lblArtTituloTag.Size = New System.Drawing.Size(80, 29)
        Me.lblArtTituloTag.TabIndex = 18
        Me.lblArtTituloTag.Text = "Empty"
        '
        'ToolStripArts
        '
        Me.ToolStripArts.CanOverflow = False
        Me.ToolStripArts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripArts.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnArtAdd, Me.btnArtEdit, Me.btnArtDel})
        Me.ToolStripArts.Location = New System.Drawing.Point(3, 3)
        Me.ToolStripArts.Name = "ToolStripArts"
        Me.ToolStripArts.Size = New System.Drawing.Size(802, 25)
        Me.ToolStripArts.TabIndex = 2
        Me.ToolStripArts.Text = "ToolStrip3"
        '
        'btnArtAdd
        '
        Me.btnArtAdd.AutoSize = False
        Me.btnArtAdd.Image = Global.PractLabBBDD.My.Resources.Resources.add
        Me.btnArtAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnArtAdd.Name = "btnArtAdd"
        Me.btnArtAdd.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.btnArtAdd.Size = New System.Drawing.Size(149, 22)
        Me.btnArtAdd.Text = "Añadir Artículo"
        Me.btnArtAdd.ToolTipText = "Añadir Artículo"
        '
        'btnArtEdit
        '
        Me.btnArtEdit.AutoSize = False
        Me.btnArtEdit.Image = CType(resources.GetObject("btnArtEdit.Image"), System.Drawing.Image)
        Me.btnArtEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnArtEdit.Name = "btnArtEdit"
        Me.btnArtEdit.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.btnArtEdit.Size = New System.Drawing.Size(149, 22)
        Me.btnArtEdit.Text = "Editar Artículo"
        '
        'btnArtDel
        '
        Me.btnArtDel.AutoSize = False
        Me.btnArtDel.Image = CType(resources.GetObject("btnArtDel.Image"), System.Drawing.Image)
        Me.btnArtDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnArtDel.Name = "btnArtDel"
        Me.btnArtDel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.btnArtDel.Size = New System.Drawing.Size(149, 22)
        Me.btnArtDel.Text = "Eliminar Artículo"
        Me.btnArtDel.ToolTipText = "Eliminar Artículo"
        '
        'stripPanAyuda
        '
        Me.stripPanAyuda.Location = New System.Drawing.Point(0, 0)
        Me.stripPanAyuda.Name = "stripPanAyuda"
        Me.stripPanAyuda.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.stripPanAyuda.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.stripPanAyuda.Size = New System.Drawing.Size(0, 0)
        '
        'stripPanTopAyuda
        '
        Me.stripPanTopAyuda.Location = New System.Drawing.Point(0, 0)
        Me.stripPanTopAyuda.Name = "stripPanTopAyuda"
        Me.stripPanTopAyuda.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.stripPanTopAyuda.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.stripPanTopAyuda.Size = New System.Drawing.Size(0, 0)
        '
        'stripPanRightInvest
        '
        Me.stripPanRightInvest.Location = New System.Drawing.Point(0, 0)
        Me.stripPanRightInvest.Name = "stripPanRightInvest"
        Me.stripPanRightInvest.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.stripPanRightInvest.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.stripPanRightInvest.Size = New System.Drawing.Size(0, 0)
        '
        'stripPanLeftInvest
        '
        Me.stripPanLeftInvest.Location = New System.Drawing.Point(0, 0)
        Me.stripPanLeftInvest.Name = "stripPanLeftInvest"
        Me.stripPanLeftInvest.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.stripPanLeftInvest.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.stripPanLeftInvest.Size = New System.Drawing.Size(0, 0)
        '
        'stripCntPanInvestigadores
        '
        Me.stripCntPanInvestigadores.Size = New System.Drawing.Size(907, 163)
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 399)
        Me.Controls.Add(Me.tabControl)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestor de Curricula"
        Me.tabControl.ResumeLayout(False)
        Me.tabPagInvest.ResumeLayout(False)
        Me.tabPagInvest.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.grpBoxInvestAsisteA.ResumeLayout(False)
        Me.lyPanInvestigadores.ResumeLayout(False)
        Me.lyPanInvestigadores.PerformLayout()
        Me.ToolStripInvest.ResumeLayout(False)
        Me.ToolStripInvest.PerformLayout()
        Me.tabPagConf.ResumeLayout(False)
        Me.tabPagConf.PerformLayout()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.PerformLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.grpBoxConfAsistentes.ResumeLayout(False)
        Me.ToolStripConfs.ResumeLayout(False)
        Me.ToolStripConfs.PerformLayout()
        Me.tabPagDep.ResumeLayout(False)
        Me.tabPagDep.PerformLayout()
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.Panel2.PerformLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.grpBoxDepMember.ResumeLayout(False)
        Me.ToolStripDep.ResumeLayout(False)
        Me.ToolStripDep.PerformLayout()
        Me.tabPagArts.ResumeLayout(False)
        Me.tabPagArts.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.grpBoxAutores.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ToolStripArts.ResumeLayout(False)
        Me.ToolStripArts.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabControl As System.Windows.Forms.TabControl
    Friend WithEvents stripPanAyuda As System.Windows.Forms.ToolStripPanel
    Friend WithEvents stripPanTopAyuda As System.Windows.Forms.ToolStripPanel
    Friend WithEvents stripPanRightInvest As System.Windows.Forms.ToolStripPanel
    Friend WithEvents stripPanLeftInvest As System.Windows.Forms.ToolStripPanel
    Friend WithEvents stripCntPanInvestigadores As System.Windows.Forms.ToolStripContentPanel
    Friend WithEvents tabPagInvest As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents grpBoxInvestAsisteA As System.Windows.Forms.GroupBox
    Friend WithEvents lstBoxInvestAsistencia As System.Windows.Forms.ListBox
    Friend WithEvents lyPanInvestigadores As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblInvestMailTag As System.Windows.Forms.Label
    Friend WithEvents lblInvestID As System.Windows.Forms.Label
    Friend WithEvents lblInvestEdificio As System.Windows.Forms.Label
    Friend WithEvents lblInvestTelefono As System.Windows.Forms.Label
    Friend WithEvents lblInvestDepartamento As System.Windows.Forms.Label
    Friend WithEvents lblInvestDespacho As System.Windows.Forms.Label
    Friend WithEvents lblInvestEmail As System.Windows.Forms.Label
    Friend WithEvents lblInvestIDTag As System.Windows.Forms.Label
    Friend WithEvents lblInvestEdificioTag As System.Windows.Forms.Label
    Friend WithEvents lblInvestTelfTag As System.Windows.Forms.Label
    Friend WithEvents lblInvestDepTag As System.Windows.Forms.Label
    Friend WithEvents lblInvestDespachoTag As System.Windows.Forms.Label
    Friend WithEvents lblInvestNombreTag As System.Windows.Forms.Label
    Friend WithEvents ToolStripInvest As System.Windows.Forms.ToolStrip
    Friend WithEvents btnInvestAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnInvestEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnInvestDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents stripSep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnInvestGetCurriculum As System.Windows.Forms.ToolStripButton
    Friend WithEvents lstBoxInvest As System.Windows.Forms.ListBox
    Friend WithEvents tabPagConf As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents lstBoxConfs As System.Windows.Forms.ListBox
    Friend WithEvents calendarConferencias As System.Windows.Forms.MonthCalendar
    Friend WithEvents grpBoxConfAsistentes As System.Windows.Forms.GroupBox
    Friend WithEvents lstBoxConfAsistencia As System.Windows.Forms.ListBox
    Friend WithEvents lblConfFechaFinTag As System.Windows.Forms.Label
    Friend WithEvents lblConfFechaInicioTag As System.Windows.Forms.Label
    Friend WithEvents lblConfLugarTag As System.Windows.Forms.Label
    Friend WithEvents lblConfLugar As System.Windows.Forms.Label
    Friend WithEvents lblConfFechaInicio As System.Windows.Forms.Label
    Friend WithEvents lblConfFechaFin As System.Windows.Forms.Label
    Friend WithEvents ToolStripConfs As System.Windows.Forms.ToolStrip
    Friend WithEvents btnConfAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnConfEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnConfDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblConfNombreTag As System.Windows.Forms.Label
    Friend WithEvents tabPagDep As System.Windows.Forms.TabPage
    Friend WithEvents tabPagArts As System.Windows.Forms.TabPage
    Friend WithEvents ToolStripDep As System.Windows.Forms.ToolStrip
    Friend WithEvents btnDepAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDepEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDepDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripArts As System.Windows.Forms.ToolStrip
    Friend WithEvents btnArtAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnArtEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnArtDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents lstBoxDep As System.Windows.Forms.ListBox
    Friend WithEvents lstBoxArts As System.Windows.Forms.ListBox
    Friend WithEvents lblDepNombreTag As System.Windows.Forms.Label
    Friend WithEvents grpBoxDepMember As System.Windows.Forms.GroupBox
    Friend WithEvents lstBoxDepMiembros As System.Windows.Forms.ListBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblArtTituloTag As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblArtID As System.Windows.Forms.Label
    Friend WithEvents lblArtPags As System.Windows.Forms.Label
    Friend WithEvents lblArtConf As System.Windows.Forms.Label
    Friend WithEvents lblArtIDTag As System.Windows.Forms.Label
    Friend WithEvents lblArtPagsTag As System.Windows.Forms.Label
    Friend WithEvents lblArtConfTag As System.Windows.Forms.Label
    Friend WithEvents grpBoxAutores As System.Windows.Forms.GroupBox
    Friend WithEvents lstBoxAutores As System.Windows.Forms.ListBox
    Friend WithEvents lblFirma As System.Windows.Forms.ToolStripLabel

End Class

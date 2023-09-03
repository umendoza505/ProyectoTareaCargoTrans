<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrincipalEstadoTarea
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrincipalEstadoTarea))
        Me.pnlFiltros = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btnBuscar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.msNuevaTarea = New System.Windows.Forms.MenuStrip()
        Me.btnNuevaTarea = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.gpbTarea = New System.Windows.Forms.GroupBox()
        Me.lbltarea = New System.Windows.Forms.Label()
        Me.txtIDTarea = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cbActivos = New System.Windows.Forms.ComboBox()
        Me.lblAsignado = New System.Windows.Forms.Label()
        Me.cbAsigando = New System.Windows.Forms.ComboBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.lblBusqueda = New System.Windows.Forms.Label()
        Me.txtBusquedaTarea = New System.Windows.Forms.TextBox()
        Me.ptRellenoBusqueda = New System.Windows.Forms.PictureBox()
        Me.ptSombreadoBusqueda = New System.Windows.Forms.PictureBox()
        Me.pnlDivisor = New System.Windows.Forms.Panel()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.btnEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.btnEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.pnlContendorGrid = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtgTarea = New System.Windows.Forms.DataGridView()
        Me.FechaCreacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tareaID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estadoTarea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tituloTarea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuarioNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descTarea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.pnlFiltros.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.msNuevaTarea.SuspendLayout()
        Me.gpbTarea.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptRellenoBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptSombreadoBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        Me.MenuStrip3.SuspendLayout()
        Me.pnlContendorGrid.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgTarea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlFiltros
        '
        Me.pnlFiltros.BackColor = System.Drawing.Color.White
        Me.pnlFiltros.Controls.Add(Me.MenuStrip1)
        Me.pnlFiltros.Controls.Add(Me.msNuevaTarea)
        Me.pnlFiltros.Controls.Add(Me.gpbTarea)
        Me.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFiltros.Location = New System.Drawing.Point(0, 0)
        Me.pnlFiltros.Name = "pnlFiltros"
        Me.pnlFiltros.Size = New System.Drawing.Size(891, 204)
        Me.pnlFiltros.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.ToolStripSeparator2})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(488, 161)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.ShowItemToolTips = True
        Me.MenuStrip1.Size = New System.Drawing.Size(113, 39)
        Me.MenuStrip1.TabIndex = 544
        Me.MenuStrip1.Text = "menuStrip1"
        '
        'btnBuscar
        '
        Me.btnBuscar.AutoSize = False
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 30)
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.ToolTipText = "Buscar Tarea"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.BackColor = System.Drawing.Color.Maroon
        Me.ToolStripSeparator2.ForeColor = System.Drawing.Color.Maroon
        Me.ToolStripSeparator2.MergeIndex = 2
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(1, 40)
        '
        'msNuevaTarea
        '
        Me.msNuevaTarea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.msNuevaTarea.AutoSize = False
        Me.msNuevaTarea.BackColor = System.Drawing.Color.Transparent
        Me.msNuevaTarea.Dock = System.Windows.Forms.DockStyle.None
        Me.msNuevaTarea.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevaTarea, Me.toolStripSeparator1})
        Me.msNuevaTarea.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.msNuevaTarea.Location = New System.Drawing.Point(601, 161)
        Me.msNuevaTarea.Name = "msNuevaTarea"
        Me.msNuevaTarea.ShowItemToolTips = True
        Me.msNuevaTarea.Size = New System.Drawing.Size(142, 39)
        Me.msNuevaTarea.TabIndex = 543
        Me.msNuevaTarea.Text = "menuStrip1"
        '
        'btnNuevaTarea
        '
        Me.btnNuevaTarea.AutoSize = False
        Me.btnNuevaTarea.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnNuevaTarea.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnNuevaTarea.ForeColor = System.Drawing.Color.White
        Me.btnNuevaTarea.Name = "btnNuevaTarea"
        Me.btnNuevaTarea.Size = New System.Drawing.Size(130, 30)
        Me.btnNuevaTarea.Text = "Nueva Tarea"
        Me.btnNuevaTarea.ToolTipText = "Crea una Nueva tarea"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.AutoSize = False
        Me.toolStripSeparator1.BackColor = System.Drawing.Color.Maroon
        Me.toolStripSeparator1.ForeColor = System.Drawing.Color.Maroon
        Me.toolStripSeparator1.MergeIndex = 2
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(1, 40)
        '
        'gpbTarea
        '
        Me.gpbTarea.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpbTarea.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gpbTarea.Controls.Add(Me.lbltarea)
        Me.gpbTarea.Controls.Add(Me.txtIDTarea)
        Me.gpbTarea.Controls.Add(Me.PictureBox1)
        Me.gpbTarea.Controls.Add(Me.PictureBox2)
        Me.gpbTarea.Controls.Add(Me.cbActivos)
        Me.gpbTarea.Controls.Add(Me.lblAsignado)
        Me.gpbTarea.Controls.Add(Me.cbAsigando)
        Me.gpbTarea.Controls.Add(Me.lblEstado)
        Me.gpbTarea.Controls.Add(Me.cbEstado)
        Me.gpbTarea.Controls.Add(Me.lblBusqueda)
        Me.gpbTarea.Controls.Add(Me.txtBusquedaTarea)
        Me.gpbTarea.Controls.Add(Me.ptRellenoBusqueda)
        Me.gpbTarea.Controls.Add(Me.ptSombreadoBusqueda)
        Me.gpbTarea.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbTarea.Location = New System.Drawing.Point(142, 12)
        Me.gpbTarea.Name = "gpbTarea"
        Me.gpbTarea.Size = New System.Drawing.Size(601, 146)
        Me.gpbTarea.TabIndex = 0
        Me.gpbTarea.TabStop = False
        Me.gpbTarea.Text = "Busqueda Tarea"
        '
        'lbltarea
        '
        Me.lbltarea.AutoSize = True
        Me.lbltarea.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltarea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbltarea.Location = New System.Drawing.Point(94, 38)
        Me.lbltarea.Name = "lbltarea"
        Me.lbltarea.Size = New System.Drawing.Size(71, 17)
        Me.lbltarea.TabIndex = 16
        Me.lbltarea.Text = "No. Tarea:"
        '
        'txtIDTarea
        '
        Me.txtIDTarea.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIDTarea.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIDTarea.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDTarea.Location = New System.Drawing.Point(97, 58)
        Me.txtIDTarea.Name = "txtIDTarea"
        Me.txtIDTarea.Size = New System.Drawing.Size(118, 18)
        Me.txtIDTarea.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(76, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(146, 29)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(74, 50)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(150, 33)
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'cbActivos
        '
        Me.cbActivos.BackColor = System.Drawing.Color.White
        Me.cbActivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbActivos.FormattingEnabled = True
        Me.cbActivos.Location = New System.Drawing.Point(358, 19)
        Me.cbActivos.Name = "cbActivos"
        Me.cbActivos.Size = New System.Drawing.Size(165, 25)
        Me.cbActivos.TabIndex = 12
        '
        'lblAsignado
        '
        Me.lblAsignado.AutoSize = True
        Me.lblAsignado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsignado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAsignado.Location = New System.Drawing.Point(265, 86)
        Me.lblAsignado.Name = "lblAsignado"
        Me.lblAsignado.Size = New System.Drawing.Size(70, 17)
        Me.lblAsignado.TabIndex = 11
        Me.lblAsignado.Text = "Asignado:"
        '
        'cbAsigando
        '
        Me.cbAsigando.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAsigando.FormattingEnabled = True
        Me.cbAsigando.Location = New System.Drawing.Point(266, 106)
        Me.cbAsigando.Name = "cbAsigando"
        Me.cbAsigando.Size = New System.Drawing.Size(261, 25)
        Me.cbAsigando.TabIndex = 10
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEstado.Location = New System.Drawing.Point(73, 86)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(53, 17)
        Me.lblEstado.TabIndex = 9
        Me.lblEstado.Text = "Estado:"
        '
        'cbEstado
        '
        Me.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Location = New System.Drawing.Point(76, 106)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(184, 25)
        Me.cbEstado.TabIndex = 8
        '
        'lblBusqueda
        '
        Me.lblBusqueda.AutoSize = True
        Me.lblBusqueda.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusqueda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblBusqueda.Location = New System.Drawing.Point(249, 38)
        Me.lblBusqueda.Name = "lblBusqueda"
        Me.lblBusqueda.Size = New System.Drawing.Size(86, 17)
        Me.lblBusqueda.TabIndex = 7
        Me.lblBusqueda.Text = "Titulo Tarea:"
        '
        'txtBusquedaTarea
        '
        Me.txtBusquedaTarea.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusquedaTarea.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBusquedaTarea.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusquedaTarea.Location = New System.Drawing.Point(252, 58)
        Me.txtBusquedaTarea.Name = "txtBusquedaTarea"
        Me.txtBusquedaTarea.Size = New System.Drawing.Size(264, 18)
        Me.txtBusquedaTarea.TabIndex = 5
        '
        'ptRellenoBusqueda
        '
        Me.ptRellenoBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ptRellenoBusqueda.BackColor = System.Drawing.Color.White
        Me.ptRellenoBusqueda.Location = New System.Drawing.Point(231, 52)
        Me.ptRellenoBusqueda.Name = "ptRellenoBusqueda"
        Me.ptRellenoBusqueda.Size = New System.Drawing.Size(292, 29)
        Me.ptRellenoBusqueda.TabIndex = 4
        Me.ptRellenoBusqueda.TabStop = False
        '
        'ptSombreadoBusqueda
        '
        Me.ptSombreadoBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ptSombreadoBusqueda.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ptSombreadoBusqueda.Location = New System.Drawing.Point(229, 50)
        Me.ptSombreadoBusqueda.Name = "ptSombreadoBusqueda"
        Me.ptSombreadoBusqueda.Size = New System.Drawing.Size(296, 33)
        Me.ptSombreadoBusqueda.TabIndex = 6
        Me.ptSombreadoBusqueda.TabStop = False
        '
        'pnlDivisor
        '
        Me.pnlDivisor.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlDivisor.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDivisor.Location = New System.Drawing.Point(0, 204)
        Me.pnlDivisor.Name = "pnlDivisor"
        Me.pnlDivisor.Size = New System.Drawing.Size(891, 2)
        Me.pnlDivisor.TabIndex = 1
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip2.AutoSize = False
        Me.MenuStrip2.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEditar, Me.ToolStripSeparator3})
        Me.MenuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip2.Location = New System.Drawing.Point(519, 301)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.ShowItemToolTips = True
        Me.MenuStrip2.Size = New System.Drawing.Size(111, 39)
        Me.MenuStrip2.TabIndex = 545
        Me.MenuStrip2.Text = "menuStrip1"
        '
        'btnEditar
        '
        Me.btnEditar.AutoSize = False
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnEditar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(100, 30)
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.ToolTipText = "Edita la tarea Seleccionada"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.AutoSize = False
        Me.ToolStripSeparator3.BackColor = System.Drawing.Color.Maroon
        Me.ToolStripSeparator3.ForeColor = System.Drawing.Color.Maroon
        Me.ToolStripSeparator3.MergeIndex = 2
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(1, 40)
        '
        'MenuStrip3
        '
        Me.MenuStrip3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip3.AutoSize = False
        Me.MenuStrip3.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEliminar, Me.ToolStripSeparator4})
        Me.MenuStrip3.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip3.Location = New System.Drawing.Point(630, 301)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.ShowItemToolTips = True
        Me.MenuStrip3.Size = New System.Drawing.Size(113, 39)
        Me.MenuStrip3.TabIndex = 546
        Me.MenuStrip3.Text = "menuStrip1"
        '
        'btnEliminar
        '
        Me.btnEliminar.AutoSize = False
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 30)
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.ToolTipText = "Elimina Tarea seleccionada"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.AutoSize = False
        Me.ToolStripSeparator4.BackColor = System.Drawing.Color.Maroon
        Me.ToolStripSeparator4.ForeColor = System.Drawing.Color.Maroon
        Me.ToolStripSeparator4.MergeIndex = 2
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(1, 40)
        '
        'pnlContendorGrid
        '
        Me.pnlContendorGrid.BackColor = System.Drawing.Color.White
        Me.pnlContendorGrid.Controls.Add(Me.GroupBox1)
        Me.pnlContendorGrid.Controls.Add(Me.MenuStrip3)
        Me.pnlContendorGrid.Controls.Add(Me.MenuStrip2)
        Me.pnlContendorGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContendorGrid.Location = New System.Drawing.Point(0, 206)
        Me.pnlContendorGrid.Name = "pnlContendorGrid"
        Me.pnlContendorGrid.Size = New System.Drawing.Size(891, 340)
        Me.pnlContendorGrid.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.dtgTarea)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(142, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(601, 291)
        Me.GroupBox1.TabIndex = 548
        Me.GroupBox1.TabStop = False
        '
        'dtgTarea
        '
        Me.dtgTarea.AllowUserToAddRows = False
        Me.dtgTarea.AllowUserToDeleteRows = False
        Me.dtgTarea.AllowUserToResizeColumns = False
        Me.dtgTarea.AllowUserToResizeRows = False
        Me.dtgTarea.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgTarea.BackgroundColor = System.Drawing.Color.White
        Me.dtgTarea.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgTarea.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtgTarea.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgTarea.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgTarea.ColumnHeadersHeight = 25
        Me.dtgTarea.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaCreacion, Me.tareaID, Me.estadoTarea, Me.tituloTarea, Me.usuarioNombre, Me.descTarea})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgTarea.DefaultCellStyle = DataGridViewCellStyle5
        Me.dtgTarea.EnableHeadersVisualStyles = False
        Me.dtgTarea.GridColor = System.Drawing.Color.Silver
        Me.dtgTarea.Location = New System.Drawing.Point(6, 14)
        Me.dtgTarea.Name = "dtgTarea"
        Me.dtgTarea.ReadOnly = True
        Me.dtgTarea.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgTarea.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dtgTarea.RowHeadersVisible = False
        Me.dtgTarea.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        Me.dtgTarea.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dtgTarea.RowTemplate.Height = 30
        Me.dtgTarea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgTarea.Size = New System.Drawing.Size(589, 271)
        Me.dtgTarea.TabIndex = 547
        '
        'FechaCreacion
        '
        Me.FechaCreacion.DataPropertyName = "FechaCreacion"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FechaCreacion.DefaultCellStyle = DataGridViewCellStyle2
        Me.FechaCreacion.HeaderText = "Fecha Creacion"
        Me.FechaCreacion.Name = "FechaCreacion"
        Me.FechaCreacion.ReadOnly = True
        Me.FechaCreacion.Width = 120
        '
        'tareaID
        '
        Me.tareaID.DataPropertyName = "TareaID"
        Me.tareaID.HeaderText = "No. Tarea"
        Me.tareaID.Name = "tareaID"
        Me.tareaID.ReadOnly = True
        Me.tareaID.Width = 80
        '
        'estadoTarea
        '
        Me.estadoTarea.DataPropertyName = "NombreEstado"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.estadoTarea.DefaultCellStyle = DataGridViewCellStyle3
        Me.estadoTarea.HeaderText = "Estado"
        Me.estadoTarea.Name = "estadoTarea"
        Me.estadoTarea.ReadOnly = True
        Me.estadoTarea.Width = 120
        '
        'tituloTarea
        '
        Me.tituloTarea.DataPropertyName = "TituloTarea"
        Me.tituloTarea.HeaderText = "Titulo"
        Me.tituloTarea.Name = "tituloTarea"
        Me.tituloTarea.ReadOnly = True
        Me.tituloTarea.Width = 200
        '
        'usuarioNombre
        '
        Me.usuarioNombre.DataPropertyName = "NombreUsuario"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.usuarioNombre.DefaultCellStyle = DataGridViewCellStyle4
        Me.usuarioNombre.HeaderText = "Asignacion"
        Me.usuarioNombre.Name = "usuarioNombre"
        Me.usuarioNombre.ReadOnly = True
        Me.usuarioNombre.Width = 200
        '
        'descTarea
        '
        Me.descTarea.DataPropertyName = "DescripcionTarea"
        Me.descTarea.HeaderText = "Descripcion"
        Me.descTarea.Name = "descTarea"
        Me.descTarea.ReadOnly = True
        Me.descTarea.Visible = False
        '
        'PrincipalEstadoTarea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 546)
        Me.Controls.Add(Me.pnlContendorGrid)
        Me.Controls.Add(Me.pnlDivisor)
        Me.Controls.Add(Me.pnlFiltros)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(907, 585)
        Me.MinimumSize = New System.Drawing.Size(907, 585)
        Me.Name = "PrincipalEstadoTarea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estatus Tarea"
        Me.pnlFiltros.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.msNuevaTarea.ResumeLayout(False)
        Me.msNuevaTarea.PerformLayout()
        Me.gpbTarea.ResumeLayout(False)
        Me.gpbTarea.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptRellenoBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptSombreadoBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        Me.pnlContendorGrid.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dtgTarea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlFiltros As Panel
    Friend WithEvents pnlDivisor As Panel
    Friend WithEvents gpbTarea As GroupBox
    Private WithEvents lblBusqueda As Label
    Private WithEvents txtBusquedaTarea As TextBox
    Private WithEvents ptRellenoBusqueda As PictureBox
    Private WithEvents ptSombreadoBusqueda As PictureBox
    Private WithEvents lblAsignado As Label
    Private WithEvents cbAsigando As ComboBox
    Private WithEvents lblEstado As Label
    Private WithEvents cbEstado As ComboBox
    Private WithEvents cbActivos As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Public WithEvents btnBuscar As ToolStripMenuItem
    Public WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents msNuevaTarea As MenuStrip
    Public WithEvents btnNuevaTarea As ToolStripMenuItem
    Public WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents MenuStrip2 As MenuStrip
    Public WithEvents btnEditar As ToolStripMenuItem
    Public WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents MenuStrip3 As MenuStrip
    Public WithEvents btnEliminar As ToolStripMenuItem
    Public WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents pnlContendorGrid As Panel
    Private WithEvents dtgTarea As DataGridView
    Private WithEvents lbltarea As Label
    Private WithEvents txtIDTarea As TextBox
    Private WithEvents PictureBox1 As PictureBox
    Private WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents FechaCreacion As DataGridViewTextBoxColumn
    Friend WithEvents tareaID As DataGridViewTextBoxColumn
    Friend WithEvents estadoTarea As DataGridViewTextBoxColumn
    Friend WithEvents tituloTarea As DataGridViewTextBoxColumn
    Friend WithEvents usuarioNombre As DataGridViewTextBoxColumn
    Friend WithEvents descTarea As DataGridViewTextBoxColumn
End Class

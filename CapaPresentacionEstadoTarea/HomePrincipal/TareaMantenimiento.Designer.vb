<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TareaMantenimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TareaMantenimiento))
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblDescripcionTitulo = New System.Windows.Forms.Label()
        Me.txtDescrpTarea = New System.Windows.Forms.TextBox()
        Me.lblTituloTarea = New System.Windows.Forms.Label()
        Me.txtTituloTarea = New System.Windows.Forms.TextBox()
        Me.lblIDTarea = New System.Windows.Forms.Label()
        Me.txtIDTarea = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.lblAsignado = New System.Windows.Forms.Label()
        Me.cbAsigando = New System.Windows.Forms.ComboBox()
        Me.gpbAccion = New System.Windows.Forms.GroupBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEstadoActual = New System.Windows.Forms.Label()
        Me.icEliminado = New System.Windows.Forms.PictureBox()
        Me.icCreado = New System.Windows.Forms.PictureBox()
        Me.icSuspendido = New System.Windows.Forms.PictureBox()
        Me.icProcesado = New System.Windows.Forms.PictureBox()
        Me.icCompleto = New System.Windows.Forms.PictureBox()
        Me.icNuevo = New System.Windows.Forms.PictureBox()
        Me.lblFechaCreado = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblUsuarioAsignado = New System.Windows.Forms.Label()
        Me.menuStrip1.SuspendLayout()
        Me.gpbAccion.SuspendLayout()
        CType(Me.icEliminado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icCreado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icSuspendido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icProcesado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icCompleto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuStrip1
        '
        Me.menuStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.menuStrip1.AutoSize = False
        Me.menuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.menuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGuardar, Me.toolStripSeparator1})
        Me.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.menuStrip1.Location = New System.Drawing.Point(343, 11)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.ShowItemToolTips = True
        Me.menuStrip1.Size = New System.Drawing.Size(93, 34)
        Me.menuStrip1.TabIndex = 598
        Me.menuStrip1.Text = "menuStrip1"
        '
        'btnGuardar
        '
        Me.btnGuardar.AutoSize = False
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(80, 30)
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.ToolTipText = "Guardar Nueva Area"
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
        'lblDescripcionTitulo
        '
        Me.lblDescripcionTitulo.AutoSize = True
        Me.lblDescripcionTitulo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDescripcionTitulo.Location = New System.Drawing.Point(16, 158)
        Me.lblDescripcionTitulo.Name = "lblDescripcionTitulo"
        Me.lblDescripcionTitulo.Size = New System.Drawing.Size(75, 15)
        Me.lblDescripcionTitulo.TabIndex = 597
        Me.lblDescripcionTitulo.Text = "Descripcion:"
        '
        'txtDescrpTarea
        '
        Me.txtDescrpTarea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescrpTarea.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescrpTarea.Location = New System.Drawing.Point(14, 174)
        Me.txtDescrpTarea.Multiline = True
        Me.txtDescrpTarea.Name = "txtDescrpTarea"
        Me.txtDescrpTarea.Size = New System.Drawing.Size(423, 70)
        Me.txtDescrpTarea.TabIndex = 596
        '
        'lblTituloTarea
        '
        Me.lblTituloTarea.AutoSize = True
        Me.lblTituloTarea.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloTarea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTituloTarea.Location = New System.Drawing.Point(126, 108)
        Me.lblTituloTarea.Name = "lblTituloTarea"
        Me.lblTituloTarea.Size = New System.Drawing.Size(75, 15)
        Me.lblTituloTarea.TabIndex = 595
        Me.lblTituloTarea.Text = "Titulo Tarea:"
        '
        'txtTituloTarea
        '
        Me.txtTituloTarea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTituloTarea.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTituloTarea.Location = New System.Drawing.Point(124, 124)
        Me.txtTituloTarea.Name = "txtTituloTarea"
        Me.txtTituloTarea.Size = New System.Drawing.Size(313, 29)
        Me.txtTituloTarea.TabIndex = 594
        '
        'lblIDTarea
        '
        Me.lblIDTarea.AutoSize = True
        Me.lblIDTarea.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDTarea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblIDTarea.Location = New System.Drawing.Point(16, 108)
        Me.lblIDTarea.Name = "lblIDTarea"
        Me.lblIDTarea.Size = New System.Drawing.Size(59, 15)
        Me.lblIDTarea.TabIndex = 593
        Me.lblIDTarea.Text = "No Tarea:"
        '
        'txtIDTarea
        '
        Me.txtIDTarea.BackColor = System.Drawing.Color.White
        Me.txtIDTarea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIDTarea.Enabled = False
        Me.txtIDTarea.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDTarea.Location = New System.Drawing.Point(14, 124)
        Me.txtIDTarea.Name = "txtIDTarea"
        Me.txtIDTarea.Size = New System.Drawing.Size(106, 29)
        Me.txtIDTarea.TabIndex = 592
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEstado.Location = New System.Drawing.Point(11, 247)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(53, 17)
        Me.lblEstado.TabIndex = 600
        Me.lblEstado.Text = "Estado:"
        '
        'cbEstado
        '
        Me.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Location = New System.Drawing.Point(14, 267)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(161, 21)
        Me.cbEstado.TabIndex = 599
        '
        'lblAsignado
        '
        Me.lblAsignado.AutoSize = True
        Me.lblAsignado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsignado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAsignado.Location = New System.Drawing.Point(189, 247)
        Me.lblAsignado.Name = "lblAsignado"
        Me.lblAsignado.Size = New System.Drawing.Size(70, 17)
        Me.lblAsignado.TabIndex = 602
        Me.lblAsignado.Text = "Asignado:"
        '
        'cbAsigando
        '
        Me.cbAsigando.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAsigando.FormattingEnabled = True
        Me.cbAsigando.Location = New System.Drawing.Point(192, 267)
        Me.cbAsigando.Name = "cbAsigando"
        Me.cbAsigando.Size = New System.Drawing.Size(245, 21)
        Me.cbAsigando.TabIndex = 601
        '
        'gpbAccion
        '
        Me.gpbAccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpbAccion.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gpbAccion.Controls.Add(Me.menuStrip1)
        Me.gpbAccion.Location = New System.Drawing.Point(5, 304)
        Me.gpbAccion.Name = "gpbAccion"
        Me.gpbAccion.Size = New System.Drawing.Size(442, 50)
        Me.gpbAccion.TabIndex = 603
        Me.gpbAccion.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(5, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(436, 68)
        Me.lblTitulo.TabIndex = 604
        Me.lblTitulo.Text = "Nueva Tarea"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(15, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 605
        Me.Label1.Text = "Estado:"
        '
        'lblEstadoActual
        '
        Me.lblEstadoActual.AutoSize = True
        Me.lblEstadoActual.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoActual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEstadoActual.Location = New System.Drawing.Point(84, 81)
        Me.lblEstadoActual.Name = "lblEstadoActual"
        Me.lblEstadoActual.Size = New System.Drawing.Size(44, 15)
        Me.lblEstadoActual.TabIndex = 606
        Me.lblEstadoActual.Text = "Nuevo"
        '
        'icEliminado
        '
        Me.icEliminado.BackgroundImage = Global.CapaPresentacionEstadoTarea.My.Resources.Resources.bote_de_basura
        Me.icEliminado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.icEliminado.Location = New System.Drawing.Point(64, 79)
        Me.icEliminado.Name = "icEliminado"
        Me.icEliminado.Size = New System.Drawing.Size(18, 20)
        Me.icEliminado.TabIndex = 612
        Me.icEliminado.TabStop = False
        Me.icEliminado.Visible = False
        '
        'icCreado
        '
        Me.icCreado.BackgroundImage = Global.CapaPresentacionEstadoTarea.My.Resources.Resources.crear
        Me.icCreado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.icCreado.Location = New System.Drawing.Point(64, 79)
        Me.icCreado.Name = "icCreado"
        Me.icCreado.Size = New System.Drawing.Size(18, 20)
        Me.icCreado.TabIndex = 611
        Me.icCreado.TabStop = False
        Me.icCreado.Visible = False
        '
        'icSuspendido
        '
        Me.icSuspendido.BackgroundImage = Global.CapaPresentacionEstadoTarea.My.Resources.Resources.cerrar
        Me.icSuspendido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.icSuspendido.Location = New System.Drawing.Point(64, 79)
        Me.icSuspendido.Name = "icSuspendido"
        Me.icSuspendido.Size = New System.Drawing.Size(18, 20)
        Me.icSuspendido.TabIndex = 610
        Me.icSuspendido.TabStop = False
        Me.icSuspendido.Visible = False
        '
        'icProcesado
        '
        Me.icProcesado.BackgroundImage = Global.CapaPresentacionEstadoTarea.My.Resources.Resources.tiempo_de_procesamiento
        Me.icProcesado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.icProcesado.Location = New System.Drawing.Point(64, 79)
        Me.icProcesado.Name = "icProcesado"
        Me.icProcesado.Size = New System.Drawing.Size(18, 20)
        Me.icProcesado.TabIndex = 609
        Me.icProcesado.TabStop = False
        Me.icProcesado.Visible = False
        '
        'icCompleto
        '
        Me.icCompleto.BackgroundImage = Global.CapaPresentacionEstadoTarea.My.Resources.Resources.garrapata
        Me.icCompleto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.icCompleto.Location = New System.Drawing.Point(64, 79)
        Me.icCompleto.Name = "icCompleto"
        Me.icCompleto.Size = New System.Drawing.Size(18, 20)
        Me.icCompleto.TabIndex = 608
        Me.icCompleto.TabStop = False
        Me.icCompleto.Visible = False
        '
        'icNuevo
        '
        Me.icNuevo.BackgroundImage = Global.CapaPresentacionEstadoTarea.My.Resources.Resources.editar_archivo
        Me.icNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.icNuevo.Location = New System.Drawing.Point(64, 79)
        Me.icNuevo.Name = "icNuevo"
        Me.icNuevo.Size = New System.Drawing.Size(18, 20)
        Me.icNuevo.TabIndex = 607
        Me.icNuevo.TabStop = False
        '
        'lblFechaCreado
        '
        Me.lblFechaCreado.AutoSize = True
        Me.lblFechaCreado.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaCreado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFechaCreado.Location = New System.Drawing.Point(364, 81)
        Me.lblFechaCreado.Name = "lblFechaCreado"
        Me.lblFechaCreado.Size = New System.Drawing.Size(73, 15)
        Me.lblFechaCreado.TabIndex = 614
        Me.lblFechaCreado.Text = "10/01/2000"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(278, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 613
        Me.Label4.Text = "Fecha Creado:"
        '
        'lblUsuarioAsignado
        '
        Me.lblUsuarioAsignado.AutoSize = True
        Me.lblUsuarioAsignado.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioAsignado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblUsuarioAsignado.Location = New System.Drawing.Point(278, 96)
        Me.lblUsuarioAsignado.Name = "lblUsuarioAsignado"
        Me.lblUsuarioAsignado.Size = New System.Drawing.Size(44, 15)
        Me.lblUsuarioAsignado.TabIndex = 615
        Me.lblUsuarioAsignado.Text = "Nuevo"
        Me.lblUsuarioAsignado.Visible = False
        '
        'TareaMantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(450, 357)
        Me.Controls.Add(Me.lblUsuarioAsignado)
        Me.Controls.Add(Me.lblFechaCreado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.icEliminado)
        Me.Controls.Add(Me.icCreado)
        Me.Controls.Add(Me.icSuspendido)
        Me.Controls.Add(Me.icProcesado)
        Me.Controls.Add(Me.icCompleto)
        Me.Controls.Add(Me.icNuevo)
        Me.Controls.Add(Me.lblEstadoActual)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.gpbAccion)
        Me.Controls.Add(Me.lblAsignado)
        Me.Controls.Add(Me.cbAsigando)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.cbEstado)
        Me.Controls.Add(Me.lblDescripcionTitulo)
        Me.Controls.Add(Me.txtDescrpTarea)
        Me.Controls.Add(Me.lblTituloTarea)
        Me.Controls.Add(Me.txtTituloTarea)
        Me.Controls.Add(Me.lblIDTarea)
        Me.Controls.Add(Me.txtIDTarea)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(466, 311)
        Me.Name = "TareaMantenimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso Tarea"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.gpbAccion.ResumeLayout(False)
        CType(Me.icEliminado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icCreado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icSuspendido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icProcesado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icCompleto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuStrip1 As MenuStrip
    Public WithEvents toolStripSeparator1 As ToolStripSeparator
    Private WithEvents lblDescripcionTitulo As Label
    Public WithEvents txtDescrpTarea As TextBox
    Private WithEvents lblTituloTarea As Label
    Public WithEvents txtTituloTarea As TextBox
    Private WithEvents lblIDTarea As Label
    Public WithEvents txtIDTarea As TextBox
    Private WithEvents lblEstado As Label
    Private WithEvents lblAsignado As Label
    Friend WithEvents gpbAccion As GroupBox
    Private WithEvents Label1 As Label
    Private WithEvents Label4 As Label
    Public WithEvents cbEstado As ComboBox
    Public WithEvents cbAsigando As ComboBox
    Public WithEvents lblEstadoActual As Label
    Public WithEvents icNuevo As PictureBox
    Public WithEvents icCompleto As PictureBox
    Public WithEvents icProcesado As PictureBox
    Public WithEvents icSuspendido As PictureBox
    Public WithEvents icCreado As PictureBox
    Public WithEvents icEliminado As PictureBox
    Public WithEvents lblFechaCreado As Label
    Public WithEvents lblTitulo As Label
    Public WithEvents lblUsuarioAsignado As Label
    Public WithEvents btnGuardar As ToolStripMenuItem
End Class

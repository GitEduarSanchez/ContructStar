<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent1))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DespachadoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformePorDestinoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnprToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContratoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConexionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.POSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GestionarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeLicenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.POSToolStripMenuItem, Me.PagosToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1370, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.DespachadoresToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.PrintToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.ToolStripSeparator5, Me.ExitToolStripMenuItem, Me.AnprToolStripMenuItem, Me.ContratoToolStripMenuItem, Me.ConexionToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(100, 20)
        Me.FileMenu.Text = "&Administración"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.NewToolStripMenuItem.Text = "&Empresa"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.OpenToolStripMenuItem.Text = "&Indicador"
        '
        'DespachadoresToolStripMenuItem
        '
        Me.DespachadoresToolStripMenuItem.Name = "DespachadoresToolStripMenuItem"
        Me.DespachadoresToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.DespachadoresToolStripMenuItem.Text = "Despachadores"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformePorDestinoToolStripMenuItem})
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.PrintToolStripMenuItem.Text = "&Informes"
        '
        'InformePorDestinoToolStripMenuItem
        '
        Me.InformePorDestinoToolStripMenuItem.Name = "InformePorDestinoToolStripMenuItem"
        Me.InformePorDestinoToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.InformePorDestinoToolStripMenuItem.Text = "informe por destino"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "&Titulo"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(159, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ExitToolStripMenuItem.Text = "&Salir"
        '
        'AnprToolStripMenuItem
        '
        Me.AnprToolStripMenuItem.Name = "AnprToolStripMenuItem"
        Me.AnprToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.AnprToolStripMenuItem.Text = "Anpr"
        '
        'ContratoToolStripMenuItem
        '
        Me.ContratoToolStripMenuItem.Name = "ContratoToolStripMenuItem"
        Me.ContratoToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ContratoToolStripMenuItem.Text = "Contrato"
        '
        'ConexionToolStripMenuItem
        '
        Me.ConexionToolStripMenuItem.Name = "ConexionToolStripMenuItem"
        Me.ConexionToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ConexionToolStripMenuItem.Text = "Conexion"
        '
        'POSToolStripMenuItem
        '
        Me.POSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarToolStripMenuItem, Me.ListadoDeLicenciasToolStripMenuItem})
        Me.POSToolStripMenuItem.Name = "POSToolStripMenuItem"
        Me.POSToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.POSToolStripMenuItem.Text = "Licencias"
        '
        'PagosToolStripMenuItem
        '
        Me.PagosToolStripMenuItem.Name = "PagosToolStripMenuItem"
        Me.PagosToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.PagosToolStripMenuItem.Text = "Pagos"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 546)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1370, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'GestionarToolStripMenuItem
        '
        Me.GestionarToolStripMenuItem.Name = "GestionarToolStripMenuItem"
        Me.GestionarToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.GestionarToolStripMenuItem.Text = "Gestionar"
        '
        'ListadoDeLicenciasToolStripMenuItem
        '
        Me.ListadoDeLicenciasToolStripMenuItem.Name = "ListadoDeLicenciasToolStripMenuItem"
        Me.ListadoDeLicenciasToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ListadoDeLicenciasToolStripMenuItem.Text = "Listado de licencias"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 568)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIParent1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "...::POLIEDRO SOFTWARE SAS::..."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DespachadoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformePorDestinoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnprToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContratoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConexionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents POSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PagosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoDeLicenciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

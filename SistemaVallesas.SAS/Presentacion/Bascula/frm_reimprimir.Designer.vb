<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_reimprimir
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_buscar_reimp = New System.Windows.Forms.TextBox()
        Me.Status = New System.Windows.Forms.GroupBox()
        Me.r_comp = New System.Windows.Forms.RadioButton()
        Me.r_all = New System.Windows.Forms.RadioButton()
        Me.r_tran = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_nit = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_razon = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Status.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.Status)
        Me.GroupBox1.Controls.Add(Me.txt_buscar_reimp)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(733, 445)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reimpresión"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.DataGridView1.Location = New System.Drawing.Point(18, 83)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(709, 353)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.Frozen = True
        Me.Column1.HeaderText = "Reimprimir"
        Me.Column1.Name = "Column1"
        Me.Column1.Text = "Reimprimir"
        Me.Column1.ToolTipText = "Reimprimir"
        Me.Column1.UseColumnTextForButtonValue = True
        '
        'Column2
        '
        Me.Column2.Frozen = True
        Me.Column2.HeaderText = "Copias"
        Me.Column2.Name = "Column2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar"
        '
        'txt_buscar_reimp
        '
        Me.txt_buscar_reimp.Location = New System.Drawing.Point(130, 27)
        Me.txt_buscar_reimp.Name = "txt_buscar_reimp"
        Me.txt_buscar_reimp.Size = New System.Drawing.Size(221, 20)
        Me.txt_buscar_reimp.TabIndex = 2
        '
        'Status
        '
        Me.Status.Controls.Add(Me.r_comp)
        Me.Status.Controls.Add(Me.r_all)
        Me.Status.Controls.Add(Me.r_tran)
        Me.Status.Location = New System.Drawing.Point(357, 9)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(310, 38)
        Me.Status.TabIndex = 44
        Me.Status.TabStop = False
        Me.Status.Text = "Status"
        '
        'r_comp
        '
        Me.r_comp.AutoSize = True
        Me.r_comp.Location = New System.Drawing.Point(156, 17)
        Me.r_comp.Name = "r_comp"
        Me.r_comp.Size = New System.Drawing.Size(54, 17)
        Me.r_comp.TabIndex = 41
        Me.r_comp.TabStop = True
        Me.r_comp.Text = "Salida"
        Me.r_comp.UseVisualStyleBackColor = True
        '
        'r_all
        '
        Me.r_all.AutoSize = True
        Me.r_all.Location = New System.Drawing.Point(249, 17)
        Me.r_all.Name = "r_all"
        Me.r_all.Size = New System.Drawing.Size(55, 17)
        Me.r_all.TabIndex = 42
        Me.r_all.TabStop = True
        Me.r_all.Text = "Todos"
        Me.r_all.UseVisualStyleBackColor = True
        '
        'r_tran
        '
        Me.r_tran.AutoSize = True
        Me.r_tran.Location = New System.Drawing.Point(54, 17)
        Me.r_tran.Name = "r_tran"
        Me.r_tran.Size = New System.Drawing.Size(62, 17)
        Me.r_tran.TabIndex = 40
        Me.r_tran.TabStop = True
        Me.r_tran.Text = "Entrada"
        Me.r_tran.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_usuario)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txt_email)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.txt_telefono)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.txt_nit)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.txt_direccion)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.txt_razon)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Location = New System.Drawing.Point(87, 56)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(118, 21)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Configuración"
        Me.GroupBox4.Visible = False
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(112, 206)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(197, 20)
        Me.txt_usuario.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Usuario"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(112, 180)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(197, 20)
        Me.txt_email.TabIndex = 34
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(29, 183)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(32, 13)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "Email"
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(112, 154)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(197, 20)
        Me.txt_telefono.TabIndex = 32
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(29, 157)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 13)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "Telefono"
        '
        'txt_nit
        '
        Me.txt_nit.Location = New System.Drawing.Point(112, 128)
        Me.txt_nit.Name = "txt_nit"
        Me.txt_nit.Size = New System.Drawing.Size(197, 20)
        Me.txt_nit.TabIndex = 30
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(29, 131)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(20, 13)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Nit"
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(112, 45)
        Me.txt_direccion.Multiline = True
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(197, 77)
        Me.txt_direccion.TabIndex = 28
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(29, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 13)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Direccion"
        '
        'txt_razon
        '
        Me.txt_razon.Location = New System.Drawing.Point(112, 19)
        Me.txt_razon.Name = "txt_razon"
        Me.txt_razon.Size = New System.Drawing.Size(197, 20)
        Me.txt_razon.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(29, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Empresa"
        '
        'frm_reimprimir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 472)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_reimprimir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Status.ResumeLayout(False)
        Me.Status.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_buscar_reimp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Status As System.Windows.Forms.GroupBox
    Friend WithEvents r_comp As System.Windows.Forms.RadioButton
    Friend WithEvents r_all As System.Windows.Forms.RadioButton
    Friend WithEvents r_tran As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_nit As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_razon As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class

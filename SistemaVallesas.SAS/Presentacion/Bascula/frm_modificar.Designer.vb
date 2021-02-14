<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_modificar
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
        Me.Status = New System.Windows.Forms.GroupBox()
        Me.r_comp = New System.Windows.Forms.RadioButton()
        Me.r_all = New System.Windows.Forms.RadioButton()
        Me.r_tran = New System.Windows.Forms.RadioButton()
        Me.txt_buscar_reimp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.Status.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Status)
        Me.GroupBox1.Controls.Add(Me.txt_buscar_reimp)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1371, 529)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reimpresión"
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
        'txt_buscar_reimp
        '
        Me.txt_buscar_reimp.Location = New System.Drawing.Point(130, 27)
        Me.txt_buscar_reimp.Name = "txt_buscar_reimp"
        Me.txt_buscar_reimp.Size = New System.Drawing.Size(221, 20)
        Me.txt_buscar_reimp.TabIndex = 2
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
        'frm_modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 595)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_modificar"
        Me.Text = "frm_modificar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Status.ResumeLayout(False)
        Me.Status.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Status As System.Windows.Forms.GroupBox
    Friend WithEvents r_comp As System.Windows.Forms.RadioButton
    Friend WithEvents r_all As System.Windows.Forms.RadioButton
    Friend WithEvents r_tran As System.Windows.Forms.RadioButton
    Friend WithEvents txt_buscar_reimp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

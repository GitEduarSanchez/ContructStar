<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_consulta
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
        Me.lbl_n_in = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_pesoneto = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.lbl_tara = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.lbl_pesobruto = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cob_status = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cob_producto = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cob_destino = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cob_origen = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cob_despachador = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cob_movimiento = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cob_titulo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cob_placa = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.date_hasta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.date_desde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_n_in)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lbl_pesoneto)
        Me.GroupBox1.Controls.Add(Me.Label37)
        Me.GroupBox1.Controls.Add(Me.lbl_tara)
        Me.GroupBox1.Controls.Add(Me.Label35)
        Me.GroupBox1.Controls.Add(Me.lbl_pesobruto)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cob_status)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cob_producto)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cob_destino)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cob_origen)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cob_despachador)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cob_movimiento)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cob_titulo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cob_placa)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.date_hasta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.date_desde)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1570, 696)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consultas"
        '
        'lbl_n_in
        '
        Me.lbl_n_in.AutoSize = True
        Me.lbl_n_in.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_n_in.Location = New System.Drawing.Point(1262, 630)
        Me.lbl_n_in.Name = "lbl_n_in"
        Me.lbl_n_in.Size = New System.Drawing.Size(58, 25)
        Me.lbl_n_in.TabIndex = 60
        Me.lbl_n_in.Text = "0.00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1113, 630)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(137, 25)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "N°Registros"
        '
        'lbl_pesoneto
        '
        Me.lbl_pesoneto.AutoSize = True
        Me.lbl_pesoneto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pesoneto.Location = New System.Drawing.Point(929, 630)
        Me.lbl_pesoneto.Name = "lbl_pesoneto"
        Me.lbl_pesoneto.Size = New System.Drawing.Size(58, 25)
        Me.lbl_pesoneto.TabIndex = 58
        Me.lbl_pesoneto.Text = "0.00"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(780, 630)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(128, 25)
        Me.Label37.TabIndex = 57
        Me.Label37.Text = "Peso  Neto"
        '
        'lbl_tara
        '
        Me.lbl_tara.AutoSize = True
        Me.lbl_tara.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tara.Location = New System.Drawing.Point(549, 633)
        Me.lbl_tara.Name = "lbl_tara"
        Me.lbl_tara.Size = New System.Drawing.Size(58, 25)
        Me.lbl_tara.TabIndex = 56
        Me.lbl_tara.Text = "0.00"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(470, 633)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(60, 25)
        Me.Label35.TabIndex = 55
        Me.Label35.Text = "Tara"
        '
        'lbl_pesobruto
        '
        Me.lbl_pesobruto.AutoSize = True
        Me.lbl_pesobruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pesobruto.Location = New System.Drawing.Point(259, 633)
        Me.lbl_pesobruto.Name = "lbl_pesobruto"
        Me.lbl_pesobruto.Size = New System.Drawing.Size(58, 25)
        Me.lbl_pesobruto.TabIndex = 54
        Me.lbl_pesobruto.Text = "0.00"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(121, 633)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(122, 24)
        Me.Label33.TabIndex = 53
        Me.Label33.Text = "Peso Bruto"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(21, 94)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1534, 519)
        Me.DataGridView1.TabIndex = 22
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1141, 46)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Exportar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1141, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cob_status
        '
        Me.cob_status.FormattingEnabled = True
        Me.cob_status.Items.AddRange(New Object() {"completo", "transito"})
        Me.cob_status.Location = New System.Drawing.Point(1003, 44)
        Me.cob_status.Name = "cob_status"
        Me.cob_status.Size = New System.Drawing.Size(121, 21)
        Me.cob_status.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(937, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Status"
        '
        'cob_producto
        '
        Me.cob_producto.FormattingEnabled = True
        Me.cob_producto.Location = New System.Drawing.Point(1003, 17)
        Me.cob_producto.Name = "cob_producto"
        Me.cob_producto.Size = New System.Drawing.Size(121, 21)
        Me.cob_producto.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(937, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Producto"
        '
        'cob_destino
        '
        Me.cob_destino.FormattingEnabled = True
        Me.cob_destino.Location = New System.Drawing.Point(802, 46)
        Me.cob_destino.Name = "cob_destino"
        Me.cob_destino.Size = New System.Drawing.Size(121, 21)
        Me.cob_destino.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(740, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Destino"
        '
        'cob_origen
        '
        Me.cob_origen.FormattingEnabled = True
        Me.cob_origen.Location = New System.Drawing.Point(802, 18)
        Me.cob_origen.Name = "cob_origen"
        Me.cob_origen.Size = New System.Drawing.Size(121, 21)
        Me.cob_origen.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(740, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Origen"
        '
        'cob_despachador
        '
        Me.cob_despachador.FormattingEnabled = True
        Me.cob_despachador.Location = New System.Drawing.Point(602, 44)
        Me.cob_despachador.Name = "cob_despachador"
        Me.cob_despachador.Size = New System.Drawing.Size(121, 21)
        Me.cob_despachador.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(525, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Despachador"
        '
        'cob_movimiento
        '
        Me.cob_movimiento.FormattingEnabled = True
        Me.cob_movimiento.Location = New System.Drawing.Point(602, 17)
        Me.cob_movimiento.Name = "cob_movimiento"
        Me.cob_movimiento.Size = New System.Drawing.Size(121, 21)
        Me.cob_movimiento.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(525, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Movimiento"
        '
        'cob_titulo
        '
        Me.cob_titulo.FormattingEnabled = True
        Me.cob_titulo.Location = New System.Drawing.Point(398, 50)
        Me.cob_titulo.Name = "cob_titulo"
        Me.cob_titulo.Size = New System.Drawing.Size(121, 21)
        Me.cob_titulo.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(358, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Titulo"
        '
        'cob_placa
        '
        Me.cob_placa.FormattingEnabled = True
        Me.cob_placa.Location = New System.Drawing.Point(398, 19)
        Me.cob_placa.Name = "cob_placa"
        Me.cob_placa.Size = New System.Drawing.Size(121, 21)
        Me.cob_placa.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(358, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Placa"
        '
        'date_hasta
        '
        Me.date_hasta.Location = New System.Drawing.Point(135, 50)
        Me.date_hasta.Name = "date_hasta"
        Me.date_hasta.Size = New System.Drawing.Size(200, 20)
        Me.date_hasta.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha hasta"
        '
        'date_desde
        '
        Me.date_desde.Location = New System.Drawing.Point(135, 19)
        Me.date_desde.Name = "date_desde"
        Me.date_desde.Size = New System.Drawing.Size(200, 20)
        Me.date_desde.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha desde"
        '
        'frm_consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 720)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_consulta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents date_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents date_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents cob_placa As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cob_status As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cob_producto As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cob_destino As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cob_origen As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cob_despachador As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cob_movimiento As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cob_titulo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_pesoneto As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents lbl_tara As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents lbl_pesobruto As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents lbl_n_in As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class

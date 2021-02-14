<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_invertir
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_mov_act = New System.Windows.Forms.Label()
        Me.lbl_mov_inv = New System.Windows.Forms.Label()
        Me.lbl_pb_inv = New System.Windows.Forms.Label()
        Me.lbl_pb_act = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_tara_inv = New System.Windows.Forms.Label()
        Me.lbl_tara_act = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_idmov = New System.Windows.Forms.Label()
        Me.lbl_iddesp = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_iddesp)
        Me.GroupBox1.Controls.Add(Me.lbl_idmov)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.lbl_tara_inv)
        Me.GroupBox1.Controls.Add(Me.lbl_tara_act)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lbl_pb_inv)
        Me.GroupBox1.Controls.Add(Me.lbl_pb_act)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lbl_mov_inv)
        Me.GroupBox1.Controls.Add(Me.lbl_mov_act)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1056, 198)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Invertir Movimiento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Movimiento actual :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Movimiento Invertido :"
        '
        'lbl_mov_act
        '
        Me.lbl_mov_act.AutoSize = True
        Me.lbl_mov_act.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mov_act.Location = New System.Drawing.Point(206, 59)
        Me.lbl_mov_act.Name = "lbl_mov_act"
        Me.lbl_mov_act.Size = New System.Drawing.Size(87, 24)
        Me.lbl_mov_act.TabIndex = 2
        Me.lbl_mov_act.Text = "***********"
        '
        'lbl_mov_inv
        '
        Me.lbl_mov_inv.AutoSize = True
        Me.lbl_mov_inv.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mov_inv.Location = New System.Drawing.Point(206, 97)
        Me.lbl_mov_inv.Name = "lbl_mov_inv"
        Me.lbl_mov_inv.Size = New System.Drawing.Size(136, 24)
        Me.lbl_mov_inv.TabIndex = 3
        Me.lbl_mov_inv.Text = "******************"
        '
        'lbl_pb_inv
        '
        Me.lbl_pb_inv.AutoSize = True
        Me.lbl_pb_inv.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pb_inv.Location = New System.Drawing.Point(525, 97)
        Me.lbl_pb_inv.Name = "lbl_pb_inv"
        Me.lbl_pb_inv.Size = New System.Drawing.Size(164, 24)
        Me.lbl_pb_inv.TabIndex = 7
        Me.lbl_pb_inv.Text = "**********************"
        '
        'lbl_pb_act
        '
        Me.lbl_pb_act.AutoSize = True
        Me.lbl_pb_act.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pb_act.Location = New System.Drawing.Point(518, 59)
        Me.lbl_pb_act.Name = "lbl_pb_act"
        Me.lbl_pb_act.Size = New System.Drawing.Size(164, 24)
        Me.lbl_pb_act.TabIndex = 6
        Me.lbl_pb_act.Text = "**********************"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(342, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(187, 24)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Peso bruto invertido :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(342, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(165, 24)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Peso bruto actual :"
        '
        'lbl_tara_inv
        '
        Me.lbl_tara_inv.AutoSize = True
        Me.lbl_tara_inv.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tara_inv.Location = New System.Drawing.Point(866, 97)
        Me.lbl_tara_inv.Name = "lbl_tara_inv"
        Me.lbl_tara_inv.Size = New System.Drawing.Size(164, 24)
        Me.lbl_tara_inv.TabIndex = 11
        Me.lbl_tara_inv.Text = "**********************"
        '
        'lbl_tara_act
        '
        Me.lbl_tara_act.AutoSize = True
        Me.lbl_tara_act.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tara_act.Location = New System.Drawing.Point(866, 59)
        Me.lbl_tara_act.Name = "lbl_tara_act"
        Me.lbl_tara_act.Size = New System.Drawing.Size(164, 24)
        Me.lbl_tara_act.TabIndex = 10
        Me.lbl_tara_act.Text = "**********************"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(722, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 24)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Tara invertida :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(722, 59)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 24)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Tara actual :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(433, 148)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(220, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_idmov
        '
        Me.lbl_idmov.AutoSize = True
        Me.lbl_idmov.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_idmov.Location = New System.Drawing.Point(16, 135)
        Me.lbl_idmov.Name = "lbl_idmov"
        Me.lbl_idmov.Size = New System.Drawing.Size(87, 24)
        Me.lbl_idmov.TabIndex = 13
        Me.lbl_idmov.Text = "***********"
        '
        'lbl_iddesp
        '
        Me.lbl_iddesp.AutoSize = True
        Me.lbl_iddesp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_iddesp.Location = New System.Drawing.Point(16, 159)
        Me.lbl_iddesp.Name = "lbl_iddesp"
        Me.lbl_iddesp.Size = New System.Drawing.Size(87, 24)
        Me.lbl_iddesp.TabIndex = 14
        Me.lbl_iddesp.Text = "***********"
        '
        'frm_invertir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1103, 227)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_invertir"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_mov_inv As System.Windows.Forms.Label
    Friend WithEvents lbl_mov_act As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbl_tara_inv As System.Windows.Forms.Label
    Friend WithEvents lbl_tara_act As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbl_pb_inv As System.Windows.Forms.Label
    Friend WithEvents lbl_pb_act As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbl_iddesp As System.Windows.Forms.Label
    Friend WithEvents lbl_idmov As System.Windows.Forms.Label
End Class

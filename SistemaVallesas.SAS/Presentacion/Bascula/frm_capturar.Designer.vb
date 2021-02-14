<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_capturar
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
        Me.vecesdedo = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vecesdedo
        '
        Me.vecesdedo.AutoSize = True
        Me.vecesdedo.Location = New System.Drawing.Point(21, 226)
        Me.vecesdedo.Name = "vecesdedo"
        Me.vecesdedo.Size = New System.Drawing.Size(39, 13)
        Me.vecesdedo.TabIndex = 1
        Me.vecesdedo.Text = "Label1"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(24, 300)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.ReadOnly = True
        Me.txt_usuario.Size = New System.Drawing.Size(171, 20)
        Me.txt_usuario.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(24, 242)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(171, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "iniciar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(24, 271)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(171, 23)
        Me.btn_guardar.TabIndex = 7
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(24, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(171, 204)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frm_capturar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(210, 332)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.vecesdedo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frm_capturar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Huella"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents vecesdedo As System.Windows.Forms.Label
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button

End Class

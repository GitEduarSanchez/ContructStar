Public Class frm_conductor
    'Dim objentidad As New CapaEntidad.ClassEntidadConductor
    'Dim objdata As New CapaDato.ClassEntidad.ClassCapaDatoConductor
    'Dim _id As Integer
    'Dim act As Boolean = False
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    With Me.txt_nombre
    '        If .Text = String.Empty Then
    '            MessageBox.Show("Debes indicar el nombre", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            .BackColor = Color.Aquamarine
    '            .Focus()
    '            Exit Sub
    '        Else
    '            .BackColor = Color.White
    '        End If
    '    End With
    '    With Me.txt_apellido
    '        If .Text = String.Empty Then
    '            MessageBox.Show("Debes seleccionar el apellido", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            .BackColor = Color.Aquamarine
    '            .Focus()
    '            Exit Sub
    '        Else
    '            .BackColor = Color.White
    '        End If
    '    End With
    '    With Me.txt_documento
    '        If .Text = String.Empty Then
    '            MessageBox.Show("Debes seleccionar el documento", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            .BackColor = Color.Aquamarine
    '            .Focus()
    '            Exit Sub
    '        Else
    '            .BackColor = Color.White
    '        End If
    '    End With
    '    If act = True Then
    '        objentidad.getnombre = Convert.ToString(Me.txt_nombre.Text)
    '        objentidad.getapellido = Convert.ToString(Me.txt_apellido.Text)
    '        objentidad.getdocumento = Convert.ToString(Me.txt_documento.Text)
    '        If objdata.updateconductor(objentidad) Then
    '            MessageBox.Show("Actualización exitosa", "conductor", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Me.txt_nombre.Text = String.Empty
    '            Me.txt_apellido.Text = String.Empty
    '            Me.txt_documento.Text = String.Empty
    '        Else
    '            MessageBox.Show("Error al actualizar", "conductor", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If
    '    Else
    '        objentidad.getnombre = Convert.ToString(Me.txt_nombre.Text)
    '        objentidad.getapellido = Convert.ToString(Me.txt_apellido.Text)
    '        objentidad.getdocumento = Convert.ToString(Me.txt_documento.Text)
    '        If objdata.insertconductor(objentidad) Then
    '            MessageBox.Show("Registro exitoso", "conductor", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Me.txt_nombre.Text = String.Empty
    '            Me.txt_apellido.Text = String.Empty
    '            Me.txt_documento.Text = String.Empty
    '        Else
    '            MessageBox.Show("Error al insertar", "conductor", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If
    '    End If

    'End Sub

    'Public Sub cargarregistro()
    '    Dim dtg As New CapaNegocio.ClassConsultarDtg(Me.DataGridView1, "conductor")
    'End Sub
    ''Sub consultardtg()
    ''    Try
    ''        If Not IsNumeric(Me.txt_buscar_reg.Text) Then
    ''            Dim dtg As New CapaNegocio.ClassConsultarDtg(Me.DataGridView1, Me.txt_buscar_reg.Text, "*", "v_despacho", "placa")
    ''            Me.DataGridView1.DataSource = dtg.getdtg
    ''        Else
    ''            Dim dtg As New CapaNegocio.ClassConsultarDtg(Me.DataGridView1, Me.txt_buscar_reg.Text, "*", "v_despacho", "documento")
    ''            Me.DataGridView1.DataSource = dtg.getdtg
    ''        End If
    ''    Catch ex As Exception
    ''        MessageBox.Show(ex.Message, "error al buscar el empleado", MessageBoxButtons.OK, MessageBoxIcon.Information)
    ''    End Try
    ''End Sub
    'Private Sub frm_conductor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Call cargarregistro()
    'End Sub

    'Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    '    With Me.DataGridView1
    '        If .CurrentCell.ColumnIndex = 0 Then
    '            Me.Close()
    '        End If
    '    End With
    '    With Me.DataGridView1
    '        If .CurrentCell.ColumnIndex = 1 Then
    '            If MessageBox.Show("Actualizar conductor ? ", "conductor", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
    '                Me.txt_nombre.Text = Convert.ToString(.CurrentRow.Cells.Item(3).Value)
    '                Me.txt_apellido.Text = Convert.ToString(.CurrentRow.Cells.Item(4).Value)
    '                Me.txt_documento.Text = Convert.ToString(.CurrentRow.Cells.Item(5).Value)
    '                _id = Integer.Parse(.CurrentRow.Cells.Item(2).Value)
    '                act = True
    '            End If

    '        End If
    '    End With
    'End Sub
End Class
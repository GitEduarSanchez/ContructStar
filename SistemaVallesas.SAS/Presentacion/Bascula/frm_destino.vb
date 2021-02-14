Public Class frm_destino
    'Dim objentidad As New CapaEntidad.ClassEntidadDestino
    'Dim objdata As New CapaDato.ClassEntidad.ClassCapaDatoDestino
    'Dim id As Integer
    'Dim act_destino As Boolean
    'Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    '    With Me.DataGridView1
    '        If .CurrentCell.ColumnIndex = 0 Then
    '            frm_despacho.cob_destino.Text = Convert.ToString(.CurrentRow.Cells.Item(3).Value)
    '            Me.Close()
    '        End If
    '    End With
    '    With Me.DataGridView1
    '        If .CurrentCell.ColumnIndex = 1 Then
    '            If MessageBox.Show("Actualizar origen ? ", "origen", MessageBoxButtons.OK, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.OK Then
    '                Me.txt_destino.Text = Convert.ToString(.CurrentRow.Cells.Item(3).Value)
    '                id = Integer.Parse(.CurrentRow.Cells.Item(2).Value)
    '                act_destino = True
    '            End If
    '        End If
    '    End With
    'End Sub

    'Private Sub frm_destino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    cargar()
    'End Sub
    'Public Sub cargar()
    '    Dim dtg As New CapaNegocio.ClassConsultarDtg(Me.DataGridView1, "destino")
    'End Sub
    'Public Sub agregardestino()
    '    If Me.txt_destino.Text = String.Empty Then
    '        MessageBox.Show("Debes indicar el destino", "origen", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Me.txt_destino.Focus()
    '        Me.txt_destino.BackColor = Color.Green
    '        Exit Sub
    '    Else
    '        Me.txt_destino.BackColor = Color.White
    '    End If
    '    objentidad.getdescripcion = Convert.ToString(Me.txt_destino.Text)
    '    If objdata.insertdestino(objentidad) Then
    '        MessageBox.Show("Registro exitoso", "destino", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Call cargar()
    '    End If
    'End Sub
    'Public Sub actualizardestino()
    '    If Me.txt_destino.Text = String.Empty Then
    '        MessageBox.Show("Debes indicar destino", "origen", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Me.txt_destino.Focus()
    '        Me.txt_destino.BackColor = Color.Green
    '        Exit Sub
    '    Else
    '        Me.txt_destino.BackColor = Color.White
    '    End If
    '    objentidad.getdescripcion = Convert.ToString(Me.txt_destino.Text)
    '    If objdata.insertdestino(objentidad) Then
    '        MessageBox.Show("Registro exitoso", "destino", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Call cargar()
    '    End If
    'End Sub
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Call agregardestino()
    'End Sub
    'Sub consultardtg()
    '    Try
    '        If Not IsNumeric(Me.txt_b_origen.Text) Then
    '            Dim dtg As New CapaNegocio.ClassConsultarDtg(Me.DataGridView1, Me.txt_b_origen.Text, "*", "destino", "descripcion")
    '            Me.DataGridView1.DataSource = dtg.getdtg
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error al buscar origen", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub
    'Private Sub txt_b_origen_TextChanged(sender As Object, e As EventArgs) Handles txt_b_origen.TextChanged
    '    Call consultardtg()
    'End Sub

    'Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    'End Sub
End Class
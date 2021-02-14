Public Class frm_origen
    'Dim objentidad As New CapaEntidad.ClassEntidadOrigen
    'Dim objdata As New CapaDato.ClassEntidad.ClassCapaDatoOrigen
    'Dim act_ori As Boolean = False
    'Dim id As Integer

    'Private Sub frm_origen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Call cargar()
    'End Sub
    'Sub cargar()
    '    Dim dtg As New CapaNegocio.ClassConsultarDtg(Me.DataGridView1, "origen")
    'End Sub
    'Sub consultardtg()
    '    Try
    '        If Not IsNumeric(Me.txt_b_origen.Text) Then
    '            Dim dtg As New CapaNegocio.ClassConsultarDtg(Me.DataGridView1, Me.txt_b_origen.Text, "*", "origen", "descripcion")
    '            Me.DataGridView1.DataSource = dtg.getdtg
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error al buscar origen", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub
    'Private Sub txt_placa_TextChanged(sender As Object, e As EventArgs) Handles txt_b_origen.TextChanged
    '    Call consultardtg()
    'End Sub
    'Public Sub agregarorigen()
    '    If Me.txt_origen.Text = String.Empty Then
    '        MessageBox.Show("Debes indicar el origen", "origen", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Me.txt_origen.Focus()
    '        Me.txt_origen.BackColor = Color.Green
    '        Exit Sub
    '    Else
    '        Me.txt_origen.BackColor = Color.White
    '    End If
    '    objentidad.getorigen = Convert.ToString(Me.txt_origen.Text)
    '    If objdata.insertorigen(objentidad) Then
    '        MessageBox.Show("Registro exitoso", "origen", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Call cargar()
    '    End If
    'End Sub
    'Sub actulaizrorigen()
    '    If Me.txt_origen.Text = String.Empty Then
    '        MessageBox.Show("Debes indicar el origen", "origen", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Me.txt_origen.Focus()
    '        Me.txt_origen.BackColor = Color.Green
    '        Exit Sub
    '    Else
    '        Me.txt_origen.BackColor = Color.White
    '    End If
    '    With Me.DataGridView1
    '        objentidad.getidorigen = Integer.Parse(id)
    '        objentidad.getorigen = Convert.ToString(Me.txt_origen.Text)
    '        If objdata.updateorigen(objentidad) Then
    '            MessageBox.Show("Actualizacion exitosa", "origen", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Call cargar()
    '        End If
    '    End With
    'End Sub
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Try
    '        If act_ori = False Then
    '            Call agregarorigen()
    '        End If
    '        If act_ori = True Then
    '            Call actulaizrorigen()
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error origen", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub
    'Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    '    With Me.DataGridView1
    '        If .CurrentCell.ColumnIndex = 0 Then
    '                frm_despacho.cob_origen.Text = Convert.ToString(.CurrentRow.Cells.Item(3).Value)
    '                Me.Close()
    '            End If
    '    End With
    '    With Me.DataGridView1
    '        If .CurrentCell.ColumnIndex = 1 Then
    '            If MessageBox.Show("Actualizar origen ? ", "origen", MessageBoxButtons.OK, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.OK Then
    '                Me.txt_origen.Text = Convert.ToString(.CurrentRow.Cells.Item(3).Value)
    '                id = Integer.Parse(.CurrentRow.Cells.Item(2).Value)
    '                act_ori = True
    '            End If

    '        End If
    '    End With
    'End Sub

    'Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    'End Sub
End Class
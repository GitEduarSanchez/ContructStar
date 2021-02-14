Public Class frm_contrato
    'Dim id As Integer
    'Dim objentidad As New CapaEntidad.ClassEntidadContrato
    'Dim objdata As New CapaDato.ClassEntidad.ClassCapaDatoContrato
    'Dim act_ori As Boolean = False
    'Sub cargar()
    '    Dim dtg As New CapaNegocio.ClassConsultarDtg(Me.DataGridView1, "contrato")
    'End Sub
    'Public Sub agregarcontrato()
    '    If Me.txt_contrato.Text = String.Empty Then
    '        MessageBox.Show("Debes indicar el origen", "origen", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Me.txt_contrato.Focus()
    '        Me.txt_contrato.BackColor = Color.Green
    '        Exit Sub
    '    Else
    '        Me.txt_contrato.BackColor = Color.White
    '    End If
    '    objentidad.getdescripcion = Convert.ToString(Me.txt_contrato.Text)
    '    If objdata.insertContrato(objentidad) Then
    '        MessageBox.Show("Registro exitoso", "origen", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Call cargar()
    '    End If
    'End Sub

    'Sub actulizarcontrato()
    '    If Me.txt_contrato.Text = String.Empty Then
    '        MessageBox.Show("Debes indicar el contrato", "contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Me.txt_contrato.Focus()
    '        Me.txt_contrato.BackColor = Color.Green
    '        Exit Sub
    '    Else
    '        Me.txt_contrato.BackColor = Color.White
    '    End If
    '    With Me.DataGridView1
    '        objentidad.getidcontrato = Integer.Parse(id)
    '        objentidad.getdescripcion = Convert.ToString(Me.txt_contrato.Text)
    '        If objdata.updatecontrato(objentidad) Then
    '            MessageBox.Show("Actualizacion exitosa", "contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Call cargar()
    '        End If
    '    End With
    'End Sub
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Try
    '        If act_ori = False Then
    '            Call agregarcontrato()
    '        End If
    '        If act_ori = True Then
    '            Call actulizarcontrato()
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub

    'Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    '    With Me.DataGridView1
    '        If .CurrentCell.ColumnIndex = 0 Then
    '            If form = "salida" Then

    '                Me.Close()
    '            End If
    '            If form = "entrada" Then
    '                frm_despacho.cob_origen.Text = Convert.ToString(.CurrentRow.Cells.Item(3).Value)
    '                Me.Close()
    '            End If
    '        Else
    '        End If
    '    End With
    '    With Me.DataGridView1
    '        If .CurrentCell.ColumnIndex = 1 Then
    '            If MessageBox.Show("Actualizar contrato ? ", "contrato", MessageBoxButtons.OK, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.OK Then
    '                Me.txt_contrato.Text = Convert.ToString(.CurrentRow.Cells.Item(3).Value)
    '                id = Integer.Parse(.CurrentRow.Cells.Item(2).Value)
    '                act_ori = True
    '            End If

    '        End If
    '    End With
    'End Sub

    'Private Sub frm_contrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    cargar()
    'End Sub
End Class
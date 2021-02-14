Public Class frm_tipovehiculo
    'Dim objentidad As New CapaEntidad.ClassEntidadTipoVehiculo
    'Dim objdata As New CapaDato.ClassEntidad.ClassCapaDatoTipoV
    'Dim _id As Integer
    'Dim act As Boolean = False
    'Private Sub frm_tipovehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Call cargar()
    'End Sub
    'Sub cargar()
    '    Dim dtg As New CapaNegocio.ClassConsultarDtg(Me.DataGridView1, "tipovehiculo")
    'End Sub
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    With Me.txt_tipovehiculo
    '        If .Text = String.Empty Then
    '            MessageBox.Show("Debes indicar el tipo de vehiculo", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            .BackColor = Color.Aquamarine
    '            .Focus()
    '            Exit Sub
    '        Else
    '            .BackColor = Color.White
    '        End If
    '    End With
    '    objentidad.getdescripcion = Convert.ToString(Me.txt_tipovehiculo.Text)
    '    If act = True Then
    '        If objdata.updatetipovehiculo(objentidad) Then
    '            MessageBox.Show("Actualizacion exitosa", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Call cargar()
    '        Else
    '            If objdata.inserttipovehiculo(objentidad) Then
    '                MessageBox.Show("Registro exitoso", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                Me.txt_tipovehiculo.Text = String.Empty
    '                Call cargar()
    '            End If
    '        End If
    '    End If


    'End Sub

    'Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    '    With Me.DataGridView1
    '        If .CurrentCell.ColumnIndex = 0 Then
    '            If MessageBox.Show("Actualizar?", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.OK Then
    '                Me.txt_tipovehiculo.Text = .CurrentRow.Cells.Item(2).Value
    '                _id = Double.Parse(.CurrentRow.Cells.Item(1).Value)
    '                act = True
    '            End If
    '        End If
    '    End With
    'End Sub
End Class
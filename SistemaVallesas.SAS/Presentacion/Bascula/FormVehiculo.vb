'Public Class FormVehiculo
'    Dim objvehiculo As New CapaDato.ClassEntidad.ClassCapaDatoBascula
'    Private Sub FormVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        With Me.DataGridView1
'            .AllowUserToAddRows = False
'            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
'        End With
'        StartPosition = FormStartPosition.CenterScreen
'        cargar()
'    End Sub
'    Public Sub cargardata()
'        Dim dtg As New CapaDato.ClassEntidad.ClassCapaDatoBascula
'        dtg.Listar_entrada()
'    End Sub

'    Public Sub cargar()
'        DataGridView1.AutoGenerateColumns = True
'        DataGridView1.DataSource = objvehiculo.Listar_entrada
'        DataGridView1.Refresh()
'    End Sub

'    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
'        With Me.DataGridView1
'            If .CurrentCell.ColumnIndex = 0 Then
'                    frm_despacho.txt_placa.Text = Convert.ToString(.CurrentRow.Cells.Item(3).Value)
'                    frm_despacho.txt_conductor.Text = .CurrentRow.Cells.Item(5).Value
'                    frm_despacho.txt_tipo_vehiculo.Text = Convert.ToString(.CurrentRow.Cells.Item(4).Value)
'                    frm_despacho.txt_docuemento.Text = Convert.ToString(.CurrentRow.Cells.Item(6).Value)
'                    frm_despacho._idvehiculo = Convert.ToInt64(.CurrentRow.Cells.Item(2).Value)
'                    Me.Close()
'                End If
'        End With
'        With Me.DataGridView1
'            If .CurrentCell.ColumnIndex = 1 Then
'                frm_act_vehiculo.txt_placa.Text = Convert.ToString(.CurrentRow.Cells.Item(3).Value)
'                frm_act_vehiculo.cob_conductor.Text = Convert.ToString(.CurrentRow.Cells.Item(5).Value)
'                frm_act_vehiculo.cob_tpv.Text = Convert.ToString(.CurrentRow.Cells.Item(4).Value)
'                frm_act_vehiculo._id = Convert.ToInt64(.CurrentRow.Cells.Item(2).Value)
'                frm_act_vehiculo.ShowDialog()
'            End If
'        End With
'    End Sub
'    Sub consultardtg()
'        Try
'            If Not IsNumeric(Me.txt_buscar_vh.Text) Then
'                Dim dtg As New CapaNegocio.ClassConsultarDtg(Me.DataGridView1, Me.txt_buscar_vh.Text, "*", "v_vehiculo", "placa")
'                Me.DataGridView1.DataSource = dtg.getdtg
'            Else
'                Dim dtg As New CapaNegocio.ClassConsultarDtg(Me.DataGridView1, Me.txt_buscar_vh.Text, "*", "v_vehiculo", "documento")
'                Me.DataGridView1.DataSource = dtg.getdtg
'            End If
'        Catch ex As Exception
'            MessageBox.Show(ex.Message, "error al buscar el empleado", MessageBoxButtons.OK, MessageBoxIcon.Information)
'        End Try
'    End Sub
'    Private Sub txt_placa_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar_vh.TextChanged
'        Call consultardtg()
'    End Sub
'End Class
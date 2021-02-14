Public Class frm_act_vehiculo
    'Dim objentidad As New CapaEntidad.ClassEntidadVehiculo
    ''Dim objdata As New CapaDato.ClassEntidad.ClassVehiculo
    'Dim _idconductor As Integer
    'Dim _idtpv As Integer
    'Public _id As Integer

    'Private Sub frm_act_vehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Dim objcargartipovolqueta As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_tpv, "descripcion", "tipovehiculo")
    '    Dim objcargarconductor As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_conductor, "nombre", "conductor")
    'End Sub

    'Public Sub actualizar()
    '    objentidad.getidvehiculo = Convert.ToInt64(_id)
    '    objentidad.getplaca = Convert.ToString(Me.txt_placa.Text)
    '    objentidad.getidconductor = Convert.ToInt64(_idconductor)
    '    objentidad.getidtipovehiculo = Convert.ToInt64(_idtpv)
    '    If objdata.updatevehiculo(objentidad) Then
    '        MessageBox.Show("Actualizacion exitosa", "Vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Me.Close()
    '        FormVehiculo.cargar()
    '    End If
    'End Sub
    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Call actualizar()
    'End Sub

    'Private Sub cob_tpv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cob_tpv.SelectedIndexChanged
    '    Try
    '        Dim objgetid As New CapaNegocio.ClassPolimorfismoGetid(Me.cob_tpv, "idtipovehiculo", "tipovehiculo", "descripcion")
    '        _idtpv = Convert.ToInt64(objgetid.getid)
    '        'MessageBox.Show(_idtpv)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error al cargar el tipovehiculo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub

    'Private Sub cob_conductor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cob_conductor.SelectedIndexChanged
    '    Try
    '        Dim objgetid As New CapaNegocio.ClassPolimorfismoGetid(Me.cob_conductor, "idconductor", "conductor", "nombre")
    '        _idconductor = Convert.ToInt64(objgetid.getid)
    '        'MessageBox.Show(_idconductor)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error al cargar el tipovehiculo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub
End Class
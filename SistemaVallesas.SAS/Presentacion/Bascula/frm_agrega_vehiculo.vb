
Public Class frm_agrega_vehiculo
    'Dim _idvehiculo As Integer
    'Dim _idconductor As Integer
    'Dim objentidad As New CapaEntidad.ClassEntidadVehiculo
    'Dim objdata As New CapaDato.ClassEntidad.ClassVehiculo
    'Private Sub frm_agrega_vehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Dim objcargarconductorb As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_conductor, "nombre", "conductor")
    '    Dim objcargartipovb As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_tipovehiclo, "descripcion", "tipovehiculo")
    'End Sub

    'Private Sub cob_tipovehiclo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cob_tipovehiclo.SelectedIndexChanged
    '    Try
    '        Dim objgetid As New CapaNegocio.ClassPolimorfismoGetid(Me.cob_tipovehiclo, "idtipovehiculo", "tipovehiculo", "descripcion")
    '        _idvehiculo = Convert.ToInt64(objgetid.getid)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error al cargar el origen", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub

    'Private Sub cob_conductor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cob_conductor.SelectedIndexChanged
    '    Try
    '        Dim objgetid As New CapaNegocio.ClassPolimorfismoGetid(Me.cob_conductor, "idconductor", "conductor", "nombre")
    '        _idconductor = Convert.ToInt64(objgetid.getid)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error al cargar el origen", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub
    'Sub registrarvehiculo()
    '    With Me.txt_placa
    '        If .Text = String.Empty Then
    '            MessageBox.Show("Debes indicar la placa", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            .BackColor = Color.Aquamarine
    '            .Focus()
    '            Exit Sub
    '        Else
    '            .BackColor = Color.White
    '        End If
    '    End With
    '    With Me.cob_tipovehiclo
    '        If .Text = String.Empty Then
    '            MessageBox.Show("Debes seleccionar el tipovehiculo", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            .BackColor = Color.Aquamarine
    '            .Focus()
    '            Exit Sub
    '        Else
    '            .BackColor = Color.White
    '        End If
    '    End With
    '    With Me.cob_conductor
    '        If .Text = String.Empty Then
    '            MessageBox.Show("Debes seleccionar el conductor", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            .BackColor = Color.Aquamarine
    '            .Focus()
    '            Exit Sub
    '        Else
    '            .BackColor = Color.White
    '        End If
    '    End With

    '    objentidad.getplaca = Convert.ToString(Me.txt_placa.Text)
    '    objentidad.getidtipovehiculo = Integer.Parse(_idvehiculo)
    '    objentidad.getidconductor = Integer.Parse(_idconductor)
    '    If objdata.insertvehiculo(objentidad) Then
    '        MessageBox.Show("Registro exitoso", "vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Me.txt_placa.Text = String.Empty
    '        Me.cob_conductor.Text = String.Empty
    '        Me.cob_tipovehiclo.Text = String.Empty
    '    End If
    'End Sub
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Call registrarvehiculo()
    'End Sub
End Class
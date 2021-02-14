Public Class frm_usuario
    'Dim objdata As New CapaDato.ClassEntidad.ClassCapaDatoUsuario
    'Dim objentidad As New CapaEntidad.ClassEntidadUser
    'Dim _idtipousuario As Integer
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    If Me.txt_usuario.Text.Length > 0 And Me.txt_clave.Text.Length > 0 And Me.cob_tipo_usuario.Text <> String.Empty Then
    '        'frm_capturar.ShowDialog()
    '    Else
    '        MessageBox.Show("Debes completar los datos de registro ", "usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If

    'End Sub

    'Private Sub frm_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Dim objcargardespachador As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_tipo_usuario, "descripcion", "tipousuario")
    'End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    objentidad.getusuario = Convert.ToString(Me.txt_usuario.Text)
    '    objentidad.getclave = Convert.ToString(Me.txt_clave.Text)
    '    objentidad.getidtipousuario = Convert.ToInt64(_idtipousuario)
    '    If objdata.insertUsuario(objentidad) Then
    '        MessageBox.Show("Registro guardado con exito", "usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    Else
    '        MessageBox.Show("No se pudo guardar el usuario ", "usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If
    'End Sub

    'Private Sub cob_tipo_usuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cob_tipo_usuario.SelectedIndexChanged
    '    Try
    '        Dim objgetid As New CapaNegocio.ClassPolimorfismoGetid(Me.cob_tipo_usuario, "idtipousuario", "tipousuario", "descripcion")
    '        _idtipousuario = Convert.ToInt64(objgetid.getid)
    '        'MessageBox.Show(_idtipousuario)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error al cargar el origen", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub
End Class
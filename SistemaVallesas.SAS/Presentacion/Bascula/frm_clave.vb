Public Class frm_clave

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_clave.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.txt_clave.Text = "1091658551" Then
            Dim f As New frm_despacho
            f.cob_b_despachador.Enabled = True
            Me.Close()
        End If
    End Sub

    Private Sub frm_clave_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
Public Class frm_consulta

    Private Sub frm_consulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        Dim dtg As New CapaNegocio.ClassConsultarDtg(Me.DataGridView1, "v_despacho_query")
        Dim objcargarplaca As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_placa, "placa", "vehiculo")
        Dim objcargartitulo As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_titulo, "descripcion", "titulo")
        Dim objcargardespachador As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_despachador, "nombre", "despachador")
        Dim objcargarproducto As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_producto, "descripcion", "producto")
        Dim objcargarorigen As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_origen, "descripcion", "origen")
        Dim objcargardestino As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_destino, "descripcion", "destino")
        Dim objcargarmov As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_movimiento, "descripcion", "movimiento")
        Call calcularpesaje()
    End Sub
   
    Sub consultar()
        Dim saerchdate As New CapaNegocio.ClassConsultarFechas(
                                                               Me.DataGridView1, Me.date_desde, Me.date_hasta, "*", "v_despacho_query", "salida",
                                                               Me.cob_placa.Text, Me.cob_movimiento.Text, Me.cob_origen.Text, Me.cob_producto.Text,
                                                               Me.cob_titulo.Text, Me.cob_despachador.Text, Me.cob_destino.Text, Me.cob_status.Text
                                                               )
        Me.DataGridView1.DataSource = saerchdate.getdatetable
        With DataGridView1
            .Columns(12).DefaultCellStyle.Format = "#,##0.0"
            .Columns(13).DefaultCellStyle.Format = "#,##0.0"
            .Columns(14).DefaultCellStyle.Format = "#,##0.0"
        End With
        Call calcularpesaje()
    End Sub
    Public Sub calcularpesaje()
        Try
            Me.lbl_n_in.Text = Me.DataGridView1.Rows.Count()
        Me.lbl_pesobruto.Text = 0
        Me.lbl_tara.Text = 0
        Me.lbl_pesoneto.Text = 0
            With Me.DataGridView1
                For i As Integer = 0 To .Rows.Count() - 1
                    Me.lbl_pesobruto.Text += Double.Parse(Me.DataGridView1(12, i).Value)
                    Me.lbl_tara.Text += Double.Parse(Me.DataGridView1(13, i).Value)
                    Me.lbl_pesoneto.Text += Double.Parse(Me.DataGridView1(14, i).Value)
                Next
            End With
        Me.lbl_pesobruto.Text = Format(Double.Parse(Me.lbl_pesobruto.Text), "#,##0.0")
        Me.lbl_tara.Text = Format(Double.Parse(Me.lbl_tara.Text), "#,##0.0")
            Me.lbl_pesoneto.Text = Format(Double.Parse(Me.lbl_pesoneto.Text), "#,##0.0")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call consultar()
        Call calcularpesaje()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            'Dim excel As New CapaNegocio.ClassExportarExcel(Me.DataGridView1)
            Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.Message, "error al exportar a excel", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub date_desde_ValueChanged(sender As Object, e As EventArgs) Handles date_desde.ValueChanged

    End Sub
End Class
Public Class frm_reimprimir

    Private Sub frm_reimprimir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
    End Sub
    Sub cargar()
        Dim dtg As New CapaNegocio.ClassConsultarDtg(Me.DataGridView1, "v_despacho")
        Dim empresa As New CapaNegocio.ClassEmpresa
        If empresa.empresa("empresa") Then
            Me.txt_razon.Text = LCase(empresa.geterazon)
            Me.txt_direccion.Text = LCase(empresa.getdireccion)
            Me.txt_nit.Text = LCase(empresa.getnit)
            Me.txt_telefono.Text = LCase(empresa.gettelefono)
            Me.txt_email.Text = LCase(empresa.getemail)
        End If
    End Sub

    Private Sub txt_buscar_reimp_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar_reimp.TextChanged
        consultardtg()
    End Sub
    Sub consultardtg()
        Try
            If Not IsNumeric(Me.txt_buscar_reimp.Text) Then
                Dim dtg As New CapaNegocio.ClassConsultarDtg(Me.DataGridView1, Me.txt_buscar_reimp.Text, "*", "v_despacho", "placa")
                Me.DataGridView1.DataSource = dtg.getdtg
            Else
                Dim dtg As New CapaNegocio.ClassConsultarDtg(Me.DataGridView1, Me.txt_buscar_reimp.Text, "*", "v_despacho", "control")
                Me.DataGridView1.DataSource = dtg.getdtg
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "error al buscar el empleado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            With Me.DataGridView1
                If .CurrentCell.ColumnIndex = 0 Then
                    If .CurrentRow.Cells.Item(1).Value = 0 Then
                        MessageBox.Show("Debes indicar el numero de copias", "reimprimir", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    If .CurrentRow.Cells.Item(1).Value = String.Empty Then
                        MessageBox.Show("Debes indicar el numero de copias", "reimprimir", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    If Not IsNumeric(.CurrentRow.Cells.Item(1).Value) Then
                        MessageBox.Show("Debes indicar el numero de copias en datos numéricas", "reimprimir", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    For i As Integer = 1 To Integer.Parse(.CurrentRow.Cells.Item(1).Value)
                        Call registrar()
                    Next
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub
    Sub registrar()
        'Try
        'With Me.DataGridView1
        '    Dim Ticket As New CapaDato.CrearTicket
        '    Ticket.TextoCentro(Convert.ToString(UCase(Me.txt_razon.Text)))
        '    Ticket.TextoIzquierda("CENTRO DE NEGOCIOS VENTURA PLAZA ")
        '    Ticket.TextoIzquierda("CENTRO DE TRABAJO: BASCULA")
        '        Ticket.TextoIzquierda("TELEFONO:5754903")
        '    Ticket.TextoIzquierda("NIT: 900204370-1")
        '    Ticket.TextoIzquierda("EMAIL: INFO@CARBONESDETOLEDO.COM")
        '    Ticket.TextoIzquierda("")
        '        Ticket.TextoCentro(Convert.ToString(UCase(.CurrentRow.Cells.Item(4).Value)))
        '        Ticket.TextoExtremos("BASCULA # 1", "# " & Convert.ToString(UCase(.CurrentRow.Cells.Item(17).Value)))
        '    Ticket.lineasAsteriscos()
        '        Ticket.TextoExtremos("PROVEEDOR", Convert.ToString(UCase(.CurrentRow.Cells.Item(12).Value)))
        '    Ticket.lineasIgual()
        '        Ticket.TextoExtremos("DESTINO", Convert.ToString(UCase(.CurrentRow.Cells.Item(13).Value)))
        '    Ticket.lineasIgual()
        '    'Sub cabecera.
        '    Ticket.TextoIzquierda("")
        '        Ticket.TextoIzquierda("TITULO: " & Convert.ToString(UCase(.CurrentRow.Cells.Item(3).Value)))
        '        Ticket.TextoIzquierda("DESPACHADOR: " & Convert.ToString(UCase(.CurrentRow.Cells.Item(19).Value)))
        '    Ticket.TextoIzquierda("CLIENTE: PUBLICO EN GENERAL")
        '        Ticket.TextoIzquierda("TIPO VEHICULO: " & Convert.ToString(UCase(.CurrentRow.Cells.Item(9).Value)))
        '        Ticket.TextoIzquierda("PLACA: " & Convert.ToString(UCase(.CurrentRow.Cells.Item(8).Value)))
        '        Ticket.TextoIzquierda("CONDUCTOR: " & Convert.ToString(UCase(.CurrentRow.Cells.Item(10).Value)))
        '        Ticket.TextoIzquierda("DOCUMENTO: " & Convert.ToString(UCase(.CurrentRow.Cells.Item(11).Value)))
        '        Ticket.TextoIzquierda("# RECIBO: " & Convert.ToString(UCase(.CurrentRow.Cells.Item(20).Value)))
        '        Ticket.TextoIzquierda("CONTRATO: " & Convert.ToString(UCase(.CurrentRow.Cells.Item(21).Value)))
        '        Ticket.TextoIzquierda("PRODUCTO: " & Convert.ToString(UCase(.CurrentRow.Cells.Item(5).Value)))
        '        Ticket.TextoIzquierda("PRESINTOS: " & Convert.ToString(UCase(.CurrentRow.Cells.Item(18).Value)))
        '    Ticket.TextoIzquierda("")
        '        Ticket.TextoExtremos("ENTRADA:" + FormatDateTime(Me.DataGridView1.CurrentRow.Cells.Item(6).Value, DateFormat.ShortDate), "HORA: " + FormatDateTime(Me.DataGridView1.CurrentRow.Cells.Item(6).Value, DateFormat.LongTime))
        '        Ticket.TextoExtremos("SALIDA :" + FormatDateTime(Me.DataGridView1.CurrentRow.Cells.Item(7).Value, DateFormat.ShortDate), "HORA: " + FormatDateTime(Me.DataGridView1.CurrentRow.Cells.Item(7).Value, DateFormat.LongTime))
        '    Ticket.lineasAsteriscos()
        '        Ticket.AgregarTotales("         PESOBRUTO...KG", Double.Parse(Me.DataGridView1.CurrentRow.Cells.Item(14).Value))
        '        Ticket.AgregarTotales("         TARA........KG", Double.Parse(Me.DataGridView1.CurrentRow.Cells.Item(15).Value))
        '        Ticket.AgregarTotales("         PESONETO....KG", Double.Parse(Me.DataGridView1.CurrentRow.Cells.Item(16).Value))
        '    Ticket.TextoIzquierda("")
        '    Ticket.TextoCentro("¡GRACIAS POR PREFERIRNOS!")
        '    Ticket.TextoIzquierda("")
        '    Ticket.TextoIzquierda("")
        '    Ticket.TextoIzquierda("")
        '    Ticket.TextoIzquierda("")
        '    Ticket.CortaTicket()
        '        Ticket.ImprimirTicket(Convert.ToString(impresora))
        '    End With
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString)
        'End Try
    End Sub

    Private Sub r_tran_CheckedChanged(sender As Object, e As EventArgs) Handles r_tran.CheckedChanged
        If r_tran.Checked Then 'entrada
            Dim dtg As New CapaNegocio.ClassConsultarDtg(Me.DataGridView1, "entrada", "*", "v_despacho", "movimiento")
        End If
    End Sub

    Private Sub r_comp_CheckedChanged(sender As Object, e As EventArgs) Handles r_comp.CheckedChanged
        If r_comp.Checked Then
            Dim dtg As New CapaNegocio.ClassConsultarDtg(Me.DataGridView1, "salida", "*", "v_despacho", "movimiento")
        End If
    End Sub

    Private Sub r_all_CheckedChanged(sender As Object, e As EventArgs) Handles r_all.CheckedChanged
        If r_all.Checked Then
            Dim dtg As New CapaNegocio.ClassConsultarDtg(Me.DataGridView1, "v_despacho")
        End If
    End Sub
End Class
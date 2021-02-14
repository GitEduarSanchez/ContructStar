Imports System.Drawing.Printing
Imports LibPrintTicket
Imports CapaDato
Imports MySql.Data.MySqlClient

Public Class frm_despacho
    'Public _idvehiculo As Integer
    'Dim _idtitulo As Integer
    'Dim _idorigen As Integer
    'Dim _iddestino As Integer
    'Dim _idproducto As Integer
    'Dim _iddespachador As Integer
    'Dim ConfiguracionesDeImpresion As New PrinterSettings
    'Dim objentidad As New CapaEntidad.ClassEntidadDespacho
    'Dim objdatadespacho As New CapaDato.ClassEntidad.ClassCapaDatoBascula
    'Dim c As New CapaDatos.ClassConexion
    'Dim cnn As New MySqlConnection
    'Dim tara As Double
    'Dim _idcontrato As Integer
    'Dim _idmovimiento As Integer
    'Private ComBuffer As Byte()                       'bascula
    'Private Delegate Sub UpdateFormDelegate()         'bascula
    'Private UpdateFormDelegate1 As UpdateFormDelegate 'bascula
    ''Creamos las variables a usar en el procedimiento de UpdateDisplay
    'Dim strReturn As String                            'bascula
    'Dim strPeso As String                              'bascula
    'Dim car As String                                  'bascula
    'Dim ti As Boolean = False
    'Dim num As New CapaNegocio.ClasseExtraerNumero
    'Private Sub buscapuerto()
    '    Try
    '        Me.ComboPorts.Items.Clear()
    '        For Each puerto As String In My.Computer.Ports.SerialPortNames
    '            Me.ComboPorts.Items.Add(puerto)
    '        Next
    '        If ComboPorts.Items.Count > 0 Then
    '            ComboPorts.SelectedIndex = 0
    '        Else
    '            MessageBox.Show("No puerto disponibles")
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    'Private Sub frm_despacho_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
    '    SerialPort1.Close()
    'End Sub

    'Private Sub frm_despacho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    'TraeConfiguracion()
    '    'antes que nada hay que abrir el puerto
    '    buscapuerto()
    '    If Not SerialPort1.IsOpen Then
    '        'SerialPort1.Open()
    '    End If
    '    Call conexionserial()
    '    Me.WindowState = FormWindowState.Maximized
    '    Me.cob_impresora.Items.Clear()
    '    For Each Impresora As String In PrinterSettings.InstalledPrinters
    '        Me.cob_impresora.Items.Add(Impresora)
    '        Me.cob_impresora.Text = ConfiguracionesDeImpresion.PrinterName
    '    Next
    '    impresora = ConfiguracionesDeImpresion.PrinterName
    '    Me.txt_copias.Text = 1
    '    Me.lbl_fecha.Text = Date.Today()
    '    Dim objcargartitulo As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_titulo, "descripcion", "titulo")
    '    Dim objcargardespachador As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_despachador, "nombre", "despachador")
    '    Dim objcargardespachadorb As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_b_despachador, "nombre", "despachador")

    '    Dim objcargarproducto As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_producto, "descripcion", "producto")
    '    Dim objcargarproductob As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_b_producto, "descripcion", "producto")
    '    Dim objcargarorigen As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_origen, "descripcion", "origen")
    '    Dim objcargarorigenb As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_b_origen, "descripcion", "origen")
    '    Dim objcargardestino As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_destino, "descripcion", "destino")
    '    Dim objcargardestinob As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_b_destino, "descripcion", "destino")
    '    Dim objcargarconductorb As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_b_conductor, "nombre", "conductor")
    '    Dim objcargartipovb As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_b_tipovehiculo, "descripcion", "tipovehiculo")
    '    Dim objcargartipocontrato As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_contrato, "descripcion", "contrato")
    '    Dim objcargarmov As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_movimiento, "descripcion", "movimiento")

    '    Dim empresa As New CapaNegocio.ClassEmpresa
    '    If empresa.empresa("empresa") Then
    '        Me.txt_razon.Text = LCase(empresa.geterazon)
    '        Me.txt_direccion.Text = LCase(empresa.getdireccion)
    '        Me.txt_nit.Text = LCase(empresa.getnit)
    '        Me.txt_telefono.Text = LCase(empresa.gettelefono)
    '        Me.txt_email.Text = LCase(empresa.getemail)
    '    End If
    '    Me.txt_razon.ReadOnly = True
    '    Me.txt_direccion.ReadOnly = True
    '    Me.txt_nit.ReadOnly = True
    '    Me.txt_telefono.ReadOnly = True
    '    Me.txt_email.ReadOnly = True
    '    Me.txt_usuario.Text = user
    '    Me.txt_usuario.ReadOnly = True
    '    Me.cob_titulo.SelectedIndex = 0
    '    Me.txt_placa.ReadOnly = True
    '    Me.txt_conductor.ReadOnly = True
    '    Me.txt_docuemento.ReadOnly = True
    '    Me.txt_tipo_vehiculo.ReadOnly = True
    '    'Call cargarentradas()
    '    Call cargarregistro()
    '    Call control()
    '    cob_producto.SelectedIndex = 0
    '    Me.cob_contrato.SelectedIndex = 0
    '    Call calcularpesajein()
    '    'With Me.DataGridView1
    '    '    .Columns(13).DefaultCellStyle.Format = fm
    '    '    .Columns(14).DefaultCellStyle.Format = fm
    '    '    .Columns(15).DefaultCellStyle.Format = fm
    '    'End With
    '    Me.DateTimePicker1.Enabled = False
    '    Me.cob_despachador.Enabled = True
    '    Me.txt_control.Enabled = False
    'End Sub
    'Public Sub userdespachador()
    '    'Dim getiddp As New CapaNegocio.ClassPolimorfismoGetid(user, "iddespachador", "despachador", "nombre")
    '    '_iddespachador = getiddp.getid
    '    'Me.cob_despachador.Text = user
    'End Sub
    'Public Sub control()
    '    Try
    '        cnn = c.conectar
    '        Dim cmdn As MySqlCommand
    '        Dim query As String
    '        Dim rn As MySqlDataReader
    '        query = "select max(control)  from v_despacho;"
    '        cmdn = New MySqlCommand(query, cnn)
    '        rn = cmdn.ExecuteReader
    '        If rn.Read() Then
    '            If rn(0).ToString = Nothing Then
    '                Me.lbl_control.Text = Convert.ToInt64(1)
    '                Me.txt_control.Text = Convert.ToInt64(1)
    '            End If
    '            Me.lbl_control.Text = Convert.ToInt64(rn(0).ToString)
    '            Me.txt_control.Text = (Convert.ToInt64(rn(0).ToString) + 1)

    '            cnn.Close()
    '            rn.Close()
    '        Else
    '            If rn(0).ToString = Nothing Then
    '                Me.lbl_control.Text = Convert.ToInt64(1)
    '            End If
    '        End If
    '    Catch ex As Exception
    '        Me.lbl_control.Text = Convert.ToInt64(1)
    '    End Try
    'End Sub
    'Public Sub cargarregistro()
    '    Dim dtg As New CapaNegocio.ClassConsultarDtg(Me.DataGridView1, "transito", "*", "v_despacho", "movimiento", "entrada", "desc", True)
    'End Sub
    'Public Sub cargarentradas()
    '    Dim dtg As New CapaNegocio.ClassConsultarDtg(Me.DataGridView1, "transito", "entrada", "*", "v_despacho", "entrada", "x", "desc", True)
    'End Sub
    'Public Sub cargarentradasall()
    '    Dim dtg As New CapaNegocio.ClassConsultarDtg(Me.DataGridView1, "v_despacho")
    'End Sub
    'Public Sub cargarentradasprocesadas()
    '    Dim dtg As New CapaNegocio.ClassConsultarDtg(Me.DataGridView1, "completo", "entrada", "*", "v_despacho", "entrada", "x", "desc", True)
    'End Sub
    'Sub completa()
    '    Dim dtg As New CapaNegocio.ClassConsultarDtg(Me.DataGridView1, "completo", "v_despacho")
    'End Sub
    'Sub registrar()
    '    Dim Ticket As New CapaDato.CrearTicket

    '    Ticket.TextoCentro(Convert.ToString(UCase(Me.txt_razon.Text)))
    '    Ticket.TextoIzquierda("CENTRO DE NEGOCIOS VENTURA PLAZA ")
    '    Ticket.TextoIzquierda("CENTRO DE TRABAJO: MOROS")
    '    Ticket.TextoIzquierda("TELEFONO: 5754903")
    '    Ticket.TextoIzquierda("NIT: 900204370-1")
    '    Ticket.TextoIzquierda("EMAIL: INFO@CARBONESDETOLEDO.COM")
    '    Ticket.TextoIzquierda("")
    '    Ticket.TextoCentro(Convert.ToString(UCase(Me.cob_movimiento.Text)))
    '    Ticket.TextoExtremos("BASCULA # 1", "# " & Convert.ToString(UCase(Me.txt_control.Text)))
    '    Ticket.lineasAsteriscos()
    '    Ticket.TextoExtremos("PROVEEDOR", Convert.ToString(UCase(Me.cob_origen.Text)))
    '    Ticket.lineasIgual()
    '    Ticket.TextoExtremos("DESTINO", Convert.ToString(UCase(Me.cob_destino.Text)))
    '    Ticket.lineasIgual()
    '    'Sub cabecera.
    '    Ticket.TextoIzquierda("")
    '    Ticket.TextoIzquierda("TITULO: " & Convert.ToString(UCase(Me.cob_titulo.Text)))
    '    Ticket.TextoIzquierda("DESPACHADOR: " & Convert.ToString(UCase(Me.cob_despachador.Text)))
    '    Ticket.TextoIzquierda("CLIENTE: PUBLICO EN GENERAL")
    '    Ticket.TextoIzquierda("TIPO VEHICULO: " & Convert.ToString(UCase(Me.txt_tipo_vehiculo.Text)))
    '    Ticket.TextoIzquierda("PLACA: " & Convert.ToString(UCase(Me.txt_placa.Text)))
    '    Ticket.TextoIzquierda("CONDUCTOR: " & Convert.ToString(UCase(Me.txt_conductor.Text)))
    '    Ticket.TextoIzquierda("DOCUMENTO: " & Convert.ToString(UCase(Me.txt_docuemento.Text)))
    '    Ticket.TextoIzquierda("# RECIBO: " & Convert.ToString(UCase(Me.txt_recibo.Text)))
    '    Ticket.TextoIzquierda("CONTRATO: " & Convert.ToString(UCase(Me.cob_contrato.Text)))
    '    Ticket.TextoIzquierda("PRODUCTO: " & Convert.ToString(UCase(Me.cob_producto.Text)))
    '    Ticket.TextoIzquierda("PRESINTOS: " & Convert.ToString(UCase(Me.txt_observaciones.Text)))
    '    'Ticket.TextoExtremos("ENTRADA:" + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString())
    '    'Ticket.TextoExtremos("SALIDA:" + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString())
    '    Ticket.TextoExtremos("ENTRADA:" + FormatDateTime(Me.DataGridView1.CurrentRow.Cells.Item(5).Value, DateFormat.ShortDate), "HORA: " + FormatDateTime(Me.DataGridView1.CurrentRow.Cells.Item(5).Value, DateFormat.LongTime))
    '    Ticket.TextoExtremos("SALIDA :" + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToLongTimeString())
    '    'Ticket.TextoIzquierda("DURACION: " & TimeValue(DateDiff(DateInterval.Minute, Me.DataGridView1.CurrentRow.Cells.Item(5).Value, Date.Now) & ":" & DateDiff(DateInterval.Second, Me.DataGridView1.CurrentRow.Cells.Item(5).Value, Date.Now)))
    '    Ticket.lineasAsteriscos()
    '    If Me.cob_movimiento.Text = "ENTRADA" Then
    '        Ticket.AgregarTotales("         PESOBRUTO...KG", Double.Parse(Me.DataGridView1.CurrentRow.Cells.Item(13).Value))
    '        Ticket.AgregarTotales("         TARA........KG", Double.Parse(num.SoloNumeros(Me.txt_pesobruto.Text)))
    '        Ticket.AgregarTotales("         PESONETO....KG", Double.Parse(Me.DataGridView1.CurrentRow.Cells.Item(13).Value - Double.Parse(num.SoloNumeros(Me.txt_pesobruto.Text))))
    '    End If
    '    If Me.cob_movimiento.Text = "SALIDA" Then
    '        Ticket.AgregarTotales("         PESOBRUTO...KG", Double.Parse(Double.Parse(num.SoloNumeros(Me.txt_pesobruto.Text))))
    '        Ticket.AgregarTotales("         TARA........KG", Double.Parse(Me.DataGridView1.CurrentRow.Cells.Item(14).Value))
    '        Ticket.AgregarTotales("         PESONETO....KG", Double.Parse(Double.Parse(num.SoloNumeros(Me.txt_pesobruto.Text)) - Me.DataGridView1.CurrentRow.Cells.Item(14).Value))
    '    End If
    '    Ticket.TextoIzquierda("")
    '    Ticket.TextoCentro("¡GRACIAS POR PREFERIRNOS!")
    '    Ticket.TextoIzquierda("")
    '    Ticket.TextoIzquierda("")
    '    Ticket.TextoIzquierda("")
    '    Ticket.TextoIzquierda("")
    '    Ticket.CortaTicket()
    '    Ticket.ImprimirTicket(Convert.ToString(Me.cob_impresora.Text))
    'End Sub
    'Public Sub insert_bascula()
    '    Try
    '        With Me.cob_movimiento
    '            If .Text = String.Empty Then
    '                MessageBox.Show("Debes indicar el movimiento", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                .BackColor = Color.Aquamarine
    '                .Focus()
    '                Exit Sub
    '            Else
    '                .BackColor = Color.White
    '            End If
    '        End With
    '        With Me.cob_titulo
    '            If .Text = String.Empty Then
    '                MessageBox.Show("Debes seleccionar el titulo minero", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                .BackColor = Color.Aquamarine
    '                .Focus()
    '                Exit Sub
    '            Else
    '                .BackColor = Color.White
    '            End If
    '        End With
    '        With Me.txt_control
    '            If .Text = String.Empty Then
    '                MessageBox.Show("Debes indicar el N° de control", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                .BackColor = Color.Aquamarine
    '                .Focus()
    '                Exit Sub
    '            Else
    '                .BackColor = Color.White
    '            End If
    '        End With
    '        With Me.txt_control
    '            If Not IsNumeric(.Text) Then
    '                MessageBox.Show("Debes indicar el N° de control en datos numericos", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                .BackColor = Color.Aquamarine
    '                .Focus()
    '                Exit Sub
    '            Else
    '                .BackColor = Color.White
    '            End If
    '        End With
    '        'With Me.cob_despachador
    '        '    If .Text = String.Empty Then
    '        '        MessageBox.Show("Debes seleccionar el despachador", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        '        .BackColor = Color.Aquamarine
    '        '        .Focus()
    '        '        Exit Sub
    '        '    Else
    '        '        .BackColor = Color.White
    '        '    End If
    '        'End With
    '        With Me.txt_placa
    '            If .Text = String.Empty Then
    '                MessageBox.Show("Debes indicar la placa", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                .BackColor = Color.Aquamarine
    '                .Focus()
    '                Exit Sub
    '            Else
    '                .BackColor = Color.White
    '            End If
    '        End With
    '        With Me.txt_tipo_vehiculo
    '            If .Text = String.Empty Then
    '                MessageBox.Show("Debes indicar el tipo de vehiculo", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                .BackColor = Color.Aquamarine
    '                .Focus()
    '                Exit Sub
    '            Else
    '                .BackColor = Color.White
    '            End If
    '        End With
    '        With Me.txt_conductor
    '            If .Text = String.Empty Then
    '                MessageBox.Show("Debes indicar el conductor", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                .BackColor = Color.Aquamarine
    '                .Focus()
    '                Exit Sub
    '            Else
    '                .BackColor = Color.White
    '            End If
    '        End With
    '        With Me.txt_docuemento
    '            If .Text = String.Empty Then
    '                MessageBox.Show("Debes indicar el documento del conductor", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                .BackColor = Color.Aquamarine
    '                .Focus()
    '                Exit Sub
    '            Else
    '                .BackColor = Color.White
    '            End If
    '        End With
    '        With Me.cob_origen
    '            If .Text = String.Empty Then
    '                MessageBox.Show("Debes seleccionar el origen", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                .BackColor = Color.Aquamarine
    '                .Focus()
    '                Exit Sub
    '            Else
    '                .BackColor = Color.White
    '            End If
    '        End With
    '        With Me.cob_destino
    '            If .Text = String.Empty Then
    '                MessageBox.Show("Debes seleccionar el destino", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                .BackColor = Color.Aquamarine
    '                .Focus()
    '                Exit Sub
    '            Else
    '                .BackColor = Color.White
    '            End If
    '        End With
    '        With Me.cob_producto
    '            If .Text = String.Empty Then
    '                MessageBox.Show("Debes seleccionar el producto", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                .BackColor = Color.Aquamarine
    '                .Focus()
    '                Exit Sub
    '            Else
    '                .BackColor = Color.White
    '            End If
    '        End With
    '        With Me.txt_recibo
    '            If .Text = String.Empty Then
    '                MessageBox.Show("Debes indicar el recibo", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                .BackColor = Color.Aquamarine
    '                .Focus()
    '                Exit Sub
    '            Else
    '                .BackColor = Color.White
    '            End If
    '        End With
    '        With Me.cob_contrato
    '            If .Text = String.Empty Then
    '                MessageBox.Show("Debes seleccionar el contrato", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                .BackColor = Color.Aquamarine
    '                .Focus()
    '                Exit Sub
    '            Else
    '                .BackColor = Color.White
    '            End If
    '        End With
    '        With Me.txt_observaciones
    '            If .Text = String.Empty Then
    '                MessageBox.Show("Debes indicar observaciones", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                .BackColor = Color.Aquamarine
    '                .Focus()
    '                Exit Sub
    '            Else
    '                .BackColor = Color.White
    '            End If
    '        End With


    '        'With Me.txt_pesobruto
    '        '    If Not IsNumeric(.Text) Then
    '        '        MessageBox.Show("Debes captar el pesaje en datos numericos", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        '        .Focus()
    '        '        Exit Sub
    '        '    End If
    '        'End With
    '        'With Me.txt_pesobruto
    '        '    If .Text < 0 Then
    '        '        MessageBox.Show("Debes captar el pesaje en datos numericos superiores a cero", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        '        .Focus()
    '        '        Exit Sub
    '        '    End If
    '        'End With
    '        'With Me.txt_pesobruto
    '        '    If .Text = 0 Then
    '        '        MessageBox.Show("Debes captar el pesaje en datos numericos superiores a cero", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        '        .Focus()
    '        '        Exit Sub
    '        '    End If
    '        'End With
    '        With Me.DataGridView1
    '            If .Rows.Count() > 0 Then
    '                For Each rd As DataGridViewRow In .Rows
    '                    If Convert.ToInt64(Me.txt_control.Text) <> Convert.ToInt64(rd.Cells.Item(16).Value) And _
    '                    Convert.ToString(Me.txt_placa.Text) = Convert.ToString(rd.Cells.Item(7).Value) And Convert.ToString(rd.Cells.Item(21).Value) = "transito" Then
    '                        MessageBox.Show("Debes revisar el numero de placa por que ya se escuentra registrada y está en tránsito", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                        Exit Sub
    '                    End If
    '                Next
    '            End If
    '        End With
    '        objentidad.getidtitulo = Convert.ToString(_idtitulo)
    '        objentidad.getidmovimiento = Convert.ToInt64(_idmovimiento)
    '        objentidad.getidproducto = Convert.ToInt64(_idproducto)
    '        objentidad.getfechaentrada = Me.lbl_fecha.Text + " " + Me.lbl_hora.Text
    '        objentidad.getfechasalida = Me.lbl_fecha.Text + " " + Me.lbl_hora.Text
    '        objentidad.getidvehiculo = Convert.ToInt64(_idvehiculo)
    '        objentidad.getidorigen = Convert.ToInt64(_idorigen)
    '        objentidad.getiddestino = Convert.ToInt64(_iddestino)
    '        If cob_movimiento.Text = "ENTRADA" Then
    '            objentidad.getpesobruto = Convert.ToDouble(num.SoloNumeros(Me.txt_pesobruto.Text))
    '            objentidad.gettara = Convert.ToDouble(0)
    '            objentidad.getpesoneto = Convert.ToDouble(0)
    '        End If
    '        If cob_movimiento.Text = "SALIDA" Then
    '            objentidad.getpesobruto = Convert.ToDouble(0)
    '            objentidad.gettara = Convert.ToDouble(num.SoloNumeros(Me.txt_pesobruto.Text))
    '            objentidad.getpesoneto = Convert.ToDouble(0)
    '        End If
    '        objentidad.getcontrol = Convert.ToInt64(Me.txt_control.Text)
    '        objentidad.getobservaciones = Convert.ToString(Me.txt_observaciones.Text)
    '        objentidad.getidstatus = Convert.ToInt64(2)
    '        objentidad.getidusuario = Convert.ToInt64(_iddespachador)
    '        objentidad.getrecibo = Convert.ToString(Me.txt_recibo.Text)
    '        objentidad.getidcontrato = Convert.ToInt64(_idcontrato)
    '        objentidad.getquincenas = Convert.ToString("quincena")
    '        If objdatadespacho.insertbascula(objentidad) Then
    '            MessageBox.Show("Registro exitoso", "Bascula", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Call calcularpesajein()
    '            Dim r As New CapaNegocio.ClassReset
    '            r.Reset(GroupBox1)
    '            Me.cob_titulo.SelectedIndex = 0
    '            Me.cob_producto.SelectedIndex = 0
    '            Me.cob_contrato.SelectedIndex = 0
    '            Call control()
    '        Else
    '            MessageBox.Show("No se insertó el registro de pesaje", "Bascula", MessageBoxButtons.OK, MessageBoxIcon.Error)

    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString, "Bascula", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
    'Public Function procesarentrada() As Boolean
    '    bandera = True
    '    'With Me.cob_b_despachador
    '    '    If .Text = String.Empty Then
    '    '        MessageBox.Show("Debes indicar el despachador", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    '        .Focus()
    '    '        Return False
    '    '        Exit Function
    '    '    End If
    '    'End With
    '    'With Me.txt_pesobruto
    '    '    If Not IsNumeric(.Text) Then
    '    '        MessageBox.Show("Debes captar el pesaje en datos numericos", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    '        .Focus()
    '    '        bandera = False
    '    '        Return False
    '    '        Exit Function
    '    '    End If
    '    'End With
    '    'With Me.txt_pesobruto
    '    '    If .Text < 0 Then
    '    '        MessageBox.Show("Debes captar el pesaje en datos numericos superiores a cero", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    '        .Focus()
    '    '        bandera = False
    '    '        Return False
    '    '        Exit Function
    '    '    End If
    '    'End With
    '    'With Me.txt_pesobruto
    '    '    If .Text = 0 Then
    '    '        MessageBox.Show("Debes captar el pesaje en datos numericos superiores a cero", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    '        .Focus()
    '    '        bandera = False
    '    '        Return False
    '    '        Exit Function
    '    '    End If
    '    'End With
    '    Try
    '        If bandera = True Then
    '            With Me.DataGridView1
    '                If .Rows.Count() > 0 Then
    '                    For i As Integer = 0 To .Rows.Count() - 1
    '                        If Convert.ToInt64(Me.txt_control.Text) = Convert.ToInt64(.CurrentRow.Cells.Item(16).Value) Then
    '                            If Me.cob_movimiento.Text = "ENTRADA" Then
    '                                objentidad.getiddespacho = Convert.ToInt64(.CurrentRow.Cells.Item(1).Value)
    '                                objentidad.gettara = Convert.ToDouble(num.SoloNumeros(Me.txt_pesobruto.Text))
    '                                objentidad.getpesoneto = Convert.ToDouble(.CurrentRow.Cells.Item(13).Value) - Convert.ToDouble(num.SoloNumeros(Me.txt_pesobruto.Text))
    '                                objentidad.getidstatus = Convert.ToInt64(1)
    '                                objentidad.getpesobruto = Convert.ToDouble(.CurrentRow.Cells.Item(13).Value)
    '                                objentidad.getfechasalida = Me.lbl_fecha.Text + " " + Me.lbl_hora.Text
    '                            End If
    '                            If Me.cob_movimiento.Text = "SALIDA" Then
    '                                objentidad.getiddespacho = Convert.ToInt64(.CurrentRow.Cells.Item(1).Value)
    '                                objentidad.gettara = Convert.ToDouble(.CurrentRow.Cells.Item(14).Value)
    '                                objentidad.getpesoneto = Convert.ToDouble(num.SoloNumeros(Me.txt_pesobruto.Text)) - Convert.ToDouble(.CurrentRow.Cells.Item(14).Value)
    '                                objentidad.getidstatus = Convert.ToInt64(1)
    '                                objentidad.getpesobruto = Convert.ToDouble(num.SoloNumeros(Me.txt_pesobruto.Text))
    '                                objentidad.getfechasalida = Me.lbl_fecha.Text + " " + Me.lbl_hora.Text
    '                            End If
    '                            If objdatadespacho.updatebascula(objentidad) Then
    '                                If Me.checkticket.Checked Then
    '                                    For j As Integer = 1 To Convert.ToInt64(Me.txt_copias.Text)
    '                                        Call registrar()
    '                                    Next
    '                                End If
    '                                Call cargarregistro()
    '                                Call calcularpesajein()
    '                                Dim b As New CapaNegocio.ClassReset
    '                                b.bloqueo(GroupBox1, True)
    '                                b.Reset(GroupBox1)
    '                                Me.cob_titulo.SelectedIndex = 0
    '                                Me.cob_producto.SelectedIndex = 0
    '                                Call control()
    '                                Me.cob_despachador.Text = String.Empty
    '                                Me.cob_despachador.Enabled = False
    '                                Me.cob_movimiento.Enabled = False
    '                                Return True
    '                                Exit Function
    '                            Else
    '                                MessageBox.Show("faile", "Bascula", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                                Return False
    '                                Exit Function
    '                            End If
    '                        End If
    '                    Next
    '                End If
    '            End With
    '        End If
    '        Return False
    '    Catch ex As Exception
    '        Return False
    '    End Try
    'End Function
    'Sub ticket_inicial()
    '    Dim Ticket As New CapaDato.CrearTicket

    '    Ticket.TextoCentro(Convert.ToString(UCase((Me.txt_razon.Text))))
    '    Ticket.TextoIzquierda("")
    '    Ticket.TextoCentro(Convert.ToString(UCase("ORDEN DE DESPACHO")))
    '    Ticket.TextoExtremos("CONTROL", "# " & Convert.ToString(UCase(Me.txt_control.Text)))
    '    Ticket.lineasAsteriscos()
    '    Ticket.TextoExtremos("PROVEEDOR", Convert.ToString(UCase(Me.cob_origen.Text)))
    '    Ticket.lineasIgual()
    '    Ticket.TextoExtremos("DESTINO", Convert.ToString(UCase(Me.cob_destino.Text)))
    '    Ticket.lineasIgual()
    '    'Sub cabecera.
    '    Ticket.TextoIzquierda("")
    '    Ticket.TextoIzquierda("TITULO: " & Convert.ToString(UCase(Me.cob_titulo.Text)))
    '    Ticket.TextoIzquierda("DESPACHADOR: " & Convert.ToString(UCase(Me.cob_despachador.Text)))
    '    Ticket.TextoIzquierda("CLIENTE: PUBLICO EN GENERAL")
    '    Ticket.TextoIzquierda("TIPO VEHICULO: " & Convert.ToString(UCase(Me.txt_tipo_vehiculo.Text)))
    '    Ticket.TextoIzquierda("PLACA: " & Convert.ToString(UCase(Me.txt_placa.Text)))
    '    Ticket.TextoIzquierda("CONDUCTOR: " & Convert.ToString(UCase(Me.txt_conductor.Text)))
    '    Ticket.TextoIzquierda("DOCUMENTO: " & Convert.ToString(UCase(Me.txt_docuemento.Text)))
    '    Ticket.TextoIzquierda("# RECIBO: " & Convert.ToString(UCase(Me.txt_recibo.Text)))
    '    Ticket.TextoIzquierda("CONTRATO: " & Convert.ToString(UCase(Me.cob_contrato.Text)))
    '    Ticket.TextoIzquierda("PRODUCTO: " & Convert.ToString(UCase(Me.cob_producto.Text)))
    '    Ticket.TextoIzquierda("PRESINTOS: " & Convert.ToString(UCase(Me.txt_observaciones.Text)))
    '    'Ticket.TextoExtremos("ENTRADA:" + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString())
    '    'Ticket.TextoExtremos("SALIDA:" + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString())
    '    Ticket.TextoExtremos("ENTRADA:" + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToLongTimeString())
    '    Ticket.TextoExtremos("SALIDA :" + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToLongTimeString())
    '    'Ticket.TextoIzquierda("DURACION: " & TimeValue(DateDiff(DateInterval.Minute, Me.DataGridView1.CurrentRow.Cells.Item(5).Value, Date.Now) & ":" & DateDiff(DateInterval.Second, Me.DataGridView1.CurrentRow.Cells.Item(5).Value, Date.Now)))
    '    Ticket.lineasAsteriscos()
    '    If Me.cob_movimiento.Text = "ENTRADA" Then
    '        Ticket.AgregarTotales("         PESOBRUTO...KG", Double.Parse(num.SoloNumeros(Me.txt_pesobruto.Text)))
    '        Ticket.AgregarTotales("         TARA........KG", Double.Parse(0))
    '        Ticket.AgregarTotales("         PESONETO....KG", Double.Parse(0))
    '    End If
    '    If Me.cob_movimiento.Text = "SALIDA" Then
    '        Ticket.AgregarTotales("         PESOBRUTO...KG", Double.Parse(0))
    '        Ticket.AgregarTotales("         TARA........KG", Double.Parse(Double.Parse(num.SoloNumeros(Me.txt_pesobruto.Text))))
    '        Ticket.AgregarTotales("         PESONETO....KG", Double.Parse(0))
    '    End If
    '    Ticket.TextoIzquierda("")
    '    Ticket.TextoCentro("¡GRACIAS POR PREFERIRNOS!")
    '    Ticket.TextoIzquierda("")
    '    Ticket.TextoIzquierda("")
    '    Ticket.TextoIzquierda("")
    '    Ticket.TextoIzquierda("")
    '    Ticket.CortaTicket()
    '    Ticket.ImprimirTicket(Convert.ToString(Me.cob_impresora.Text))
    'End Sub
    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Try
    '        Dim iddesp As New CapaNegocio.ClassPolimorfismoGetid(Me.cob_despachador, "idusuario", "usuario", "usuario")
    '        _iddespachador = Convert.ToInt32(iddesp.getid) 'extraer id del despachador
    '        If _iddespachador = 0 Then
    '            MessageBox.Show("Debes indicar el despachador", "Bascula", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Exit Sub
    '        End If
    '        If ti = False Then
    '            Call ticket_inicial()
    '        End If
    '        If procesarentrada() = True Then Exit Sub
    '        Call insert_bascula()
    '        Call cargarregistro()
    '        Call calcularpesajein()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString, "Bascula", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    'Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles checkticket.CheckedChanged

    'End Sub
    'Sub consultardtg()
    '    Try
    '        If Not IsNumeric(Me.txt_buscar_reg.Text) Then
    '            Dim dtg As New CapaNegocio.ClassConsultarDtg(Me.DataGridView1, Me.txt_buscar_reg.Text, "*", "v_despacho", "placa")
    '            Me.DataGridView1.DataSource = dtg.getdtg
    '        Else
    '            Dim dtg As New CapaNegocio.ClassConsultarDtg(Me.DataGridView1, Me.txt_buscar_reg.Text, "*", "v_despacho", "documento")
    '            Me.DataGridView1.DataSource = dtg.getdtg
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error al buscar el empleado", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub
    'Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar_reg.TextChanged
    '    Call consultardtg()
    '    Call calcularpesajein()
    'End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    Me.lbl_hora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)
    '    Me.lbl_hora.Text = FormatDateTime(Me.lbl_hora.Text, DateFormat.LongTime)
    'End Sub

    'Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
    '    FormVehiculo.ShowDialog()
    'End Sub
    'Private Sub cob_titulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cob_titulo.SelectedIndexChanged
    '    Try
    '        Dim objgetid As New CapaNegocio.ClassPolimorfismoGetid(Me.cob_titulo, "idtitulo", "titulo", "descripcion")
    '        _idtitulo = Convert.ToInt32(objgetid.getid)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error al cargar el titulo minero", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub
    'Private Sub cob_origen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cob_origen.SelectedIndexChanged
    '    Try
    '        Dim objgetid As New CapaNegocio.ClassPolimorfismoGetid(Me.cob_origen, "idorigen", "origen", "descripcion")
    '        _idorigen = Convert.ToInt32(objgetid.getid)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error al cargar el origen", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub
    'Private Sub cob_destino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cob_destino.SelectedIndexChanged
    '    Try
    '        Dim objgetid As New CapaNegocio.ClassPolimorfismoGetid(Me.cob_destino, "iddestino", "destino", "descripcion")
    '        _iddestino = Convert.ToInt32(objgetid.getid)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error al cargar el destino", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub
    'Private Sub cob_producto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cob_producto.SelectedIndexChanged
    '    Try
    '        Dim objgetid As New CapaNegocio.ClassPolimorfismoGetid(Me.cob_producto, "idproducto", "producto", "descripcion")
    '        _idproducto = Convert.ToInt32(objgetid.getid)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error al cargar el producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub

    'Private Sub cob_despachador_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cob_despachador.SelectedIndexChanged
    '    Try
    '        'Dim iddesp As New CapaNegocio.ClassPolimorfismoGetid(Me.cob_despachador, "idusuario", "usuario", "usuario")
    '        '_iddespachador = Convert.ToInt32(iddesp.getid) 'extraer id del despachador
    '        ' ''MsgBox(_iddespachador)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error al cargar el origen", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub

    'Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
    '    'frm_buscar_huella.ShowDialog()
    'End Sub

    ''Private Sub timer_mov_Tick(sender As Object, e As EventArgs) Handles timer_mov.Tick
    ''    'lbl_movimiento.Left -= 5
    ''    'If lbl_movimiento.Left <= -Width Then
    ''    '    lbl_movimiento.Left = Width
    ''    'End If
    ''End Sub

    'Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    '    frm_origen.ShowDialog()
    'End Sub

    'Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
    '    frm_destino.ShowDialog()
    'End Sub

    'Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click

    'End Sub
    'Private Sub cob_b_origen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cob_b_origen.SelectedIndexChanged
    '    Try
    '        Dim dtgcob As New CapaNegocio.ClassConsultarDtg(Me.DataGridView1, Me.cob_b_origen, "*", "v_despacho", "origen", "entrada")
    '        Me.DataGridView1.DataSource = dtgcob.getdtg
    '        Call calcularpesajein()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error al buscar", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub

    'Private Sub cob_b_destino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cob_b_destino.SelectedIndexChanged
    '    Try
    '        Dim dtgcob As New CapaNegocio.ClassConsultarDtg(Me.DataGridView1, Me.cob_b_destino, "*", "v_despacho", "destino", "entrada")
    '        Me.DataGridView1.DataSource = dtgcob.getdtg
    '        Call calcularpesajein()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error al buscar", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub

    'Private Sub cob_b_producto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cob_b_producto.SelectedIndexChanged
    '    Try
    '        Dim dtgcob As New CapaNegocio.ClassConsultarDtg(Me.DataGridView1, Me.cob_b_producto, "*", "v_despacho", "producto", "entrada")
    '        Me.DataGridView1.DataSource = dtgcob.getdtg
    '        Call calcularpesajein()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error al buscar", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub
    'Private Sub cob_b_despachador_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cob_b_despachador.SelectedIndexChanged
    '    Try
    '        Dim dtgcob As New CapaNegocio.ClassConsultarDtg(Me.DataGridView1, Me.cob_b_despachador, "*", "v_despacho", "despachador", "entrada")
    '        Me.DataGridView1.DataSource = dtgcob.getdtg
    '        Call calcularpesajein()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error al buscar", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub
    'Private Sub cob_b_conductor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cob_b_conductor.SelectedIndexChanged

    'End Sub

    'Private Sub cob_b_tipovehiculo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cob_b_tipovehiculo.SelectedIndexChanged
    '    Try
    '        Dim dtgcob As New CapaNegocio.ClassConsultarDtg(Me.DataGridView1, Me.cob_b_tipovehiculo, "*", "v_despacho", "tipovehiculo", "entrada")
    '        Me.DataGridView1.DataSource = dtgcob.getdtg
    '        Call calcularpesajein()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error al buscar", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub

    'Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    '    With Me.DataGridView1
    '        If .CurrentCell.ColumnIndex = 0 And Convert.ToString(.CurrentRow.Cells.Item(21).Value) = "transito" Then
    '            Me.cob_titulo.Text = Convert.ToString(.CurrentRow.Cells.Item(2).Value)
    '            Me.txt_control.Text = Convert.ToString(.CurrentRow.Cells.Item(16).Value)
    '            'Me.cob_despachador.Text = Convert.ToString(.CurrentRow.Cells.Item(16).Value)
    '            Me.cob_movimiento.Text = Convert.ToString(.CurrentRow.Cells.Item(3).Value)
    '            Me.cob_movimiento.Enabled = False
    '            Me.txt_placa.Text = Convert.ToString(.CurrentRow.Cells.Item(7).Value)
    '            Me.txt_tipo_vehiculo.Text = Convert.ToString(.CurrentRow.Cells.Item(8).Value)
    '            Me.txt_conductor.Text = Convert.ToString(.CurrentRow.Cells.Item(9).Value)
    '            Me.txt_docuemento.Text = Convert.ToString(.CurrentRow.Cells.Item(10).Value)
    '            Me.cob_origen.Text = Convert.ToString(.CurrentRow.Cells.Item(11).Value)
    '            Me.cob_destino.Text = Convert.ToString(.CurrentRow.Cells.Item(12).Value)
    '            Me.cob_producto.Text = Convert.ToString(.CurrentRow.Cells.Item(4).Value)
    '            Me.txt_observaciones.Text = Convert.ToString(.CurrentRow.Cells.Item(17).Value)
    '            Me.txt_recibo.Text = Convert.ToString(.CurrentRow.Cells.Item(19).Value)
    '            Me.cob_contrato.Text = Convert.ToString(.CurrentRow.Cells.Item(20).Value)
    '            Me.txt_pesobruto.Text = String.Empty
    '            Dim b As New CapaNegocio.ClassReset
    '            b.bloqueo(GroupBox1, False)
    '            tara = Double.Parse(.CurrentRow.Cells.Item(14).Value)
    '            Me.lbl_pesobruto.Text = FormatNumber(Double.Parse(.CurrentRow.Cells.Item(13).Value), 2)
    '            Me.lbl_tara.Text = FormatNumber(Double.Parse(.CurrentRow.Cells.Item(14).Value), 2)
    '            Me.lbl_pesoneto.Text = FormatNumber(Double.Parse(.CurrentRow.Cells.Item(15).Value), 2)
    '            bandera = True
    '            Me.cob_despachador.Enabled = False
    '            ti = True
    '        Else
    '        End If
    '    End With
    'End Sub
    'Public Sub calcularpesajein()
    '    Me.lbl_n_in.Text = Me.DataGridView1.Rows.Count()
    '    Me.lbl_pesobruto.Text = 0
    '    Me.lbl_tara.Text = 0
    '    Me.lbl_pesoneto.Text = 0
    '    With Me.DataGridView1
    '        For i As Integer = 0 To .Rows.Count() - 1
    '            Me.lbl_pesobruto.Text += Double.Parse(Me.DataGridView1(13, i).Value)
    '            Me.lbl_tara.Text += Double.Parse(Me.DataGridView1(14, i).Value)
    '            Me.lbl_pesoneto.Text += Double.Parse(Me.DataGridView1(15, i).Value)
    '        Next
    '    End With
    '    Me.lbl_pesobruto.Text = Format(Double.Parse(Me.lbl_pesobruto.Text), "#,##0.0")
    '    Me.lbl_tara.Text = Format(Double.Parse(Me.lbl_tara.Text), "#,##0.0")
    '    Me.lbl_pesoneto.Text = Format(Double.Parse(Me.lbl_pesoneto.Text), "#,##0.0")
    'End Sub
    'Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
    '    If Me.DataGridView1.CurrentCell.ColumnIndex <> 0 Then
    '        Dim inv As New frm_invertir
    '        With inv
    '            .WindowState = FormWindowState.Normal
    '            .StartPosition = FormStartPosition.CenterScreen
    '            .lbl_mov_act.Text = Convert.ToString(Me.DataGridView1.CurrentRow.Cells.Item(3).Value)
    '            If Convert.ToString(Me.DataGridView1.CurrentRow.Cells.Item(3).Value) = "entrada" Then
    '                .lbl_mov_inv.Text = "salida"
    '            End If

    '            If Convert.ToString(Me.DataGridView1.CurrentRow.Cells.Item(3).Value) = "salida" Then
    '                .lbl_mov_inv.Text = "entrada"
    '            End If

    '            If Convert.ToString(Me.DataGridView1.CurrentRow.Cells.Item(3).Value) = "entrada" Then
    '                .lbl_pb_act.Text = Format(Double.Parse(Me.DataGridView1.CurrentRow.Cells.Item(13).Value), fm)
    '                If Double.Parse(Me.DataGridView1.CurrentRow.Cells.Item(13).Value) > 0 Then
    '                    .lbl_pb_inv.Text = Format(0, fm)
    '                    .lbl_tara_act.Text = Format(0, fm)
    '                    .lbl_tara_inv.Text = Format(Double.Parse(Me.DataGridView1.CurrentRow.Cells.Item(13).Value), fm)
    '                End If
    '            End If
    '            If Convert.ToString(Me.DataGridView1.CurrentRow.Cells.Item(3).Value) = "salida" Then
    '                .lbl_tara_act.Text = Format(Double.Parse(Me.DataGridView1.CurrentRow.Cells.Item(14).Value), fm)
    '                If Double.Parse(Me.DataGridView1.CurrentRow.Cells.Item(14).Value) > 0 Then
    '                    .lbl_pb_act.Text = Format(0, fm)
    '                    .lbl_tara_inv.Text = Format(0, fm)
    '                    .lbl_pb_inv.Text = Format(Double.Parse(Me.DataGridView1.CurrentRow.Cells.Item(14).Value), fm)
    '                End If
    '            End If
    '            If Convert.ToString(Me.DataGridView1.CurrentRow.Cells.Item(3).Value) = "entrada" Then
    '                .lbl_idmov.Text = 1
    '            Else
    '                .lbl_idmov.Text = 2
    '            End If
    '            .lbl_iddesp.Text = Me.DataGridView1.CurrentRow.Cells.Item(1).Value
    '            .ShowDialog()
    '        End With
    '    End If

    'End Sub
    'Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
    '    If e.ColumnIndex = 13 Then
    '        e.CellStyle.BackColor = Color.LightBlue
    '    End If
    '    If e.ColumnIndex = 14 Then
    '        e.CellStyle.BackColor = Color.LightSkyBlue
    '    End If
    '    If e.ColumnIndex = 15 Then
    '        e.CellStyle.BackColor = Color.LightSteelBlue
    '    End If

    'End Sub
    'Private Sub DataGridView1_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles DataGridView1.RowStateChanged
    '    'Call calcularpesajein()
    'End Sub

    'Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
    '    'Me.lbl_n_in.Text = Me.DataGridView1.Rows.Count()
    'End Sub
    'Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
    '    Try
    '        Cursor = System.Windows.Forms.Cursors.WaitCursor
    '        'Dim excel As New CapaNegocio.ClassExportarExcel(Me.DataGridView1)
    '        Cursor = System.Windows.Forms.Cursors.Default
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error al exportar a excel", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub
    'Private Sub r_comp_CheckedChanged(sender As Object, e As EventArgs) Handles r_comp.CheckedChanged
    '    If Me.r_comp.Checked Then
    '        Call completa()
    '        Call calcularpesajein()
    '    End If
    'End Sub
    'Private Sub r_tran_CheckedChanged(sender As Object, e As EventArgs) Handles r_tran.CheckedChanged
    '    If Me.r_tran.Checked Then
    '        Call cargarregistro()
    '        Call calcularpesajein()
    '    End If
    'End Sub
    'Private Sub r_all_CheckedChanged(sender As Object, e As EventArgs) Handles r_all.CheckedChanged
    '    If Me.r_all.Checked Then
    '        Call cargarentradasall()
    '        Call calcularpesajein()
    '    End If
    'End Sub
    'Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter
    'End Sub
    'Private Sub Button4_Click(sender As Object, e As EventArgs)

    'End Sub

    'Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
    '    frm_reimprimir.ShowDialog()
    'End Sub

    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    '    Me.Button2.Enabled = True
    'End Sub

    'Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    'End Sub

    'Private Sub cob_contrato_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cob_contrato.SelectedIndexChanged
    '    Try
    '        Dim objgetid As New CapaNegocio.ClassPolimorfismoGetid(Me.cob_contrato, "idcontrato", "contrato", "descripcion")
    '        _idcontrato = Convert.ToInt32(objgetid.getid)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error al cargar el destino", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub
    'Private Sub cob_b_despachador_SelectedValueChanged(sender As Object, e As EventArgs) Handles cob_b_despachador.SelectedValueChanged
    '    Dim iddesp As New CapaNegocio.ClassPolimorfismoGetid(Me.cob_despachador, "idusuario", "usuario", "usuario")
    '    _iddespachador = Convert.ToInt32(iddesp.getid) 'extraer id del despachador
    'End Sub

    'Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    'End Sub

    'Private Sub cob_movimiento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cob_movimiento.SelectedIndexChanged
    '    Try
    '        Dim objgetid As New CapaNegocio.ClassPolimorfismoGetid(Me.cob_movimiento, "idmovimiento", "movimiento", "descripcion")
    '        _idmovimiento = Convert.ToInt32(objgetid.getid)
    '        Me.lbl_movimiento.Text = UCase(Me.cob_movimiento.Text)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error al cargar el origen", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try

    'End Sub

    'Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
    '    'frm_buscar_huella.ShowDialog()
    'End Sub

    'Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
    '    Me.Close()
    'End Sub

    'Private Sub lbl_hora_Click(sender As Object, e As EventArgs) Handles lbl_hora.Click
    '    frm_clave.ShowDialog()
    'End Sub

    'Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
    '    frm_productos.ShowDialog()
    'End Sub
    'Sub conexionserial()
    '    Try
    '        With SerialPort1
    '            .Close()
    '            .BaudRate = 9600
    '            .DataBits = 8
    '            .Parity = IO.Ports.Parity.None
    '            .StopBits = 1
    '            .PortName = "COM7"
    '            .Open()
    '            If .IsOpen Then
    '                lbl_serial.Text = "Conectado"
    '            Else
    '                MessageBox.Show("Conexion Fallido!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            End If
    '        End With
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Status", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub
    'Private Sub Button8_Click(sender As Object, e As EventArgs) Handles BtnConectar.Click
    '    Call conexionserial()
    'End Sub
    'Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
    '    Dim n As Integer
    '    Try
    '        UpdateFormDelegate1 = New UpdateFormDelegate(AddressOf UpdateDisplay)
    '        n = SerialPort1.BytesToRead ' capturamos el numero de bytes leidos
    '        If n > 50 Then
    '            ComBuffer = New Byte(n - 1) {} 'redimensionamos
    '            SerialPort1.Read(ComBuffer, 0, n) 'leemos el dato
    '            Me.Invoke(UpdateFormDelegate1)
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
    'Private Sub UpdateDisplay()
    '    'variables locales
    '    Dim incoming As String = ""
    '    Dim longBuffer As Long
    '    Dim i As Integer
    '    'calcularmos la longitud del buffer y guardamos la información en una variable
    '    longBuffer = ComBuffer.Length
    '    For i = 0 To longBuffer - 1
    '        incoming = incoming & Chr(ComBuffer(i))
    '    Next
    '    strReturn = incoming.ToString
    '    'ahora solo tenemos que formatear la cadena tal como deseemos.
    '    'Yo conecte el puerto a una báscula por tanto necesito capturar el dato del pesaje
    '    '------------------------------------------------
    '    If strReturn.Length > 2 Then
    '        i = 0
    '        strPeso = ""
    '        Dim blnLeyoNumero As Boolean
    '        For i = 1 To strReturn.Length
    '            car = Mid(strReturn, i, 1)
    '            If IsNumeric(car) Or car = "." Then
    '                strPeso = strPeso & car
    '                blnLeyoNumero = True
    '            Else
    '                If blnLeyoNumero Then Exit For
    '            End If
    '        Next
    '    End If
    '    '--------------------------------------------------
    '    'Listo ahora el dato lo mostramos en la cajita de texto, ahora si a probarlo
    '    Me.txt_pesobruto.Text = strPeso
    'End Sub
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    'End Sub

    'Private Sub timer_mov_Tick(sender As Object, e As EventArgs) Handles timer_mov.Tick

    'End Sub

    'Private Sub cob_impresora_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cob_impresora.SelectedIndexChanged

    'End Sub

    'Private Sub txt_control_TextChanged(sender As Object, e As EventArgs) Handles txt_control.TextChanged


    'End Sub

    'Private Sub ComboPorts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboPorts.SelectedIndexChanged

    'End Sub

    'Private Sub txt_pesobruto_TextChanged(sender As Object, e As EventArgs) Handles txt_pesobruto.TextChanged

    'End Sub

    Private Sub cob_movimiento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cob_movimiento.SelectedIndexChanged

    End Sub

    Private Sub cob_despachador_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cob_despachador.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class
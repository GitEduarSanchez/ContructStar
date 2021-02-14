Imports DPFP
Imports DPFP.Capture
Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.IO
Imports CapaDatos
Public Class frm_capturar
    Implements DPFP.Capture.EventHandler
    Dim enrolar As New DPFP.Processing.Enrollment
    Dim cnn As New CapaDatos.ClassConexion
    Private captura As DPFP.Capture.Capture
    Private Delegate Sub delegadomuestra(ByVal text As String)
    Private template As New DPFP.Template
    Private Delegate Sub delagatecontroles()

    Private Sub mostarveces(ByVal texto As String)
        If vecesdedo.InvokeRequired Then
            Dim deleg As New delegadomuestra(AddressOf mostarveces)
            Me.Invoke(deleg, New Object() {texto})
        Else
            vecesdedo.Text = texto.ToString()
        End If
    End Sub
    Private Sub modificarcontroles()
        If Me.txt_usuario.InvokeRequired Then
            Dim delag As New delagatecontroles(AddressOf modificarcontroles)
            Me.Invoke(delag, New Object() {})
        Else
            Me.txt_usuario.Enabled = True
            Me.btn_guardar.Enabled = True
        End If
    End Sub
    Protected Overridable Sub iniciar()
        Try
            captura = New DPFP.Capture.Capture()
            enrolar = New DPFP.Processing.Enrollment()
            Dim text As New StringBuilder()
            text.AppendFormat("Nesecitas pasar el dedo {0} veces ", enrolar.FeaturesNeeded)
            vecesdedo.Text = text.ToString()
            If Not captura Is Nothing Then
                captura.EventHandler = Me
            Else
                MessageBox.Show("no se puede inicializar la captura", "Huella", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("no se puede inicializar la captura", "Huella", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Protected Overridable Sub iniciarCaptura()
        Try
            If Not captura Is Nothing Then
                captura.StartCapture()
            Else
                MessageBox.Show("no se puede inicializar la captura", "Huella", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("no se puede inicializar la captura", "Huella", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Protected Overridable Sub pararCaptura()
        Try
            If Not captura Is Nothing Then
                captura.StopCapture()
            Else
                MessageBox.Show("no se detener la captura inicializar la captura", "Huella", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("no se puede detener la captura", "Huella", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Protected Function convertirSampleMapaBits(ByVal sample As DPFP.Sample) As Bitmap
        Dim conversor As New DPFP.Capture.SampleConversion()
        Dim mapabits As Bitmap = Nothing
        conversor.ConvertToPicture(sample, mapabits)
        Return mapabits
    End Function
    Private Sub generarImagen(ByVal bmp)
        Me.PictureBox1.Image = bmp
    End Sub
    Protected Function obtenerCaracteristica(ByVal sample As DPFP.Sample, ByVal purpose As DPFP.Processing.DataPurpose) As DPFP.FeatureSet
        Dim extractor As New DPFP.Processing.FeatureExtraction()
        Dim feedback As DPFP.Capture.CaptureFeedback = DPFP.Capture.CaptureFeedback.None
        Dim propiedades As New DPFP.FeatureSet()
        extractor.CreateFeatureSet(sample, purpose, feedback, propiedades)
        If feedback = DPFP.Capture.CaptureFeedback.Good Then
            Return propiedades
        Else
            Return Nothing
        End If
    End Function

    Private Sub frm_capturar_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciar()
        iniciarCaptura()

        Me.txt_usuario.Enabled = False
        Me.txt_usuario.Text = frm_usuario.txt_usuario.Text
    End Sub

    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As Sample) Implements EventHandler.OnComplete
        generarImagen(convertirSampleMapaBits(Sample))
        procesar(Sample)

    End Sub

    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerGone

    End Sub

    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerTouch
        'MessageBox.Show("AH PULSADO EL LECTOR")
    End Sub

    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderConnect

    End Sub

    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderDisconnect

    End Sub

    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As CaptureFeedback) Implements EventHandler.OnSampleQuality

    End Sub

    Protected Function extraercarecteristica(ByVal sample As DPFP.Sample, ByVal purpose As DPFP.Processing.DataPurpose) As DPFP.FeatureSet
        Dim extractor As New DPFP.Processing.FeatureExtraction()
        Dim alimentacion As DPFP.Capture.CaptureFeedback = DPFP.Capture.CaptureFeedback.None
        Dim caracteristicas As New DPFP.FeatureSet()
        extractor.CreateFeatureSet(sample, purpose, alimentacion, caracteristicas)
        If alimentacion = DPFP.Capture.CaptureFeedback.Good Then
            Return caracteristicas
        Else
            Return Nothing
            MessageBox.Show("nada", "Huella", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Function
    Protected Sub procesar(ByVal sample As DPFP.Sample)
        Dim caracteristicas As DPFP.FeatureSet = extraercarecteristica(sample, Processing.DataPurpose.Enrollment)
        If Not caracteristicas Is Nothing Then
            Try
                enrolar.AddFeatures(caracteristicas)
            Finally
                Dim text As New StringBuilder()
                text.AppendFormat("Nesecitas pasar el dedo {0} veces ", enrolar.FeaturesNeeded)
                mostarveces(text.ToString())
                Select Case enrolar.TemplateStatus
                    Case DPFP.Processing.Enrollment.Status.Ready
                        template = enrolar.Template
                        pararCaptura()
                        modificarcontroles()
                    Case Processing.Enrollment.Status.Failed
                        enrolar.Clear()
                        pararCaptura()
                        iniciarCaptura()
                End Select
            End Try
        End If
    End Sub
    Sub insert()
        'Dim cnn As New MySqlConnectionStringBuilder()
        'cnn.Server = "127.0.0.1"
        'cnn.Database = "digitalperson"
        'cnn.UserID = "root"
        'cnn.Password = ""
        Dim conexion As MySqlConnection
        conexion = cnn.conectar
        Dim cmd As New MySqlCommand
        cmd = conexion.CreateCommand
        If Me.txt_usuario.Text = String.Empty Then
            MessageBox.Show("indica el nombre", "Huella", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            cmd.CommandText = "insert into datos(usuario,huella) values(?,?)"
            'Me.txt_nombre.Text = Convert.ToString(frm_empleados.txt_documento_emp.Text.ToString)
            cmd.Parameters.AddWithValue("usuario", Me.txt_usuario.Text.ToString())
            Using h As New MemoryStream(template.Bytes)
                cmd.Parameters.AddWithValue("huella", h.ToArray())
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                conexion.Close()
                conexion.Dispose()
                MessageBox.Show("Huella Guardada con éxito", "Huella", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.txt_usuario.Enabled = False

                'enrolar.Clear()
                'iniciarCaptura()
            End Using
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        insert()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        pararCaptura()
        Dim f As New frm_buscar_huella()
        f.Show()
    End Sub

    Private Sub Form1_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        pararCaptura()
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            iniciar()
            iniciarCaptura()
        Catch ex As Exception
            pararCaptura()
        End Try
       
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        insert()
    End Sub
End Class

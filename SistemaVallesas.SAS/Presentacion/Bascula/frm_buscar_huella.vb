Imports DPFP
Imports DPFP.Capture
Imports System.Text
Imports MySql.Data.MySqlClient
Imports CapaDatos
Public Class frm_buscar_huella
    Implements DPFP.Capture.EventHandler
    Private captura As DPFP.Capture.Capture
    Dim cnn As New CapaDatos.ClassConexion
    Private template As DPFP.Template
    Private verificador As DPFP.Verification.Verification
    Dim cd As New CapaNegocio.ClassCedula
    'Public cedula_ As String = String.Empty
    Public Delegate Sub delagatecontroles(ByVal text As String)
    Public Delegate Sub pasarcedula(ByVal formcedula As String)

    'Public casilla As New System.Windows.Forms.TextBox
    Public Sub modificarcontroles(ByVal cedula As String)
        If Me.txt_cedula.InvokeRequired Then
            Dim delag As New delagatecontroles(AddressOf modificarcontroles)
            Me.Invoke(delag, New Object() {cedula})
        Else
            Me.txt_cedula.Text = cedula
            Me.txt_cedula.Enabled = False
        End If
    End Sub
    Public Sub cedula(ByVal pasarcedula As String)
        If Me.txt_cedula.InvokeRequired Then
            Dim delag As New pasarcedula(AddressOf cedula)
            Me.Invoke(delag, New Object() {pasarcedula})
        Else
            frm_despacho.cob_despachador.Text = pasarcedula
           
        End If
    End Sub

    Protected Overridable Sub iniciar()
        Try
            captura = New DPFP.Capture.Capture()

            If Not captura Is Nothing Then
                captura.EventHandler = Me
                template = New DPFP.Template
                verificador = New DPFP.Verification.Verification
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

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        pararCaptura()
        Me.PictureBox1.Image = Nothing
        Me.txt_cedula.Text = String.Empty
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciar()
        iniciarCaptura()
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
    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As DPFP.Sample) Implements DPFP.Capture.EventHandler.OnComplete
        generarImagen(convertirSampleMapaBits(Sample))
        Dim caracteristicas As DPFP.FeatureSet = extraercarecteristica(Sample, Processing.DataPurpose.Verification)
        If Not caracteristicas Is Nothing Then
            Dim result As New DPFP.Verification.Verification.Result()
            'Dim cnn As New MySqlConnectionStringBuilder()
            'cnn.Server = "127.0.0.1"
            'cnn.Database = "digitalperson"
            'cnn.UserID = "root"
            'cnn.Password = ""
            Dim conexion As MySqlConnection
            conexion = cnn.conectar
            Dim cmd As New MySqlCommand
            cmd = conexion.CreateCommand
            cmd.CommandText = "select * from datos"
            Dim r As MySqlDataReader
            r = cmd.ExecuteReader
            Dim verificado As Boolean = False
            While r.Read()
                cd.cedula_ = r("usuario")
                Dim m As New IO.MemoryStream(CType(r("huella"), Byte()))
                template.DeSerialize(m.ToArray())
                verificador.Verify(caracteristicas, template, result)
                If result.Verified Then
                    cd.cedula_ = r("usuario")
                    verificado = True
                    Exit While
                End If
            End While
            If verificado = True Then
                'MessageBox.Show(cd.cedula_)
                modificarcontroles(cd.cedula_)
                cedula(cd.cedula_)
            Else
                MessageBox.Show("No se encuentran datos asociados a esta huella por favor intente de nuevo", "Huella", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            r.Dispose()
            cmd.Dispose()
            conexion.Close()
            conexion.Dispose()
        End If
    End Sub
    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerGone

    End Sub

    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerTouch

    End Sub

    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderConnect

    End Sub

    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderDisconnect

    End Sub

    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As DPFP.Capture.CaptureFeedback) Implements DPFP.Capture.EventHandler.OnSampleQuality

    End Sub

    Private Sub Form2_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        'cd.cedula_ = Me.txt_cedula.Text.ToString
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        pararCaptura()
    End Sub
End Class
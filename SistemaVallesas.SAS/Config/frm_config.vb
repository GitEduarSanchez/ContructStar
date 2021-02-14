Imports System.Net
Imports CapaNegocio
'Imports CapaDato
Public Class frm_config
    Dim IPaddress_ As String
    Dim cadena As New ClassConexionPortable
    Dim data As String
    Dim IP As New CapaNegocio.ClassIP

    'Public Function parse(ipAddr As String) As Boolean
    '    Try
    '        ' Create an instance of IPAddress for the specified address string (in 
    '        ' dotted-quad, or colon-hexadecimal notation).
    '        Dim address As IPAddress = IPAddress.Parse(ipAddr)

    '        ' Display the address in standard notation.
    '        Console.WriteLine(("Parsing your input string: " + """" + ipAddr + """" + " produces this address (shown in its standard notation): " + address.ToString()))
    '        Return True
    '    Catch e As ArgumentNullException
    '        Console.WriteLine("ArgumentNullException caught!!!")
    '        Console.WriteLine(("Source : " + e.Source))
    '        Console.WriteLine(("Message : " + e.Message))
    '        Return False
    '    Catch e As FormatException
    '        Console.WriteLine("FormatException caught!!!")
    '        Console.WriteLine(("Source : " + e.Source))
    '        Console.WriteLine(("Message : " + e.Message))
    '        Return False
    '    Catch e As Exception
    '        Console.WriteLine("Exception caught!!!")
    '        Console.WriteLine(("Source : " + e.Source))
    '        Console.WriteLine(("Message : " + e.Message))
    '        Return False

    '    End Try

    'End Function 'parse 

    'Public Shared Function Parse(ipString As String) As IPAddress


    'End Function
   

   
    Private Sub bnt_probar_Click(sender As Object, e As EventArgs) Handles bnt_probar.Click
        Try
            If IP.EsIP(Me.txt_servidor.Text) = False Then
                MessageBox.Show("ip invalida")
                Exit Sub
            End If
            With Me.txt_servidor
                If .Text = String.Empty Then
                    MessageBox.Show("Debes indicar el ip del servidor", "rectifica",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .Text = Convert.ToDouble(0)
                    .Focus()
                    .BackColor = Color.Aquamarine
                    Exit Sub
                Else
                    .BackColor = Color.White
                End If
            End With
            With Me.txt_db
                If .Text = String.Empty Then
                    MessageBox.Show("Debes indicar el nombre de la base de dato", "rectifica",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .Text = Convert.ToDouble(0)
                    .Focus()
                    .BackColor = Color.Aquamarine
                    Exit Sub
                Else
                    .BackColor = Color.White
                End If
            End With
            With Me.txt_usuario
                If .Text = String.Empty Then
                    MessageBox.Show("Debes indicar el nombre de usuario", "rectifica",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .Text = Convert.ToDouble(0)
                    .Focus()
                    .BackColor = Color.Aquamarine
                    Exit Sub
                Else
                    .BackColor = Color.White
                End If
            End With
            Data = "Server=" & txt_servidor.Text & ";Database=" & txt_db.Text & ";Uid=" & txt_usuario.Text & ";Pwd=" & txt_contraseña.Text & ""
            If cadena.ProbarConexion(Data) Then
                MessageBox.Show("ok")
            Else
                MessageBox.Show("faile")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Try
            If IP.EsIP(Me.txt_servidor.Text) = False Then
                MessageBox.Show("ip invalida")
                Exit Sub
            End If
            With Me.txt_servidor
                If .Text = String.Empty Then
                    MessageBox.Show("Debes indicar el ip del servidor", "rectifica",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .Text = Convert.ToDouble(0)
                    .Focus()
                    .BackColor = Color.Aquamarine
                    Exit Sub
                Else
                    .BackColor = Color.White
                End If
            End With
            With Me.txt_db
                If .Text = String.Empty Then
                    MessageBox.Show("Debes indicar el nombre de la base de dato", "rectifica",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .Text = Convert.ToDouble(0)
                    .Focus()
                    .BackColor = Color.Aquamarine
                    Exit Sub
                Else
                    .BackColor = Color.White
                End If
            End With
            With Me.txt_usuario
                If .Text = String.Empty Then
                    MessageBox.Show("Debes indicar el nombre de usuario", "rectifica",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .Text = Convert.ToDouble(0)
                    .Focus()
                    .BackColor = Color.Aquamarine
                    Exit Sub
                Else
                    .BackColor = Color.White
                End If
            End With
            My.Settings.cnn = "Server=" & txt_servidor.Text & ";Database=" & txt_db.Text & ";Uid=" & txt_usuario.Text & ";Pwd=" & txt_contraseña.Text & ""
            My.Settings.Save()
            MessageBox.Show("La Conexion se guardo correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
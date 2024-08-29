Public Class ctlPrivacy
    Dim username As String
    Dim password As String
    Dim host As String

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles usPic.Click
        usPic.BackColor = Color.White
        username = "freevpn"
        host = "83.170.115.92"
        password = "account"
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        username = "free"
        host = "65.111.173.161"
        password = "1234"
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        username = "freevpn"
        host = "108.163.169.44"
        password = "1234"
    End Sub

    Private Sub MyButton2_Click(sender As Object, e As EventArgs) Handles MyButton2.Click
        Dim vpnDir As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector\"

        If Not IO.Directory.Exists(vpnDir) Then
            IO.Directory.CreateDirectory(vpnDir)
        End If

        ' Create connection.pbk
        Dim pbkContent As String = "[VPN]" & vbNewLine & "MEDIA=rastapi" & vbNewLine & "Port=VPN2-0" & vbNewLine & "Device=WAN Miniprot (IKEv2)" & vbNewLine & "DEVICE=vpn" & vbNewLine & "PhoneNumber=" & host
        IO.File.WriteAllText(vpnDir & "connection.pbk", pbkContent)

        ' Create connection.bat
        Dim batContent As String = "rasdial ""VPN"" " & username & " " & password & " /phonebook:" & """" & vpnDir & "connection.pbk" & """"
        IO.File.WriteAllText(vpnDir & "connection.bat", batContent)

        Dim connect As New System.Diagnostics.Process()
        connect.StartInfo.FileName = vpnDir & "connection.bat"
        connect.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        connect.StartInfo.RedirectStandardError = True
        connect.StartInfo.UseShellExecute = False
        connect.Start()

        Dim errorMsg As String = connect.StandardError.ReadToEnd()
        connect.WaitForExit()

        If connect.ExitCode = 0 Then
            Label1.Text = "Connected - your new IP address is " & host
            Label1.ForeColor = Color.Green
            PictureBox2.Image = My.Resources.connected
        Else
            Label1.Text = "Connection failed: " & errorMsg
            Label1.ForeColor = Color.Red
            PictureBox2.Image = My.Resources.disconnected
        End If
    End Sub

    Private Sub MyButton1_Click(sender As Object, e As EventArgs) Handles MyButton1.Click
        Dim vpnDir As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector\"

        IO.File.WriteAllText(vpnDir & "disconnect.bat", "rasdial /d")

        Dim connect As New System.Diagnostics.Process()
        connect.StartInfo.FileName = vpnDir & "disconnect.bat"
        connect.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        connect.StartInfo.RedirectStandardError = True
        connect.StartInfo.UseShellExecute = False
        connect.Start()

        Dim errorMsg As String = connect.StandardError.ReadToEnd()
        connect.WaitForExit()

        If connect.ExitCode = 0 Then
            Label1.Text = "Disconnected"
            Label1.ForeColor = Color.Red
            PictureBox2.Image = My.Resources.disconnected
        Else
            Label1.Text = "Disconnection failed: " & errorMsg
            Label1.ForeColor = Color.Red
        End If
    End Sub
End Class

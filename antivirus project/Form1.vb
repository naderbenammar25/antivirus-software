Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports antivirus_project.My

Public Class Form1



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.ActivationStatus = False Then
            CtlSubscription1.BringToFront()
            CtlSubscription1.Visible = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lblTitle.Click
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        frmPopUp.ShowDialog()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, headerPanel.MouseDown, lblTitle.MouseDown
        If e.Button = MouseButtons.Left Then
            MyFunctions.ReleaseCapture()
            MyFunctions.SendMessage(Handle, MyFunctions.WM_NCLBUTTONDOWN, MyFunctions.HT_CAPTION, 0)
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click

    End Sub

    Private Sub btnDash2_Click(sender As Object, e As EventArgs) Handles btndash2.Click
        MyFunctions.dashClick()


    End Sub

    Private Sub btnScan2_Click(sender As Object, e As EventArgs) Handles btnScan2.Click
        MyFunctions.scanCenterClick()


    End Sub

    Private Sub btnPriv2_Click(sender As Object, e As EventArgs) Handles btnPriv2.Click
        MyFunctions.privacyClick()
        If My.Settings.ActivationStatus = True Then
            CtlPremium1.BringToFront()
            CtlPremium1.Visible = True
        Else
            CtlPrivacy1.BringToFront()
            CtlPrivacy1.Visible = True
        End If






    End Sub

    Private Sub btnPerf2_Click(sender As Object, e As EventArgs) Handles btnPerf2.Click
        MyFunctions.PerfClick()
        If My.Settings.ActivationStatus = False Then
            CtlPremium1.BringToFront()
            CtlPremium1.Visible = True
        Else
            CtlSysPrerformance1.BringToFront()
            CtlSysPrerformance1.Visible = True
        End If



    End Sub

    Private Sub btnAcc2_Click(sender As Object, e As EventArgs) Handles btnAcc2.Click
        MyFunctions.AccountClick()


    End Sub

    Private Sub btnSett2_Click(sender As Object, e As EventArgs)
        MyFunctions.SettingsClick()


    End Sub

    Private Sub btnHelp2_Click(sender As Object, e As EventArgs)
        MyFunctions.HelpClick()


    End Sub


    Private Sub StlScan21_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub CtlSysPrerformance1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub mainPanel_Paint(sender As Object, e As PaintEventArgs) Handles mainPanel.Paint

    End Sub

    Private Sub imgPref_Click(sender As Object, e As EventArgs) Handles imgPref.Click
        frmSettings.ShowDialog()
    End Sub

    Private Sub imgHelp_Click(sender As Object, e As EventArgs) Handles imgHelp.Click
        Try
            Dim psi As New ProcessStartInfo()
            psi.FileName = MyStrings.HelpLink
            psi.UseShellExecute = True
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub MyButton1_Click(sender As Object, e As EventArgs) Handles MyButton1.Click
        CtlSubscription1.BringToFront()
        CtlSubscription1.Visible = True
    End Sub
End Class

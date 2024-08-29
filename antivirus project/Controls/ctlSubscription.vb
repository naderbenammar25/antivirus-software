Public Class ctlSubscription
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

    Private Sub btndash2_Click(sender As Object, e As EventArgs) Handles btndash2.Click
        Try
            Dim psi As New ProcessStartInfo()
            psi.FileName = MyStrings.SubscriptionLink
            psi.UseShellExecute = True
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub MyButton1_Click(sender As Object, e As EventArgs) Handles MyButton1.Click
        Try
            Dim psi As New ProcessStartInfo()
            psi.FileName = MyStrings.SubscriptionLink
            psi.UseShellExecute = True
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub MyButton2_Click(sender As Object, e As EventArgs) Handles MyButton2.Click
        Try
            Dim psi As New ProcessStartInfo()
            psi.FileName = MyStrings.SubscriptionLink
            psi.UseShellExecute = True
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmSerialKey.ShowDialog()
    End Sub
End Class

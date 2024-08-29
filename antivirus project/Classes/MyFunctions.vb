Imports System.Runtime.InteropServices

Public Class MyFunctions
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2
    <DllImport("user32.dll", SetLastError:=True)>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    <DllImport("user32.dll", SetLastError:=True)>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    Public Shared Sub privacyClick()



        With Form1.btndash2
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.Deactive_color2
        End With
        Form1.imgDash.BackColor = MyColors.imageDeactiveColor

        With Form1.btnScan2
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.Deactive_color2
        End With
        Form1.imgProtec.BackColor = MyColors.imageDeactiveColor

        With Form1.btnPriv2
            .BottomColor = MyColors.active_color1
            .TopColor = MyColors.active_color2
        End With
        Form1.imgPriv.BackColor = MyColors.imageActiveColor

        With Form1.btnPerf2
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.Deactive_color2
        End With
        Form1.imgNotif.BackColor = MyColors.imageDeactiveColor

        With Form1.btnAcc2
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.Deactive_color2
        End With
        Form1.imgAccount.BackColor = MyColors.imageDeactiveColor
    End Sub

    Public Shared Sub scanCenterClick()
        With Form1.btndash2
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.Deactive_color2
        End With
        Form1.imgDash.BackColor = MyColors.imageDeactiveColor
        Form1.StlScan21.BringToFront()
        Form1.StlScan21.Visible = True

        With Form1.btnScan2
            .BottomColor = MyColors.active_color1
            .TopColor = MyColors.active_color2
        End With
        Form1.imgProtec.BackColor = MyColors.imageActiveColor

        With Form1.btnPriv2
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.Deactive_color2
        End With
        Form1.imgPriv.BackColor = MyColors.imageDeactiveColor

        With Form1.btnPerf2
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.Deactive_color2
        End With
        Form1.imgNotif.BackColor = MyColors.imageDeactiveColor

        With Form1.btnAcc2
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.Deactive_color2
        End With
        Form1.imgAccount.BackColor = MyColors.imageDeactiveColor
    End Sub

    Public Shared Sub PerfClick()


        With Form1.btndash2
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.Deactive_color2
        End With
        Form1.imgDash.BackColor = MyColors.imageDeactiveColor

        With Form1.btnScan2
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.Deactive_color2
        End With
        Form1.imgProtec.BackColor = MyColors.imageDeactiveColor

        With Form1.btnPriv2
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.Deactive_color2
        End With
        Form1.imgPriv.BackColor = MyColors.imageDeactiveColor

        With Form1.btnPerf2
            .BottomColor = MyColors.active_color1
            .TopColor = MyColors.active_color2
        End With
        Form1.imgNotif.BackColor = MyColors.imageActiveColor

        With Form1.btnAcc2
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.Deactive_color2
        End With
        Form1.imgAccount.BackColor = MyColors.imageDeactiveColor

    End Sub
    Public Shared Sub AccountClick()
        Form1.CtlAccount1.BringToFront()
        Form1.CtlAccount1.Visible = True
        With Form1.btndash2
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.Deactive_color2
        End With
        Form1.imgDash.BackColor = MyColors.imageDeactiveColor

        With Form1.btnScan2
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.Deactive_color2
        End With
        Form1.imgProtec.BackColor = MyColors.imageDeactiveColor

        With Form1.btnPriv2
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.Deactive_color2
        End With
        Form1.imgPriv.BackColor = MyColors.imageDeactiveColor

        With Form1.btnPerf2
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.Deactive_color2
        End With
        Form1.imgNotif.BackColor = MyColors.imageDeactiveColor

        With Form1.btnAcc2
            .BottomColor = MyColors.active_color1
            .TopColor = MyColors.active_color2
        End With
        Form1.imgAccount.BackColor = MyColors.imageActiveColor
    End Sub
    Public Shared Sub SettingsClick()
        With Form1.btndash2
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.Deactive_color2
        End With
        Form1.imgDash.BackColor = MyColors.imageDeactiveColor

        With Form1.btnScan2
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.Deactive_color2
        End With
        Form1.imgProtec.BackColor = MyColors.imageDeactiveColor

        With Form1.btnPriv2
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.Deactive_color2
        End With
        Form1.imgPriv.BackColor = MyColors.imageDeactiveColor

        With Form1.btnPerf2
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.Deactive_color2
        End With
        Form1.imgNotif.BackColor = MyColors.imageDeactiveColor

        With Form1.btnAcc2
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.Deactive_color2
        End With
        Form1.imgAccount.BackColor = MyColors.imageDeactiveColor
    End Sub
    Public Shared Sub HelpClick()
        With Form1.btndash2
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.Deactive_color2
        End With
        Form1.imgDash.BackColor = MyColors.imageDeactiveColor

        With Form1.btnScan2
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.Deactive_color2
        End With
        Form1.imgProtec.BackColor = MyColors.imageDeactiveColor

        With Form1.btnPriv2
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.Deactive_color2
        End With
        Form1.imgPriv.BackColor = MyColors.imageDeactiveColor

        With Form1.btnPerf2
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.Deactive_color2
        End With
        Form1.imgNotif.BackColor = MyColors.imageDeactiveColor

        With Form1.btnAcc2
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.Deactive_color2
        End With
        Form1.imgAccount.BackColor = MyColors.imageDeactiveColor
    End Sub
    Public Shared Sub dashClick()
        With Form1.btndash2
            .BottomColor = MyColors.active_color1
            .TopColor = MyColors.active_color2
        End With
        Form1.CtlDashboard1.BringToFront()
        Form1.CtlDashboard1.Visible = True
        Form1.imgDash.BackColor = MyColors.imageActiveColor

        With Form1.btnScan2
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.Deactive_color2
        End With
        Form1.imgProtec.BackColor = MyColors.imageDeactiveColor

        With Form1.btnPriv2
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.Deactive_color2
        End With
        Form1.imgPriv.BackColor = MyColors.imageDeactiveColor

        With Form1.btnPerf2
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.Deactive_color2
        End With
        Form1.imgNotif.BackColor = MyColors.imageDeactiveColor

        With Form1.btnAcc2
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.Deactive_color2
        End With
        Form1.imgAccount.BackColor = MyColors.imageDeactiveColor
    End Sub
End Class

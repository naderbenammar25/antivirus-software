<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        sidePanel = New Panel()
        btnAcc2 = New MyButton()
        btnPerf2 = New MyButton()
        btnPriv2 = New MyButton()
        btnScan2 = New MyButton()
        btndash2 = New MyButton()
        Panel1 = New Panel()
        imgNotif = New PictureBox()
        imgPriv = New PictureBox()
        imgProtec = New PictureBox()
        imgDash = New PictureBox()
        imgAccount = New PictureBox()
        PictureBox8 = New PictureBox()
        CtlSubscription1 = New ctlSubscription()
        imgHelp = New PictureBox()
        imgPref = New PictureBox()
        headerPanel = New Panel()
        MyButton1 = New MyButton()
        btnMinimize = New PictureBox()
        btnClose = New PictureBox()
        lblTitle = New Label()
        mainPanel = New Panel()
        CtlDashboard1 = New ctlDashboard()
        CtlPrivacy1 = New ctlPrivacy()
        CtlSysPrerformance1 = New ctlSysPrerformance()
        StlScan21 = New stlScan2()
        CtlAccount1 = New ctlAccount()
        CtlPremium1 = New ctlPremium()
        sidePanel.SuspendLayout()
        Panel1.SuspendLayout()
        CType(imgNotif, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgPriv, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgProtec, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgDash, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgAccount, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgHelp, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgPref, ComponentModel.ISupportInitialize).BeginInit()
        headerPanel.SuspendLayout()
        CType(btnMinimize, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnClose, ComponentModel.ISupportInitialize).BeginInit()
        mainPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' sidePanel
        ' 
        sidePanel.BackColor = Color.FromArgb(CByte(26), CByte(30), CByte(37))
        sidePanel.Controls.Add(btnAcc2)
        sidePanel.Controls.Add(btnPerf2)
        sidePanel.Controls.Add(btnPriv2)
        sidePanel.Controls.Add(btnScan2)
        sidePanel.Controls.Add(btndash2)
        sidePanel.Controls.Add(Panel1)
        sidePanel.Controls.Add(PictureBox8)
        sidePanel.Dock = DockStyle.Left
        sidePanel.Location = New Point(0, 0)
        sidePanel.Name = "sidePanel"
        sidePanel.Size = New Size(253, 698)
        sidePanel.TabIndex = 0
        ' 
        ' btnAcc2
        ' 
        btnAcc2.BottomColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        btnAcc2.Font = New Font("Segoe UI", 12F)
        btnAcc2.ForeColor = Color.White
        btnAcc2.Location = New Point(58, 639)
        btnAcc2.Name = "btnAcc2"
        btnAcc2.Size = New Size(191, 56)
        btnAcc2.TabIndex = 11
        btnAcc2.Text = "My Account"
        btnAcc2.TopColor = Color.FromArgb(CByte(82), CByte(107), CByte(175))
        btnAcc2.UseVisualStyleBackColor = True
        ' 
        ' btnPerf2
        ' 
        btnPerf2.BottomColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        btnPerf2.Font = New Font("Segoe UI", 12F)
        btnPerf2.ForeColor = Color.White
        btnPerf2.Location = New Point(59, 355)
        btnPerf2.Name = "btnPerf2"
        btnPerf2.Size = New Size(191, 56)
        btnPerf2.TabIndex = 10
        btnPerf2.Text = "System Performance"
        btnPerf2.TopColor = Color.FromArgb(CByte(82), CByte(107), CByte(175))
        btnPerf2.UseVisualStyleBackColor = True
        ' 
        ' btnPriv2
        ' 
        btnPriv2.BottomColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        btnPriv2.Font = New Font("Segoe UI", 12F)
        btnPriv2.ForeColor = Color.White
        btnPriv2.Location = New Point(59, 293)
        btnPriv2.Name = "btnPriv2"
        btnPriv2.Size = New Size(191, 56)
        btnPriv2.TabIndex = 9
        btnPriv2.Text = "Privacy"
        btnPriv2.TopColor = Color.FromArgb(CByte(82), CByte(107), CByte(175))
        btnPriv2.UseVisualStyleBackColor = True
        ' 
        ' btnScan2
        ' 
        btnScan2.BottomColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        btnScan2.Font = New Font("Segoe UI", 12F)
        btnScan2.ForeColor = Color.White
        btnScan2.Location = New Point(58, 231)
        btnScan2.Name = "btnScan2"
        btnScan2.Size = New Size(191, 56)
        btnScan2.TabIndex = 8
        btnScan2.Text = "Scan Center"
        btnScan2.TopColor = Color.FromArgb(CByte(82), CByte(107), CByte(175))
        btnScan2.UseVisualStyleBackColor = True
        ' 
        ' btndash2
        ' 
        btndash2.BottomColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        btndash2.Font = New Font("Segoe UI", 12F)
        btndash2.ForeColor = Color.White
        btndash2.Location = New Point(59, 169)
        btndash2.Name = "btndash2"
        btndash2.Size = New Size(191, 56)
        btndash2.TabIndex = 2
        btndash2.Text = "Dashboard"
        btndash2.TopColor = Color.FromArgb(CByte(82), CByte(107), CByte(175))
        btndash2.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        Panel1.Controls.Add(imgNotif)
        Panel1.Controls.Add(imgPriv)
        Panel1.Controls.Add(imgProtec)
        Panel1.Controls.Add(imgDash)
        Panel1.Controls.Add(imgAccount)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(56, 698)
        Panel1.TabIndex = 7
        ' 
        ' imgNotif
        ' 
        imgNotif.Image = CType(resources.GetObject("imgNotif.Image"), Image)
        imgNotif.Location = New Point(0, 355)
        imgNotif.Name = "imgNotif"
        imgNotif.Size = New Size(56, 56)
        imgNotif.SizeMode = PictureBoxSizeMode.Zoom
        imgNotif.TabIndex = 12
        imgNotif.TabStop = False
        ' 
        ' imgPriv
        ' 
        imgPriv.Image = CType(resources.GetObject("imgPriv.Image"), Image)
        imgPriv.Location = New Point(-1, 293)
        imgPriv.Name = "imgPriv"
        imgPriv.Size = New Size(57, 56)
        imgPriv.SizeMode = PictureBoxSizeMode.Zoom
        imgPriv.TabIndex = 10
        imgPriv.TabStop = False
        ' 
        ' imgProtec
        ' 
        imgProtec.Image = CType(resources.GetObject("imgProtec.Image"), Image)
        imgProtec.Location = New Point(-1, 231)
        imgProtec.Name = "imgProtec"
        imgProtec.Size = New Size(57, 56)
        imgProtec.SizeMode = PictureBoxSizeMode.Zoom
        imgProtec.TabIndex = 8
        imgProtec.TabStop = False
        ' 
        ' imgDash
        ' 
        imgDash.BackColor = Color.Gray
        imgDash.Image = My.Resources.Resources.performance
        imgDash.Location = New Point(0, 169)
        imgDash.Name = "imgDash"
        imgDash.Size = New Size(53, 56)
        imgDash.SizeMode = PictureBoxSizeMode.Zoom
        imgDash.TabIndex = 2
        imgDash.TabStop = False
        ' 
        ' imgAccount
        ' 
        imgAccount.Image = CType(resources.GetObject("imgAccount.Image"), Image)
        imgAccount.Location = New Point(0, 639)
        imgAccount.Name = "imgAccount"
        imgAccount.Size = New Size(54, 56)
        imgAccount.SizeMode = PictureBoxSizeMode.Zoom
        imgAccount.TabIndex = 14
        imgAccount.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(62, 9)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(125, 112)
        PictureBox8.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox8.TabIndex = 3
        PictureBox8.TabStop = False
        ' 
        ' CtlSubscription1
        ' 
        CtlSubscription1.BackColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        CtlSubscription1.Location = New Point(3, 0)
        CtlSubscription1.Name = "CtlSubscription1"
        CtlSubscription1.Size = New Size(1725, 875)
        CtlSubscription1.TabIndex = 8
        CtlSubscription1.Visible = False
        ' 
        ' imgHelp
        ' 
        imgHelp.Image = CType(resources.GetObject("imgHelp.Image"), Image)
        imgHelp.Location = New Point(804, 0)
        imgHelp.Name = "imgHelp"
        imgHelp.Size = New Size(40, 52)
        imgHelp.SizeMode = PictureBoxSizeMode.Zoom
        imgHelp.TabIndex = 16
        imgHelp.TabStop = False
        ' 
        ' imgPref
        ' 
        imgPref.Image = CType(resources.GetObject("imgPref.Image"), Image)
        imgPref.Location = New Point(754, 8)
        imgPref.Name = "imgPref"
        imgPref.Size = New Size(44, 33)
        imgPref.SizeMode = PictureBoxSizeMode.Zoom
        imgPref.TabIndex = 15
        imgPref.TabStop = False
        ' 
        ' headerPanel
        ' 
        headerPanel.BackColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        headerPanel.Controls.Add(MyButton1)
        headerPanel.Controls.Add(btnMinimize)
        headerPanel.Controls.Add(btnClose)
        headerPanel.Controls.Add(lblTitle)
        headerPanel.Controls.Add(imgHelp)
        headerPanel.Controls.Add(imgPref)
        headerPanel.Dock = DockStyle.Top
        headerPanel.Location = New Point(253, 0)
        headerPanel.Name = "headerPanel"
        headerPanel.Size = New Size(1125, 55)
        headerPanel.TabIndex = 1
        ' 
        ' MyButton1
        ' 
        MyButton1.BottomColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        MyButton1.Font = New Font("Segoe UI", 12F)
        MyButton1.ForeColor = Color.White
        MyButton1.Location = New Point(889, 3)
        MyButton1.Name = "MyButton1"
        MyButton1.Size = New Size(144, 38)
        MyButton1.TabIndex = 12
        MyButton1.Text = "Go Premium"
        MyButton1.TopColor = Color.FromArgb(CByte(82), CByte(107), CByte(175))
        MyButton1.UseVisualStyleBackColor = True
        ' 
        ' btnMinimize
        ' 
        btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), Image)
        btnMinimize.Location = New Point(1053, 8)
        btnMinimize.Name = "btnMinimize"
        btnMinimize.Size = New Size(34, 33)
        btnMinimize.SizeMode = PictureBoxSizeMode.Zoom
        btnMinimize.TabIndex = 3
        btnMinimize.TabStop = False
        ' 
        ' btnClose
        ' 
        btnClose.Image = CType(resources.GetObject("btnClose.Image"), Image)
        btnClose.Location = New Point(1093, 12)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(25, 24)
        btnClose.SizeMode = PictureBoxSizeMode.Zoom
        btnClose.TabIndex = 3
        btnClose.TabStop = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 14F)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(307, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(301, 32)
        lblTitle.TabIndex = 3
        lblTitle.Text = "antivirus - free trial version"
        ' 
        ' mainPanel
        ' 
        mainPanel.BorderStyle = BorderStyle.FixedSingle
        mainPanel.Controls.Add(headerPanel)
        mainPanel.Controls.Add(sidePanel)
        mainPanel.Controls.Add(CtlDashboard1)
        mainPanel.Controls.Add(CtlPrivacy1)
        mainPanel.Controls.Add(CtlSysPrerformance1)
        mainPanel.Controls.Add(StlScan21)
        mainPanel.Controls.Add(CtlAccount1)
        mainPanel.Controls.Add(CtlPremium1)
        mainPanel.Controls.Add(CtlSubscription1)
        mainPanel.Dock = DockStyle.Fill
        mainPanel.Location = New Point(0, 0)
        mainPanel.Name = "mainPanel"
        mainPanel.Size = New Size(1380, 700)
        mainPanel.TabIndex = 2
        ' 
        ' CtlDashboard1
        ' 
        CtlDashboard1.BackColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        CtlDashboard1.Location = New Point(253, 47)
        CtlDashboard1.Name = "CtlDashboard1"
        CtlDashboard1.Size = New Size(1409, 799)
        CtlDashboard1.TabIndex = 2
        ' 
        ' CtlPrivacy1
        ' 
        CtlPrivacy1.BackColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        CtlPrivacy1.Location = New Point(253, 47)
        CtlPrivacy1.Name = "CtlPrivacy1"
        CtlPrivacy1.Size = New Size(1429, 850)
        CtlPrivacy1.TabIndex = 3
        ' 
        ' CtlSysPrerformance1
        ' 
        CtlSysPrerformance1.BackColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        CtlSysPrerformance1.Location = New Point(253, 47)
        CtlSysPrerformance1.Name = "CtlSysPrerformance1"
        CtlSysPrerformance1.Size = New Size(1429, 850)
        CtlSysPrerformance1.TabIndex = 4
        ' 
        ' StlScan21
        ' 
        StlScan21.BackColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        StlScan21.Location = New Point(253, 47)
        StlScan21.Name = "StlScan21"
        StlScan21.Size = New Size(1429, 850)
        StlScan21.TabIndex = 5
        ' 
        ' CtlAccount1
        ' 
        CtlAccount1.BackColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        CtlAccount1.Location = New Point(253, 47)
        CtlAccount1.Name = "CtlAccount1"
        CtlAccount1.Size = New Size(1761, 999)
        CtlAccount1.TabIndex = 6
        ' 
        ' CtlPremium1
        ' 
        CtlPremium1.BackColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        CtlPremium1.Location = New Point(253, 47)
        CtlPremium1.Name = "CtlPremium1"
        CtlPremium1.Size = New Size(1409, 799)
        CtlPremium1.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        ClientSize = New Size(1380, 700)
        Controls.Add(mainPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        sidePanel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        CType(imgNotif, ComponentModel.ISupportInitialize).EndInit()
        CType(imgPriv, ComponentModel.ISupportInitialize).EndInit()
        CType(imgProtec, ComponentModel.ISupportInitialize).EndInit()
        CType(imgDash, ComponentModel.ISupportInitialize).EndInit()
        CType(imgAccount, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(imgHelp, ComponentModel.ISupportInitialize).EndInit()
        CType(imgPref, ComponentModel.ISupportInitialize).EndInit()
        headerPanel.ResumeLayout(False)
        headerPanel.PerformLayout()
        CType(btnMinimize, ComponentModel.ISupportInitialize).EndInit()
        CType(btnClose, ComponentModel.ISupportInitialize).EndInit()
        mainPanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnDash As MyButton
    Friend WithEvents btnNotif As MyButton
    Friend WithEvents btnPriv As MyButton
    Friend WithEvents btnProtec As MyButton
    Friend WithEvents btnHelp As MyButton
    Friend WithEvents btnPref As MyButton
    Friend WithEvents btnAccount As MyButton
    Friend WithEvents MyButton8 As MyButton
    Friend WithEvents CtlDashboard1 As ctlDashboard
    Friend WithEvents StlScan21 As stlScan2
    Friend WithEvents CtlPrivacy1 As ctlPrivacy
    Friend WithEvents sidePanel As Panel
    Friend WithEvents btnAcc2 As MyButton
    Friend WithEvents btnPerf2 As MyButton
    Friend WithEvents btnPriv2 As MyButton
    Friend WithEvents btnScan2 As MyButton
    Friend WithEvents btndash2 As MyButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents imgNotif As PictureBox
    Friend WithEvents imgPriv As PictureBox
    Friend WithEvents imgHelp As PictureBox
    Friend WithEvents imgProtec As PictureBox
    Friend WithEvents imgPref As PictureBox
    Friend WithEvents imgDash As PictureBox
    Friend WithEvents imgAccount As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents headerPanel As Panel
    Friend WithEvents btnMinimize As PictureBox
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents mainPanel As Panel
    Friend WithEvents CtlSysPrerformance1 As ctlSysPrerformance
    Friend WithEvents CtlAccount1 As ctlAccount
    Friend WithEvents MyButton1 As MyButton
    Friend WithEvents CtlPremium1 As ctlPremium
    Friend WithEvents CtlSubscription1 As ctlSubscription

End Class

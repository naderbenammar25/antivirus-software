<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class srmScan
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(srmScan))
        headerPanel = New Panel()
        btnMinimize = New PictureBox()
        MyButton2 = New MyButton()
        btnClose = New PictureBox()
        lblTitle = New Label()
        Panel1 = New Panel()
        MyButton3 = New MyButton()
        MyButton4 = New MyButton()
        Label14 = New Label()
        Label13 = New Label()
        ListBox2 = New ListBox()
        ListBox1 = New ListBox()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        MyButton1 = New MyButton()
        lbllast = New Label()
        Label11 = New Label()
        lblVirus = New Label()
        Label9 = New Label()
        lblTotal = New Label()
        Label7 = New Label()
        ProgressBar1 = New ProgressBar()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        Label6 = New Label()
        PictureBox2 = New PictureBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Label1 = New Label()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        Timer1 = New Timer(components)
        OpenFileDialog1 = New OpenFileDialog()
        Timer2 = New Timer(components)
        headerPanel.SuspendLayout()
        CType(btnMinimize, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnClose, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' headerPanel
        ' 
        headerPanel.BackColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        headerPanel.Controls.Add(btnMinimize)
        headerPanel.Controls.Add(MyButton2)
        headerPanel.Controls.Add(btnClose)
        headerPanel.Controls.Add(lblTitle)
        headerPanel.Dock = DockStyle.Top
        headerPanel.Location = New Point(0, 0)
        headerPanel.Name = "headerPanel"
        headerPanel.Size = New Size(870, 55)
        headerPanel.TabIndex = 2
        ' 
        ' btnMinimize
        ' 
        btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), Image)
        btnMinimize.Location = New Point(793, 8)
        btnMinimize.Name = "btnMinimize"
        btnMinimize.Size = New Size(34, 33)
        btnMinimize.SizeMode = PictureBoxSizeMode.Zoom
        btnMinimize.TabIndex = 3
        btnMinimize.TabStop = False
        ' 
        ' MyButton2
        ' 
        MyButton2.BottomColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        MyButton2.Location = New Point(611, 6)
        MyButton2.Name = "MyButton2"
        MyButton2.Size = New Size(176, 38)
        MyButton2.TabIndex = 53
        MyButton2.Text = "Run in background"
        MyButton2.TopColor = Color.LightPink
        MyButton2.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Image = CType(resources.GetObject("btnClose.Image"), Image)
        btnClose.Location = New Point(833, 12)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(25, 24)
        btnClose.SizeMode = PictureBoxSizeMode.Zoom
        btnClose.TabIndex = 3
        btnClose.TabStop = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 14.0F)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(12, 8)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(211, 32)
        lblTitle.TabIndex = 3
        lblTitle.Text = "Smart Scan Center"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(MyButton3)
        Panel1.Controls.Add(MyButton4)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(ListBox2)
        Panel1.Controls.Add(ListBox1)
        Panel1.Controls.Add(FlowLayoutPanel3)
        Panel1.Controls.Add(MyButton1)
        Panel1.Controls.Add(lbllast)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(lblVirus)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(lblTotal)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(ProgressBar1)
        Panel1.Controls.Add(FlowLayoutPanel2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(FlowLayoutPanel1)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 55)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(870, 753)
        Panel1.TabIndex = 3
        ' 
        ' MyButton3
        ' 
        MyButton3.BottomColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        MyButton3.ForeColor = Color.White
        MyButton3.Location = New Point(816, 635)
        MyButton3.Name = "MyButton3"
        MyButton3.Size = New Size(47, 45)
        MyButton3.TabIndex = 59
        MyButton3.Text = "?"
        MyButton3.TopColor = Color.DarkGreen
        MyButton3.UseVisualStyleBackColor = True
        ' 
        ' MyButton4
        ' 
        MyButton4.BottomColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        MyButton4.ForeColor = Color.White
        MyButton4.Location = New Point(816, 584)
        MyButton4.Name = "MyButton4"
        MyButton4.Size = New Size(47, 45)
        MyButton4.TabIndex = 58
        MyButton4.Text = "X"
        MyButton4.TopColor = Color.DarkRed
        MyButton4.UseVisualStyleBackColor = True
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 12.0F)
        Label14.ForeColor = SystemColors.Control
        Label14.Location = New Point(437, 553)
        Label14.Name = "Label14"
        Label14.Size = New Size(94, 28)
        Label14.TabIndex = 56
        Label14.Text = "Virus list :"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12.0F)
        Label13.ForeColor = SystemColors.Control
        Label13.Location = New Point(21, 553)
        Label13.Name = "Label13"
        Label13.Size = New Size(140, 28)
        Label13.TabIndex = 55
        Label13.Text = "Scanning files :"
        ' 
        ' ListBox2
        ' 
        ListBox2.BackColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        ListBox2.BorderStyle = BorderStyle.FixedSingle
        ListBox2.ForeColor = Color.Silver
        ListBox2.FormattingEnabled = True
        ListBox2.Location = New Point(437, 584)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(373, 162)
        ListBox2.TabIndex = 54
        ' 
        ' ListBox1
        ' 
        ListBox1.BackColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        ListBox1.BorderStyle = BorderStyle.FixedSingle
        ListBox1.ForeColor = Color.Silver
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(21, 584)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(410, 162)
        ListBox1.TabIndex = 53
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.BackColor = Color.White
        FlowLayoutPanel3.Location = New Point(2, 537)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Size = New Size(910, 5)
        FlowLayoutPanel3.TabIndex = 40
        ' 
        ' MyButton1
        ' 
        MyButton1.BottomColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        MyButton1.Location = New Point(759, 344)
        MyButton1.Name = "MyButton1"
        MyButton1.Size = New Size(98, 31)
        MyButton1.TabIndex = 52
        MyButton1.Text = "Abort"
        MyButton1.TopColor = Color.LightPink
        MyButton1.UseVisualStyleBackColor = True
        ' 
        ' lbllast
        ' 
        lbllast.AutoSize = True
        lbllast.Font = New Font("Segoe UI", 12.0F)
        lbllast.ForeColor = SystemColors.Control
        lbllast.Location = New Point(222, 506)
        lbllast.Name = "lbllast"
        lbllast.Size = New Size(36, 28)
        lbllast.TabIndex = 51
        lbllast.Text = "C:\"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12.0F)
        Label11.ForeColor = SystemColors.Control
        Label11.Location = New Point(11, 506)
        Label11.Name = "Label11"
        Label11.Size = New Size(215, 28)
        Label11.TabIndex = 50
        Label11.Text = "Last scanned directory :"
        ' 
        ' lblVirus
        ' 
        lblVirus.AutoSize = True
        lblVirus.Font = New Font("Segoe UI", 12.0F)
        lblVirus.ForeColor = SystemColors.Control
        lblVirus.Location = New Point(186, 478)
        lblVirus.Name = "lblVirus"
        lblVirus.Size = New Size(23, 28)
        lblVirus.TabIndex = 49
        lblVirus.Text = "0"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12.0F)
        Label9.ForeColor = SystemColors.Control
        Label9.Location = New Point(11, 478)
        Label9.Name = "Label9"
        Label9.Size = New Size(165, 28)
        Label9.TabIndex = 48
        Label9.Text = "Detected threats :"
        ' 
        ' lblTotal
        ' 
        lblTotal.Font = New Font("Segoe UI", 12.0F)
        lblTotal.ForeColor = SystemColors.Control
        lblTotal.Location = New Point(11, 404)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(843, 74)
        lblTotal.TabIndex = 47
        lblTotal.Text = "-"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12.0F)
        Label7.ForeColor = SystemColors.Control
        Label7.Location = New Point(11, 376)
        Label7.Name = "Label7"
        Label7.Size = New Size(138, 28)
        Label7.TabIndex = 46
        Label7.Text = "Scanned Files :"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(11, 344)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(739, 29)
        ProgressBar1.TabIndex = 45
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.BackColor = Color.White
        FlowLayoutPanel2.Location = New Point(-3, 333)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(910, 5)
        FlowLayoutPanel2.TabIndex = 39
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(15, 210)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(181, 110)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 39
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12.0F)
        Label5.ForeColor = Color.Silver
        Label5.Location = New Point(659, 247)
        Label5.Name = "Label5"
        Label5.Size = New Size(204, 56)
        Label5.TabIndex = 44
        Label5.Text = "Scan a specefic folder " & vbCrLf & "for virus detection"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 20.0F)
        Label6.ForeColor = SystemColors.Control
        Label6.Location = New Point(660, 202)
        Label6.Name = "Label6"
        Label6.Size = New Size(194, 46)
        Label6.TabIndex = 43
        Label6.Text = "Folder Scan"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(472, 201)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(181, 110)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 42
        PictureBox2.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12.0F)
        Label4.ForeColor = Color.Silver
        Label4.Location = New Point(202, 255)
        Label4.Name = "Label4"
        Label4.Size = New Size(201, 56)
        Label4.TabIndex = 41
        Label4.Text = "Quick virus detection " & vbCrLf & "for folders and files"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 20.0F)
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(203, 210)
        Label3.Name = "Label3"
        Label3.Size = New Size(185, 46)
        Label3.TabIndex = 40
        Label3.Text = "Quick Scan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12.0F)
        Label2.ForeColor = Color.Silver
        Label2.Location = New Point(21, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(744, 56)
        Label2.TabIndex = 37
        Label2.Text = "Quickly run a smart scan on your computer to detect and intercept any hidden virus " & vbCrLf & "that can harm your system and files." & vbCrLf
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.White
        FlowLayoutPanel1.Location = New Point(21, 176)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(833, 10)
        FlowLayoutPanel1.TabIndex = 38
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 35.0F)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(11, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(343, 78)
        Label1.TabIndex = 36
        Label1.Text = "Scan Center"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        ' 
        ' srmScan
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        ClientSize = New Size(870, 808)
        Controls.Add(Panel1)
        Controls.Add(headerPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "srmScan"
        StartPosition = FormStartPosition.CenterScreen
        Text = "srmScan"
        headerPanel.ResumeLayout(False)
        headerPanel.PerformLayout()
        CType(btnMinimize, ComponentModel.ISupportInitialize).EndInit()
        CType(btnClose, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents headerPanel As Panel
    Friend WithEvents btnMinimize As PictureBox
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblVirus As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbllast As Label
    Friend WithEvents MyButton1 As MyButton
    Friend WithEvents MyButton2 As MyButton
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents MyButton4 As MyButton
    Friend WithEvents MyButton3 As MyButton
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Timer2 As Timer
End Class

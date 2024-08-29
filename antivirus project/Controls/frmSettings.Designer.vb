<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Panel1 = New Panel()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        Panel3 = New Panel()
        Label3 = New Label()
        MyButton3 = New MyButton()
        Label4 = New Label()
        Panel2 = New Panel()
        Label2 = New Label()
        MyButton1 = New MyButton()
        Label1 = New Label()
        MyButton2 = New MyButton()
        PictureBox1 = New PictureBox()
        lblTitle = New Label()
        btnClose = New PictureBox()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnClose, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(CheckBox4)
        Panel1.Controls.Add(CheckBox3)
        Panel1.Controls.Add(CheckBox2)
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(MyButton2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(lblTitle)
        Panel1.Controls.Add(btnClose)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(582, 582)
        Panel1.TabIndex = 0
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Font = New Font("Segoe UI", 12F)
        CheckBox4.ForeColor = Color.White
        CheckBox4.Location = New Point(309, 465)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(150, 32)
        CheckBox4.TabIndex = 20
        CheckBox4.Text = "Auto-Update"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Font = New Font("Segoe UI", 12F)
        CheckBox3.ForeColor = Color.White
        CheckBox3.Location = New Point(309, 427)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(189, 32)
        CheckBox3.TabIndex = 19
        CheckBox3.Text = "Scan every 1 hour"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Segoe UI", 12F)
        CheckBox2.ForeColor = Color.White
        CheckBox2.Location = New Point(23, 465)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(241, 32)
        CheckBox2.TabIndex = 18
        CheckBox2.Text = "Start VPN automatically"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 12F)
        CheckBox1.ForeColor = Color.White
        CheckBox1.Location = New Point(26, 427)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(277, 32)
        CheckBox1.TabIndex = 17
        CheckBox1.Text = "Start-up with windows boot"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.Control
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(MyButton3)
        Panel3.Controls.Add(Label4)
        Panel3.Location = New Point(23, 282)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(527, 125)
        Panel3.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(3, 68)
        Label3.Name = "Label3"
        Label3.Size = New Size(504, 50)
        Label3.TabIndex = 14
        Label3.Text = "Automatically manage your device’s security with minimal user intervention."
        ' 
        ' MyButton3
        ' 
        MyButton3.BottomColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        MyButton3.Location = New Point(327, 3)
        MyButton3.Name = "MyButton3"
        MyButton3.Size = New Size(180, 62)
        MyButton3.TabIndex = 0
        MyButton3.Text = "Enable"
        MyButton3.TopColor = Color.LightGreen
        MyButton3.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(3, 15)
        Label4.Name = "Label4"
        Label4.Size = New Size(212, 35)
        Label4.TabIndex = 13
        Label4.Text = "Auto-Pilot Mode"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Control
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(MyButton1)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(23, 104)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(527, 172)
        Panel2.TabIndex = 15
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(3, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(504, 104)
        Label2.TabIndex = 14
        Label2.Text = resources.GetString("Label2.Text")
        ' 
        ' MyButton1
        ' 
        MyButton1.BottomColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        MyButton1.Location = New Point(327, 3)
        MyButton1.Name = "MyButton1"
        MyButton1.Size = New Size(180, 62)
        MyButton1.TabIndex = 0
        MyButton1.Text = "Enable"
        MyButton1.TopColor = Color.LightGreen
        MyButton1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(3, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(263, 35)
        Label1.TabIndex = 13
        Label1.Text = "Real-Time Protection"
        ' 
        ' MyButton2
        ' 
        MyButton2.BottomColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        MyButton2.ForeColor = Color.White
        MyButton2.Location = New Point(198, 530)
        MyButton2.Name = "MyButton2"
        MyButton2.Size = New Size(162, 39)
        MyButton2.TabIndex = 14
        MyButton2.Text = "Save Settings"
        MyButton2.TopColor = Color.FromArgb(CByte(90), CByte(100), CByte(171))
        MyButton2.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(4, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(53, 45)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 14F)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(60, 10)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(183, 32)
        lblTitle.TabIndex = 11
        lblTitle.Text = "System Settings"
        ' 
        ' btnClose
        ' 
        btnClose.Image = CType(resources.GetObject("btnClose.Image"), Image)
        btnClose.Location = New Point(544, 8)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(25, 24)
        btnClose.SizeMode = PictureBoxSizeMode.Zoom
        btnClose.TabIndex = 10
        btnClose.TabStop = False
        ' 
        ' frmSettings
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        ClientSize = New Size(582, 582)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmSettings"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmSettings"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnClose, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MyButton2 As MyButton
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MyButton1 As MyButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents MyButton3 As MyButton
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
End Class

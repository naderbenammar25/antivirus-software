<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlDashboard
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlDashboard))
        Panel1 = New Panel()
        Label5 = New Label()
        Label4 = New Label()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        LinkLabel1 = New LinkLabel()
        MyButton1 = New MyButton()
        Panel8 = New Panel()
        PictureBox3 = New PictureBox()
        Label6 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Panel3 = New Panel()
        PictureBox7 = New PictureBox()
        Label7 = New Label()
        Panel4 = New Panel()
        PictureBox6 = New PictureBox()
        Label8 = New Label()
        Panel5 = New Panel()
        PictureBox8 = New PictureBox()
        Label9 = New Label()
        Panel6 = New Panel()
        PictureBox5 = New PictureBox()
        Label10 = New Label()
        Label11 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel8.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Control
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(24, 118)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(898, 133)
        Panel1.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 8F)
        Label5.ForeColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        Label5.Location = New Point(80, 104)
        Label5.Name = "Label5"
        Label5.Size = New Size(509, 19)
        Label5.TabIndex = 14
        Label5.Text = "Customize, Optimise and run reports on your entire household from one account."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 8F)
        Label4.ForeColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        Label4.Location = New Point(80, 85)
        Label4.Name = "Label4"
        Label4.Size = New Size(712, 19)
        Label4.TabIndex = 12
        Label4.Text = "Bitdefender is designed to run in the background when you don't want it, But be instantly accessible when you do. "
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(17, 73)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(57, 52)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 13
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F)
        Label3.ForeColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        Label3.Location = New Point(80, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(285, 35)
        Label3.TabIndex = 11
        Label3.Text = "Enable / Disable Firewall"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(17, 15)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(57, 52)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Control
        Panel2.Controls.Add(LinkLabel1)
        Panel2.Controls.Add(MyButton1)
        Panel2.Location = New Point(928, 118)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(180, 133)
        Panel2.TabIndex = 4
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 10F)
        LinkLabel1.Location = New Point(-2, 102)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(182, 23)
        LinkLabel1.TabIndex = 1
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Next recommendation"
        ' 
        ' MyButton1
        ' 
        MyButton1.BottomColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        MyButton1.Location = New Point(0, 33)
        MyButton1.Name = "MyButton1"
        MyButton1.Size = New Size(180, 62)
        MyButton1.TabIndex = 0
        MyButton1.Text = "Enable"
        MyButton1.TopColor = Color.LightGreen
        MyButton1.UseVisualStyleBackColor = True
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = SystemColors.Control
        Panel8.Controls.Add(PictureBox3)
        Panel8.Controls.Add(Label6)
        Panel8.Location = New Point(24, 279)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(347, 179)
        Panel8.TabIndex = 8
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(139, 82)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(74, 59)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 12
        PictureBox3.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 20F)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(80, 10)
        Label6.Name = "Label6"
        Label6.Size = New Size(181, 46)
        Label6.TabIndex = 11
        Label6.Text = "Quick scan"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 35F)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(24, -13)
        Label1.Name = "Label1"
        Label1.Size = New Size(347, 78)
        Label1.TabIndex = 9
        Label1.Text = "You are safe"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.ForeColor = Color.Silver
        Label2.Location = New Point(41, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(181, 35)
        Label2.TabIndex = 10
        Label2.Text = "Collecting data"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.Control
        Panel3.Controls.Add(PictureBox7)
        Panel3.Controls.Add(Label7)
        Panel3.Location = New Point(400, 279)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(347, 179)
        Panel3.TabIndex = 12
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(139, 82)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(74, 59)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 16
        PictureBox7.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 20F)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(60, 10)
        Label7.Name = "Label7"
        Label7.Size = New Size(201, 46)
        Label7.TabIndex = 11
        Label7.Text = "System scan"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.Control
        Panel4.Controls.Add(Label11)
        Panel4.Controls.Add(PictureBox6)
        Panel4.Controls.Add(Label8)
        Panel4.Location = New Point(773, 279)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(335, 343)
        Panel4.TabIndex = 13
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(134, 245)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(74, 59)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 15
        PictureBox6.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 20F)
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(46, 22)
        Label8.Name = "Label8"
        Label8.Size = New Size(242, 46)
        Label8.TabIndex = 11
        Label8.Text = "Zero trust scan"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.Control
        Panel5.Controls.Add(PictureBox8)
        Panel5.Controls.Add(Label9)
        Panel5.Location = New Point(24, 464)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(347, 158)
        Panel5.TabIndex = 12
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(139, 60)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(74, 59)
        PictureBox8.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox8.TabIndex = 17
        PictureBox8.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 25F)
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(124, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(106, 57)
        Label9.TabIndex = 11
        Label9.Text = "VPN"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.Control
        Panel6.Controls.Add(PictureBox5)
        Panel6.Controls.Add(Label10)
        Panel6.Location = New Point(400, 464)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(347, 158)
        Panel6.TabIndex = 13
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(139, 60)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(74, 59)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 14
        PictureBox5.TabStop = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 20F)
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(79, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(183, 46)
        Label10.TabIndex = 11
        Label10.Text = "Add action"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 10F)
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(80, 68)
        Label11.Name = "Label11"
        Label11.Size = New Size(177, 23)
        Label11.TabIndex = 16
        Label11.Text = "Scan all vulnerabilities"
        ' 
        ' ctlDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel8)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "ctlDashboard"
        Size = New Size(1127, 639)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MyButton1 As MyButton
    Friend WithEvents Label5 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label11 As Label

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlPrivacy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlPrivacy))
        Label1 = New Label()
        MyButton2 = New MyButton()
        MyButton1 = New MyButton()
        usPic = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        PictureBox7 = New PictureBox()
        Label8 = New Label()
        CType(usPic, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 30F)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(329, 253)
        Label1.Name = "Label1"
        Label1.Size = New Size(436, 67)
        Label1.TabIndex = 28
        Label1.Text = "VPN Disconnected"
        ' 
        ' MyButton2
        ' 
        MyButton2.BottomColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        MyButton2.ForeColor = Color.White
        MyButton2.Location = New Point(344, 569)
        MyButton2.Name = "MyButton2"
        MyButton2.Size = New Size(182, 47)
        MyButton2.TabIndex = 30
        MyButton2.Text = "Connect"
        MyButton2.TopColor = Color.LightGreen
        MyButton2.UseVisualStyleBackColor = True
        ' 
        ' MyButton1
        ' 
        MyButton1.BottomColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        MyButton1.ForeColor = Color.White
        MyButton1.Location = New Point(563, 569)
        MyButton1.Name = "MyButton1"
        MyButton1.Size = New Size(182, 47)
        MyButton1.TabIndex = 29
        MyButton1.Text = "Disconnect"
        MyButton1.TopColor = Color.Red
        MyButton1.UseVisualStyleBackColor = True
        ' 
        ' usPic
        ' 
        usPic.Image = CType(resources.GetObject("usPic.Image"), Image)
        usPic.Location = New Point(240, 443)
        usPic.Name = "usPic"
        usPic.Size = New Size(95, 79)
        usPic.SizeMode = PictureBoxSizeMode.Zoom
        usPic.TabIndex = 31
        usPic.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(410, 16)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(293, 234)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 32
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(644, 443)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(95, 79)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 33
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(543, 443)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(95, 79)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 34
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(442, 443)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(95, 79)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 35
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(341, 443)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(95, 79)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 36
        PictureBox6.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 7F)
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(264, 525)
        Label2.Name = "Label2"
        Label2.Size = New Size(29, 15)
        Label2.TabIndex = 37
        Label2.Text = "USA"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 7F)
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(667, 525)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 15)
        Label3.TabIndex = 38
        Label3.Text = "England"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 7F)
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(362, 525)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 15)
        Label4.TabIndex = 39
        Label4.Text = "Canada"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 7F)
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(560, 525)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 15)
        Label5.TabIndex = 40
        Label5.Text = "Singapore"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 7F)
        Label6.ForeColor = SystemColors.Control
        Label6.Location = New Point(463, 525)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 15)
        Label6.TabIndex = 41
        Label6.Text = "Germany"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 15F)
        Label7.ForeColor = SystemColors.Control
        Label7.Location = New Point(466, 384)
        Label7.Name = "Label7"
        Label7.Size = New Size(192, 35)
        Label7.TabIndex = 42
        Label7.Text = "Choose Country"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(745, 443)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(95, 79)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 43
        PictureBox7.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 7F)
        Label8.ForeColor = SystemColors.Control
        Label8.Location = New Point(775, 525)
        Label8.Name = "Label8"
        Label8.Size = New Size(37, 15)
        Label8.TabIndex = 44
        Label8.Text = "Korea"
        ' 
        ' ctlPrivacy
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        Controls.Add(Label8)
        Controls.Add(PictureBox7)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(usPic)
        Controls.Add(MyButton2)
        Controls.Add(MyButton1)
        Controls.Add(Label1)
        Name = "ctlPrivacy"
        Size = New Size(1143, 680)
        CType(usPic, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MyButton2 As MyButton
    Friend WithEvents MyButton1 As MyButton
    Friend WithEvents usPic As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label8 As Label

End Class

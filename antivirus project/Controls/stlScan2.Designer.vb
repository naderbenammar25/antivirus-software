<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stlScan2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stlScan2))
        Label2 = New Label()
        MyButton1 = New MyButton()
        PictureBox1 = New PictureBox()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Label5 = New Label()
        Label6 = New Label()
        PictureBox2 = New PictureBox()
        Label4 = New Label()
        Label3 = New Label()
        Panel2 = New Panel()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.ForeColor = Color.Silver
        Label2.Location = New Point(51, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(744, 56)
        Label2.TabIndex = 28
        Label2.Text = "Quickly run a smart scan on your computer to detect and intercept any hidden virus " & vbCrLf & "that can harm your system and files." & vbCrLf
        ' 
        ' MyButton1
        ' 
        MyButton1.BottomColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        MyButton1.Location = New Point(3, 3)
        MyButton1.Name = "MyButton1"
        MyButton1.Size = New Size(431, 62)
        MyButton1.TabIndex = 0
        MyButton1.Text = "Start smart scan"
        MyButton1.TopColor = Color.LightPink
        MyButton1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(19, 284)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(181, 110)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 29
        PictureBox1.TabStop = False
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.White
        FlowLayoutPanel1.Location = New Point(51, 194)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(1037, 10)
        FlowLayoutPanel1.TabIndex = 35
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.ForeColor = Color.Silver
        Label5.Location = New Point(206, 465)
        Label5.Name = "Label5"
        Label5.Size = New Size(744, 56)
        Label5.TabIndex = 34
        Label5.Text = "Quickly run a smart scan on your computer to detect and intercept any hidden virus " & vbCrLf & "that can harm your system and files." & vbCrLf
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 20F)
        Label6.ForeColor = SystemColors.Control
        Label6.Location = New Point(207, 420)
        Label6.Name = "Label6"
        Label6.Size = New Size(563, 46)
        Label6.TabIndex = 33
        Label6.Text = "Schedule your Scan Time and Events"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(19, 419)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(181, 110)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 32
        PictureBox2.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.ForeColor = Color.Silver
        Label4.Location = New Point(206, 329)
        Label4.Name = "Label4"
        Label4.Size = New Size(744, 56)
        Label4.TabIndex = 31
        Label4.Text = "Quickly run a smart scan on your computer to detect and intercept any hidden virus " & vbCrLf & "that can harm your system and files." & vbCrLf
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 20F)
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(207, 284)
        Label3.Name = "Label3"
        Label3.Size = New Size(187, 46)
        Label3.TabIndex = 30
        Label3.Text = "Smart Scan"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Control
        Panel2.Controls.Add(MyButton1)
        Panel2.Location = New Point(358, 564)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(437, 67)
        Panel2.TabIndex = 26
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 35F)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(41, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(343, 78)
        Label1.TabIndex = 27
        Label1.Text = "Scan Center"
        ' 
        ' stlScan2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(PictureBox2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Panel2)
        Controls.Add(Label1)
        Name = "stlScan2"
        Size = New Size(1143, 680)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents MyButton1 As MyButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label

End Class

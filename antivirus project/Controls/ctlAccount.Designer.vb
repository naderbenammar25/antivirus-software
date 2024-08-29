<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlAccount))
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Label1 = New Label()
        imgAccount = New PictureBox()
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        MyButton2 = New MyButton()
        MyButton1 = New MyButton()
        CType(imgAccount, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.White
        FlowLayoutPanel1.Location = New Point(14, 158)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(1079, 10)
        FlowLayoutPanel1.TabIndex = 40
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 35F)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(3, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(380, 78)
        Label1.TabIndex = 39
        Label1.Text = "User Account"
        ' 
        ' imgAccount
        ' 
        imgAccount.Image = CType(resources.GetObject("imgAccount.Image"), Image)
        imgAccount.Location = New Point(454, 188)
        imgAccount.Name = "imgAccount"
        imgAccount.Size = New Size(199, 185)
        imgAccount.SizeMode = PictureBoxSizeMode.Zoom
        imgAccount.TabIndex = 41
        imgAccount.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(103, 455)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(962, 265)
        GroupBox1.TabIndex = 42
        GroupBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(52, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(153, 28)
        Label2.TabIndex = 0
        Label2.Text = "Activation Mail :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(96, 89)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 28)
        Label3.TabIndex = 1
        Label3.Text = "Validation :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(131, 130)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 28)
        Label4.TabIndex = 2
        Label4.Text = "Expiry :"
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(211, 46)
        Label5.Name = "Label5"
        Label5.Size = New Size(538, 28)
        Label5.TabIndex = 3
        Label5.Text = "-"
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.Location = New Point(211, 89)
        Label6.Name = "Label6"
        Label6.Size = New Size(538, 28)
        Label6.TabIndex = 4
        Label6.Text = "-"
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Segoe UI", 12F)
        Label7.Location = New Point(211, 130)
        Label7.Name = "Label7"
        Label7.Size = New Size(538, 28)
        Label7.TabIndex = 5
        Label7.Text = "-"
        ' 
        ' MyButton2
        ' 
        MyButton2.BottomColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        MyButton2.ForeColor = Color.White
        MyButton2.Location = New Point(345, 391)
        MyButton2.Name = "MyButton2"
        MyButton2.Size = New Size(182, 47)
        MyButton2.TabIndex = 44
        MyButton2.Text = "Login"
        MyButton2.TopColor = Color.LightGreen
        MyButton2.UseVisualStyleBackColor = True
        ' 
        ' MyButton1
        ' 
        MyButton1.BottomColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        MyButton1.ForeColor = Color.White
        MyButton1.Location = New Point(564, 391)
        MyButton1.Name = "MyButton1"
        MyButton1.Size = New Size(182, 47)
        MyButton1.TabIndex = 43
        MyButton1.Text = "Create an Account"
        MyButton1.TopColor = Color.Red
        MyButton1.UseVisualStyleBackColor = True
        ' 
        ' ctlAccount
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        Controls.Add(MyButton2)
        Controls.Add(MyButton1)
        Controls.Add(GroupBox1)
        Controls.Add(imgAccount)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Label1)
        Name = "ctlAccount"
        Size = New Size(1409, 799)
        CType(imgAccount, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents imgAccount As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents MyButton2 As MyButton
    Friend WithEvents MyButton1 As MyButton

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSerialKey
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSerialKey))
        Panel1 = New Panel()
        LinkLabel1 = New LinkLabel()
        MyButton2 = New MyButton()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        btnClose = New PictureBox()
        PictureBox1 = New PictureBox()
        lblTitle = New Label()
        Panel1.SuspendLayout()
        CType(btnClose, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(MyButton2)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(btnClose)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(lblTitle)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 371)
        Panel1.TabIndex = 16
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 12F)
        LinkLabel1.Location = New Point(282, 287)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(221, 28)
        LinkLabel1.TabIndex = 55
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Don't have a serial key ?"
        ' 
        ' MyButton2
        ' 
        MyButton2.BottomColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        MyButton2.Font = New Font("Segoe UI", 12F)
        MyButton2.ForeColor = Color.White
        MyButton2.Location = New Point(509, 273)
        MyButton2.Name = "MyButton2"
        MyButton2.Size = New Size(191, 56)
        MyButton2.TabIndex = 54
        MyButton2.Text = "Submit Key"
        MyButton2.TopColor = Color.FromArgb(CByte(82), CByte(107), CByte(175))
        MyButton2.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(85, 207)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 32)
        Label2.TabIndex = 22
        Label2.Text = "Serial Key :"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 15F)
        TextBox2.Location = New Point(227, 201)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(473, 41)
        TextBox2.TabIndex = 21
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(122, 142)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 32)
        Label1.TabIndex = 20
        Label1.Text = "E-mail :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 15F)
        TextBox1.Location = New Point(227, 136)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(473, 41)
        TextBox1.TabIndex = 19
        ' 
        ' btnClose
        ' 
        btnClose.Image = CType(resources.GetObject("btnClose.Image"), Image)
        btnClose.Location = New Point(772, 3)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(25, 24)
        btnClose.SizeMode = PictureBoxSizeMode.Zoom
        btnClose.TabIndex = 18
        btnClose.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(53, 45)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 14F)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(62, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(120, 32)
        lblTitle.TabIndex = 16
        lblTitle.Text = "Activation"
        ' 
        ' frmSerialKey
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        ClientSize = New Size(800, 371)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmSerialKey"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmSerialKey"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(btnClose, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents MyButton2 As MyButton
    Friend WithEvents LinkLabel1 As LinkLabel
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPopUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPopUp))
        Panel1 = New Panel()
        MyButton2 = New MyButton()
        MyButton1 = New MyButton()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        lblTitle = New Label()
        btnClose = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnClose, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(MyButton2)
        Panel1.Controls.Add(MyButton1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(lblTitle)
        Panel1.Controls.Add(btnClose)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(394, 212)
        Panel1.TabIndex = 0
        ' 
        ' MyButton2
        ' 
        MyButton2.BottomColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        MyButton2.ForeColor = Color.White
        MyButton2.Location = New Point(73, 123)
        MyButton2.Name = "MyButton2"
        MyButton2.Size = New Size(94, 29)
        MyButton2.TabIndex = 9
        MyButton2.Text = "Yes"
        MyButton2.TopColor = Color.FromArgb(CByte(90), CByte(100), CByte(171))
        MyButton2.UseVisualStyleBackColor = True
        ' 
        ' MyButton1
        ' 
        MyButton1.BottomColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        MyButton1.ForeColor = Color.White
        MyButton1.Location = New Point(226, 123)
        MyButton1.Name = "MyButton1"
        MyButton1.Size = New Size(94, 29)
        MyButton1.TabIndex = 8
        MyButton1.Text = "No"
        MyButton1.TopColor = Color.FromArgb(CByte(90), CByte(100), CByte(171))
        MyButton1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(111, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(167, 32)
        Label1.TabIndex = 7
        Label1.Text = "Are you sure ?"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 8)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(53, 45)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 14F)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(54, 8)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(249, 32)
        lblTitle.TabIndex = 5
        lblTitle.Text = "antivirus still no name"
        ' 
        ' btnClose
        ' 
        btnClose.Image = CType(resources.GetObject("btnClose.Image"), Image)
        btnClose.Location = New Point(364, 3)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(25, 24)
        btnClose.SizeMode = PictureBoxSizeMode.Zoom
        btnClose.TabIndex = 4
        btnClose.TabStop = False
        ' 
        ' frmPopUp
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        ClientSize = New Size(394, 212)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmPopUp"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmPopUp"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnClose, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents MyButton2 As MyButton
    Friend WithEvents MyButton1 As MyButton
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

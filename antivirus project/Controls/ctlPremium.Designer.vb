<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlPremium
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlPremium))
        MyButton2 = New MyButton()
        PictureBox8 = New PictureBox()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MyButton2
        ' 
        MyButton2.BottomColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        MyButton2.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        MyButton2.ForeColor = Color.White
        MyButton2.Location = New Point(369, 348)
        MyButton2.Name = "MyButton2"
        MyButton2.Size = New Size(349, 100)
        MyButton2.TabIndex = 15
        MyButton2.Text = "Go Premium"
        MyButton2.TopColor = Color.FromArgb(CByte(90), CByte(100), CByte(171))
        MyButton2.UseVisualStyleBackColor = True
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(436, 134)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(216, 163)
        PictureBox8.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox8.TabIndex = 16
        PictureBox8.TabStop = False
        ' 
        ' ctlPremium
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        Controls.Add(PictureBox8)
        Controls.Add(MyButton2)
        Name = "ctlPremium"
        Size = New Size(1127, 639)
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents MyButton2 As MyButton
    Friend WithEvents PictureBox8 As PictureBox

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlSysPrerformance
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
        components = New ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Label2 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Label1 = New Label()
        Chart1 = New DataVisualization.Charting.Chart()
        ProgressBar1 = New ProgressBar()
        Label4 = New Label()
        Label3 = New Label()
        ProgressBar2 = New ProgressBar()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label5 = New Label()
        Label6 = New Label()
        Timer1 = New Timer(components)
        CType(Chart1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.ForeColor = Color.Silver
        Label2.Location = New Point(33, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(1054, 28)
        Label2.TabIndex = 37
        Label2.Text = "Monitor your computer's performance effortlessly and easily. We help you control your PC's speed exactly as you desire."
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.White
        FlowLayoutPanel1.Location = New Point(33, 160)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(1079, 10)
        FlowLayoutPanel1.TabIndex = 38
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 35F)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(22, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(641, 78)
        Label1.TabIndex = 36
        Label1.Text = "Computer Performance"
        ' 
        ' Chart1
        ' 
        ChartArea1.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Chart1.Legends.Add(Legend1)
        Chart1.Location = New Point(33, 211)
        Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "CPU Speed"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "RAM Speed"
        Chart1.Series.Add(Series1)
        Chart1.Series.Add(Series2)
        Chart1.Size = New Size(1079, 339)
        Chart1.TabIndex = 39
        Chart1.Text = "Chart1"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(202, 574)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(774, 29)
        ProgressBar1.TabIndex = 40
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 20F)
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(103, 557)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 46)
        Label4.TabIndex = 43
        Label4.Text = "CPU"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 20F)
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(103, 603)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 46)
        Label3.TabIndex = 44
        Label3.Text = "RAM"
        ' 
        ' ProgressBar2
        ' 
        ProgressBar2.Location = New Point(202, 620)
        ProgressBar2.Name = "ProgressBar2"
        ProgressBar2.Size = New Size(774, 29)
        ProgressBar2.TabIndex = 45
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(65), CByte(140), CByte(240))
        Panel1.Location = New Point(34, 571)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(63, 32)
        Panel1.TabIndex = 46
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(252), CByte(180), CByte(65))
        Panel2.Location = New Point(34, 617)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(63, 32)
        Panel2.TabIndex = 47
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20F)
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(982, 560)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 46)
        Label5.TabIndex = 48
        Label5.Text = "0%"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 20F)
        Label6.ForeColor = SystemColors.Control
        Label6.Location = New Point(982, 606)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 46)
        Label6.TabIndex = 49
        Label6.Text = "0%"
        ' 
        ' ctlSysPrerformance
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(18), CByte(23), CByte(30))
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(ProgressBar2)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(ProgressBar1)
        Controls.Add(Chart1)
        Controls.Add(Label2)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Label1)
        Name = "ctlSysPrerformance"
        Size = New Size(1143, 680)
        CType(Chart1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer1 As Timer

End Class

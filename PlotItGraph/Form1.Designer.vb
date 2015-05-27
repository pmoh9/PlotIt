<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea9 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend9 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Expression = New System.Windows.Forms.TextBox()
        Me.Samples = New System.Windows.Forms.ListBox()
        Me.Graph = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Graph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(406, 468)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Plot"
        '
        'Expression
        '
        Me.Expression.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Expression.Location = New System.Drawing.Point(260, 423)
        Me.Expression.Name = "Expression"
        Me.Expression.Size = New System.Drawing.Size(658, 20)
        Me.Expression.TabIndex = 5
        '
        'Samples
        '
        Me.Samples.FormattingEnabled = True
        Me.Samples.Items.AddRange(New Object() {"sin(x)", "cos(x)", "tan(x)", "1/x", "ln(x)", "log(x)", "e(x)", "pow(x,n)", "mod1(x)"})
        Me.Samples.Location = New System.Drawing.Point(12, 50)
        Me.Samples.Name = "Samples"
        Me.Samples.Size = New System.Drawing.Size(157, 342)
        Me.Samples.TabIndex = 12
        '
        'Graph
        '
        ChartArea9.Name = "ChartArea1"
        Me.Graph.ChartAreas.Add(ChartArea9)
        Legend9.Name = "Legend1"
        Me.Graph.Legends.Add(Legend9)
        Me.Graph.Location = New System.Drawing.Point(195, 12)
        Me.Graph.Name = "Graph"
        Series9.ChartArea = "ChartArea1"
        Series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series9.IsVisibleInLegend = False
        Series9.Legend = "Legend1"
        Series9.Name = "Series1"
        Me.Graph.Series.Add(Series9)
        Me.Graph.Size = New System.Drawing.Size(778, 365)
        Me.Graph.TabIndex = 13
        Me.Graph.Text = "Chart1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(655, 468)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Saved Functions"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 516)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Graph)
        Me.Controls.Add(Me.Samples)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Expression)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Plot It!"
        CType(Me.Graph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Expression As System.Windows.Forms.TextBox
    Friend WithEvents Samples As System.Windows.Forms.ListBox
    Friend WithEvents Graph As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class

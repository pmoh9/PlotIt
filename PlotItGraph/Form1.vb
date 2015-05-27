Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form1
    Inherits System.Windows.Forms.Form
    ''' <remarks>
    ''' Uses Evaluator library to evaluate a
    ''' mathematical expression as a string.
    ''' </remarks>
    WithEvents Evaluator1 As Evaluator

    ''' <summary>
    ''' Button1 click event
    ''' Plots the graph using values returned
    ''' by the EvalFunctions class.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Graph.Series(0).Points.Clear()
        Graph.Series(0).ChartType = SeriesChartType.Line
        Graph.Series(0).Color = Color.Red
        Dim i As Double = -10D
        Dim res As String = ""
        If Expression.Text = "1/x" Then
            Expression.Text = "pow(x,-1)"
        End If
        While i < 10D
            Try
                res = Evaluator1.Eval(Expression.Text.Replace("x", i.ToString)).ToString
                If res.Contains("E-") Then
                    res = "0"
                End If
            Catch ex As Exception
            End Try
            Graph.Series(0).Points.AddXY(i, Double.Parse(res))
            i += 0.001D
        End While
    End Sub

    ''' <summary>
    ''' Saved functions or samples
    ''' Can be directly saved and selected from
    ''' ListBox Samples.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Samples_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Samples.SelectedIndexChanged
        Expression.Text = Samples.Text
    End Sub

    ''' <summary>
    ''' Call to Evaluator library as
    ''' a new object.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Evaluator1 = New Evaluator
        Samples.SelectedIndex = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Samples.Items.Add(Expression.Text)
    End Sub
End Class

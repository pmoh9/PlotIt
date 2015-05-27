Public Class EvalFunctions
    Function sin(ByVal v As Double) As Double
        Return Math.Sin(v * Math.PI)
    End Function

    Function cos(ByVal v As Double) As Double
        Return Math.Cos(v * Math.PI)
    End Function

    Function tan(ByVal v As Double) As Double
        Return Math.Tan(v * Math.PI)
    End Function

    Function log(ByVal v As Double) As Double
        Return Math.Log10(v)
    End Function

    Function ln(ByVal v As Double) As Double
        Return Math.Log(v)
    End Function

    Function e(ByVal v As Double) As Double
        Return Math.Exp(v)
    End Function

    Function pow(ByVal v As Double, ByVal n As Double) As Double
        Return Math.Pow(v, n)
    End Function

    Function mod1(ByVal v As Double) As Double
        Return Math.Abs(v)
    End Function

    Function rnd() As Integer
        Microsoft.VisualBasic.Randomize()
        Return CInt(Microsoft.VisualBasic.Rnd() * 100)
    End Function

    Function len(ByVal str As String) As Double
        Return Microsoft.VisualBasic.Len(str)
    End Function

    Function trim(ByVal str As String) As String
        Return Microsoft.VisualBasic.Trim(str)
    End Function

    Function [Date](ByVal year As Double, ByVal month As Double, ByVal day As Double) As DateTime
        Return New Date(CInt(year), CInt(month), CInt(day))
    End Function

    Function Int(ByVal value As Double) As Double
        Return Microsoft.VisualBasic.Int(value)
    End Function

    Function Round(ByVal value As Double) As Double
        Return Math.Round(value)
    End Function
End Class

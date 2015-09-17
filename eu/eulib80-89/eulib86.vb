Public Class eulib86
    Public Sub Main()
        Dim x As Integer = 0
        Dim c As Integer
        Dim count As Integer

        While count < 1000000
            x = x + 1
            For y = x To 1 Step -1
                For z = y To 1 Step -1
                    'a = (x + y) ^ 2 + z ^ 2
                    'b = (x + z) ^ 2 + y ^ 2
                    c = (y + z) ^ 2 + x ^ 2
                    'q = Math.Min(a, Math.Min(b, c))
                    If Math.Sqrt(c) = Math.Floor(Math.Sqrt(c)) Then
                        count = count + 1
                        'Console.WriteLine(String.Join(vbTab, {"{0}", "{1}", "{2}", "{3}", "{4}"}), x, y, z, Math.Sqrt(q), count)
                    End If
                Next
            Next
        End While
        'two min....
        Console.WriteLine("{0}" & vbTab & "{1}", x, count)

    End Sub
End Class

Public Class eulib86
    Public Sub Main()
        Dim lim As Integer = 0
        Dim q As Integer = 0
        Dim count As Integer

        While count < 2000
            lim = lim + 1
            'count = 0
            Dim x = lim
            For y = x To 1 Step -1
                For z = y To 1 Step -1
                    'rotation case
                    'If x <> y AndAlso y = z Then Continue For
                    q = Math.Min(Math.Min((x + y) ^ 2 + z ^ 2, (x + z) ^ 2 + y ^ 2), (y + z) ^ 2 + x ^ 2)
                    If Math.Sqrt(q) = Math.Floor(Math.Sqrt(q)) Then
                        count = count + 1
                        'Console.WriteLine(String.Join(vbTab, {"{0}", "{1}", "{2}", "{3}"}), x, y, z, Math.Sqrt(q))
                    End If
                Next
            Next


        End While


    End Sub
End Class

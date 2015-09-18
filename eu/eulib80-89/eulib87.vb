
Public Class eulib87
    Public Sub Main()
        Dim h As New helper.Primes
        Dim p As New List(Of Long)

        Dim max As Integer = 50000000
        p = h.sieve_lst(Math.Ceiling(Math.Sqrt(max + 1)))

        Dim sq As New List(Of Integer)
        For Each prime In p
            If prime ^ 2 <= max Then
                sq.add(prime ^ 2)
            End If
        Next

        Dim cb As New List(Of Integer)
        For Each prime In p
            If prime ^ 3 <= max Then
                cb.add(prime ^ 3)
            End If
        Next

        Dim qd As New List(Of Integer)
        For Each prime In p
            If prime ^ 4 <= max Then
                qd.Add(prime ^ 4)
            Else : Exit For
            End If
        Next

        Dim works As New BitArray(max + 1, False)
        Dim cnt As Integer = 0
        For Each a In sq
            For Each b In cb
                For Each c In qd
                    If a + b + c < max AndAlso works(a + b + c) = False Then
                        works(a + b + c) = True
                        cnt += 1
                    End If
                Next
            Next
        Next

        Console.WriteLine("How many numbers below fifty million can be expressed as the sum of a prime square, prime cube, and prime fourth power?")
        Console.WriteLine(cnt)

    End Sub
End Class

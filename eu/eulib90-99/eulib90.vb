Public Class eulib90
    Public Sub Main()
        Dim arr(11) As Integer
        Dim l(5) As Integer
        Dim r(5) As Integer
        Dim cnt As Integer = 0

        'While arr(0) < 10
        '    increment(arr)
        '    For a = 0 To 5
        '        l(a) = arr(a)
        '        r(a) = arr(a + 6)
        '    Next
        '    If test(l, r) Then
        '        cnt += 1
        '        If cnt Mod 10000 = 0 Then
        '            Console.WriteLine(cnt)
        '        End If
        '    End If
        'End While
        Console.WriteLine(6 ^ 20)
        Console.WriteLine(10 ^ 12)
    End Sub
    Public Sub increment(ByRef arr() As Integer)
        arr(11) += 1
        For a = arr.Count() - 1 To 1 Step -1
            If arr(a) = 10 Then
                arr(a) = 0
                arr(a - 1) += 1
            Else
                Exit For
            End If
        Next
    End Sub

End Class

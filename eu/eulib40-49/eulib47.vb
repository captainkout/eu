Public Class eulib47
	Public Sub Main()
		Dim p As New Primes
		Dim parr As BitArray
		parr = p.sieve(200000)

		Dim iarr(200000) As Integer
		For i = 2 To 200000
			If parr(i) = True Then
				For j = i To 200000 Step i
					iarr(j) = iarr(j) + 1
				Next
			End If
		Next
		Dim k As Integer = 2
		While iarr(k) < 4 OrElse iarr(k - 1) < 4 OrElse iarr(k - 2) < 4 OrElse iarr(k - 3) < 4
			k = k + 1
		End While
		Console.WriteLine("i:{0}   i-1:{1}   i-2:{2}   i-3:{3}", k, k - 1, k - 2, k - 3)

	End Sub
End Class

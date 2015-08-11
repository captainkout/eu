Public Class eulib46
	Public Sub Main()
		Dim p As New Primes
		Dim parr As BitArray
		parr = p.sieve(20000000)

		For i = 3 To 20000000 Step 2
			If parr(i) = False Then
				Dim valid As Boolean = False
				For j As Integer = 1 To Math.Floor(Math.Sqrt(i / 2))
					If parr(i - 2 * (j ^ 2)) = True Then
						'Console.WriteLine("i:{0}   j:{1}   p:{2}", i, j, i - 2 * j ^ 2)
						valid = True
						Exit For
					End If
				Next
				If valid = False Then
					Console.WriteLine("failed to solve i = {0}", i)
					Exit Sub
				End If
			End If
		Next


	End Sub
End Class

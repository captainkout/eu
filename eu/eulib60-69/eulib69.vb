Public Class eulib69
	Public Sub Main()
		Dim m As Integer = 1000000
		Dim p As New helper.Primes
		Dim parr As BitArray = p.sieve(m)

		Dim rparr(m) As Double
		For a = 2 To m
			rparr(a) = a
		Next

		For a = 2 To parr.Count() - 1
			If parr(a) = True Then
				For b = a To parr.Count() - 1 Step a
					rparr(b) = rparr(b) * (1 - 1 / a)
				Next
			End If
		Next

		For a = 2 To parr.Count() - 1
			rparr(a) = a / rparr(a)
		Next

		Dim dmax As Double = 0
		Dim sol As Integer = 0
		For a = 2 To rparr.Count() - 1
			If rparr(a) > dmax Then
				dmax = rparr(a)
				sol = a
			End If
		Next

		Console.WriteLine(sol)
	End Sub
End Class

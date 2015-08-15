Imports helper.Primes
Public Class eulib58
	Public Sub Main()
		Dim p As New helper.Primes
		Dim parr As BitArray = p.sieve(1000000000)
		'1000000000

		Dim cnum As Integer = 1
		Dim cprimes As Integer = 0
		Dim n As Integer = 1
		Dim x As Long = 1
		While True
			For m = 1 To 4
				cnum = cnum + 1
				x = x + 2 * n
				If parr(x) = True Then
					cprimes = cprimes + 1
				End If
				If cprimes / cnum < 0.1 Then
					Console.WriteLine(1 + 2 * n)
					Exit Sub
				End If
			Next
			n = n + 1
		End While
	End Sub
End Class

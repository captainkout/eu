Imports eulib40_49
Public Class eulib50
	Public Sub Main()
		Dim p As New Primes
		Dim parr As BitArray
		parr = p.sieve(1000000)

		Dim plst As New List(Of Integer)
		For i = 0 To 1000000
			If parr(i) = True Then
				plst.Add(i)
			End If
		Next

		Dim start As Integer = 0
		While True
			Dim sum = 0
			Dim stp As Integer = start
			While sum < 1000
				sum = sum + plst(stp)
				stp = stp + 1
			End While
		End While



	End Sub
End Class

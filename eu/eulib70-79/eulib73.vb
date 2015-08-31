Public Class eulib73
	Public Sub Main()
		Dim h As New helper.Primes
		Dim parr As BitArray = h.sieve(8)

		Dim plst As New List(Of Integer)
		For a = 2 To parr.Count() - 1
			If parr(a) = True Then
				plst.Add(a)
			End If
		Next

	End Sub
End Class

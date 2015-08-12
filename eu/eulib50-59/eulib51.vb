Public Class eulib51
	Public Sub Main()
		Dim p As New helper.Primes
		Dim parr As BitArray()
		parr = p.sieve(1000000)

		'Dim repeaters As List(Of Integer)
		For i = 0 To 999999
			'do stuff
		Next

	End Sub
	Public Function rep(ByVal num As String)
		For Each digit In num
			If Not num.IndexOf(digit) = num.LastIndexOf(digit) Then
				Return True
			End If
		Next
		Return False
	End Function
End Class

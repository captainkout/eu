Imports helper
Public Class eulib51
	Public Sub Main()
		Dim p As New Primes
		Dim parr As BitArray
		parr = p.sieve(1000000)

		Dim primes As New List(Of String)
		For i = 10000 To 99999
			If parr(i) = True Then
				primes.Add(i)
			End If
		Next

		Dim test As String = "56003"
		For i = 0 To 4
			For j = i + 1 To 4
				If i = j Then
					Continue For
				End If

				Dim count As Integer = 0
				For k = 0 To 9
					If primes.Contains(test.Substring(0, i) & k.ToString() & test.Substring(i + 1, j - i - 1) & k.ToString() & test.Substring(j + 1)) Then
						count = count + 1
					End If
				Next
			Next
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

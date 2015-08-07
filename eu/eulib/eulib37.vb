Public Class eulib37
	Public Sub Main()
		Dim p As New eulib.Primes
		p.sieve(1000000)

		Dim examples As New List(Of Integer)
		For j = 0 To p.primes.Count() - 1
			'p.Next_Prime()

			Dim pstr As String = p.primes(j).ToString()
			If pstr.Length() = 1 Then
				Continue For
			End If
			Dim valid As Boolean = False
			For i = 0 To pstr.Length() - 1
				If p.primes.Contains(Val(pstr.Substring(i, pstr.Length() - i))) = False _
					OrElse p.primes.Contains(Val(pstr.Substring(0, pstr.Length() - i))) = False Then
					valid = False
					Exit For
				End If
				valid = True
			Next
			If valid = True Then
				examples.Add(p.primes(j))

			End If
			If examples.Count() = 11 Then
				Exit For
			End If
		Next
		Console.WriteLine("sum of truncatable primes is ", examples.Sum())
	End Sub
End Class

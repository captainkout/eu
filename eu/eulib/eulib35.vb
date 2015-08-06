
Public Class eulib35
	Public Sub Main()
		Dim p As New Primes
		p.To_Max(1000000)
		Dim examples As New List(Of Integer)

		For Each prime In p.primes
			Dim primestr As String = prime.ToString()
			Dim isrot As Boolean = False
			For Each digit In prime.ToString()
				primestr = primestr.Substring(1, primestr.Length() - 1) & primestr.Substring(0, 1)
				If Not p.primes.Contains(Val(primestr)) Then
					isrot = False
					Exit For
				End If
				isrot = True
			Next
			If isrot = True AndAlso examples.Contains(prime) = False Then
				examples.Add(prime)
			End If
		Next
		Console.WriteLine("total rot primes is {0}", examples.Count())

	End Sub
End Class

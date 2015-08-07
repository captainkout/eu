Imports eulib40_49
Public Class eulib41
	Public Sub Main()
		Dim p As New eulib40_49.Primes
		Dim primes As BitArray
		primes = p.sieve(999999999)
		'p.sieve(987654321)
		Dim pandigital As New List(Of Integer)

		For i = primes.Count() - 1 To 0 Step -1
			If primes(i) = True Then
				Dim pstr As String = i.ToString()

				If Not pstr.Contains("0") Then
					Dim valid As Boolean = True
					For j = 1 To pstr.Length()
						If pstr.Contains(j.ToString()) = False OrElse _
							pstr.IndexOf(j.ToString()) <> pstr.LastIndexOf(j.ToString()) Then
							valid = False
							Exit For
						End If
					Next
					If valid = True Then
						pandigital.Add(i)
						Exit For
						'Console.WriteLine("{0}   {1}", i, i.ToString.Length())
					End If
				End If
			End If
		Next

		Console.WriteLine(pandigital.Max())

	End Sub
End Class

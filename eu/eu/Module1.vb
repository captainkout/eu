Imports eulib
Module Module1

	Sub Main()
		Dim x As New Primes
		While x.primes.Max() < 100
			x.Next_Prime()
		End While
		x.Next_Prime()
		Console.WriteLine(String.Join(",", x.primes.ToArray()))
		Console.ReadKey()

	End Sub

End Module

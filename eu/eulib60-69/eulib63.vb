Public Class eulib63
	Public Sub Main()
		Dim n As Integer = 1
		Dim e As System.Numerics.BigInteger = 0
		Dim count As Integer = 0
		For a = 1 To 9
			e = a ^ n
			While e.ToString().Length() = n
				count = count + 1

				n = n + 1
				e = a ^ n
			End While
			n = 1
		Next
		Console.WriteLine(count)
	End Sub
End Class
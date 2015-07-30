Imports System.Numerics

Public Class eulib25
	Public Sub Main()
		Dim a As BigInteger = 1
		Dim b As BigInteger = 1
		Dim c As BigInteger = 0

		Dim count As Integer = 2

		While c.ToString.Length() < 1000

			c = a + b
			count = count + 1

			a = b
			b = c
			If count Mod 100 Then
				Console.WriteLine("count: {0} --> {1}", count, c.ToString())
			End If
		End While

		Console.ReadKey()

	End Sub
End Class

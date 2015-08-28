Imports System.Numerics.BigInteger

Public Class eulib66
	Public Sub Main()
		Dim a As New Numerics.BigInteger
		Dim b As New Numerics.BigInteger
		Dim N = 67, k = 0
		Dim m As New Numerics.BigInteger


		'find trivial
		a = Math.Floor(Math.Sqrt(N))
		b = 1
		k = a * a - N * b * b

		'Console.WriteLine(B.Sign())

		While Not k = 1
			'find min k value
			Dim kindex1 = 0, minimal = 9999999
			m = Math.Abs(k)
			Dim tmpBig As New Numerics.BigInteger
			'go down
			While Not (a + (a - kindex1)) Mod m = 0
				kindex1 = kindex1 + 1
			End While
			tmpBig = m * m - N
			If tmpBig.Sign() = 1 AndAlso tmpBig < minimal Then
				minimal = N + tmpBig.Sign() * (tmpBig)
				m = (a - kindex1)
			ElseIf tmpBig > -1 * minimal Then
				minimal = N - tmpBig.Sign() * (tmpBig)
				m = (a - kindex1)
			End If
			'go up
			kindex1 = 0
			While Not (a + (a + kindex1)) Mod m = 0
				kindex1 = kindex1 + 1
			End While
			If tmpBig.Sign() = 1 AndAlso tmpBig < minimal Then
				minimal = N + tmpBig.Sign() * (tmpBig)
				m = (a - kindex1)
			ElseIf tmpBig > -1 * minimal Then
				minimal = N - tmpBig.Sign() * (tmpBig)
				m = (a - kindex1)
			End If

			a = (a * m + N * b) / Math.Abs(k)
			b = (a + b * m) / Math.Abs(k)
			k = (m * m - N) / k
		End While



	End Sub
End Class

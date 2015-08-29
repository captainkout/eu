Imports System.Numerics.BigInteger

Public Class eulib66
	Public Sub Main()
		Dim max As New List(Of Numerics.BigInteger)
		For N = 2 To 1000
			If Math.Floor(Math.Sqrt(N)) = Math.Sqrt(N) Then
				Continue For
			End If
			Dim a As New Numerics.BigInteger
			Dim b As New Numerics.BigInteger
			Dim k = 0
			Dim m As New Numerics.BigInteger

			Dim a2 As New Numerics.BigInteger
			Dim b2 As New Numerics.BigInteger
			Dim m2 As New Numerics.BigInteger

			'find trivial
			a = Math.Floor(Math.Sqrt(N))
			b = 1
			k = a * a - N * b * b
			m = 1

			While Not k = 1

				'find min k value
				Dim minimal = 9999999
				Dim tmpBig As New Numerics.BigInteger

				'go down from rootN
				Dim kindex1 = 0
				While Not (a + b * (Math.Floor(Math.Sqrt(N)) - kindex1)) Mod Math.Abs(k) = 0
					kindex1 = kindex1 + 1
				End While

				m = (Math.Floor(Math.Sqrt(N)) - kindex1)
				tmpBig = m * m - N
				If tmpBig.Sign() * tmpBig < minimal Then
					minimal = tmpBig.Sign() * (tmpBig)
				End If

				'go up from rootN
				kindex1 = 1
				While Not (a + b * (Math.Floor(Math.Sqrt(N)) + kindex1)) Mod Math.Abs(k) = 0
					kindex1 = kindex1 + 1
				End While

				m2 = Math.Floor(Math.Sqrt(N)) + kindex1
				tmpBig = m2 * m2 - N
				If tmpBig.Sign() * tmpBig < minimal Then
					m = m2
				End If
				a2 = a
				b2 = b
				a = (a * m + N * b) / Math.Abs(k)
				b = (a2 + b2 * m) / Math.Abs(k)
				k = (m * m - N) / k
			End While

			If max.Count() = 0 Then
				max.Add(N)
				max.Add(a)
			ElseIf a > max(1) Then
				max(0) = N
				max(1) = a
			End If


		Next

		Console.WriteLine("{0}  {1}", max(0), max(1))


	End Sub
End Class

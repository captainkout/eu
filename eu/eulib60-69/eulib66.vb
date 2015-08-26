Imports System.Numerics.BigInteger

Public Class eulib66
	Public Sub Main()
		'Dim lst As New List(Of Long)
		'Dim l As Long
		'Dim max As Long
		'max = 10000000

		'For a As Long = 0 To max
		'	l = a * a
		'	lst.Add(l)
		'Next
		Dim grr As Double = 0
		For d As Double = 2 To 50

			If Math.Floor(Math.Sqrt(d)) = Math.Sqrt(d) Then Continue For
			Dim x As Double = 2

			While True
				grr = Math.Sqrt((x * x - 1) / d)
				If Math.Floor(grr) = grr Then
					Console.WriteLine("{0}" & vbTab & "{1}" & vbTab & "{2}", x, d, "boobs")
					Exit While
				End If

				x = x + 1
			End While
		Next

		Console.WriteLine(Numerics.BigInteger.GreatestCommonDivisor(9801, 169))

	End Sub
End Class

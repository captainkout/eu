Imports System.Numerics.BigInteger

Public Class eulib66
	Public Sub Main()
		Dim test As Long = 0
		Dim grr As Double = 2
		For d As Double = 2 To 1000

			If Math.Floor(Math.Sqrt(d)) = Math.Sqrt(d) Then
				Console.WriteLine("{0}" & vbTab & "{1}" & vbTab & "{2}" & vbTab & "{3}", "...", d, "...", "...")
				Continue For
			End If
			Dim x As Double = Max(2, Math.Floor(d / grr))
			While True
				grr = Math.Sqrt((x * x - 1) / d)
				If Math.Floor(grr) = grr Then
					If test < x Then
						test = x
						Console.WriteLine("{0}" & vbTab & "{1}" & vbTab & "{2}" & vbTab & "{3}", test, d, grr, x / grr)
					End If

					Exit While
				End If
				x = x + 1
			End While
		Next



	End Sub
End Class

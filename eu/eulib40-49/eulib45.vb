Public Class eulib45
	Public Sub Main()
		Dim found As Integer = 0
		'Dim test As Long = 89478753
		'test = 24 * test + 1

		Dim i As Long = 1
		Dim lin As Long = -1

		While found < 2
			lin = lin + 1
			i = i + 5 + lin * 4
			Dim hex As Double = (Math.Sqrt(8 * i + 1) + 1) / 4
			If Math.Ceiling(hex) = hex Then
				Dim pen As Double = (Math.Sqrt(24 * i + 1) + 1) / 6
				If Math.Ceiling(pen) = pen Then
					Dim tri As Double = (Math.Sqrt(8 * i + 1) - 1) / 2
					If Math.Ceiling(tri) = tri Then
						found = found + 1
						Console.WriteLine(i, tri, pen, hex)
					End If
				End If
			End If
		End While
	End Sub
End Class

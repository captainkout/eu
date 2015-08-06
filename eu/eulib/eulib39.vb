Public Class eulib39
	Public Sub Main()

		For a = 1 To Math.Ceiling(Math.Sqrt(1000))
			For b = 1 To Math.Ceiling(Math.Sqrt(1000))
				Dim c = Math.Sqrt(a ^ 2 + b ^ 2)
				If a + b + c = 120 Then
					Console.WriteLine("yah")
				End If
			Next
		Next
	End Sub
End Class

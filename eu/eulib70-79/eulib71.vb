Public Class eulib71
	Public Sub Main()
		Dim find As Double = (3 / 7)
		Dim highest As Integer = 1000000
		Dim closest() As Double = {0, 0, 1}

		Dim dedbl As Double = 0
		For d = highest To 2 Step -1

			For n = Math.Ceiling(d * find) To Math.Floor(d * find) Step -1
				dedbl = n / d
				If dedbl < find AndAlso find - dedbl < closest(2) Then
					closest(0) = n
					closest(1) = d
					closest(2) = find - dedbl
				End If
			Next
		Next
		Console.WriteLine("{0}   {1}   {2}", closest(0), closest(1), closest(2))
	End Sub
End Class

Public Class eulib78
	Public Sub Main()

		Dim max As Integer = 100000
		Dim find As Integer = 1000000
		Dim arr(max) As Integer

		Dim a As Long = 1
		For a = 1 To max
			For b As Long = a To arr.GetUpperBound(0)
				If a = b Then
					arr(b) = (arr(b) + 1) Mod find
					If arr(b) = 0 Then
						Console.WriteLine(b)
						Exit Sub
					End If
				Else
					arr(b) = (arr(b) + arr(b - a)) Mod find
				End If
			Next
		Next

	End Sub
End Class

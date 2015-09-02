
Public Class eulib76
	Public Sub Main()
		Dim max As Integer = 100
		Dim arr(max + 1) As Integer
		'For a = 1 To arr.GetUpperBound(0)
		'	arr(a) = 1
		'Next

		For n = 1 To max
			For a = n To arr.GetUpperBound(0)
				If a - n = 0 Then
					arr(a) = arr(a) + 1
				Else
					arr(a) = arr(a) + arr(a - n)
				End If
			Next
		Next

		Console.WriteLine(arr(100) - 1)

	End Sub
End Class

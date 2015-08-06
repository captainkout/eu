Public Class eulib36
	Public Sub Main()

		Dim ten As New List(Of Integer) From {0}
		Dim two As New List(Of Integer) From {0}
		Dim examples As New List(Of Integer)

		For i = 1 To 999999
			ten(0) = ten(0) + 1
			For j = 0 To ten.Count() - 1
				If ten(j) > 9 AndAlso j = ten.Count() - 1 Then
					ten(j) = 0
					ten.Add(1)
				ElseIf ten(j) > 9 Then
					ten(j) = 0
					ten(j + 1) = ten(j + 1) + 1
				End If
			Next

			two(0) = two(0) + 1
			For j = 0 To two.Count() - 1
				If two(j) > 1 AndAlso j = two.Count() - 1 Then
					two(j) = 0
					two.Add(1)
				ElseIf two(j) > 1 Then
					two(j) = 0
					two(j + 1) = two(j + 1) + 1
				End If
			Next
			If pal(two) AndAlso pal(ten) Then
				examples.Add(i)
			End If
		Next

		Console.WriteLine("sum of all palidromic numbers in base ten and two is {0}", examples.Sum())
	End Sub
	Public Function pal(ByVal arr As List(Of Integer))
		For i = 0 To Math.Floor(arr.Count() / 2)
			If arr(i) <> arr(arr.Count() - 1 - i) Then
				Return False
			End If
		Next
		Return True
	End Function
End Class

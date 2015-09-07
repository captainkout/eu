Public Class eulib82
	Public Sub Main()
		'Dim f As New System.IO.StreamReader("c:\users\chris\downloads\test81.txt")
		'Dim f As New System.IO.StreamReader("c:\users\chris\downloads\p081_matrix.txt")
		Dim f As New System.IO.StreamReader("C:\Users\ckoutras\Downloads\p081_matrix.txt")

		Dim fstr As String = f.ReadToEnd().Replace(vbLf, ",")
		Dim farr() As String = fstr.Split(",")
		'x+1 by y+1 for 2 extra rows/col full of 99999
		Dim clarr(81, 81) As coord


		For x = clarr.GetUpperBound(0) To 0 Step -1
			For y = 0 To clarr.GetUpperBound(1)
				Dim c As New coord
				c.x = x
				c.y = y

				If x = 0 OrElse y = 0 OrElse x = clarr.GetUpperBound(0) OrElse y = clarr.GetUpperBound(1) Then
					c.original = 99999999
					c.changed = False
				Else
					c.original = farr((x - 1) + (clarr.GetUpperBound(0) - 1) * ((clarr.GetUpperBound(0) - 1) - y))
					c.changed = True
				End If

				c.value = 99999999

				clarr(x, y) = c
			Next
		Next

		For y = 1 To clarr.GetUpperBound(1) - 1
			'left edge
			clarr(0, y).value = 0
			clarr(0, y).original = 0
			'right edge
			clarr(clarr.GetUpperBound(1), y).value = 0
			clarr(clarr.GetUpperBound(1), y).original = 0
		Next


		While chk_changed(clarr)
			'start at bottom right
			For x = clarr.GetUpperBound(0) - 1 To 0 Step -1
				For y = 1 To clarr.GetUpperBound(1) - 1
					If clarr(x, y).value <> clarr(x, y).original + _
						Math.Min(clarr(x + 1, y).value, _
						Math.Min(clarr(x, y - 1).value, clarr(x, y + 1).value)) Then

						clarr(x, y).changed = True
						clarr(x, y).value = clarr(x, y).original + _
							Math.Min(clarr(x + 1, y).value, _
							Math.Min(clarr(x, y - 1).value, clarr(x, y + 1).value))
					Else : clarr(x, y).changed = False
					End If

				Next
			Next
		End While

		Dim min As Integer = 0
		For y = 1 To clarr.GetUpperBound(1) - 1
			If min = 0 OrElse min > clarr(1, y).value Then
				min = clarr(1, y).value
			End If
		Next
		Console.WriteLine(min)

	End Sub
	Public Class coord
		Public Property x As Integer
		Public Property y As Integer
		Public Property changed As Boolean
		Public Property value As Integer
		Public Property original As Integer
	End Class
	Public Function chk_changed(ByRef arr As Array)
		For Each c In arr
			If c.changed = True Then
				Return True
			End If
		Next
		Return False
	End Function
End Class

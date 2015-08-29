Public Class eulib67b

	Public Sub Main()
		Dim lst As New List(Of Integer) From {0, 0, 0, 0, 0, 0}
		Dim max As Long = 0
		For N = 0 To 18
			For a = 0 To 6
				For b = 0 To 6
					If a = b Then Continue For
					For c = 0 To 6
						If c = a OrElse c = b Then Continue For
						lst(0) = a
						lst(1) = b
						lst(2) = c

						lst(3) = N - (a + b)
						lst(4) = N - (b + c)
						lst(5) = N - (c + a)

						Dim flag = True
						For Each fint In lst
							If lst.IndexOf(fint) <> lst.LastIndexOf(fint) OrElse fint > 6 Then
								flag = False
							End If
						Next
						If flag = False Then Continue For
						Dim strtest = stringify(lst)

						If strtest.ToString().Length() = 9 AndAlso CLng(strtest) > max Then
							max = CLng(strtest)
						End If

					Next
				Next
			Next
		Next

		Console.WriteLine(max)
	End Sub
	Public Function stringify(ByRef l As List(Of Integer))
		Select Case l.GetRange(3, 3).Min()
			Case l(3)
				Return l(3).ToString() & l(0).ToString() & l(1).ToString() & _
				l(4).ToString() & l(1).ToString() & l(2).ToString() & _
				l(5).ToString() & l(2).ToString() & l(0).ToString()

			Case l(4)
				Return l(4).ToString() & l(1).ToString() & l(2).ToString() & _
				l(5).ToString() & l(2).ToString() & l(0).ToString() & _
				l(3).ToString() & l(0).ToString() & l(1).ToString()
			Case l(5)
				Return l(5).ToString() & l(2).ToString() & l(0).ToString() & _
				l(3).ToString() & l(0).ToString() & l(1).ToString() & _
				l(4).ToString() & l(1).ToString() & l(2).ToString()
		End Select
		Return "boobs"
	End Function
End Class

Public Class eulib67
	Public Sub Main()
		Dim lst As New List(Of Integer) From {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
		Dim max As Long = 0
		For N = 0 To 30
			For i = 0 To lst.Count() - 1
				lst(i) = 0
			Next
			For a = 1 To 10
				For b = 1 To 10
					If a = b Then Continue For
					For c = 1 To 10
						If c = a OrElse c = b Then Continue For
						For d = 1 To 10
							If d = a OrElse d = b OrElse d = c Then Continue For
							For e = 1 To 10
								If e = a OrElse e = b OrElse e = c OrElse e = d Then Continue For
								lst(0) = a
								lst(1) = b
								lst(2) = c
								lst(3) = d
								lst(4) = e
								lst(5) = N - (a + b)
								lst(6) = N - (b + c)
								lst(7) = N - (c + d)
								lst(8) = N - (d + e)
								lst(9) = N - (e + a)

								Dim flag = True
								For Each fint In lst
									If lst.IndexOf(fint) <> lst.LastIndexOf(fint) OrElse fint > 10 Then
										flag = False
									End If
								Next
								If flag = False Then Continue For

								Dim strtest = stringify(lst)
								If strtest.ToString().Length() = 16 AndAlso CLng(strtest) > max Then
									max = CLng(strtest)
								End If

							Next
						Next
					Next
				Next
			Next
		Next
		Console.WriteLine(max)
	End Sub
	Public Function stringify(ByRef l As List(Of Integer))

		Select Case l.GetRange(5, 5).Min()

			Case l(5)
				Return l(5).ToString() & l(0).ToString() & l(1).ToString() & _
					l(6).ToString() & l(1).ToString() & l(2).ToString() & _
					l(7).ToString() & l(2).ToString() & l(3).ToString() & _
					l(8).ToString() & l(3).ToString() & l(4).ToString() & _
					l(9).ToString() & l(4).ToString() & l(0).ToString()
			Case l(6)
				Return l(6).ToString() & l(1).ToString() & l(2).ToString() & _
					l(7).ToString() & l(2).ToString() & l(3).ToString() & _
					l(8).ToString() & l(3).ToString() & l(4).ToString() & _
					l(9).ToString() & l(4).ToString() & l(0).ToString() & _
					l(5).ToString() & l(0).ToString() & l(1).ToString()
			Case l(7)
				Return l(7).ToString() & l(2).ToString() & l(3).ToString() & _
					l(8).ToString() & l(3).ToString() & l(4).ToString() & _
					l(9).ToString() & l(4).ToString() & l(0).ToString() & _
					l(5).ToString() & l(0).ToString() & l(1).ToString() & _
					l(6).ToString() & l(1).ToString() & l(2).ToString()
			Case l(8)
				Return l(8).ToString() & l(3).ToString() & l(4).ToString() & _
					l(9).ToString() & l(4).ToString() & l(0).ToString() & _
					l(5).ToString() & l(0).ToString() & l(1).ToString() & _
					l(6).ToString() & l(1).ToString() & l(2).ToString() & _
					l(7).ToString() & l(2).ToString() & l(3).ToString()
			Case l(9)
				Return l(9).ToString() & l(4).ToString() & l(0).ToString() & _
					l(5).ToString() & l(0).ToString() & l(1).ToString() & _
					l(6).ToString() & l(1).ToString() & l(2).ToString() & _
					l(7).ToString() & l(2).ToString() & l(3).ToString() & _
					l(8).ToString() & l(3).ToString() & l(4).ToString()
		End Select

		Return "boobs"
	End Function
End Class

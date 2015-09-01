Public Class eulib75
	Public Sub Main()
		Dim max As Integer = 1500000
		Dim orig As New Tuple(Of Integer, Integer, Integer)(3, 4, 5)
		Dim lst As New List(Of Tuple(Of Integer, Integer, Integer))
		Dim arr(max) As Integer
		lst.Add(orig)
		For a = 12 To max Step 12
			arr(a) = arr(a) + 1
		Next
		'transforms
		Dim begin As Integer = 0
		While begin <= lst.Count() - 1
			Dim ta As New Tuple(Of Integer, Integer, Integer) _
				(1 * lst(begin).Item1() - 2 * lst(begin).Item2() + 2 * lst(begin).Item3(), _
				2 * lst(begin).Item1() - 1 * lst(begin).Item2() + 2 * lst(begin).Item3(), _
				2 * lst(begin).Item1() - 2 * lst(begin).Item2() + 3 * lst(begin).Item3())
			For a = ta.Item1 + ta.Item2 + ta.Item3 To max Step ta.Item1 + ta.Item2 + ta.Item3
				arr(a) = arr(a) + 1
			Next
			If ta.Item1 + ta.Item2 + ta.Item3 <= max Then
				lst.Add(ta)
			End If

			Dim tb As New Tuple(Of Integer, Integer, Integer) _
				(1 * lst(begin).Item1() + 2 * lst(begin).Item2() + 2 * lst(begin).Item3(), _
				2 * lst(begin).Item1() + 1 * lst(begin).Item2() + 2 * lst(begin).Item3(), _
				2 * lst(begin).Item1() + 2 * lst(begin).Item2() + 3 * lst(begin).Item3())
			For a = tb.Item1 + tb.Item2 + tb.Item3 To max Step tb.Item1 + tb.Item2 + tb.Item3
				arr(a) = arr(a) + 1
			Next
			If tb.Item1 + tb.Item2 + tb.Item3 <= max Then
				lst.Add(tb)
			End If

			Dim tc As New Tuple(Of Integer, Integer, Integer) _
				(-1 * lst(begin).Item1() + 2 * lst(begin).Item2() + 2 * lst(begin).Item3(), _
				-2 * lst(begin).Item1() + 1 * lst(begin).Item2() + 2 * lst(begin).Item3(), _
				-2 * lst(begin).Item1() + 2 * lst(begin).Item2() + 3 * lst(begin).Item3())
			For a = tc.Item1 + tc.Item2 + tc.Item3 To max Step tc.Item1 + tc.Item2 + tc.Item3
				arr(a) = arr(a) + 1
			Next
			If tc.Item1 + tc.Item2 + tc.Item3 <= max Then
				lst.Add(tc)
			End If
			begin = begin + 1
		End While

		Dim tot As Integer = 0
		For a = 0 To arr.GetUpperBound(0)
			If arr(a) = 1 Then
				tot = tot + 1
			End If
		Next

		Console.WriteLine(tot)
	End Sub
End Class

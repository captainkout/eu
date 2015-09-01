Public Class eulib74
	Public Sub Main()
		Dim fac As New List(Of Long) From {1}
		For i = 1 To 9
			fac.Add(fac(i - 1) * i)
		Next
		Dim cnt As Integer
		Dim tot As Integer = 0
		For a As Long = 1 To 999999
			cnt = 0
			Dim sum As Long = a
			Dim lst As New List(Of Long)
			While lst.Contains(sum) = False
				cnt = cnt + 1
				lst.Add(sum)
				Dim newsum As Integer = 0
				For Each dig In sum.ToString()
					newsum = newsum + fac(Val(dig))
				Next
				sum = newsum
			End While
			If cnt = 60 Then
				tot = tot + 1
			End If
		Next
		Console.WriteLine(tot)
	End Sub

End Class

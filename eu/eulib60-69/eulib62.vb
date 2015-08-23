Public Class eulib62
	Public Sub Main()
		Dim p As New helper.permuations
		Dim dic As New Dictionary(Of String, List(Of Long))

		Dim aaa As Long = 0
		Dim count As Integer = 0
		Dim strcount As String = ""
		For x = 0 To 25
			For y = 10 ^ x To 10 ^ (x + 1)
				aaa = y ^ 3
				Dim pcount As Array = p.count_dig(aaa)
				strcount = ""
				For c = 0 To pcount.GetUpperBound(0)
					strcount = strcount & pcount(c) & ","
				Next
				If dic.ContainsKey(strcount) = False Then
					Dim lst As New List(Of Long)
					lst.Add(aaa)
					dic(strcount) = lst
				Else
					dic(strcount).Add(aaa)
					count = dic(strcount).Count()
				End If
			Next
			For Each l In dic.Keys()
				If dic(l).Count() = 5 Then
					For Each n In dic(l)
						Console.Write(n.ToString & vbTab)
					Next
					Exit Sub
				End If
			Next
		Next
	End Sub
End Class

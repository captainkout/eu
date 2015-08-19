Public Class eulib60
	Public Sub Main()
		Dim p As New helper.Primes
		Dim max As Integer = 9999999
		Dim parr As BitArray = p.sieve(max)
		Dim pdic As New Dictionary(Of Integer, List(Of Integer))
		Dim plst As New List(Of String)

		For a = 0 To parr.Length() - 1
			If parr(a) = True Then
				'If Not pdic.ContainsKey(10 ^ (a.ToString().Length() - 1)) Then
				'	pdic(10 ^ (a.ToString().Length() - 1)) = New List(Of Integer)
				'End If
				'pdic(10 ^ (a.ToString().Length() - 1)).Add(a)

				'check if all mods are prime

				plst.Add(a.ToString())
			End If
		Next

		For b = 0 To plst.Count() - 1
			For c = b + 1 To plst.Count() - 1
				Dim bc As String = Val(plst(b).ToString() & plst(c).ToString())
				Dim cb As String = Val(plst(c).ToString() & plst(b).ToString())
				If bc < max AndAlso cb < max Then
					If parr(bc) = True AndAlso _
					parr(cb) = True Then
						If pdic.ContainsKey(plst(b)) = False Then
							pdic(plst(b)) = New List(Of Integer)
						End If
						pdic(plst(b)).Add(plst(c))
					End If
				Else
					Exit For
				End If
			Next
		Next

		For a = 0 To plst.Count() - 1
			Dim pcount As New List(Of Integer) From {plst(a)}

			For b = 0 To a
				If pdic(pdic.Keys()(b)).Contains(plst(a)) Then
					pcount.Add(pdic.Keys()(b))
					If pcount.Count() = 5 Then
						Dim tot As Integer = 0
						For Each i In pcount
							tot = tot + i
							Console.Write(i & vbTab)
						Next
						Console.Write("sum:{0}", tot)
						Exit Sub
					End If
				End If
			Next
		Next
	End Sub
	Public Function chk_left(ByVal prime As Integer, _
													 ByVal parr As BitArray)



		Return True
	End Function
End Class

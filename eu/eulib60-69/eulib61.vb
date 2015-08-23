Public Class eulib61
	Public parr As New List(Of Integer) From {0, 1, 2, 3, 4, 5}
	Public Sub Main()
		'get all 4 digit tri-oct number 
		Dim one As New Dictionary(Of Integer, List(Of String))
		init(one)

		'get all possible orders for tri-octs
		Dim h As New helper.permuations
		Dim perm As New List(Of Object)
		perm = h.perm(parr.ToArray(), 6)

		For Each p In perm
			For a = 0 To one(p(0)).Count() - 1
				For b = 0 To one(p(1)).Count() - 1
					If one(p(0))(a).Substring(2, 2) = one(p(1))(b).Substring(0, 2) Then
						For c = 0 To one(p(2)).Count - 1
							If one(p(1))(b).Substring(2, 2) = one(p(2))(c).Substring(0, 2) Then
								For d = 0 To one(p(3)).Count - 1
									If one(p(2))(c).Substring(2, 2) = one(p(3))(d).Substring(0, 2) Then
										For e = 0 To one(p(4)).Count - 1
											If one(p(3))(d).Substring(2, 2) = one(p(4))(e).Substring(0, 2) Then
												For f = 0 To one(p(5)).Count - 1
													If one(p(4))(e).Substring(2, 2) = one(p(5))(f).Substring(0, 2) AndAlso _
														one(p(5))(f).Substring(2, 2) = one(p(0))(a).Substring(0, 2) Then

														Console.WriteLine("p(0):{0}  a:{1}  one(p(0))(a):{2}", p(0), a, one(p(0))(a))
														Console.WriteLine("p(1):{0}  b:{1}  one(p(1))(b):{2}", p(1), b, one(p(1))(b))
														Console.WriteLine("p(2):{0}  c:{1}  one(p(2))(c):{2}", p(2), c, one(p(2))(c))
														Console.WriteLine("p(3):{0}  d:{1}  one(p(3))(d):{2}", p(3), d, one(p(3))(d))
														Console.WriteLine("p(4):{0}  e:{1}  one(p(4))(e):{2}", p(4), e, one(p(4))(e))
														Console.WriteLine("p(5):{0}  e:{1}  one(p(5))(f):{2}", p(5), f, one(p(5))(f))

														Console.WriteLine()
														Console.WriteLine(Val(one(p(0))(a)) + Val(one(p(1))(b)) + Val(one(p(2))(c)) + Val(one(p(3))(d)) + Val(one(p(4))(e)) + Val(one(p(5))(f)))
														Exit Sub
													End If
												Next
											End If
										Next
									End If
								Next
							End If
						Next
					End If
				Next
			Next
		Next

	End Sub

	Public Function init(ByRef dic As Dictionary(Of Integer, List(Of String)))

		For a = 0 To 10000
			If a = 0 Then
				Dim tmplst As New List(Of String) From {}
				dic(5) = tmplst
			End If
			Dim tmp As Integer = a * (a + 1) / 2
			If tmp > 1000 AndAlso tmp < 10000 AndAlso tmp.ToString().Substring(2, 1) <> "0" Then
				dic(5).Add(tmp)
			End If
			If tmp > 10000 Then Exit For
		Next
		For a = 0 To 10000
			If a = 0 Then
				Dim tmplst As New List(Of String) From {}
				dic(4) = tmplst
			End If
			Dim tmp As Integer = a * a
			If tmp > 1000 AndAlso tmp < 10000 AndAlso tmp.ToString().Substring(2, 1) <> "0" Then
				dic(4).Add(tmp)
			End If
			If tmp > 10000 Then Exit For
		Next
		For a = 0 To 10000
			If a = 0 Then
				Dim tmplst As New List(Of String) From {}
				dic(3) = tmplst
			End If
			Dim tmp As Integer = a * (3 * a - 1) / 2
			If tmp > 1000 AndAlso tmp < 10000 AndAlso tmp.ToString().Substring(2, 1) <> "0" Then
				dic(3).Add(tmp)
			End If
			If tmp > 10000 Then Exit For
		Next
		For a = 0 To 10000
			If a = 0 Then
				Dim tmplst As New List(Of String) From {}
				dic(2) = tmplst
			End If
			Dim tmp As Integer = a * (2 * a - 1)
			If tmp > 1000 AndAlso tmp < 10000 AndAlso tmp.ToString().Substring(2, 1) <> "0" Then
				dic(2).Add(tmp)
			End If
			If tmp > 10000 Then Exit For
		Next
		For a = 0 To 10000
			If a = 0 Then
				Dim tmplst As New List(Of String) From {}
				dic(1) = tmplst
			End If
			Dim tmp As Integer = a * (5 * a - 3) / 2
			If tmp > 1000 AndAlso tmp < 10000 AndAlso tmp.ToString().Substring(2, 1) <> "0" Then
				dic(1).Add(tmp)
			End If
			If tmp > 10000 Then Exit For
		Next
		For a = 0 To 10000
			If a = 0 Then
				Dim tmplst As New List(Of String) From {}
				dic(0) = tmplst
			End If
			Dim tmp As Integer = a * (3 * a - 2)
			If tmp > 1000 AndAlso tmp < 10000 AndAlso tmp.ToString().Substring(2, 1) <> "0" Then
				dic(0).Add(tmp)
			End If
			If tmp > 10000 Then Exit For
		Next
		Return dic
	End Function


End Class

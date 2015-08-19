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
			If plst(b) > max Then
				Exit Sub
			Else
				For c = b + 1 To plst.Count() - 1
					Dim bc As String = Val(plst(b).ToString() & plst(c).ToString())
					Dim cb As String = Val(plst(c).ToString() & plst(b).ToString())
					If bc > max OrElse cb > max Then
						Exit For
					ElseIf parr(bc) = True AndAlso parr(cb) = True Then
						For d = c + 1 To plst.Count() - 1
							Dim bd As String = Val(plst(b).ToString() & plst(d).ToString())
							Dim db As String = Val(plst(d).ToString() & plst(b).ToString())
							Dim cd As String = Val(plst(c).ToString() & plst(d).ToString())
							Dim dc As String = Val(plst(d).ToString() & plst(c).ToString())
							If bd > max OrElse db > max OrElse cd > max OrElse dc > max Then
								Exit For
							ElseIf parr(bd) = True AndAlso parr(db) = True AndAlso parr(cd) = True AndAlso parr(dc) = True Then
								For e = d + 1 To plst.Count() - 1
									Dim be As String = Val(plst(b).ToString() & plst(e).ToString())
									Dim eb As String = Val(plst(e).ToString() & plst(b).ToString())
									Dim ce As String = Val(plst(c).ToString() & plst(e).ToString())
									Dim ec As String = Val(plst(e).ToString() & plst(c).ToString())
									Dim de As String = Val(plst(e).ToString() & plst(d).ToString())
									Dim ed As String = Val(plst(d).ToString() & plst(e).ToString())
									If be > max OrElse eb > max OrElse ce > max OrElse ec > max OrElse de > max OrElse ed > max Then
										Exit For
									ElseIf parr(be) = True AndAlso parr(eb) = True AndAlso parr(ce) = True _
										AndAlso parr(ec) = True AndAlso parr(de) = True AndAlso parr(ed) = True Then

										For f = e + 1 To plst.Count() - 1
											Dim bf As String = Val(plst(b).ToString() & plst(f).ToString())
											Dim fb As String = Val(plst(f).ToString() & plst(b).ToString())
											Dim cf As String = Val(plst(c).ToString() & plst(f).ToString())
											Dim fc As String = Val(plst(f).ToString() & plst(c).ToString())
											Dim df As String = Val(plst(e).ToString() & plst(f).ToString())
											Dim fd As String = Val(plst(f).ToString() & plst(e).ToString())
											Dim ef As String = Val(plst(e).ToString() & plst(f).ToString())
											Dim fe As String = Val(plst(f).ToString() & plst(e).ToString())

											'just do last shit


										Next
										max = Val(plst(b)) + Val(plst(c)) + Val(plst(d)) + Val(plst(e))
										Console.WriteLine("a:{0} b:{1} c:{2} d:{3} e:{4} sum:{5}", "a isn't done", plst(b), plst(c), plst(d), plst(e), max)
									End If
								Next
							End If
						Next
					End If
				Next
			End If
		Next

	End Sub
	Public Function chk_left(ByVal prime As Integer, _
							 ByVal parr As BitArray)



		Return True
	End Function
End Class

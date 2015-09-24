Public Class eulib88

	Public Sub Main()

		Dim mink As New List(Of Integer)

		Dim max As Integer = 12000
		For a = 0 To max
			mink.Add(0)
		Next
		Dim l As New List(Of Integer)
		Dim p As New List(Of Integer)
		For a = 0 To Math.Floor(Math.Log10(2 * max) / Math.Log10(2))
			l.Add(0)
			p.Add(2 ^ a)
		Next
		l(l.Count() - 1) = 1
		l(l.Count() - 2) = 2

		Dim s As New SortedSet(Of Integer)
		Dim mult As Integer
		Dim non0 As Integer
		While l(0) <= 2
			increment(l, 2 * (mink.Count() - 1), p)
			check(l, non0, mult, mink.Count() - 1)

			If non0 <= max AndAlso (mink(non0) = 0 OrElse mult < mink(non0)) Then
				mink(non0) = mult
			End If
		End While
		For a = 2 To mink.Count() - 1
			s.Add(mink(a))
		Next
		Console.WriteLine(s.Sum())
	End Sub
	Public Sub increment(ByRef l As List(Of Integer), _
						ByVal lim As Integer, _
						ByRef p As List(Of Integer))

		Dim update As Boolean = False
		l(l.Count() - 1) += 1

		For a = l.Count() - 1 To 1 Step -1
			If l(a) > lim OrElse l(a) > p(a) Then
				update = True
				l(a) = 2
				If l(a - 1) = 0 Then
					l(a - 1) = 2
				Else
					l(a - 1) += 1
				End If
			Else
				Exit For
			End If
		Next

		If update = True Then
			Dim ugh As Integer = 1
			For a = 0 To l.Count() - 1
				If l(a) > 0 Then

					p(a) = (2 ^ a) / (ugh)
					ugh = ugh * l(a)
				End If
			Next
		End If
	End Sub
	Public Sub check(ByRef l As List(Of Integer), _
					ByRef non0 As Integer, _
					ByRef mult As Integer, _
					ByVal maxk As Integer)
		mult = 1
		non0 = 0
		For Each item In l
			If item > 0 Then
				non0 += 1
				mult = mult * item
			End If
		Next

		If non0 > 1 Then
			non0 = mult - l.Sum() + non0
		Else
			non0 = 0
		End If

	End Sub


End Class

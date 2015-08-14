Imports System.IO
Public Class eulib54
	Public Property dic As New List(Of String) From {"2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K", "A"}
	Public Sub Main()
		Dim f As New StreamReader("c:\\users\\chris\\downloads\\p054_poker.txt")
		'Dim number As New List(Of String) From {"2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K", "A"}
		While True


			Dim hand As New List(Of String)(f.ReadLine().Split(" "))
			Dim A As New List(Of String), B As New List(Of String)
			Dim acount As Integer = 0
			A = hand.GetRange(0, 5)
			B = hand.GetRange(5, 5)

			Dim aisflush = IsFlush(A)
			Dim bisflush = IsFlush(B)

			If aisflush.Item1() = True AndAlso bisflush.Item1() = True Then
				For i = aisflush.Item2().Count() - 1 To 0
					If aisflush.Item2(i) > bisflush.Item2(i) Then
						acount = acount + 1
					ElseIf aisflush.Item2(i) < bisflush.Item2(i) Then
						Exit For
					End If
				Next
			ElseIf aisflush.Item1() = True AndAlso bisflush.Item1() = False Then
				acount = acount + 1
			ElseIf aisflush.Item1() = False AndAlso bisflush.Item1() = True Then
				Continue While
				'go to next hand
			End If


		End While


	End Sub

	Public Function IsStraight(ByVal clst As List(Of String)) As Tuple(Of Integer, Integer)
		Dim diglst As New List(Of Integer)

		For Each c In clst
			diglst.Add(dic.IndexOf(c.Substring(0, 1)))
		Next
		diglst.Sort()

		For i = 0 To diglst.Count() - 2
			If diglst(i) <> diglst(i + 1) Then
				Return New Tuple(Of Integer, Integer)(1, diglst.Max())
			End If
		Next

		Return New Tuple(Of Integer, Integer)(0, 0)
	End Function
	Public Function IsFlush(ByVal clst As List(Of String)) As Tuple(Of Integer, List(Of Integer))
		Dim diglst As New List(Of Integer)

		Dim poss As New List(Of String) From {"H", "D", "C", "S"}

		For i = 0 To poss.Count() - 1
			Dim count As Integer = 0
			For Each c In clst
				If c.Contains(poss(i)) = True Then
					count = count + 1
				End If
			Next
			If count = 5 Then
				'is flush, get high card
				For Each c In clst
					diglst.Add(dic.IndexOf(c.Substring(1, 1)))
				Next
				diglst.Sort()
				Return New Tuple(Of Boolean, List(Of Integer))(True, diglst)
			End If
		Next
		Return New Tuple(Of Boolean, List(Of Integer))(False, Nothing)
	End Function
	Public Function IsQuad(ByVal clst As List(Of Integer)) As Tuple(Of Boolean, Integer)
		If clst.Contains(4) Then
			Return New Tuple(Of Boolean, Integer)(True, clst.IndexOf(4))
		End If
		Return New Tuple(Of Boolean, Integer)(False, 0)
	End Function
	Public Function IsFull(ByVal clst As List(Of Integer)) As Tuple(Of Boolean, Integer)
		If clst.Contains(3) AndAlso clst.Contains(2) Then
			Return New Tuple(Of Boolean, Integer)(True, clst.IndexOf(3))
		End If
		Return New Tuple(Of Boolean, Integer)(False, 0)
	End Function
	Public Function IsTrip(ByVal clst As List(Of Integer)) As Tuple(Of Boolean, Integer, Integer, Integer)
		If clst.Contains(3) AndAlso clst.Contains(1) Then
			Return New Tuple(Of Boolean, Integer, Integer, Integer)(True, clst.IndexOf(3), clst.LastIndexOf(1), clst.IndexOf(1))
		End If
		Return New Tuple(Of Boolean, Integer, Integer, Integer)(False, 0, 0, 0)
	End Function
	Public Function IsTwoPairIsTrip(ByVal clst As List(Of Integer)) As Tuple(Of Boolean, Integer, Integer, Integer)
		If clst.IndexOf(2) <> clst.LastIndexOf(2) Then
			Return New Tuple(Of Boolean, Integer, Integer, Integer)(True, clst.LastIndexOf(2), clst.IndexOf(2), clst.IndexOf(1))
		End If
		Return New Tuple(Of Boolean, Integer, Integer, Integer)(False, 0, 0, 0)
	End Function
	Public Function IsPair(ByVal clst As List(Of Integer)) As Tuple(Of Boolean, Integer, Integer, Integer, Integer)
		Dim hand As New List(Of Integer)
		If clst.IndexOf(2) = clst.LastIndexOf(2) Then
			For i = 12 To 0 Step -1
				If clst(i) = 1 Then
					For j = 1 To clst(i)
						hand.Add(i)
					Next
				End If
			Next
			Return New Tuple(Of Boolean, Integer, Integer, Integer, Integer)(True, clst.IndexOf(2), hand(0), hand(1), hand(2))
		End If
		Return New Tuple(Of Boolean, Integer, Integer, Integer, Integer)(True, clst.IndexOf(2), hand(0), hand(1), hand(2))
	End Function
	Public Function Ccount(ByVal clst As List(Of String)) As List(Of Integer)
		Dim cards As New List(Of Integer) From {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}

		For Each c In clst
			cards(dic.IndexOf(c.Substring(0, 1))) = cards(dic.IndexOf(c.Substring(0, 1))) + 1
		Next
		Return cards
	End Function
End Class

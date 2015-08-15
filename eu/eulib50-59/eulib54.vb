Imports System.IO
Public Class eulib54
	Public Property CardDic As New List(Of String) From {"2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K", "A"}
	Public Property SuitDic As New List(Of String) From {"C", "D", "H", "S"}

	Public Sub Main()
		Dim f As New StreamReader("c:\\users\\chris\\downloads\\p054_poker.txt")
		Dim fline As String = f.ReadLine()
		'Dim f As New StreamReader("c:\\users\\ckoutras\\downloads\\p054_poker.txt")

		Dim awins As Integer = 0
		Dim line As Integer = 1

		While fline <> ""
			Dim hand As New List(Of String)(fline.Split(" "))
			Dim A As New Dictionary(Of String, Object), B As New Dictionary(Of String, Object)

			A("cards") = hand.GetRange(0, 5)
			B("cards") = hand.GetRange(5, 5)

			A("card count") = CardCount(A("cards"))
			B("card count") = CardCount(B("cards"))

			A("suit count") = SuitCount(A("cards"))
			B("suit count") = SuitCount(B("cards"))

			A("is flush") = A("suit count").Contains(5)
			B("is flush") = B("suit count").Contains(5)

			A("is straight") = DirectCast(A("card count"), List(Of Integer)).Max() = 1 AndAlso A("card count").LastIndexOf(1) - A("card count").IndexOf(1) = 4
			B("is straight") = DirectCast(B("card count"), List(Of Integer)).Max() = 1 AndAlso B("card count").LastIndexOf(1) - B("card count").IndexOf(1) = 4

			Dim ABotPair As Integer = -1
			If A("card count").LastIndexOf(2) <> A("card count").IndexOf(2) Then
				ABotPair = A("card count").IndexOf(2)
			End If
			Dim BBotPair As Integer = -1
			If B("card count").LastIndexOf(2) <> B("card count").IndexOf(2) Then
				BBotPair = B("card count").IndexOf(2)
			End If

			A("sets") = New List(Of Integer) From {A("card count").IndexOf(4), _
																								 A("card count").IndexOf(3), _
																								 A("card count").LastIndexOf(2), _
																								 ABotPair}
			B("sets") = New List(Of Integer) From {B("card count").IndexOf(4), _
																								 B("card count").IndexOf(3), _
																								 B("card count").LastIndexOf(2), _
																								 BBotPair}

			Select Case True
				'check for straight flush
				Case (A("is flush") = True AndAlso A("is straight") = True) OrElse _
					(B("is flush") = True AndAlso B("is straight") = True)

					If (A("is flush") = True AndAlso A("is straight") = True) AndAlso _
					(B("is flush") = True AndAlso B("is straight") = True) Then
						awins = awins + HighCard(A("card count"), B("card count"))
					ElseIf (A("is flush") = True AndAlso A("is straight") = True) Then
						awins = awins + 1
					End If
					'bwins so don't add, just exit
					Exit Select	'this needs to be exit for instead of sub

					'check for quads
				Case A("sets")(0) > 0 OrElse B("sets")(0) > 0

					If A("sets")(0) > B("sets")(0) Then
						awins = awins + +1
					End If
					Exit Select

					'check for full house
				Case (A("sets")(1) > 0 AndAlso A("sets")(2) > 0) OrElse _
					(B("sets")(1) > 0 AndAlso B("sets")(2) > 0)

					If (A("sets")(1) > 0 AndAlso A("sets")(2) > 0) AndAlso _
					(B("sets")(1) > 0 AndAlso B("sets")(2) > 0) Then
						If A("sets")(1) > B("sets")(1) Then
							awins = awins + HighCard(A("card count"), B("card count"))
						End If
					ElseIf A("sets")(1) > 0 AndAlso A("sets")(2) > 0 Then
						awins = awins + 1
					End If
					'bwins
					Exit Select

					'check flush
				Case A("is flush") = True OrElse B("is flush") = True

					If A("is flush") = True AndAlso B("is flush") = True Then
						awins = awins + HighCard(A("card count"), B("card count"))
					ElseIf A("is flush") = True Then
						awins = awins + 1
					End If
					'bwins
					Exit Select

				Case A("is straight") = True OrElse B("is straight")

					If A("is straight") = True AndAlso B("is straight") = True Then
						awins = awins + HighCard(A("card count"), B("card count"))
					ElseIf A("is straight") = True Then
						awins = awins + 1
					End If
					'bwins
					Exit Select

					'check trips
				Case A("sets")(1) > 0 OrElse B("sets")(1) > 0

					If A("sets")(1) > B("sets")(1) Then
						awins = awins + 1
					End If
					'bwins
					Exit Select

					'check twopair
				Case (A("sets")(2) > 0 AndAlso A("sets")(3) > 0) OrElse _
					(B("sets")(2) > 0 AndAlso B("sets")(3) > 0)

					Select Case True
						Case A("sets")(3) = -1
							Exit Select
						Case B("sets")(3) = -1
							awins = awins + 1
						Case A("sets")(2) = B("sets")(2) AndAlso _
							A("sets")(3) = B("sets")(3)
							awins = awins + HighCard(A("card count"), B("card count"))
						Case A("sets")(2) = B("sets")(2) AndAlso _
							A("sets")(3) > B("sets")(3)
							awins = awins + 1
						Case A("sets")(2) = B("sets")(2) AndAlso _
							A("sets")(3) < B("sets")(3)
							Exit Select
						Case A("sets")(2) > B("sets")(2)
							awins = awins + 1
					End Select

					'bwins
					Exit Select

					'check pair
				Case A("sets")(2) > 0 OrElse B("sets")(2) > 0

					If A("sets")(2) = B("sets")(2) Then
						awins = awins + HighCard(A("card count"), B("card count"))
					ElseIf A("sets")(2) > B("sets")(2) Then
						awins = awins + 1
					End If
					'bwins
					Exit Select

				Case True
					awins = awins + HighCard(A("card count"), B("card count"))
			End Select

			fline = f.ReadLine()
			line = line + 1
		End While
		Console.WriteLine("player a won {0} hands", awins)
	End Sub

	Public Function CardCount(ByVal clst As List(Of String))
		Dim cards = New List(Of Integer) From {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}

		For Each c In clst
			cards(CardDic.IndexOf(c.Substring(0, 1))) = cards(CardDic.IndexOf(c.Substring(0, 1))) + 1
		Next
		Return cards
	End Function
	Public Function SuitCount(ByVal clst As List(Of String)) As List(Of Integer)
		Dim suits As New List(Of Integer) From {0, 0, 0, 0}

		For Each c In clst
			suits(SuitDic.IndexOf(c.Substring(1, 1))) = suits(SuitDic.IndexOf(c.Substring(1, 1))) + 1
		Next
		Return suits
	End Function
	Public Function HighCard(ByVal ACardCount As List(Of Integer), _
													 ByVal BCardCount As List(Of Integer)) As Integer
		For i = CardDic.Count() - 1 To 0 Step -1
			If ACardCount(i) > BCardCount(i) Then
				Return 1
			ElseIf ACardCount(i) < BCardCount(i) Then
				Return 0
			End If
		Next

		Return 0 'apparently its a tie
	End Function
End Class

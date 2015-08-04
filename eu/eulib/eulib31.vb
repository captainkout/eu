
Public Class eulib31
	Dim pcoin As New List(Of Integer) From {1, 2, 5, 10, 20, 50, 100, 200} 'possible coins
	Dim combinations As New List(Of Integer)	'combinations for given i

	Public Sub Main()

		For x = 0 To 200
			If x = 0 Then
				combinations.Add(1)
			Else
				combinations.Add(0)
			End If
		Next
		For Each coin In pcoin
			For i = coin To 200
				combinations(i) = combinations(i) + combinations(i - coin)
			Next
		Next
		For i = 0 To combinations.Count() - 1
			Console.WriteLine("i:{0}   comb:{1}", i, combinations(i))
		Next

	End Sub
End Class

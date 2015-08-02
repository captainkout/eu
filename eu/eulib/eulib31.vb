Public Class eulib31
	Dim pcoin As New List(Of Integer) From {5, 2, 1} 'possible coins
	Dim start As New Dictionary(Of Integer, Integer)
	Dim combinations As New Dictionary(Of Integer, List(Of Dictionary(Of Integer, Integer))) 'all possible dcoins

	Public Sub Main()
		start.Add(5, 1)
		start.Add(2, 0)
		start.Add(1, 0)

		Dim dcoin As New Dictionary(Of Integer, Integer)
		init_dcoin(dcoin)

		getCombs(start, 5)

	End Sub
	Public Sub init_dcoin(ByRef dic As Dictionary(Of Integer, Integer))

		For i = 0 To pcoin.Count() - 1
			dic.Add(pcoin(i), 0)
		Next

	End Sub
	Public Sub getCombs(ByRef dic As Dictionary(Of Integer, Integer), _
											ByVal total As Integer)
		Dim newdic As New Dictionary(Of Integer, Integer)

		If combinations.Item(total).Contains(dic) Then
			'add the coin to all the combinations and add to combinations
			For Each item In combinations.Item(total)
				'newdic =
				'newdic() = newdic() + 1
				combinations.Item(total).Add(newdic)
			Next
		End If


	End Sub
End Class

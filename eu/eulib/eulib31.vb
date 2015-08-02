Public Class eulib31
	Dim pcoin As New List(Of Integer) From {1, 2, 5} 'possible coins
	'Dim dcoin As New Dictionary(Of Integer, Integer)
	Dim start As New List(Of Integer) 'list of all ones
	Dim combinations As New List(Of Dictionary(Of Integer, Integer)) 'all possible dcoins

	Public Sub Main()
		'init_dcoin(dcoin)

		'initiate start arr
		For i = 1 To 5
			start.Add(1)
		Next

		Dim dcoin As New Dictionary(Of Integer, Integer)
		init_dcoin(dcoin)

		getCombs(start, dcoin)

	End Sub
	Public Sub init_dcoin(ByRef dic As Dictionary(Of Integer, Integer))

		For i = 0 To pcoin.Count() - 1
			dic.Add(pcoin(i), 0)
		Next

	End Sub
	Public Sub getCombs(ByRef lst As List(Of Integer), _
											ByRef dcoin2 As Dictionary(Of Integer, Integer))


		Dim newlst As New List(Of Integer)

		For i = 0 To lst.Count - 1
			Dim coin As Integer = lst(i)

			If coin > lst.Count - 1 Then
				'find combinations for everything after taking out "key" 1's and regress the list that left over
				dcoin2(coin) = dcoin2(coin) + 1
				newlst = lst.GetRange(lst.Count - 1 - coin, coin)
				getCombs(newlst, dcoin2)
			End If
		Next


	End Sub
End Class

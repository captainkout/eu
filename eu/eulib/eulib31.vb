Public Class eulib31
	Dim pcoin As New List(Of Integer) From {1, 2, 5} 'possible coins
	Dim start As New List(Of Integer) 'list of all ones
	Dim combinations As New Dictionary(Of Integer, List(Of Dictionary(Of Integer, Integer))) 'all possible dcoins

	Public Sub Main()
		'init_dcoin(dcoin)

		'initiate start arr
		For i = 1 To 5
			start.Add(1)
		Next

		Dim dcoin As New Dictionary(Of Integer, Integer)
		init_dcoin(dcoin)

		getCombs(start, dcoin, False)

	End Sub
	Public Sub init_dcoin(ByRef dic As Dictionary(Of Integer, Integer))

		For i = 0 To pcoin.Count() - 1
			dic.Add(pcoin(i), 0)
		Next

	End Sub
	Public Sub getCombs()


		getCombs()

	End Sub
End Class

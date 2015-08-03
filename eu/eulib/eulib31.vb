Public Class eulib31
	Dim pcoin As New List(Of Integer) From {1, 2, 5} 'possible coins
	Dim start As New Dictionary(Of Integer, Integer)
	Dim combinations As New Dictionary(Of Integer, List(Of Dictionary(Of Integer, Integer))) 'all possible dcoins

	Public Sub Main()
		'add the zero case to combinations
		Dim tmpList_zero As New List(Of Dictionary(Of Integer, Integer))
		Dim tmpDic_zero As New Dictionary(Of Integer, Integer)
		init_dic(tmpDic_zero)
		tmpList_zero.Add(tmpDic_zero)

		combinations.Add(0, tmpList_zero)		'this is the base case


		For i = 1 To 5

			Dim tmpList As New List(Of Dictionary(Of Integer, Integer))
			For Each coin In pcoin
				If coin = 1 Then
					'get all combinations and add a 1 to it
					For Each comb In combinations.Item(i - 1)
						'add 1's
						Dim tmpdic As New Dictionary(Of Integer, Integer)
						For Each coin2 In pcoin
							tmpdic(coin2) = comb(coin2)
						Next
						tmpdic(1) = tmpdic(1) + 1

						tmpList.Add(tmpdic)
					Next

				ElseIf coin <= i Then
					'get all combinations for total-coin with zero 1's
					For Each comb In combinations.Item(i - coin)
						If comb(1) = 0 Then
							'add coin to it
							Dim tmpdic As New Dictionary(Of Integer, Integer)
							For Each coin2 In pcoin
								tmpdic(coin2) = comb(coin2)
							Next
							tmpdic(coin) = tmpdic(coin) + 1

							tmpList.Add(tmpdic)
						End If
					Next

				End If
			Next
			combinations.Add(i, tmpList)
		Next


	End Sub
	Public Sub init_dic(ByRef dic As Dictionary(Of Integer, Integer))

		For i = 0 To pcoin.Count() - 1
			dic.Add(pcoin(i), 0)
		Next

	End Sub
End Class

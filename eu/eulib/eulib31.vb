Public Class eulib31
	Dim pcoin As New List(Of Integer) From {1, 2, 5, 10, 20, 50, 100, 200} 'possible coins
	Dim start As New Dictionary(Of Integer, Integer)
	Dim combinations As New Dictionary(Of Integer, List(Of Dictionary(Of Integer, Integer))) 'all possible dcoins

	Public Sub Main()
		'add the zero case to combinations
		Dim tmpList_zero As New List(Of Dictionary(Of Integer, Integer))
		Dim tmpDic_zero As New Dictionary(Of Integer, Integer)
		init_dic(tmpDic_zero)
		tmpList_zero.Add(tmpDic_zero)

		combinations.Add(0, tmpList_zero)		'this is the base case


		For i = 1 To 9

			Dim tmpList As New List(Of Dictionary(Of Integer, Integer))
			Dim j = 0
			While i >= pcoin(j)

				If pcoin(j) = 1 Then
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

				ElseIf pcoin(j) = 2 Then
					'get all combinations for total-coin with zero 1's
					For Each comb In combinations.Item(i - pcoin(j))
						If comb(1) = 0 Then
							'add coin to it
							Dim tmpdic As New Dictionary(Of Integer, Integer)
							For Each coin2 In pcoin
								tmpdic(coin2) = comb(coin2)
							Next
							tmpdic(pcoin(j)) = tmpdic(pcoin(j)) + 1

							tmpList.Add(tmpdic)
						End If
					Next
				ElseIf pcoin(j) = 5 Then
					For Each comb In combinations.Item(i - pcoin(j))
						If comb(1) = 0 AndAlso comb(2) = 0 Then
							'add coin to it
							Dim tmpdic As New Dictionary(Of Integer, Integer)
							For Each coin2 In pcoin
								tmpdic(coin2) = comb(coin2)
							Next
							tmpdic(pcoin(j)) = tmpdic(pcoin(j)) + 1

							tmpList.Add(tmpdic)
						End If
					Next
				End If
				j = j + 1
			End While
			combinations.Add(i, tmpList)
			Console.WriteLine("item:{0}   combinations:{1}", i, combinations.Item(i).Count())
		Next

		For Each c In combinations.Item(7)
			Console.WriteLine("1:{0}   2:{1}   5:{2}", c.Item(1), c.Item(2), c.Item(5))
		Next

	End Sub
	Public Sub init_dic(ByRef dic As Dictionary(Of Integer, Integer))

		For i = 0 To pcoin.Count() - 1
			dic.Add(pcoin(i), 0)
		Next

	End Sub
End Class

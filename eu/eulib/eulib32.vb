Public Class eulib32

	Public Sub Main()

		'Dim pool As New List(Of Integer) From {1, 2, 3, 4, 5, 6, 7, 8, 9}
		Dim finals As New List(Of Integer)

		Dim a As New List(Of Integer) From {1, 0, 0, 0}
		For adigits = 0 To 3

			Dim local_pool As New List(Of Integer)
			For i = 1 To 9
				local_pool.Add(i)
			Next
			Dim alpha As Integer = 0
			For i = 0 To adigits
				alpha = alpha + local_pool(a(i)) * 10 ^ i
				local_pool.Remove(local_pool(a(i)))



				'This next section needs work. It doesn't increment correctly.




				'if finished all digits and a(final digit) is maxed out
				'if its a single digit it should max at 9
				If i = adigits AndAlso a(i) = local_pool.Max() Then
					a(i + 1) = a(i + 1) + 1
					a(i) = 0
					'if done forming a then increment a(i)
					'so after min+1 it will get min+2 next time
				ElseIf i = adigits Then
					a(i) = a(i) + 1
				End If
			Next

			Dim b As New List(Of Integer) From {0, 0, 0, 0, 0}
			Dim beta As Integer = 0
			Dim bdigits As Integer = 0

			While bdigits <= 3 - adigits

				For i = 0 To bdigits
					beta = beta + local_pool(b(i)) * 10 ^ i
					local_pool.Remove(local_pool(b(i)))

					If i = bdigits AndAlso b(i) = local_pool.Max() Then
						bdigits = bdigits + 1
						b(i + 1) = b(i + 1) + 1
						b(i) = 0
					ElseIf i = bdigits Then
						b(i) = b(i) + 1
					End If
				Next

				'final test
				Dim c As Integer = alpha * beta
				Dim test As Boolean = False
				If c.ToString().Length() = local_pool.Count() Then
					For Each num In c.ToString()
						'check if its unique and 'check if its been used
						If c.ToString().IndexOf(num) = c.ToString().LastIndexOf(num) _
							AndAlso local_pool.Contains(Val(num)) Then
							test = True
						Else
							Exit For
						End If
					Next
					If test = True Then
						finals.Add(alpha * beta)
					End If
				End If
			End While

		Next
	End Sub
	Public Function Evaluate(ByVal a As Integer, _
													 ByVal b As Integer, _
													 ByRef local_pool As List(Of Integer))

		Dim c As Integer = a * b

		Dim test As Boolean = False
		If c.ToString().Length() = local_pool.Count() Then
			For Each num In c.ToString()
				'check if its unique
				If c.ToString().IndexOf(num) = c.ToString().LastIndexOf(num) _
					AndAlso local_pool.Contains(Val(num)) Then 'check if its been used
					test = True
				End If
			Next
		End If
		Return test

	End Function
	Public Function chk_arr(arr, bdigits)


		Return True
	End Function
End Class

Public Class eulib49
	Public Sub Main()
		Dim p As New Primes
		Dim parr As BitArray
		parr = p.sieve(10000)

		Dim step1 As New List(Of Integer)
		For i = 1000 To 10000
			If parr(i) = True Then
				step1.Add(i)
			End If
		Next

		For i = 1 To 5000
			For j = 0 To step1.Count() - 1
				Dim valid As Boolean = True
				If step1.Contains(step1(j) + i) AndAlso step1.Contains(step1(j) + 2 * i) Then

					Dim one(9) As Integer, two(9) As Integer, three(9) As Integer
					For Each dig In step1(j).ToString()
						one(Val(dig)) = one(Val(dig)) + 1
					Next
					For Each dig In (step1(j) + i).ToString()
						two(Val(dig)) = two(Val(dig)) + 1
					Next
					For Each dig In (step1(j) + 2 * i).ToString()
						three(Val(dig)) = three(Val(dig)) + 1
					Next

					For k = 0 To 9
						If one(k) <> two(k) OrElse one(k) <> three(k) Then
							valid = False
							Exit For
						End If
					Next
					If valid = True Then
						Console.WriteLine("step by:{0}   step1:{1}   step2:{2}   step3:{3}", i, step1(j), step1(j) + i, step1(j) + 2 * i)
					End If
				End If

			Next
		Next

	End Sub
End Class

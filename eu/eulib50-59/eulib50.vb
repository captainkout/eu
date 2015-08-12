Imports helper
Public Class eulib50
	Public Sub Main()

		Dim p As New Primes
		Dim parr As BitArray
		parr = p.sieve(1000000)

		Dim plst As New List(Of Integer)
		For i = 0 To 1000000
			If parr(i) = True Then
				plst.Add(i)
			End If
		Next

		Dim examples(2) As Integer

		For i = 0 To plst.Count() - 1
			'find max length from start
			Dim cnt As Integer = 0
			Dim sum As Integer = 0
			'Dim h As Integer = i
			While cnt + i <= plst.Count() - 1 AndAlso plst(cnt + i) + sum < 1000000
				sum = sum + plst(cnt + i)
				cnt = cnt + 1
				If parr(sum) = True AndAlso cnt > examples(2) Then
					examples(0) = i
					examples(1) = sum
					examples(2) = cnt
					'Console.WriteLine("start:{0}   end:{1}   length:{2}", i, sum, cnt)
				End If
			End While
		Next
	End Sub
End Class

Public Class eulib43
	Public Sub Main()
		Dim possible_digits = "0123456789"
		Dim digits_max_minus As New List(Of Integer) From {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
		Dim primes As New List(Of Integer) From {2, 3, 5, 7, 11, 13, 17}
		Dim sum As Double = 0

		While digits_max_minus(0) < 10 'finish criteria
			Dim tmpcomplete As String = possible_digits	'reset string
			Dim numstr As String = ""
			For i = 0 To 9
				Dim position As Integer = tmpcomplete.Length() - 1 - digits_max_minus(i)
				numstr = numstr & tmpcomplete(position)
				tmpcomplete = tmpcomplete.Substring(0, position) & tmpcomplete.Substring(position + 1)
			Next
			Dim numslice As Integer
			If numstr = "1406357289" Then	'check example from question
				Console.WriteLine("verify example: {0}", numstr)
			End If
			For i = 0 To 6 'verify criteria
				numslice = Val(numstr.Substring(i + 1, 3))
				If Not Val(numslice) Mod primes(i) = 0 Then
					Exit For
				End If
				If i = 6 Then
					sum = sum + Val(numstr)
				End If
			Next
			digits_max_minus(digits_max_minus.Count() - 1) = 1	'increment digit
			For i = 9 To 0 Step -1
				If digits_max_minus(i) > 9 - i AndAlso i > 0 Then
					digits_max_minus(i) = 0
					digits_max_minus(i - 1) = digits_max_minus(i - 1) + 1
				ElseIf digits_max_minus(i) > 9 - 1 AndAlso i = 0 Then
					digits_max_minus(i) = 10
				End If
			Next
		End While
		Console.WriteLine("sum of pandigital specials = {0}", sum)

	End Sub
End Class

Public Class permuations
	Public Function perm()
		Dim possible_digits = "0123456789"
		Dim digits_max_minus As New List(Of Integer) From {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


		digits_max_minus(digits_max_minus.Count() - 1) = 1	'increment digit
		For i = 9 To 0 Step -1
			If digits_max_minus(i) > 9 - i AndAlso i > 0 Then
				digits_max_minus(i) = 0
				digits_max_minus(i - 1) = digits_max_minus(i - 1) + 1
			ElseIf digits_max_minus(i) > 9 - 1 AndAlso i = 0 Then
				digits_max_minus(i) = 10
			End If
		Next
		Return digits_max_minus
	End Function

	Public Function count_dig(ByVal num As Integer)
		Dim darr(9) As Integer
		For Each dig In num.ToString()
			darr(Val(dig)) = darr(Val(dig)) + 1
		Next

		Return darr
	End Function
End Class

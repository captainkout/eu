Public Class permuations
	Public Function perm(ByRef possible_digits As Array, _
											 ByVal length As Integer)
		If length < possible_digits.GetUpperBound(0) Then
			Throw New Exception("not enough posssibilities, digits:" & possible_digits.GetUpperBound(0) & "  length:" & length)
		End If

		Dim local_poss As New List(Of Object)
		For a = 0 To possible_digits.GetUpperBound(0)
			local_poss.Add(possible_digits(a))
		Next
		'Dim possible_digits As New List(Of Object) From {0, 1, 2, 3, 4, 5}
		Dim digits_max_minus As New List(Of Integer)
		For a = 0 To length - 1
			digits_max_minus.Add(0)
		Next

		Dim return_list As New List(Of Object)
		While digits_max_minus(0) < local_poss.Count()
			Dim tmp1 As New List(Of Object)
			tmp1 = local_poss.GetRange(0, local_poss.Count())

			Dim tmp2 As New List(Of Integer)
			For a = 0 To digits_max_minus.Count() - 1
				tmp2.Add(tmp1(tmp1.Count() - 1 - digits_max_minus(a)))
				tmp1.Remove((tmp1(tmp1.Count() - 1 - digits_max_minus(a))))
			Next

			digits_max_minus(digits_max_minus.Count() - 1) = digits_max_minus(digits_max_minus.Count() - 1) + 1
			'increment digit
			For i = digits_max_minus.Count() - 1 To 0 Step -1
				If digits_max_minus(i) > local_poss.Count() - 1 - i AndAlso i > 0 Then
					digits_max_minus(i) = 0
					digits_max_minus(i - 1) = digits_max_minus(i - 1) + 1
				ElseIf digits_max_minus(i) > local_poss.Count() - 1 - i AndAlso i = 0 Then
					digits_max_minus(i) = local_poss.Count()
				End If
			Next
			return_list.Add(tmp2)
		End While
		Return return_list
	End Function

	Public Function count_dig(ByVal num As Long)
		Dim darr(9) As Integer
		For Each dig In num.ToString()
			darr(Val(dig)) = darr(Val(dig)) + 1
		Next

		Return darr
	End Function
End Class

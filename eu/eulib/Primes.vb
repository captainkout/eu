Public Class Primes
	Public primes As New List(Of Integer) From {2}
	Public Sub To_Max(ByVal max As Integer)
		If primes.Max() > max Then
			'all good
		Else
			For i = primes.Max() + 1 To max
				chk_prime(i)
			Next
		End If
	End Sub
	Public Sub To_Ith(ByVal ith As Integer)

		If primes.Count > ith Then
			'all good
		Else
			Dim i = 3
			While primes.Count <= ith
				chk_prime(i)
				i = i + 1
			End While
		End If

	End Sub
	Public Sub Next_Prime()

		Dim done As Boolean = False
		Dim current_max As Integer = primes.Max()

		While done = False
			current_max = current_max + 1
			done = chk_prime(current_max)
		End While

	End Sub

	Private Function chk_prime(ByVal num As Integer)
		If primes.Contains(num) Then
			Return True
		End If
		Dim i = 0
		While i < primes.Count() - 1 AndAlso i <= Math.Floor(Math.Sqrt(num))
			If num Mod primes(i) = 0 Then
				Return False
			End If
			i = i + 1
		End While
		primes.Add(num)
		Return True

	End Function
End Class

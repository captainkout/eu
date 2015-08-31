Public Class phi
	Public Function phi_to(ByVal max As Long)
		Dim m As Integer = max
		Dim p As New helper.Primes
		Dim parr As BitArray = p.sieve(m)

		Dim rparr(m) As Double
		For a = 2 To m
			rparr(a) = a
		Next

		For a = 2 To parr.Count() - 1
			If parr(a) = True Then
				For b = a To parr.Count() - 1 Step a
					rparr(b) = rparr(b) * (a - 1) / a
				Next
			End If
		Next

		Return rparr
	End Function

End Class

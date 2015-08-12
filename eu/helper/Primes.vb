Public Class Primes

	Public Function sieve(ByVal max As Integer)
		'Primes.Clear()
		Dim bitarr As New BitArray(max + 1, True)

		bitarr(0) = False
		bitarr(1) = False
		bitarr(2) = True


		For i = 2 To Math.Ceiling(Math.Sqrt(max + 1))
			If bitarr(i) = True Then
				For j = i * 2 To max Step i
					bitarr(j) = False
				Next
			End If
		Next

		Return bitarr

	End Function
End Class

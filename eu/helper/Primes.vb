Public Class Primes

	Public Function sieve(ByVal max As Long) As BitArray
		'Primes.Clear()
		Dim bitarr As New BitArray(max + 1, True)

		bitarr(0) = False
		bitarr(1) = False
		bitarr(2) = True

		For i = 2 To Math.Ceiling(Math.Sqrt(max + 1))
			If bitarr(i) = True Then
				For j = i * i To max Step i
					bitarr(j) = False
				Next
			End If
		Next

		Return bitarr
	End Function

	Public Function sieve_lst(ByVal Max As Long) As List(Of Long)
		Dim bitarr As New BitArray(Math.Floor(Max / 2) + 1, True)
		bitarr(0) = False

		Dim plist As New List(Of Long)
		plist.Add(2)

		For i = 1 To bitarr.Count() - 1
			If bitarr(i) = True Then
				plist.Add(2 * i + 1)
				For j = i + 2 * i + 1 To bitarr.Count() - 1 Step 2 * i + 1
					bitarr(j) = False
				Next
			End If
		Next
		Return plist
	End Function
End Class

Public Class eulib77
	Public Sub Main()
		Dim max As Long = 1000
		Dim h As New helper.Primes
		Dim plist As New List(Of Long)
		plist = h.sieve_lst(max)
		Dim arr(max + 1) As Long

		For Each p In plist
			For a = p To arr.GetUpperBound(0)
				If a - p = 0 Then
					arr(a) = arr(a) + 1
				Else
					arr(a) = arr(a) + arr(a - p)
				End If
			Next
		Next
		For a = 0 To arr.GetUpperBound(0)
			If arr(a) >= 5000 Then
				Console.WriteLine(a)
				Exit Sub
			End If
		Next
	End Sub
End Class

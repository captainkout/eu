Imports helper.permuations
Public Class eulib70
	Public Sub Main()
		Dim m As Integer = 10000000
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

		Dim lstdigits As New Dictionary(Of Integer, Double)
		Dim h As New helper.permuations
		For a = 2 To rparr.Count() - 1
			If a.ToString().Length() = rparr(a).ToString().Length() AndAlso _
				h.count_dig_tostr(a) = h.count_dig_tostr(rparr(a)) Then
				lstdigits.Add(a, a / rparr(a))
			End If
		Next

		Dim dmin As Double = 0
		Dim sol As Integer = 0
		For Each key In lstdigits.Keys()
			If lstdigits(key) < dmin OrElse dmin = 0 Then
				dmin = lstdigits(key)
				sol = key
			End If
		Next

		Console.WriteLine(sol)
	End Sub
End Class

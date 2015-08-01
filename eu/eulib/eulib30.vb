Public Class eulib30
	Public Sub Main()
		'For i = 1 To 10
		'	Console.WriteLine("digits = {0}: {1} {2} {3} {4} {5} {6} {7} {8} {9}", i, i * 1 ^ 5, i * 2 ^ 5, i * 3 ^ 5, i * 4 ^ 5, i * 5 ^ 5, i * 6 ^ 5, i * 7 ^ 5, i * 8 ^ 5, i * 9 ^ 4)
		'Next

		Dim tots As Integer = 0
		For i As Integer = 10 To 6 * 9 ^ 5

			Dim dsum As Integer = 0
			Dim istr As String = i.ToString()
			For j = 0 To istr.Length() - 1
				dsum = dsum + (Val(istr(j)) ^ 5)

			Next

			If dsum = i Then
				Console.WriteLine("wooo found one {0}", i)
				tots = tots + i
			End If
		Next
		Console.WriteLine("tots is {0}", tots)
	End Sub
End Class

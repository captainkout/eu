Public Class eulib30
	Public Sub Main()

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

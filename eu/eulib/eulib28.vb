Public Class eulib28
	Public Sub Main()
		Dim sum As Long = 1
		Dim i As Integer = 1
		While ((2 * i + 1) ^ 2) <= 1001 ^ 2
			sum = sum + ((2 * i + 1) ^ 2) + ((2 * i + 1) ^ 2 - 2 * i) + ((2 * i + 1) ^ 2 - 4 * i) + ((2 * i + 1) ^ 2 - 6 * i)
			i = i + 1
		End While
		Console.WriteLine("sum up to {0}x{1} is {2}", 1001, 1001, sum)
	End Sub
End Class

Imports System.Numerics
Public Class eulib57
	Public Sub Main()
		Dim top(1000) As BigInteger
		Dim bottom(1000) As BigInteger

		top(0) = 3
		top(1) = 7
		bottom(0) = 2
		bottom(1) = 5
		Dim tot As Integer = 0

		For i = 2 To 1000
			bottom(i) = top(i - 1) + bottom(i - 1)
			top(i) = 2 * top(i - 1) + top(i - 2)

			If top(i).ToString().Length() > bottom(i).ToString().Length() Then
				tot = tot + 1
			End If
		Next

		Console.WriteLine("more top dig than bot in 1k expansions {0}", tot)

	End Sub
End Class

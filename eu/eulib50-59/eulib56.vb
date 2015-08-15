Imports System.Numerics
Public Class eulib56
	Public Sub Main()
		Dim max As Double = 0
		For a As Integer = 10 To 100
			For b As Integer = 23 To 100
				Dim big As BigInteger = 1
				For i = 1 To b
					big = big * a
				Next
				Dim dsum As Double = 0
				For Each dig In big.ToString()
					dsum = dsum + Val(dig)
				Next
				If dsum > max Then
					max = dsum
				End If
			Next
		Next
		Console.WriteLine("highest digit sum all a^b a,b<100 is {0}", max)
	End Sub
End Class

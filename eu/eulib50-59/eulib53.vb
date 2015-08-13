Imports System.Numerics
Public Class eulib53
	Dim fdic As New Dictionary(Of Integer, Double)
	Public Sub Main()
		Dim count As Integer = 0
		For n = 1 To 100
			For r As Integer = 1 To n - 1
				If fac(n) / (fac(r) * fac(n - r)) > 1000000 Then
					count = count + 1
				End If
			Next
		Next
		Console.WriteLine("there are values nCr for 1<=n<=100 : {0}", count)
	End Sub
	Public Function fac(ByVal num As Integer)
		If fdic.ContainsKey(num) Then
			Return fdic(num)
		End If

		Dim fnum As Double = 1
		For i = 2 To num
			fnum = fnum * i
		Next
		Return fnum
	End Function
End Class

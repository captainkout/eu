Imports System.Numerics
Public Class eulib55
	Public Sub Main()
		Dim tot As Integer = 0
		For i As Integer = 0 To 10000
			Dim newi As BigInteger = i
			Dim count = 0
			Do
				newi = newi + Reverse(newi.ToString())
				count = count + 1
			Loop While IsPal(newi) = False AndAlso count < 50
			If count >= 50 Then
				tot = tot + 1
			End If
		Next
		Console.WriteLine("total lychrel number below 10k is {0}", tot)
	End Sub
	Public Function IsPal(ByVal num As BigInteger) As Boolean
		For i = 0 To Math.Floor((num.ToString().Length()) / 2)
			If num.ToString()(i) <> num.ToString()(num.ToString().Length() - 1 - i) Then
				Return False
			End If
		Next
		Return True
	End Function
	Public Function Reverse(ByVal str As String) As BigInteger
		Dim nlong As BigInteger = 0
		For i As Integer = 0 To str.Length() - 1
			nlong = nlong + Val(str(i)) * 10 ^ i
		Next

		Return nlong
	End Function
End Class

Imports System.Numerics

'bit shifting isn't any faster than dividing by two
'.net is smart like that
Public Class eulib80
	Public Sub Main()
		Dim big As New BigInteger
		Dim sum As Long = 0
		For a = 2 To 100
			If Math.Sqrt(a) = Math.Floor(Math.Sqrt(a)) Then Continue For
			big = a
			For b = 1 To 200
				big = big * 10
			Next
			Dim bigstr As String = SqrtN(big).ToString()
			For dig = 0 To 99
				sum = sum + Val(bigstr(dig))
			Next
		Next

		Console.WriteLine(sum)

	End Sub
	Public Sub Main2()
		Dim big As New BigInteger
		Dim sum As Long = 0
		For a = 2 To 100
			If Math.Sqrt(a) = Math.Floor(Math.Sqrt(a)) Then Continue For
			big = a
			For b = 1 To 200
				big = big * 10
			Next
			Dim bigstr As String = SqrtN2(big).ToString()
			For dig = 0 To 99
				sum = sum + Val(bigstr(dig))
			Next
		Next

		Console.WriteLine(sum)

	End Sub
	Public Function SqrtN(ByVal N As BigInteger) As BigInteger
		If (0 = N) Then Return 0
		Dim n1 As BigInteger = (N >> 1) + 1
		Dim n2 As BigInteger = (n1 + (N / n1)) >> 1
		While (n2 < n1)
			n1 = n2
			n2 = (n1 + (N / n1)) >> 1
		End While
		Return n1
	End Function
	Public Function SqrtN2(ByVal N As BigInteger) As BigInteger
		If (0 = N) Then Return 0
		Dim n1 As BigInteger = (N / 2) + 1
		Dim n2 As BigInteger = (n1 + (N / n1)) / 2
		While (n2 < n1)
			n1 = n2
			n2 = (n1 + (N / n1)) / 2
		End While
		Return n1
	End Function
End Class

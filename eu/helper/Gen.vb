Imports System.Numerics
Public Class Gen
	Public Function SqrtN(ByVal N As BigInteger) As BigInteger
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

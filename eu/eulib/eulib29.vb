Imports System.Numerics

Public Class eulib29
	Public Sub Main()
		Dim seq As New List(Of BigInteger)
		For a = 2 To 100
			For b = 2 To 100
				Dim bi As New BigInteger
				bi = a ^ b
				If Not seq.Contains(bi) Then
					seq.Add(bi)
				End If
			Next
		Next
		Console.WriteLine(seq.Count())
	End Sub
End Class

Imports System.Numerics
Imports System.Math
Public Class eulib33
	Public Sub Main()
		Dim examples As New List(Of Tuple(Of Integer, Integer, Double))
		For top = 10 To 99
			If top Mod 11 = 0 Or top Mod 10 = 0 Then
				Continue For
			End If

			For bot = 10 To 99
				If bot Mod 11 = 0 OrElse top Mod 10 = 0 Then
					Continue For
				End If

				Dim TistBsec As Double = (Math.Floor(top / 10)) / (bot Mod 10)

				If TistBsec = top / bot AndAlso top Mod 10 = Math.Floor(bot / 10) Then
					examples.Add(New Tuple(Of Integer, Integer, Double)(top, bot, top / bot))
				End If

			Next
		Next
		Dim topprod As Integer = 1
		Dim botprod As Integer = 1

		For Each item In examples
			topprod = topprod * item.Item1()
			botprod = botprod * item.Item2()
		Next
		Console.WriteLine("topprod: {0}   botprod: {1}", topprod, botprod)
		Console.WriteLine("reduced with pen and paper to 1/100")

		Dim gcd As New Numerics.BigInteger
		gcd = Numerics.BigInteger.GreatestCommonDivisor(topprod, botprod)
		Console.WriteLine("or using Numerics Library  {0} /  {1}", topprod / gcd, botprod / gcd)

	End Sub
End Class

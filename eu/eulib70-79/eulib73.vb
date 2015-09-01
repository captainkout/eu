Imports System.Numerics

Public Class eulib73
	Public Sub Main()
		'Dim big As New BigInteger
		Dim max = 12000
		Dim h As New helper.Primes
		Dim plist As New List(Of Long)
		plist = h.sieve_lst(max)
		'plist.Insert(0, 1)
		Dim tot As Integer = 0

		For a = 2 To max
			For b = Math.Floor(a / 3) To Math.Ceiling(a / 2)
				If b / a > 1 / 3 AndAlso b / a < 1 / 2 AndAlso BigInteger.GreatestCommonDivisor(a, b) = 1 Then
					tot = tot + 1
				End If
			Next
		Next

		Console.WriteLine(tot)
	End Sub
End Class

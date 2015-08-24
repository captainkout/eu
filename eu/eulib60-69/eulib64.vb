Imports System.Numerics.BigInteger
Public Class eulib64
	Public Sub Main()
		Dim gcd As New Numerics.BigInteger
		Dim odds As Integer = 0

		For root = 2 To 10000
			'remove squares
			If Math.Floor(Math.Sqrt(root)) = Math.Ceiling(Math.Sqrt(root)) Then
				Continue For
			End If

			Dim whole As Integer = Math.Floor(Math.Sqrt(root))
			Dim plus As Integer = -1 * whole

			Dim examples As New List(Of String)
			Dim ret As New List(Of Integer) From {whole, root, 1, plus, 1}
			Dim retstr As String = strify(ret)
			While Not examples.Contains(retstr)
				examples.Add(retstr)

				ret(0) = whole
				ret(1) = root
				ret(2) = ret(4)
				ret(3) = -1 * plus
				ret(4) = root - plus ^ 2

				gcd = Numerics.BigInteger.GreatestCommonDivisor(ret(2), ret(4))
				ret(2) = ret(2) / gcd
				ret(4) = ret(4) / gcd

				whole = Math.Floor((Math.Sqrt(root) + ret(3)) / ret(4))

				plus = ret(3) - ret(4) * whole
				retstr = strify(ret)
			End While

			If (examples.Count() - examples.IndexOf(retstr)) Mod 2 = 1 Then
				odds = odds + 1
			End If
		Next
		Console.WriteLine("number of odd period : {0}", odds)
	End Sub
	Public Function strify(ByRef lst As List(Of Integer))
		Dim retstr As String = lst(0)
		For a = 1 To lst.Count() - 1
			retstr = retstr & "," & lst(a)
		Next
		Return retstr
	End Function
End Class

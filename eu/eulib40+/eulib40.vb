Public Class eulib40
	Public Sub Main()
		Dim numstr As New System.Text.StringBuilder("")

		Dim i As Integer = 0
		While numstr.Length() <= 1000000
			numstr.Append(CStr(i))
			i = i + 1
		End While
		Dim tot As System.Numerics.BigInteger = 1
		For i = 0 To 6
			tot = tot * Val(numstr(10 ^ i))
		Next
		Console.WriteLine("tot is {0}", tot)
	End Sub
End Class

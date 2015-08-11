Public Class eulib48
	Public Sub Main()
		Dim a As Long = 0

		For i = 1 To 1000
			Dim b As Long = 1
			For j = 1 To i
				b = b * i
				Dim len As Integer = b.ToString().Length()
				b = Val(b.ToString().Substring(len - Math.Min(15, len)))
			Next
			a = a + b
		Next
		Console.WriteLine("digits: {0}", a.ToString().Substring(a.ToString.Length() - 10))
	End Sub
End Class

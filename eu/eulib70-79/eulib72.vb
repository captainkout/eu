Public Class eulib72
	Public Sub Main()
		Dim max As Integer = 1000000
		Dim h As New helper.phi
		Dim phiarr() As Double = h.phi_to(max)

		Dim fincnt As Long = 0
		For a = 2 To phiarr.Count() - 1
			fincnt = fincnt + phiarr(a)
		Next

		Console.WriteLine(fincnt)
	End Sub
End Class

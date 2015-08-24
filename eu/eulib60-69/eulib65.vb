Imports System.Math

Public Class eulib65
	Public Sub Main()
		Dim a As Integer = Math.Floor(Math.E)
		Console.WriteLine(Math.Floor((Math.E + 2) / (Math.E ^ 2 - 4)))
		Console.WriteLine(Math.Floor((3 - Math.E) / (Math.E - 2)))
	End Sub
End Class

Imports System.Numerics
Public Class eulib31b
	Dim pcoin As New List(Of Integer) From {1, 2, 5, 10, 20, 50, 100, 200} 'possible coins
	Dim start As New Dictionary(Of Integer, Integer)
	Dim combinations As New Dictionary(Of Integer, List(Of Integer))	'combinations for given i

	Public Sub Main()
		'add the zero case to combinations
		'combinations.Add(0, New List(Of Integer) From {1})	'this is the base case
		Dim justcount As Integer = 0
		Dim i As Integer = 1
		While justcount <= 200
			pcoin(i)
			justcount = justcount + 1
		End While
	End Sub
End Class

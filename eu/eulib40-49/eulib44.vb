Public Class eulib44
	Public Sub Main()
		Dim pentagons As New List(Of Integer)
		'Dim examples As New List(Of Tuple(Of Integer, Integer, Integer))
		Dim j As Integer = 0

		While True
			j = j + 1
			Dim pj As Integer = (3 * j * j - j) / 2
			pentagons.Add(pj)
			For i = 0 To pentagons.Count() - 1
				If chk_sum(pj - pentagons(i)) AndAlso chk_sum(pj + pentagons(i)) Then
					Console.WriteLine(pj - pentagons(i))
					Console.ReadKey()
				End If
			Next

		End While
	End Sub
	Public Function chk_sum(ByVal num As Integer)
		Dim sum As Double = (Math.Sqrt(24 * (num) + 1) + 1) / 6
		If Math.Ceiling(sum) = sum Then
			Return True
		End If
		Return False

	End Function
End Class

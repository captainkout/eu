Public Class eulib39
	Public Sub Main()
		Dim psqrs As New List(Of Integer) From {0}
		Dim examples As New Dictionary(Of Integer, Integer)
		For a = 1 To 355
			For b = a To 2 * 355 - a
				Dim c = Math.Sqrt(a ^ 2 + b ^ 2)
				'While c > psqrs.Max()
				'	psqrs.Add(psqrs.Count() ^ 2)
				'End While
				If Integer.TryParse(c, c) Then
					Dim p As Integer = a + b + c
					If examples.ContainsKey(p) Then
						examples(p) = examples(p) + 1
					Else
						examples(p) = 1
					End If
				End If
			Next
		Next

		Dim max As Integer = 0
		For Each key In examples.Keys
			If examples(key) >= max OrElse key = 120 Then
				max = examples(key)
				Console.WriteLine("key:{0}   max:{1}", key, examples(key))
			End If
		Next

	End Sub
End Class

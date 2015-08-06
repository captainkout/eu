Public Class eulib38
	Public Sub Main()
		Dim examples As New List(Of Tuple(Of Integer, Integer))
		Dim i As Integer = 1
		While CStr(i).Length < 5
			Dim numstr As String = ""
			Dim j As Integer = 0
			While numstr.Length() < 9
				j = j + 1
				numstr = numstr & CStr(j * i)
			End While
			If j > 1 AndAlso numstr.Length() = 9 AndAlso numstr.Contains("0") = False Then
				Dim valid As Boolean = True
				For Each dig In numstr
					If numstr.IndexOf(dig) <> numstr.LastIndexOf(dig) Then
						valid = False
						Exit For
					End If
				Next
				If valid = True Then
					examples.Add(New Tuple(Of Integer, Integer)(i, numstr))
				End If
			End If
			i = i + 1
		End While
		Console.WriteLine("num: {0}   numstr: {1}", examples(examples.Count - 1).Item1(), examples(examples.Count - 1).Item2())
	End Sub
End Class

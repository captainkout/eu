Imports System.IO.File
Public Class eulib42
	Public Sub Main()
		Dim f As New System.IO.StreamReader("c:\\users\\chris\\downloads\\p042_words.txt")
		Dim farr As Array = f.ReadToEnd().Replace("""", "").Split(",")
		f.Close()

		Dim alphabet As String = "0abcdefghijklmnopqrstuvwxyz"
		Dim triangles As New List(Of Integer) From {0}
		Dim examples As New List(Of Tuple(Of String, Integer))

		For Each word As String In farr
			word.ToLower()
			Dim wtot As Integer = 0
			For Each letter As String In word
				wtot = wtot + alphabet.IndexOf(letter.ToLower())
			Next
			While wtot >= triangles.Count()
				triangles.Add(0.5 * triangles.Count() * (triangles.Count() + 1))
			End While
			If triangles.Contains(wtot) Then
				examples.Add(New Tuple(Of String, Integer)(word, wtot))
			End If
		Next
		Console.WriteLine("triangle words in p042_words.txt = {0}", examples.Count())
	End Sub
End Class

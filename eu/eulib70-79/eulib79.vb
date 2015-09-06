Public Class eulib79
	Public Sub Main()
		Dim f As New System.IO.StreamReader("c:\\users\\chris\\downloads\\p079_keylog.txt")
		Dim fstr As String = f.ReadToEnd()
		Dim farr() As String = fstr.Split(vbLf)
		f.Close()

		Dim l As New Dictionary(Of Char, List(Of Char))
		For a = 0 To 9
			If fstr.IndexOf(a.ToString()) > 0 Then
				Dim l2 As New List(Of Char)
				l(a.ToString()) = l2
			End If
		Next

		For Each item In farr
			If item.Length() = 0 Then Continue For
			If Not l(item(0)).Contains(item(1)) Then
				l(item(0)).Add(item(1))
			End If
			If Not l(item(0)).Contains(item(2)) Then
				l(item(0)).Add(item(2))
			End If
			If Not l(item(1)).Contains(item(2)) Then
				l(item(1)).Add(item(2))
			End If
		Next

		Dim final As String = ""
		Dim cnt As Integer = 0
		While cnt < l.Keys.Count()
			For Each key In l.Keys()
				If l(key).Count() = cnt Then
					final = key & final
					cnt = cnt + 1
					Exit For
				End If
			Next
		End While

		Console.WriteLine(final)
	End Sub
End Class

Imports System.IO
Imports System.Text
Public Class eulib59
	Public Sub Main()

		Dim f As New StreamReader("c:\\users\\chris\\downloads\\p059_cipher.txt")
		Dim s() As String = f.ReadToEnd.Split(",")
		Dim s2(s.GetUpperBound(0)) As String
		Dim bestcnt As Integer = s.Length()
		Dim bestarr(s.GetUpperBound(0)) As String
		Dim commonwords As New List(Of String) From {"the", "be", "to", "of", "and", "in", "that", "have", "I"}
		For a0 = 97 To 122
			For a1 = 97 To 122
				For a2 = 97 To 122
					For i = 0 To s.GetUpperBound(0)
						s2(i) = Convert.ToString(CInt(s(i)), 2)
						's2(i) = Convert.ToString(Asc(s(i)), 2)
					Next
					Dim k(2) As String
					k(0) = a0.ToString()
					k(1) = a1.ToString()
					k(2) = a2.ToString()
					For a = 0 To k.GetUpperBound(0)
						k(a) = Convert.ToString(CInt(k(a)), 2)
					Next

					encode(s2, k)
					Dim zstr As String = ""
					For a = 0 To s2.GetUpperBound(0)
						zstr = zstr + Chr(Convert.ToInt32(s2(a), 2))
					Next

					Dim result = analyze(zstr, commonwords)
					If result < bestcnt Then
						bestcnt = result
						bestarr = s2.Clone()
					End If
				Next
			Next
		Next

		Dim final As Integer = 0
		For Each b In bestarr
			final = final + Convert.ToInt32(b, 2)
		Next
		Console.WriteLine(final)
	End Sub
	Public Sub encode(ByRef arr As String(), _
										 ByVal karr As String())
		For a = 0 To arr.GetUpperBound(0)
			While arr(a).Length() < 7
				arr(a) = "0" & arr(a)
			End While
			While karr(a Mod karr.Length()).Length() < 7
				karr(a) = "0" & karr(a)
			End While
			Dim nb As String = ""
			For b = 0 To arr(a).Length() - 1
				nb = nb & Convert.ToByte(arr(a)(b) <> karr(a Mod karr.Length())(b))
			Next
			arr(a) = nb
		Next
	End Sub
	Public Function analyze(ByVal astr As String, _
													ByRef words As List(Of String))
		For Each w In words
			astr = astr.Replace(w, "")
		Next
		Return astr.Length()

	End Function
End Class

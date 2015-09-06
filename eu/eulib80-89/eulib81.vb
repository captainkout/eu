Imports System.IO
Public Class eulib81
	Public Sub Main()
		'Dim f As New System.IO.StreamReader("c:\users\chris\downloads\test81.txt")
		Dim f As New System.IO.StreamReader("c:\users\chris\downloads\p081_matrix.txt")

		Dim fstr As String = f.ReadToEnd().Replace(vbLf, ",")
		Dim farr() As String = fstr.Split(",")
		'x-1 by y-1
		Dim clarr(79, 79) As coord

		For a = 0 To clarr.GetUpperBound(0)
			For b = 0 To clarr.GetUpperBound(1)
				Dim c As New coord
				c.x = a
				c.y = b
				c.changed = True
				c.original = farr(a * 80 + b)
				c.value = 9999

				clarr(a, b) = c
			Next
		Next

		While chk_changed(clarr)
			For a = 0 To clarr.GetUpperBound(0)
				For b = 0 To clarr.GetUpperBound(1)
					Select Case True
						Case a = clarr.GetUpperBound(0) AndAlso b < clarr.GetUpperBound(1)
							'move right only
							If Not clarr(a, b).value = clarr(a, b).original + clarr(a, b + 1).value Then
								clarr(a, b).changed = True
								clarr(a, b).value = clarr(a, b).original + clarr(a, b + 1).value
							Else : clarr(a, b).changed = False
							End If

						Case a < clarr.GetUpperBound(0) AndAlso b = clarr.GetUpperBound(1)
							'move down only
							If Not clarr(a, b).value = clarr(a, b).original + clarr(a + 1, b).value Then
								clarr(a, b).changed = True
								clarr(a, b).value = clarr(a, b).original + clarr(a + 1, b).value
							Else : clarr(a, b).changed = False
							End If

						Case a < clarr.GetUpperBound(0) AndAlso b < clarr.GetUpperBound(1)
							'move both
							If Not clarr(a, b).value = clarr(a, b).original + Math.Min(clarr(a, b + 1).value, clarr(a + 1, b).value) Then
								clarr(a, b).changed = True
								clarr(a, b).value = clarr(a, b).original + Math.Min(clarr(a, b + 1).value, clarr(a + 1, b).value)
							Else : clarr(a, b).changed = False
							End If

						Case Else
							'the bottom right corner
							clarr(a, b).changed = False
							clarr(a, b).value = clarr(a, b).original
					End Select

				Next
			Next
		End While

		Console.WriteLine(clarr(0, 0).value)

	End Sub
	Public Class coord
		Public Property x As Integer
		Public Property y As Integer
		Public Property changed As Boolean
		Public Property value As Integer
		Public Property original As Integer
	End Class
	Public Function chk_changed(ByRef arr As Array)
		For Each c In arr
			If c.changed = True Then
				Return True
			End If
		Next
		Return False
	End Function
End Class

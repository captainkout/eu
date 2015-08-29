Public Class speedtest
	Public Property arr As New List(Of Double)
	Public Sub Main()


		'For a = 0 To arr.Count() - 1
		'	arr(a) = a * Math.PI
		'Next
		funk(0, arr.Count() - 1)
	End Sub
	Public Sub funk(ByVal i As Integer, ByVal e As Integer)

		arr(i) = i * Math.PI
		If i < e Then
			funk(i + 1, e)
		End If
		Exit Sub
	End Sub
End Class

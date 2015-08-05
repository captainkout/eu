Public Class eulib32
	Public Sub Main()
		Dim finals As New List(Of Integer)
		For a = 2 To 9876
			If Valid(a) = False Then
				Continue For
			End If
			Dim b = a + 1
			'For b = a + 1 To 9876
			While b.ToString().Length() + a.ToString().Length() < 7
				If Valid(b) = False Then
					b = b + 1
					Continue While
				End If
				Dim c As Integer = a * b

				If a.ToString().Length() + b.ToString().Length() + c.ToString().Length() = 9 _
					AndAlso Valid(Val(a.ToString() + b.ToString() + c.ToString())) = True Then
					If finals.Contains(c) = False Then
						finals.Add(c)
					End If
				End If
				b = b + 1
			End While
		Next
		finals.Sort()
		Console.WriteLine("sum of c's : {0}", finals.Sum())
	End Sub
	Public Function Valid(ByVal test_int As Integer)
		If test_int.ToString().Contains("0") Then
			Return False
		End If
		For Each num In test_int.ToString()
			If Not test_int.ToString().IndexOf(num) = test_int.ToString().LastIndexOf(num) Then
				Return False
			End If
		Next
		Return True
	End Function
End Class

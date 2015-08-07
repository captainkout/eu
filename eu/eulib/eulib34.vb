Public Class eulib34
	Public Sub Main()
		Dim n As Integer = 1
		Dim curious As New List(Of Integer)

		For i = 3 To 1999999 'this is last number less than facsum
			If Valid(i) Then
				curious.Add(i)
				'Console.WriteLine(i)
			End If
		Next

		Console.WriteLine("sum of all curious numbers is {0}", curious.Sum())
	End Sub
	Public Function Valid(ByVal num As Integer)
		Dim value As Integer = 0
		For i = 0 To num.ToString().Length() - 1
			value = value + fac(Val(num.ToString()(i)))
		Next
		If value = num Then
			Return True
		Else
			Return False
		End If
	End Function
	Public Function fac(ByVal n As Integer)
		If n = 0 Then Return 1
		If n = 1 Then Return 1
		Dim dfac As Integer = 1
		For i = 2 To n
			dfac = dfac * i
		Next

		Return dfac
	End Function
End Class

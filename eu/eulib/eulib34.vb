Public Class eulib34
	Public Sub Main()
		Dim ninebang As Integer = fac(9)
		Dim n As Integer = 1
		Dim num As String = "9"
		Dim curious As List(Of Integer)
		While n * ninebang >= Val(num)
			n = n + 1
			num = num + "9"
		End While
		Console.WriteLine("n:{0}   n*ninebang:{1}   num:{2}", n, n * ninebang, num)

		For i = 3 To 7 * ninebang
			If Valid(i) Then
				curious.Add(i)
				Console.WriteLine(i)
			End If
		Next

		Console.WriteLine("sum of all curious numbers is {0}", curious.Sum())
	End Sub
	Public Function Valid(ByVal num As Integer)
		Dim value As Integer = 0
		For Each dig In num.ToString()
			value = value + fac(Val(dig))
		Next
		If value = num Then
			Return True
		Else
			Return False
		End If
	End Function
	Public Function fac(ByVal n As Integer)
		For i = 1 To n
			n = n * i
		Next
		Return fac
	End Function
End Class

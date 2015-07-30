Imports System
Public Class eulib24
	Public numb As Integer

	Public Sub Main()

		Dim done As Boolean = False
		Dim str As New List(Of Integer) From {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
		Dim pull As New List(Of Integer) From {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}
		Dim index = str.Count() - 1
		Dim count As Integer = 0

		'write the first one
		translate(str, pull, count)

		While chk_all(str) = False
			str(index) = str(index) + 1
			While str(index) > str.Count() - 1 - index
				str(index) = 0
				'decrease index
				index = index - 1
				'increase value
				str(index) = str(index) + 1
				If str(index) <= str.Count() - 1 - index Then
					translate(str, pull, count)
				End If
			End While

			index = str.Count() - 1
		End While

		Console.ReadKey()
	End Sub
	Public Function chk_all(ByRef arr As List(Of Integer))
		For i = 0 To arr.Count - 1 - 1
			If Not arr(i) > arr(i + 1) Then
				Return False
			End If
		Next
		Return True
	End Function
	Public Sub translate(ByRef arr As List(Of Integer), _
											 ByRef pull_from As List(Of Integer), _
											 ByRef cnt As Integer)

		Dim pulled As New List(Of Integer)(pull_from)
		Dim print_string As String = ""
		For i = 0 To arr.Count - 1
			print_string = print_string + " " + CStr(pulled(arr(i)))
			pulled.RemoveAt(arr(i))
		Next
		cnt = cnt + 1
		Console.WriteLine("counted {0} --> perm {1}", cnt, print_string)

		If cnt = 1000000 Then
			Console.ReadKey()
		End If
	End Sub
End Class

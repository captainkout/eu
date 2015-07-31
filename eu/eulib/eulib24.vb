Imports System
Public Class eulib24
	Public numb As Integer

	Public Sub Main()

		Dim done As Boolean = False
		Dim min_plus As New List(Of Integer) From {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
		Dim pull As New List(Of Integer) From {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}
		Dim index = min_plus.Count() - 1
		Dim count As Integer = 0

		'write the first one
		translate(min_plus, pull, count)

		While chk_all(min_plus) = False
			min_plus(index) = min_plus(index) + 1
			While min_plus(index) > min_plus.Count() - 1 - index
				min_plus(index) = 0
				'decrease index
				index = index - 1
				'increase value
				min_plus(index) = min_plus(index) + 1
				If min_plus(index) <= min_plus.Count() - 1 - index Then
					translate(min_plus, pull, count)
				End If
			End While

			index = min_plus.Count() - 1
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
		Dim print_min_plusing As String = ""
		For i = 0 To arr.Count - 1
			print_min_plusing = print_min_plusing + " " + CStr(pulled(arr(i)))
			pulled.RemoveAt(arr(i))
		Next
		cnt = cnt + 1
		Console.WriteLine("counted {0} --> perm {1}", cnt, print_min_plusing)

		If cnt = 1000000 Then
			Console.ReadKey()
		End If
	End Sub
End Class

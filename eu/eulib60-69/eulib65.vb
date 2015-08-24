Imports System.Math
Imports System.Numerics.BigInteger
Public Class eulib65
	Public Sub Main()

		Dim lst As New List(Of Integer) From {2}
		For a = 1 To 33
			lst.Add(1)
			lst.Add(2 * a)
			lst.Add(1)
		Next

		Dim comp As New List(Of Numerics.BigInteger) From {1, lst(lst.Count() - 1)}

		For a As Integer = lst.Count() - 1 To 1 Step -1

			If a = lst.Count() - 1 Then
				comp(1) = lst(a)
			End If
			comp(0) = lst(a - 1) * comp(1) + comp(0)

			Dim tmp As New Numerics.BigInteger
			tmp = comp(0)
			comp(0) = comp(1)
			comp(1) = tmp

		Next
		Dim tot As Integer = 0
		For Each dig In comp(1).ToString()
			tot = tot + Val(dig)
		Next
		Console.WriteLine("{0}/{1}  sum:{2}", comp(1), comp(0), tot)
	End Sub
End Class

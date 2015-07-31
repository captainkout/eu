Imports System
Public Class eulib26
	Public Sub Main()
		Dim repeaters As New List(Of Tuple(Of Integer, Integer))

		For i = 2 To 1000
			Dim remainders As New List(Of Integer)
			Dim digits As New List(Of Integer)
			Dim r As Integer = 1
			Dim n As Integer = i

			remainders.Add(0)
			digits.Add(0)
			While r <> 0 AndAlso Not remainders.Contains(r)
				remainders.Add(r)
				While r < n
					r = 10 * r
				End While

				Dim div = 0
				While r >= n
					r = r - n
					div = div + 1
				End While

				digits.Add(div)
			End While
			If r = 0 Then
				'do nothing
			Else

				repeaters.Add(New Tuple(Of Integer, Integer)(n, String.Join("", digits.GetRange(remainders.IndexOf(r), digits.Count - remainders.IndexOf(r)).ToArray()).Length))
			End If

		Next
		Dim max As New Tuple(Of Integer, Integer)(0, 0)
		For Each t In repeaters
			If t.Item2() > max.Item2() Then
				max = t
			End If
		Next
		Console.WriteLine(max.ToString())
		Console.ReadKey()
	End Sub
End Class

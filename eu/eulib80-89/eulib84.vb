Imports System.Random
Public Class eulib84
	Public Property r As New Random
	Public Property doubles As Integer = 0
	Public Property position As Integer = 0

	Public Sub Main()
		Dim Rand As New Random
		Dim count As New List(Of Double)
		For a = 0 To 39
			count.Add(0)
		Next

		For a = 0 To 100000000
			Move()
			count(position) = count(position) + 1
		Next

		'find max
		While count.Max > 0
			Console.WriteLine(count.IndexOf(count.Max()))
			count(count.IndexOf(count.Max())) = 0
		End While

	End Sub

	Public Sub Move()
		Dim d1 As Integer = r.Next(1, 6)
		Dim d2 As Integer = r.Next(1, 6)

		If d1 = d2 Then
			doubles = doubles + 1
		Else
			doubles = 0
		End If
		'if double is 3 then go to jail
		If doubles >= 3 Then
			position = 10
			doubles = 0
		End If
		position = (position + d1 + d2) Mod 40
		While position = 2 OrElse position = 17 OrElse position = 33 OrElse _
			position = 7 OrElse position = 22 OrElse position = 36 OrElse position = 30
			Select Case True
				Case position = 2 OrElse position = 17 OrElse position = 33
					DrawCC()
				Case position = 7 OrElse position = 22 OrElse position = 36
					DrawChance()
				Case position = 30
					position = 10
			End Select
		End While
	End Sub
	Public Sub DrawCC()
		Dim x As Integer = r.Next(1, 16)
		Select Case True
			Case x = 1
				position = 0
			Case x = 2
				position = 10
		End Select
	End Sub
	Public Sub DrawChance()
		Dim x As Integer = r.Next(1, 16)
		Select Case True
			Case x = 1
				position = 0
			Case x = 2
				position = 10
			Case x = 3
				position = 11
			Case x = 4
				position = 24
			Case x = 5
				position = 39
			Case x = 6
				position = 5
			Case x = 7 OrElse x = 8
				If position >= 35 AndAlso position < 5 Then
					position = 5
				ElseIf position >= 5 AndAlso position < 15 Then
					position = 15
				ElseIf position >= 15 AndAlso position < 25 Then
					position = 25
				ElseIf position >= 25 AndAlso position < 25 Then
					position = 35
				End If
			Case x = 9
				If position >= 12 OrElse position < 18 Then
					position = 18
				Else
					position = 12
				End If
			Case x = 10
				position = (position - 3) Mod 40
		End Select
	End Sub
End Class

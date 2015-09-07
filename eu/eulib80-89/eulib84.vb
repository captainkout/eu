Imports System.Random
Public Class eulib84
	Public Property r As New Random
	Public Property doubles As Integer = 0
	Public Property position As Integer = 0
	Public Property cc As Integer = 0
	Public Property ch As Integer = 0

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

		'consume lst and get max
		While count.Max > 0
			Console.WriteLine(count.IndexOf(count.Max()))
			count(count.IndexOf(count.Max())) = 0
		End While

	End Sub

	Public Sub Move()
		Dim d1 As Integer = r.Next(4) + 1
		Dim d2 As Integer = r.Next(4) + 1

		If d1 = d2 Then
			doubles = doubles + 1
		Else
			doubles = 0
		End If
		'if double is 3 then go to jail
		If doubles >= 3 Then
			position = 10
			doubles = 0
			Exit Sub
		End If

		position = (position + d1 + d2) Mod 40
		Select Case True
			Case position = 2 OrElse position = 17 OrElse position = 33
				DrawCC()
			Case position = 7 OrElse position = 22
				DrawChance()
			Case position = 36
				DrawChance()
				If position = 33 Then
					DrawCC()
				End If
			Case position = 30
				position = 10
			Case Else
				Exit Sub
		End Select
	End Sub
	Public Sub DrawCC()
		cc = (cc + 1) Mod 16
		Dim x As Integer = cc
		Select Case True
			Case x = 1
				position = 0
			Case x = 2
				position = 10
			Case Else
				Exit Sub
		End Select
	End Sub
	Public Sub DrawChance()
		ch = (ch + 1) Mod 16
		Dim x As Integer = ch
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
				If position >= 5 AndAlso position < 15 Then
					position = 15
				ElseIf position >= 15 AndAlso position < 25 Then
					position = 25
				Else
					position = 5
				End If
			Case x = 9
				If position = 22 Then
					position = 18
				Else
					position = 12
				End If
			Case x = 10
				position = position - 3
		End Select
	End Sub
End Class

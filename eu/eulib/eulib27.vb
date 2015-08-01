Imports eulib.Primes

Public Class eulib27
	Public p As New Primes
	Public Sub Main()


		p.To_Max(1000)

		Dim b_arr As New List(Of Integer)(p.primes.ToArray())
		Dim max As Integer = 0

		For b = 0 To b_arr.Count - 1

			For a = -1000 To 1000
				Dim n As Integer = 0
				Dim done As Boolean = True

				While p.primes.Contains(Quad(a, b_arr(b), n))
					n = n + 1
				End While
				If n > max Then
					max = n - 1
					Console.WriteLine("a: {0}, b:{1}, n:{2}, prod: {3}", a, b_arr(b), n, a * b_arr(b))
				End If
			Next
		Next

	End Sub
	Public Function Quad(ByVal qa As Integer, _
											 ByVal qb As Integer, _
											 ByVal qn As Integer)

		While p.primes.Max() < qn * qn + qa * qn + qb
			p.Next_Prime()
		End While

		Return qn * qn + qa * qn + qb

	End Function
End Class

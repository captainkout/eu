Public Class eulib85
	Public Sub Main()
		Dim i As Integer = 0
		Dim builder As Integer = 0
		Dim lst As New List(Of Integer)

		Dim cl_to As Integer = 2000000

		Dim closest As Integer = cl_to

		While builder <= cl_to
			i = i + 1
			builder = builder + i
			lst.Add(builder)
		End While

		For x = 0 To lst.Count() - 1
			Dim tot As Integer = 0
			Dim counter As Integer = 0
			Dim prev As Integer = 0
			While tot <= cl_to
				counter = counter + 1
				tot = tot + lst(x) * counter

			End While
			prev = tot - lst(x) * counter

			If Math.Abs(tot - cl_to) <= closest OrElse Math.Abs(prev - cl_to) <= closest Then
				closest = Math.Min(Math.Abs(tot - cl_to), Math.Abs(prev - cl_to))
				Console.WriteLine(String.Join(vbTab, {"OVER--x:{0}", "y:{1}", "closest:{2}", "area:{3}", "tot:{4}", "grr:{5}"}), _
								  x + 1, counter, closest, (x + 1) * counter, tot, Math.Abs(tot - cl_to))
				Console.WriteLine(String.Join(vbTab, {"Under--x:{0}", "y:{1}", "closest:{2}", "area:{3}", "tot:{4}", "grr:{5}"}), _
								  x + 1, counter - 1, closest, (x + 1) * (counter - 1), prev, Math.Abs(prev - cl_to))
			End If
		Next

	End Sub

End Class

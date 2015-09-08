Public Class eulib85
	Public Sub Main()
		Dim i As Integer = 0
		Dim builder As Integer = 0
		Dim lst As New List(Of Integer)
		lst.Add(0)

		Dim closest_to As Integer = 2000000
		Dim closest As Integer = closest_to

		While builder <= closest_to
			i = i + 1
			builder = builder + i
			lst.Add(builder)
		End While

		For x = 1 To lst.Count() - 1
			Dim tot As Integer = 0
			Dim counter As Integer = 0
			Dim prev As Integer = 0
			While tot <= closest_to
				counter = counter + 1
				tot = tot + lst(x) * counter

			End While
			prev = tot - lst(x) * counter

			If Math.Abs(tot - closest_to) <= closest Then
				closest = Math.Abs(tot - closest_to)
				Console.WriteLine(String.Join(vbTab, {"OVER", "x:{0}", "y:{1}", "closest:{2}", "area:{3}", "tot:{4}", "grr:{5}"}), _
								  x, counter, closest, x * counter, tot, Math.Abs(tot - closest_to))
			End If
			If Math.Abs(prev - closest_to) <= closest Then
				closest = Math.Abs(prev - closest_to)
				Console.WriteLine(String.Join(vbTab, {"Under", "x:{0}", "y:{1}", "closest:{2}", "area:{3}", "tot:{4}", "grr:{5}"}), _
				  x, counter - 1, closest, x * (counter - 1), prev, Math.Abs(prev - closest_to))
			End If
		Next

	End Sub

End Class

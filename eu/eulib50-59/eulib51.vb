Imports helper
Public Class eulib51
	Public Sub Main()
		Dim p As New Primes
		Dim parr As BitArray
		parr = p.sieve(1000000)

		Dim primes As New List(Of String)
		For i = 100000 To 999999
			If parr(i) = True Then
				primes.Add(i.ToString())
			End If
		Next

		Dim count As Integer = 0
		Dim max As Integer = 0
		Dim x As Integer = 0
		While x < primes.Count() AndAlso max < 8
			For i = 0 To primes(x).Length() - 1
				For j = i To primes(x).Length() - 1
					For m = j To primes(x).Length() - 1
						Dim strb As New System.Text.StringBuilder(primes(x))

						count = 0
						For k = 0 To 9
							strb(i) = k.ToString()
							strb(j) = k.ToString()
							strb(m) = k.ToString()

							If Val(strb.ToString()) > 100000 AndAlso parr(Val(strb.ToString())) = True Then
								count = count + 1
							End If
						Next
						If max < count AndAlso count = 8 Then
							max = count
							'print lowest prime
							For k = 0 To 9
								strb(i) = k.ToString()
								strb(j) = k.ToString()
								strb(m) = k.ToString()

								If Val(strb.ToString()) > 100000 AndAlso parr(strb.ToString()) = True Then
									Console.WriteLine("lowest prime in first 8 group: {0}", strb.ToString())
									Exit Sub
								End If
							Next
						End If
					Next
				Next
			Next

			x = x + 1
		End While

	End Sub
End Class

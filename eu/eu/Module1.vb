
Module Module1

	Sub Main()

		Dim y As New helper.Primes
		Dim lst As New List(Of Long)

		GC.Collect()
		GC.WaitForFullGCComplete()
		GC.WaitForPendingFinalizers()

		Dim strt As Integer = System.Environment.TickCount()

		'y.Main()
		lst = y.sieve_lst(100000000)
		Dim fin As Integer = System.Environment.TickCount()
		Console.WriteLine("{0} ms", fin - strt)

		Dim lst2 As New List(Of Integer)
		Dim b As BitArray
		GC.Collect()
		GC.WaitForFullGCComplete()
		GC.WaitForPendingFinalizers()

		strt = System.Environment.TickCount()

		'y.Main()
		b = y.sieve(100000000)
		For a = 0 To b.Count() - 1
			If b(a) = True Then lst2.Add(a)
		Next
		fin = System.Environment.TickCount()
		Console.WriteLine("{0} ms", fin - strt)
		Console.ReadKey()

	End Sub

End Module

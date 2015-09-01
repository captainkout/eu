
Module Module1

	Sub Main()
		Dim tot As Long = 10000000

		Dim y As New helper.Primes
		Dim lst As New List(Of Long)
		Dim lst2 As New List(Of Long)

		GC.Collect()
		GC.WaitForFullGCComplete()
		GC.WaitForPendingFinalizers()

		Dim strt As Integer = System.Environment.TickCount()

		'y.Main()
		lst = y.sieve_lst(tot)
		Dim fin As Integer = System.Environment.TickCount()
		Console.WriteLine("{0} ms", fin - strt)

		lst.Clear()
		GC.Collect()
		GC.WaitForFullGCComplete()
		GC.WaitForPendingFinalizers()

		strt = System.Environment.TickCount()

		'y.Main()
		lst2 = y.sieve_lst2(tot)
		fin = System.Environment.TickCount()
		Console.WriteLine("{0} ms", fin - strt)
		'Console.ReadKey()


	End Sub

End Module

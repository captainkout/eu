
Module Module1

	Sub Main()


		Dim y As New eulib80_89.eulib84

		GC.Collect()
		GC.WaitForFullGCComplete()
		GC.WaitForPendingFinalizers()

		Dim strt = System.Environment.TickCount()

		y.Main()

		Dim fin = System.Environment.TickCount()
		Console.WriteLine("{0} ms", fin - strt)

		Console.ReadKey()

	End Sub

End Module

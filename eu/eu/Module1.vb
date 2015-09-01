
Module Module1

	Sub Main()
		Dim tot As Long = 100000000

		Dim y As New eulib70_79.eulib73

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

Imports eulib
Imports eulib40_49
Imports eulib50_59


Module Module1

	Sub Main()

		Dim y As New eulib58
		GC.Collect()
		GC.WaitForFullGCComplete()
		GC.WaitForPendingFinalizers()


		Dim strt As Integer = System.Environment.TickCount()

		y.Main()

		Dim fin As Integer = System.Environment.TickCount()
		Console.WriteLine("{0} ms", fin - strt)
		Console.ReadKey()

	End Sub

End Module

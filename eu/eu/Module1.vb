﻿Imports eulib
Imports eulib40_49
Imports eulib50_59
Imports eulib60_69
Imports helper


Module Module1

	Sub Main()

		Dim y As New helper.speedtest
		GC.Collect()
		GC.WaitForFullGCComplete()
		GC.WaitForPendingFinalizers()

		For a = 0 To 100000
			y.arr.Add(a)
		Next

		Dim strt As Integer = System.Environment.TickCount()

		y.Main()

		Dim fin As Integer = System.Environment.TickCount()
		Console.WriteLine("{0} ms", fin - strt)
		Console.ReadKey()

	End Sub

End Module

﻿
Module Module1

	Sub Main()


        Dim y As New eulib90_99.eulib90

		GC.Collect()
		GC.WaitForFullGCComplete()
		GC.WaitForPendingFinalizers()

		Dim time As New System.Diagnostics.Stopwatch
		time.Start()

		y.Main()

		time.Stop()
		Console.WriteLine("{0} ms", time.ElapsedMilliseconds())

		Console.ReadKey()

	End Sub

End Module

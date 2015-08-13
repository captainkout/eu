Imports helper.permuations
Public Class eulib52
	Public Sub Main()
		Dim helper As New helper.permuations
		For i = 100 To 1000000
			Dim mult As Integer = 2
			Dim org(9) As Integer
			org = helper.count_dig(i)

			While (mult * i).ToString().Length() = i.ToString.Length() AndAlso chk_mult(org, helper.count_dig(mult * i))
				If mult = 6 Then
					Console.WriteLine("2x-6x for i: {0}", i)
					Exit Sub
				End If
				mult = mult + 1
			End While

		Next
	End Sub
	Public Function chk_mult(ByRef arr1 As Array, _
													 ByRef arr2 As Array)
		For Each item In arr1
			If arr1(item) <> arr2(item) Then
				Return False
			End If
		Next

		Return True
	End Function

End Class

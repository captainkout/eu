Imports System.IO
Imports System.Net
Public Class eulib89
    Public Sub Main()
        Dim client As New WebClient()
        Dim s As New StreamReader(client.OpenRead("https://projecteuler.net/project/resources/p089_roman.txt"))

        Dim f() As String = s.ReadToEnd().Split(vbLf)
        Dim beg As Integer = Join(f, "").ToString().Length()

        For l = 0 To f.Count() - 1
            Dim v As Integer = 0
            For c = 0 To f(l).Count() - 1
                Select Case f(l)(c)
                    Case "M"c
                        v += 1000
                    Case "D"c
                        v += 500
                    Case "C"c
                        v += 100
                    Case "L"c
                        v += 50
                    Case "X"c
                        v += 10
                    Case "V"c
                        v += 5
                    Case "I"c
                        v += 1
                End Select
            Next

            'subtract out stuff
            If f(l).Contains("CM") Then v -= 200
            If f(l).Contains("CD") Then v -= 200
            If f(l).Contains("XC") Then v -= 20
            If f(l).Contains("XL") Then v -= 20
            If f(l).Contains("IX") Then v -= 2
            If f(l).Contains("IV") Then v -= 2

            Dim vstr As String = v.ToString()
            Dim newstr As String = ""
            'ones digit
            Select Case Val(vstr(vstr.Length() - 1))
                Case 4
                    newstr = "IV"
                Case 9
                    newstr = "IX"
                Case Is < 4
                    For a = 1 To Val(vstr(vstr.Length() - 1))
                        newstr = "I" & newstr
                    Next
                Case Is < 9
                    For a = 6 To Val(vstr(vstr.Length() - 1))
                        newstr = "I" & newstr
                    Next
                    newstr = "V" & newstr
            End Select

            'tens digit
            If vstr.Length() > 1 Then
                Select Case Val(vstr(vstr.Length() - 2))
                    Case 4
                        newstr = "XL" & newstr
                    Case 9
                        newstr = "XC" & newstr
                    Case Is < 4
                        For a = 1 To Val(vstr(vstr.Length() - 2))
                            newstr = "X" & newstr
                        Next
                    Case Is < 9
                        For a = 6 To Val(vstr(vstr.Length() - 2))
                            newstr = "X" & newstr
                        Next
                        newstr = "L" & newstr
                End Select
            End If

            'hundreds digit
            If vstr.Length() > 2 Then
                Select Case Val(vstr(vstr.Length() - 3))
                    Case 4
                        newstr = "CD" & newstr
                    Case 9
                        newstr = "CM" & newstr
                    Case Is < 4
                        For a = 1 To Val(vstr(vstr.Length() - 3))
                            newstr = "C" & newstr
                        Next
                    Case Is < 9
                        For a = 6 To Val(vstr(vstr.Length() - 3))
                            newstr = "C" & newstr
                        Next
                        newstr = "D" & newstr
                End Select
                'more, add M's
            End If
            If vstr.Length() > 3 Then
                For a = 1 To Val(vstr.Substring(0, vstr.Length() - 3))
                    newstr = "M" & newstr
                Next
            End If
            'If f(l) <> newstr Then
            '    Console.WriteLine(f(l).ToString() & vbTab & newstr)

            'End If
            f(l) = newstr
        Next

        Console.WriteLine(beg - Join(f, "").ToString().Length())

    End Sub
End Class

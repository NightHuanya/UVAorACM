Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c, g, h As Integer
        Dim d(500)
        Dim f$
        d(1) = 1
        d(2) = 2
        c = 3
        Do Until EOF(1) = True
            f = LineInput(1)
            For i = 1 To Len(f)
                Select Case Mid(f, i, 1)
                    Case "0" To "9"
                        b = b & Mid(f, i, 1)
                    Case Else
                        a = b
                        b = 0
                End Select
            Next


            For i = 3 To a
                For j = 2 To i - 1
                    If i Mod j = 0 Then
                        Exit For
                    ElseIf j = i - 1 Then
                        d(c) = i
                        c = c + 1
                    End If
                Next
            Next
            g = c - 1
            b = b * 2
            If b > c - 1 Then
                b = c - 1
            End If
            h = b
            If g Mod 2 = 1 Then
                h = h - 1

            End If
            If b Mod 2 = 1 Then
                b = (b - 2) / 2
            Else
                b = b / 2
            End If
            If g Mod 2 = 1 Then
                b = b - 1
            End If
            If g Mod 2 = 1 Then
                g = (g - 1) / 2
            Else
                g = g / 2
            End If
            Print(2, f & ":")
            For i = 1 To h
                Print(2, Space(1) & d(g - b + i))
            Next
            If EOF(1) = False Then
                Print(2, vbNewLine & vbNewLine)
            End If
            a = 0
            b = 0
            c = 3
            h = 0
        Loop




    End Sub
End Class

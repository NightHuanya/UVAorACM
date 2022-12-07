Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c, d, g As String
        Dim f$
        a = LineInput(1)
        Do

            If a = 0 Then
                Exit Do
            End If

            f = LineInput(1)

            For i = 1 To Len(f)
                Select Case Mid(f, i, 1)
                    Case "0" To "9"
                        b = b & Mid(f, i, 1)
                    Case "-"
                        b = Mid(f, i, 1) & b
                    Case Else
                        c = b
                        b = ""
                End Select
            Next
            For j = 1 To Val(a)
                f = LineInput(1)
                For k = 1 To Len(f)
                    Select Case Mid(f, k, 1)
                        Case "0" To "9"
                            d = d & Mid(f, k, 1)
                        Case "-"
                            d = Mid(f, k, 1) & d
                        Case Else
                            g = d
                            d = ""
                    End Select
                Next
                If j = Val(a) Then
                    a = LineInput(1)
                End If
                If Val(g) = Val(c) Or Val(b) = Val(d) Then
                    If a = 0 Then
                        Print(2, "divisa")
                    Else
                        PrintLine(2, "divisa")
                    End If
                ElseIf Val(g) > Val(c) And Val(d) > Val(b) Then
                    If a = 0 Then
                        Print(2, "NE")
                    Else
                        PrintLine(2, "NE")
                    End If
                ElseIf Val(g) > Val(c) And Val(d) < Val(b) Then
                    If a = 0 Then
                        Print(2, "SE")
                    Else
                        PrintLine(2, "SE")
                    End If

                ElseIf Val(g) < Val(c) And Val(d) > Val(b) Then
                    If a = 0 Then
                        Print(2, "NO")
                    Else
                        PrintLine(2, "NO")
                    End If
                ElseIf Val(g) < Val(c) And Val(d) < Val(b) Then
                    If a = 0 Then
                        Print(2, "SO")
                    Else
                        PrintLine(2, "SO")
                    End If
                End If
                d = ""
                g = ""
            Next
            c = ""
            b = ""
        Loop


    End Sub
End Class

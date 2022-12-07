Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c, g, h As Long
        Dim d()
        Dim f$
        c = 1
        f = LineInput(1)

        Do Until EOF(1) = True

            For i = 1 To Len(f)
                Select Case Mid(f, i, 1)
                    Case "0" To "9"
                        a = a & Mid(f, i, 1)
                    Case Else
                        b = a
                        a = 0
                End Select
            Next

            ReDim d(b)
            f = LineInput(1)
            For i = 1 To Len(f)
                Select Case Mid(f, i, 1)
                    Case "0" To "9"
                        g = g & Mid(f, i, 1)
                    Case Else
                        d(c) = g
                        g = 0
                        c = c + 1
                End Select
                If i = Len(f) Then
                    d(c) = g
                End If
            Next
            c = 0
            g = 0
            For i = 1 To a
                f = LineInput(1)
                For j = 1 To Len(f)
                    Select Case Mid(f, j, 1)
                        Case "0" To "9"
                            c = c & Mid(f, j, 1)
                        Case Else
                            g = c
                            c = 0
                    End Select
                Next

                For j = 1 To b
                    If d(j) = c Then
                        h = h + 1
                    End If
                    If h = g Then
                        h = j
                        Exit For
                    End If
                    If j = b Then
                        h = 0
                    End If
                Next

                If i <> a Then
                    PrintLine(2, h)
                    h = 0
                    c = 0
                    g = 0
                End If

            Next

            If EOF(1) <> True Then
                PrintLine(2, h)
                f = LineInput(1)
            Else
                Print(2, h)
            End If

            a = 0
            b = 0
            c = 1
            g = 0
            h = 0

        Loop





    End Sub
End Class

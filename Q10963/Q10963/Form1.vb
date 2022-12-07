Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c, d, f As String
        Dim g, h As Integer
        a = LineInput(1)



        For i = 1 To Val(a)
            LineInput(1)
            b = LineInput(1)
            For j = 1 To Val(b)
                c = LineInput(1)
                For k = 1 To Len(c)
                    Select Case Mid(c, k, 1)
                        Case "0" To "9"
                            d = d & Mid(c, k, 1)
                        Case "-"
                            d = Mid(c, k, 1) & d
                        Case Else
                            f = d
                            d = ""
                    End Select
                Next

                g = Val(f) - Val(d)
                If h = 0 Then
                    h = g
                Else
                    If Math.Abs(h) <> Math.Abs(g) Then
                        If i = Val(a) Then
                            Print(2, "No")
                        Else
                            PrintLine(2, "No")
                        End If
                        Exit For
                    End If
                End If

                If j = Val(b) Then
                    If Val(a) = i Then
                        Print(2, "Yes")
                    Else
                        PrintLine(2, "Yes")
                    End If
                End If
                d = ""
                f = ""
            Next

            g = 0
            h = 0

        Next



    End Sub
End Class

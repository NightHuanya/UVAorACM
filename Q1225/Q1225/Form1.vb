Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a()
        Dim b, c As Integer
        Dim d$

        b = LineInput(1)

        For i = 1 To b
            c = LineInput(1)
            ReDim a(9)
            For z = 0 To 9
                a(z) = 0
            Next
            For j = 1 To c
                d = j
                For k = 1 To Len(d)
                    Select Case Mid(d, k, 1)
                        Case "0"
                            a(0) = a(0) + 1
                        Case "1"
                            a(1) = a(1) + 1
                        Case "2"
                            a(2) = a(2) + 1
                        Case "3"
                            a(3) = a(3) + 1
                        Case "4"
                            a(4) = a(4) + 1
                        Case "5"
                            a(5) = a(5) + 1
                        Case "6"
                            a(6) = a(6) + 1
                        Case "7"
                            a(7) = a(7) + 1
                        Case "8"
                            a(8) = a(8) + 1
                        Case "9"
                            a(9) = a(9) + 1
                    End Select
                Next
                
            Next

            For l = 0 To 9
                Print(2, a(l))
                If l <> 9 Then
                    Print(2, " ")
                End If
            Next

            If i <> b Then
                Print(2, vbNewLine)
            End If

        Next

    End Sub
End Class

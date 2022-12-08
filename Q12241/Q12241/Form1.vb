Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b As Integer
        Dim d(9) As Long
        Dim c$, f$

        c = LineInput(1)

        Do Until c = "0 0"

            For i = 1 To Len(c)
                Select Case Mid(c, i, 1)
                    Case "0" To "9"
                        b = b & Mid(c, i, 1)
                    Case Else
                        a = b
                        b = 0
                End Select
            Next

            For i = a To b
                f = i
                For j = 1 To Len(f)
                    Select Case Mid(f, j, 1)
                        Case "0"
                            d(0) = d(0) + 1
                        Case "1"
                            d(1) = d(1) + 1
                        Case "2"
                            d(2) = d(2) + 1
                        Case "3"
                            d(3) = d(3) + 1
                        Case "4"
                            d(4) = d(4) + 1
                        Case "5"
                            d(5) = d(5) + 1
                        Case "6"
                            d(6) = d(6) + 1
                        Case "7"
                            d(7) = d(7) + 1
                        Case "8"
                            d(8) = d(8) + 1
                        Case "9"
                            d(9) = d(9) + 1
                    End Select
                Next
            Next

            c = LineInput(1)

            For i = 0 To 9
                Print(2, d(i))
                If i < 9 Then
                    Print(2, Space(1))
                End If
            Next
            If c <> "0 0" Then
                Print(2, vbNewLine)
            End If
            ReDim d(9)
            a = 0
            b = 0
        Loop


    End Sub
End Class

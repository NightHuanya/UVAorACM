Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b As String
        Dim c, d As Integer
        Dim f As Boolean = False
        a = LineInput(1)
        Do Until Mid(a, 1, 1) = "-"

            For i = 1 To Len(a)
                Select Case Mid(a, i, 1)
                    Case "0" To "9"
                        b = b & Mid(a, i, 1)
                    Case "A" To "Z"
                        b = b & Mid(a, i, 1)
                    Case "x"
                        b = ""
                        f = True
                End Select
            Next
            c = Val(b)
            If f = False Then
                b = ""
                Do Until c < 16
                    d = c Mod 16
                    Select Case d
                        Case Is < 10
                            b = b & d
                        Case 10
                            b = b & "A"
                        Case 11
                            b = b & "B"
                        Case 12
                            b = b & "C"
                        Case 13
                            b = b & "D"
                        Case 14
                            b = b & "E"
                        Case 15
                            b = b & "F"
                    End Select
                    c = c \ 16
                Loop
                b = "0x" & c & b
            Else
                b = ""
                a = c
                For i = 0 To Len(a) - 1
                    Select Case Mid(a, Len(a) - i, 1)
                        Case "0" To "9"
                            b = Val(b) + Val(Mid(a, Len(a) - i, 1)) * 16 ^ i
                        Case "A"
                            b = Val(b) + 10 * 16 ^ i
                        Case "B"
                            b = Val(b) + 11 * 16 ^ i
                        Case "C"
                            b = Val(b) + 12 * 16 ^ i
                        Case "D"
                            b = Val(b) + 13 * 16 ^ i
                        Case "E"
                            b = Val(b) + 14 * 16 ^ i
                        Case "F"
                            b = Val(b) + 15 * 16 ^ i
                    End Select
                Next
            End If
            a = LineInput(1)
            If Mid(a, 1, 1) = "-" Then
                Print(2, b)
            Else
                PrintLine(2, b)
            End If

            b = ""
            c = 0
            d = 0
            f = False

        Loop

    End Sub
End Class

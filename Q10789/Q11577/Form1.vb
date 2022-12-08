Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, d, f As Long
        Dim b As String
        Dim c(61, 1)

        For i = 0 To 9
            c(i, 0) = i
        Next
        For i = 10 To 35
            c(i, 0) = Chr(65 + i - 10)
        Next
        For i = 36 To 61
            c(i, 0) = Chr(97 + i - 36)
        Next
        a = LineInput(1)

        For i = 1 To a

            b = LineInput(1)

            For j = 1 To Len(b)
                Select Case Mid(b, j, 1)
                    Case "a" To "z"
                        c(Asc(Mid(b, j, 1)) - 61, 1) = Val(c(Asc(Mid(b, j, 1)) - 61, 1)) + 1
                    Case "A" To "Z"
                        c(Asc(Mid(b, j, 1)) - 55, 1) = Val(c(Asc(Mid(b, j, 1)) - 55, 1)) + 1
                    Case "0" To "9"
                        c(Asc(Mid(b, j, 1)) - 48, 1) = Val(c(Asc(Mid(b, j, 1)) - 48, 1)) + 1
                End Select
            Next
            Print(2, "Case " & i & ": ")
            For j = 0 To 61
                If c(j, 1) = 2 Then
                    Print(2, c(j, 0))
                    f = f + 1
                Else
                    For k = 2 To c(j, 1) - 1
                        If c(j, 1) Mod k = 0 Then
                            Exit For
                        End If
                        If k = c(j, 1) - 1 Then
                            Print(2, c(j, 0))
                            f = f + 1
                        End If
                    Next
                End If
            Next
            If f = 0 Then
                Print(2, "empty")
            End If
            If i < a Then
                Print(2, vbNewLine)
            End If
            For j = 1 To 61
                c(j, 1) = 0
            Next
            d = 0
            f = 0
        Next


    End Sub
End Class

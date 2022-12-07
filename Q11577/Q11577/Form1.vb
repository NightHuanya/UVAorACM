Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, d As Long
        Dim b As String
        Dim c(25, 1)

        For i = 0 To 25
            c(i, 0) = Chr(97 + i)
        Next
        a = LineInput(1)

        For i = 1 To a

            b = LineInput(1)

            For j = 1 To Len(b)
                Select Case Mid(b, j, 1)
                    Case "a" To "z"
                        c(Asc(Mid(b, j, 1)) - 97, 1) = Val(c(Asc(Mid(b, j, 1)) - 97, 1)) + 1
                    Case "A" To "Z"
                        c(Asc(LCase(Mid(b, j, 1))) - 97, 1) = Val(c(Asc(LCase(Mid(b, j, 1))) - 97, 1)) + 1
                End Select
            Next

            For j = 0 To 25

                If c(j, 1) > d Then
                    d = c(j, 1)
                End If

            Next

            For j = 0 To 25
                If c(j, 1) = d Then
                    Print(2, c(j, 0))
                End If
            Next
            If i < a Then
                Print(2, vbNewLine)
            End If
            For j = 1 To 25
                c(j, 1) = 0
            Next
            d = 0
        Next


    End Sub
End Class

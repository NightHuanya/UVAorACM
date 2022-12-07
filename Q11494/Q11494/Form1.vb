Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a As String
        Dim b, c, d, f As Integer
        a = LineInput(1)

        Do Until a = "0 0 0 0"

            For i = 1 To Len(a)
                Select Case Mid(a, i, 1)
                    Case "0" To "9"
                        b = c
                        c = d
                        d = f
                        f = Mid(a, i, 1)
                End Select
            Next
            a = LineInput(1)
            If b = d And c = f Then
                If a = "0 0 0 0" Then
                    Print(2, 0)
                Else
                    PrintLine(2, 0)
                End If
            ElseIf Math.Abs(b - d) = Math.Abs(c - f) Then
                If a = "0 0 0 0" Then
                    Print(2, 1)
                Else
                    PrintLine(2, 1)
                End If
            Else
                If a = "0 0 0 0" Then
                    Print(2, 2)
                Else
                    PrintLine(2, 2)
                End If
            End If
        Loop
    End Sub
End Class

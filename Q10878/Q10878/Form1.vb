Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b As Integer

        Dim c, d As String

        LineInput(1)
        c = LineInput(1)
        Do


            For i = 1 To Len(c)
                Select Case Mid(c, i, 1)
                    Case "o"
                        d = d & "1"
                    Case " "
                        d = d & "0"
                End Select
            Next

            For i = 0 To Len(d) - 1
                If Mid(d, i + 1, 1) = "1" Then
                    a = a + 2 ^ (7 - i)
                End If
            Next

            c = LineInput(1)

            Print(2, Chr(a))
            a = 0
            d = ""
        Loop Until EOF(1) = True

    End Sub
End Class

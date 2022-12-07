Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b As Long
        Dim c As String

        Do Until EOF(1) = True
            c = LineInput(1)

            For i = 1 To Len(c)
                Select Case Mid(c, i, 1)
                    Case " "
                        a = a + 1
                    Case Else
                        If a > b Then
                            b = a
                        End If
                        a = 0
                End Select
            Next
            a = 0
            Do Until b = 1
                b = b \ 2 + b Mod 2
                a = a + 1
            Loop

            If EOF(1) <> True Then
                PrintLine(2, a)
            Else
                Print(2, a)
            End If
            a = 0
            b = 0
        Loop

    End Sub
End Class

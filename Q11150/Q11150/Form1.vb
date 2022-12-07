Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c As Integer
        Dim d As Boolean = False

        Do Until EOF(1) = True
            a = LineInput(1)
            If a = 1 Then
                d = True
            End If
            Do Until a = 0
                If d = True Then
                    b = 2
                    Exit Do
                End If
                If a Mod 3 <> 0 And a <> 1 Then
                    a = a + 1
                    c = c + 1
                ElseIf a Mod 3 = 0 And a > 1 Then
                    b = b + a
                    a = a / 3
                Else
                    b = b + a
                    a = 0
                End If

            Loop

            If EOF(1) <> True Then
                PrintLine(2, b - c)
            Else
                Print(2, b - c)
            End If
            b = 0
            d = False
            c = 0
        Loop

    End Sub
End Class

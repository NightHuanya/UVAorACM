Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)
        Dim a, b As Integer
        b = LineInput(1)
        Do Until b = 0
            a = b
            b = LineInput(1)
            If a = 1 And EOF(1) = True Then
                Print(2, "0/1")
            ElseIf a = 1 And EOF(1) = False Then
                PrintLine(2, "0/1")
            End If
            If a > 1 And EOF(1) = True Then
                Print(2, "1/2")
            ElseIf a > 1 And EOF(1) = False Then
                PrintLine(2, "1/2")
            End If
        Loop
    End Sub
End Class

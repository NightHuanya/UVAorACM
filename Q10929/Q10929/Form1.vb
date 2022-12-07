Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a As Long
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        a = LineInput(1)
        Do
            If a Mod 11 = 0 Then
                Print(2, a & " is a multiple of 11.")
            Else
                Print(2, a & " is not a multiple of 11.")
            End If
            a = LineInput(1)
            If a <> 0 Then
                PrintLine(2)
            End If
        Loop Until a = 0
    End Sub
End Class

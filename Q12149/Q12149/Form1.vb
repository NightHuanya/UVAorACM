Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b As Integer

        a = LineInput(1)

        Do

            For i = 1 To a

                b = b + i ^ 2

            Next

            a = LineInput(1)

            If a <> 0 Then
                PrintLine(2, b)
            Else
                Print(2, b)
            End If
            b = 0

        Loop Until a = 0


    End Sub
End Class

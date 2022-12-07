Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b As Integer
        Dim c As String

        Do Until EOF(1) = True
            b = 1

            a = LineInput(1)

            For i = 1 To a \ 2

                For j = 1 To a + 2 - 2 * i


                    b = b + 2


                Next

            Next

            If b > 1 Then
                b = b * 3 - 6
                c = b
            End If
            If EOF(1) = True Then
                Print(2, c)
            Else
                PrintLine(2, c)
            End If
        Loop


    End Sub
End Class

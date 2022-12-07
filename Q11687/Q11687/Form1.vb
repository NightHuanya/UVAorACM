Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b As String
        Dim c As Integer
        c = 1
        a = LineInput(1)

        Do


            b = Len(a)
            If b <> 1 Then
                Do
                    b = Len(b)

                    c = c + 1
                    If b = 1 Then
                        c = c + 1
                        Exit Do
                    End If

                Loop
            Else
                c = c + 1
            End If



            a = LineInput(1)
            If EOF(1) = True Then
                Print(2, c)
            Else
                PrintLine(2, c)
            End If

            c = 1
        Loop Until EOF(1) = True




    End Sub
End Class

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a As Long
        Dim d$
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Do Until EOF(1) = True
            a = LineInput(1)
            If a = 0 Then
                d = 0
            ElseIf a = 1 Then
                d = 1
            ElseIf a = 2 Then
                d = 2
            End If
            Do Until a < 3

                d = a Mod 3 & d

                a = a \ 3




                If a < 3 Then
                    d = a & d
                End If



            Loop
            If EOF(1) = True Then
                Print(2, d)
            Else
                PrintLine(2, d)
            End If
            d = ""
        Loop





    End Sub
End Class

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a As String
        Dim b, c As Long

        Do Until EOF(1) = True
            b = LineInput(1)
            Do
                a = a & "1"
                c = c + 1
                If Val(a) Mod b = 0 Then
                    Exit Do
                End If
            Loop

            If EOF(1) = True Then
                Print(2, c)
            Else
                PrintLine(2, c)
            End If

            a = ""
            c = 0

        Loop


    End Sub
End Class

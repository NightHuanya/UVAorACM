Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim a As String
        Dim b As Integer



        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Do Until EOF(1) = True

            a = LineInput(1)

            For i = 1 To Len(a)
                b = Asc(Mid(a, i, 1))
                b = b - 7
                If i = Len(a) Then
                    PrintLine(2, Chr(b))
                Else
                    Print(2, Chr(b))
                End If

            Next

        Loop



    End Sub
End Class

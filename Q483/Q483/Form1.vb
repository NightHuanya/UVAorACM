Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)
        Dim a, b, c As String

        Do Until EOF(1) = True
            a = LineInput(1)

            For i = 1 To Len(a)
                Select Case Mid(a, i, 1)
                    Case " "
                        c = c & b
                        c = c & Mid(a, i, 1)
                        b = ""
                    Case Else
                        b = Mid(a, i, 1) & b
                End Select

                If i = Len(a) Then
                    c = c & b
                    b = ""
                End If
            Next

            If EOF(1) = True Then
                Print(2, c)
            Else
                PrintLine(2, c)
            End If

            b = ""
            c = ""

        Loop

    End Sub
End Class

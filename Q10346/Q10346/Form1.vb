Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c As String
        Dim d$
        Do Until EOF(1) = True
            d = LineInput(1)
            For i = 1 To Len(d)
                Select Case Mid(d, i, 1)
                    Case "0" To "9"
                        a = a & Mid(d, i, 1)
                    Case Else
                        b = a
                        a = ""
                End Select
            Next

            Do
                c = Val(c) + Val(b)
                If Val(b) < Val(a) Then
                    Exit Do
                End If
                b = Val(b) \ Val(a)
            Loop

            If EOF(1) = True Then
                Print(2, c)
            Else
                PrintLine(2, c)
            End If

            a = ""
            b = ""
            c = ""

        Loop

    End Sub
End Class

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)
        Dim a, c As String
        Dim b As Single

        Do Until EOF(1) = True
            b = 0
            a = LineInput(1)

            For i = 1 To Len(a)
                c = Mid(a, i, 1)
                If Asc(c) < 65 Or Asc(c) > 90 And Asc(c) < 97 Or Asc(c) > 122 Then
                    Select Case Mid(a, i - 1, 1)
                        Case "A" To "Z", "a" To "z"
                            b = b + 1
                    End Select
                End If
            Next
            PrintLine(2, b)
        Loop
    End Sub

    
End Class

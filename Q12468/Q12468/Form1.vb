Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a, b, c As Integer
        Dim d As String
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)


        Do Until EOF(1) = True


            d = LineInput(1)

            For i = 1 To Len(d)
                Select Case Mid(d, i, 1)
                    Case "0" To "9"
                        a = a & Mid(d, i, 1)

                    Case "-"
                        a = Mid(d, i, 1) & a
                    Case Else

                        c = a
                        a = 0

                End Select
            Next

            If a = -1 And c = -1 Then
                Exit Do
            End If

            If c < a Then
                If (c - a) ^ 2 ^ 0.5 < c + 100 - a Then
                    Print(2, (c - a) ^ 2 ^ 0.5)


                Else
                    Print(2, c + 100 - a)
                End If
            ElseIf c > a Then
                If c - a < 100 - c + a Then
                    Print(2, c - a)
                Else
                    Print(2, 100 - c + a)
                End If
            End If
            If EOF(1) <> True Then
                PrintLine(2)
            End If


            c = 0
            a = 0

        Loop






    End Sub
End Class

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, c As Long
        Dim b$
        Dim d As Boolean
        d = False
        a = LineInput(1)

        For i = 1 To a

            b = LineInput(1)

            For j = 1 To Len(b)

                Select Case Mid(b, j, 1)

                    Case "0" To "9"
                        If d = True Then
                            c = c & Mid(b, j, 1)
                        End If
                    Case Else
                        d = True
                End Select
            Next


            If i = a Then
                Print(2, "0" & Space(1) & c)
            Else
                PrintLine(2, "0" & Space(1) & c)
            End If

            c = 0
            d = False

        Next

    End Sub
End Class

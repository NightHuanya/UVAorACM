Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)
        Dim a, b, c, f, g, h As Integer
        Dim d$

        a = LineInput(1)

        For i = 1 To a

            d = LineInput(1)

            For j = 1 To Len(d)

                Select Case Mid(d, j, 1)
                    Case "0" To "9"
                        b = b + 1
                        If b Mod 2 = 1 Then
                            c = Val(Mid(d, j, 1)) * 2
                            For k = 1 To Len(c)
                                g = g + Val(Mid(c, k, 1))
                            Next
                        Else
                            f = f + Val(Mid(d, j, 1))
                        End If
                    Case Else
                        b = 0
                End Select

            Next

            h = f + g

            If h Mod 2 = 0 And h Mod 5 = 0 Then
                If i = a Then
                    Print(2, "Valid")
                Else
                    PrintLine(2, "Valid")
                End If
            Else
                If i = a Then
                    Print(2, "Invalid")
                Else
                    PrintLine(2, "Invalid")
                End If

            End If

            b = 0
            f = 0
            g = 0
            h = 0

        Next









    End Sub
End Class

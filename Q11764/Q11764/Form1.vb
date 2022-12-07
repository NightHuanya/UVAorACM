Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c, f, g As Integer
        Dim d As String

        a = LineInput(1)

        For i = 1 To a
            b = LineInput(1)
            d = LineInput(1)
            For j = 1 To Len(d)
                Select Case Mid(d, j, 1)
                    Case "0" To "9"
                        c = c & Mid(d, j, 1)
                    Case Else
                        If j > 3 Then
                            If b < c Then
                                f = f + 1
                            ElseIf b > c Then
                                g = g + 1
                            End If
                        End If
                        b = c
                        c = 0
                End Select
                If j = Len(d) Then
                    If j > 3 Then
                        If b < c Then
                            f = f + 1
                        ElseIf b > c Then
                            g = g + 1
                        End If
                    End If
                End If
            Next

            If i = a Then
                Print(2, f & Space(1) & g)
            Else
                PrintLine(2, f & Space(1) & g)
            End If

            c = 0
            f = 0
            g = 0

        Next

    End Sub
End Class

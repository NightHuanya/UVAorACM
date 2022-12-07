Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a() = {"`", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "-", "="}
        Dim b() = {"q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "[", "]", "\"}
        Dim c() = {"a", "s", "d", "f", "g", "h", "j", "k", "l", ";", "'"}
        Dim d() = {"z", "x", "c", "v", "b", "n", "m", ",", ".", "/"}
        Dim f$
        Do

            f = LineInput(1)


            For j = 1 To Len(f)
                Select Case Mid(f, j, 1)
                    Case " "
                        Print(2, " ")
                    Case Else
                        For z = 0 To a.Length - 1
                            If a(z) = Mid(f, j, 1) Then
                                Print(2, a(z - 2))
                            End If
                        Next
                        For x = 0 To b.Length - 1
                            If b(x) = Mid(f, j, 1) Then
                                Print(2, b(x - 2))
                            End If
                        Next
                        For y = 0 To c.Length - 1
                            If c(y) = Mid(f, j, 1) Then
                                Print(2, c(y - 2))
                            End If
                        Next
                        For w = 0 To d.Length - 1
                            If d(w) = Mid(f, j, 1) Then
                                Print(2, d(w - 2))
                            End If
                        Next
                End Select
            Next

            If EOF(1) <> True Then
                Print(2, vbNewLine)
            End If

        Loop Until EOF(1) = True

    End Sub
End Class

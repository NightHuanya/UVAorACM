Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)
        Dim a, b, c As Long
        a = LineInput(1)
        Do Until a = 0

            b = f91(a)
            c = a
            a = LineInput(1)
            If a <> 0 Then
                PrintLine(2, "f91(" & c & ") = " & b)
            Else
                Print(2, "f91(" & c & ") = " & b)
            End If
        Loop



    End Sub

    Function f91(ByVal x As Long)
        If x >= 101 Then
            f91 = x - 10
        Else
            f91 = f91(f91(x + 11))
        End If
    End Function
End Class

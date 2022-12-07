Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b As String
        Dim c, d As Long

        Do Until EOF(1) = True
            a = LineInput(1)
            b = StrReverse(a)
            If Val(b) > Val(a) Then
                c = Val(b) - Val(a)
            Else
                c = Val(a) - Val(b)
            End If
            d = c / 9

            If EOF(1) = True Then
                If Val(a) > Val(b) Then
                    Print(2, a & " - " & b & " = " & c & " = " & " 9 * " & d)
                Else
                    Print(2, b & " - " & a & " = " & c & " = " & " 9 * " & d)
                End If
            Else
                If Val(a) > Val(b) Then
                    PrintLine(2, a & " - " & b & " = " & c & " = " & " 9 * " & d)
                Else
                    PrintLine(2, b & " - " & a & " = " & c & " = " & " 9 * " & d)
                End If
            End If

        Loop

    End Sub
End Class

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Dim a% = LineInput(1)
        For i = 1 To a
            Dim z$() = LineInput(1).Split
            Dim b%(UBound(z))
            For k = 0 To UBound(z)
                b(k) = Val(z(k))
            Next
            Array.Sort(b)
            Array.Reverse(b)
            Dim c% = 0
            Dim d% = 0
            For j = 0 To UBound(b)
                If c = d Then
                    c += Val(b(j))
                ElseIf c < d Then
                    c += Val(b(j))
                ElseIf c > d Then
                    d += Val(b(j))
                End If
            Next
            If c = d Then
                PrintLine(2, "YES")
            Else
                PrintLine(2, "NO")
            End If
        Next
    End Sub
End Class

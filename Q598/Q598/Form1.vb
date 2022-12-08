Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Dim a% = LineInput(1)
        LineInput(1)
        For i = 1 To a
            Dim b$() = LineInput(1).Split
            Dim word As New List(Of String)
            Dim che$ = LineInput(1)
            Do Until che = "" Or EOF(1) = True
                word.Add(che)
                che = LineInput(1)
            Loop
            If EOF(1) = True Then word.Add(che)
            If b(0) = "*" Then
                ReDim b(word.Count - 1)
                For j = 0 To UBound(b)
                    b(j) = j + 1
                Next
            End If
            For j = 0 To UBound(b)
                PrintLine(2, "Size " & b(j))
                QQ(word, Val(b(j)), 0, 0, "")
                PrintLine(2)
            Next
            PrintLine(2)
        Next
    End Sub
    Function QQ(ByVal word As List(Of String), ByVal x%, ByVal y%, ByVal z%, ByVal ans$)
        If x = z Then PrintLine(2, ans.Trim(" ").Trim(",")) : Exit Function
        For i = y To word.Count - 1
            QQ(word, x, i + 1, z + 1, ans & word(i) & ", ")
        Next
    End Function
End Class

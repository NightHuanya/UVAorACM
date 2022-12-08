Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Dim word As New List(Of String)
        Do Until EOF(1) = True
            Dim a$() = LCase(LineInput(1).Replace(".", "").Replace(":", "").Replace(";", "").Replace(Chr(34), "")).Split({" "}, StringSplitOptions.RemoveEmptyEntries)
            For i = 0 To UBound(a)
                If word.Contains(a(i)) = False Then word.Add(a(i))
            Next
        Loop
        word.Sort()
        For i = 0 To word.Count - 1
            PrintLine(2, word(i))
        Next
    End Sub
End Class

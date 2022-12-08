Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Do
            Dim a% = LineInput(1)
            If a = 0 Then Exit Do
            Dim ans% = 0
            For i = 1 To a
                Dim b$() = LineInput(1).Split
                If b(0) = "0" Then Exit For
                If UBound(b) >= 2 Then ans += 1
            Next
            PrintLine(2, ans)
        Loop
    End Sub
End Class

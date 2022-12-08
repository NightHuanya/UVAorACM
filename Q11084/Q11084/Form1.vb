Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Dim a% = LineInput(1)
        Do Until a = 0
            Dim b$() = LineInput(1).Split
            Dim c As New List(Of Integer)
            For k = 0 To UBound(b)
                c.Add(Val(b(k)))
            Next
            c.Sort()
            Dim ans% = 0
            Do Until c.Count = 1
                Dim x% = c.Min
                c.Remove(x)
                Dim y% = c.Min
                c.Remove(y)
                c.Add(x + y)
                ans += x + y
                c.Sort()
            Loop
            a = LineInput(1)
            PrintLine(2, Trim(ans))
        Loop
    End Sub
End Class

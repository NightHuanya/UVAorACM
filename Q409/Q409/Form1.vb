Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Dim a% = 1
        Do Until EOF(1) = True
            Dim b$() = LineInput(1).Split({" "}, StringSplitOptions.RemoveEmptyEntries)
            Dim keyword As New List(Of String)
            For k = 1 To Val(b(0))
                keyword.Add(UCase(LineInput(1)))
            Next
            Dim ans As New List(Of String)
            Dim ans1 As New List(Of Integer)
            For k = 1 To Val(b(1))
                Dim c$ = LineInput(1)
                ans.Add(c)
                Dim d$() = c.Split({" "}, StringSplitOptions.RemoveEmptyEntries)
                Dim x% = 0
                For l = 0 To UBound(d)
                    For m = 0 To keyword.Count - 1
                        If InStr(UCase(d(l)), keyword(m)) <> 0 Then x += 1
                    Next
                Next
                ans1.Add(x)
            Next
            Dim z% = ans1.Max
            PrintLine(2, "Excuse Set #" & a)
            Do Until ans1.Contains(z) = False : PrintLine(2, ans(ans1.IndexOf(z))) : ans1(ans1.IndexOf(z)) = 0 : Loop
            a += 1
            PrintLine(2)
        Loop
    End Sub
End Class

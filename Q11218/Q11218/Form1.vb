Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Dim a% = LineInput(1)
        Dim b% = 1
        Do Until a = 0
            Dim team As New List(Of String)
            For i = 1 To a
                team.Add(LineInput(1))
            Next
            Dim ans As New List(Of Integer)
            QQ(team, "", 0, 0, ans)
            If ans.Count = 0 Then ans.Add(-1)
            PrintLine(2, "Case " & b & ": " & ans.Max)
            b += 1
            a = LineInput(1)
        Loop
    End Sub
    Function QQ(ByVal team As List(Of String), ByVal che$, ByVal che2%, ByVal ans%, ByVal aans As List(Of Integer))
        If che2 = 3 Then aans.Add(ans) : Exit Function
        For i = 0 To team.Count - 1
            Dim a$() = team(i).Split(" ")
            For j = 0 To 2
                If InStr(che, a(j)) <> 0 Then Exit For
                If j = 2 Then QQ(team, che & a(0) & a(1) & a(2), che2 + 1, ans + Val(a(3)), aans)
            Next
        Next
    End Function
End Class

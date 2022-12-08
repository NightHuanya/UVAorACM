Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Dim a% = LineInput(1)
        For i = 1 To a
            Dim b$() = LineInput(1).Split
            Dim FD%(Val(b(0)))
            For k = 1 To UBound(FD)
                FD(k) = k
            Next
            For k = 1 To Val(b(1))
                Dim c$() = LineInput(1).Split
                If FD(Val(c(0))) <> FD(Val(c(1))) Then
                    Dim x% = Math.Max(FD(Val(c(0))), FD(Val(c(1)))), y% = Math.Min(FD(Val(c(0))), FD(Val(c(1))))
                    Do Until FD.Contains(x) = False : FD(Array.IndexOf(FD, x)) = y : Loop
                End If
            Next
            Dim ans1 As New List(Of Integer)
            Dim ans2 As New List(Of Integer)
            For k = 1 To UBound(FD)
                If ans1.Contains(FD(k)) = False Then
                    ans1.Add(FD(k)) : ans2.Add(1)
                Else
                    ans2(ans1.IndexOf(FD(k))) += 1
                End If
            Next
            PrintLine(2, Trim(ans2.Max))
        Next
    End Sub
End Class

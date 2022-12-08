Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Dim a$ = LineInput(1)
        Do Until a = "0"
            Dim b$() = a.Split
            Dim x As New List(Of Integer)
            For k = 1 To UBound(b)
                x.Add(Val(b(k)))
            Next
            Dim ans As New List(Of String)
            QQ(x, "", 0, ans)
            For k = 0 To ans.Count - 1
                PrintLine(2, ans(k))
            Next
            PrintLine(2)
            a = LineInput(1)
        Loop
    End Sub
    Function QQ(ByVal x As List(Of Integer), ByVal y$, ByVal z%, ByVal ans As List(Of String))
        If z = 6 Then
            Dim o$() = Trim(y).Split
            Dim Q%(UBound(o))
            For i = 0 To UBound(Q)
                Q(i) = Val(o(i))
            Next
            Array.Sort(Q)
            For i = 0 To UBound(Q)
                o(i) = Q(i)
            Next
            If ans.Contains(Join(o, " ")) = False Then ans.Add(Trim(y))
        Else
            For i = 0 To x.Count - 1
                If InStr(y, x(i)) = 0 Then QQ(x, y & x(i) & " ", z + 1, ans)
            Next
        End If
    End Function
End Class

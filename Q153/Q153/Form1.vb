Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Dim a$ = LineInput(1)
        Do Until a = "#"
            Dim b As New List(Of String)
            For i = 1 To Len(a)
                b.Add(Mid(a, i, 1))
            Next
            b.Sort()
            Dim c$ = ""
            For i = 1 To b.Count
                c = c & Chr(i + 49)
            Next
            Dim ans% = 0
            Dim Ce As Boolean = False
            Dim rr As New List(Of String)
            QQ(c, "", ans, a, Ce, b, rr)
            Dim aans$ = ans
            Do Until Len(aans) = 10 : aans = " " & aans : Loop
            PrintLine(2, aans)
            a = LineInput(1)
        Loop
    End Sub
    Function QQ(ByVal x$, ByVal y$, ByRef ans%, ByVal che$, ByRef Ce As Boolean, ByVal b As List(Of String), ByRef RR As List(Of String))
        Dim a As Boolean = False
        If Len(x) = Len(y) Then
            Dim u$ = ""
            For k = 1 To Len(y)
                u = u & b(Asc(Mid(y, k, 1)) - 50)
            Next
            If RR.Contains(u) = False Then
                ans += 1
                If u = che Then Ce = True
                RR.Add(u)
            End If
        Else
            For i = 1 To Len(x)
                For j = 1 To Len(y)
                    If Mid(x, i, 1) = Mid(y, j, 1) Then a = True
                Next
                If a = False Then QQ(x, y & Mid(x, i, 1), ans, che, Ce, b, RR)
                If Ce = True Then Exit Function
                a = False
            Next
        End If
    End Function
End Class

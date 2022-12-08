Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Dim a$ = LineInput(1)
        Do Until a = "0 0"
            Dim b$() = a.Split
            Dim ST As New List(Of String)
            QQ(ST, b, 2, 0, "")
            PrintLine(2, "Sums of " & b(0) & ":")
            If ST.Count > 0 Then
                For i = 0 To ST.Count - 1 : PrintLine(2, ST(i)) : Next
            Else
                PrintLine(2, "NONE")
            End If
            a = LineInput(1)
        Loop
    End Sub
    Function QQ(ByVal ST As List(Of String), ByVal b$(), ByVal x%, ByVal sum%, ByVal ans$)
        If sum = Val(b(0)) Then
            If ST.Contains(ans.Trim("+")) = False Then ST.Add(ans.Trim("+"))
            Exit Function
        End If
        For i = x To UBound(b)
            QQ(ST, b, i + 1, sum + Val(b(i)), ans & b(i) & "+")
        Next
    End Function
End Class

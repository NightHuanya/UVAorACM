Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Do Until EOF(1) = True
            Dim a% = LineInput(1)
            If EOF(1) = True Then Exit Do
            Dim b$ = LineInput(1)
            Do Until b = "0"
                Dim c$() = b.Split
                Dim d As New Stack
                Dim x% = 0
                For k = 1 To a
                    d.Push(k)
                    If d.Peek = c(x) Then d.Pop() : x += 1
                    If d.Count <> 0 Then
                        Do Until d.Peek <> c(x)
                            d.Pop()
                            x += 1
                            If d.Count = 0 Then Exit Do
                        Loop
                    End If
                Next
                If d.Count > 0 Then PrintLine(2, "No") Else PrintLine(2, "Yes")
                b = LineInput(1)
            Loop
            PrintLine(2)
        Loop
    End Sub
End Class

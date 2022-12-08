Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Dim a% = LineInput(1)
        Do Until a = 0
            Dim ans As New List(Of String)
            Dim c = a
            If a < 0 Then ans.Add(-1) : a = a * -1
            Dim b% = 2
            Do Until a = 1
                If a Mod b = 0 Then
                    ans.Add(b) : a = a / b
                Else
                    b += 1
                End If
            Loop
            PrintLine(2, c & " = " & Join(ans.ToArray, " x "))
            a = LineInput(1)
        Loop
    End Sub
End Class

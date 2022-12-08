Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Dim a$ = LineInput(1)
        Dim z% = 1
        Do Until a = "0 0"
            Dim b$() = a.Split
            Dim student%(Val(b(0)))
            For i = 0 To UBound(student)
                student(i) = i
            Next
            Dim ans As New List(Of Integer)
            For i = 1 To Val(b(1))
                Dim c$() = LineInput(1).Split
                If student(Val(c(0))) <> student(Val(c(1))) Then
                    Dim x% = Math.Max(student(Val(c(0))), student(Val(c(1))))
                    Dim y% = Math.Min(student(Val(c(0))), student(Val(c(1))))
                    Do Until student.Contains(x) = False : student(Array.IndexOf(student, x)) = y : Loop
                End If
            Next
            For i = 1 To UBound(student)
                If ans.Contains(student(i)) = False Then ans.Add(student(i))
            Next
            PrintLine(2, "Case " & z & ": " & ans.Count)
            z += 1
            a = LineInput(1)
        Loop
    End Sub
End Class

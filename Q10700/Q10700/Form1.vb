Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Dim a% = LineInput(1)
        For i = 1 To a
            Dim b$ = LineInput(1)
            Dim c$() = b.Split("*")
            For j = 0 To UBound(c)
                Dim d$() = c(j).Split("+")
                For k = 1 To UBound(d)
                    d(0) = Val(d(0)) + Val(d(k))
                Next
                c(j) = d(0)
                If j <> 0 Then c(0) = Val(c(0)) * Val(c(j))
            Next
            Dim g$() = b.Split("+")
            For j = 0 To UBound(g)
                Dim d$() = g(j).Split("*")
                For k = 1 To UBound(d)
                    d(0) = Val(d(0)) * Val(d(k))
                Next
                g(j) = d(0)
                If j <> 0 Then g(0) = Val(g(0)) + Val(g(j))
            Next
            If InStr(c(0), "E") <> 0 Then
                Dim x% = Val(Mid(c(0), InStr(c(0), "+") + 1, Len(c(0)) - InStr(c(0), "+") + 1)) - (InStr(c(0), "E") - InStr(c(0), ".")) + 1
                Dim y$ = Mid(c(0), 1, InStr(c(0), "E") - 1).Replace(".", "")
                For k = 1 To x : y &= "0" : Next : c(0) = y
            End If
            If InStr(g(0), "E") <> 0 Then
                Dim x% = Val(Mid(g(0), InStr(g(0), "+") + 1, Len(g(0)) - InStr(g(0), "+") + 1)) - (InStr(g(0), "E") - InStr(g(0), ".")) + 1
                Dim y$ = Mid(g(0), 1, InStr(g(0), "E") - 1).Replace(".", "")
                For k = 1 To x : y &= "0" : Next : g(0) = y
            End If
            PrintLine(2, "The maximum and minimum are " & c(0) & " and " & g(0) & ".")
        Next
    End Sub
End Class

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim x$ = ""
        Dim x2$ = ""
        Dim x3$ = ""
        Dim x4$ = ""
        Dim x5$ = ""
        For i = 1 To 26
            x = x & Chr(96 + i) & " "
            For i2 = i + 1 To 26
                x2 = x2 & Chr(96 + i) & Chr(96 + i2) & " "
                For i3 = i2 + 1 To 26
                    x3 = x3 & Chr(96 + i) & Chr(96 + i2) & Chr(96 + i3) & " "
                    For i4 = i3 + 1 To 26
                        x4 = x4 & Chr(96 + i) & Chr(96 + i2) & Chr(96 + i3) & Chr(96 + i4) & " "
                        For i5 = i4 + 1 To 26
                            x5 = x5 & Chr(96 + i) & Chr(96 + i2) & Chr(96 + i3) & Chr(96 + i4) & Chr(96 + i5) & " "
                        Next
                    Next
                Next
            Next
        Next
        Dim cowu As New List(Of String)
        Dim y$() = Trim(x).Split
        For i = 0 To UBound(y)
            cowu.Add(y(i))
        Next
        y = Trim(x2).Split
        For i = 0 To UBound(y)
            cowu.Add(y(i))
        Next
        y = Trim(x3).Split
        For i = 0 To UBound(y)
            cowu.Add(y(i))
        Next
        y = Trim(x4).Split
        For i = 0 To UBound(y)
            cowu.Add(y(i))
        Next
        y = Trim(x5).Split
        For i = 0 To UBound(y)
            cowu.Add(y(i))
        Next
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Do Until EOF(1) = True
            Dim b$ = LineInput(1)
            If cowu.Contains(b) = False Then
                PrintLine(2, 0)
            Else
                PrintLine(2, cowu.IndexOf(b) + 1)
            End If
        Loop
    End Sub
End Class

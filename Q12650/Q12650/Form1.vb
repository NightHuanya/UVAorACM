Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a As String
        Dim b() As String
        Dim c, d, f, g As Integer

        Do Until EOF(1) = True

            a = LineInput(1)

            For i = 1 To Len(a)
                Select Case Mid(a, i, 1)
                    Case "0" To "9"
                        f = f & Mid(a, i, 1)
                    Case Else
                        c = f
                        f = 0
                End Select
            Next

            ReDim b(c)

            For j = 1 To c
                b(j) = j
            Next

            a = LineInput(1)

            For k = 1 To Len(a)
                Select Case Mid(a, k, 1)
                    Case "0" To "9"
                        d = d & Mid(a, k, 1)
                    Case Else
                        b(d) = ""
                        d = 0
                End Select
                If k = Len(a) Then
                    b(d) = ""
                    d = 0
                End If
            Next

            If f = c Then
                If EOF(1) <> True Then
                    PrintLine(2, "*")
                Else
                    Print(2, "*")
                End If
            Else
                For l = 1 To c
                    If g = 0 And b(l) <> "" Then
                        Print(2, b(l))
                        g = g + 1
                    ElseIf b(l) <> "" Then
                        Print(2, " " & b(l))
                    End If
                    If l = c And EOF(1) <> True Then
                        Print(2, vbNewLine)
                    End If
                Next
            End If
            c = 0
            d = 0
            f = 0
        Loop

    End Sub
End Class

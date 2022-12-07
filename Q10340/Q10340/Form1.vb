Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a, b, c As String
        Dim d, g As Long
        Dim f%
        f = 1
        d = 1
        g = 1
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Do Until EOF(1) = True
            a = LineInput(1)

            For i = 1 To Len(a)
                Select Case Mid(a, i, 1)
                    Case "a" To "z"
                        If f = 1 Then
                            b = b & Mid(a, i, 1)
                        Else
                            c = c & Mid(a, i, 1)
                        End If
                    Case "A" To "Z"
                        If f = 1 Then
                            b = b & Mid(a, i, 1)
                        Else
                            c = c & Mid(a, i, 1)
                        End If
                    Case Else
                        f = f + 1
                End Select
            Next

            For j = 1 To Len(b)
                For k = 1 To Len(c)

                    If Mid(b, j, 1) = Mid(c, d, 1) Then
                        d = d + 1
                        Exit For
                    Else
                        d = d + 1

                    End If

                    If k = Len(c) And EOF(1) = True Then
                        Print(2, "No")
                        g = g + 1
                        Exit For
                    ElseIf k = Len(c) Then
                        PrintLine(2, "No")
                        g = g + 1
                        Exit For
                    End If
                Next
                If g <> 1 Then
                    Exit For
                End If
                If j = Len(b) And EOF(1) = True Then
                    Print(2, "Yes")
                ElseIf j = Len(b) Then
                    PrintLine(2, "Yes")
                End If
            Next
            b = ""
            c = ""
            d = 1
            f = 1
            g = 1


        Loop

    End Sub
End Class

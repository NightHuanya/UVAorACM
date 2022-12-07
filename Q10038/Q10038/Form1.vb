Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim c, d, f As Integer
        Dim b$, a$

        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Do Until EOF(1) = True

            b = LineInput(1)

            For i = 1 To Len(b) - 2

                Select Case Mid(b, 2 + i, 1)
                    Case "0" To "9"
                        a = a & Mid(b, 2 + i, 1)
                    Case "-"
                        a = Mid(b, 2 + i, 1) & a
                    Case Else

                        If i > 2 Then
                            f = ((Val(a) - d) ^ 2) ^ 0.5
                        End If

                        d = Val(a)
                        a = ""

                        If i > 2 And c <> 0 And f <> 0 Then
                            If (f - c) ^ 2 ^ 0.5 <> 1 Then
                                If EOF(1) <> True Then
                                    PrintLine(2, "Not jolly")
                                    Exit For
                                Else
                                    Print(2, "Not jolly")
                                    Exit For
                                End If

                            End If

                        End If
                        If i > 4 And f > c And EOF(1) <> True Then
                            PrintLine(2, "Not jolly")
                            Exit For
                        ElseIf i > 4 And f > c And EOF(1) = True Then
                            Print(2, "Not jolly")
                            Exit For
                        End If
                        c = f

                End Select

                If i = Len(b) - 2 Then
                    f = ((Val(a) - d) ^ 2) ^ 0.5
                    If (f - c) ^ 2 ^ 0.5 <> 1 Then
                        If EOF(1) <> True Then
                            PrintLine(2, "Not jolly")
                            Exit For
                        Else
                            Print(2, "Not jolly")
                            Exit For
                        End If
                    End If
                    If i > 4 And f > c And EOF(1) <> True Then
                        PrintLine(2, "Not jolly")
                        Exit For
                    ElseIf i > 4 And f > c And EOF(1) = True Then
                        Print(2, "Not jolly")
                        Exit For
                    End If
                End If

                If i = Len(b) - 2 And EOF(1) <> True Then
                    PrintLine(2, "jolly")
                ElseIf i = Len(b) - 2 Then
                    Print(2, "jolly")
                End If

            Next
            d = 0
            a = ""
            f = 0
            c = 0

        Loop


    End Sub
End Class

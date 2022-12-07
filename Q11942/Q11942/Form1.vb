Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c, f, g, h As Integer
        Dim d$
        Dim z As Boolean
        z = False
        PrintLine(2, "Lumberjacks:")
        a = LineInput(1)

        For i = 1 To a

            d = LineInput(1)

            For j = 1 To Len(d)

                Select Case Mid(d, j, 1)
                    Case "0" To "9"
                        b = b & Mid(d, j, 1)
                    Case Else
                        f = f + 1
                        If f > 1 Then
                            If c > b And h < 1 Then
                                g = g + 1
                            ElseIf c < b And g < 1 Then
                                h = h + 1
                            Else
                                If i = a Then
                                    Print(2, "Unordered")
                                Else
                                    PrintLine(2, "Unordered")
                                End If
                                z = True
                            End If
                        End If


                        c = b
                        b = 0

                End Select
                If j = Len(d) Then
                    If c > b And h < 1 Then
                        g = g + 1
                    ElseIf c < b And g < 1 Then
                        h = h + 1
                    Else
                        If i = a Then
                            Print(2, "Unordered")
                        Else
                            PrintLine(2, "Unordered")
                        End If
                        z = True
                    End If
                End If

                If z = True Then
                    Exit For
                End If

            Next

            If z = False Then
                If i = a Then
                    Print(2, "Ordered")
                Else
                    PrintLine(2, "Ordered")
                End If
            End If

            z = False
            f = 0
            g = 0
            h = 0
            b = 0
            c = 0

        Next





    End Sub
End Class

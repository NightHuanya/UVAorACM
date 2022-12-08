Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)
        Dim a, b, h As Long
        Dim d$
        Dim c As Boolean = False
        Dim f As Boolean = False
        Dim g As Boolean = False
        h = 2000000
        a = LineInput(1)
        Do Until a = 0
            d = LineInput(1)
            For i = 1 To a
                If Mid(d, i, 1) = "Z" Then
                    h = 0
                    Exit For
                ElseIf Mid(d, i, 1) = "R" Then
                    If c = False Then
                        c = True
                        b = 1
                        f = True
                    Else
                        If g = False Then
                            b = 1
                        Else
                            If b < h Then
                                h = b
                            End If
                            g = False
                            f = True
                            b = 1
                        End If
                        End If
                ElseIf Mid(d, i, 1) = "D" Then
                        If c = False Then
                            c = True
                            b = 1
                            g = True
                        Else
                            If f = False Then
                            b = 1
                        Else
                            If b < h Then
                                h = b
                            End If
                            f = False
                            g = True
                            b = 1
                        End If
                        End If
                ElseIf Mid(d, i, 1) = "." Then
                        If c = True Then b = b + 1
                End If
            Next
            c = False
            f = False
            g = False
            a = LineInput(1)
            If a = 0 Then
                Print(2, h)
            Else
                PrintLine(2, h)
            End If
            b = 0
            h = 2000000
        Loop
    End Sub
End Class

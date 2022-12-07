Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b As String
        Dim c, d As Long
        Dim f, g As Boolean
        g = False
        a = LineInput(1)
        Do Until a = "~"
            For i = 1 To Len(a)
                Select Case Mid(a, i, 1)
                    Case "0"
                        c = c + 1
                    Case "#"
                        g = True
                    Case Else
                        If c = 1 Then
                            f = True
                        ElseIf c = 2 Then
                            f = False
                        Else
                            If f = True Then
                                For j = 1 To c - 2
                                    b = 1 & b
                                Next
                            Else
                                For j = 1 To c - 2
                                    b = 0 & b
                                Next
                            End If
                        End If
                        c = 0
                End Select
            Next
            a = LineInput(1)
            If g = True Then
                For k = 0 To Len(b) - 1
                    d = d + Val(Mid(b, k + 1, 1)) * 2 ^ k
                Next
                If a = "~" Then
                    Print(2, d)
                Else
                    PrintLine(2, d)
                End If
                b = ""
                c = 0
                d = 0
                g = False
            End If

        Loop

    End Sub
End Class

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a As String
        Dim b, c, d, f, g As Integer
        g = 1000
        a = LineInput(1)
        Do Until a = "0 0"
            For i = 1 To Len(a)
                Select Case Mid(a, i, 1)
                    Case "0" To "9"
                        c = c & Mid(a, i, 1)
                    Case Else
                        b = c
                        c = 0
                End Select
            Next
            d = b
            For j = 1 To b
                For k = 1 To j
                    If k <> j And j Mod k = 0 And k <> 1 Then
                        Exit For
                    ElseIf k = j And k <> 1 Then
                        Do
                            d = d + k
                            f = f + 1
                            If d = c Then
                                If g > f Then
                                    g = f
                                End If
                                f = 0
                                Exit Do
                            ElseIf d > c Then
                                f = 0
                                Exit Do
                            End If
                        Loop
                    End If
                Next
                d = b
                If j = b And g = 1000 Then
                    g = -1
                End If
            Next
            a = LineInput(1)
            If EOF(1) = True Then
                Print(2, "Case 1: " & g)
            Else
                PrintLine(2, "Case 1: " & g)
            End If
            b = 0
            c = 0
            d = 0
            f = 0
            g = 1000
        Loop

    End Sub
End Class

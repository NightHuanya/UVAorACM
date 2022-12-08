Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c As String
        Dim d As Long
        Dim f As Boolean = False
        a = LineInput(1)
        Do Until a = "."

            For i = 1 To Len(a)
                b = b & Mid(a, i, 1)

                For j = 1 To Len(a)
                    c = c & b
                    d = d + 1
                    If c = a Then
                        f = True
                        Exit For
                    ElseIf Len(c) > Len(a) Then
                        c = ""
                        d = 0
                        Exit For
                    End If
                    If j = Len(a) Then
                        c = ""
                        d = 0
                    End If
                Next

                If f = True Then
                    f = False
                    Exit For
                End If

            Next
            a = LineInput(1)
            If EOF(1) = True Then
                Print(2, d)
            Else
                PrintLine(2, d)
            End If

            b = ""
            c = ""
            d = 0
        Loop

    End Sub
End Class

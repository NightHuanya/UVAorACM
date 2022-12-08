Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c, d As String
        Dim f As Boolean = False
        a = LineInput(1)

        For i = 1 To Val(a)

            b = LineInput(1)

            For j = 1 To Len(b)

                Select Case Mid(b, j, 1)
                    Case "0" To "9"
                        c = c & Mid(b, j, 1)
                    Case Else
                        d = c
                        c = ""
                End Select

            Next

            For k = 1 To Val(d)
                For l = 1 To Val(d)
                    If l - k = Val(c) And l + k = Val(d) Then
                        If i = Val(a) Then
                            Print(2, l & Space(1) & k)
                        Else
                            PrintLine(2, l & Space(1) & k)
                        End If
                        f = True
                        Exit For
                    End If
                Next
                If f = True Then
                    f = False
                    Exit For
                End If
                If k > Val(d) / 2 Then
                    If i = Val(a) Then
                        Print(2, "impossible")
                    Else
                        PrintLine(2, "impossible")
                    End If
                    Exit For
                End If
            Next

            c = ""

        Next

    End Sub
End Class

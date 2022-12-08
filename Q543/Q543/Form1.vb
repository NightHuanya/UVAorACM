Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)
        Dim a, b, c, f As Long
        Dim d As Boolean = False
        f = LineInput(1)
        a = f
        Do Until f = 0
            For i = a To 3 Step -1
                For j = 2 To i - 1
                    If i Mod j = 0 Then
                        Exit For
                    End If
                    If j = i - 1 Then
                        For k = 2 To (a - i) - 1
                            If (a - i) Mod k = 0 Then
                                Exit For
                            End If
                            If k = (a - i) - 1 Then
                                b = i
                                c = a - i
                                d = True
                            End If
                            If d = True Then Exit For
                        Next
                    End If
                    If d = True Then Exit For
                Next
                If d = True Then
                    Exit For
                End If
            Next

            f = LineInput(1)
            If d = False Then
                If f = 0 Then
                    Print(2, "Goldbach's conjecture is wrong.")
                Else
                    PrintLine(2, "Goldbach's conjecture is wrong.")
                End If
            End If
            If d = True Then
                If f = 0 Then
                    Print(2, a & " = " & c & " + " & b)
                Else
                    PrintLine(2, a & " = " & c & " + " & b)
                End If
            End If
            a = f
            b = 0
            c = 0
            d = False
        Loop

    End Sub
End Class

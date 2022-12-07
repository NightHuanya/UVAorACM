Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim a$
        Dim c, d, f, j, k As Integer
        Dim b As String

        f = 1

        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)



        Do Until EOF(1) = True

            a = LineInput(1)



            For i = 1 To Len(a)
                b = Mid(a, i, 1)
                If b <> " " Then
                    j = j & b

                Else
                    c = j
                    j = 0
                End If
            Next

            If c < j Then

                For g = c To j
                    d = g
                    For h = 1 To f


                        If d = 1 Then
                            Exit For
                        ElseIf d Mod 2 <> 0 Then
                            d = 3 * d + 1
                        Else
                            d = d / 2
                        End If

                        f = f + 1
                        h = h - 1

                    Next
                    If f > k Then
                        k = f
                    End If

                    f = 1

                Next
                PrintLine(2, a & Space(1) & k)
                j = 0
            Else
                For g = j To c
                    d = g
                    For h = 1 To f


                        If d = 1 Then
                            Exit For
                        ElseIf d Mod 2 <> 0 Then
                            d = 3 * d + 1
                        Else
                            d = d / 2
                        End If

                        f = f + 1
                        h = h - 1

                    Next
                    If f > k Then
                        k = f
                    End If

                    f = 1

                Next
                PrintLine(2, a & Space(1) & k)
                j = 0
            End If
            k = 0
        Loop







    End Sub
End Class

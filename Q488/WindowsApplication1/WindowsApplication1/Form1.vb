Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a, c, d As Integer
        Dim b$

        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        a = LineInput(1)

        For i = 1 To a

            b = LineInput(1)

            d = LineInput(1)

            c = LineInput(1)

            For j = 1 To c

                For k = 1 To d

                    For l = 1 To k
                        If l = k Then
                            PrintLine(2, k)
                        Else
                            Print(2, k)
                        End If
                        
                    Next

                    If k = d Then
                        For m = k - 1 To 1 Step -1
                            For n = m To 1 Step -1
                                If n = 1 Then
                                    PrintLine(2, m)
                                Else
                                    Print(2, m)
                                End If


                            Next

                        Next
                    End If



                Next
                If j <> c Then
                    Print(2, vbNewLine)
                End If
            Next

        Next
    End Sub
End Class

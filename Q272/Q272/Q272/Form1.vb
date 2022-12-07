Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)
        Dim a As String
        Dim b%
        b = 1

        Do Until EOF(1) = True

            a = LineInput(1)

            For i = 1 To Len(a)

                If Mid(a, i, 1) = Chr(34) Then

                    If b Mod 2 <> 0 Then

                        If i = Len(a) Then
                            PrintLine(2, "``")
                        Else
                            Print(2, "``")
                        End If
                    Else
                        If i = Len(a) Then
                            PrintLine(2, "''")
                        Else
                            Print(2, "''")
                        End If
                    End If
                Else
                    If i = Len(a) Then
                        PrintLine(2, Mid(a, i, 1))
                    Else
                        Print(2, Mid(a, i, 1))
                    End If
                    b = b + 1
                End If
            Next
        Loop




    End Sub
End Class

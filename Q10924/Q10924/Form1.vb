Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a As Long
        Dim c As String
        Dim b As Boolean = False

        Do Until EOF(1) = True

            c = LineInput(1)
            For i = 1 To Len(c)
                Select Case Mid(c, i, 1)
                    Case "a" To "z"
                        a = a + Asc(Mid(c, i, 1)) - 96
                    Case "A" To "Z"
                        a = a + Asc(Mid(c, i, 1)) - 38
                End Select
            Next

            For i = 2 To a \ 2
                If a Mod i = 0 Then
                    b = True
                    Exit For
                End If
            Next

            If EOF(1) <> True Then
                If b = True Then
                    PrintLine(2, "It is not a prime word.")
                Else
                    PrintLine(2, "It is a prime word.")
                End If
            Else
                If b = True Then
                    Print(2, "It is not a prime word.")
                Else
                    Print(2, "It is a prime word.")
                End If
            End If

            a = 0
            b = False

        Loop

    End Sub
End Class

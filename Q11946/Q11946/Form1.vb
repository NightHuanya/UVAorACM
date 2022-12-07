Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b As Integer
        Dim c, d As String

        a = LineInput(1)

        For i = 1 To a
            c = LineInput(1)
            Do

                For j = 1 To Len(c)
                    Select Case Mid(c, j, 1)
                        Case "0"
                            d = d & "O"
                        Case "1"
                            d = d & "I"
                        Case "2"
                            d = d & "Z"
                        Case "3"
                            d = d & "E"
                        Case "4"
                            d = d & "A"
                        Case "5"
                            d = d & "S"
                        Case "6"
                            d = d & "G"
                        Case "7"
                            d = d & "T"
                        Case "8"
                            d = d & "B"
                        Case "9"
                            d = d & "P"
                        Case Else
                            d = d & Mid(c, j, 1)
                    End Select
                Next

                If EOF(1) <> True Then
                    PrintLine(2, d)
                    d = ""
                Else
                    Print(2, d)
                    Exit Do
                End If
                c = LineInput(1)
            Loop Until c = vbNewLine

        Next

    End Sub
End Class

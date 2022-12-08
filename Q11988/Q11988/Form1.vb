Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c As String
        Dim d As Integer = 0
        Do Until EOF(1) = True

            a = LineInput(1)

            For i = 1 To Len(a)
                Select Case Mid(a, i, 1)
                    Case "a" To "z"
                        If d = 0 Then
                            b = b & Mid(a, i, 1)
                        Else
                            c = c & Mid(a, i, 1)
                        End If
                    Case "A" To "Z"
                        If d = 0 Then
                            b = b & Mid(a, i, 1)
                        Else
                            c = c & Mid(a, i, 1)
                        End If
                    Case "_"
                        If d = 0 Then
                            b = b & Mid(a, i, 1)
                        Else
                            c = c & Mid(a, i, 1)
                        End If
                    Case "["
                        If d = 2 Then
                            b = b & c
                        ElseIf d = 1 Then
                            b = c & b
                        End If
                        c = ""
                        d = 1
                    Case "]"
                        If d = 2 Then
                            b = b & c
                        ElseIf d = 1 Then
                            b = c & b
                        End If
                        c = ""
                        d = 2
                End Select

                If i = Len(a) Then

                    If d = 2 Then
                        b = b & c
                    ElseIf d = 1 Then
                        b = c & b
                    End If
                    c = ""
                End If

            Next

            If EOF(1) = True Then
                Print(2, b)
            Else
                PrintLine(2, b)
            End If

            b = ""
            d = 0

        Loop

    End Sub
End Class

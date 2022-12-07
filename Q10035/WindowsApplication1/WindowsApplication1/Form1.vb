Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)


        Dim a, b, c, d As String
        Dim f, g As Integer
        a = LineInput(1)
        Do
            f = 0

            If a = "0 0" Then
                Exit Do
            End If

            For i = 1 To Len(a)

                If Mid(a, i, 1) <> " " Then
                    b = b & Mid(a, i, 1)
                Else
                    g = i + 1
                    Exit For
                End If

            Next

            For k = g To Len(a)

                c = c & Mid(a, k, 1)
            Next

            d = Val(b) + Val(c)

            For j = Len(d) To 1 Step -1
                If Val(Mid(d, j, 1)) < Val(Mid(b, j, 1)) Then

                    f = f + 1

                End If

            Next

            b = ""
            c = ""
            a = LineInput(1)

            If f = 0 And EOF(1) = True Then
                Print(2, "No carry operation.")
            ElseIf f = 1 And EOF(1) = True Then
                Print(2, f & " carry operation.")
            ElseIf f > 1 And EOF(1) = True Then
                Print(2, f & " carry operations.")
            ElseIf f = 0 Then
                PrintLine(2, "No carry operation.")
            ElseIf f = 1 Then
                PrintLine(2, f & " carry operation.")
            Else
                PrintLine(2, f & " carry operations.")
            End If



        Loop


    End Sub
End Class

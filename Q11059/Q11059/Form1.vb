Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, g, h, z As Long
        Dim c, f As String
        Dim d()
        b = 1
        z = 1
        Do Until EOF(1) = True

            a = LineInput(1)
            ReDim d(a)
            c = LineInput(1)
            For i = 1 To Len(c)
                Select Case Mid(c, i, 1)
                    Case "0" To "9"
                        f = f & Mid(c, i, 1)
                    Case "-"
                        f = Mid(c, i, 1) & f
                    Case Else
                        d(b) = Val(f)
                        f = ""
                        b = b + 1
                End Select

                If i = Len(c) Then
                    d(b) = Val(f)
                End If
            Next
            g = d(1)
            For i = 2 To a
                g = g * d(i)
                If g > h Then
                    h = g
                End If
            Next
            g = d(a)
            For i = a - 1 To 1 Step -1
                g = g * d(i)
                If g > h Then
                    h = g
                End If
            Next

            If EOF(1) <> True Then
                LineInput(1)
            End If

            If EOF(1) = True Then
                Print(2, "Case #" & z & ": The maximum product is " & h & ".")
            Else
                PrintLine(2, "Case #" & z & ": The maximum product is " & h & "." & vbNewLine)
            End If
            f = ""
            b = 1
            g = 0
            h = 0
            z = z + 1
        Loop




    End Sub
End Class

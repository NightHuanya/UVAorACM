Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Do Until EOF(1) = True
            Dim a$ = LineInput(1)
            Dim ans$ = ""
            Select Case Mid(a, 1, 1)
                Case "0" To "9"
                    Dim b% = Val(a)
                    Do Until b = 0
                        If b - 1000 >= 0 Then
                            b = b - 1000 : ans &= "M"
                        ElseIf b - 900 >= 0 Then
                            b = b - 900 : ans &= "CM"
                        ElseIf b - 500 >= 0 Then
                            b = b - 500 : ans &= "D"
                        ElseIf b - 400 >= 0 Then
                            b = b - 400 : ans &= "CD"
                        ElseIf b - 100 >= 0 Then
                            b = b - 100 : ans &= "C"
                        ElseIf b - 90 >= 0 Then
                            b = b - 90 : ans &= "XC"
                        ElseIf b - 50 >= 0 Then
                            b = b - 50 : ans &= "L"
                        ElseIf b - 40 >= 0 Then
                            b = b - 40 : ans &= "XL"
                        ElseIf b - 10 >= 0 Then
                            b = b - 10 : ans &= "X"
                        ElseIf b - 9 >= 0 Then
                            b = b - 9 : ans &= "IX"
                        ElseIf b - 5 >= 0 Then
                            b = b - 5 : ans &= "V"
                        ElseIf b - 4 >= 0 Then
                            b = b - 4 : ans &= "IV"
                        ElseIf b - 1 >= 0 Then
                            b = b - 1 : ans &= "I"
                        End If
                    Loop
                Case Else
                    ans = "0"
                    Dim b% = 0, c% = 0
                    For k = 1 To Len(a) - 1
                        Select Case Mid(a, k, 1)
                            Case "M"
                                b = 1000
                            Case "D"
                                b = 500
                            Case "C"
                                b = 100
                            Case "L"
                                b = 50
                            Case "X"
                                b = 10
                            Case "V"
                                b = 5
                            Case "I"
                                b = 1
                        End Select
                        Select Case Mid(a, k + 1, 1)
                            Case "M"
                                c = 1000
                            Case "D"
                                c = 500
                            Case "C"
                                c = 100
                            Case "L"
                                c = 50
                            Case "X"
                                c = 10
                            Case "V"
                                c = 5
                            Case "I"
                                c = 1
                        End Select
                        If b >= c Then ans = Val(ans) + b Else ans = Val(ans) - b
                        If k = Len(a) - 1 Then ans = Val(ans) + c
                    Next
            End Select
            PrintLine(2, ans)
        Loop
    End Sub
End Class

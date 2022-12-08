Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Do Until EOF(1) = True
            Dim a$ = Trim(LineInput(1))
            Dim b$ = a.Replace(" ", "").Replace("-", "")
            Dim ans$ = ""
            If InStr(a, " ") <> 0 Then ans &= a & " is incorrect."
            If Len(b) > 10 Then If ans = "" Then ans &= a & " is incorrect."
            b = b.Replace("X", "10")
            For k = 1 To Len(b)
                If Asc(Mid(b, k, 1)) < 48 Or Asc(Mid(b, k, 1)) > 57 Then
                    If ans = "" Then ans &= a & " is incorrect."
                    Exit For
                End If
            Next
            If ans = "" Then
                If Mid(b, Len(b) - 1, 2) = "10" And Len(b) = 11 Then
                    Dim x%(10)
                    For k = 1 To 9
                        x(k) += Val(Mid(b, k, 1))
                    Next
                    x(10) = 10
                    For k = 2 To 10
                        x(k) = x(k) + x(k - 1)
                    Next
                    For k = 2 To 10
                        x(k) = x(k) + x(k - 1)
                    Next
                    If x(10) Mod 11 = 0 Then ans &= a & " is correct." Else ans &= a & " is incorrect."
                Else
                    Dim x%(10)
                    For k = 1 To 10
                        x(k) += Val(Mid(b, k, 1))
                    Next
                    For k = 2 To 10
                        x(k) = x(k) + x(k - 1)
                    Next
                    For k = 2 To 10
                        x(k) = x(k) + x(k - 1)
                    Next
                    If x(10) Mod 11 = 0 Then ans &= a & " is correct." Else ans &= a & " is incorrect."
                End If
            End If
            PrintLine(2, ans)
        Loop
    End Sub
End Class

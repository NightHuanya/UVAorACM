Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)
        Dim a As Long
        a = LineInput(1)
        Dim b As String
        Dim c, d As Integer
        Dim f As Date
        For i = 1 To a
            b = LineInput(1)
            For j = 1 To Len(b)
                Select Case Mid(b, j, 1)
                    Case "0" To "9"
                        d = d & Mid(b, j, 1)
                    Case Else
                        c = d
                        d = 0
                End Select
            Next
            b = "#" & c & "/" & d & "/2011#"
            f = b
            b = f.DayOfWeek
            Select Case b
                Case 1
                    b = "Monday"
                Case 2
                    b = "Tuesday"
                Case 3
                    b = "Wednesday"
                Case 4
                    b = "Thursday"
                Case 5
                    b = "Friday"
                Case 6
                    b = "Saturday"
                Case 0
                    b = "Sunday"
            End Select
            If a = i Then
                Print(2, b)
            Else
                PrintLine(2, b)
            End If
            c = 0
            d = 0
        Next
    End Sub
End Class

Option Explicit On
Option Strict On
Option Infer Off
'Will Eberhard 3d1


Public Class Form1

    Private dblWholesale() As Double = {17.5, 9, 10.5, 18.75, 26, 8.5, 5.65, 12.25, 10, 30}


    Private Sub btnDisplayDays_Click(sender As Object, e As EventArgs) Handles btnDisplayDays.Click
        Dim intDaysInMonth() As Integer = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}
        Dim intMonth As Integer
        Integer.TryParse(txtMonth.Text, intMonth)

        If intMonth = 1 Then
            lblDays.Text = intDaysInMonth(0).ToString
        ElseIf intMonth = 2 Then
            lblDays.Text = intDaysInMonth(1).ToString
        ElseIf intMonth = 3 Then
            lblDays.Text = intDaysInMonth(2).ToString
        ElseIf intMonth = 4 Then
            lblDays.Text = intDaysInMonth(3).ToString
        ElseIf intMonth = 5 Then
            lblDays.Text = intDaysInMonth(4).ToString
        ElseIf intMonth = 6 Then
            lblDays.Text = intDaysInMonth(5).ToString
        ElseIf intMonth = 7 Then
            lblDays.Text = intDaysInMonth(6).ToString
        ElseIf intMonth = 8 Then
            lblDays.Text = intDaysInMonth(7).ToString
        ElseIf intMonth = 9 Then
            lblDays.Text = intDaysInMonth(8).ToString
        ElseIf intMonth = 10 Then
            lblDays.Text = intDaysInMonth(9).ToString
        ElseIf intMonth = 11 Then
            lblDays.Text = intDaysInMonth(10).ToString
        ElseIf intMonth = 12 Then
            lblDays.Text = intDaysInMonth(11).ToString
        Else
            MessageBox.Show("You did something wrong", "Try again")
        End If

        txtMonth.Focus()
        txtMonth.SelectAll()
    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        Dim intSold() As Integer = {250, 225, 193, 260}
        Dim intHighSub As Integer = intSold.GetUpperBound(0)
        Dim dblAvgTotal As Double = 0
        Dim avgCount As Integer = 0

        'clear labels
        lblAvg.Text = String.Empty
        lblLessAvg.Text = String.Empty

        For Count As Integer = 0 To intHighSub
            dblAvgTotal += intSold(Count)
            avgCount += 1
        Next Count
        'does the math
        dblAvgTotal = dblAvgTotal / avgCount
        'display
        lblAvg.Text = dblAvgTotal.ToString

        'Checks if one of the array numbers is less than the total
        For count As Integer = 0 To intHighSub
            If intSold(count) < dblAvgTotal Then
                lblLessAvg.Text &= intSold(count).ToString & ", "
            End If
        Next count
        'Removes extra comma at the end
        If lblLessAvg.Text.EndsWith(", ") Then
            lblLessAvg.Text = lblLessAvg.Text.Substring(0, lblLessAvg.Text.Length - 2)
        End If
    End Sub

    Private Sub btnForEachNext_Click(sender As Object, e As EventArgs) Handles btnForEachNext.Click
        'clear labels
        lblAvg.Text = String.Empty
        lblLessAvg.Text = String.Empty

        Dim intSold() As Integer = {250, 225, 193, 260}
        Dim dblAvgTotal As Double = 0
        Dim avgCount As Integer = 0

        For Each count As Integer In intSold
            dblAvgTotal += count
            avgCount += 1
        Next count

        dblAvgTotal = dblAvgTotal / avgCount
        lblAvg.Text = dblAvgTotal.ToString

        For Each count As Integer In intSold
            If count < dblAvgTotal Then
                lblLessAvg.Text &= count.ToString & ", "
            End If
        Next count

        'Removes extra comma at the end
        If lblLessAvg.Text.EndsWith(", ") Then
            lblLessAvg.Text = lblLessAvg.Text.Substring(0, lblLessAvg.Text.Length - 2)
        End If
    End Sub

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        'clear labels
        lblAvg.Text = String.Empty
        lblLessAvg.Text = String.Empty

        Dim intSold() As Integer = {250, 225, 193, 260}
        Dim dblAvgTotal As Double = 0
        Dim avgCount As Integer = 0
        Dim intHighSub As Integer = intSold.GetUpperBound(0)

        Do While avgCount <= intHighSub
            dblAvgTotal += intSold(avgCount)
            avgCount += 1
        Loop

        dblAvgTotal = dblAvgTotal / avgCount
        lblAvg.Text = dblAvgTotal.ToString

        Dim doCount As Integer = 0
        Do While doCount < intHighSub
            doCount += 1
            If intSold(doCount) < dblAvgTotal Then
                lblLessAvg.Text &= intSold(doCount).ToString & ", "
            End If

        Loop

        'Removes extra comma at the end
        If lblLessAvg.Text.EndsWith(", ") Then
            lblLessAvg.Text = lblLessAvg.Text.Substring(0, lblLessAvg.Text.Length - 2)
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fill lstWholesale with array values

        For intSub As Integer = 0 To dblWholesale.GetUpperBound(0)
            lstWholesale.Items.Add(dblWholesale(intSub).ToString("n2").PadLeft(6))
        Next intSub
    End Sub

    Private Sub btnWholesale_Click(sender As Object, e As EventArgs) Handles btnWholesale.Click
        ' returns array to the original wholesale prices

        For intSub As Integer = 0 To dblWholesale.GetUpperBound(0)
            dblWholesale(intSub) = Convert.ToDouble(lstWholesale.Items(intSub))
        Next intSub
        lstRetail.Items.Clear()
    End Sub

    Private Sub btnRetail_Click(sender As Object, e As EventArgs) Handles btnRetail.Click
        lstRetail.Items.Clear()
        Dim strInput As String
        Dim intInput As Double
        Dim dblTotal As Double = 0

        strInput = InputBox("Multiply price by percentage", "Mark Up Price", "10")
        Double.TryParse(strInput, intInput)

        intInput = intInput / 100
        intInput = intInput + 1

        For intSub As Integer = 0 To dblWholesale.GetUpperBound(0)
            dblTotal = dblWholesale(intSub) * intInput
            lstRetail.Items.Add(dblTotal.ToString("n2").PadLeft(6))
        Next intSub

    End Sub
End Class

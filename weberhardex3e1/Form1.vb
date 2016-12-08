Option Explicit On
Option Strict On
Option Infer Off
'Will Eberhard 3e1 12/8/2016

Public Class Form1
    Private intCommission() As Integer = {300, 500, 200, 150, 600, 750, 900, 150, 100, 200, 250, 650, 300, 750, 800, 350, 250, 150, 100, 300}

    Private Sub cboSearchRange_TextChanged(sender As Object, e As EventArgs) Handles cboSearchRanges.TextChanged
        lblRangeCount.Text = String.Empty
        Dim intSearchMin As Integer = 0
        Dim intSearchMax As Integer = 0
        Dim intHyphenIndex As Integer = cboSearchRanges.Text.IndexOf("-")
        If intHyphenIndex >= 0 AndAlso cboSearchRanges.Text.Length > intHyphenIndex + 1 Then
            Dim strSearchMin As String = cboSearchRanges.Text.Substring(0, intHyphenIndex).Trim()
            Dim strSearchMax As String = cboSearchRanges.Text.Substring(intHyphenIndex + 1).Trim()
            Int32.TryParse(strSearchMin, intSearchMin)
            Int32.TryParse(strSearchMax, intSearchMax)
            If intSearchMax >= intSearchMin Then
                lblRangeCount.Text = CountRange(intSearchMin, intSearchMax).ToString
            End If
        End If

    End Sub

    Private Sub cboSearchValue_TextChanged(sender As Object, e As EventArgs) Handles cboSearchValue.TextChanged
        Dim intValueCount As Integer

        lblValue.Text = CountValue(intValueCount).ToString
    End Sub

    Private Sub DisplayCommissions()
        For Each count As Integer In intCommission
            lblCommission.Text &= count.ToString & ", "
        Next count

        'Removes extra comma at the end
        If lblCommission.Text.EndsWith(", ") Then
            lblCommission.Text = lblCommission.Text.Substring(0, lblCommission.Text.Length - 2)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        DisplayCommissions()
        cboSearchRanges.SelectedIndex = 0
        cboSearchValue.SelectedIndex = 0
    End Sub

    Private Function CountValue(intSearchValue As Integer) As Integer
        Integer.TryParse(cboSearchValue.Text, intSearchValue)
        Dim intValueCount As Integer = 0

        For Each count As Integer In intCommission
            If count = intSearchValue Then
                intValueCount += 1
            End If
        Next count
        Return intValueCount
    End Function

    Private Function CountRange(intSearchMin As Integer, intSearchMax As Integer) As Integer
        Dim intRangeCount As Integer = 0

        For Each count As Integer In intCommission
            If count >= intSearchMin AndAlso count <= intSearchMax Then
                intRangeCount += 1
            End If
        Next count
        Return intRangeCount
    End Function
End Class

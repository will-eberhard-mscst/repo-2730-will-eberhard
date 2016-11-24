Option Strict On
Option Explicit On
Option Infer Off

Public Class Form1
    Private Sub btnPreWhile_Click(sender As Object, e As EventArgs) Handles btnPreWhile.Click
        lblEven.Text = "Pretest Do While" & ControlChars.NewLine
        Dim intEven As Integer = 2
        Do While intEven <= 20
            lblEven.Text = lblEven.Text & intEven.ToString & ControlChars.NewLine
            intEven += 2
        Loop
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblEven.Text = "Pretest Do Until" & ControlChars.NewLine
        Dim intEven As Integer = 2
        Do Until intEven > 20
            lblEven.Text = lblEven.Text & intEven.ToString & ControlChars.NewLine
            intEven += 2
        Loop
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lblEven.Text = "Posttest Loop While" & ControlChars.NewLine
        Dim intEven As Integer = 2
        Do
            lblEven.Text = lblEven.Text & intEven.ToString & ControlChars.NewLine
            intEven += 2
        Loop While intEven <= 20
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lblEven.Text = "Posttest Loop Until" & ControlChars.NewLine
        Dim intEven As Integer = 2
        Do
            lblEven.Text = lblEven.Text & intEven.ToString & ControlChars.NewLine
            intEven += 2
        Loop Until intEven > 20

    End Sub

    Private Sub btnFor_Click(sender As Object, e As EventArgs) Handles btnFor.Click
        lblEven.Text = "Pretest For" & ControlChars.NewLine
        For intEven As Integer = 2 To 20 Step +2
            lblEven.Text = lblEven.Text & intEven.ToString & ControlChars.NewLine
        Next intEven
    End Sub

    Private Sub btnSumWhile_Click(sender As Object, e As EventArgs) Handles btnSumWhile.Click
        txtList.Text = String.Empty
        lblAvg.Text = String.Empty
        lblCount.Text = String.Empty

        Const strPrompt As String = "Enter a Number. " & ControlChars.NewLine & "Click Cancel or leave blank to end."
        Const strTitle As String = "Number Entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double

        'get first sales
        strNum = InputBox(strPrompt, strTitle, "0")

        Do While strNum <> String.Empty
            Int32.TryParse(strNum, intNum)

            'display in txtbox
            txtList.Text = txtList.Text & intNum.ToString & ControlChars.NewLine
            'update counter
            intCount += 1
            intSum = intSum + intNum

            strNum = InputBox(strPrompt, strTitle, "0")
        Loop

        lblCount.Text = intCount.ToString

        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub

    Private Sub btnSumUntil_Click(sender As Object, e As EventArgs) Handles btnSumUntil.Click
        txtList.Text = String.Empty
        lblAvg.Text = String.Empty
        lblCount.Text = String.Empty

        Const strPrompt As String = "Enter a Number. " & ControlChars.NewLine & "Click Cancel or leave blank to end."
        Const strTitle As String = "Number Entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double

        'get first sales
        strNum = InputBox(strPrompt, strTitle, "0")

        Do
            Int32.TryParse(strNum, intNum)

            'display in txtbox
            txtList.Text = txtList.Text & intNum.ToString & ControlChars.NewLine
            'update counter
            intCount += 1
            intSum = intSum + intNum

            strNum = InputBox(strPrompt, strTitle, "0")
        Loop Until strNum = String.Empty

        lblCount.Text = intCount.ToString

        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub

    Private Sub BtnSumFor_Click(sender As Object, e As EventArgs) Handles BtnSumFor.Click
        txtList.Text = String.Empty
        lblAvg.Text = String.Empty
        lblCount.Text = String.Empty

        Const strPrompt As String = "Enter count. " & ControlChars.NewLine & "Click Cancel or leave blank to end."
        Const strPrompt2 As String = "Enter a Number. " & ControlChars.NewLine
        Const strTitle As String = "Number Entry"
        Dim strNum As String
        Dim strCount As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double

        'get first sales
        strCount = InputBox(strPrompt, strTitle, "0")
        Int32.TryParse(strCount, intCount)
        'start loop

        For intFor As Integer = 1 To intCount Step +1
            strNum = InputBox(strPrompt2, strTitle, "0")
            Int32.TryParse(strNum, intNum)

            'display in txtbox
            txtList.Text = txtList.Text & intNum.ToString & ControlChars.NewLine
            intSum = intSum + intNum
        Next intFor

        'end loop

        lblCount.Text = intCount.ToString

        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub
End Class

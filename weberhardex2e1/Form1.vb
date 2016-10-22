Option Strict On
Option Explicit On
Option Infer Off

Public Class Form1
    Private Sub btnCalcAnd_Click(sender As Object, e As EventArgs) Handles btnCalcAnd.Click
        Dim amount As Double
        Dim savannah As String
        Dim shipping As Double

        Double.TryParse(txtAmount.Text, amount)
        savannah = txtCard.Text.ToUpper

        If amount >= 100 AndAlso savannah = "Y" Then
            shipping = 0
        Else
            shipping = 9
        End If

        'display
        lblCharge.Text = Convert.ToString(shipping)
    End Sub

    Private Sub btnCalcOr_Click(sender As Object, e As EventArgs) Handles btnCalcOr.Click
        Dim amount As Double
        Dim savannah As String
        Dim shipping As Double

        Double.TryParse(txtAmount.Text, amount)
        savannah = txtCard.Text.ToUpper

        If amount < 99 OrElse savannah <> "Y" Then
            shipping = 9
        Else
            shipping = 0
        End If

        'display
        lblCharge.Text = Convert.ToString(shipping)
    End Sub

    Private Sub btnCalcEqual_Click(sender As Object, e As EventArgs) Handles btnCalcEqual.Click
        Dim ID As String
        Dim sales As Double
        Dim com As Double

        Double.TryParse(txtSales.Text, sales)
        ID = txtID.Text.ToUpper

        If (ID = "A1" OrElse ID = "B2" OrElse ID = "C3") AndAlso sales >= 25000 Then
            com = sales * 0.15
        Else
            com = sales * 0.12
        End If

        'display
        lblCom.Text = Convert.ToString(com)
    End Sub

    Private Sub btnCalcNot_Click(sender As Object, e As EventArgs) Handles btnCalcNot.Click
        Dim ID As String
        Dim sales As Double
        Dim com As Double

        Double.TryParse(txtSales.Text, sales)
        ID = txtID.Text.ToUpper

        If (ID <> "A1" OrElse ID <> "B2" OrElse ID <> "C3") AndAlso sales < 25000 Then
            com = sales * 0.12
        Else
            com = sales * 0.15
        End If

        'display
        lblCom.Text = Convert.ToString(com)
    End Sub
End Class

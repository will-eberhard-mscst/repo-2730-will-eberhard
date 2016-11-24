Option Strict On
Option Explicit On
Option Infer Off

Public Class Test1
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim dollar As Double
        Dim euro As Double
        Dim pound As Double
        Dim rand As Double

        If txtDollar.Text = String.Empty Then
            MessageBox.Show("Enter something in the text box.", "Try Again")
        End If

        lblEuro.Text = String.Empty
        lblPound.Text = String.Empty
        lblRand.Text = String.Empty

        Double.TryParse(txtDollar.Text, dollar)
        euro = dollar * 0.9
        pound = dollar * 0.79
        rand = dollar * 13.89

        'display
        lblEuro.Text = Convert.ToString(euro)
        lblPound.Text = Convert.ToString(pound)
        lblRand.Text = Convert.ToString(rand)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim dollar As Double
        Dim euro As Double
        Dim pound As Double
        Dim rand As Double

        If txtDollar.Text <> String.Empty Then
            lblEuro.Text = String.Empty
            lblPound.Text = String.Empty
            lblRand.Text = String.Empty

            Double.TryParse(txtDollar.Text, dollar)
            euro = dollar * 0.9
            pound = dollar * 0.79
            rand = dollar * 13.89

            'display
            lblEuro.Text = Convert.ToString(euro)
            lblPound.Text = Convert.ToString(pound)
            lblRand.Text = Convert.ToString(rand)
        Else
            MessageBox.Show("Enter something in the text box.", "Try Again")
        End If
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim pounds As Double
        Dim price As Double
        Dim total As Double

        If MessageBox.Show("Is there shipping?", "Answer the question", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Double.TryParse(txtPounds.Text, pounds)
            Double.TryParse(txtPrice.Text, price)
            total = pounds * price + 15
        Else

            Double.TryParse(txtPounds.Text, pounds)
            Double.TryParse(txtPrice.Text, price)
            total = pounds * price
        End If
        'display
        lblDue.Text = Convert.ToString(total)

    End Sub

    Private Sub btnCalc2_Click(sender As Object, e As EventArgs) Handles btnCalc2.Click
        Dim prev As Double
        Dim cur As Double
        Dim bill As Double

        lblBill.Text = String.Empty

        Double.TryParse(txtPrev.Text, prev)
        Double.TryParse(txtCur.Text, cur)

        If cur <= prev OrElse txtCur.Text = String.Empty OrElse txtPrev.Text = String.Empty Then
            MessageBox.Show("The current value must be higher than the previous value.", "Try Again")
        Else
            bill = (cur - prev) * 0.13
            'display
            lblBill.Text = Convert.ToString(bill)
        End If
    End Sub

    Private Sub btnCalc4_Click(sender As Object, e As EventArgs) Handles btnCalc4.Click
        Dim first As Double
        Dim second As Double
        Dim Quo As Double

        lblQuo.Text = String.Empty

        Double.TryParse(txtFirst.Text, first)
        Double.TryParse(txtSecond.Text, second)

        If first = 0 OrElse second = 0 OrElse txtFirst.Text = String.Empty OrElse txtSecond.Text = String.Empty Then
            MessageBox.Show("The numbers cannot be zero.", "Try Again")
        End If
        'Swaps numbers
        If second > first Then
            Dim temp As Double
            temp = first
            first = second
            second = temp
        End If

        Quo = first / second
        lblQuo.Text = Convert.ToString(Quo)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class

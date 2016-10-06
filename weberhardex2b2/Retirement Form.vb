Public Class frmRetirement
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim gross As Double
        Dim employee As Double
        Dim employer As Double
        Dim superTotal As Double
        Dim total1 As Double
        Dim total2 As Double

        Double.TryParse(txtGross.Text, gross)
        Double.TryParse(txtEmployee.Text, employee)
        Double.TryParse(txtEmployer.Text, employer)
        total1 = gross * 52 * employee
        total2 = gross * 52 * employer
        superTotal = total1 + total2

        'display
        lblEmployee.Text = Convert.ToString(total1)
        lblEmployer.Text = Convert.ToString(total2)
        lblTotal.Text = Convert.ToString(superTotal)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtEmployee.Text = String.Empty
        txtEmployer.Text = String.Empty
        txtGross.Text = String.Empty
        lblTotal.Text = String.Empty
        lblEmployee.Text = String.Empty
        lblEmployer.Text = String.Empty
        txtGross.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
Option Strict On
Public Class MainForm
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        lblStraw.Text = Format(Val(txtStraw.Text) * (1 + Val(txtProjIncrease.Text)
            ), "currency")
        lblBlue.Text = Format(Val(txtBlue.Text) * (1 + Val(txtProjIncrease.Text)
            ), "currency")
        lblRasp.Text = Format(Val(txtRasp.Text) * (1 + Val(txtProjIncrease.Text)
            ), "currency")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtProjIncrease.Text = String.Empty
        lblStraw.Text = String.Empty
        lblBlue.Text = String.Empty
        lblRasp.Text = String.Empty
        txtStraw.Text = String.Empty
        txtBlue.Text = String.Empty
        txtRasp.Text = String.Empty
        txtProjIncrease.Focus()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'Prints screen
        btnCalc.Visible = False
        btnClear.Visible = False
        btnPrint.Visible = False
        btnExit.Visible = False
        PrintForm1.Print()
        btnCalc.Visible = True
        btnClear.Visible = True
        btnPrint.Visible = True
        btnExit.Visible = True
    End Sub
End Class

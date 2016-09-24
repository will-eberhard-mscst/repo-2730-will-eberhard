Option Strict On

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        lblGross.Text = Format(Val(txtHours.Text) * Val(txtPayrate.Text), "fixed")
        lblFWT.Text = Format(Val(lblGross.Text) * 0.2, "fixed")
        lblFICA.Text = Format(Val(lblGross.Text) * 0.08, "fixed")
        lblState.Text = Format(Val(lblGross.Text) * 0.03, "fixed")
        lblNet.Text = Format(Val(lblGross.Text) - Val(lblFWT.Text) - Val(lblFICA.Text) - Val(lblState.Text), "fixed")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = String.Empty
        txtHours.Text = String.Empty
        txtPayrate.Text = String.Empty
        lblNet.Text = String.Empty
        lblGross.Text = String.Empty
        lblFWT.Text = String.Empty
        lblFICA.Text = String.Empty
        lblState.Text = String.Empty
        txtHours.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

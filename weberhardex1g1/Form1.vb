Option Strict On
Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        lblAve.Text = Format((Val(txt1.Text) + Val(txt2.Text) + Val(txt3.Text)) / 3,
            "fixed")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblAve.Text = String.Empty
        txt1.Text = String.Empty
        txt2.Text = String.Empty
        txt3.Text = String.Empty
        txt1.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

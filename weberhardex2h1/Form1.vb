Public Class weberhard2h
    Private Sub txtSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSales.KeyPress
        'only allows numbers and backspace key
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            'cancel the key
            e.Handled = True
        End If
    End Sub

    Private Sub btnIf_Click(sender As Object, e As EventArgs) Handles btnIf.Click
        lblCommission.Text = String.Empty
        lblAddition.Text = String.Empty
        lblTotal.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommission As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotal As Double = 0.0
        Dim boolSalesOk As Boolean = Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOk Then
            MessageBox.Show("You did something wrong", "Try again")
        End If

        If boolSalesOk AndAlso dblSales < 1.0 Then
            dblCommission = 0.0
        End If

        If boolSalesOk AndAlso dblSales > 1.0 AndAlso dblSales < 6000 Then
            dblCommission = 0.1
        End If

        If boolSalesOk AndAlso dblSales >= 6000 AndAlso dblSales < 30000 Then
            dblCommission = 120 + (dblSales - 6000) * 0.13
        End If

        If boolSalesOk AndAlso dblSales >= 30000 Then
            dblCommission = 3120 + (dblSales - 30000) * 0.14
        End If

        If chkOver10.Checked Then
            dblAdditional = dblAdditional + 500
        End If

        If chkTraveling.Checked Then
            dblAdditional = dblAdditional + 700
        End If

        dblTotal = dblCommission + dblSales + dblAdditional

        'display
        If boolSalesOk Then
            lblCommission.Text = dblCommission.ToString("c2")
            lblAddition.Text = dblAdditional.ToString("c2")
            lblTotal.Text = dblTotal.ToString("c2")
        End If
        txtSales.Focus()
    End Sub

    Private Sub btnNested_Click(sender As Object, e As EventArgs) Handles btnNested.Click
        lblCommission.Text = String.Empty
        lblAddition.Text = String.Empty
        lblTotal.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommission As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotal As Double = 0.0
        Dim boolSalesOk As Boolean = Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOk Then
            MessageBox.Show("You did something wrong", "Try again")
        End If

        If boolSalesOk AndAlso dblSales >= 30000 Then
            dblCommission = 3120 + (dblSales - 30000) * 0.14
        Else
            If dblSales >= 6000 AndAlso dblSales < 30000 Then
                dblCommission = 120 + (dblSales - 6000) * 0.13
            Else
                If boolSalesOk AndAlso dblSales > 1.0 AndAlso dblSales < 6000 Then
                    dblCommission = 0.1
                Else
                    If dblSales < 1.0 Then
                        dblCommission = 0.0
                    End If
                End If
            End If
        End If

            If chkOver10.Checked Then
            dblAdditional = dblAdditional + 500
        End If

        If chkTraveling.Checked Then
            dblAdditional = dblAdditional + 700
        End If

        dblTotal = dblCommission + dblSales + dblAdditional

        'display
        If boolSalesOk Then
            lblCommission.Text = dblCommission.ToString("c2")
            lblAddition.Text = dblAdditional.ToString("c2")
            lblTotal.Text = dblTotal.ToString("c2")
        End If
        txtSales.Focus()
    End Sub

    Private Sub btnIfElse_Click(sender As Object, e As EventArgs) Handles btnIfElse.Click
        lblCommission.Text = String.Empty
        lblAddition.Text = String.Empty
        lblTotal.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommission As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotal As Double = 0.0
        Dim boolSalesOk As Boolean = Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOk Then
            MessageBox.Show("You did something wrong", "Try again")
        End If

        If boolSalesOk AndAlso dblSales >= 30000 Then
            dblCommission = 3120 + (dblSales - 30000) * 0.14
        ElseIf dblSales >= 6000 AndAlso dblSales < 30000 Then
            dblCommission = 120 + (dblSales - 6000) * 0.13
        ElseIf boolSalesOk AndAlso dblSales > 1.0 AndAlso dblSales < 6000 Then
            dblCommission = 0.1
        ElseIf dblSales < 1.0 Then
            dblCommission = 0.0
        End If

        If chkOver10.Checked Then
            dblAdditional = dblAdditional + 500
        End If

        If chkTraveling.Checked Then
            dblAdditional = dblAdditional + 700
        End If

        dblTotal = dblCommission + dblSales + dblAdditional

        'display
        If boolSalesOk Then
            lblCommission.Text = dblCommission.ToString("c2")
            lblAddition.Text = dblAdditional.ToString("c2")
            lblTotal.Text = dblTotal.ToString("c2")
        End If
        txtSales.Focus()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        lblCommission.Text = String.Empty
        lblAddition.Text = String.Empty
        lblTotal.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommission As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotal As Double = 0.0
        Dim boolSalesOk As Boolean = Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOk Then
            MessageBox.Show("You did something wrong", "Try again")
        End If

        If boolSalesOk Then
            Select Case dblSales
                Case Is < 1.0
                    dblCommission = 0.0
                Case 1 To 5999.99
                    dblCommission = 0.1
                Case 6000 To 29999.99
                    dblCommission = 120 + (dblSales - 6000) * 0.13
                Case Is >= 30000
                    dblCommission = 3120 + (dblSales - 30000) * 0.14
            End Select
        End If

        If chkOver10.Checked Then
            dblAdditional = dblAdditional + 500
        End If

        If chkTraveling.Checked Then
            dblAdditional = dblAdditional + 700
        End If

        dblTotal = dblCommission + dblSales + dblAdditional

        'display
        If boolSalesOk Then
            lblCommission.Text = dblCommission.ToString("c2")
            lblAddition.Text = dblAdditional.ToString("c2")
            lblTotal.Text = dblTotal.ToString("c2")
        End If
        txtSales.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

' Name:         Multiplication Project
' Purpose:      Display a multiplication table that shows
'               the multiplicand, multiplier, and product
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        ' displays a multiplication table
        Dim number, product, count As Integer
        lstMultTable.Items.Clear()
        lstMultTable.Items.Add("For Loop:")
        Integer.TryParse(txtNumber.Text, number)

        Do While count < 9
            count += 1
            product = number * count
            Dim strOutput As String = "    " & number.ToString() & " * " & count.ToString() & " = " & product.ToString()
            lstMultTable.Items.Add(strOutput)
        Loop
    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        ' displays a multiplication table
        Dim number, product As Integer
        lstMultTable.Items.Clear()
        lstMultTable.Items.Add("For Loop:")
        Integer.TryParse(txtNumber.Text, number)

        For count As Integer = 1 To 9 Step +1
            product = number * count
            Dim strOutput As String = "    " & number.ToString() & " * " & count.ToString() & " = " & product.ToString()
            lstMultTable.Items.Add(strOutput)
        Next count

    End Sub

    Private Sub txtNumber_Enter(sender As Object, e As EventArgs) Handles txtNumber.Enter
        txtNumber.SelectAll()
    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        ' allows only numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        'lblTable.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim count As Double = 0.00
        Dim dblTax As Double
        Dim dblTotal As Double
        Do Until count = 4
            count += 1
            lstPrices.Items.Add(count)
        Loop

        Dim dblPretaxTotal As Double = 0
        Dim strSelectedItem As String
        Dim dblSelectedPrice As Double
        For index As Integer = 0 To lstPrices.Items.Count - 1
            index = lstPrices.SelectedIndex

            'I believe this line below is the problem
            strSelectedItem = lstPrices.SelectedItem.ToString
            Double.TryParse(strSelectedItem, dblSelectedPrice)
            dblPretaxTotal = dblPretaxTotal + dblSelectedPrice
        Next index

        lblPretax.Text = dblPretaxTotal.ToString("N2")
        dblTax = dblPretaxTotal * 0.05
        dblTotal = dblPretaxTotal + dblTax
        lblTax.Text = dblTax.ToString("N2")
        lblTotal.Text = dblTotal.ToString("N2")
        lstPrices.SelectedItem = -1
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strPrice As String
        Dim dblPrice As Double
        Dim dblTax As Double
        Dim dblTotal As Double
        strPrice = InputBox("Enter a number to add")
        Double.TryParse(strPrice, dblPrice)

        Do While dblPrice < 0 OrElse dblPrice > 9.99
            strPrice = InputBox("Enter a number to add")
            Double.TryParse(strPrice, dblPrice)
        Loop

        'Calculations
        lstPrices.Items.Add(dblPrice)

        Dim dblPretaxTotal As Double = 0
        Dim strSelectedItem As String
        Dim dblSelectedPrice As Double
        For index As Integer = 0 To lstPrices.Items.Count - 1
            index = lstPrices.SelectedIndex
            strSelectedItem = Convert.ToString(lstPrices.SelectedItem)
            Double.TryParse(strSelectedItem, dblSelectedPrice)
            dblPretaxTotal = dblPretaxTotal + dblSelectedPrice
        Next index

        lblPretax.Text = dblPretaxTotal.ToString("N2")
        dblTax = dblPretaxTotal * 0.05
        dblTotal = dblPretaxTotal + dblTax
        lblTax.Text = dblTax.ToString("N2")
        lblTotal.Text = dblTotal.ToString("N2")
        lstPrices.SelectedItem = -1

        'Removes Item

    End Sub

    Private Sub lstPrices_KeyDown(sender As Object, e As KeyEventArgs) Handles lstPrices.KeyDown
        If lstPrices.SelectedIndex <> -1 AndAlso (e.KeyCode = Keys.Back OrElse e.KeyCode = Keys.Delete) Then
            lstPrices.Items.RemoveAt(lstPrices.SelectedIndex)
        End If
    End Sub
End Class

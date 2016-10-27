' Name:         Treeline Project
' Purpose:      Display the total room charge, tax, 
'               total resort fee, and total due
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) _
        Handles txtRooms.TextChanged, txtNights.TextChanged,
        txtAdults.TextChanged, txtChildren.TextChanged,
        radQueen.CheckedChanged, radKing.CheckedChanged,
        radStandard.CheckedChanged, radAtrium.CheckedChanged,
        chkParkingFee.CheckedChanged
        ' clear calculated amounts

        lblRoomChg.Text = String.Empty
        lblTax.Text = String.Empty
        lblResortFee.Text = String.Empty
        lblParkingFee.Text = String.Empty
        lblTotalDue.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Const intMaxPerRoom As Integer = 6
        'Const dblDailyRoomCharge As Double = 255.5
        Const dblDailyRoomChargeQueenStand As Double = 225.5
        Const dblDailyRoomChargeQuennAtrium As Double = 275
        Const dblDailyRoomChargeKingStand As Double = 245.5
        Const dblDailyRoomChargeKingAtrium As Double = 325
        Const dblDailyParkingFee As Double = 8.5
        Const dblTaxRate As Double = 0.1625
        Const dblDailyResortFee As Double = 12.5
        Const strMSG As String = "You have exceeded the maximum guests per room."

        Dim intRoomsReserved As Integer
        Dim intNights As Integer
        Dim intAdults As Integer
        Dim intChildren As Integer
        Dim intNumGuests As Integer
        Dim dblRoomsRequired As Double
        Dim dblParkingFee As Double
        Dim dblDailyRoomCharge As Double
        Dim dblTotalRoomCharge As Double
        Dim dblTax As Double
        Dim dblTotalResortFee As Double
        Dim dblTotalDue As Double
        Dim blnIsNightsOk As Boolean
        Dim blnIsRoomsReservedOk As Boolean
        Dim blnIsAdultsOk As Boolean
        'Dim blnIsChildrenOk As Boolean

        'store into variables
        blnIsRoomsReservedOk = Integer.TryParse(txtRooms.Text, intRoomsReserved)
        blnIsNightsOk = Integer.TryParse(txtNights.Text, intNights)
        blnIsAdultsOk = Integer.TryParse(txtAdults.Text, intAdults)
        Integer.TryParse(txtChildren.Text, intChildren)

        If blnIsRoomsReservedOk AndAlso blnIsNightsOk AndAlso blnIsAdultsOk Then

            'calculations
            intNumGuests = intAdults + intChildren
            dblRoomsRequired = intNumGuests / intMaxPerRoom

            If intRoomsReserved < dblRoomsRequired Then
                MessageBox.Show(strMSG, "Treeline Resort", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'calculate charges
                If radQueen.Checked Then
                    If radStandard.Checked Then
                        dblDailyRoomCharge = dblDailyRoomChargeQueenStand
                    Else
                        dblDailyRoomCharge = dblDailyRoomChargeQuennAtrium
                    End If
                Else
                    If radStandard.Checked Then
                        dblDailyRoomCharge = dblDailyRoomChargeKingStand
                    Else
                        dblDailyRoomCharge = dblDailyRoomChargeKingAtrium
                    End If
                End If
                dblTotalRoomCharge = intRoomsReserved * intNights * dblDailyRoomCharge
                dblTax = dblTotalRoomCharge * dblTaxRate
                dblTotalResortFee = intRoomsReserved * intNights * dblDailyResortFee
                'Check box code
                If chkParkingFee.Checked Then
                    dblParkingFee = intNights * dblDailyParkingFee
                End If
                dblTotalDue = dblTotalRoomCharge + dblTax + dblTotalResortFee + dblParkingFee

                'display
                lblRoomChg.Text = dblTotalRoomCharge.ToString("n2")
                lblTax.Text = dblTax.ToString("n2")
                lblResortFee.Text = dblTotalResortFee.ToString("n2")
                lblParkingFee.Text = dblParkingFee.ToString("n2")
                lblTotalDue.Text = dblTotalDue.ToString("c2")
            End If
        End If
    End Sub

    Private Sub txtRooms_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRooms.KeyPress, txtNights.KeyPress, txtAdults.KeyPress, txtChildren.KeyPress
        'only allows numbers and backspace key
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            'cancel the key
            e.Handled = True
        End If
    End Sub

    Private Sub txtRooms_Enter(sender As Object, e As EventArgs) Handles txtRooms.Enter
        'Selects all contents when sent focus
        txtRooms.SelectAll()
    End Sub

    Private Sub txtAdults_Enter(sender As Object, e As EventArgs) Handles txtAdults.Enter
        txtAdults.SelectAll()
    End Sub

    Private Sub txtChildren_Enter(sender As Object, e As EventArgs) Handles txtChildren.Enter
        txtChildren.SelectAll()
    End Sub

    Private Sub txtNights_Enter(sender As Object, e As EventArgs) Handles txtNights.Enter
        txtNights.SelectAll()
    End Sub
End Class

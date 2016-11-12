﻿' Name:         Chapter 8, String functions, list boxes
' Purpose:      #2: Interprets color code
'               #5: Sets proper upper/lower case
'               #6: Interprets shipping code
' Programmer:   <your name> on <today's date>

Option Strict On
Option Explicit On
Option Infer Off

Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ItemNumbers_TextChanged(sender As Object, e As EventArgs) _
            Handles txtItem1.TextChanged, txtItem2.TextChanged, txtItem3.TextChanged, txtItem4.TextChanged, txtItem5.TextChanged
        lstColors.Items.Clear()
    End Sub

    Private Sub btnDisplayColor_Click(sender As Object, e As EventArgs) Handles btnDisplayColor.Click
        DisplayColor(txtItem1.Text)
        DisplayColor(txtItem2.Text)
        DisplayColor(txtItem3.Text)
        DisplayColor(txtItem4.Text)
        DisplayColor(txtItem5.Text)
    End Sub

    Private Sub DisplayColor(ByVal itemNum As String)
        If itemNum.Length <> 7 Then
            MessageBox.Show("The value must contain 7 characters", "Try Again")
        ElseIf itemNum.ToUpper Like "???B???" Then
            lstColors.Items.Add(itemNum & ": Blue")
        ElseIf itemNum.ToUpper Like "???G???" Then
            lstColors.Items.Add(itemNum & ": Green")
        ElseIf itemNum.ToUpper Like "???R???" Then
            lstColors.Items.Add(itemNum & ": Red")
        ElseIf itemNum.ToUpper Like "???W???" Then
            lstColors.Items.Add(itemNum & ": White")
        Else
            lstColors.Items.Add("Invalid: " & itemNum)
        End If


    End Sub

    Private Sub txtName_Enter(sender As Object, e As EventArgs) Handles txtName.Enter
        txtName.SelectAll()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        lblName.Text = String.Empty
    End Sub

    Private Sub btnDisplayDelivery_Click(sender As Object, e As EventArgs) Handles btnDisplayDelivery.Click
        DisplayDelivery(txtPartNum1.Text)
        DisplayDelivery(txtPartNum2.Text)
        DisplayDelivery(txtPartNum3.Text)
        DisplayDelivery(txtPartNum4.Text)
        DisplayDelivery(txtPartNum5.Text)
        DisplayDelivery(txtPartNum6.Text)
    End Sub

    Private Sub DisplayDelivery(ByVal partNum As String)
        If partNum.Length = 3 OrElse partNum.Length = 4 Then
            If partNum.ToUpper Like "##MS" Then
                lstDelivery.Items.Add("Mail - Standard")
            End If
            If partNum.ToUpper Like "##MP" Then
                lstDelivery.Items.Add("Mail - Priority")
            End If
            If partNum.ToUpper Like "##FS" Then
                lstDelivery.Items.Add("FedEx - Standarf")
            End If
            If partNum.ToUpper Like "##FO" Then
                lstDelivery.Items.Add("FedEx - Overnight")
            End If
            If partNum.ToUpper Like "##U" Then
                lstDelivery.Items.Add("UPS")
            End If
        Else
            lstDelivery.Items.Add("Invalid")
        End If

    End Sub

    Private Sub PartNum_TextChanged(sender As Object, e As EventArgs) _
            Handles txtPartNum1.TextChanged, txtPartNum2.TextChanged, txtPartNum3.TextChanged, txtPartNum4.TextChanged, txtPartNum5.TextChanged, txtPartNum6.TextChanged
        lstDelivery.Items.Clear()
    End Sub

    'btnProper_Click pseudocode:
    '1) Convert txtName to lower case, store in strName
    '2) Use strName.Substring() to get first character of strName, convert to upper case, store in strFirstChar
    '3) Remove first character of strName
    '4) Insert strFirstChar at beginning of strName
    '5) Use strName.IndexOf() to find the space character. Add 1 and store in index
    '6) Repeat steps 2 - 4 to remove/insert first letter of last name

    Private Sub btnProper_Click(sender As Object, e As EventArgs) Handles btnProper.Click
        Dim strName As String = txtName.Text.ToLower
        Dim index As Integer
        Dim strFirstChar As String
        Dim strLastChar As String
        strFirstChar = strName.ToUpper.Substring(0, 1)
        strName = strName.Remove(0, 1)
        strName = strName.Insert(0, strFirstChar)

        index = strName.IndexOf(" ")
        If index <> -1 Then
            index = index + 1
            strLastChar = strName.ToUpper.Substring(index, 1)
            strName = strName.Remove(index, 1)
            strName = strName.Insert(index, strLastChar)
        End If

        lblName.Text = strName
    End Sub

End Class

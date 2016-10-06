﻿Option Strict On
Option Explicit On
Option Infer Off
Public Class MainForm
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim decProj As Double
        Dim intStraw As Integer
        Dim decTotalStraw As Double
        Dim intBlue As Integer
        Dim decTotalBlue As Double
        Dim intRasp As Integer
        Dim decTotalRasp As Double

        Integer.TryParse(txtStraw.Text, intStraw)
        Double.TryParse(txtProjIncrease.Text, decProj)
        decProj = decProj + 1
        decTotalStraw = intStraw * decProj

        Integer.TryParse(txtBlue.Text, intBlue)
        Double.TryParse(txtProjIncrease.Text, decProj)
        decProj = decProj + 1
        decTotalBlue = intBlue * decProj

        Integer.TryParse(txtRasp.Text, intRasp)
        Double.TryParse(txtProjIncrease.Text, decProj)
        decProj = decProj + 1
        decTotalRasp = intRasp * decProj

        'displays results
        lblStraw.Text = Convert.ToString(decTotalStraw)
        lblBlue.Text = Convert.ToString(decTotalBlue)
        lblRasp.Text = Convert.ToString(decTotalRasp)
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
        frmRetirement.Show()
    End Sub
End Class

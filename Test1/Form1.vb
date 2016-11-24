Option Strict On
Option Explicit On
Option Infer Off

Public Class Form1
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim v1 As Single
        Dim v2 As Double
        Dim v3 As String
        Dim v4 As String
        v3 = "eberh$ardb"
        Dim Random As Random

        v4 = v3.Substring(4)

        lblEuro.Text = v4




    End Sub
End Class

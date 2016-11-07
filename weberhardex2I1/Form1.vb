Option Strict On
Option Explicit On
Option Infer Off

Public Class weberhard2i
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        '3
        Dim word As String = txt3.Text
        word = word.Remove(0, 1)
        word = word.Insert(0, "cr")
        lbl3.Text = word

        '4
        Dim item As String = txt4.Text
        Dim color As String
        color = item.Substring(2, 4)
        lbl4.Text = color

        '5a
        Dim msg As String = txt5a.Text
        Dim int5a As Integer = msg.Length
        lbl5a.Text = Convert.ToString(int5a)

        '5b
        Dim city As String = txt5b.Text
        lbl5b.Text = city.Trim

        '5c
        Dim word2 As String = txt5c.Text
        word2 = word2.Remove(1, 1)
        word2 = word2.Insert(1, "rit")
        lbl5c.Text = word2

        '5d
        Dim word3 As String = txt5d.Text
        word3 = word3.Insert(0, "Mon")
        lbl5d.Text = word3

        '5e
        Dim word4 As String = txt5e.Text
        word4 = word4.PadLeft(10, "*"c)
        lbl5e.Text = word4

        '6
        Dim word5 As String = txt6.Text
        word5 = word5.Remove(1, 1)
        word5 = word5.Remove(4, 1)
        lbl6.Text = word5

        '7
        Dim word6 As String = txt7.Text
        Dim blnContained As Boolean
        blnContained = word6.Contains("Jefferson Street")

        If blnContained Then
            lbl7.Text = "Jefferson Street Found!"
        Else
            lbl7.Text = "Not Found"
        End If

        '12
        Dim word7 As String = txt12.Text
        Dim length1 As Integer = word7.Length
        length1 = length1 - 3
        word7 = word7.Remove(length1, 3)
        lbl12.Text = word7

        '13
        Dim word8 As String = txt13.Text

        If word8 Like "605##" Then
            lbl13.Text = "Shipping: $25"
        ElseIf word8 Like "606##" Then
            lbl13.Text = "Shipping: $30"
        Else
            lbl13.Text = "Invalid Zip"
        End If
    End Sub
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnForNext = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDoLoop = New System.Windows.Forms.Button()
        Me.lstMultTable = New System.Windows.Forms.ListBox()
        Me.P348 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPretax = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstPrices = New System.Windows.Forms.ListBox()
        Me.P348.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Number:"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(90, 22)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(42, 27)
        Me.txtNumber.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Multiplication table:"
        '
        'btnForNext
        '
        Me.btnForNext.Location = New System.Drawing.Point(169, 22)
        Me.btnForNext.Name = "btnForNext"
        Me.btnForNext.Size = New System.Drawing.Size(111, 33)
        Me.btnForNext.TabIndex = 2
        Me.btnForNext.Text = "&For...Next"
        Me.btnForNext.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(169, 100)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(111, 33)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDoLoop
        '
        Me.btnDoLoop.Location = New System.Drawing.Point(169, 61)
        Me.btnDoLoop.Name = "btnDoLoop"
        Me.btnDoLoop.Size = New System.Drawing.Size(111, 33)
        Me.btnDoLoop.TabIndex = 3
        Me.btnDoLoop.Text = "&Do...Loop"
        Me.btnDoLoop.UseVisualStyleBackColor = True
        '
        'lstMultTable
        '
        Me.lstMultTable.FormattingEnabled = True
        Me.lstMultTable.ItemHeight = 20
        Me.lstMultTable.Location = New System.Drawing.Point(19, 133)
        Me.lstMultTable.Name = "lstMultTable"
        Me.lstMultTable.Size = New System.Drawing.Size(143, 204)
        Me.lstMultTable.TabIndex = 6
        '
        'P348
        '
        Me.P348.Controls.Add(Me.lstMultTable)
        Me.P348.Controls.Add(Me.Label1)
        Me.P348.Controls.Add(Me.btnDoLoop)
        Me.P348.Controls.Add(Me.txtNumber)
        Me.P348.Controls.Add(Me.btnExit)
        Me.P348.Controls.Add(Me.Label2)
        Me.P348.Controls.Add(Me.btnForNext)
        Me.P348.Location = New System.Drawing.Point(12, 12)
        Me.P348.Name = "P348"
        Me.P348.Size = New System.Drawing.Size(296, 349)
        Me.P348.TabIndex = 7
        Me.P348.TabStop = False
        Me.P348.Text = "P.348"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblTax)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblPretax)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lstPrices)
        Me.GroupBox1.Location = New System.Drawing.Point(325, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 349)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "P.388"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(169, 304)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(94, 33)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(169, 252)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(94, 29)
        Me.lblTotal.TabIndex = 16
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(165, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Total:"
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTax.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(169, 192)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(94, 29)
        Me.lblTax.TabIndex = 13
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(165, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Tax:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(165, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Pretax Total:"
        '
        'lblPretax
        '
        Me.lblPretax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPretax.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPretax.Location = New System.Drawing.Point(169, 133)
        Me.lblPretax.Name = "lblPretax"
        Me.lblPretax.Size = New System.Drawing.Size(94, 29)
        Me.lblPretax.TabIndex = 10
        Me.lblPretax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Prices:"
        '
        'lstPrices
        '
        Me.lstPrices.FormattingEnabled = True
        Me.lstPrices.ItemHeight = 20
        Me.lstPrices.Location = New System.Drawing.Point(6, 133)
        Me.lstPrices.Name = "lstPrices"
        Me.lstPrices.Size = New System.Drawing.Size(143, 204)
        Me.lstPrices.TabIndex = 7
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 383)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.P348)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multiplication Table"
        Me.P348.ResumeLayout(False)
        Me.P348.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnForNext As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDoLoop As Button
    Friend WithEvents lstMultTable As ListBox
    Friend WithEvents P348 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lstPrices As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPretax As Label
End Class

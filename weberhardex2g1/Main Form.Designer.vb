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
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.btnCalcIf = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnCalcNest = New System.Windows.Forms.Button()
        Me.btnCalcIfElse = New System.Windows.Forms.Button()
        Me.btnCalcSelect = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Price:"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(12, 148)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(81, 27)
        Me.txtPrice.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(100, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Quantity:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(104, 148)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(81, 27)
        Me.txtQuantity.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(251, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Discount:"
        '
        'lblDiscount
        '
        Me.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiscount.Location = New System.Drawing.Point(255, 148)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(81, 29)
        Me.lblDiscount.TabIndex = 7
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(356, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total due:"
        '
        'lblTotalDue
        '
        Me.lblTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalDue.Location = New System.Drawing.Point(360, 148)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(81, 29)
        Me.lblTotalDue.TabIndex = 9
        Me.lblTotalDue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalcIf
        '
        Me.btnCalcIf.Location = New System.Drawing.Point(12, 192)
        Me.btnCalcIf.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalcIf.Name = "btnCalcIf"
        Me.btnCalcIf.Size = New System.Drawing.Size(86, 32)
        Me.btnCalcIf.TabIndex = 4
        Me.btnCalcIf.Text = "&Calc: If"
        Me.btnCalcIf.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(176, 232)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 32)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(57, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 112)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Discount Rates"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 20)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "> 20       3%"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "16-20     2.5%"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "11-15     2%"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "1-10       0%"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(255, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(128, 112)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sample Data"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 86)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 20)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "$10, Qty 30: $9"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 20)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "$10, Qty 20: $5"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 20)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "$10, Qty 15: $3"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 20)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "$10, Qty 10: $0"
        '
        'btnCalcNest
        '
        Me.btnCalcNest.Location = New System.Drawing.Point(104, 192)
        Me.btnCalcNest.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalcNest.Name = "btnCalcNest"
        Me.btnCalcNest.Size = New System.Drawing.Size(116, 32)
        Me.btnCalcNest.TabIndex = 12
        Me.btnCalcNest.Text = "&Calc: Nested If"
        Me.btnCalcNest.UseVisualStyleBackColor = True
        '
        'btnCalcIfElse
        '
        Me.btnCalcIfElse.Location = New System.Drawing.Point(226, 192)
        Me.btnCalcIfElse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalcIfElse.Name = "btnCalcIfElse"
        Me.btnCalcIfElse.Size = New System.Drawing.Size(110, 32)
        Me.btnCalcIfElse.TabIndex = 13
        Me.btnCalcIfElse.Text = "&Calc: If-Else-If"
        Me.btnCalcIfElse.UseVisualStyleBackColor = True
        '
        'btnCalcSelect
        '
        Me.btnCalcSelect.Location = New System.Drawing.Point(342, 192)
        Me.btnCalcSelect.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalcSelect.Name = "btnCalcSelect"
        Me.btnCalcSelect.Size = New System.Drawing.Size(103, 32)
        Me.btnCalcSelect.TabIndex = 14
        Me.btnCalcSelect.Text = "&Calc: Select"
        Me.btnCalcSelect.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 297)
        Me.Controls.Add(Me.btnCalcSelect)
        Me.Controls.Add(Me.btnCalcIfElse)
        Me.Controls.Add(Me.btnCalcNest)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalcIf)
        Me.Controls.Add(Me.lblTotalDue)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jetters"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTotalDue As System.Windows.Forms.Label
    Friend WithEvents btnCalcIf As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnCalcNest As Button
    Friend WithEvents btnCalcIfElse As Button
    Friend WithEvents btnCalcSelect As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCalcOr = New System.Windows.Forms.Button()
        Me.btnCalcAnd = New System.Windows.Forms.Button()
        Me.lblCharge = New System.Windows.Forms.Label()
        Me.txtCard = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblCom = New System.Windows.Forms.Label()
        Me.btnCalcEqual = New System.Windows.Forms.Button()
        Me.btnCalcNot = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCalcOr)
        Me.GroupBox1.Controls.Add(Me.btnCalcAnd)
        Me.GroupBox1.Controls.Add(Me.lblCharge)
        Me.GroupBox1.Controls.Add(Me.txtCard)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblAmount)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 127)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Savannah Cards"
        '
        'btnCalcOr
        '
        Me.btnCalcOr.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcOr.Location = New System.Drawing.Point(205, 87)
        Me.btnCalcOr.Name = "btnCalcOr"
        Me.btnCalcOr.Size = New System.Drawing.Size(117, 28)
        Me.btnCalcOr.TabIndex = 16
        Me.btnCalcOr.Text = "Calculate (or)"
        Me.btnCalcOr.UseVisualStyleBackColor = True
        '
        'btnCalcAnd
        '
        Me.btnCalcAnd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcAnd.Location = New System.Drawing.Point(48, 87)
        Me.btnCalcAnd.Name = "btnCalcAnd"
        Me.btnCalcAnd.Size = New System.Drawing.Size(138, 28)
        Me.btnCalcAnd.TabIndex = 15
        Me.btnCalcAnd.Text = "Calculate (and)"
        Me.btnCalcAnd.UseVisualStyleBackColor = True
        '
        'lblCharge
        '
        Me.lblCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCharge.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharge.Location = New System.Drawing.Point(312, 52)
        Me.lblCharge.Name = "lblCharge"
        Me.lblCharge.Size = New System.Drawing.Size(98, 29)
        Me.lblCharge.TabIndex = 13
        '
        'txtCard
        '
        Me.txtCard.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCard.Location = New System.Drawing.Point(147, 52)
        Me.txtCard.Name = "txtCard"
        Me.txtCard.Size = New System.Drawing.Size(39, 29)
        Me.txtCard.TabIndex = 9
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(28, 52)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(98, 29)
        Me.txtAmount.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(308, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Shipping Charge:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(143, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Savannah Card (Y/N):"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(24, 16)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(114, 21)
        Me.lblAmount.TabIndex = 5
        Me.lblAmount.Text = "Order Amount:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCalcNot)
        Me.GroupBox2.Controls.Add(Me.btnCalcEqual)
        Me.GroupBox2.Controls.Add(Me.lblCom)
        Me.GroupBox2.Controls.Add(Me.txtID)
        Me.GroupBox2.Controls.Add(Me.txtSales)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 145)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(447, 128)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Commission"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(88, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Sales:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(201, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Commission:"
        '
        'txtSales
        '
        Me.txtSales.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSales.Location = New System.Drawing.Point(92, 40)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(98, 29)
        Me.txtSales.TabIndex = 9
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(27, 40)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(39, 29)
        Me.txtID.TabIndex = 10
        '
        'lblCom
        '
        Me.lblCom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCom.Location = New System.Drawing.Point(205, 40)
        Me.lblCom.Name = "lblCom"
        Me.lblCom.Size = New System.Drawing.Size(98, 29)
        Me.lblCom.TabIndex = 14
        '
        'btnCalcEqual
        '
        Me.btnCalcEqual.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcEqual.Location = New System.Drawing.Point(70, 75)
        Me.btnCalcEqual.Name = "btnCalcEqual"
        Me.btnCalcEqual.Size = New System.Drawing.Size(109, 28)
        Me.btnCalcEqual.TabIndex = 16
        Me.btnCalcEqual.Text = "Calculate (=)"
        Me.btnCalcEqual.UseVisualStyleBackColor = True
        '
        'btnCalcNot
        '
        Me.btnCalcNot.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcNot.Location = New System.Drawing.Point(185, 75)
        Me.btnCalcNot.Name = "btnCalcNot"
        Me.btnCalcNot.Size = New System.Drawing.Size(118, 28)
        Me.btnCalcNot.TabIndex = 17
        Me.btnCalcNot.Text = "Calculate (<>)"
        Me.btnCalcNot.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 325)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents txtCard As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lblCharge As Label
    Friend WithEvents btnCalcOr As Button
    Friend WithEvents btnCalcAnd As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCalcNot As Button
    Friend WithEvents btnCalcEqual As Button
    Friend WithEvents lblCom As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtSales As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class

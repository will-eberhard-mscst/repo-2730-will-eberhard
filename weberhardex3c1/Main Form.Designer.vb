<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.radSubCm = New System.Windows.Forms.RadioButton()
        Me.radSubIn = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMeasurement = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.radFuncCm = New System.Windows.Forms.RadioButton()
        Me.radFuncIn = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEarthWeight = New System.Windows.Forms.TextBox()
        Me.cboPlanets = New System.Windows.Forms.ComboBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.radSub = New System.Windows.Forms.RadioButton()
        Me.radFunc = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'radSubCm
        '
        Me.radSubCm.Checked = True
        Me.radSubCm.Location = New System.Drawing.Point(111, 25)
        Me.radSubCm.Margin = New System.Windows.Forms.Padding(2)
        Me.radSubCm.Name = "radSubCm"
        Me.radSubCm.Size = New System.Drawing.Size(203, 26)
        Me.radSubCm.TabIndex = 2
        Me.radSubCm.TabStop = True
        Me.radSubCm.Text = "Sub: Inches to &Centimeters"
        '
        'radSubIn
        '
        Me.radSubIn.Location = New System.Drawing.Point(111, 62)
        Me.radSubIn.Margin = New System.Windows.Forms.Padding(2)
        Me.radSubIn.Name = "radSubIn"
        Me.radSubIn.Size = New System.Drawing.Size(203, 26)
        Me.radSubIn.TabIndex = 3
        Me.radSubIn.Text = "Sub: Centimeters to &Inches"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Measurement:"
        '
        'txtMeasurement
        '
        Me.txtMeasurement.Location = New System.Drawing.Point(8, 46)
        Me.txtMeasurement.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMeasurement.Name = "txtMeasurement"
        Me.txtMeasurement.Size = New System.Drawing.Size(55, 27)
        Me.txtMeasurement.TabIndex = 1
        Me.txtMeasurement.Text = "10"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 86)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Result:"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Location = New System.Drawing.Point(8, 106)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(81, 30)
        Me.lblResult.TabIndex = 7
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(309, 224)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(72, 30)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        '
        'radFuncCm
        '
        Me.radFuncCm.Location = New System.Drawing.Point(111, 100)
        Me.radFuncCm.Margin = New System.Windows.Forms.Padding(2)
        Me.radFuncCm.Name = "radFuncCm"
        Me.radFuncCm.Size = New System.Drawing.Size(212, 26)
        Me.radFuncCm.TabIndex = 8
        Me.radFuncCm.Text = "Func: Inches to &Centimeters"
        '
        'radFuncIn
        '
        Me.radFuncIn.Location = New System.Drawing.Point(111, 142)
        Me.radFuncIn.Margin = New System.Windows.Forms.Padding(2)
        Me.radFuncIn.Name = "radFuncIn"
        Me.radFuncIn.Size = New System.Drawing.Size(212, 26)
        Me.radFuncIn.TabIndex = 9
        Me.radFuncIn.Text = "Func: Inches to &Centimeters"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.radFuncIn)
        Me.GroupBox1.Controls.Add(Me.txtMeasurement)
        Me.GroupBox1.Controls.Add(Me.radFuncCm)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblResult)
        Me.GroupBox1.Controls.Add(Me.radSubIn)
        Me.GroupBox1.Controls.Add(Me.radSubCm)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(335, 207)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Part 1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radFunc)
        Me.GroupBox2.Controls.Add(Me.radSub)
        Me.GroupBox2.Controls.Add(Me.lblWeight)
        Me.GroupBox2.Controls.Add(Me.cboPlanets)
        Me.GroupBox2.Controls.Add(Me.txtEarthWeight)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(353, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(325, 207)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Part 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 23)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "&Earth Weight:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(106, 23)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "&Weight on:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(208, 23)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "&Calculate using:"
        '
        'txtEarthWeight
        '
        Me.txtEarthWeight.Location = New System.Drawing.Point(9, 46)
        Me.txtEarthWeight.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEarthWeight.Name = "txtEarthWeight"
        Me.txtEarthWeight.Size = New System.Drawing.Size(55, 27)
        Me.txtEarthWeight.TabIndex = 4
        Me.txtEarthWeight.Text = "100"
        '
        'cboPlanets
        '
        Me.cboPlanets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlanets.FormattingEnabled = True
        Me.cboPlanets.Location = New System.Drawing.Point(110, 46)
        Me.cboPlanets.Name = "cboPlanets"
        Me.cboPlanets.Size = New System.Drawing.Size(83, 28)
        Me.cboPlanets.TabIndex = 5
        '
        'lblWeight
        '
        Me.lblWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWeight.Location = New System.Drawing.Point(110, 151)
        Me.lblWeight.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(83, 30)
        Me.lblWeight.TabIndex = 8
        Me.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radSub
        '
        Me.radSub.Checked = True
        Me.radSub.Location = New System.Drawing.Point(212, 46)
        Me.radSub.Margin = New System.Windows.Forms.Padding(2)
        Me.radSub.Name = "radSub"
        Me.radSub.Size = New System.Drawing.Size(63, 26)
        Me.radSub.TabIndex = 9
        Me.radSub.TabStop = True
        Me.radSub.Text = "Sub"
        '
        'radFunc
        '
        Me.radFunc.Location = New System.Drawing.Point(212, 76)
        Me.radFunc.Margin = New System.Windows.Forms.Padding(2)
        Me.radFunc.Name = "radFunc"
        Me.radFunc.Size = New System.Drawing.Size(88, 26)
        Me.radFunc.TabIndex = 10
        Me.radFunc.Text = "Function"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 272)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Measurement Converter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents radSubCm As System.Windows.Forms.RadioButton
    Friend WithEvents radSubIn As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMeasurement As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents radFuncCm As RadioButton
    Friend WithEvents radFuncIn As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radFunc As RadioButton
    Friend WithEvents radSub As RadioButton
    Friend WithEvents lblWeight As Label
    Friend WithEvents cboPlanets As ComboBox
    Friend WithEvents txtEarthWeight As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class

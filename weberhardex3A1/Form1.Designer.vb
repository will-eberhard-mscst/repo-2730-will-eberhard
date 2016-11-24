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
        Me.lblEven = New System.Windows.Forms.Label()
        Me.btnPreWhile = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnFor = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtList = New System.Windows.Forms.TextBox()
        Me.lblAvg = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.btnSumWhile = New System.Windows.Forms.Button()
        Me.btnSumUntil = New System.Windows.Forms.Button()
        Me.BtnSumFor = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFor)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnPreWhile)
        Me.GroupBox1.Controls.Add(Me.lblEven)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 249)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "3A"
        '
        'lblEven
        '
        Me.lblEven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEven.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEven.Location = New System.Drawing.Point(0, 16)
        Me.lblEven.Name = "lblEven"
        Me.lblEven.Size = New System.Drawing.Size(157, 222)
        Me.lblEven.TabIndex = 9
        '
        'btnPreWhile
        '
        Me.btnPreWhile.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreWhile.Location = New System.Drawing.Point(163, 16)
        Me.btnPreWhile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPreWhile.Name = "btnPreWhile"
        Me.btnPreWhile.Size = New System.Drawing.Size(166, 32)
        Me.btnPreWhile.TabIndex = 12
        Me.btnPreWhile.Text = "&Pretest: Do While"
        Me.btnPreWhile.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(163, 56)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 32)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "&Pretest: Do Until"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(163, 96)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(166, 32)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "&Posttest: Loop While"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(163, 136)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(166, 32)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "&Posttest: Loop Until"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnFor
        '
        Me.btnFor.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFor.Location = New System.Drawing.Point(163, 176)
        Me.btnFor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnFor.Name = "btnFor"
        Me.btnFor.Size = New System.Drawing.Size(166, 32)
        Me.btnFor.TabIndex = 16
        Me.btnFor.Text = "&Pretest: For"
        Me.btnFor.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnSumFor)
        Me.GroupBox2.Controls.Add(Me.btnSumUntil)
        Me.GroupBox2.Controls.Add(Me.btnSumWhile)
        Me.GroupBox2.Controls.Add(Me.lblCount)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblAvg)
        Me.GroupBox2.Controls.Add(Me.txtList)
        Me.GroupBox2.Location = New System.Drawing.Point(360, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 248)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "P. 348"
        '
        'txtList
        '
        Me.txtList.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtList.Location = New System.Drawing.Point(6, 16)
        Me.txtList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtList.Multiline = True
        Me.txtList.Name = "txtList"
        Me.txtList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtList.Size = New System.Drawing.Size(150, 222)
        Me.txtList.TabIndex = 3
        '
        'lblAvg
        '
        Me.lblAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvg.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvg.Location = New System.Drawing.Point(162, 47)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(56, 29)
        Me.lblAvg.TabIndex = 9
        Me.lblAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(158, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "&Average:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(244, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "&Count:"
        '
        'lblCount
        '
        Me.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCount.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(248, 47)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(56, 29)
        Me.lblCount.TabIndex = 12
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSumWhile
        '
        Me.btnSumWhile.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSumWhile.Location = New System.Drawing.Point(162, 96)
        Me.btnSumWhile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSumWhile.Name = "btnSumWhile"
        Me.btnSumWhile.Size = New System.Drawing.Size(142, 32)
        Me.btnSumWhile.TabIndex = 13
        Me.btnSumWhile.Text = "&Sum, Do While"
        Me.btnSumWhile.UseVisualStyleBackColor = True
        '
        'btnSumUntil
        '
        Me.btnSumUntil.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSumUntil.Location = New System.Drawing.Point(162, 136)
        Me.btnSumUntil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSumUntil.Name = "btnSumUntil"
        Me.btnSumUntil.Size = New System.Drawing.Size(142, 32)
        Me.btnSumUntil.TabIndex = 14
        Me.btnSumUntil.Text = "&Sum, Loop Until"
        Me.btnSumUntil.UseVisualStyleBackColor = True
        '
        'BtnSumFor
        '
        Me.BtnSumFor.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSumFor.Location = New System.Drawing.Point(162, 176)
        Me.BtnSumFor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSumFor.Name = "BtnSumFor"
        Me.BtnSumFor.Size = New System.Drawing.Size(142, 32)
        Me.BtnSumFor.TabIndex = 15
        Me.BtnSumFor.Text = "&Sum, For Next"
        Me.BtnSumFor.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 274)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "3A"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblEven As Label
    Friend WithEvents btnFor As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnPreWhile As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtList As TextBox
    Friend WithEvents lblAvg As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSumFor As Button
    Friend WithEvents btnSumUntil As Button
    Friend WithEvents btnSumWhile As Button
End Class

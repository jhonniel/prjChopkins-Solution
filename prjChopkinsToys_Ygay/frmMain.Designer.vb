<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtPack12 = New System.Windows.Forms.TextBox()
        Me.txtPack5 = New System.Windows.Forms.TextBox()
        Me.lblTpack12 = New System.Windows.Forms.TextBox()
        Me.lblTpack5 = New System.Windows.Forms.TextBox()
        Me.txtSpack = New System.Windows.Forms.TextBox()
        Me.lblShip = New System.Windows.Forms.TextBox()
        Me.txtPack2 = New System.Windows.Forms.TextBox()
        Me.lblTpack2 = New System.Windows.Forms.TextBox()
        Me.txtTpack = New System.Windows.Forms.TextBox()
        Me.btncalc = New System.Windows.Forms.Button()
        Me.btnclr = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtShip = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Invoice"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(75, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date ordered:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "12 pack:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(75, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "5 pack:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(75, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "2 pack:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(67, 286)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Shipping:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(59, 315)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Sales total:"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(149, 91)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 20)
        Me.txtDate.TabIndex = 7
        '
        'txtPack12
        '
        Me.txtPack12.Location = New System.Drawing.Point(124, 153)
        Me.txtPack12.Name = "txtPack12"
        Me.txtPack12.Size = New System.Drawing.Size(48, 20)
        Me.txtPack12.TabIndex = 8
        '
        'txtPack5
        '
        Me.txtPack5.Location = New System.Drawing.Point(124, 193)
        Me.txtPack5.Name = "txtPack5"
        Me.txtPack5.Size = New System.Drawing.Size(48, 20)
        Me.txtPack5.TabIndex = 9
        '
        'lblTpack12
        '
        Me.lblTpack12.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.lblTpack12.Location = New System.Drawing.Point(188, 153)
        Me.lblTpack12.Name = "lblTpack12"
        Me.lblTpack12.ReadOnly = True
        Me.lblTpack12.Size = New System.Drawing.Size(100, 20)
        Me.lblTpack12.TabIndex = 10
        '
        'lblTpack5
        '
        Me.lblTpack5.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.lblTpack5.Location = New System.Drawing.Point(188, 193)
        Me.lblTpack5.Name = "lblTpack5"
        Me.lblTpack5.ReadOnly = True
        Me.lblTpack5.Size = New System.Drawing.Size(100, 20)
        Me.lblTpack5.TabIndex = 11
        '
        'txtSpack
        '
        Me.txtSpack.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtSpack.Location = New System.Drawing.Point(188, 312)
        Me.txtSpack.Name = "txtSpack"
        Me.txtSpack.ReadOnly = True
        Me.txtSpack.Size = New System.Drawing.Size(100, 20)
        Me.txtSpack.TabIndex = 12
        '
        'lblShip
        '
        Me.lblShip.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.lblShip.Location = New System.Drawing.Point(188, 279)
        Me.lblShip.Name = "lblShip"
        Me.lblShip.ReadOnly = True
        Me.lblShip.Size = New System.Drawing.Size(100, 20)
        Me.lblShip.TabIndex = 13
        '
        'txtPack2
        '
        Me.txtPack2.Location = New System.Drawing.Point(124, 230)
        Me.txtPack2.Name = "txtPack2"
        Me.txtPack2.Size = New System.Drawing.Size(48, 20)
        Me.txtPack2.TabIndex = 14
        '
        'lblTpack2
        '
        Me.lblTpack2.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.lblTpack2.Location = New System.Drawing.Point(188, 230)
        Me.lblTpack2.Name = "lblTpack2"
        Me.lblTpack2.ReadOnly = True
        Me.lblTpack2.Size = New System.Drawing.Size(100, 20)
        Me.lblTpack2.TabIndex = 15
        '
        'txtTpack
        '
        Me.txtTpack.Location = New System.Drawing.Point(124, 312)
        Me.txtTpack.Name = "txtTpack"
        Me.txtTpack.ReadOnly = True
        Me.txtTpack.Size = New System.Drawing.Size(48, 20)
        Me.txtTpack.TabIndex = 16
        '
        'btncalc
        '
        Me.btncalc.Location = New System.Drawing.Point(59, 348)
        Me.btncalc.Name = "btncalc"
        Me.btncalc.Size = New System.Drawing.Size(66, 32)
        Me.btncalc.TabIndex = 17
        Me.btncalc.Text = "Calculate"
        Me.btncalc.UseVisualStyleBackColor = True
        '
        'btnclr
        '
        Me.btnclr.Location = New System.Drawing.Point(156, 348)
        Me.btnclr.Name = "btnclr"
        Me.btnclr.Size = New System.Drawing.Size(61, 32)
        Me.btnclr.TabIndex = 18
        Me.btnclr.Text = "Clear"
        Me.btnclr.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(242, 348)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(62, 32)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtShip
        '
        Me.txtShip.Location = New System.Drawing.Point(124, 279)
        Me.txtShip.Name = "txtShip"
        Me.txtShip.Size = New System.Drawing.Size(48, 20)
        Me.txtShip.TabIndex = 20
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 402)
        Me.Controls.Add(Me.txtShip)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnclr)
        Me.Controls.Add(Me.btncalc)
        Me.Controls.Add(Me.txtTpack)
        Me.Controls.Add(Me.lblTpack2)
        Me.Controls.Add(Me.txtPack2)
        Me.Controls.Add(Me.lblShip)
        Me.Controls.Add(Me.txtSpack)
        Me.Controls.Add(Me.lblTpack5)
        Me.Controls.Add(Me.lblTpack12)
        Me.Controls.Add(Me.txtPack5)
        Me.Controls.Add(Me.txtPack12)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.Text = "                                      Chopkins Toys"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtPack12 As TextBox
    Friend WithEvents txtPack5 As TextBox
    Friend WithEvents lblTpack12 As TextBox
    Friend WithEvents lblTpack5 As TextBox
    Friend WithEvents txtSpack As TextBox
    Friend WithEvents lblShip As TextBox
    Friend WithEvents txtPack2 As TextBox
    Friend WithEvents lblTpack2 As TextBox
    Friend WithEvents txtTpack As TextBox
    Friend WithEvents btncalc As Button
    Friend WithEvents btnclr As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtShip As TextBox
End Class

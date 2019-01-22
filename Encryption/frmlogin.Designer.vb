<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
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
        Me.l4 = New System.Windows.Forms.LinkLabel()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtuname = New System.Windows.Forms.TextBox()
        Me.l2 = New System.Windows.Forms.Label()
        Me.l1 = New System.Windows.Forms.Label()
        Me.btnregister = New System.Windows.Forms.Button()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.l3 = New System.Windows.Forms.Label()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.SuspendLayout()
        '
        'l4
        '
        Me.l4.AutoSize = True
        Me.l4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l4.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.l4.Location = New System.Drawing.Point(524, 259)
        Me.l4.Name = "l4"
        Me.l4.Size = New System.Drawing.Size(171, 20)
        Me.l4.TabIndex = 20
        Me.l4.TabStop = True
        Me.l4.Text = "Forgot your password?"
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(310, 256)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txtpassword.Size = New System.Drawing.Size(199, 26)
        Me.txtpassword.TabIndex = 1
        '
        'txtuname
        '
        Me.txtuname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuname.Location = New System.Drawing.Point(310, 177)
        Me.txtuname.Name = "txtuname"
        Me.txtuname.Size = New System.Drawing.Size(199, 26)
        Me.txtuname.TabIndex = 0
        '
        'l2
        '
        Me.l2.AutoSize = True
        Me.l2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.l2.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l2.Location = New System.Drawing.Point(80, 260)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(189, 18)
        Me.l2.TabIndex = 23
        Me.l2.Text = "Enter Your Password:"
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.l1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.l1.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l1.Location = New System.Drawing.Point(113, 185)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(156, 18)
        Me.l1.TabIndex = 22
        Me.l1.Text = "Enter User Name:"
        '
        'btnregister
        '
        Me.btnregister.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnregister.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregister.Location = New System.Drawing.Point(400, 397)
        Me.btnregister.Name = "btnregister"
        Me.btnregister.Size = New System.Drawing.Size(123, 38)
        Me.btnregister.TabIndex = 3
        Me.btnregister.Text = "Register"
        Me.btnregister.UseVisualStyleBackColor = False
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnlogin.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.Location = New System.Drawing.Point(232, 397)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(123, 38)
        Me.btnlogin.TabIndex = 2
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'l3
        '
        Me.l3.AutoSize = True
        Me.l3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.l3.Font = New System.Drawing.Font("Lucida Bright", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l3.ForeColor = System.Drawing.Color.Black
        Me.l3.Location = New System.Drawing.Point(57, 19)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(592, 54)
        Me.l3.TabIndex = 21
        Me.l3.Text = "         REGISTER TO CREATE NEW LOCKER OR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     LOGIN TO ACCESS AREADY EXITED LOC" & _
            "KER."
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -1
        Me.LineShape1.X2 = 736
        Me.LineShape1.Y1 = 104
        Me.LineShape1.Y2 = 104
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(737, 517)
        Me.ShapeContainer1.TabIndex = 24
        Me.ShapeContainer1.TabStop = False
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(737, 517)
        Me.Controls.Add(Me.l4)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtuname)
        Me.Controls.Add(Me.l2)
        Me.Controls.Add(Me.l1)
        Me.Controls.Add(Me.btnregister)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.l3)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmlogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents l4 As System.Windows.Forms.LinkLabel
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtuname As System.Windows.Forms.TextBox
    Friend WithEvents l2 As System.Windows.Forms.Label
    Friend WithEvents l1 As System.Windows.Forms.Label
    Friend WithEvents btnregister As System.Windows.Forms.Button
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents l3 As System.Windows.Forms.Label
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
End Class

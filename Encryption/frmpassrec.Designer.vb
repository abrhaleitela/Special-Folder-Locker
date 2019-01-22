<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpassrec
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
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtfplace = New System.Windows.Forms.TextBox()
        Me.txtnname = New System.Windows.Forms.TextBox()
        Me.txtmodel = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtpwd = New System.Windows.Forms.TextBox()
        Me.lp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtuname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.l1 = New System.Windows.Forms.Label()
        Me.txtcpwd = New System.Windows.Forms.TextBox()
        Me.btnchange = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(737, 517)
        Me.ShapeContainer1.TabIndex = 2
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 1
        Me.LineShape1.X2 = 736
        Me.LineShape1.Y1 = 371
        Me.LineShape1.Y2 = 371
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LineShape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.LineShape2.BorderWidth = 2
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 0
        Me.LineShape2.X2 = 735
        Me.LineShape2.Y1 = 64
        Me.LineShape2.Y2 = 64
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(236, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "What is your favoraite place?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(236, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "What is  your nack name?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(236, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Who is your model?"
        '
        'txtfplace
        '
        Me.txtfplace.Location = New System.Drawing.Point(239, 171)
        Me.txtfplace.Name = "txtfplace"
        Me.txtfplace.Size = New System.Drawing.Size(201, 20)
        Me.txtfplace.TabIndex = 1
        '
        'txtnname
        '
        Me.txtnname.Location = New System.Drawing.Point(239, 223)
        Me.txtnname.Name = "txtnname"
        Me.txtnname.Size = New System.Drawing.Size(201, 20)
        Me.txtnname.TabIndex = 2
        '
        'txtmodel
        '
        Me.txtmodel.Location = New System.Drawing.Point(239, 273)
        Me.txtmodel.Name = "txtmodel"
        Me.txtmodel.Size = New System.Drawing.Size(201, 20)
        Me.txtmodel.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(224, 321)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 37)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Recover"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(363, 321)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 37)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "<<Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtpwd
        '
        Me.txtpwd.Location = New System.Drawing.Point(330, 394)
        Me.txtpwd.Name = "txtpwd"
        Me.txtpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txtpwd.Size = New System.Drawing.Size(256, 20)
        Me.txtpwd.TabIndex = 12
        Me.txtpwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtpwd.Visible = False
        '
        'lp
        '
        Me.lp.AutoSize = True
        Me.lp.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lp.Location = New System.Drawing.Point(86, 396)
        Me.lp.Name = "lp"
        Me.lp.Size = New System.Drawing.Size(223, 18)
        Me.lp.TabIndex = 11
        Me.lp.Text = "Enter Your New Password :"
        Me.lp.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(42, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(617, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Answer all of those quetions to recover your password."
        '
        'txtuname
        '
        Me.txtuname.Location = New System.Drawing.Point(239, 122)
        Me.txtuname.Name = "txtuname"
        Me.txtuname.Size = New System.Drawing.Size(201, 20)
        Me.txtuname.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(236, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "What is your lockername?"
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.l1.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l1.Location = New System.Drawing.Point(66, 432)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(243, 18)
        Me.l1.TabIndex = 15
        Me.l1.Text = "Confirm Your New Password:"
        Me.l1.Visible = False
        '
        'txtcpwd
        '
        Me.txtcpwd.Location = New System.Drawing.Point(330, 430)
        Me.txtcpwd.Name = "txtcpwd"
        Me.txtcpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txtcpwd.Size = New System.Drawing.Size(256, 20)
        Me.txtcpwd.TabIndex = 16
        Me.txtcpwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtcpwd.Visible = False
        '
        'btnchange
        '
        Me.btnchange.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnchange.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnchange.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnchange.Location = New System.Drawing.Point(305, 466)
        Me.btnchange.Name = "btnchange"
        Me.btnchange.Size = New System.Drawing.Size(135, 39)
        Me.btnchange.TabIndex = 17
        Me.btnchange.Text = "Change"
        Me.btnchange.UseVisualStyleBackColor = False
        Me.btnchange.Visible = False
        '
        'frmpassrec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(737, 517)
        Me.Controls.Add(Me.btnchange)
        Me.Controls.Add(Me.l1)
        Me.Controls.Add(Me.txtcpwd)
        Me.Controls.Add(Me.txtuname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lp)
        Me.Controls.Add(Me.txtpwd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtmodel)
        Me.Controls.Add(Me.txtnname)
        Me.Controls.Add(Me.txtfplace)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmpassrec"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmpassrec"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents txtfplace As System.Windows.Forms.TextBox
    Friend WithEvents txtnname As System.Windows.Forms.TextBox
    Friend WithEvents txtmodel As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents txtpwd As System.Windows.Forms.TextBox
    Friend WithEvents lp As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtuname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents l1 As System.Windows.Forms.Label
    Friend WithEvents txtcpwd As System.Windows.Forms.TextBox
    Friend WithEvents btnchange As System.Windows.Forms.Button
End Class

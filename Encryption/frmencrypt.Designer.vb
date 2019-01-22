<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmencrypt
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnlock = New System.Windows.Forms.Button()
        Me.btndeletes = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.dir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.file = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.add = New System.Windows.Forms.ToolStripMenuItem()
        Me.selectall = New System.Windows.Forms.ToolStripMenuItem()
        Me.unselect = New System.Windows.Forms.ToolStripMenuItem()
        Me.delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.lock = New System.Windows.Forms.ToolStripMenuItem()
        Me.unlock = New System.Windows.Forms.ToolStripMenuItem()
        Me.l4 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.fbd = New System.Windows.Forms.FolderBrowserDialog()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnlock
        '
        Me.btnlock.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnlock.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnlock.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlock.Location = New System.Drawing.Point(120, 472)
        Me.btnlock.Name = "btnlock"
        Me.btnlock.Size = New System.Drawing.Size(118, 33)
        Me.btnlock.TabIndex = 7
        Me.btnlock.Text = "LockSelected"
        Me.btnlock.UseVisualStyleBackColor = False
        '
        'btndeletes
        '
        Me.btndeletes.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btndeletes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndeletes.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeletes.Location = New System.Drawing.Point(376, 472)
        Me.btndeletes.Name = "btndeletes"
        Me.btndeletes.Size = New System.Drawing.Size(117, 33)
        Me.btndeletes.TabIndex = 8
        Me.btndeletes.Text = "Delete/Remove"
        Me.btndeletes.UseVisualStyleBackColor = False
        '
        'dgv1
        '
        Me.dgv1.AllowDrop = True
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.BackgroundColor = System.Drawing.Color.White
        Me.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dir, Me.file, Me.status, Me.Column2, Me.Column1})
        Me.dgv1.ContextMenuStrip = Me.ContextMenuStrip2
        Me.dgv1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv1.Location = New System.Drawing.Point(0, 74)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgv1.Size = New System.Drawing.Size(735, 382)
        Me.dgv1.TabIndex = 9
        '
        'dir
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dir.DefaultCellStyle = DataGridViewCellStyle5
        Me.dir.HeaderText = "FolderDirectory"
        Me.dir.Name = "dir"
        Me.dir.ReadOnly = True
        Me.dir.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dir.Width = 350
        '
        'file
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.file.DefaultCellStyle = DataGridViewCellStyle6
        Me.file.HeaderText = "Status"
        Me.file.Name = "file"
        Me.file.ReadOnly = True
        Me.file.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.file.Width = 145
        '
        'status
        '
        Me.status.HeaderText = "WantToAccess/Open"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.status.Width = 120
        '
        'Column2
        '
        Me.Column2.HeaderText = "Lock/UnLock"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column2.Width = 80
        '
        'Column1
        '
        Me.Column1.HeaderText = "encdir"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.Visible = False
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.add, Me.selectall, Me.unselect, Me.delete, Me.lock, Me.unlock})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(199, 180)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.ShortcutKeyDisplayString = "F5"
        Me.RefreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'add
        '
        Me.add.Name = "add"
        Me.add.ShortcutKeyDisplayString = "Alt+A"
        Me.add.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.add.Size = New System.Drawing.Size(198, 22)
        Me.add.Text = "AddFolder"
        '
        'selectall
        '
        Me.selectall.Name = "selectall"
        Me.selectall.ShortcutKeyDisplayString = "Ctrl+A"
        Me.selectall.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.selectall.Size = New System.Drawing.Size(198, 22)
        Me.selectall.Text = "SelectAll"
        '
        'unselect
        '
        Me.unselect.Name = "unselect"
        Me.unselect.ShortcutKeyDisplayString = "Alt+C"
        Me.unselect.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.unselect.Size = New System.Drawing.Size(198, 22)
        Me.unselect.Text = "UnSelectAll"
        '
        'delete
        '
        Me.delete.Name = "delete"
        Me.delete.ShortcutKeyDisplayString = "Alt+R"
        Me.delete.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.delete.Size = New System.Drawing.Size(198, 22)
        Me.delete.Text = "RemoveSelected"
        '
        'lock
        '
        Me.lock.Name = "lock"
        Me.lock.ShortcutKeyDisplayString = "Alt+L"
        Me.lock.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.lock.Size = New System.Drawing.Size(198, 22)
        Me.lock.Text = "LockSelected"
        '
        'unlock
        '
        Me.unlock.Name = "unlock"
        Me.unlock.ShortcutKeyDisplayString = "Alt+U"
        Me.unlock.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.unlock.Size = New System.Drawing.Size(198, 22)
        Me.unlock.Text = "UnlockSelected"
        '
        'l4
        '
        Me.l4.AutoSize = True
        Me.l4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l4.Location = New System.Drawing.Point(34, 27)
        Me.l4.Name = "l4"
        Me.l4.Size = New System.Drawing.Size(531, 24)
        Me.l4.TabIndex = 10
        Me.l4.Text = "THE FILES LOCKED AND MANAGED BY  THE USER "
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnadd.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(4, 472)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(110, 33)
        Me.btnadd.TabIndex = 12
        Me.btnadd.Text = "Add Files"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndelete.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(499, 472)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(103, 33)
        Me.btndelete.TabIndex = 13
        Me.btndelete.Text = "DeleteLocker"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(655, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnclose.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(608, 472)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(127, 33)
        Me.btnclose.TabIndex = 16
        Me.btnclose.Text = "LockAllAndClose"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(244, 472)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 33)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "UnLockSelected"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmencrypt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 517)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.l4)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.btndeletes)
        Me.Controls.Add(Me.btnlock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmencrypt"
        Me.Text = "frmencrypt"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnlock As System.Windows.Forms.Button
    Friend WithEvents btndeletes As System.Windows.Forms.Button
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents l4 As System.Windows.Forms.Label
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents fbd As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents add As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents selectall As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents unselect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents delete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents unlock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents file As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

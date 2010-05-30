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
        Me.components = New System.ComponentModel.Container
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"1", "11", "111", "1111", "11111"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"2", "22", "222", "2222", "22222", "222222"}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"3", "33", "333"}, -1)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("4")
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"5", "55"}, -1)
        Me.DomainUpDown1 = New System.Windows.Forms.DomainUpDown
        Me.cmsCopy = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopySelectedRows = New System.Windows.Forms.ToolStripMenuItem
        Me.CopySelectedRowsWithColumeNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBoxExt1 = New UI_EX.ComboBoxExt
        Me.ListViewExt1 = New UI_EX.ListViewExt
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.cmsCopy.SuspendLayout()
        Me.SuspendLayout()
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.Location = New System.Drawing.Point(73, 148)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.DomainUpDown1.TabIndex = 0
        Me.DomainUpDown1.Text = "DomainUpDown1"
        '
        'cmsCopy
        '
        Me.cmsCopy.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopySelectedRows, Me.CopySelectedRowsWithColumeNameToolStripMenuItem})
        Me.cmsCopy.Name = "ContextMenuStrip1"
        Me.cmsCopy.Size = New System.Drawing.Size(306, 48)
        '
        'CopySelectedRows
        '
        Me.CopySelectedRows.Name = "CopySelectedRows"
        Me.CopySelectedRows.Size = New System.Drawing.Size(305, 22)
        Me.CopySelectedRows.Text = "Copy Selected Rows"
        '
        'CopySelectedRowsWithColumeNameToolStripMenuItem
        '
        Me.CopySelectedRowsWithColumeNameToolStripMenuItem.Name = "CopySelectedRowsWithColumeNameToolStripMenuItem"
        Me.CopySelectedRowsWithColumeNameToolStripMenuItem.Size = New System.Drawing.Size(305, 22)
        Me.CopySelectedRowsWithColumeNameToolStripMenuItem.Text = "Copy Selected Rows With Column Name"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(31, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(210, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'ComboBoxExt1
        '
        Me.ComboBoxExt1.FormattingEnabled = True
        Me.ComboBoxExt1.Items.AddRange(New Object() {"1", "2", "3"})
        Me.ComboBoxExt1.Location = New System.Drawing.Point(13, 13)
        Me.ComboBoxExt1.Name = "ComboBoxExt1"
        Me.ComboBoxExt1.SelectedIndexChangedDelay = True
        Me.ComboBoxExt1.SelectedIndexChangedDelayTime = 1000
        Me.ComboBoxExt1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxExt1.TabIndex = 4
        '
        'ListViewExt1
        '
        Me.ListViewExt1.AllowRightClickCopy = True
        Me.ListViewExt1.CheckBoxes = True
        Me.ListViewExt1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListViewExt1.GridLines = True
        ListViewItem1.StateImageIndex = 0
        ListViewItem2.StateImageIndex = 0
        ListViewItem3.StateImageIndex = 0
        ListViewItem4.StateImageIndex = 0
        ListViewItem5.StateImageIndex = 0
        Me.ListViewExt1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5})
        Me.ListViewExt1.KeyColumn = 1
        Me.ListViewExt1.Location = New System.Drawing.Point(89, 53)
        Me.ListViewExt1.Name = "ListViewExt1"
        Me.ListViewExt1.Size = New System.Drawing.Size(411, 192)
        Me.ListViewExt1.TabIndex = 2
        Me.ListViewExt1.UseCompatibleStateImageBehavior = False
        Me.ListViewExt1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "col1"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "col2"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "col3"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "col4"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "col5"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "col6"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 262)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxExt1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListViewExt1)
        Me.Controls.Add(Me.DomainUpDown1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.cmsCopy.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DomainUpDown1 As System.Windows.Forms.DomainUpDown
    Friend WithEvents cmsCopy As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopySelectedRows As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopySelectedRowsWithColumeNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListViewExt1 As UI_EX.ListViewExt
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBoxExt1 As UI_EX.ComboBoxExt
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class

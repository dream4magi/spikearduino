<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscLogWatch
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.ListViewExt1 = New UI_EX.ListViewExt
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListViewExt1
        '
        Me.ListViewExt1.AllowRightClickCopy = True
        Me.ListViewExt1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListViewExt1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewExt1.FullRowSelect = True
        Me.ListViewExt1.GridLines = True
        Me.ListViewExt1.KeyColumn = 0
        Me.ListViewExt1.Location = New System.Drawing.Point(0, 100)
        Me.ListViewExt1.Name = "ListViewExt1"
        Me.ListViewExt1.Size = New System.Drawing.Size(541, 153)
        Me.ListViewExt1.TabIndex = 0
        Me.ListViewExt1.UseCompatibleStateImageBehavior = False
        Me.ListViewExt1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Header"
        Me.ColumnHeader1.Width = 125
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Log Content"
        Me.ColumnHeader2.Width = 292
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(541, 100)
        Me.Panel1.TabIndex = 1
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Time"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 256)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(541, 100)
        Me.Panel2.TabIndex = 2
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter1.Location = New System.Drawing.Point(0, 253)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(541, 3)
        Me.Splitter1.TabIndex = 3
        Me.Splitter1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(541, 100)
        Me.TextBox1.TabIndex = 0
        '
        'uscLogWatch
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.ListViewExt1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "uscLogWatch"
        Me.Size = New System.Drawing.Size(541, 356)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListViewExt1 As UI_EX.ListViewExt
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter

End Class

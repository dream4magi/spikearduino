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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.grbFilter = New System.Windows.Forms.GroupBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.cboLevel = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnApplyFilter = New System.Windows.Forms.Button
        Me.btnResetFilter = New System.Windows.Forms.Button
        Me.DateTimePickerTo = New System.Windows.Forms.DateTimePicker
        Me.chkAdvance = New System.Windows.Forms.CheckBox
        Me.chkTo = New System.Windows.Forms.CheckBox
        Me.DateTimePickerFrom = New System.Windows.Forms.DateTimePicker
        Me.chkFrom = New System.Windows.Forms.CheckBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cboHash = New System.Windows.Forms.ComboBox
        Me.cboSection = New System.Windows.Forms.ComboBox
        Me.cboThread = New System.Windows.Forms.ComboBox
        Me.cboFunction = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtLogDetail = New System.Windows.Forms.TextBox
        Me.txtLogTitle = New System.Windows.Forms.TextBox
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.lvwLog = New UI_EX.ListViewExt
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.panAdvanced = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel1.SuspendLayout()
        Me.grbFilter.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.panAdvanced.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grbFilter)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.Panel1.Size = New System.Drawing.Size(699, 121)
        Me.Panel1.TabIndex = 1
        '
        'grbFilter
        '
        Me.grbFilter.Controls.Add(Me.CheckBox1)
        Me.grbFilter.Controls.Add(Me.cboLevel)
        Me.grbFilter.Controls.Add(Me.Label2)
        Me.grbFilter.Controls.Add(Me.Label1)
        Me.grbFilter.Controls.Add(Me.btnApplyFilter)
        Me.grbFilter.Controls.Add(Me.btnResetFilter)
        Me.grbFilter.Controls.Add(Me.DateTimePickerTo)
        Me.grbFilter.Controls.Add(Me.chkAdvance)
        Me.grbFilter.Controls.Add(Me.chkTo)
        Me.grbFilter.Controls.Add(Me.DateTimePickerFrom)
        Me.grbFilter.Controls.Add(Me.chkFrom)
        Me.grbFilter.Dock = System.Windows.Forms.DockStyle.Left
        Me.grbFilter.Location = New System.Drawing.Point(2, 1)
        Me.grbFilter.Name = "grbFilter"
        Me.grbFilter.Size = New System.Drawing.Size(572, 118)
        Me.grbFilter.TabIndex = 6
        Me.grbFilter.TabStop = False
        Me.grbFilter.Text = "Filter"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(268, 62)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(136, 20)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Include level above"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'cboLevel
        '
        Me.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLevel.FormattingEnabled = True
        Me.cboLevel.Location = New System.Drawing.Point(268, 34)
        Me.cboLevel.Name = "cboLevel"
        Me.cboLevel.Size = New System.Drawing.Size(101, 24)
        Me.cboLevel.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Time"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(263, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Level"
        '
        'btnApplyFilter
        '
        Me.btnApplyFilter.Location = New System.Drawing.Point(489, 18)
        Me.btnApplyFilter.Name = "btnApplyFilter"
        Me.btnApplyFilter.Size = New System.Drawing.Size(72, 28)
        Me.btnApplyFilter.TabIndex = 4
        Me.btnApplyFilter.Text = "Apply"
        Me.btnApplyFilter.UseVisualStyleBackColor = True
        '
        'btnResetFilter
        '
        Me.btnResetFilter.Location = New System.Drawing.Point(489, 48)
        Me.btnResetFilter.Name = "btnResetFilter"
        Me.btnResetFilter.Size = New System.Drawing.Size(72, 28)
        Me.btnResetFilter.TabIndex = 5
        Me.btnResetFilter.Text = "Reset"
        Me.btnResetFilter.UseVisualStyleBackColor = True
        '
        'DateTimePickerTo
        '
        Me.DateTimePickerTo.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.DateTimePickerTo.Enabled = False
        Me.DateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerTo.Location = New System.Drawing.Point(75, 59)
        Me.DateTimePickerTo.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerTo.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerTo.Name = "DateTimePickerTo"
        Me.DateTimePickerTo.Size = New System.Drawing.Size(161, 23)
        Me.DateTimePickerTo.TabIndex = 6
        '
        'chkAdvance
        '
        Me.chkAdvance.AutoSize = True
        Me.chkAdvance.Location = New System.Drawing.Point(21, 88)
        Me.chkAdvance.Name = "chkAdvance"
        Me.chkAdvance.Size = New System.Drawing.Size(149, 20)
        Me.chkAdvance.TabIndex = 7
        Me.chkAdvance.Text = "Open Advanced Filter"
        Me.chkAdvance.UseVisualStyleBackColor = True
        '
        'chkTo
        '
        Me.chkTo.AutoSize = True
        Me.chkTo.Location = New System.Drawing.Point(21, 62)
        Me.chkTo.Name = "chkTo"
        Me.chkTo.Size = New System.Drawing.Size(42, 20)
        Me.chkTo.TabIndex = 7
        Me.chkTo.Text = "To"
        Me.chkTo.UseVisualStyleBackColor = True
        '
        'DateTimePickerFrom
        '
        Me.DateTimePickerFrom.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.DateTimePickerFrom.Enabled = False
        Me.DateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerFrom.Location = New System.Drawing.Point(75, 33)
        Me.DateTimePickerFrom.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerFrom.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerFrom.Name = "DateTimePickerFrom"
        Me.DateTimePickerFrom.Size = New System.Drawing.Size(161, 23)
        Me.DateTimePickerFrom.TabIndex = 6
        '
        'chkFrom
        '
        Me.chkFrom.AutoSize = True
        Me.chkFrom.Location = New System.Drawing.Point(21, 36)
        Me.chkFrom.Name = "chkFrom"
        Me.chkFrom.Size = New System.Drawing.Size(56, 20)
        Me.chkFrom.TabIndex = 7
        Me.chkFrom.Text = "From"
        Me.chkFrom.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.ErrorImage = Global.SmartLogWacter.My.Resources.Resources.Close_Box_Red
        Me.PictureBox1.Image = Global.SmartLogWacter.My.Resources.Resources.Close_Box_Red
        Me.PictureBox1.InitialImage = Global.SmartLogWacter.My.Resources.Resources.Close_Box_Red
        Me.PictureBox1.Location = New System.Drawing.Point(661, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'cboHash
        '
        Me.cboHash.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHash.FormattingEnabled = True
        Me.cboHash.Location = New System.Drawing.Point(440, 36)
        Me.cboHash.Name = "cboHash"
        Me.cboHash.Size = New System.Drawing.Size(118, 24)
        Me.cboHash.Sorted = True
        Me.cboHash.TabIndex = 8
        '
        'cboSection
        '
        Me.cboSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.Location = New System.Drawing.Point(158, 36)
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Size = New System.Drawing.Size(118, 24)
        Me.cboSection.Sorted = True
        Me.cboSection.TabIndex = 8
        '
        'cboThread
        '
        Me.cboThread.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboThread.FormattingEnabled = True
        Me.cboThread.Location = New System.Drawing.Point(298, 36)
        Me.cboThread.Name = "cboThread"
        Me.cboThread.Size = New System.Drawing.Size(118, 24)
        Me.cboThread.Sorted = True
        Me.cboThread.TabIndex = 8
        '
        'cboFunction
        '
        Me.cboFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFunction.FormattingEnabled = True
        Me.cboFunction.Location = New System.Drawing.Point(16, 36)
        Me.cboFunction.Name = "cboFunction"
        Me.cboFunction.Size = New System.Drawing.Size(118, 24)
        Me.cboFunction.Sorted = True
        Me.cboFunction.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Function"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(156, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Section"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtLogDetail)
        Me.Panel2.Controls.Add(Me.txtLogTitle)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 418)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(699, 133)
        Me.Panel2.TabIndex = 2
        '
        'txtLogDetail
        '
        Me.txtLogDetail.BackColor = System.Drawing.SystemColors.Window
        Me.txtLogDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLogDetail.HideSelection = False
        Me.txtLogDetail.Location = New System.Drawing.Point(0, 26)
        Me.txtLogDetail.Multiline = True
        Me.txtLogDetail.Name = "txtLogDetail"
        Me.txtLogDetail.ReadOnly = True
        Me.txtLogDetail.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLogDetail.Size = New System.Drawing.Size(699, 107)
        Me.txtLogDetail.TabIndex = 1
        '
        'txtLogTitle
        '
        Me.txtLogTitle.BackColor = System.Drawing.SystemColors.Window
        Me.txtLogTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtLogTitle.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtLogTitle.HideSelection = False
        Me.txtLogTitle.Location = New System.Drawing.Point(0, 0)
        Me.txtLogTitle.Multiline = True
        Me.txtLogTitle.Name = "txtLogTitle"
        Me.txtLogTitle.ReadOnly = True
        Me.txtLogTitle.Size = New System.Drawing.Size(699, 26)
        Me.txtLogTitle.TabIndex = 2
        Me.txtLogTitle.Text = "111"
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter1.Location = New System.Drawing.Point(0, 414)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(699, 4)
        Me.Splitter1.TabIndex = 3
        Me.Splitter1.TabStop = False
        '
        'lvwLog
        '
        Me.lvwLog.AllowMark = True
        Me.lvwLog.AllowRightClickCopy = True
        Me.lvwLog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvwLog.CheckBoxes = True
        Me.lvwLog.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader9, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader2})
        Me.lvwLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwLog.FullRowSelect = True
        Me.lvwLog.GridLines = True
        Me.lvwLog.HideSelection = False
        Me.lvwLog.KeyColumn = 0
        Me.lvwLog.Location = New System.Drawing.Point(1, 0)
        Me.lvwLog.Name = "lvwLog"
        Me.lvwLog.Size = New System.Drawing.Size(697, 213)
        Me.lvwLog.TabIndex = 2
        Me.lvwLog.UseCompatibleStateImageBehavior = False
        Me.lvwLog.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Line"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Level"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Time"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Function"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Section"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Thread"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ThreadHash"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Log Content"
        Me.ColumnHeader2.Width = 292
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel3.Controls.Add(Me.lvwLog)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 201)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Panel3.Size = New System.Drawing.Size(699, 213)
        Me.Panel3.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(438, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "ThreadHash"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(296, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Thread"
        '
        'panAdvanced
        '
        Me.panAdvanced.Controls.Add(Me.GroupBox1)
        Me.panAdvanced.Dock = System.Windows.Forms.DockStyle.Top
        Me.panAdvanced.Location = New System.Drawing.Point(0, 121)
        Me.panAdvanced.Name = "panAdvanced"
        Me.panAdvanced.Padding = New System.Windows.Forms.Padding(2, 0, 2, 8)
        Me.panAdvanced.Size = New System.Drawing.Size(699, 80)
        Me.panAdvanced.TabIndex = 3
        Me.panAdvanced.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboFunction)
        Me.GroupBox1.Controls.Add(Me.cboHash)
        Me.GroupBox1.Controls.Add(Me.cboSection)
        Me.GroupBox1.Controls.Add(Me.cboThread)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(2, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(572, 72)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Advanced Filter"
        '
        'uscLogWatch
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.panAdvanced)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.MinimumSize = New System.Drawing.Size(623, 400)
        Me.Name = "uscLogWatch"
        Me.Size = New System.Drawing.Size(699, 551)
        Me.Panel1.ResumeLayout(False)
        Me.grbFilter.ResumeLayout(False)
        Me.grbFilter.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.panAdvanced.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvwLog As UI_EX.ListViewExt
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtLogDetail As System.Windows.Forms.TextBox
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnResetFilter As System.Windows.Forms.Button
    Friend WithEvents btnApplyFilter As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtLogTitle As System.Windows.Forms.TextBox
    Friend WithEvents grbFilter As System.Windows.Forms.GroupBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DateTimePickerFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkTo As System.Windows.Forms.CheckBox
    Friend WithEvents chkFrom As System.Windows.Forms.CheckBox
    Friend WithEvents cboLevel As System.Windows.Forms.ComboBox
    Friend WithEvents cboSection As System.Windows.Forms.ComboBox
    Friend WithEvents cboFunction As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents cboHash As System.Windows.Forms.ComboBox
    Friend WithEvents cboThread As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents panAdvanced As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkAdvance As System.Windows.Forms.CheckBox

End Class

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
        Me.grbIN = New System.Windows.Forms.GroupBox
        Me.btnRTS = New System.Windows.Forms.Button
        Me.btnDTR = New System.Windows.Forms.Button
        Me.panDTR = New System.Windows.Forms.Panel
        Me.panRTS = New System.Windows.Forms.Panel
        Me.grbOUT = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.panDSR = New System.Windows.Forms.Panel
        Me.panCTS = New System.Windows.Forms.Panel
        Me.panCD = New System.Windows.Forms.Panel
        Me.grbSeial = New System.Windows.Forms.GroupBox
        Me.txtReceive = New System.Windows.Forms.TextBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnClear = New System.Windows.Forms.Button
        Me.chkAutoReceive = New System.Windows.Forms.CheckBox
        Me.txtSend = New System.Windows.Forms.TextBox
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.cboCom = New System.Windows.Forms.ComboBox
        Me.btnReloadCom = New System.Windows.Forms.Button
        Me.btnConnect = New System.Windows.Forms.Button
        Me.btnDisconnect = New System.Windows.Forms.Button
        Me.panSerialOperation = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboHandshake = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.txtDisplayBuffer = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.grbIN.SuspendLayout()
        Me.grbOUT.SuspendLayout()
        Me.grbSeial.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.panSerialOperation.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbIN
        '
        Me.grbIN.Controls.Add(Me.btnRTS)
        Me.grbIN.Controls.Add(Me.btnDTR)
        Me.grbIN.Controls.Add(Me.panDTR)
        Me.grbIN.Controls.Add(Me.panRTS)
        Me.grbIN.Dock = System.Windows.Forms.DockStyle.Left
        Me.grbIN.Location = New System.Drawing.Point(0, 0)
        Me.grbIN.Name = "grbIN"
        Me.grbIN.Size = New System.Drawing.Size(113, 75)
        Me.grbIN.TabIndex = 0
        Me.grbIN.TabStop = False
        Me.grbIN.Text = "IN"
        '
        'btnRTS
        '
        Me.btnRTS.Location = New System.Drawing.Point(61, 43)
        Me.btnRTS.Name = "btnRTS"
        Me.btnRTS.Size = New System.Drawing.Size(40, 23)
        Me.btnRTS.TabIndex = 0
        Me.btnRTS.Text = "RTS"
        Me.btnRTS.UseVisualStyleBackColor = True
        '
        'btnDTR
        '
        Me.btnDTR.Location = New System.Drawing.Point(61, 16)
        Me.btnDTR.Name = "btnDTR"
        Me.btnDTR.Size = New System.Drawing.Size(40, 23)
        Me.btnDTR.TabIndex = 0
        Me.btnDTR.Text = "DTR"
        Me.btnDTR.UseVisualStyleBackColor = True
        '
        'panDTR
        '
        Me.panDTR.BackColor = System.Drawing.Color.DarkGray
        Me.panDTR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panDTR.Location = New System.Drawing.Point(12, 20)
        Me.panDTR.Name = "panDTR"
        Me.panDTR.Size = New System.Drawing.Size(43, 14)
        Me.panDTR.TabIndex = 0
        '
        'panRTS
        '
        Me.panRTS.BackColor = System.Drawing.Color.DarkGray
        Me.panRTS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panRTS.Location = New System.Drawing.Point(12, 47)
        Me.panRTS.Name = "panRTS"
        Me.panRTS.Size = New System.Drawing.Size(43, 14)
        Me.panRTS.TabIndex = 0
        '
        'grbOUT
        '
        Me.grbOUT.Controls.Add(Me.Label3)
        Me.grbOUT.Controls.Add(Me.Label2)
        Me.grbOUT.Controls.Add(Me.Label1)
        Me.grbOUT.Controls.Add(Me.panDSR)
        Me.grbOUT.Controls.Add(Me.panCTS)
        Me.grbOUT.Controls.Add(Me.panCD)
        Me.grbOUT.Dock = System.Windows.Forms.DockStyle.Left
        Me.grbOUT.Location = New System.Drawing.Point(113, 0)
        Me.grbOUT.Name = "grbOUT"
        Me.grbOUT.Size = New System.Drawing.Size(108, 75)
        Me.grbOUT.TabIndex = 0
        Me.grbOUT.TabStop = False
        Me.grbOUT.Text = "OUT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "DSR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CTS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CD"
        '
        'panDSR
        '
        Me.panDSR.BackColor = System.Drawing.Color.DarkGray
        Me.panDSR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panDSR.Location = New System.Drawing.Point(19, 54)
        Me.panDSR.Name = "panDSR"
        Me.panDSR.Size = New System.Drawing.Size(43, 14)
        Me.panDSR.TabIndex = 0
        '
        'panCTS
        '
        Me.panCTS.BackColor = System.Drawing.Color.DarkGray
        Me.panCTS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panCTS.Location = New System.Drawing.Point(19, 34)
        Me.panCTS.Name = "panCTS"
        Me.panCTS.Size = New System.Drawing.Size(43, 14)
        Me.panCTS.TabIndex = 0
        '
        'panCD
        '
        Me.panCD.BackColor = System.Drawing.Color.DarkGray
        Me.panCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panCD.Location = New System.Drawing.Point(19, 14)
        Me.panCD.Name = "panCD"
        Me.panCD.Size = New System.Drawing.Size(43, 14)
        Me.panCD.TabIndex = 0
        '
        'grbSeial
        '
        Me.grbSeial.Controls.Add(Me.txtReceive)
        Me.grbSeial.Controls.Add(Me.Panel3)
        Me.grbSeial.Controls.Add(Me.txtSend)
        Me.grbSeial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grbSeial.Location = New System.Drawing.Point(0, 75)
        Me.grbSeial.Name = "grbSeial"
        Me.grbSeial.Padding = New System.Windows.Forms.Padding(5)
        Me.grbSeial.Size = New System.Drawing.Size(519, 155)
        Me.grbSeial.TabIndex = 0
        Me.grbSeial.TabStop = False
        Me.grbSeial.Text = "Serial"
        '
        'txtReceive
        '
        Me.txtReceive.BackColor = System.Drawing.Color.Black
        Me.txtReceive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtReceive.ForeColor = System.Drawing.Color.Lime
        Me.txtReceive.Location = New System.Drawing.Point(5, 42)
        Me.txtReceive.Multiline = True
        Me.txtReceive.Name = "txtReceive"
        Me.txtReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReceive.Size = New System.Drawing.Size(509, 88)
        Me.txtReceive.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtDisplayBuffer)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.btnClear)
        Me.Panel3.Controls.Add(Me.chkAutoReceive)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(5, 18)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(509, 24)
        Me.Panel3.TabIndex = 2
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(435, 0)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(74, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'chkAutoReceive
        '
        Me.chkAutoReceive.AutoSize = True
        Me.chkAutoReceive.Checked = True
        Me.chkAutoReceive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutoReceive.Location = New System.Drawing.Point(2, 3)
        Me.chkAutoReceive.Name = "chkAutoReceive"
        Me.chkAutoReceive.Size = New System.Drawing.Size(91, 17)
        Me.chkAutoReceive.TabIndex = 0
        Me.chkAutoReceive.Text = "Auto Receive"
        Me.chkAutoReceive.UseVisualStyleBackColor = True
        '
        'txtSend
        '
        Me.txtSend.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtSend.Location = New System.Drawing.Point(5, 130)
        Me.txtSend.Name = "txtSend"
        Me.txtSend.Size = New System.Drawing.Size(509, 20)
        Me.txtSend.TabIndex = 1
        '
        'SerialPort1
        '
        Me.SerialPort1.ReadBufferSize = 10
        '
        'cboCom
        '
        Me.cboCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCom.FormattingEnabled = True
        Me.cboCom.Location = New System.Drawing.Point(75, 11)
        Me.cboCom.Name = "cboCom"
        Me.cboCom.Size = New System.Drawing.Size(155, 21)
        Me.cboCom.TabIndex = 1
        '
        'btnReloadCom
        '
        Me.btnReloadCom.Location = New System.Drawing.Point(236, 10)
        Me.btnReloadCom.Name = "btnReloadCom"
        Me.btnReloadCom.Size = New System.Drawing.Size(75, 23)
        Me.btnReloadCom.TabIndex = 2
        Me.btnReloadCom.Text = "Reload"
        Me.btnReloadCom.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(236, 37)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 3
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(317, 37)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(75, 23)
        Me.btnDisconnect.TabIndex = 3
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'panSerialOperation
        '
        Me.panSerialOperation.Controls.Add(Me.grbSeial)
        Me.panSerialOperation.Controls.Add(Me.Panel2)
        Me.panSerialOperation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panSerialOperation.Location = New System.Drawing.Point(3, 70)
        Me.panSerialOperation.Name = "panSerialOperation"
        Me.panSerialOperation.Size = New System.Drawing.Size(519, 230)
        Me.panSerialOperation.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.grbOUT)
        Me.Panel2.Controls.Add(Me.grbIN)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(519, 75)
        Me.Panel2.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cboHandshake)
        Me.Panel1.Controls.Add(Me.cboCom)
        Me.Panel1.Controls.Add(Me.btnReloadCom)
        Me.Panel1.Controls.Add(Me.btnDisconnect)
        Me.Panel1.Controls.Add(Me.btnConnect)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(519, 67)
        Me.Panel1.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Handshake"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Com Port"
        '
        'cboHandshake
        '
        Me.cboHandshake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHandshake.FormattingEnabled = True
        Me.cboHandshake.Location = New System.Drawing.Point(75, 38)
        Me.cboHandshake.Name = "cboHandshake"
        Me.cboHandshake.Size = New System.Drawing.Size(155, 21)
        Me.cboHandshake.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(375, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 23)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "SPIKE's Utility"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 300)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(519, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(132, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'txtDisplayBuffer
        '
        Me.txtDisplayBuffer.Location = New System.Drawing.Point(370, 1)
        Me.txtDisplayBuffer.Name = "txtDisplayBuffer"
        Me.txtDisplayBuffer.Size = New System.Drawing.Size(56, 20)
        Me.txtDisplayBuffer.TabIndex = 8
        Me.txtDisplayBuffer.Text = "4096"
        Me.txtDisplayBuffer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(267, 1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Display Buffer"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 325)
        Me.Controls.Add(Me.panSerialOperation)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Text = "RS232 Viewer"
        Me.grbIN.ResumeLayout(False)
        Me.grbOUT.ResumeLayout(False)
        Me.grbOUT.PerformLayout()
        Me.grbSeial.ResumeLayout(False)
        Me.grbSeial.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.panSerialOperation.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grbIN As System.Windows.Forms.GroupBox
    Friend WithEvents grbOUT As System.Windows.Forms.GroupBox
    Friend WithEvents grbSeial As System.Windows.Forms.GroupBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents cboCom As System.Windows.Forms.ComboBox
    Friend WithEvents btnReloadCom As System.Windows.Forms.Button
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents panSerialOperation As System.Windows.Forms.Panel
    Friend WithEvents btnRTS As System.Windows.Forms.Button
    Friend WithEvents btnDTR As System.Windows.Forms.Button
    Friend WithEvents panDSR As System.Windows.Forms.Panel
    Friend WithEvents panCTS As System.Windows.Forms.Panel
    Friend WithEvents panCD As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents panDTR As System.Windows.Forms.Panel
    Friend WithEvents panRTS As System.Windows.Forms.Panel
    Friend WithEvents txtReceive As System.Windows.Forms.TextBox
    Friend WithEvents txtSend As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents chkAutoReceive As System.Windows.Forms.CheckBox
    Friend WithEvents cboHandshake As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtDisplayBuffer As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class

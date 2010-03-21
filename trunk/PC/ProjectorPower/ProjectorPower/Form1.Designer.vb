<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label2 = New System.Windows.Forms.Label
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.SerialPort2 = New System.IO.Ports.SerialPort(Me.components)
        Me.SerialPort3 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnSaveTime = New System.Windows.Forms.Button
        Me.btnConnect = New System.Windows.Forms.Button
        Me.btnDisconnect = New System.Windows.Forms.Button
        Me.btnPWRON = New System.Windows.Forms.Button
        Me.btnPWROFF = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cboCom1 = New System.Windows.Forms.ComboBox
        Me.cboCom2 = New System.Windows.Forms.ComboBox
        Me.cboCom3 = New System.Windows.Forms.ComboBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnSaveCom = New System.Windows.Forms.Button
        Me.cboONHOUR = New System.Windows.Forms.ComboBox
        Me.cboONMIN = New System.Windows.Forms.ComboBox
        Me.cboOFFHOUR = New System.Windows.Forms.ComboBox
        Me.cboOFFMIN = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Projector1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Projector2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Projector3"
        '
        'btnSaveTime
        '
        Me.btnSaveTime.Location = New System.Drawing.Point(139, 289)
        Me.btnSaveTime.Name = "btnSaveTime"
        Me.btnSaveTime.Size = New System.Drawing.Size(75, 27)
        Me.btnSaveTime.TabIndex = 2
        Me.btnSaveTime.Text = "儲存"
        Me.btnSaveTime.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(26, 115)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 3
        Me.btnConnect.Text = "連結"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(107, 115)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(75, 23)
        Me.btnDisconnect.TabIndex = 3
        Me.btnDisconnect.Text = "中斷"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'btnPWRON
        '
        Me.btnPWRON.Location = New System.Drawing.Point(26, 144)
        Me.btnPWRON.Name = "btnPWRON"
        Me.btnPWRON.Size = New System.Drawing.Size(75, 23)
        Me.btnPWRON.TabIndex = 4
        Me.btnPWRON.Text = "開機"
        Me.btnPWRON.UseVisualStyleBackColor = True
        '
        'btnPWROFF
        '
        Me.btnPWROFF.Location = New System.Drawing.Point(107, 144)
        Me.btnPWROFF.Name = "btnPWROFF"
        Me.btnPWROFF.Size = New System.Drawing.Size(75, 23)
        Me.btnPWROFF.TabIndex = 4
        Me.btnPWROFF.Text = "關機"
        Me.btnPWROFF.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(155, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = ":"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "關機時間"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(155, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 23)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = ":"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "開機時間"
        '
        'cboCom1
        '
        Me.cboCom1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCom1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCom1.FormattingEnabled = True
        Me.cboCom1.Location = New System.Drawing.Point(110, 10)
        Me.cboCom1.Name = "cboCom1"
        Me.cboCom1.Size = New System.Drawing.Size(83, 28)
        Me.cboCom1.TabIndex = 8
        '
        'cboCom2
        '
        Me.cboCom2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCom2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCom2.FormattingEnabled = True
        Me.cboCom2.Location = New System.Drawing.Point(110, 45)
        Me.cboCom2.Name = "cboCom2"
        Me.cboCom2.Size = New System.Drawing.Size(83, 28)
        Me.cboCom2.TabIndex = 8
        '
        'cboCom3
        '
        Me.cboCom3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCom3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCom3.FormattingEnabled = True
        Me.cboCom3.Location = New System.Drawing.Point(110, 79)
        Me.cboCom3.Name = "cboCom3"
        Me.cboCom3.Size = New System.Drawing.Size(83, 28)
        Me.cboCom3.TabIndex = 8
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'btnSaveCom
        '
        Me.btnSaveCom.Location = New System.Drawing.Point(199, 81)
        Me.btnSaveCom.Name = "btnSaveCom"
        Me.btnSaveCom.Size = New System.Drawing.Size(75, 27)
        Me.btnSaveCom.TabIndex = 2
        Me.btnSaveCom.Text = "儲存"
        Me.btnSaveCom.UseVisualStyleBackColor = True
        '
        'cboONHOUR
        '
        Me.cboONHOUR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboONHOUR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboONHOUR.FormattingEnabled = True
        Me.cboONHOUR.Items.AddRange(New Object() {"", "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.cboONHOUR.Location = New System.Drawing.Point(107, 204)
        Me.cboONHOUR.Name = "cboONHOUR"
        Me.cboONHOUR.Size = New System.Drawing.Size(42, 28)
        Me.cboONHOUR.TabIndex = 8
        '
        'cboONMIN
        '
        Me.cboONMIN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboONMIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboONMIN.FormattingEnabled = True
        Me.cboONMIN.Items.AddRange(New Object() {"", "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.cboONMIN.Location = New System.Drawing.Point(185, 204)
        Me.cboONMIN.Name = "cboONMIN"
        Me.cboONMIN.Size = New System.Drawing.Size(42, 28)
        Me.cboONMIN.TabIndex = 8
        '
        'cboOFFHOUR
        '
        Me.cboOFFHOUR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOFFHOUR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOFFHOUR.FormattingEnabled = True
        Me.cboOFFHOUR.Items.AddRange(New Object() {"", "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.cboOFFHOUR.Location = New System.Drawing.Point(107, 247)
        Me.cboOFFHOUR.Name = "cboOFFHOUR"
        Me.cboOFFHOUR.Size = New System.Drawing.Size(42, 28)
        Me.cboOFFHOUR.TabIndex = 8
        '
        'cboOFFMIN
        '
        Me.cboOFFMIN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOFFMIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOFFMIN.FormattingEnabled = True
        Me.cboOFFMIN.Items.AddRange(New Object() {"", "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.cboOFFMIN.Location = New System.Drawing.Point(185, 247)
        Me.cboOFFMIN.Name = "cboOFFMIN"
        Me.cboOFFMIN.Size = New System.Drawing.Size(42, 28)
        Me.cboOFFMIN.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 367)
        Me.Controls.Add(Me.cboOFFHOUR)
        Me.Controls.Add(Me.cboOFFMIN)
        Me.Controls.Add(Me.cboONMIN)
        Me.Controls.Add(Me.cboONHOUR)
        Me.Controls.Add(Me.cboCom3)
        Me.Controls.Add(Me.cboCom2)
        Me.Controls.Add(Me.cboCom1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnPWROFF)
        Me.Controls.Add(Me.btnPWRON)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.btnSaveCom)
        Me.Controls.Add(Me.btnSaveTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auto"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents SerialPort2 As System.IO.Ports.SerialPort
    Friend WithEvents SerialPort3 As System.IO.Ports.SerialPort
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSaveTime As System.Windows.Forms.Button
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents btnPWRON As System.Windows.Forms.Button
    Friend WithEvents btnPWROFF As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboCom1 As System.Windows.Forms.ComboBox
    Friend WithEvents cboCom2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboCom3 As System.Windows.Forms.ComboBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnSaveCom As System.Windows.Forms.Button
    Friend WithEvents cboONHOUR As System.Windows.Forms.ComboBox
    Friend WithEvents cboONMIN As System.Windows.Forms.ComboBox
    Friend WithEvents cboOFFHOUR As System.Windows.Forms.ComboBox
    Friend WithEvents cboOFFMIN As System.Windows.Forms.ComboBox

End Class

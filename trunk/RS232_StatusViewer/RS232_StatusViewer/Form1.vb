Imports System.IO.Ports
Imports System.Threading.Thread
Public Class Form1
    ReadOnly ENABLE_COLOR As Color = Color.Green
    ReadOnly DISABLE_COLOR As Color = Color.DarkGray
    Const DEFAULT_DISPLAY_SIZE As Integer = 4096
    Dim strDisplayBuffer As String = ""
    Dim intDisplaySize As Integer = DEFAULT_DISPLAY_SIZE

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadSerialHandShake(cboHandshake)
        loadComPortName_UI(cboCom)
        refreshSerialUI()

        AddHandler SerialPort1.PinChanged, New System.IO.Ports.SerialPinChangedEventHandler(AddressOf SerialPort1_PinChanged)
        '  AddHandler SerialPort1.DataReceived, New System.IO.Ports.SerialDataReceivedEventHandler(AddressOf SerialPort1_DataReceived)
        AddHandler SerialPort1.DataReceived, AddressOf SerialPort1_DataReceived
        AddHandler SerialPort1.ErrorReceived, New System.IO.Ports.SerialErrorReceivedEventHandler(AddressOf SerialPort1_ErrorReceived)

        intDisplaySize = getDisplayBufferSize_UI(txtDisplayBuffer)


    End Sub
    Private Sub btnReloadCom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReloadCom.Click
        loadComPortName_UI(cboCom)
    End Sub



    Sub refresh_txtReceive_UI(ByRef strContent As String)
        If strContent.Length > intDisplaySize Then
            strContent = strContent.Substring(0, intDisplaySize)
        End If
        txtReceive.Text = strContent
    End Sub


#Region "UI"
    Sub loadComPortName_UI(ByVal cbo As ComboBox)
        cbo.Items.Clear()
        For Each portName As String In My.Computer.Ports.SerialPortNames
            cbo.Items.Add(portName)
        Next
    End Sub
    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        If Not String.IsNullOrEmpty(cboCom.Text) Then
            connectToSerial(SerialPort1, cboCom.Text, CType(cboHandshake.SelectedItem, System.IO.Ports.Handshake))
            refreshSerialUI()
        End If
    End Sub

    Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click
        disconnectToSerial(SerialPort1)
        refreshSerialUI()
    End Sub
    Sub refreshSerialUI()
        btnConnect.Enabled = Not SerialPort1.IsOpen
        cboCom.Enabled = Not SerialPort1.IsOpen
        btnReloadCom.Enabled = Not SerialPort1.IsOpen

        btnDisconnect.Enabled = SerialPort1.IsOpen
        panSerialOperation.Enabled = SerialPort1.IsOpen

        setOutputPin(SerialPort1)
        setInputPin(SerialPort1)
    End Sub
    Sub loadSerialHandShake(ByVal cbo As ComboBox)
        cbo.Items.Clear()
        cbo.Items.Add(System.IO.Ports.Handshake.None)
        cbo.Items.Add(System.IO.Ports.Handshake.RequestToSend)
        cbo.Items.Add(System.IO.Ports.Handshake.XOnXOff)
        cbo.Items.Add(System.IO.Ports.Handshake.RequestToSendXOnXOff)
        If cbo.Items.Count > 0 Then
            cbo.SelectedIndex = 0
        End If

    End Sub


#End Region
#Region "INTERNAL"
    Function connectToSerial(ByVal Serial As SerialPort, ByVal portname As String, ByVal handshake As System.IO.Ports.Handshake) As Boolean
        If Serial.IsOpen Then
            Try
                Serial.Close()
                Sleep(50)
            Catch ex As Exception
            End Try
        End If

        Try
            Serial.PortName = portname
            Serial.Open()
        Catch ex As Exception
            Return False
        End Try

        Return True
    End Function

    Function disconnectToSerial(ByVal Serial As SerialPort) As Boolean
        If Serial.IsOpen Then
            Try
                Serial.Close()
                Sleep(50)
            Catch ex As Exception
                Return (False)
            End Try
        End If

        Return True
    End Function

    Function IsSerialOpen() As Boolean

        If SerialPort1.IsOpen Then
            IsSerialOpen = True
        Else
            IsSerialOpen = False
            refreshSerialUI()
        End If
    End Function

    Function ReceiveSerialData(ByVal serial As SerialPort, ByVal ifReceive As Boolean) As String
        If serial.IsOpen Then
            Sleep(50)
            Dim str As String = SerialPort1.ReadExisting
            Return str
        Else
            Return ""
        End If
    End Function

    Sub setInputPin(ByVal serial As SerialPort)
        If serial.IsOpen Then
            If serial.CDHolding Then
                panCD.BackColor = ENABLE_COLOR
            Else
                panCD.BackColor = DISABLE_COLOR
            End If

            If serial.CtsHolding Then
                panCTS.BackColor = ENABLE_COLOR
            Else
                panCTS.BackColor = DISABLE_COLOR
            End If

            If serial.DsrHolding Then
                panDSR.BackColor = ENABLE_COLOR
            Else
                panDSR.BackColor = DISABLE_COLOR
            End If


        End If

    End Sub
    Sub setOutputPin(ByVal serial As SerialPort)
        If serial.IsOpen Then
            If SerialPort1.RtsEnable Then
                panRTS.BackColor = ENABLE_COLOR
            Else
                panRTS.BackColor = DISABLE_COLOR
            End If
            If SerialPort1.DtrEnable Then
                panDTR.BackColor = ENABLE_COLOR
            Else
                panDTR.BackColor = DISABLE_COLOR
            End If
        End If
    End Sub
#End Region









    Private Sub SerialPort1_PinChanged(ByVal sender As Object, ByVal e As System.IO.Ports.SerialPinChangedEventArgs)
        setInputPin(CType(sender, System.IO.Ports.SerialPort))
    End Sub

   
    Private Sub btnDTR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDTR.Click
        SerialPort1.DtrEnable = Not SerialPort1.DtrEnable
        setOutputPin(SerialPort1)
    End Sub

    Private Sub btnRTS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRTS.Click
        SerialPort1.RtsEnable = Not SerialPort1.RtsEnable
        setOutputPin(SerialPort1)
    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs)
        If chkAutoReceive.Checked Then
            If Me.InvokeRequired Then
                Me.Invoke(New System.IO.Ports.SerialDataReceivedEventHandler(AddressOf SerialPort1_DataReceived), sender, e)
            Else
                Dim strTmp As String = ReceiveSerialData(SerialPort1, chkAutoReceive.Checked)
                strDisplayBuffer &= strTmp
                ' getDisplayBuffer(ReceiveSerialData(SerialPort1, chkAutoReceive.Checked))
                'refresh_txtReceive_UI(strDisplayBuffer)
                If strDisplayBuffer.Length > intDisplaySize Then
                    strDisplayBuffer.Substring(0, intDisplaySize)
                End If
                txtReceive.Text = strDisplayBuffer
            End If
        End If


    End Sub


    Private Sub txtSend_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSend.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            If IsSerialOpen() Then
                SerialPort1.Write(txtSend.Text)
                txtSend.Clear()
            Else
                MsgBox("SerialPort Closed.")
            End If
        End If
    End Sub


    Private Sub chkAutoReceive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutoReceive.CheckedChanged
        If chkAutoReceive.Checked Then
            txtReceive.Text &= ReceiveSerialData(SerialPort1, True)
        End If
    End Sub

 

    Private Sub SerialPort1_ErrorReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialErrorReceivedEventArgs) Handles SerialPort1.ErrorReceived
        Select Case e.EventType
            Case SerialError.Frame
                MsgBox("Frame Error.")
            Case SerialError.Overrun
                MsgBox("Character-buffer Overrun.")
            Case SerialError.RXOver
                MsgBox("Receive Buffer Full.")
            Case SerialError.RXParity
                MsgBox("RX Parity Error.")
            Case SerialError.TXFull
                MsgBox("Transfer Buffer Full.")
            Case Else
                MsgBox("Unknown Error.")
        End Select
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        strDisplayBuffer = ""
        txtReceive.Clear()


    End Sub

    Function getDisplayBufferSize_UI(ByVal txtDisplayBuffer As TextBox) As Integer
        If Not IsNumeric(txtDisplayBuffer.Text) Then
            txtDisplayBuffer.Text = CStr(DEFAULT_DISPLAY_SIZE)
            Return DEFAULT_DISPLAY_SIZE
        Else
            Return CInt(txtDisplayBuffer.Text)
        End If
    End Function

    Sub getDisplayBuffer(ByVal StringToAdd As String)
        SyncLock strDisplayBuffer
            strDisplayBuffer += StringToAdd
        End SyncLock
    End Sub
End Class

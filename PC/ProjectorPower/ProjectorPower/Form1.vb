Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each portName As String In My.Computer.Ports.SerialPortNames
            cboCom1.Items.Add(portName)
            cboCom2.Items.Add(portName)
            cboCom3.Items.Add(portName)
        Next

        cboCom1.Text = My.Settings.COM1
        cboCom2.Text = My.Settings.COM2
        cboCom3.Text = My.Settings.COM3

        cboOFFHOUR.Text = My.Settings.OFF_HOUR
        cboOFFMIN.Text = My.Settings.OFF_MIN

        cboONHOUR.Text = My.Settings.ON_HOUR
        cboONMIN.Text = My.Settings.ON_MIN

        btnConnect.PerformClick()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnPWRON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPWRON.Click

        Try

        
            If SerialPort1.IsOpen Then
                SerialPort1.Write("PWR ON")
            Else
                connectPrj1()
                SerialPort1.Write("PWR ON")
            End If

            If SerialPort2.IsOpen Then
                SerialPort2.Write("PWR ON")
            Else
                connectPrj2()
                SerialPort2.Write("PWR ON")
            End If

            If SerialPort3.IsOpen Then
                SerialPort3.Write("PWR ON")
            Else
                connectPrj3()
                SerialPort3.Write("PWR ON")
            End If
        Catch ex As Exception
            Dim str As String = "[btn Power On]  " & Now.ToString("yyyy-MM-dd HH:mm") & vbNewLine & ex.ToString & vbNewLine & vbNewLine
            My.Computer.FileSystem.WriteAllText(".\log.txt", str, True)
        End Try

    End Sub

    Private Sub btnPWROFF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPWROFF.Click
        Try

        
            If SerialPort1.IsOpen Then
                SerialPort1.Write("PWR OFF")
            Else
                connectPrj1()
                SerialPort1.Write("PWR OFF")
            End If

            If SerialPort2.IsOpen Then
                SerialPort2.Write("PWR OFF")
            Else
                connectPrj2()
                SerialPort2.Write("PWR OFF")
            End If

            If SerialPort3.IsOpen Then
                SerialPort3.Write("PWR OFF")
            Else
                connectPrj3()
                SerialPort3.Write("PWR OFF")
            End If
        Catch ex As Exception
            Dim str As String = "[btn Power Off]  " & Now.ToString("yyyy-MM-dd HH:mm") & vbNewLine & ex.ToString & vbNewLine & vbNewLine
            My.Computer.FileSystem.WriteAllText(".\log.txt", str, True)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        Try
      

         

            connectPrj1()
            connectPrj2()
            connectPrj3()
       
         

        Catch ex As Exception
            Dim str As String = "[btn Connect]  " & Now.ToString("yyyy-MM-dd HH:mm") & vbNewLine & ex.ToString & vbNewLine & vbNewLine
            My.Computer.FileSystem.WriteAllText(".\log.txt", str, True)
        End Try
    End Sub
    Sub connectPrj1()
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If
        If My.Computer.Ports.SerialPortNames.Contains(cboCom1.Text) Then
            SerialPort1.PortName = My.Settings.COM1
            SerialPort1.Open()
        End If
    End Sub
    Sub connectPrj2()
        If SerialPort2.IsOpen Then
            SerialPort2.Close()
        End If
        If My.Computer.Ports.SerialPortNames.Contains(cboCom2.Text) Then
            SerialPort2.PortName = My.Settings.COM2
            SerialPort2.Open()
        End If
    End Sub
    Sub connectPrj3()
        If SerialPort3.IsOpen Then
            SerialPort3.Close()
        End If
        If My.Computer.Ports.SerialPortNames.Contains(cboCom3.Text) Then
            SerialPort3.PortName = My.Settings.COM3
            SerialPort3.Open()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click
        Try
            If SerialPort1.IsOpen Then
                SerialPort1.Close()
            End If
            If SerialPort2.IsOpen Then
                SerialPort2.Close()
            End If
            If SerialPort3.IsOpen Then
                SerialPort3.Close()
            End If
        Catch ex As Exception
            Dim str As String = "[btn Disconnect]  " & Now.ToString("yyyy-MM-dd HH:mm") & vbNewLine & ex.ToString & vbNewLine & vbNewLine
            My.Computer.FileSystem.WriteAllText(".\log.txt", str, True)
        End Try

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            If (My.Settings.ON_HOUR = CStr(Now.Hour)) AndAlso (My.Settings.ON_MIN = CStr(Now.Minute)) Then
                btnPWRON.PerformClick()
            End If

            If (My.Settings.OFF_HOUR = CStr(Now.Hour)) AndAlso (My.Settings.OFF_MIN = CStr(Now.Minute)) Then
                btnPWROFF.PerformClick()
            End If
        Catch ex As Exception
            Dim str As String = "[Timer]  " & Now.ToString("yyyy-MM-dd HH:mm") & vbNewLine & ex.ToString & vbNewLine & vbNewLine
            My.Computer.FileSystem.WriteAllText(".\log.txt", str, True)
        End Try


    End Sub

    Private Sub btnSaveCom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveCom.Click
        My.Settings.COM1 = cboCom1.Text
        My.Settings.COM2 = cboCom2.Text
        My.Settings.COM3 = cboCom3.Text
    End Sub



    Private Sub btnSaveTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveTime.Click
        My.Settings.ON_HOUR = cboONHOUR.Text
        My.Settings.ON_MIN = cboONMIN.Text
        My.Settings.OFF_HOUR = cboOFFHOUR.Text
        My.Settings.OFF_MIN = cboOFFMIN.Text
    End Sub
End Class

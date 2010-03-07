Imports System.Text
Imports System.IO.Ports

Public Class frmMain
    Dim data As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            AddHandler SerialPort1.DataReceived, AddressOf DoData
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False


            getPort()

            GroupBox1.Enabled = False
            ComboBox2.Text = "115200"
            ComboBox1.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub DoData(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs)
        Try
            If SerialPort1.IsOpen AndAlso CheckBox1.Checked Then
                data &= SerialPort1.ReadExisting()
                TextBox1.Text = data
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub getPort()
        ComboBox1.Items.Clear()
        For Each portName As String In My.Computer.Ports.SerialPortNames
            ComboBox1.Items.Add(portName)
        Next
    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click

        Try

            If btnConnect.Text.ToUpper.Equals("CONNECT") AndAlso Not String.IsNullOrEmpty(ComboBox1.Text) AndAlso Not SerialPort1.IsOpen AndAlso Not String.IsNullOrEmpty(ComboBox1.Text) Then
                SerialPort1.PortName = ComboBox1.Text
                SerialPort1.BaudRate = ComboBox2.Text
                SerialPort1.Open()
                If SerialPort1.IsOpen Then
                    btnConnect.Text = "Disconnect"
                    ComboBox1.Enabled = False
                    ComboBox2.Enabled = False
                    GroupBox1.Enabled = True
                    Button2.Enabled = False
                End If
            ElseIf btnConnect.Text.ToUpper.Equals("DISCONNECT") AndAlso SerialPort1.IsOpen Then
                Button3.PerformClick()
                SerialPort1.Close()
                If Not SerialPort1.IsOpen Then
                    btnConnect.Text = "Connect"
                    ComboBox1.Enabled = True
                    ComboBox2.Enabled = True
                    GroupBox1.Enabled = False
                    Label1.Text = ""
                    Button2.Enabled = True
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Dim pin As Integer = -1
    Dim onoff As Integer = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If SerialPort1.IsOpen Then




                If onoff = 1 Then
                    onoff = 0

                ElseIf onoff = 0 Then
                    onoff = 1
                    If pin = 50 Then
                        pin = 0
                    Else
                        pin = pin + 1
                    End If


                End If

                Dim str As String = String.Format("A{0}{1}Z", pin, onoff)
                Label1.Text = String.Format("A {0} {1} Z", pin, onoff)
                SerialPort1.Write(str)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        getPort()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try

            SerialPort1.Write("A00Z")
            Label1.Text = ""
            pin = -1
            onoff = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            TextBox1.Text = SerialPort1.ReadExisting
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Timer1.Enabled = Not Timer1.Enabled
    End Sub

    Dim pin2 As Integer = -1
    Dim onoff2 As Integer = 0
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try


            If SerialPort1.IsOpen Then




                If onoff2 = 1 Then
                    onoff2 = 0

                ElseIf onoff2 = 0 Then
                    onoff2 = 1
                    If pin2 = 50 Then
                        'Timer1.Enabled = False
                        pin2 = -1
                        onoff2 = 0
                        Label1.Text = "Done!"
                        Exit Sub
                    Else
                        pin2 = pin2 + 1
                    End If


                End If

                Dim str As String = String.Format("A{0}{1}Z", pin2, onoff2)
                Label1.Text = String.Format("A {0} {1} Z", pin2, onoff2)
                SerialPort1.Write(str)
            Else
                Timer1.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class

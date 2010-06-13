
Public Class BrisaLogger

    Const LOG_FOLDER As String = ".\Log"
    Const LOG_EXTENTION As String = "BrisaLog"
    Const LOG_LEVEL As SmartLog.LogType = SmartLog.LogType.Info
    Const LOG_EXPIRE_DAYS As Integer = 90

    Enum EventType
        AppFrameWork = 0
        SendTrx = 1
        TrxResult = 2
        UIOperation = 3
        EqpEvent = 4
        ComponentEvent = 5
    End Enum

    Private Shared p_isConfigSet As Boolean = False
    Shared ReadOnly Property isConfigSet() As Boolean
        Get
            Return p_isConfigSet
        End Get
    End Property

    Public Shared Function Info(ByVal EventType As EventType, ByVal Sender As Object, ByVal LogMessege As String) As Boolean
        Try
            setConfig()
            Return SmartLog.Info(EventType.ToString, Sender.GetType.Name, LogMessege)
        Catch ex As Exception
        End Try
        Return False
    End Function
    Public Shared Function Debug(ByVal EventType As EventType, ByVal Sender As Object, ByVal LogMessege As String) As Boolean
        Try
            setConfig()
            Return SmartLog.Debug(EventType.ToString, Sender.GetType.Name, LogMessege)
        Catch ex As Exception
        End Try
        Return False
    End Function
    Public Shared Function Warn(ByVal EventType As EventType, ByVal Sender As Object, ByVal LogMessege As String) As Boolean
        Try
            setConfig()
            Return SmartLog.Warn(EventType.ToString, Sender.GetType.Name, LogMessege)
        Catch ex As Exception
        End Try
        Return False
    End Function
    Public Shared Function [Error](ByVal EventType As EventType, ByVal Sender As Object, ByVal LogMessege As String) As Boolean
        Try
            setConfig()
            Return SmartLog.[Error](EventType.ToString, Sender.GetType.Name, LogMessege)
        Catch ex As Exception
        End Try
        Return False
    End Function
    Public Shared Function Fatal(ByVal EventType As EventType, ByVal Sender As Object, ByVal LogMessege As String) As Boolean
        Try
            setConfig()
            Return SmartLog.Fatal(EventType.ToString, Sender.GetType.Name, LogMessege)
        Catch ex As Exception
        End Try
        Return False
    End Function

    Shared Function setConfig() As Boolean
        Try
            If Not isConfigSet Then
                SmartLog.AppName = My.Application.Info.AssemblyName
                SmartLog.LogFolder = LOG_FOLDER
                SmartLog.LogLevel = SmartLog.LogType.Info
                SmartLog.Extention = LOG_EXTENTION
                SmartLog.ExpireDays = LOG_EXPIRE_DAYS
                p_isConfigSet = True
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function










End Class

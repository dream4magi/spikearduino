Imports System.Threading
Imports System.Threading.ThreadPool
Imports System.Collections.ObjectModel


Public Class SmartLog
    Enum LogType
        Info = 0
        Debug = 1
        Warn = 2
        [Error] = 3
        Fatal = 4
    End Enum

    Const DEFAULT_LOG_FOLDER As String = ".\SmartLog"
    Const DEFAULT_APP_NAME As String = "App Name"
    Const DEFAULT_EXTENTION As String = "log"
    Const DEFAULT_EXPIRE_DAYS As Integer = 90
    Private Const DATE_FORMAT As String = "yyyyMMdd"
    Private Const TIME_FORMAT As String = "yyyy/MM/dd HH:mm:ss.fff"
    Private Const YEARMONTH_FORMAT As String = "yyyyMM"



#Region "Shared"
    'Private Shared WithEvents tmr As New System.Threading.Timer(New System.Threading.TimerCallback(AddressOf WriteAllLog), Nothing, 250, 250)
    Private Shared dicThreadLogObject As New Dictionary(Of Threading.Thread, LogObject)
    Private Shared MainLogObject As New LogObject(False)
    Private Shared mConfigFilename As String = ""

#Region "property"
    Private Shared p_isInitialized As Boolean = False
    Shared ReadOnly Property isInitialized() As Boolean
        Get
            Return p_isInitialized
        End Get
    End Property

    Private Shared p_ExpireDays As Integer = DEFAULT_EXPIRE_DAYS
    Shared Property ExpireDays() As Integer
        Get
            Return p_ExpireDays
        End Get
        Set(ByVal value As Integer)
            If value < 1 Then
                Throw New Exception("ExpireDays must be equal or greater then 1.")
            End If
            p_ExpireDays = value
        End Set
    End Property

    Private Shared p_Extention As String = DEFAULT_EXTENTION
    Shared Property Extention() As String
        Get
            Return p_Extention
        End Get
        Set(ByVal value As String)
            p_Extention = value
        End Set
    End Property
    Private Shared p_LogFolder As String = DEFAULT_LOG_FOLDER
    Shared Property LogFolder() As String
        Get
            Return p_LogFolder
        End Get
        Set(ByVal value As String)
            p_LogFolder = value
        End Set
    End Property
    Private Shared p_AppName As String = DEFAULT_APP_NAME
    Shared Property AppName() As String
        Get
            Return p_AppName
        End Get
        Set(ByVal value As String)
            p_AppName = value
        End Set
    End Property
    Private Shared p_LogLevel As LogType = LogType.Info
    Shared Property LogLevel() As LogType
        Get
            Return p_LogLevel
        End Get
        Set(ByVal value As LogType)
            p_LogLevel = value
        End Set
    End Property
#End Region

#End Region

#Region "Public"
    Public Shared Function Fatal(ByVal FunctionName As String, ByVal SectionName As String, ByVal Messege As String) As Boolean
        If p_LogLevel <= LogType.Fatal Then
            Return getLogObject.Fatal(FunctionName, SectionName, Messege)
        Else
            Return False
        End If
    End Function
    Public Shared Function [Error](ByVal FunctionName As String, ByVal SectionName As String, ByVal Messege As String) As Boolean
        If p_LogLevel <= LogType.Error Then
            Return getLogObject.Error(FunctionName, SectionName, Messege)
        Else
            Return False
        End If
    End Function
    Public Shared Function Warn(ByVal FunctionName As String, ByVal SectionName As String, ByVal Messege As String) As Boolean
        If p_LogLevel <= LogType.Warn Then
            Return getLogObject.Warn(FunctionName, SectionName, Messege)
        Else
            Return False
        End If
    End Function
    Public Shared Function Debug(ByVal FunctionName As String, ByVal SectionName As String, ByVal Messege As String) As Boolean
        If p_LogLevel <= LogType.Debug Then
            Return getLogObject.Debug(FunctionName, SectionName, Messege)
        Else
            Return False
        End If
    End Function
    Public Shared Function Info(ByVal FunctionName As String, ByVal SectionName As String, ByVal Messege As String) As Boolean
        If p_LogLevel <= LogType.Info Then

            Return getLogObject.Info(FunctionName, SectionName, Messege)
        Else
            Return False
        End If
    End Function

#Region "Add/ Remove"
    Public Shared Function RemoveThreadLog(ByVal Thd As Thread) As Boolean
        Try
            dicThreadLogObject.Remove(Thd)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function RemoveThreadLog() As Boolean
        Return RemoveThreadLog(Thread.CurrentThread)
    End Function
    Public Shared Function AddThreadLog(ByVal Thd As Thread) As Boolean
        If Not dicThreadLogObject.ContainsKey(Thd) Then
            Dim oLogObject As New LogObject(True)
            Try
                dicThreadLogObject.Add(Thd, oLogObject)
                Return True
            Catch ex As Exception
                Return False
            End Try
        End If
        Return False
    End Function
    Public Shared Function AddThreadLog() As Boolean
        Return AddThreadLog(Thread.CurrentThread)
    End Function
#End Region


#End Region
#Region "Private Shared Function "
    Private Shared Function DelExpiredLogs() As Boolean
        Try
            For i As Integer = ExpireDays To ExpireDays + 60

                Dim ts As TimeSpan = TimeSpan.FromDays(i)

                Dim DelDate As Date = Now - ts

                Dim strLogFolder As String = LogFolder & "\" & getYearMonth(DelDate)

                Dim folderExists As Boolean
                folderExists = My.Computer.FileSystem.DirectoryExists(strLogFolder)
                If Not folderExists Then
                    Continue For
                End If

                Dim strLogfilenamePreFix As String = String.Format("{0}_{1}", AppName, getDate(DelDate))

                Dim files As ReadOnlyCollection(Of String)
                files = My.Computer.FileSystem.GetFiles(strLogFolder, FileIO.SearchOption.SearchTopLevelOnly, "*." & Extention)
                If files.Count < 1 Then
                    Continue For
                End If

                For Each file As String In files
                    If System.IO.Path.GetFileName(file).StartsWith(strLogfilenamePreFix) Then
                        Try
                            System.IO.File.Delete(file)
                        Catch ex As Exception

                        End Try
                    End If
                Next

            Next
        Catch ex As Exception
        End Try
        Return True
    End Function
    Private Shared Function getLogObject() As LogObject
        'If MainLogObject Is Nothing Then
        '    MainLogObject = New LogObject
        'End If
        getLogObject = MainLogObject
        Try
            getLogObject = dicThreadLogObject(Thread.CurrentThread)
        Catch ex As Exception

        End Try
    End Function

    Private Shared Function getDate(Optional ByVal [Date] As Date = Nothing) As String
        If [Date] = Nothing Then
            [Date] = Now
        End If
        Return [Date].ToString(DATE_FORMAT)
    End Function
    Private Shared Function getNowTime(Optional ByVal [Date] As Date = Nothing) As String
        If [Date] = Nothing Then
            [Date] = Now
        End If
        Return [Date].ToString(TIME_FORMAT)
    End Function
    Private Shared Function getYearMonth(Optional ByVal [Date] As Date = Nothing) As String
        If [Date] = Nothing Then
            [Date] = Now
        End If
        Return [Date].ToString(YEARMONTH_FORMAT)
    End Function


#End Region














    Private Class LogObject


        '  Private lstLog As New List(Of String)
#Region "Public"
        Public Function Fatal(ByVal FunctionName As String, ByVal SectionName As String, ByVal Messege As String) As Boolean
            Return AddLog(LogType.Fatal, FunctionName, SectionName, Messege)
        End Function
        Public Function [Error](ByVal FunctionName As String, ByVal SectionName As String, ByVal Messege As String) As Boolean
            Return AddLog(LogType.[Error], FunctionName, SectionName, Messege)
        End Function
        Public Function Warn(ByVal FunctionName As String, ByVal SectionName As String, ByVal Messege As String) As Boolean
            Return AddLog(LogType.Warn, FunctionName, SectionName, Messege)
        End Function
        Public Function Debug(ByVal FunctionName As String, ByVal SectionName As String, ByVal Messege As String) As Boolean
            Return AddLog(LogType.Debug, FunctionName, SectionName, Messege)
        End Function
        Public Function Info(ByVal FunctionName As String, ByVal SectionName As String, ByVal Messege As String) As Boolean
            Return AddLog(LogType.Info, FunctionName, SectionName, Messege)
        End Function
#End Region

#Region "Property"
        ReadOnly Property LogFileName() As String
            Get
                Return getLogPath() & "\" & getLogFileName()
            End Get
        End Property
        Private p_ThreadingName As String = ""
        ReadOnly Property ThreadingName() As String
            Get
                Return p_ThreadingName
            End Get
        End Property
        Private p_ThreadingHashCode As String = ""
        ReadOnly Property ThreadingHashCode() As String
            Get
                Return p_ThreadingHashCode
            End Get
        End Property
        Private p_isThreadLog As Boolean = False
        ReadOnly Property isThreadLog() As Boolean
            Get
                Return p_isThreadLog
            End Get
        End Property
#End Region

        Public Sub New(Optional ByVal isThreadLog As Boolean = False)
            If isThreadLog Then
                p_ThreadingName = Thread.CurrentThread.Name
                p_ThreadingHashCode = Thread.CurrentThread.ToString.PadLeft(8, "0"c)
            End If
            p_isThreadLog = isThreadLog
        End Sub



#Region "private Function "
        Private Function AddLog(ByVal LogType As LogType, ByVal FunctionName As String, ByVal SectionName As String, ByVal Messege As String) As Boolean

            If Not p_isInitialized Then
                p_isInitialized = True
                DelExpiredLogs()
            End If

            Dim strNowTime As String = getDate()
            Dim strLogHeader As String = String.Format("[{0}][{1}][{2}][{3}][{4}][{5}]", getNowTime, LogType.ToString, FunctionName, SectionName, CStr(IIf(isThreadLog, p_ThreadingName, Thread.CurrentThread.Name)), CStr(IIf(isThreadLog, p_ThreadingHashCode, Thread.CurrentThread.GetHashCode)))
            Dim strLog As String = strLogHeader & vbNewLine & Messege & vbNewLine & vbNewLine
            Dim strLogPath As String = getLogPath()
            Dim strLogFileName As String = getLogFileName()

            Try
                NewThreadWriteLog(strLogPath, strLogPath & "\" & strLogFileName, strLog)
                Return True
            Catch ex As Exception

            End Try
            Return False
        End Function

        Private Sub NewThreadWriteLog(ByVal LogFolder As String, ByVal FullFileName As String, ByVal LogContent As String)
            'Dim thd As New Thread(AddressOf WriteLog)
            'thd.Name = "TmpWriteLogThread"
            'thd.IsBackground = True
            'thd.Priority = ThreadPriority.BelowNormal
            'thd.Start(New Object() {LogFolder, FullFileName, LogContent})
            ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf WriteLog), New Object() {LogFolder, FullFileName, LogContent})

        End Sub
        Private Sub WriteLog(ByVal arg As Object)
            Dim args() As Object = CType(arg, Object())
            My.Computer.FileSystem.CreateDirectory(CStr(args(0)))
            SyncLock "WriteLog"
                My.Computer.FileSystem.WriteAllText(CStr(args(1)), CStr(args(2)), True)
            End SyncLock
        End Sub
        'Friend Sub WriteLog()
        '    SyncLock lstLog
        '        If lstLog.Count > 0 Then

        '            Dim strAllLog As String = ""

        '            For Each Str As String In lstLog
        '                strAllLog &= Str
        '            Next

        '            Dim strLogPath As String = getLogPath()
        '            Dim strLogFileName As String = getLogFileName()

        '            My.Computer.FileSystem.CreateDirectory(strLogPath)


        '            My.Computer.FileSystem.WriteAllText(strLogPath & "\" & strLogFileName, strAllLog, True)
        '            lstLog.Clear()
        '            'tmr.Enabled = False

        '        End If
        '    End SyncLock



        'End Sub
        Private Function getLogPath() As String
            'Dim strToday As String = getDate()
            Dim strYearMonth As String = getYearMonth()
            Return String.Format("{0}\{1}", LogFolder, strYearMonth)
        End Function
        Private Function getLogFileName() As String
            Dim strToday As String = getDate()
            'Dim strYearMonth As String = getYearMonth()
            If Not isThreadLog Then
                Return String.Format("{0}_{1}.log", AppName, strToday)
            Else
                Return String.Format("{0}_{1}_{2}_{3}.{4}", AppName, strToday, ThreadingName, ThreadingHashCode, p_Extention)
            End If
        End Function
#End Region

        'Private Sub doWriteLog(ByVal oLogEntry As LogEntry)
        '    doWriteLogEntry(oLogEntry)
        '    '            ThreadPool.QueueUserWorkItem(AddressOf doWriteLogEntry, oLogEntry)
        'End Sub
        'Private Sub doWriteLogEntry(ByVal oLogEntry As LogEntry)
        '    'Do Write Log


        'End Sub




    End Class

    'Private Class LogEntry
    '    Private p_LogTime As Date = Now
    '    Property LogTime() As Date
    '        Get
    '            Return p_LogTime
    '        End Get
    '        Set(ByVal value As Date)
    '            p_LogTime = value
    '        End Set
    '    End Property

    '    Private p_FunctionName As String = ""
    '    Property FunctionName() As String
    '        Get
    '            Return p_FunctionName
    '        End Get
    '        Set(ByVal value As String)
    '            p_FunctionName = value
    '        End Set
    '    End Property
    '    Private p_SectionName As String = ""
    '    Property SectionName() As String
    '        Get
    '            Return p_SectionName
    '        End Get
    '        Set(ByVal value As String)
    '            p_SectionName = value
    '        End Set
    '    End Property
    '    Private p_Messege As String = ""
    '    Property Messege() As String
    '        Get
    '            Return p_Messege
    '        End Get
    '        Set(ByVal value As String)
    '            p_Messege = value
    '        End Set
    '    End Property
    '    Private p_LogObject As LogObject = Nothing
    '    Property LogObject() As LogObject
    '        Get
    '            Return p_LogObject
    '        End Get
    '        Set(ByVal value As LogObject)
    '            p_LogObject = value
    '        End Set
    '    End Property
    '    Public Sub New(ByVal FunctionName As String, ByVal SectionName As String, ByVal Messege As String, ByVal LogObject As LogObject, Optional ByVal LogTime As Date = Nothing)
    '        If LogTime = Nothing Then
    '            Me.LogTime = LogTime
    '        End If

    '        Me.FunctionName = FunctionName
    '        Me.SectionName = SectionName
    '        Me.Messege = Messege
    '        Me.LogObject = LogObject



    '    End Sub
    'End Class

    'Private Shared Sub WriteAllLog(ByVal state As Object)
    '    If MainLogObject IsNot Nothing Then
    '        MainLogObject.WriteLog()
    '    End If


    '    For Each obj As System.Collections.Generic.KeyValuePair(Of System.Threading.Thread, SmartLog.LogObject) In dicThreadLogObject
    '        obj.Value.WriteLog()
    '    Next



    'End Sub


End Class

Public Class clsSmartLogDoc

    Private p_dicLogItems As New Dictionary(Of Integer, clsLogItem)
    'Private p_lstLogItems As New List(Of clsLogItem)

    'ReadOnly Property lstLogItems() As List(Of clsLogItem)
    '    Get
    '        Return p_lstLogItems
    '    End Get
    'End Property
    ReadOnly Property dicLogItems() As Dictionary(Of Integer, clsLogItem)
        Get
            Return p_dicLogItems
        End Get
    End Property

    Public Shared Function getLogList(ByVal LogFilename As String) As Dictionary(Of Integer, clsLogItem)

        Dim o As New clsSmartLogDoc(LogFilename)

        Return o.p_dicLogItems
    End Function
    Public Sub New(ByVal LogFilename As String)
        ReadLogFile(LogFilename)
    End Sub

    Public Function ReadLogFile(ByVal FullFileName As String) As Boolean
        If Not System.IO.File.Exists(FullFileName) Then
            Return False
        End If






        Dim fileContents As String
        fileContents = My.Computer.FileSystem.ReadAllText(FullFileName)

        Dim lines() As String = Strings.Split(fileContents, vbNewLine)


        Dim lstLineNo As New List(Of Integer)
        For i As Integer = 0 To lines.Length - 1
            Dim LineNo As Integer = i + 1

            If isLineTitle(lines(i)) Then
                Dim oLogItem As clsLogItem = getLogItemTitle(lines(i))
                oLogItem.LineNo = LineNo
                p_dicLogItems.Add(LineNo, oLogItem)
                'p_lstLogItems.Add(oLogItem)
                lstLineNo.Add(LineNo)
            End If

        Next



        For i As Integer = 0 To lstLineNo.Count - 1
            Dim logContent As String = ""
            If i < lstLineNo.Count - 1 Then
                For j As Integer = lstLineNo(i) To lstLineNo(i + 1) - 2
                    logContent &= lines(j).Trim & vbNewLine
                Next
            Else
                For j As Integer = lstLineNo(i) To lines.Length - 1
                    logContent &= lines(j).Trim & vbNewLine
                Next

            End If

            Try
                p_dicLogItems(lstLineNo(i)).LogContent = logContent
            Catch ex As Exception

            End Try

        Next












    End Function
    Private Function getLogItemTitle(ByVal strLineContent As String) As clsLogItem
        Dim cols() As String = Strings.Split(strLineContent, "]")
        Dim oLogItem As clsLogItem = Nothing
        ' For i As Integer = 0 To 6


        Dim oLogType As LogType = LogType.Info
        Dim strLogType As String = cols(1).Substring(1)

        Select Case strLogType.ToUpper
            Case LogType.Info.ToString.ToUpper
                oLogType = LogType.Info
            Case LogType.Debug.ToString.ToUpper
                oLogType = LogType.Debug
            Case LogType.Warn.ToString.ToUpper
                oLogType = LogType.Warn
            Case LogType.Error.ToString.ToUpper
                oLogType = LogType.Error
            Case LogType.Fatal.ToString.ToUpper
                oLogType = LogType.Fatal

        End Select
        Try
            oLogItem = New clsLogItem(CDate(cols(0).Substring(1)), oLogType, cols(2).Substring(1), cols(3).Substring(1), cols(4).Substring(1), cols(5).Substring(1), strLineContent, "")
        Catch ex As Exception

        End Try

        'Next

        Return oLogItem
    End Function
    Private Function isLineTitle(ByVal strLineContent As String) As Boolean
        If Not strLineContent.Contains("[") OrElse Not strLineContent.Contains("]") Then
            Return False
        End If
        If Not strLineContent.StartsWith("[") OrElse Not strLineContent.EndsWith("]") Then
            Return False
        End If

        If strLineContent.Split("["c).Length <> 7 Then
            Return False
        End If
        If strLineContent.Split("]"c).Length <> 7 Then
            Return False
        End If

        Return True

    End Function


    
End Class

Public Class clsLogItem

    Public Sub New(ByVal Time As Date, ByVal [LogType] As LogType, ByVal FunctionName As String, ByVal SectionName As String, ByVal ThreadName As String, ByVal ThreadHash As String, ByVal Title As String, ByVal Content As String)
        With Me
            .LogTime = Time
            .LogType = [LogType]
            .LogFunction = FunctionName
            .LogSection = SectionName
            .LogThreadName = ThreadName
            .LogThreadHash = ThreadHash
            .LogTitle = Title
            .LogContent = Content
        End With
    End Sub



#Region "property"
    Private p_LogTitle As String = ""
    Property LogTitle() As String
        Get
            Return p_LogTitle
        End Get
        Set(ByVal value As String)
            p_LogTitle = value
        End Set
    End Property

    Private p_LineNo As Integer = 0
    Property LineNo() As Integer
        Get
            Return p_LineNo
        End Get
        Set(ByVal value As Integer)
            p_LineNo = value
        End Set
    End Property
    Private p_LogTime As Date = Nothing
    Property LogTime() As Date
        Get
            Return p_LogTime
        End Get
        Set(ByVal value As Date)
            p_LogTime = value
        End Set
    End Property

    Private p_LogType As LogType = LogType.Info
    Property LogType() As LogType
        Get
            Return p_LogType
        End Get
        Set(ByVal value As LogType)
            p_LogType = value
        End Set
    End Property

    Private p_LogFunction As String = ""
    Property LogFunction() As String
        Get
            Return p_LogFunction
        End Get
        Set(ByVal value As String)
            p_LogFunction = value
        End Set
    End Property

    Private p_LogSection As String = ""
    Property LogSection() As String
        Get
            Return p_LogSection
        End Get
        Set(ByVal value As String)
            p_LogSection = value
        End Set
    End Property

    Private p_LogThreadName As String = ""
    Property LogThreadName() As String
        Get
            Return p_LogThreadName
        End Get
        Set(ByVal value As String)
            p_LogThreadName = value
        End Set
    End Property
    Private p_LogThreadHash As String = ""
    Property LogThreadHash() As String
        Get
            Return p_LogThreadHash
        End Get
        Set(ByVal value As String)
            p_LogThreadHash = value
        End Set
    End Property

    Private p_LogContent As String = ""
    Property LogContent() As String
        Get
            Return p_LogContent
        End Get
        Set(ByVal value As String)
            p_LogContent = value
        End Set
    End Property

#End Region



End Class

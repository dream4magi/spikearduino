Public Class clsSmartLogDoc

    Private dicLogItems As New Dictionary(Of Integer, clsLogItem)



    Public Function ReadLogFile(ByVal FullFileName As String) As Boolean
        If System.IO.File.Exists(FullFileName) Then
            Return False
        End If






        Dim fileContents As String
        fileContents = My.Computer.FileSystem.ReadAllText(FullFileName)



    End Function
End Class

Class clsLogItem

    Public Sub New(ByVal Time As Date, ByVal FunctionName As String, ByVal SectionName As String, ByVal ThreadName As String, ByVal ThreadHash As String, ByVal Content As String)
        With Me
            .LogTime = Time
            .LogFunction = FunctionName
            .LogSection = SectionName
            .LogThreadName = ThreadName
            .LogThreadHash = ThreadHash
            .LogContent = Content
        End With
    End Sub



#Region "property"
    Private p_LogTime As Date = Nothing
    Property LogTime() As Date
        Get
            Return p_LogTime
        End Get
        Set(ByVal value As Date)
            p_LogTime = value
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

Public Class Cmd



    Enum enumCmdType
        Swing



    End Enum


    Public CmdType As enumCmdType
    Public value1 As Integer
    Public value2 As Integer
    Public times As Integer
    Public TimeSpan As Integer




    Public Sub New(ByVal _CmdType As enumCmdType, ByVal _value1 As Integer, ByVal _value2 As Integer, ByVal _times As Integer, ByVal Time As Integer)
        CmdType = _CmdType
        value1 = _value1
        value2 = _value2
        times = _times
        TimeSpan = Time
    End Sub
End Class

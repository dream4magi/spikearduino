Public Class Servo
    Private p_level As Integer

    Public Event LevelChanged(ByVal sender As Object, ByVal Level As Integer)
    
    Const SERVO_MAX_LEVEL As Integer = 20
    Const SERVO_MIN_LEVEL As Integer = 1

    Property Level() As Integer
        Get
            Return CInt(p_level)
        End Get
        Set(ByVal value As Integer)
            setServerLevel(value)
            doLevelChanged()
        End Set
    End Property
    

    Public Sub Move(ByVal Offset As Integer)
        setServerLevel(Level + Offset)
    End Sub


    Private Sub doLevelChanged()
        RaiseEvent LevelChanged(Me, Level)
    End Sub

    Private Sub setServerLevel(ByVal _Level As Integer)
        If _Level > SERVO_MAX_LEVEL Then
            Level = SERVO_MAX_LEVEL
        ElseIf _Level < SERVO_MIN_LEVEL Then
            Level = SERVO_MIN_LEVEL
        Else
            Level = _Level
        End If

    End Sub

    Public Class ServoException
        Inherits Exception
        Protected Sub New(ByVal info As System.Runtime.Serialization.SerializationInfo, ByVal context As System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
        End Sub
        Public Sub New()
            MyBase.New()
        End Sub
        Public Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub

        Public Sub New(ByVal message As String, ByVal innerException As System.Exception)
            MyBase.New(message, innerException)
        End Sub
    End Class
End Class

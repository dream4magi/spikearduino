Public Class frmMain

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Threading.Thread.CurrentThread.Name = "MainThread"
        BrisaLogger.Info(BrisaLogger.EventType.AppFrameWork, Me, "test")
        BrisaLogger.Info(BrisaLogger.EventType.SendTrx, Me, "test2")
        'SmartLog.AppName = "BrisaOPI"
        'SmartLog.AddThreadLog(New Threading.Thread(AddressOf a))
        'Threading.Thread.Sleep(2000)
        'Dim t1 As Date = Now
        'For i As Integer = 0 To 100
        '    'Dim i As Integer = 1
        '    SmartLog.Info("Function" & i.ToString, "Section" & i.ToString, "Msgsdfdsfsdfsdf   " & i.ToString)
        '    'Threading.Thread.Sleep(1000)
        '    SmartLog.Debug("Function" & i.ToString, "Section" & i.ToString, "Msgsdfdsfsdfsdf   " & i.ToString)
        '    'Threading.Thread.Sleep(1000)
        '    SmartLog.Warn("Function" & i.ToString, "Section" & i.ToString, "Msgsdfdsfsdfsdf   " & i.ToString)
        '    'Threading.Thread.Sleep(1000)
        '    SmartLog.Error("Function" & i.ToString, "Section" & i.ToString, "Msgsdfdsfsdfsdf   " & i.ToString)
        '    'Threading.Thread.Sleep(1000)
        '    SmartLog.Fatal("Function" & i.ToString, "Section" & i.ToString, "Msgsdfdsfsdfsdf   " & i.ToString)
        '    'Threading.Thread.Sleep(1000)
        'Next
        'Dim t2 As Date = Now

        'Dim ts As TimeSpan = t2 - t1
        'MsgBox(ts.TotalSeconds.ToString)
    End Sub
    Sub a()

    End Sub
End Class


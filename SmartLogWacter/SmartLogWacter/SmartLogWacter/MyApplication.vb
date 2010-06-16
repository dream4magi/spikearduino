Namespace My
    Partial Friend Class MyApplication

        Private Sub MyApplication_StartupNextInstance(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            Env.MAIN_FORM.startUp(e.CommandLine)
            e.BringToForeground = True

        End Sub

        Private Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            MsgBox("Oooooooooooops! My bad..." & vbNewLine, MsgBoxStyle.Critical Or MsgBoxStyle.YesNo, "Oh!")
        End Sub
    End Class
End Namespace


'NOTE: This file is auto-generated; do not modify it directly.  To make changes,
' or if you encounter build errors in this file, go to the Project Designer
' (go to Project Properties or double-click the My Project node in
' Solution Explorer), and make changes on the Application tab.
'

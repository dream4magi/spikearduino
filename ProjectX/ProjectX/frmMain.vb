Public Class frmMain

    Dim Process As New Process



    Sub showListCmd(ByVal lstCmd As lstCmd)
        ListViewExt1.Items.Clear()

        For i As Integer = 0 To lstCmd.Count - 1
            With lstCmd(i)
                ListViewExt1.Items.Add(New ListViewItem(New String() {i.ToString, .CmdType.ToString, .value1.ToString, .value2.ToString, .times.ToString, .TimeSpan.ToString}))
            End With
        Next

    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AddHandler Process.ListChanged, AddressOf ListChanged
    End Sub
    Private Sub ListChanged(ByVal sender As Object, ByVal e As Process.ProcessEventArgs)
        showListCmd(e.lstCmd)
    End Sub
End Class

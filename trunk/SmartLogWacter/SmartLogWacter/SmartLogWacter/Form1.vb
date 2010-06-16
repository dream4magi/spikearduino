Imports System.Windows.Forms
Imports System.Collections.ObjectModel

Public Class frmLogViewer



    ' Dim lstTabs As New List(Of System.Windows.Forms.TabPage)




    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Env.MAIN_FORM = Me
        OpenFileDialog1.InitialDirectory = My.Application.Info.DirectoryPath

        startUp(My.Application.CommandLineArgs)

    End Sub
    Public Sub startUp(ByVal CommandLineArgs As ReadOnlyCollection(Of String))
        Dim strOpenFile As ReadOnlyCollection(Of String) = CommandLineArgs
        If strOpenFile.Count > 0 Then


            For Each Str As String In strOpenFile

                Try
                    If System.IO.File.Exists(Str) Then
                        LoadLogFile(Str)
                    End If
                Catch ex As Exception
                End Try
          
            Next

        End If
    End Sub



    Sub LoadLogFile(ByVal FullLogFilename As String)
        Dim strFilename As String = System.IO.Path.GetFileName(FullLogFilename)

        For Each oTab As TabPage In TabControl1.TabPages
            If CStr(oTab.Tag).ToUpper.Equals(FullLogFilename.ToUpper) Then
                Select Case MsgBox("Log file already open. Re-open it?" & vbNewLine & "[Yes] will discard the original log.", MsgBoxStyle.Question Or MsgBoxStyle.YesNoCancel)
                    Case MsgBoxResult.No
                        Exit For
                    Case MsgBoxResult.Yes
                        TabControl1.TabPages.Remove(oTab)
                        Exit For
                    Case MsgBoxResult.Cancel
                        TabControl1.SelectedTab = oTab
                        Return
                End Select
            End If
        Next



        Dim dicLogItem As Dictionary(Of Integer, clsLogItem) = clsSmartLogDoc.getLogList(FullLogFilename)





        Dim o As New uscLogWatch(dicLogItem)
        o.SuspendLayout()

        Me.SuspendLayout()
        TabControl1.SuspendLayout()

        Dim TabPage1 As New System.Windows.Forms.TabPage
        TabPage1.SuspendLayout()

        TabPage1.Location = New System.Drawing.Point(4, 24)
        TabPage1.Name = strFilename
        TabPage1.Padding = New System.Windows.Forms.Padding(3)
        TabPage1.Size = New System.Drawing.Size(683, 388)
        TabPage1.TabIndex = 0
        TabPage1.Text = strFilename
        TabPage1.UseVisualStyleBackColor = True


        TabControl1.TabPages.Add(TabPage1)
        TabPage1.Tag = FullLogFilename
        TabPage1.AutoScroll = True
        TabPage1.Controls.Add(o)
        o.Dock = DockStyle.Fill

        TabControl1.SelectedTab = TabPage1

        TabPage1.ResumeLayout(True)
        TabControl1.ResumeLayout(True)
        Me.ResumeLayout(True)

        o.ResumeLayout(True)
        'lstTabs.Add(TabPage1)
    End Sub


    Private Sub menuOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuOpen.Click

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If OpenFileDialog1.FileNames.Length > 0 Then
                For Each strFilename As String In OpenFileDialog1.FileNames
                    LoadLogFile(strFilename)
                Next
            End If
        End If
    End Sub

    Private Sub TabControl1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TabControl1.DragDrop
        Dim a() As String = e.Data.GetFormats
        Dim o As Object = e.Data.GetData("FileDrop", True)
        If o.GetType.Equals(GetType(String())) Then
            Dim b() As String = CType(o, String())
            For Each str As String In b
                LoadLogFile(str)
            Next
        End If

    End Sub
    Private Sub TabControl1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TabControl1.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        If TabControl1.TabPages.Count > 0 Then
            TabControl1.TabPages.Remove(TabControl1.SelectedTab)
            If TabControl1.TabPages.Count > 0 Then
                TabControl1.SelectedIndex = TabControl1.TabPages.Count - 1
            End If
            ' lstTabs.Remove(TabControl1.SelectedTab)
        End If
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseAllToolStripMenuItem.Click
        TabControl1.TabPages.Clear()
        '  lstTabs.Clear()
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
        If TabControl1.TabPages.Count > 0 Then
            CloseAllToolStripMenuItem.Enabled = True
            CloseToolStripMenuItem.Enabled = True
        Else
            CloseAllToolStripMenuItem.Enabled = False
            CloseToolStripMenuItem.Enabled = False

        End If
    End Sub

    Private Sub TabControl1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabControl1.MouseDoubleClick
        menuOpen.PerformClick()
    End Sub

End Class

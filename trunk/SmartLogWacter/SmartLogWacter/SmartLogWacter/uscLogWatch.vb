Public Class uscLogWatch

    Private COLOR_INFO As Color = Color.FromArgb(255, 255, 255)
    Private COLOR_DEBUG As Color = Color.FromArgb(226, 240, 255)
    Private COLOR_WARN As Color = Color.FromArgb(255, 249, 197)
    Private COLOR_ERROR As Color = Color.FromArgb(255, 205, 188)
    Private COLOR_FATAL As Color = Color.FromArgb(255, 150, 150)


    Const SHORT_TIME_FORMAT As String = "MM/dd HH:mm:ss.fff"

    Private dicLogItemLvw As New Dictionary(Of clsLogItem, ListViewItem)


    Public Function setLVW(ByVal lstLogItems As List(Of clsLogItem)) As Boolean
        lvwLog.Items.Clear()

        For Each oLogItem As clsLogItem In lstLogItems

            lvwLog.Items.Add(dicLogItemLvw.Item(oLogItem))

        Next
        lvwLog.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        '  lvwLog.Columns(7).Width = 0

    End Function


    Private Sub setUIDataSource(ByVal lstLogItem As List(Of clsLogItem))
        For Each oLogItem As clsLogItem In lstLogItem
            With oLogItem
                Dim oItem As New ListViewItem(New String() {.LineNo.ToString, "[" & .LogType.ToString & "]", .LogTime.ToString(SHORT_TIME_FORMAT), .LogFunction, .LogSection, .LogThreadName, .LogThreadHash, .LogContent.Replace(vbNewLine, " ")})
                setLvwItemColor(oItem, oLogItem)
                oItem.Tag = oLogItem
                lvwLog.Items.Add(oItem)

                dicLogItemLvw.Add(oLogItem, oItem)
            End With

        Next



        setLVW(lstLogItem)

    End Sub

    Private Sub setFilterDataSource(ByVal lstLogItem As List(Of clsLogItem))
        setCboFunction(lstLogItem)
        setCboSection(lstLogItem)
        setCboThread(lstLogItem)
        setCboHash(lstLogItem)
    End Sub

    Private Sub setLvwItemColor(ByVal LvwItem As ListViewItem, ByVal LogItem As clsLogItem)
        Select Case LogItem.LogType
            Case LogType.Info
                LvwItem.BackColor = COLOR_INFO
            Case LogType.Debug
                LvwItem.BackColor = COLOR_DEBUG
            Case LogType.Warn
                LvwItem.BackColor = COLOR_WARN
            Case LogType.Error
                LvwItem.BackColor = COLOR_ERROR
            Case LogType.Fatal
                LvwItem.BackColor = COLOR_FATAL
        End Select
    End Sub



    Private Sub lvwLog_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwLog.SelectedIndexChanged
        If lvwLog.SelectedItems.Count = 1 Then
            Dim oLogItem As clsLogItem = CType(lvwLog.SelectedItems(0).Tag, clsLogItem)
            With oLogItem
                txtLogTitle.Text = String.Format("{0}  {1}  {2}", .LogFunction, .LogSection, .LogTime.ToString([Const].TIME_FORMAT))
            End With

            txtLogDetail.Text = oLogItem.LogTitle & vbNewLine & oLogItem.LogContent
            txtLogDetail.BackColor = lvwLog.SelectedItems(0).BackColor
        Else
            txtLogTitle.Text = ""
            txtLogDetail.BackColor = Nothing
            txtLogDetail.Clear()
        End If
    End Sub


    Private p_dicLogItem As Dictionary(Of Integer, clsLogItem)
    ReadOnly Property dicLogItem() As Dictionary(Of Integer, clsLogItem)
        Get
            Return p_dicLogItem
        End Get
    End Property

    Private p_lstcLogItemNow As List(Of clsLogItem)

    Private p_lstcLogItemOriginal As List(Of clsLogItem)
    ReadOnly Property lstcLogItemOriginal() As List(Of clsLogItem)
        Get
            Return p_lstcLogItemOriginal
        End Get
    End Property




    Public Sub New(ByVal dicLogItem As Dictionary(Of Integer, clsLogItem))



        p_lstcLogItemOriginal = New List(Of clsLogItem)

        For Each o As System.Collections.Generic.KeyValuePair(Of Integer, SmartLogWacter.clsLogItem) In dicLogItem
            p_lstcLogItemOriginal.Add(o.Value)
        Next


        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


        setUIDataSource(p_lstcLogItemOriginal)
        setFilterDataSource(p_lstcLogItemOriginal)
        UiInitail()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If Me.Parent.GetType.Equals(GetType(TabPage)) AndAlso CType(Me.Parent, TabPage).Parent.GetType.Equals(GetType(TabControl)) Then

            CType(CType(Me.Parent, TabPage).Parent, TabControl).TabPages.Remove(CType(Me.Parent, TabPage))

        End If

        'If Env.MAIN_FORM IsNot Nothing Then
        '    Env.MAIN_FORM.CloseToolStripMenuItem.PerformClick()
        'End If
    End Sub

    Private Sub chkFrom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFrom.CheckedChanged
        DateTimePickerFrom.Enabled = chkFrom.Checked
        ' DateTimePickerFrom.Visible = chkFrom.Checked
    End Sub

    Private Sub chkTo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTo.CheckedChanged

        DateTimePickerTo.Enabled = chkTo.Checked
        '   DateTimePickerTo.Visible = chkTo.Checked
    End Sub

    Private Sub uscLogWatch_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

      



    End Sub

    Private Sub btnResetFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetFilter.Click
        chkFrom.Checked = False
        chkTo.Checked = False

        cboLevel.Text = String.Empty
        cboFunction.Text = String.Empty
        cboSection.Text = String.Empty
        cboThread.Text = String.Empty
        cboHash.Text = String.Empty
    End Sub


    Private Sub setCboFunction(ByVal LstLogItem As List(Of clsLogItem))
        cboFunction.Items.Clear()
        cboFunction.Items.Add(String.Empty)

        For Each oLogitem As clsLogItem In LstLogItem
            If Not cboFunction.Items.Contains(oLogitem.LogFunction) Then
                cboFunction.Items.Add(oLogitem.LogFunction)
            End If
        Next
    End Sub

    Private Sub setCboSection(ByVal LstLogItem As List(Of clsLogItem))
        cboSection.Items.Clear()
        cboSection.Items.Add(String.Empty)

        For Each oLogitem As clsLogItem In LstLogItem
            If Not cboSection.Items.Contains(oLogitem.LogSection) Then
                cboSection.Items.Add(oLogitem.LogSection)
            End If
        Next
    End Sub
    Private Sub setCboThread(ByVal LstLogItem As List(Of clsLogItem))
        cboThread.Items.Clear()
        cboThread.Items.Add(String.Empty)

        For Each oLogitem As clsLogItem In LstLogItem
            If Not cboThread.Items.Contains(oLogitem.LogThreadName) Then
                cboThread.Items.Add(oLogitem.LogThreadName)
            End If
        Next
    End Sub

    Private Sub setCboHash(ByVal LstLogItem As List(Of clsLogItem))
        cboHash.Items.Clear()
        cboHash.Items.Add(String.Empty)

        For Each oLogitem As clsLogItem In LstLogItem
            If Not cboHash.Items.Contains(oLogitem.LogThreadHash) Then
                cboHash.Items.Add(oLogitem.LogThreadHash)
            End If
        Next
    End Sub


    Private Sub UiInitail()
        cboLevel.Items.Add(String.Empty)
        cboLevel.Items.Add(LogType.Info)
        cboLevel.Items.Add(LogType.Debug)
        cboLevel.Items.Add(LogType.Warn)
        cboLevel.Items.Add(LogType.Error)
        cboLevel.Items.Add(LogType.Fatal)
    End Sub

    Private Sub chkAdvance_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAdvance.CheckedChanged
        panAdvanced.Visible = chkAdvance.Checked
    End Sub
    Class LogItemAndLvw
        Public LogItem As clsLogItem
        Public LvwItem As ListViewItem
    End Class
End Class

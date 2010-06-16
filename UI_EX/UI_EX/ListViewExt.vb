Imports System.Windows.Forms
Imports System.Windows.Forms.ListView

Public Class ListViewExt
    Inherits System.Windows.Forms.ListView

    Const EMPTY_VALUE As String = ""
    Const STRING_TAB As String = vbTab
    Const STRING_NEW_LINE As String = vbNewLine

    Friend WithEvents cmsCopy As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopySelectedRows As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopySelectedRowsWithColumeName As System.Windows.Forms.ToolStripMenuItem

    Friend WithEvents CopyCheckedRows As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyCheckedRowsWithColumeName As System.Windows.Forms.ToolStripMenuItem

    Friend WithEvents MarkRedSelectedRows As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarkYellowSelectedRows As System.Windows.Forms.ToolStripMenuItem


    Friend WithEvents UnMarkSelectedRows As System.Windows.Forms.ToolStripMenuItem

    Public Sub New()



        Me.cmsCopy = New System.Windows.Forms.ContextMenuStrip()
        Me.CopySelectedRows = New System.Windows.Forms.ToolStripMenuItem
        Me.CopySelectedRowsWithColumeName = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyCheckedRows = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyCheckedRowsWithColumeName = New System.Windows.Forms.ToolStripMenuItem
        Me.MarkRedSelectedRows = New System.Windows.Forms.ToolStripMenuItem
        Me.MarkYellowSelectedRows = New System.Windows.Forms.ToolStripMenuItem
        Me.UnMarkSelectedRows = New System.Windows.Forms.ToolStripMenuItem

        Me.cmsCopy.SuspendLayout()
        Me.SuspendLayout()


        '
        'cmsCopy
        '
        ' Me.cmsCopy.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopySelectedRows, Me.CopySelectedRowsWithColumeName, Me.CopyCheckedRows, Me.CopyCheckedRowsWithColumeName})
        Me.cmsCopy.Name = "ContextMenuStrip1"
        Me.cmsCopy.Size = New System.Drawing.Size(306, 48)
        '
        'CopySelectedRows
        '
        Me.CopySelectedRows.Name = "CopySelectedRows"
        Me.CopySelectedRows.Size = New System.Drawing.Size(305, 22)
        Me.CopySelectedRows.Text = "Copy Selected Rows"
        '
        'CopySelectedRowsWithColumeNameToolStripMenuItem
        '
        Me.CopySelectedRowsWithColumeName.Name = "CopySelectedRowsWithColumeNameToolStripMenuItem"
        Me.CopySelectedRowsWithColumeName.Size = New System.Drawing.Size(305, 22)
        Me.CopySelectedRowsWithColumeName.Text = "Copy Selected Rows With Column Name"

        '
        'CopyCheckedRows
        '
        Me.CopyCheckedRows.Name = "CopyCheckedRows"
        Me.CopyCheckedRows.Size = New System.Drawing.Size(305, 22)
        Me.CopyCheckedRows.Text = "Copy Checked Rows"
        '
        'CopyCheckedRowsWithColumeNameToolStripMenuItem
        '
        Me.CopyCheckedRowsWithColumeName.Name = "CopyCheckedRowsWithColumeName"
        Me.CopyCheckedRowsWithColumeName.Size = New System.Drawing.Size(305, 22)
        Me.CopyCheckedRowsWithColumeName.Text = "Copy Checked Rows With Column Name"

        Me.MarkRedSelectedRows.Name = "MarkRed"
        Me.MarkRedSelectedRows.Size = New System.Drawing.Size(305, 22)
        Me.MarkRedSelectedRows.Text = "Mark Red"

        Me.MarkYellowSelectedRows.Name = "MarkYellow"
        Me.MarkYellowSelectedRows.Size = New System.Drawing.Size(305, 22)
        Me.MarkYellowSelectedRows.Text = "Mark Yellow"

        Me.UnMarkSelectedRows.Name = "UnMarkColor"
        Me.UnMarkSelectedRows.Size = New System.Drawing.Size(305, 22)
        Me.UnMarkSelectedRows.Text = "Unmark"

        Me.cmsCopy.ResumeLayout(False)
        Me.ResumeLayout(False)

        handleRightMenuUI()
    End Sub

 
#Region "copy function"
    Public Function CopySelectedRowsText() As Boolean
        Return CopySelectedRowsText(False)
    End Function
    Public Function CopySelectedRowsTextWithColumnName() As Boolean
        Return CopySelectedRowsText(True)
    End Function
    Public Function CopySelectedRowsText(ByVal WithHeader As Boolean) As Boolean
        If Not Me.SelectedItems.Count > 0 Then
            Return False
        End If

        Dim strCopyMsg As String = ""
        Try
            If WithHeader Then
                For i As Integer = 0 To Me.Columns.Count - 1
                    If i = 0 Then
                        strCopyMsg &= Me.Columns(i).Text
                    Else
                        strCopyMsg &= STRING_TAB & Me.Columns(i).Text
                    End If
                Next
                strCopyMsg &= STRING_NEW_LINE
            End If

            For i As Integer = 0 To Me.SelectedItems.Count - 1

                For col As Integer = 0 To Me.Columns.Count - 1
                    If col <= SelectedItems(i).SubItems.Count - 1 Then
                        If col = 0 Then
                            strCopyMsg &= Me.SelectedItems(i).SubItems(col).Text
                        Else
                            strCopyMsg &= STRING_TAB & Me.SelectedItems(i).SubItems(col).Text
                        End If
                    Else
                        If col = 0 Then
                            strCopyMsg &= EMPTY_VALUE
                        Else
                            strCopyMsg &= STRING_TAB & EMPTY_VALUE
                        End If
                    End If
                Next

                If i < Me.SelectedItems.Count - 1 Then strCopyMsg &= STRING_NEW_LINE

            Next
            My.Computer.Clipboard.SetText(strCopyMsg)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function CopyCheckedRowsText() As Boolean
        Return CopyCheckedRowsText(False)
    End Function
    Public Function CopyCheckedRowsTextWithColumnName() As Boolean
        Return CopyCheckedRowsText(True)
    End Function
    Public Function CopyCheckedRowsText(ByVal WithHeader As Boolean) As Boolean
        If Not Me.CheckedItems.Count > 0 Then
            Return False
        End If

        Dim strCopyMsg As String = ""
        Try
            If WithHeader Then
                For i As Integer = 0 To Me.Columns.Count - 1
                    If i = 0 Then
                        strCopyMsg &= Me.Columns(i).Text
                    Else
                        strCopyMsg &= STRING_TAB & Me.Columns(i).Text
                    End If
                Next
                strCopyMsg &= STRING_NEW_LINE
            End If

            For i As Integer = 0 To Me.CheckedItems.Count - 1

                For col As Integer = 0 To Me.Columns.Count - 1
                    If col <= CheckedItems(i).SubItems.Count - 1 Then
                        If col = 0 Then
                            strCopyMsg &= Me.CheckedItems(i).SubItems(col).Text
                        Else
                            strCopyMsg &= STRING_TAB & Me.CheckedItems(i).SubItems(col).Text
                        End If
                    Else
                        If col = 0 Then
                            strCopyMsg &= EMPTY_VALUE
                        Else
                            strCopyMsg &= STRING_TAB & EMPTY_VALUE
                        End If
                    End If
                Next

                If i < Me.CheckedItems.Count - 1 Then strCopyMsg &= STRING_NEW_LINE

            Next
            My.Computer.Clipboard.SetText(strCopyMsg)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

#Region "Get from multi rows"
#Region "All items"
    Public Function getCells(ByVal RowKeyText As String, ByVal ColHeaderText As String, Optional ByVal KeyColIndex As Integer = -1) As List(Of ListViewItem.ListViewSubItem)
        Dim ColIndex As Integer = getColIndex(ColHeaderText)
        Return getCells(RowKeyText, ColIndex, KeyColIndex)
    End Function
    Public Function getCells(ByVal RowKeyText As String, ByVal ColHeader As ColumnHeader, Optional ByVal KeyColIndex As Integer = -1) As List(Of ListViewItem.ListViewSubItem)
        Dim ColIndex As Integer = getColIndex(ColHeader)
        Return getCells(RowKeyText, ColIndex, KeyColIndex)
    End Function
    Public Function getCells(ByVal RowKeyText As String, ByVal ColIndex As Integer, Optional ByVal KeyColIndex As Integer = -1) As List(Of ListViewItem.ListViewSubItem)
        Dim lstCell As New List(Of ListViewItem.ListViewSubItem)

        If KeyColIndex <= Me.Columns.Count - 1 Then
            For Each row As ListViewItem In Me.Items
                If isWantedRow(row, RowKeyText, KeyColIndex) Then
                    lstCell.Add(getSingleCell(row, ColIndex))
                End If
            Next
        End If

        Return lstCell

    End Function
#End Region

#Region "Selected"
    Public Function getCells(ByVal RowKeyText As String, ByVal ColHeaderText As String, ByVal ListViewItems As ListView.SelectedListViewItemCollection, Optional ByVal KeyColIndex As Integer = -1) As List(Of ListViewItem.ListViewSubItem)
        Dim ColIndex As Integer = getColIndex(ColHeaderText)
        Return getCells(RowKeyText, ColIndex, ListViewItems, KeyColIndex)
    End Function
    Public Function getCells(ByVal RowKeyText As String, ByVal ColHeader As ColumnHeader, ByVal ListViewItems As ListView.SelectedListViewItemCollection, Optional ByVal KeyColIndex As Integer = -1) As List(Of ListViewItem.ListViewSubItem)
        Dim ColIndex As Integer = getColIndex(ColHeader)
        Return getCells(RowKeyText, ColIndex, ListViewItems, KeyColIndex)
    End Function
    Public Function getCells(ByVal RowKeyText As String, ByVal ColIndex As Integer, ByVal ListViewItems As ListView.SelectedListViewItemCollection, Optional ByVal KeyColIndex As Integer = -1) As List(Of ListViewItem.ListViewSubItem)

        Dim lstCell As New List(Of ListViewItem.ListViewSubItem)
        If KeyColIndex <= Me.Columns.Count - 1 Then
            For Each row As ListViewItem In ListViewItems
                If isWantedRow(row, RowKeyText, KeyColIndex) Then
                    lstCell.Add(getSingleCell(row, ColIndex))
                End If
            Next
        End If

        Return lstCell

    End Function
#End Region

#Region "checked"
    Public Function getCells(ByVal RowKeyText As String, ByVal ColHeaderText As String, ByVal ListViewItems As ListView.CheckedListViewItemCollection, Optional ByVal KeyColIndex As Integer = -1) As List(Of ListViewItem.ListViewSubItem)
        Dim ColIndex As Integer = getColIndex(ColHeaderText)
        Return getCells(RowKeyText, ColIndex, ListViewItems, KeyColIndex)
    End Function
    Public Function getCells(ByVal RowKeyText As String, ByVal ColHeader As ColumnHeader, ByVal ListViewItems As ListView.CheckedListViewItemCollection, Optional ByVal KeyColIndex As Integer = -1) As List(Of ListViewItem.ListViewSubItem)
        Dim ColIndex As Integer = getColIndex(ColHeader)
        Return getCells(RowKeyText, ColIndex, ListViewItems, KeyColIndex)
    End Function
    Public Function getCells(ByVal RowKeyText As String, ByVal ColIndex As Integer, ByVal ListViewItems As ListView.CheckedListViewItemCollection, Optional ByVal KeyColIndex As Integer = -1) As List(Of ListViewItem.ListViewSubItem)
        Dim lstCell As New List(Of ListViewItem.ListViewSubItem)
        If KeyColIndex <= Me.Columns.Count - 1 Then
            For Each row As ListViewItem In ListViewItems
                If isWantedRow(row, RowKeyText, KeyColIndex) Then
                    lstCell.Add(getSingleCell(row, ColIndex))
                End If
            Next
        End If

        Return lstCell

    End Function
#End Region
#End Region

#Region "Get from single row"
    Public Function getSingleCell(ByVal Row As ListViewItem, ByVal ColHeader As ColumnHeader) As ListViewItem.ListViewSubItem
        Dim ColIndex As Integer = getColIndex(ColHeader)
        Return getSingleCell(Row, ColIndex)
    End Function
    Public Function getSingleCell(ByVal Row As ListViewItem, ByVal ColHeaderText As String) As ListViewItem.ListViewSubItem
        Dim ColIndex As Integer = getColIndex(ColHeaderText)
        Return getSingleCell(Row, ColIndex)
    End Function
    Public Function getSingleCell(ByVal Row As ListViewItem, ByVal ColIndex As Integer) As ListViewItem.ListViewSubItem
        If ColIndex > -1 AndAlso Row.SubItems.Count - 1 >= ColIndex Then
            Return Row.SubItems(ColIndex)
        Else
            Return Nothing
        End If
    End Function
#End Region

#Region "Tools"

    Private Function getColIndex(ByVal ColHeaderText As String) As Integer
        For i As Integer = 0 To Me.Columns.Count - 1
            If Me.Columns(i).Text.Equals(ColHeaderText) Then
                Return i
            End If
        Next
        Return -1
    End Function
    Private Function getColIndex(ByVal ColHeader As ColumnHeader) As Integer
        For i As Integer = 0 To Me.Columns.Count - 1
            If Me.Columns(i).Equals(ColHeader) Then
                Return i
            End If
        Next
        Return -1
    End Function
    Function isWantedRow(ByVal Row As ListViewItem, ByVal SubitemText As String, Optional ByVal KeyColindex As Integer = -1) As Boolean
        If KeyColindex = -1 Then
            KeyColindex = p_KeyColumnIndex
        End If

        If Row.SubItems.Count - 1 >= KeyColindex AndAlso Row.SubItems(KeyColindex).Text.Equals(SubitemText) Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#Region "Get Rows"
    Public Function getRows(ByVal KeyText As String, ByVal ColHeader As ColumnHeader, Optional ByVal ListViewItems As ListViewItemCollection = Nothing) As List(Of ListViewItem)
        Return getRows(KeyText, ListViewItems, getColIndex(ColHeader))
    End Function
    Public Function getRows(ByVal KeyText As String, ByVal ColHeaderText As String, Optional ByVal ListViewItems As ListViewItemCollection = Nothing) As List(Of ListViewItem)
        Return getRows(KeyText, ListViewItems, getColIndex(ColHeaderText))
    End Function
    Public Function getRows(ByVal KeyText As String, Optional ByVal ListViewItems As ListViewItemCollection = Nothing, Optional ByVal KeyColIndex As Integer = -1) As List(Of ListViewItem)
        Dim lstRows As List(Of ListViewItem) = New List(Of ListViewItem)
        If ListViewItems Is Nothing Then
            ListViewItems = Me.Items
        End If

        If KeyColIndex <= Me.Columns.Count - 1 Then
            For Each row As ListViewItem In ListViewItems
                If isWantedRow(row, KeyText, KeyColIndex) Then
                    lstRows.Add(row)
                End If
            Next

        End If
        Return lstRows
    End Function
    Public Function getRow(ByVal RowIndex As Integer) As ListViewItem
        If RowIndex <= Me.Items.Count - 1 Then
            Return Me.Items(RowIndex)
        Else
            Return Nothing
        End If
    End Function
#End Region

    Public Function MarkColor(ByVal Items As System.Windows.Forms.ListView.SelectedListViewItemCollection, ByVal color As System.Drawing.Color) As Boolean
        If Items Is Nothing Then
            Return False
        End If
        Dim isError As Boolean = False

        For Each lvwItem As ListViewItem In Items
            If Me.Items.Contains(lvwItem) Then
                lvwItem.BackColor = color
            Else
                isError = True
            End If
        Next

        Return Not isError
    End Function
    Public Function MarkColor(ByVal Items As System.Windows.Forms.ListView.ListViewItemCollection, ByVal color As System.Drawing.Color) As Boolean
        If Items Is Nothing Then
            Return False
        End If
        Dim isError As Boolean = False

        For Each lvwItem As ListViewItem In Items
            If Me.Items.Contains(lvwItem) Then
                lvwItem.BackColor = color
            Else
                isError = True
            End If
        Next

        Return Not isError
    End Function
    Public Function MarkColor(ByVal Items() As ListViewItem, ByVal color As System.Drawing.Color) As Boolean
        If Items Is Nothing Then
            Return False
        End If
        Dim isError As Boolean = False

        For Each lvwItem As ListViewItem In Items
            If Me.Items.Contains(lvwItem) Then
                lvwItem.BackColor = color
            Else
                isError = True
            End If
        Next

        Return Not isError
    End Function
    Public Function UnMarkColor(ByVal Items As System.Windows.Forms.ListView.SelectedListViewItemCollection) As Boolean
        If Items Is Nothing Then
            Return False
        End If
        Dim isError As Boolean = False

        For Each lvwItem As ListViewItem In Items
            If Me.Items.Contains(lvwItem) Then
                lvwItem.BackColor = Nothing
            Else
                isError = True
            End If
        Next

        Return Not isError
    End Function
    Public Function UnMarkColor(ByVal Items As System.Windows.Forms.ListView.ListViewItemCollection) As Boolean
        If Items Is Nothing Then
            Return False
        End If
        Dim isError As Boolean = False

        For Each lvwItem As ListViewItem In Items
            If Me.Items.Contains(lvwItem) Then
                lvwItem.BackColor = Nothing
            Else
                isError = True
            End If
        Next

        Return Not isError
    End Function
    Public Function UnMarkColor(ByVal Items() As ListViewItem) As Boolean
        If Items Is Nothing Then
            Return False
        End If
        Dim isError As Boolean = False

        For Each lvwItem As ListViewItem In Items
            If Me.Items.Contains(lvwItem) Then
                lvwItem.BackColor = Nothing
            Else
                isError = True
            End If
        Next

        Return Not isError
    End Function
#Region "LVW right click event"
    Private Sub ListViewExt_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        If (p_AllowRightClickCopy Or p_AllowMark) AndAlso e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cmsCopy.Show(Me, e.Location)
        End If
    End Sub
#End Region

#Region "UI"
    Private Sub handleRightMenuUI()
        Me.cmsCopy.Items.Clear()
        If p_AllowRightClickCopy Then
            If Me.CheckBoxes Then
                Me.cmsCopy.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopySelectedRows, Me.CopySelectedRowsWithColumeName, Me.CopyCheckedRows, Me.CopyCheckedRowsWithColumeName})
            Else
                Me.cmsCopy.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopySelectedRows, Me.CopySelectedRowsWithColumeName})
            End If
        End If
        If p_AllowMark Then
            Me.cmsCopy.Items.AddRange(New System.Windows.Forms.ToolStripItem() {MarkRedSelectedRows, MarkYellowSelectedRows, UnMarkSelectedRows})
        End If

    End Sub
#End Region

#Region "Right Menu Event"
    Private Sub CopySelectedRows_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CopySelectedRows.Click
        CopySelectedRowsText()
    End Sub


    Private Sub CopySelectedRowsWithColumeName_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CopySelectedRowsWithColumeName.Click
        CopySelectedRowsTextWithColumnName()
    End Sub

    Private Sub CopyCheckedRows_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CopyCheckedRows.Click
        CopyCheckedRowsText()
    End Sub

    Private Sub CopyCheckedRowsWithColumeName_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CopyCheckedRowsWithColumeName.Click
        CopyCheckedRowsTextWithColumnName()
    End Sub
    Private Sub MarkRedSelectedRows_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MarkRedSelectedRows.Click
        If Me.SelectedItems.Count > 0 Then
            MarkColor(Me.SelectedItems, Color.LightCoral)
        End If
    End Sub

    Private Sub MarkYellowSelectedRows_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MarkYellowSelectedRows.Click
        If Me.SelectedItems.Count > 0 Then
            MarkColor(Me.SelectedItems, Color.Yellow)
        End If
    End Sub
    Private Sub UnMarkSelectedRows_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UnMarkSelectedRows.Click
        If Me.SelectedItems.Count > 0 Then
            UnMarkColor(Me.SelectedItems)
        End If
    End Sub

#End Region

#Region "Properties"
    Private p_AllowMark As Boolean = True
    Property AllowMark() As Boolean
        Get
            Return p_AllowMark
        End Get
        Set(ByVal value As Boolean)
            p_AllowMark = value
            handleRightMenuUI()
        End Set
    End Property
    Shadows Property CheckBoxes() As Boolean
        Get
            Return MyBase.CheckBoxes
        End Get
        Set(ByVal value As Boolean)
            MyBase.CheckBoxes = value
            handleRightMenuUI()
        End Set
    End Property
    Private p_AllowRightClickCopy As Boolean = True
    Property AllowRightClickCopy() As Boolean
        Get
            Return p_AllowRightClickCopy
        End Get
        Set(ByVal value As Boolean)
            p_AllowRightClickCopy = value
        End Set
    End Property
    Private p_KeyColumnIndex As Integer = 0
    Property KeyColumn() As Integer
        Get
            Return p_KeyColumnIndex
        End Get
        Set(ByVal value As Integer)
            p_KeyColumnIndex = value
        End Set
    End Property
#End Region





End Class

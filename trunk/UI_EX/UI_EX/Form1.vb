Public Class Form1

    Dim aaa As Integer = 0
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim o As test

        Using bb As New test(Of Integer)
            bb.a = "a"
            o = bb
        End Using

        MsgBox(o.a)

        Dim a As New ListViewExt
        Me.Controls.Add(a)

        Dim az As New Windows.Forms.ListView.ListViewItemCollection(ListViewExt1)
        ' az.RemoveAt(0)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim b As List(Of ListViewItem.ListViewSubItem) = ListViewExt1.getCells("11", ColumnHeader2, ListViewExt1.SelectedItems)

    End Sub

    Private Sub ComboBoxExt1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxExt1.SelectedIndexChanged
        aaa += 1

        Label1.Text = aaa.ToString
    End Sub
End Class
Class test(Of type1, type2 As Integer)
    Implements IDisposable

    Public a As String = ""
    Public b As String = ""

    Private disposedValue As Boolean = False        ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: free other state (managed objects).
            End If

            ' TODO: free your own state (unmanaged objects).
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

#Region " IDisposable Support "
    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
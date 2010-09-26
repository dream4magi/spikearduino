Public Class Process
    Class ProcessEventArgs
        Inherits EventArgs
        Private p_lstCmd As lstCmd
        ReadOnly Property lstCmd() As lstCmd
            Get
                Return p_lstCmd
            End Get
        End Property

        Public Sub New(ByVal _lstCmd As lstCmd)
            p_lstCmd = _lstCmd
        End Sub
    End Class
    Public p_lstCmd As New lstCmd
    ReadOnly Property lstCmd() As lstCmd
        Get
            Return p_lstCmd
        End Get
    End Property
    Public Event ListChanged(ByVal sender As Object, ByVal e As ProcessEventArgs)



    Public Sub New()

    End Sub



    Public Sub Add(ByVal NewCmd As Cmd)
        Try
            lstCmd.Add(NewCmd)
        Catch ex As Exception
            Throw New ProcessException("Add Exception.", ex)
        End Try
        LstChanged()
    End Sub
    Public Sub Insert(ByVal index As Integer, ByVal NewCmd As Cmd)
        Try
            lstCmd.Insert(index, NewCmd)
        Catch ex As Exception
            Throw New ProcessException("Insert Exception.", ex)
        End Try
        LstChanged()
    End Sub
    Public Sub Delete(ByVal index As Integer)
        Try
            lstCmd.RemoveAt(index)
        Catch ex As Exception
            Throw New ProcessException("Delete Exception.", ex)
        End Try
        LstChanged()
    End Sub
    Public Sub Clear()
        Try
            lstCmd.Clear()
        Catch ex As Exception
            Throw New ProcessException("Clear Exception.", ex)
        End Try
        LstChanged()
    End Sub
    Public Sub Reverse()
        Try
            lstCmd.Reverse()
        Catch ex As Exception
            Throw New ProcessException("Reverse Exception.", ex)
        End Try
        LstChanged()
    End Sub
    Public Sub Edit(ByVal index As Integer, ByVal Cmd As Cmd)
        Try
            Delete(index)
            Insert(index, Cmd)
        Catch ex As Exception
            Throw New ProcessException("Edit Exception.", ex)
        End Try
        LstChanged()
    End Sub

    Private Sub LstChanged()
        RaiseEvent ListChanged(Me, New ProcessEventArgs(lstCmd))
    End Sub
End Class

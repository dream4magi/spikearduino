Imports System.Windows.Forms
Imports System.Windows.Forms.ComboBox

Public Class ComboBoxExt
    Inherits Windows.Forms.ComboBox

    Private Const SELECTED_INDEX_CHANGED_DELAY_VALUE_ERROR As String = "SelectedIndexChanged deley must greater then 0 ms."
    Private Const SELECTED_INDEX_CHANGED_DELAY_DEFAULT As Integer = 200


    Private WithEvents TmrSelectedIndexChangedDelay As New System.Windows.Forms.Timer
    Private TmrSelectedIndexChangedDelaySender As Object
    Private TmrSelectedIndexChangedDelayE As System.EventArgs


    Public Shadows Event SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)




#Region "Properties"
    Private p_SelectedIndexChangedDelay As Boolean = False
    Property SelectedIndexChangedDelay() As Boolean
        Get
            Return p_SelectedIndexChangedDelay
        End Get
        Set(ByVal value As Boolean)
            p_SelectedIndexChangedDelay = value
        End Set
    End Property
    Private p_SelectedIndexChangedDelayTime As Integer = SELECTED_INDEX_CHANGED_DELAY_DEFAULT
    Property SelectedIndexChangedDelayTime() As Integer
        Get
            Return p_SelectedIndexChangedDelayTime
        End Get
        Set(ByVal value As Integer)
            If value < 1 Then
                Throw New Exception(SELECTED_INDEX_CHANGED_DELAY_VALUE_ERROR)
            Else
                p_SelectedIndexChangedDelayTime = value
                TmrSelectedIndexChangedDelay.Interval = p_SelectedIndexChangedDelayTime
            End If

        End Set
    End Property
    Private p_UseMainThread As Boolean = True
    Property UseMainThread() As Boolean
        Get
            Return p_UseMainThread
        End Get
        Set(ByVal value As Boolean)
            p_UseMainThread = value
        End Set
    End Property

#End Region

#Region "Delay SelectedIndexChanged"
    Private Sub ComboBoxExt_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.SelectedIndexChanged
        If p_UseMainThread AndAlso p_SelectedIndexChangedDelay Then
            TmrSelectedIndexChangedDelaySender = sender
            TmrSelectedIndexChangedDelayE = e
            TmrSelectedIndexChangedDelay.Stop()
            TmrSelectedIndexChangedDelay.Start()
        Else
            RaiseEvent SelectedIndexChanged(sender, e)
        End If
    End Sub

    Private Sub Tmr_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TmrSelectedIndexChangedDelay.Tick

        TmrSelectedIndexChangedDelay.Stop()
        Me.Invoke(New SelectedIndexChangedEventHandler(AddressOf RaiseEventSelectedChanged), New Object() {TmrSelectedIndexChangedDelaySender, TmrSelectedIndexChangedDelayE})

    End Sub

    Private Sub RaiseEventSelectedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        RaiseEvent SelectedIndexChanged(sender, e)
    End Sub

#End Region
End Class

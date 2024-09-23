Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public MustInherit Class BaseService(Of T)
    Protected Friend Connection As SqlConnection
    Protected Friend DTable As DataTable
    Protected Friend SAdapter As SqlDataAdapter
    Protected Friend SCommand As SqlCommand
    Protected Friend DataList As ObservableCollection(Of T)
    Protected Const MAX_FETCH As Integer = 30

    Sub New()
        DataList = New ObservableCollection(Of T)
        DTable = New DataTable()
        Try
            Connection = New SqlConnection(My.Settings.ConnectionString)
            Connection.Open()
        Catch ex As SqlException
            ' TODO Catch the SqlException
        Catch ex As InvalidOperationException
            ' TODO Catch the InvalidOperationException
        End Try
    End Sub

    Sub OpenConnection()
        Try
            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If
        Catch ex As InvalidOperationException
            ' TODO Catch the InvalidOperationException
        End Try
    End Sub

    Public MustOverride Sub _AddParameters(data As T)

#Region "CRUD Operations"
    Public MustOverride Function Add(data As T) As Boolean
    Public MustOverride Function Update(data As T) As Boolean
    Public MustOverride Function Archive(data As T) As Boolean
    Public MustOverride Function Fetch(Optional page As Integer = 1) As ObservableCollection(Of T)
    Public MustOverride Function Search() As ObservableCollection(Of T)
#End Region

End Class

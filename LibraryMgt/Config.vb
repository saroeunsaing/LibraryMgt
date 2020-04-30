Imports System.Data.SqlClient
Module Config
    'Server Configuration
    Public datasource As String = "ACER-PC"
    Public database As String = "LibraryMgt"
    Public user_ID As String = "sa"
    Public pwd As String = "123"

    'Global Variable Declaration
    Public cn As SqlConnection
    Public cmd As SqlCommand
    Public da As SqlDataAdapter
    Public dr As SqlDataReader
    Public dt As New DataTable
    Public ds As New DataSet
    Public cs As String

End Module

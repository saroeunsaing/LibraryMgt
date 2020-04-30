Imports System.Data.SqlClient

Public MustInherit Class ConnectionString

    ' create connection in mustinherit class to use all in project
    Public Sub New()
        cs = "Data Source=" + datasource + ";Initial Catalog=" + database + "; User ID=" + user_ID + ";Password=" + pwd

    End Sub

    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(cs)
    End Function
End Class

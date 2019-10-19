Imports System.Data
Imports System.Configuration
Imports System.Data.OleDb
Imports System

Module ModuleConnection
    Public conn As New OleDbConnection
    Public cmd As New OleDbCommand
    Public RD As OleDbDataReader
    Public sSQL As String
    Public adapter As New OleDbDataAdapter
    Public mydataset As New DataSet
    Public dt As New DataTable


    Public Sub execSQL(ByVal query As String, ByVal stat As Boolean)
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\students.mdb;User Id=admin;Password=;"
            '"server=RANEGILLIAN\DWHSEASDB;Database=login;Trusted_Connection=True;"
            conn.Open()
            cmd.Connection = conn
            cmd.CommandText() = query




            If stat = False Then
                RD = cmd.ExecuteReader()
            Else
                cmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub filldg(ByVal query As String, ByRef dg As DataGridView)
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            cmd = New OleDbCommand(query, conn)
            adapter = New OleDbDataAdapter(cmd)

            mydataset = New DataSet()
            adapter.Fill(mydataset)
            dg.DataSource = ""
            dg.DataSource = mydataset.Tables(0)
            dg.AutoResizeColumns()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module

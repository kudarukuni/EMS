Imports System.Diagnostics.Eventing
Imports MySql.Data.MySqlClient

Public Class Form8
    Private Sub ts_Home_Click(sender As Object, e As EventArgs) Handles ts_Home.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub ts_AssetReg_Click(sender As Object, e As EventArgs) Handles ts_AssetReg.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub ts_Maintanance_Click(sender As Object, e As EventArgs) Handles ts_Maintanance.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub ts_Query_Click(sender As Object, e As EventArgs) Handles ts_Query.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub ts_Analysis_Click(sender As Object, e As EventArgs) Handles ts_Analysis.Click
        Form6.Show()
        Me.Close()
    End Sub

    Private Sub ts_Library_Click(sender As Object, e As EventArgs) Handles ts_Library.Click
        Form7.Show()
        Me.Close()
    End Sub

    Private Sub ts_Inventory_Click(sender As Object, e As EventArgs) Handles ts_Inventory.Click
        Me.Show()
    End Sub

    Private Sub ts_Login_Click(sender As Object, e As EventArgs) Handles ts_Login.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub ts_Register_Click(sender As Object, e As EventArgs) Handles ts_Register.Click
        Form1.Show()
        Me.Close()
    End Sub

    Dim mysqlconn As MySqlConnection
    Dim COMMAND, COMMAND1, COMMAND2 As MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myData As New DataTable
    Dim READER As MySqlDataReader



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=127.0.0.1; user=root; database=ems_db"
        Dim Query1 As String

        mysqlconn.Open()
        Query1 = "INSERT INTO library (Name, Asset_Borrowed, Serial_Number, Due_Date, Phone) VALUES('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "')"
        COMMAND1 = New MySqlCommand(Query1, mysqlconn)
        READER = COMMAND1.ExecuteReader
        mysqlconn.Close()
        MsgBox("Successfully Borrowed!!")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=127.0.0.1; user=root; database=ems_db"
        Dim Query2 As String

        mysqlconn.Open()
        Query2 = "DELETE FROM library WHERE Serial_Number = '" & TextBox6.Text & "'"
        COMMAND2 = New MySqlCommand(Query2, mysqlconn)
        READER = COMMAND2.ExecuteReader
        mysqlconn.Close()
        MsgBox("Successfully Returned!!")
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=127.0.0.1; user=root; database=ems_db"
        Dim Query As String

        mysqlconn.Open()
        Query = "SELECT * FROM library"
        COMMAND = New MySqlCommand(Query, mysqlconn)
        myAdapter.SelectCommand = COMMAND
        myAdapter.Fill(myData)
        DataGridView1.DataSource = myData
        mysqlconn.Close()
    End Sub
End Class
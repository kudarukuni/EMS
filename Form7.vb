Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Pkcs

Public Class Form7
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
        Me.Show()
    End Sub

    Private Sub ts_Inventory_Click(sender As Object, e As EventArgs) Handles ts_Inventory.Click
        Form8.Show()
        Me.Close()
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
    Dim COMMAND, COMMAND1, COMMAND2, COMMAND3 As MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myData As New DataTable
    Dim READER, READER1 As MySqlDataReader

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=127.0.0.1; user=root; database=ems_db"
        Dim Query As String

        mysqlconn.Open()
        Query = "SELECT COUNT(Confisticat_Id) as 'countcomps' FROM confisticated"
        COMMAND = New MySqlCommand(Query, mysqlconn)
        Label4.Text = "Assets Confisticated: " + COMMAND.ExecuteScalar().ToString()
        mysqlconn.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=127.0.0.1; user=root; database=ems_db"
        Dim Query1 As String

        mysqlconn.Open()
        Query1 = "SELECT * FROM confisticated"
        COMMAND1 = New MySqlCommand(Query1, mysqlconn)
        myAdapter.SelectCommand = COMMAND1
        myAdapter.Fill(myData)
        DataGridView1.DataSource = myData
        mysqlconn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=127.0.0.1; user=root; database=ems_db"
        Dim Query2, Query3 As String

        mysqlconn.Open()
        Query2 = "INSERT INTO confisticated (Serial_Number, Model, Date_Purchased, Stock_Price) VALUES('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "')"
        COMMAND2 = New MySqlCommand(Query2, mysqlconn)
        READER = COMMAND1.ExecuteReader
        mysqlconn.Close()

        mysqlconn.Open()
        Query3 = "DELETE FROM assetregister WHERE seria='" & TextBox1.Text & "'"
        COMMAND3 = New MySqlCommand(Query3, mysqlconn)
        READER = COMMAND3.ExecuteReader
        mysqlconn.Close()

        MsgBox("Successfully Confisticated!!")
    End Sub

End Class
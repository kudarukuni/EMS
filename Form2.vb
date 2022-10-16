Imports MySql.Data.MySqlClient
Imports System
Imports System.Data
Imports System.Windows
Imports System.Windows.Forms.DataFormats
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Dim mysqlconn As MySqlConnection
    Dim COMMAND, COMMAND1 As MySqlCommand

    Private Sub ts_Home_Click_1(sender As Object, e As EventArgs) Handles ts_Home.Click
        Me.Show()
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

    Private Sub ts_Inventory_Click(sender As Object, e As EventArgs) Handles ts_Inventory.Click
        Form7.Show()
        Me.Close()
    End Sub

    Private Sub ts_Library_Click(sender As Object, e As EventArgs) Handles ts_Library.Click
        Form8.Show()
        Me.Close()
    End Sub

    Private Sub ts_Register_Click(sender As Object, e As EventArgs) Handles ts_Register.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub ts_Login_Click(sender As Object, e As EventArgs) Handles ts_Login.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=127.0.0.1; user=root; database=ems_db"
        Dim Query, Query1 As String
        mysqlconn.Open()
        Query = "SELECT COUNT(assid) as 'countassets' FROM assetregister"
        Query1 = "SELECT COUNT(main_id) as 'countmaints' FROM maintain"
        COMMAND = New MySqlCommand(Query, mysqlconn)
        COMMAND1 = New MySqlCommand(Query1, mysqlconn)
        Label3.Text = "Assets Registered: " + COMMAND.ExecuteScalar().ToString() + "" & vbCrLf & "" & vbCrLf & "Total Repairs: " + COMMAND1.ExecuteScalar().ToString() + ""
        mysqlconn.Close()
    End Sub
End Class
﻿Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Form5
    Dim mysqlconn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myData As New DataTable
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
        Me.Show()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=127.0.0.1; user=root; database=ems_db"
        Dim Query As String
        mysqlconn.Open()
        Query = "SELECT * FROM maintain WHERE Serial_Number='" & TextBox1.Text & "'"
        COMMAND = New MySqlCommand(Query, mysqlconn)
        myAdapter.SelectCommand = COMMAND
        myAdapter.Fill(myData)
        DataGridView1.DataSource = myData
        mysqlconn.Close()
    End Sub
End Class
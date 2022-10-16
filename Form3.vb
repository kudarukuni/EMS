Imports MySql.Data.MySqlClient
Imports System
Imports System.Data
Imports System.Windows
Imports System.Windows.Forms.DataFormats
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form3
    Dim mysqlconn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub ts_Home_Click(sender As Object, e As EventArgs) Handles ts_Home.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub ts_AssetReg_Click(sender As Object, e As EventArgs) Handles ts_AssetReg.Click
        Me.Show()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Fill In All Fields")
        Else
            mysqlconn = New MySqlConnection
            mysqlconn.ConnectionString = "server=127.0.0.1; user=root; database=ems_db"
            Dim READER As MySqlDataReader
            Dim Query As String

            mysqlconn.Open()
            Query = "INSERT INTO assetregister (ecnum, seria, model, dob, sp) VALUES('" & TextBox5.Text & "', '" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "')"
            COMMAND = New MySqlCommand(Query, mysqlconn)
            READER = COMMAND.ExecuteReader
            mysqlconn.Close()
            MsgBox("Successfully Registered")
            Form2.Show()
            Me.Close()
        End If
    End Sub
End Class
Imports MySql.Data.MySqlClient

Public Class Form4
    Dim mysqlconn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub ts_Home_Click(sender As Object, e As EventArgs) Handles ts_Home.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub ts_AssetReg_Click(sender As Object, e As EventArgs) Handles ts_AssetReg.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub ts_Maintanance_Click(sender As Object, e As EventArgs) Handles ts_Maintanance.Click
        Me.Show()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then
            MsgBox("Fill In All Fields")
        Else
            mysqlconn = New MySqlConnection
            mysqlconn.ConnectionString = "server=127.0.0.1; user=root; database=ems_db"
            Dim READER As MySqlDataReader
            Dim Query As String

            mysqlconn.Open()
            Query = "INSERT INTO maintain (ecnum, mac, model, history, cost, repaired, fix) VALUES('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox7.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "')"
            COMMAND = New MySqlCommand(Query, mysqlconn)
            READER = COMMAND.ExecuteReader
            mysqlconn.Close()
            MsgBox("Report Register Was Successfully Created !!")
            Form2.Show()
            Me.Close()
        End If
    End Sub
End Class
Imports MySql.Data.MySqlClient
Imports System.Math
Public Class Form6
    Dim mysqlconn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub ts_Home_Click(sender As Object, e As EventArgs)
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub ts_AssetReg_Click(sender As Object, e As EventArgs)
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub ts_Maintanance_Click(sender As Object, e As EventArgs)
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub ts_Query_Click(sender As Object, e As EventArgs)
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub ts_Analysis_Click(sender As Object, e As EventArgs)
        Me.Show()
    End Sub

    Private Sub ts_Inventory_Click(sender As Object, e As EventArgs) Handles ts_Inventory.Click
        Form7.Show()
        Me.Close()
    End Sub

    Private Sub ts_Library_Click(sender As Object, e As EventArgs) Handles ts_Library.Click
        Form8.Show()
        Me.Close()
    End Sub

    Private Sub ts_Login_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub ts_Register_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a, b, c, dep, rate, sv, pl As Double
        dep = (1 - 0.25)
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = Val(TextBox3.Text)
        rate = Math.Pow(dep, c)
        sv = b * rate
        pl = sv - a

        Label8.Text = "Scrap Value: $" & sv & "" & vbCrLf & "" & vbCrLf & "Profit & Loss: $" & pl & ""
    End Sub

End Class
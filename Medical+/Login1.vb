Imports System.Data.OleDb
Public Class Login1
    Public f As Int16

    Public SAPI = CreateObject("SAPI.SPVOICE")

    Public connstring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ABHISHEK JADHAV\Desktop\Medical+db.accdb; persist security info=false"
    Public conn As New OleDbConnection


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn.ConnectionString = connstring
        conn.Open()

        ComboBox1.Items.Add("OWNER")
        ComboBox1.Items.Add("EMPLOYEE")


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        conn.Close()
        Me.Close()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error GoTo save
        If ("OWNER" = ComboBox1.Text Or "owner" = ComboBox1.Text) And TextBox1.Text = My.Settings.Admin Then
            TextBox1.Text =
                f = 0
            Me.Hide()
            Form2.Show()

        ElseIf ("EMPLOYEE" = ComboBox1.SelectedItem.ToString Or "employee" = ComboBox1.SelectedItem.ToString) And TextBox1.Text = My.Settings.Employee Then
            TextBox1.Text = ""
            f = 1
            Me.Hide()
            Employee3.Show()


        Else
save:

            MsgBox("Wrong username or password. . .")
            TextBox1.Text = ""

        End If

    End Sub
End Class

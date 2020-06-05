Imports System.Data.OleDb
Public Class Expiry11
    Dim sqlcommand As New OleDbCommand
    Private Sub Form11_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Login1.f = 0 Then
            Me.BackColor = My.Settings.Adminback
            Me.ForeColor = My.Settings.Adminfore
        ElseIf Login1.f = 1 Then
            Me.BackColor = My.Settings.Employeeback
            Me.ForeColor = My.Settings.Employeefore
        End If

        Label1.Text = "Medicine Expire  In Next "
        Label1.Text = Label1.Text + My.Settings.Expiryday + " Day"

        Dim check As String = Date.Now.AddDays(My.Settings.Expiryday)
        Dim sqlquery As String = "update purchase1 set tday = @dobg"
        Dim sqlcommand As New OleDbCommand
        With sqlcommand
            .CommandText = sqlquery
            .Connection = Login1.conn
            sqlcommand.Parameters.AddWithValue("@dobg", check)
            .ExecuteNonQuery()
        End With

        Dim sqlquery1 As String = "SELECT Supplier_id,Product_id,Product_name,Qty,Alert_qty,Mfg,Exp FROM purchase1 where tday >= Exp"
        With sqlcommand
            .CommandText = sqlquery1
            .Connection = Login1.conn
            .ExecuteNonQuery()
        End With
        Dim sda As New OleDbDataAdapter(sqlcommand)
        Dim dt As New DataTable()
        sda.Fill(dt)
        DataGridView1.DataSource = dt


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label1.Text = "Medicine Expire  In Next "
        Label1.Text = Label1.Text + My.Settings.Expiryday + " Day"

        Dim check As String = Date.Now.AddDays(My.Settings.Expiryday)
        Dim sqlquery As String = "update purchase1 set tday = @dobg"
        Dim sqlcommand As New OleDbCommand
        With sqlcommand
            .CommandText = sqlquery
            .Connection = Login1.conn
            sqlcommand.Parameters.AddWithValue("@dobg", check)
            .ExecuteNonQuery()
        End With

        Dim sqlquery1 As String = "SELECT Supplier_id,Product_id,Product_name,Qty,Alert_qty,Mfg,Exp FROM purchase1 where tday >= Exp"
        With sqlcommand
            .CommandText = sqlquery1
            .Connection = Login1.conn
            .ExecuteNonQuery()
        End With
        Dim sda As New OleDbDataAdapter(sqlcommand)
        Dim dt As New DataTable()
        sda.Fill(dt)
        DataGridView1.DataSource = dt


    End Sub


End Class
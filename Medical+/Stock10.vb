Imports System.Data.OleDb
Public Class Stock10

    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Login1.f = 0 Then
            Me.BackColor = My.Settings.Adminback
            Me.ForeColor = My.Settings.Adminfore
        ElseIf Login1.f = 1 Then
            Me.BackColor = My.Settings.Employeeback
            Me.ForeColor = My.Settings.Employeefore
        End If


        Dim sqlquery As String = "SELECT Supplier_id,Product_id,Product_name,Qty,Alert_qty,exp FROM purchase1 where Qty <= Alert_qty"
        Dim sqlcommand As New OleDbCommand
        With sqlcommand
            .CommandText = sqlquery
            .Connection = Login1.conn
            .ExecuteNonQuery()
        End With
        Dim sda As New OleDbDataAdapter(sqlcommand)
        Dim dt As New DataTable()
        sda.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sqlquery As String = "SELECT Supplier_id,Product_id,Product_name,Qty,Alert_qty,exp FROM purchase1 where Qty <= Alert_qty"
        Dim sqlcommand As New OleDbCommand
        With sqlcommand
            .CommandText = sqlquery
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
End Class
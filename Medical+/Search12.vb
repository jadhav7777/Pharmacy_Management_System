Imports System.Data.OleDb

Public Class Search12
    Dim sqlquery As String

    Private Sub Form12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Login1.f = 0 Then
            Me.BackColor = My.Settings.Adminback
            Me.ForeColor = My.Settings.Adminfore
        ElseIf Login1.f = 1 Then
            Me.BackColor = My.Settings.Employeeback
            Me.ForeColor = My.Settings.Employeefore
        End If


        TextBox1.Text = ""
        RadioButton1.Checked = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = True

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' check = " '" & TextBox1.Text & "%' "
        ' MsgBox(check)
        If DataGridView1.Focused <> True And GroupBox1.Focused <> True Then
            If RadioButton1.Checked Then
                sqlquery = "SELECT S_no,Product_id,Supplier_id,Product_name,Purchase_date,Qty,Price_qty,Alert_qty,Mfg,Exp,Total_price FROM purchase1 where Product_id like '" & TextBox1.Text & "%' "
            ElseIf RadioButton2.Checked Then
                sqlquery = "SELECT S_no,Product_id,Supplier_id,Product_name,Purchase_date,Qty,Price_qty,Alert_qty,Mfg,Exp,Total_price FROM purchase1 where Supplier_id like '" & TextBox1.Text & "%' "
            ElseIf RadioButton3.Checked Then
                sqlquery = "SELECT S_no,Product_id,Supplier_id,Product_name,Purchase_date,Qty,Price_qty,Alert_qty,Mfg,Exp,Total_price FROM purchase1 where Product_name like '" & TextBox1.Text & "%' "
            ElseIf RadioButton4.Checked Then
                sqlquery = "SELECT S_no,Product_id,Supplier_id,Product_name,Purchase_date,Qty,Price_qty,Alert_qty,Mfg,Exp,Total_price FROM purchase1 where Price_qty like '" & TextBox1.Text & "%' "
            End If

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
        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
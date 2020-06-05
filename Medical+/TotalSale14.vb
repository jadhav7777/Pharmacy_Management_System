Imports System.Data.OleDb
Imports System.Data.SqlDbType
Public Class Form14
    Dim bill_noe As String

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Form14_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Login1.f = 0 Then
            Me.BackColor = My.Settings.Adminback
            Me.ForeColor = My.Settings.Adminfore
        ElseIf Login1.f = 1 Then
            Me.BackColor = My.Settings.Employeeback
            Me.ForeColor = My.Settings.Employeefore
        End If
        Button1.ForeColor = Color.Blue

        Dim sqlquery3 As String = "SELECT * from sales "
        Dim sqlcommand3 As New OleDbCommand

        With sqlcommand3
            .CommandText = sqlquery3
            .Connection = Login1.conn
            .ExecuteNonQuery()
        End With
        Dim sda As New OleDbDataAdapter(sqlcommand3)
        Dim dt As New DataTable()
        sda.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub OwnerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SaleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleToolStripMenuItem.Click

        Dim sqlquery3 As String = "SELECT * from sales "
        Dim sqlcommand3 As New OleDbCommand

        With sqlcommand3
            .CommandText = sqlquery3
            .Connection = Login1.conn
            .ExecuteNonQuery()
        End With
        Dim sda As New OleDbDataAdapter(sqlcommand3)
        Dim dt As New DataTable()
        sda.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub TodayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TodayToolStripMenuItem.Click




        '  Dim check As String = Date.Now.AddDays(My.Settings.Expiryday)
        Dim check As String = Date.Today
        MsgBox(check)
        Dim sqlquery3 As String = "SELECT * from sales where Sale_Date = @dobg "
        Dim sqlcommand3 As New OleDbCommand

        With sqlcommand3
            .CommandText = sqlquery3
            .Connection = Login1.conn
            sqlcommand3.Parameters.AddWithValue("@dobg", check)
            .ExecuteNonQuery()
        End With
        Dim sda As New OleDbDataAdapter(sqlcommand3)
        Dim dt As New DataTable()
        sda.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub CompleteEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompleteEntryToolStripMenuItem.Click
        Dim ask As New MsgBoxResult

        ask = MsgBox("Delete all sales entry. . .", MsgBoxStyle.OkCancel, "Medical+")
        If ask = MsgBoxResult.Ok Then

            Dim sqlquery3 As String = "delete from sales "
            Dim sqlcommand3 As New OleDbCommand

            With sqlcommand3
                .CommandText = sqlquery3
                .Connection = Login1.conn
                .ExecuteNonQuery()
            End With



            Dim sqlquery As String = "SELECT * from sales "
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
            Beep()




        Else
            Beep()
        End If

    End Sub

    Private Sub ByOwnerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByOwnerToolStripMenuItem.Click

        Dim sqlquery3 As String = "SELECT * from sales where Sale_By= '" & My.Settings.ownername & "' "
        Dim sqlcommand3 As New OleDbCommand

        With sqlcommand3
            .CommandText = sqlquery3
            .Connection = Login1.conn
            .ExecuteNonQuery()
        End With
        Dim sda As New OleDbDataAdapter(sqlcommand3)
        Dim dt As New DataTable()
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub ByEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByEmployeeToolStripMenuItem.Click
        Dim sqlquery3 As String = "SELECT * from sales where Sale_By= '" & My.Settings.employeename & "' "
        Dim sqlcommand3 As New OleDbCommand

        With sqlcommand3
            .CommandText = sqlquery3
            .Connection = Login1.conn
            .ExecuteNonQuery()
        End With
        Dim sda As New OleDbDataAdapter(sqlcommand3)
        Dim dt As New DataTable()
        sda.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub ByBillNoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByBillNoToolStripMenuItem.Click

        Dim bill_no As String

        bill_no = InputBox("Enter bill number to delete entry. . .")

        Dim sqlquery3 As String = "delete from sales where Bill_NO = @dobg "

        Dim sqlcommand3 As New OleDbCommand

        With sqlcommand3
            .CommandText = sqlquery3
            .Connection = Login1.conn
            sqlcommand3.Parameters.AddWithValue("@dobg", bill_no)
            .ExecuteNonQuery()
        End With

        Dim sqlquery As String = "SELECT * from sales "
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
        Beep()

    End Sub

    Private Sub BillNoToBillNoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillNoToBillNoToolStripMenuItem.Click
        On Error GoTo save
        Dim bill_nos As String

        bill_nos = InputBox("Enter first bill number of range. . .")

        bill_noe = InputBox("Enter last bill number of range. . .")

        Dim sqlquery3 As String = "delete from sales where Bill_NO  between @dobg and @dobh "
        Dim sqlcommand3 As New OleDbCommand
        With sqlcommand3
            .CommandText = sqlquery3
            .Connection = Login1.conn
            sqlcommand3.Parameters.AddWithValue("@dobg", bill_nos)
            sqlcommand3.Parameters.AddWithValue("@dobh", bill_noe)

            .ExecuteNonQuery()
        End With

save:

        Dim sqlquery As String = "SELECT * from sales "
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
        Beep()


    End Sub

    Private Sub ByDateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByDateToolStripMenuItem.Click

    End Sub

    Private Sub DateToDateToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateToDateToolStripMenuItem1.Click

    End Sub
End Class
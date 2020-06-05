Imports System.Data.OleDb
Public Class Sale13
    Dim check As String
    Dim sqlquery As String
    Dim mname As String
    Dim price As String
    Dim d As Double
    Dim i As Integer = 1
    Dim Product_id As String
    Dim Purchase_date As Date
    Dim Qty As Int64
    Dim Available_qty As New Int64
    Public expdate As Date
    Dim Sale_by As String




    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = True

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        Timer1.Enabled = False
    End Sub

    Private Sub Form13_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox3.Text = My.Settings.billno
        Button5.Enabled = False

        Dim sqlq As String = "delete from salestemp"
        Dim sqlcommand As New OleDbCommand
        With sqlcommand
            .CommandText = sqlq
            .Connection = Login1.conn
            .ExecuteNonQuery()
        End With



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

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' check = " '" & TextBox1.Text & "%' "
        ' MsgBox(check)
        If DataGridView1.Focused <> True Then
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

        On Error GoTo save

        Dim mycommand As New OleDbCommand("select Product_name,Price_qty,exp,Product_id,Purchase_date,Qty from purchase1 where Product_name = '" & Product_nameTextBox.Text & "' ", Login1.conn)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader()

        While myreader.Read()
            mname = myreader.GetString(0)
            price = myreader.GetString(1)
            expdate = myreader.GetValue(2)
            Product_id = myreader.GetString(3)
            Purchase_date = myreader.GetValue(4)
            Qty = myreader.GetValue(5)
        End While

        If Val(TextBox2.Text) <= Qty Then


            d = Val(price) * Val(TextBox2.Text)
            Available_qty = Qty - Val(TextBox2.Text)

            Dim sqlquery As String = "insert into salestemp(S_No,Medicine_Name,Quantity,Price_Quantity,Total,exp_date) values( '" & i & "' ,'" & Product_nameTextBox.Text & "','" & TextBox2.Text & "','" & price & "','" & d & "','" & expdate & "' )"

            Dim sqlcommand As New OleDbCommand
            With sqlcommand
                .CommandText = sqlquery
                .Connection = Login1.conn
                .ExecuteNonQuery()
            End With


            If Login1.f = 0 Then
                Sale_by = Form2.Label9.Text
            ElseIf Login1.f = 1 Then
                Sale_by = Employee3.Label11.Text

            End If


            Dim sqlqu As String = "insert into sales(Bill_No,Sale_Date,Medicine_id,Medicine_Name,Quantity,Price_Quantity,Total,Now_Available,Purchase_date,exp_date,Sale_by) values( '" & Val(TextBox3.Text) & "','" & System.DateTime.Now & "','" & Product_id & "','" & Product_nameTextBox.Text & "','" & TextBox2.Text & "','" & price & "','" & d & "','" & Available_qty & "','" & Purchase_date & "','" & expdate & "','" & Sale_by & "' )"

            Dim sqlco As New OleDbCommand
            With sqlcommand
                .CommandText = sqlqu
                .Connection = Login1.conn
                .ExecuteNonQuery()
            End With

            Dim sqlquery1 As String = "update   purchase1 set Qty= ( Qty - '" & TextBox2.Text & "') where Product_name = '" & Product_nameTextBox.Text & "' "
            Dim sqlcommand1 As New OleDbCommand
            With sqlcommand1
                .CommandText = sqlquery1
                .Connection = Login1.conn
                .ExecuteNonQuery()
            End With
            TextBox2.Text = ""
            Product_nameTextBox.Text = ""
            i = i + 1



            Dim sqlquery3 As String = "SELECT * from salestemp "
            Dim sqlcommand3 As New OleDbCommand
            With sqlcommand3
                .CommandText = sqlquery3
                .Connection = Login1.conn
                .ExecuteNonQuery()
            End With
            Dim sda As New OleDbDataAdapter(sqlcommand3)
            Dim dt As New DataTable()
            sda.Fill(dt)
            DataGridView2.DataSource = dt
            TextBox3.Enabled = False
            Button5.Enabled = True



        Else


            MsgBox("Only " + Str(Qty) + " units available")

        End If


save:

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form14.Show()

    End Sub

    Private Sub Button5_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        On Error GoTo save
        Dim sqlq As String = "delete from salestemp"
        Dim sqlcommand As New OleDbCommand
        With sqlcommand
            .CommandText = sqlq
            .Connection = Login1.conn
            .ExecuteNonQuery()
        End With

        Dim sqlquery3 As String = "SELECT * from salestemp "
        Dim sqlcommand3 As New OleDbCommand
        With sqlcommand3
            .CommandText = sqlquery3
            .Connection = Login1.conn
            .ExecuteNonQuery()
        End With
        Dim sda As New OleDbDataAdapter(sqlcommand3)
        Dim dt As New DataTable()
        sda.Fill(dt)
        DataGridView2.DataSource = dt
        TextBox3.Enabled = True
        My.Settings.billno = My.Settings.billno + 1
        TextBox3.Text = My.Settings.billno
        My.Settings.Save()
        i = 1
        Button5.Enabled = False
save:
    End Sub
End Class
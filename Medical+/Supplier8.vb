Imports System.Data.OleDb
Public Class Supplier8
    Dim newdata As Boolean
    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Login1.f = 0 Then
            Me.BackColor = My.Settings.Adminback
            Me.ForeColor = My.Settings.Adminfore
        ElseIf Login1.f = 1 Then
            Me.BackColor = My.Settings.Employeeback
            Me.ForeColor = My.Settings.Employeefore
        End If

        'TODO: This line of code loads data into the '_Medical_dbDataSet1.supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me._Medical_dbDataSet1.supplier)
        'TODO: This line of code loads data into the '_Medical_dbDataSet1.supplier' table. You can move, or remove it, as needed.

        newdata = False

        TextBox7.Text = TextBox1.Text


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        newdata = True
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error GoTo save
        If newdata Then

            Dim sqlquery As String = "insert into supplier(id,Supplier_Name,Company_Name,Mobile,Email,Address) values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')"
            Dim sqlcommand As New OleDbCommand
            With sqlcommand
                .CommandText = sqlquery
                .Connection = Login1.conn
                .ExecuteNonQuery()
                MsgBox("Done.....")
                newdata = False

                Me.SupplierTableAdapter.Fill(Me._Medical_dbDataSet1.supplier)
            End With
          

        Else

            Dim sqlquery As String = "update  supplier set id='" & TextBox1.Text & "',Supplier_Name='" & TextBox2.Text & "',Company_Name='" & TextBox3.Text & "',Mobile='" & TextBox4.Text & "',Email='" & TextBox5.Text & "',Address='" & TextBox6.Text & "' where id='" & TextBox7.Text & "'  "
            Dim sqlcommand As New OleDbCommand
            With sqlcommand
                .CommandText = sqlquery
                .Connection = Login1.conn
                .ExecuteNonQuery()
                MsgBox("Done.....")
                Me.SupplierTableAdapter.Fill(Me._Medical_dbDataSet1.supplier)
                TextBox7.Text = TextBox1.Text
            End With
          

        End If
save:
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        On Error GoTo save

        Dim sqlquery As String = "delete from supplier where id='" & TextBox1.Text & "' "
        Dim sqlcommand As New OleDbCommand
        With sqlcommand
            .CommandText = sqlquery
            .Connection = Login1.conn
            .ExecuteNonQuery()
            MsgBox("Done.....")
            Me.SupplierTableAdapter.Fill(Me._Medical_dbDataSet1.supplier)
        End With
save:
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub
End Class
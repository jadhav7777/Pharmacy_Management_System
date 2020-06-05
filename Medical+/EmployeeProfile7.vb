Imports System.Data.OleDb
Imports System.IO
Public Class EmployeeProfile7

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BackColor = My.Settings.Employeeback
        Me.ForeColor = My.Settings.Employeefore

        Button2.ForeColor = Color.Blue
        Button3.ForeColor = Color.Blue
        Dim mycommand As New OleDbCommand("select * from employee_profile", Login1.conn)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader()

        myreader.Read()
        TextBox1.Text = myreader.GetString(0)
        TextBox2.Text = myreader.GetString(1)
        If myreader.GetString(2) = "Male" Then
            RadioButton1.Select()
        Else
            RadioButton2.Select()
        End If
        DateTimePicker1.Value = myreader.GetDateTime(3)
        DateTimePicker2.Value = myreader.GetDateTime(4)
        TextBox4.Text = myreader.GetString(5)
        TextBox5.Text = myreader.GetString(6)
        TextBox6.Text = myreader.GetString(7)
        TextBox3.Text = myreader.GetString(8)

        Dim bits As Byte() = CType(myreader("pic"), Byte())
        Dim memo As New MemoryStream(bits)
        Dim myimg As New Bitmap(memo)
        PictureBox1.Image = myimg



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error GoTo save
        OpenFileDialog1.Filter = " IMAGE FILE (*.JPG , *.BMP , *.PNG ) | *.JPG; *.BMP , *.PNG | ALL FILES(*.*) |* . * "
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
save:
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error GoTo save
        Dim genderg As String = ""
        If RadioButton1.Checked = True Then
            genderg = "Male"
        Else
            genderg = "Female"
        End If
        Dim myfreader As New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read)
        Dim breader As New BinaryReader(myfreader)
        Dim imgbuffer(myfreader.Length) As Byte
        breader.Read(imgbuffer, 0, myfreader.Length)
        myfreader.Close()
        Dim sqlquery As String = "update employee_profile set first_name='" & TextBox1.Text & "',last_name='" & TextBox2.Text & "',gender=@gen,dob=@dobg,doj=@dojg,quali='" & TextBox4.Text & "',mobile_no='" & TextBox5.Text & "',email_id='" & TextBox6.Text & "',aadhar_no='" & TextBox3.Text & "',pic=@picd "
        Dim sqlcommand As New OleDbCommand
        With sqlcommand
            .CommandText = sqlquery
            .Connection = Login1.conn
            sqlcommand.Parameters.AddWithValue("@gen", genderg)
            sqlcommand.Parameters.AddWithValue("@dobg", DateTimePicker1.Value.Date)
            sqlcommand.Parameters.AddWithValue("@dojg", DateTimePicker2.Value.Date)
            sqlcommand.Parameters.AddWithValue("@picd", imgbuffer)
            .ExecuteNonQuery()

            Login1.SAPI.speak("Updated Successfully.....")
            MsgBox("Updated Successfully.....")
            Me.Close()
        End With
save:
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
End Class
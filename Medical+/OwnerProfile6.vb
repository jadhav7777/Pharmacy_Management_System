Imports System.Data.OleDb
Imports System.IO
Public Class OwnerProfile6
    Public pic_names As String
    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo save
        Me.BackColor = My.Settings.Adminback
        Me.ForeColor = My.Settings.Adminfore


        Button2.ForeColor = Color.Blue
        Button3.ForeColor = Color.Blue




        TextBox1.Text = Form2.first
        TextBox2.Text = Form2.last
        If Form2.Label10.Text = "Male" Then
            RadioButton1.Select()
        Else
            RadioButton2.Select()
        End If
        DateTimePicker1.Value = Form2.Label11.Text
        TextBox3.Text = Form2.Label12.Text
        TextBox5.Text = Form2.Label13.Text
        TextBox6.Text = Form2.Label14.Text
        PictureBox1.Image = Form2.PictureBox1.Image
save:
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error GoTo save
        OpenFileDialog1.Filter = " IMAGE FILE (*.JPG , *.BMP , *.PNG ) | *.JPG; *.BMP , *.PNG | ALL FILES(*.*) |* . * "
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
        If OpenFileDialog1.FileName <> Nothing Or OpenFileDialog1.FileName <> "" Then

            pic_names = OpenFileDialog1.FileName.Substring( _
                OpenFileDialog1.FileName.LastIndexOf("\") + 1, _
                (OpenFileDialog1.FileName.IndexOf(".", 0) - (OpenFileDialog1.FileName.LastIndexOf("\") + 1)))


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

        Dim sqlquery As String = "update owner_profile set first_name='" & TextBox1.Text & "',last_name='" & TextBox2.Text & "',gender=@gen,dob=@dobg,quali='" & TextBox3.Text & "',mobile_no='" & TextBox5.Text & "',email_id='" & TextBox6.Text & "',pic=@picd,pic_name=@picdname "
        Dim sqlcommand As New OleDbCommand
        With sqlcommand
            .CommandText = sqlquery
            .Connection = Login1.conn
            sqlcommand.Parameters.AddWithValue("@gen", genderg)
            sqlcommand.Parameters.AddWithValue("@dobg", DateTimePicker1.Value.Date)
            sqlcommand.Parameters.AddWithValue("@picd", imgbuffer)
            sqlcommand.Parameters.AddWithValue("@picdname", pic_names)
            .ExecuteNonQuery()


            MsgBox("Updated Successfully.....")

            Form2.Close()
            Form2.Show()
            Me.Close()
        End With
save:
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
End Class
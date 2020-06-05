Public Class EmployeePass5

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Form2.check1 = 1 Then
            If TextBox2.Text = TextBox3.Text Then
                My.Settings.Employee = TextBox2.Text
                Me.Close()
                MsgBox("Password change" + vbNewLine + "successfully. . .")
                My.Settings.Save()
                Form2.check1 = 0
            Else
                MsgBox("Password does " + vbNewLine + " not match. . .")
                TextBox2.Text = ""
                TextBox3.Text = ""
            End If
        Else

            If TextBox1.Text = My.Settings.Employee Then
                If TextBox2.Text = TextBox3.Text Then
                    My.Settings.Employee = TextBox2.Text
                    Me.Close()
                    MsgBox("Password change" + vbNewLine + "successfully. . .")
                    My.Settings.Save()
                    Form2.check1 = 0
                Else
                    MsgBox("Password does " + vbNewLine + " not match. . .")
                    TextBox2.Text = ""
                    TextBox3.Text = ""
                End If
            Else

                MsgBox("Wrong password. . .")
                TextBox1.Text = ""
            End If

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form2.check1 = 0
        Me.Close()
    End Sub
End Class

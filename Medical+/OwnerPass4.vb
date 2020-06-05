Public Class OwnerPass4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If TextBox1.Text = My.Settings.Admin Then
            If TextBox2.Text = TextBox3.Text Then
                My.Settings.Admin = TextBox2.Text
                Me.Close()
                MsgBox("Password change" + vbNewLine + "successfully. . .")
                My.Settings.Save()
            Else
                MsgBox("Password does not match")
                TextBox2.Text = ""
                TextBox3.Text = ""
            End If
        Else

            MsgBox("Wrong password. . .")
            TextBox1.Text = ""
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
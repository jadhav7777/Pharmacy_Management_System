Imports System.Data.OleDb
Imports System.IO
Public Class Form2
    Public check1 As Int16 = 0
    Public first, last As String

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        OwnerPass4.Show()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        HOMEToolStripMenuItem.Select()
        Label2.Show()

        Label2.ForeColor = My.Settings.adclock
        Me.BackColor = My.Settings.Adminback
        Me.ForeColor = My.Settings.Adminfore
        check1 = 0

        Dim mycommand As New OleDbCommand("select * from owner_profile", Login1.conn)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader()

        myreader.Read()
        first = myreader.GetString(0)
        last = myreader.GetString(1)
        Label9.Text = first + " " + last
        My.Settings.ownername = Label9.Text
        My.Settings.Save()
        Label10.Text = myreader.GetString(2)
        Label11.Text = myreader.GetDateTime(3)

        Label12.Text = myreader.GetString(4)
        Label13.Text = myreader.GetString(5)
        Label14.Text = myreader.GetString(6)



        Dim bits As Byte() = CType(myreader("pic"), Byte())
        Dim memo As New MemoryStream(bits)
        Dim myimg As New Bitmap(memo)
        PictureBox1.Image = myimg


        Label1.Show()
        Label3.Show()
        Label4.Show()
        Label6.Show()
        Label5.Show()
        Label7.Show()
        Label9.Show()
        Label10.Show()
        Label11.Show()
        Label12.Show()
        Label13.Show()
        Label14.Show()
        Label8.Show()
        PictureBox1.Show()
    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = Date.Now.ToString("dd MMM yyyy  hh:mm:ss")


    End Sub


    Private Sub ToolStripMenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem13.Click
        check1 = 1
        EmployeePass5.Show()

        EmployeePass5.Label1.Hide()
        EmployeePass5.TextBox1.Hide()

    End Sub

    Private Sub ToolStripMenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem15.Click

    End Sub

    Private Sub ToolStripMenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem16.Click
        If (ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            If (ColorDialog1.Color <> Me.ForeColor) Then
                Me.BackColor = ColorDialog1.Color
                My.Settings.Adminback = ColorDialog1.Color
                My.Settings.Save()

            Else
                MsgBox("Background Colour and Text Colour Can't be same")
            End If
        End If

    End Sub

    Private Sub ToolStripMenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem18.Click
        Login1.TextBox1.Text = ""

        Login1.Show()
        Me.Close()

    End Sub

    Private Sub ToolStripMenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem14.Click
        EmployeeProfile7.Show()

    End Sub

    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem11.Click
        EmployeePass5.Show()

    End Sub

    Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click

    End Sub

    Private Sub ExpiryDateAlertToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpiryDateAlertToolStripMenuItem.Click
        My.Settings.Expiryday = InputBox("Enter number of days to alert before expiry date. . .")
        My.Settings.Save()

    End Sub

    Private Sub ResetToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem1.Click
        Me.BackColor = Color.White
        Me.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        My.Settings.Adminback = Color.White
        My.Settings.Adminfore = Color.Red
        My.Settings.adclock = Color.Red
        My.Settings.Save()

    End Sub

    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        Sale13.Show()

    End Sub

    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
        Search12.Show()

    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Purchase9.Show()

    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        Stock10.Show()
    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        Expiry11.Show()

    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Supplier8.Show()

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        OwnerProfile6.Show()

    End Sub

    Private Sub ToolStripMenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem17.Click
        If (ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            If (ColorDialog1.Color <> Me.BackColor) Then
                Me.ForeColor = ColorDialog1.Color
                My.Settings.Adminfore = ColorDialog1.Color
                My.Settings.Save()

            Else
                MsgBox("Text Colour and Background Colour Can't be same")
            End If
        End If

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        If (ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            Label2.ForeColor = ColorDialog1.Color
            My.Settings.adclock = ColorDialog1.Color
            My.Settings.Save()
        End If
    End Sub

    Private Sub BillNoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillNoToolStripMenuItem.Click
        Dim billno As New Int64
        billno = InputBox("Bill number start from. . .")
        My.Settings.billno = billno
        My.Settings.Save()
    End Sub

    Private Sub SalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesToolStripMenuItem.Click
        Form14.Show()

    End Sub
End Class
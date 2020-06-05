Imports System.Data.OleDb
Imports System.IO

Public Class Employee3
    Public first As String
    Public last As String

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        EmployeePass5.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        Login1.Show()
        Me.Close()

    End Sub

    Private Sub BackgroundToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackgroundToolStripMenuItem.Click


    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        HomeToolStripMenuItem.Select()
        Label2.Show()
        Label2.ForeColor = My.Settings.emclock
        Me.BackColor = My.Settings.Employeeback
        Me.ForeColor = My.Settings.Employeefore
        Dim mycommand As New OleDbCommand("select * from employee_profile", Login1.conn)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader()

        myreader.Read()
        first = myreader.GetString(0)
        last = myreader.GetString(1)
        Label11.Text = first + " " + last
        My.Settings.employeename = Label11.Text
        My.Settings.Save()
        Label12.Text = myreader.GetString(2)
        Label13.Text = myreader.GetDateTime(3)
        Label14.Text = myreader.GetDateTime(4)
        Label15.Text = myreader.GetString(5)
        Label16.Text = myreader.GetString(6)
        Label17.Text = myreader.GetString(7)
        Label18.Text = myreader.GetString(8)




        Dim bits As Byte() = CType(myreader("pic"), Byte())
        Dim memo As New MemoryStream(bits)
        Dim myimg As New Bitmap(memo)
        PictureBox1.Image = myimg



    End Sub

    Private Sub TextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextToolStripMenuItem.Click
        If (ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then

            If (ColorDialog1.Color <> Me.BackColor) Then
                Me.ForeColor = ColorDialog1.Color
                My.Settings.Employeefore = ColorDialog1.Color
                My.Settings.Save()

            Else
                MsgBox("Text Colour and Background Colour Can't be same")
            End If


        End If
    End Sub

    Private Sub ExpiryAlertDayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpiryAlertDayToolStripMenuItem.Click

        My.Settings.Expiryday = InputBox("Enter number of days to alert before expiry date. . .")

    End Sub

    Private Sub SaleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleToolStripMenuItem.Click
        Sale13.Show()

    End Sub

    Private Sub FindMedicineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindMedicineToolStripMenuItem.Click
        Search12.Show()

    End Sub

    Private Sub ExpiryDateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpiryDateToolStripMenuItem.Click
        Expiry11.Show()

    End Sub

    Private Sub CheckStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckStockToolStripMenuItem.Click
        Stock10.Show()

    End Sub

    Private Sub AddProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddProductToolStripMenuItem.Click
        Purchase9.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = Date.Now.ToString("dd MMM yyyy  hh:mm:ss")

    End Sub

    Private Sub ResetToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem1.Click
        Me.BackColor = Color.White
        Me.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        My.Settings.Employeeback = Color.White
        My.Settings.Employeefore = Color.Red
        My.Settings.emclock = Color.Red
        My.Settings.Save()
    End Sub

    Private Sub ExpiryAlertDayToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpiryAlertDayToolStripMenuItem1.Click
        My.Settings.Expiryday = InputBox("Enter number of days to alert before expiry date. . .")
        My.Settings.Save()

    End Sub

    Private Sub ToolStripMenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem12.Click
        If (ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            If (ColorDialog1.Color <> Me.BackColor) Then
                Me.ForeColor = ColorDialog1.Color
                My.Settings.Employeefore = ColorDialog1.Color
                My.Settings.Save()

            Else
                MsgBox("Text Colour and Background Colour Can't be same")
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem11.Click
        If (ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            If (ColorDialog1.Color <> Me.ForeColor) Then
                Me.BackColor = ColorDialog1.Color
                My.Settings.Employeeback = ColorDialog1.Color
                My.Settings.Save()

            Else
                MsgBox("Background Colour and Text Colour Can't be same")
            End If


        End If
    End Sub

    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        EmployeePass5.Show()

    End Sub

    Private Sub ToolStripMenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem13.Click
        Login1.TextBox1.Text = ""


        Login1.Show()
        Me.Close()

    End Sub

    Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click

    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        Sale13.Show()

    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        Search12.Show()

    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Stock10.Show()

    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        Expiry11.Show()

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Supplier8.Show()

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        If (ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            Label2.ForeColor = ColorDialog1.Color
            My.Settings.emclock = ColorDialog1.Color
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
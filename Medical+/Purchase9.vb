Public Class Purchase9

    Private Sub Purchase1BindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Purchase1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Medical_dbDataSet1)
        MsgBox("Updated Successfully.....")
    End Sub

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Login1.f = 0 Then
            Me.BackColor = My.Settings.Adminback
            Me.ForeColor = My.Settings.Adminfore
        ElseIf Login1.f = 1 Then
            Me.BackColor = My.Settings.Employeeback
            Me.ForeColor = My.Settings.Employeefore
        End If


        'TODO: This line of code loads data into the '_Medical_dbDataSet1.purchase1' table. You can move, or remove it, as needed.
        Me.Purchase1TableAdapter.Fill(Me._Medical_dbDataSet1.purchase1)
        'TODO: This line of code loads data into the '_Medical_dbDataSet1.purchase1' table. You can move, or remove it, as needed.
        Me.Purchase1TableAdapter.Fill(Me._Medical_dbDataSet1.purchase1)

    End Sub

    Private Sub Purchase1BindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Purchase1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Purchase1BindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Purchase1BindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me._Medical_dbDataSet1)
            Beep()
        Catch ex As Exception
            MsgBox("Operation was unsuccessful. . .")
        End Try


    End Sub

    Private Sub Price_qtyLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Alert_qtyLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MfgLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ExpLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Total_priceLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub QtyLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Purchase_dateLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Product_nameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Supplier_idLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub S_noLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Product_idLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MfgDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MfgDateTimePicker.ValueChanged

    End Sub

    Private Sub Purchase1BindingNavigator_RefreshItems_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Purchase1BindingNavigator.RefreshItems

    End Sub

    Private Sub Purchase1BindingSource_CurrentChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Purchase1BindingSource.CurrentChanged

    End Sub
End Class
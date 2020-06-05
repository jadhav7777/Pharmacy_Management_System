<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form14
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form14))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LastWeekToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateToDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByOwnerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByBillNoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillNoToBillNoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateToDateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompleteEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.Location = New System.Drawing.Point(12, 35)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.Size = New System.Drawing.Size(960, 351)
        Me.DataGridView1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(897, 397)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaleToolStripMenuItem, Me.SelectToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SaleToolStripMenuItem
        '
        Me.SaleToolStripMenuItem.Image = CType(resources.GetObject("SaleToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaleToolStripMenuItem.Name = "SaleToolStripMenuItem"
        Me.SaleToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.SaleToolStripMenuItem.Text = "&Sale"
        '
        'SelectToolStripMenuItem
        '
        Me.SelectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TodayToolStripMenuItem, Me.LastWeekToolStripMenuItem, Me.DateToDateToolStripMenuItem, Me.ByOwnerToolStripMenuItem, Me.ByEmployeeToolStripMenuItem})
        Me.SelectToolStripMenuItem.Image = CType(resources.GetObject("SelectToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SelectToolStripMenuItem.Name = "SelectToolStripMenuItem"
        Me.SelectToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.SelectToolStripMenuItem.Text = "&Select"
        '
        'TodayToolStripMenuItem
        '
        Me.TodayToolStripMenuItem.Name = "TodayToolStripMenuItem"
        Me.TodayToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.TodayToolStripMenuItem.Text = "&Today"
        '
        'LastWeekToolStripMenuItem
        '
        Me.LastWeekToolStripMenuItem.Name = "LastWeekToolStripMenuItem"
        Me.LastWeekToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.LastWeekToolStripMenuItem.Text = "&Last Week"
        '
        'DateToDateToolStripMenuItem
        '
        Me.DateToDateToolStripMenuItem.Name = "DateToDateToolStripMenuItem"
        Me.DateToDateToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.DateToDateToolStripMenuItem.Text = "&Date to date"
        '
        'ByOwnerToolStripMenuItem
        '
        Me.ByOwnerToolStripMenuItem.Name = "ByOwnerToolStripMenuItem"
        Me.ByOwnerToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ByOwnerToolStripMenuItem.Text = "&By owner"
        '
        'ByEmployeeToolStripMenuItem
        '
        Me.ByEmployeeToolStripMenuItem.Name = "ByEmployeeToolStripMenuItem"
        Me.ByEmployeeToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ByEmployeeToolStripMenuItem.Text = "&By employee"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ByBillNoToolStripMenuItem, Me.BillNoToBillNoToolStripMenuItem, Me.ByDateToolStripMenuItem, Me.DateToDateToolStripMenuItem1, Me.CompleteEntryToolStripMenuItem})
        Me.DeleteToolStripMenuItem.Image = CType(resources.GetObject("DeleteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.DeleteToolStripMenuItem.Text = "&Delete"
        '
        'ByBillNoToolStripMenuItem
        '
        Me.ByBillNoToolStripMenuItem.Name = "ByBillNoToolStripMenuItem"
        Me.ByBillNoToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ByBillNoToolStripMenuItem.Text = "&By bill no"
        '
        'BillNoToBillNoToolStripMenuItem
        '
        Me.BillNoToBillNoToolStripMenuItem.Name = "BillNoToBillNoToolStripMenuItem"
        Me.BillNoToBillNoToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.BillNoToBillNoToolStripMenuItem.Text = "&Bill no to bill no"
        '
        'ByDateToolStripMenuItem
        '
        Me.ByDateToolStripMenuItem.Name = "ByDateToolStripMenuItem"
        Me.ByDateToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ByDateToolStripMenuItem.Text = "&By date"
        '
        'DateToDateToolStripMenuItem1
        '
        Me.DateToDateToolStripMenuItem1.Name = "DateToDateToolStripMenuItem1"
        Me.DateToDateToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.DateToDateToolStripMenuItem1.Text = "&Date to date"
        '
        'CompleteEntryToolStripMenuItem
        '
        Me.CompleteEntryToolStripMenuItem.Name = "CompleteEntryToolStripMenuItem"
        Me.CompleteEntryToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.CompleteEntryToolStripMenuItem.Text = "&All entry"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(25, 20)
        Me.ToolStripMenuItem1.Text = "  "
        Me.ToolStripMenuItem1.Visible = False
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 429)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(1080, 468)
        Me.Name = "Form14"
        Me.Text = "Total Sale. . ."
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SelectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TodayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LastWeekToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateToDateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByOwnerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByBillNoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BillNoToBillNoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByDateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateToDateToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompleteEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class

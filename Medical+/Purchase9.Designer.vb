<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purchase9
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
        Me.components = New System.ComponentModel.Container()
        Dim S_noLabel As System.Windows.Forms.Label
        Dim Total_priceLabel As System.Windows.Forms.Label
        Dim MfgLabel As System.Windows.Forms.Label
        Dim ExpLabel As System.Windows.Forms.Label
        Dim Alert_qtyLabel As System.Windows.Forms.Label
        Dim Price_qtyLabel As System.Windows.Forms.Label
        Dim QtyLabel As System.Windows.Forms.Label
        Dim Purchase_dateLabel As System.Windows.Forms.Label
        Dim Product_nameLabel As System.Windows.Forms.Label
        Dim Supplier_idLabel As System.Windows.Forms.Label
        Dim Product_idLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Purchase9))
        Me.ExpDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Purchase1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._Medical_dbDataSet1 = New Medical_._Medical_dbDataSet1()
        Me.MfgDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Total_priceTextBox = New System.Windows.Forms.TextBox()
        Me.Alert_qtyTextBox = New System.Windows.Forms.TextBox()
        Me.Price_qtyTextBox = New System.Windows.Forms.TextBox()
        Me.QtyTextBox = New System.Windows.Forms.TextBox()
        Me.Purchase_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Product_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Supplier_idTextBox = New System.Windows.Forms.TextBox()
        Me.Product_idTextBox = New System.Windows.Forms.TextBox()
        Me.S_noTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Purchase1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Purchase1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Purchase1TableAdapter = New Medical_._Medical_dbDataSet1TableAdapters.purchase1TableAdapter()
        Me.TableAdapterManager = New Medical_._Medical_dbDataSet1TableAdapters.TableAdapterManager()
        Me.Purchase1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        S_noLabel = New System.Windows.Forms.Label()
        Total_priceLabel = New System.Windows.Forms.Label()
        MfgLabel = New System.Windows.Forms.Label()
        ExpLabel = New System.Windows.Forms.Label()
        Alert_qtyLabel = New System.Windows.Forms.Label()
        Price_qtyLabel = New System.Windows.Forms.Label()
        QtyLabel = New System.Windows.Forms.Label()
        Purchase_dateLabel = New System.Windows.Forms.Label()
        Product_nameLabel = New System.Windows.Forms.Label()
        Supplier_idLabel = New System.Windows.Forms.Label()
        Product_idLabel = New System.Windows.Forms.Label()
        CType(Me.Purchase1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Medical_dbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Purchase1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Purchase1BindingNavigator.SuspendLayout()
        CType(Me.Purchase1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'S_noLabel
        '
        S_noLabel.AutoSize = True
        S_noLabel.ForeColor = System.Drawing.Color.Blue
        S_noLabel.Location = New System.Drawing.Point(73, 46)
        S_noLabel.Name = "S_noLabel"
        S_noLabel.Size = New System.Drawing.Size(35, 15)
        S_noLabel.TabIndex = 26
        S_noLabel.Text = "S no:"
        AddHandler S_noLabel.Click, AddressOf Me.S_noLabel_Click
        '
        'Total_priceLabel
        '
        Total_priceLabel.AutoSize = True
        Total_priceLabel.ForeColor = System.Drawing.Color.Blue
        Total_priceLabel.Location = New System.Drawing.Point(470, 206)
        Total_priceLabel.Name = "Total_priceLabel"
        Total_priceLabel.Size = New System.Drawing.Size(68, 15)
        Total_priceLabel.TabIndex = 47
        Total_priceLabel.Text = "Total Price:"
        AddHandler Total_priceLabel.Click, AddressOf Me.Total_priceLabel_Click
        '
        'MfgLabel
        '
        MfgLabel.AutoSize = True
        MfgLabel.ForeColor = System.Drawing.Color.Blue
        MfgLabel.Location = New System.Drawing.Point(423, 122)
        MfgLabel.Name = "MfgLabel"
        MfgLabel.Size = New System.Drawing.Size(118, 15)
        MfgLabel.TabIndex = 43
        MfgLabel.Text = "Manufacturing Date:"
        AddHandler MfgLabel.Click, AddressOf Me.MfgLabel_Click
        '
        'ExpLabel
        '
        ExpLabel.AutoSize = True
        ExpLabel.ForeColor = System.Drawing.Color.Blue
        ExpLabel.Location = New System.Drawing.Point(470, 162)
        ExpLabel.Name = "ExpLabel"
        ExpLabel.Size = New System.Drawing.Size(72, 15)
        ExpLabel.TabIndex = 45
        ExpLabel.Text = "Expiry Date:"
        AddHandler ExpLabel.Click, AddressOf Me.ExpLabel_Click
        '
        'Alert_qtyLabel
        '
        Alert_qtyLabel.AutoSize = True
        Alert_qtyLabel.ForeColor = System.Drawing.Color.Blue
        Alert_qtyLabel.Location = New System.Drawing.Point(472, 83)
        Alert_qtyLabel.Name = "Alert_qtyLabel"
        Alert_qtyLabel.Size = New System.Drawing.Size(81, 15)
        Alert_qtyLabel.TabIndex = 41
        Alert_qtyLabel.Text = "Alert Quantity:"
        AddHandler Alert_qtyLabel.Click, AddressOf Me.Alert_qtyLabel_Click
        '
        'Price_qtyLabel
        '
        Price_qtyLabel.AutoSize = True
        Price_qtyLabel.ForeColor = System.Drawing.Color.Blue
        Price_qtyLabel.Location = New System.Drawing.Point(489, 46)
        Price_qtyLabel.Name = "Price_qtyLabel"
        Price_qtyLabel.Size = New System.Drawing.Size(63, 15)
        Price_qtyLabel.TabIndex = 39
        Price_qtyLabel.Text = "Price/Unit:"
        AddHandler Price_qtyLabel.Click, AddressOf Me.Price_qtyLabel_Click
        '
        'QtyLabel
        '
        QtyLabel.AutoSize = True
        QtyLabel.ForeColor = System.Drawing.Color.Blue
        QtyLabel.Location = New System.Drawing.Point(54, 249)
        QtyLabel.Name = "QtyLabel"
        QtyLabel.Size = New System.Drawing.Size(54, 15)
        QtyLabel.TabIndex = 37
        QtyLabel.Text = "Quantity:"
        AddHandler QtyLabel.Click, AddressOf Me.QtyLabel_Click
        '
        'Purchase_dateLabel
        '
        Purchase_dateLabel.AutoSize = True
        Purchase_dateLabel.ForeColor = System.Drawing.Color.Blue
        Purchase_dateLabel.Location = New System.Drawing.Point(19, 212)
        Purchase_dateLabel.Name = "Purchase_dateLabel"
        Purchase_dateLabel.Size = New System.Drawing.Size(89, 15)
        Purchase_dateLabel.TabIndex = 35
        Purchase_dateLabel.Text = "Purchase date:"
        AddHandler Purchase_dateLabel.Click, AddressOf Me.Purchase_dateLabel_Click
        '
        'Product_nameLabel
        '
        Product_nameLabel.AutoSize = True
        Product_nameLabel.ForeColor = System.Drawing.Color.Blue
        Product_nameLabel.Location = New System.Drawing.Point(22, 167)
        Product_nameLabel.Name = "Product_nameLabel"
        Product_nameLabel.Size = New System.Drawing.Size(96, 15)
        Product_nameLabel.TabIndex = 33
        Product_nameLabel.Text = "Medicine name:"
        AddHandler Product_nameLabel.Click, AddressOf Me.Product_nameLabel_Click
        '
        'Supplier_idLabel
        '
        Supplier_idLabel.AutoSize = True
        Supplier_idLabel.ForeColor = System.Drawing.Color.Blue
        Supplier_idLabel.Location = New System.Drawing.Point(42, 127)
        Supplier_idLabel.Name = "Supplier_idLabel"
        Supplier_idLabel.Size = New System.Drawing.Size(69, 15)
        Supplier_idLabel.TabIndex = 31
        Supplier_idLabel.Text = "Supplier id:"
        AddHandler Supplier_idLabel.Click, AddressOf Me.Supplier_idLabel_Click
        '
        'Product_idLabel
        '
        Product_idLabel.AutoSize = True
        Product_idLabel.ForeColor = System.Drawing.Color.Blue
        Product_idLabel.Location = New System.Drawing.Point(43, 86)
        Product_idLabel.Name = "Product_idLabel"
        Product_idLabel.Size = New System.Drawing.Size(74, 15)
        Product_idLabel.TabIndex = 29
        Product_idLabel.Text = "Medicine id:"
        AddHandler Product_idLabel.Click, AddressOf Me.Product_idLabel_Click
        '
        'ExpDateTimePicker
        '
        Me.ExpDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Purchase1BindingSource, "Exp", True))
        Me.ExpDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ExpDateTimePicker.Location = New System.Drawing.Point(565, 166)
        Me.ExpDateTimePicker.Name = "ExpDateTimePicker"
        Me.ExpDateTimePicker.Size = New System.Drawing.Size(189, 21)
        Me.ExpDateTimePicker.TabIndex = 46
        Me.ExpDateTimePicker.Value = New Date(2016, 11, 1, 0, 0, 0, 0)
        '
        'Purchase1BindingSource
        '
        Me.Purchase1BindingSource.DataMember = "purchase1"
        Me.Purchase1BindingSource.DataSource = Me._Medical_dbDataSet1
        '
        '_Medical_dbDataSet1
        '
        Me._Medical_dbDataSet1.DataSetName = "_Medical_dbDataSet1"
        Me._Medical_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MfgDateTimePicker
        '
        Me.MfgDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Purchase1BindingSource, "Mfg", True))
        Me.MfgDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MfgDateTimePicker.Location = New System.Drawing.Point(565, 119)
        Me.MfgDateTimePicker.Name = "MfgDateTimePicker"
        Me.MfgDateTimePicker.Size = New System.Drawing.Size(189, 21)
        Me.MfgDateTimePicker.TabIndex = 44
        Me.MfgDateTimePicker.Value = New Date(2016, 11, 1, 0, 0, 0, 0)
        '
        'Total_priceTextBox
        '
        Me.Total_priceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Purchase1BindingSource, "Total_price", True))
        Me.Total_priceTextBox.Location = New System.Drawing.Point(565, 206)
        Me.Total_priceTextBox.Name = "Total_priceTextBox"
        Me.Total_priceTextBox.Size = New System.Drawing.Size(189, 21)
        Me.Total_priceTextBox.TabIndex = 48
        '
        'Alert_qtyTextBox
        '
        Me.Alert_qtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Purchase1BindingSource, "Alert_qty", True))
        Me.Alert_qtyTextBox.Location = New System.Drawing.Point(565, 79)
        Me.Alert_qtyTextBox.Name = "Alert_qtyTextBox"
        Me.Alert_qtyTextBox.Size = New System.Drawing.Size(189, 21)
        Me.Alert_qtyTextBox.TabIndex = 42
        '
        'Price_qtyTextBox
        '
        Me.Price_qtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Purchase1BindingSource, "Price_qty", True))
        Me.Price_qtyTextBox.Location = New System.Drawing.Point(565, 44)
        Me.Price_qtyTextBox.Name = "Price_qtyTextBox"
        Me.Price_qtyTextBox.Size = New System.Drawing.Size(189, 21)
        Me.Price_qtyTextBox.TabIndex = 40
        '
        'QtyTextBox
        '
        Me.QtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Purchase1BindingSource, "Qty", True))
        Me.QtyTextBox.Location = New System.Drawing.Point(118, 245)
        Me.QtyTextBox.Name = "QtyTextBox"
        Me.QtyTextBox.Size = New System.Drawing.Size(167, 21)
        Me.QtyTextBox.TabIndex = 38
        '
        'Purchase_dateDateTimePicker
        '
        Me.Purchase_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Purchase1BindingSource, "Purchase_date", True))
        Me.Purchase_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Purchase_dateDateTimePicker.Location = New System.Drawing.Point(118, 205)
        Me.Purchase_dateDateTimePicker.Name = "Purchase_dateDateTimePicker"
        Me.Purchase_dateDateTimePicker.Size = New System.Drawing.Size(167, 21)
        Me.Purchase_dateDateTimePicker.TabIndex = 36
        Me.Purchase_dateDateTimePicker.Value = New Date(2016, 11, 1, 0, 0, 0, 0)
        '
        'Product_nameTextBox
        '
        Me.Product_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Purchase1BindingSource, "Product_name", True))
        Me.Product_nameTextBox.Location = New System.Drawing.Point(118, 164)
        Me.Product_nameTextBox.Name = "Product_nameTextBox"
        Me.Product_nameTextBox.Size = New System.Drawing.Size(167, 21)
        Me.Product_nameTextBox.TabIndex = 34
        '
        'Supplier_idTextBox
        '
        Me.Supplier_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Purchase1BindingSource, "Supplier_id", True))
        Me.Supplier_idTextBox.Location = New System.Drawing.Point(118, 123)
        Me.Supplier_idTextBox.Name = "Supplier_idTextBox"
        Me.Supplier_idTextBox.Size = New System.Drawing.Size(167, 21)
        Me.Supplier_idTextBox.TabIndex = 32
        '
        'Product_idTextBox
        '
        Me.Product_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Purchase1BindingSource, "Product_id", True))
        Me.Product_idTextBox.Location = New System.Drawing.Point(118, 83)
        Me.Product_idTextBox.Name = "Product_idTextBox"
        Me.Product_idTextBox.Size = New System.Drawing.Size(167, 21)
        Me.Product_idTextBox.TabIndex = 30
        '
        'S_noTextBox
        '
        Me.S_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Purchase1BindingSource, "S_no", True))
        Me.S_noTextBox.Location = New System.Drawing.Point(118, 42)
        Me.S_noTextBox.Name = "S_noTextBox"
        Me.S_noTextBox.Size = New System.Drawing.Size(167, 21)
        Me.S_noTextBox.TabIndex = 28
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(888, 243)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 27)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "CLOSE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Purchase1BindingNavigator
        '
        Me.Purchase1BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Purchase1BindingNavigator.BindingSource = Me.Purchase1BindingSource
        Me.Purchase1BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Purchase1BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Purchase1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Purchase1BindingNavigatorSaveItem})
        Me.Purchase1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Purchase1BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Purchase1BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Purchase1BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Purchase1BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Purchase1BindingNavigator.Name = "Purchase1BindingNavigator"
        Me.Purchase1BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Purchase1BindingNavigator.Size = New System.Drawing.Size(1012, 25)
        Me.Purchase1BindingNavigator.TabIndex = 50
        Me.Purchase1BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Purchase1BindingNavigatorSaveItem
        '
        Me.Purchase1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Purchase1BindingNavigatorSaveItem.Image = CType(resources.GetObject("Purchase1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Purchase1BindingNavigatorSaveItem.Name = "Purchase1BindingNavigatorSaveItem"
        Me.Purchase1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Purchase1BindingNavigatorSaveItem.Text = "Save Data"
        '
        'Purchase1TableAdapter
        '
        Me.Purchase1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.employee_profileTableAdapter = Nothing
        Me.TableAdapterManager.owner_profileTableAdapter = Nothing
        Me.TableAdapterManager.purchase1TableAdapter = Me.Purchase1TableAdapter
        Me.TableAdapterManager.salesTableAdapter = Nothing
        Me.TableAdapterManager.supplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Medical_._Medical_dbDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Purchase1DataGridView
        '
        Me.Purchase1DataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Purchase1DataGridView.AutoGenerateColumns = False
        Me.Purchase1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Purchase1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.Purchase1DataGridView.DataSource = Me.Purchase1BindingSource
        Me.Purchase1DataGridView.Location = New System.Drawing.Point(22, 287)
        Me.Purchase1DataGridView.Name = "Purchase1DataGridView"
        Me.Purchase1DataGridView.Size = New System.Drawing.Size(971, 269)
        Me.Purchase1DataGridView.TabIndex = 53
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "S_no"
        Me.DataGridViewTextBoxColumn1.HeaderText = "S_no"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Product_id"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Product_id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Supplier_id"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Supplier_id"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Product_name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Product_name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Purchase_date"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Purchase_date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Qty"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Price_qty"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Price_qty"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Alert_qty"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Alert_qty"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Mfg"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Mfg"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Exp"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Exp"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Total_price"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Total_price"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'Purchase9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1012, 568)
        Me.Controls.Add(Me.Purchase1DataGridView)
        Me.Controls.Add(Me.Purchase1BindingNavigator)
        Me.Controls.Add(S_noLabel)
        Me.Controls.Add(Me.ExpDateTimePicker)
        Me.Controls.Add(Me.MfgDateTimePicker)
        Me.Controls.Add(Me.Total_priceTextBox)
        Me.Controls.Add(Me.Alert_qtyTextBox)
        Me.Controls.Add(Me.Price_qtyTextBox)
        Me.Controls.Add(Me.QtyTextBox)
        Me.Controls.Add(Me.Purchase_dateDateTimePicker)
        Me.Controls.Add(Me.Product_nameTextBox)
        Me.Controls.Add(Me.Supplier_idTextBox)
        Me.Controls.Add(Me.Product_idTextBox)
        Me.Controls.Add(Me.S_noTextBox)
        Me.Controls.Add(Total_priceLabel)
        Me.Controls.Add(MfgLabel)
        Me.Controls.Add(ExpLabel)
        Me.Controls.Add(Alert_qtyLabel)
        Me.Controls.Add(Price_qtyLabel)
        Me.Controls.Add(QtyLabel)
        Me.Controls.Add(Purchase_dateLabel)
        Me.Controls.Add(Product_nameLabel)
        Me.Controls.Add(Supplier_idLabel)
        Me.Controls.Add(Product_idLabel)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1097, 729)
        Me.Name = "Purchase9"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Purchase. . ."
        CType(Me.Purchase1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Medical_dbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Purchase1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Purchase1BindingNavigator.ResumeLayout(False)
        Me.Purchase1BindingNavigator.PerformLayout()
        CType(Me.Purchase1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExpDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents MfgDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Total_priceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Alert_qtyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Price_qtyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QtyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Purchase_dateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Product_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Supplier_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Product_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents S_noTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents _Medical_dbDataSet1 As Medical_._Medical_dbDataSet1
    Friend WithEvents Purchase1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Purchase1TableAdapter As Medical_._Medical_dbDataSet1TableAdapters.purchase1TableAdapter
    Friend WithEvents TableAdapterManager As Medical_._Medical_dbDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Purchase1BindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Purchase1BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Purchase1DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

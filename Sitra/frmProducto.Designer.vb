<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdproductoLabel As System.Windows.Forms.Label
        Dim DescripcionprodLabel As System.Windows.Forms.Label
        Dim PrecioprodLabel As System.Windows.Forms.Label
        Dim IdcategoriaLabel As System.Windows.Forms.Label
        Dim IdproveedorLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProducto))
        Me._system2026_2002_2003_DataSet = New Sitra._system2026_2002_2003_DataSet()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New Sitra._system2026_2002_2003_DataSetTableAdapters.productoTableAdapter()
        Me.TableAdapterManager = New Sitra._system2026_2002_2003_DataSetTableAdapters.TableAdapterManager()
        Me.ProductoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ProductoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdproductoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionprodTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioprodTextBox = New System.Windows.Forms.TextBox()
        Me.IdcategoriaTextBox = New System.Windows.Forms.TextBox()
        Me.IdproveedorTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        IdproductoLabel = New System.Windows.Forms.Label()
        DescripcionprodLabel = New System.Windows.Forms.Label()
        PrecioprodLabel = New System.Windows.Forms.Label()
        IdcategoriaLabel = New System.Windows.Forms.Label()
        IdproveedorLabel = New System.Windows.Forms.Label()
        CType(Me._system2026_2002_2003_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductoBindingNavigator.SuspendLayout()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdproductoLabel
        '
        IdproductoLabel.AutoSize = True
        IdproductoLabel.Location = New System.Drawing.Point(193, 142)
        IdproductoLabel.Name = "IdproductoLabel"
        IdproductoLabel.Size = New System.Drawing.Size(61, 13)
        IdproductoLabel.TabIndex = 2
        IdproductoLabel.Text = "Idproducto:"
        '
        'DescripcionprodLabel
        '
        DescripcionprodLabel.AutoSize = True
        DescripcionprodLabel.Location = New System.Drawing.Point(193, 168)
        DescripcionprodLabel.Name = "DescripcionprodLabel"
        DescripcionprodLabel.Size = New System.Drawing.Size(85, 13)
        DescripcionprodLabel.TabIndex = 4
        DescripcionprodLabel.Text = "descripcionprod:"
        '
        'PrecioprodLabel
        '
        PrecioprodLabel.AutoSize = True
        PrecioprodLabel.Location = New System.Drawing.Point(193, 194)
        PrecioprodLabel.Name = "PrecioprodLabel"
        PrecioprodLabel.Size = New System.Drawing.Size(60, 13)
        PrecioprodLabel.TabIndex = 6
        PrecioprodLabel.Text = "precioprod:"
        '
        'IdcategoriaLabel
        '
        IdcategoriaLabel.AutoSize = True
        IdcategoriaLabel.Location = New System.Drawing.Point(193, 220)
        IdcategoriaLabel.Name = "IdcategoriaLabel"
        IdcategoriaLabel.Size = New System.Drawing.Size(63, 13)
        IdcategoriaLabel.TabIndex = 8
        IdcategoriaLabel.Text = "Idcategoria:"
        '
        'IdproveedorLabel
        '
        IdproveedorLabel.AutoSize = True
        IdproveedorLabel.Location = New System.Drawing.Point(193, 246)
        IdproveedorLabel.Name = "IdproveedorLabel"
        IdproveedorLabel.Size = New System.Drawing.Size(67, 13)
        IdproveedorLabel.TabIndex = 10
        IdproveedorLabel.Text = "Idproveedor:"
        '
        '_system2026_2002_2003_DataSet
        '
        Me._system2026_2002_2003_DataSet.DataSetName = "_system2026_2002_2003_DataSet"
        Me._system2026_2002_2003_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "producto"
        Me.ProductoBindingSource.DataSource = Me._system2026_2002_2003_DataSet
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoriaTableAdapter = Nothing
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.empleadoTableAdapter = Nothing
        Me.TableAdapterManager.facturaTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Me.ProductoTableAdapter
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sitra._system2026_2002_2003_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        Me.TableAdapterManager.ventaTableAdapter = Nothing
        '
        'ProductoBindingNavigator
        '
        Me.ProductoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProductoBindingNavigator.BindingSource = Me.ProductoBindingSource
        Me.ProductoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProductoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProductoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProductoBindingNavigatorSaveItem})
        Me.ProductoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProductoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProductoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProductoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductoBindingNavigator.Name = "ProductoBindingNavigator"
        Me.ProductoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProductoBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.ProductoBindingNavigator.TabIndex = 0
        Me.ProductoBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
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
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ProductoBindingNavigatorSaveItem
        '
        Me.ProductoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProductoBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductoBindingNavigatorSaveItem.Name = "ProductoBindingNavigatorSaveItem"
        Me.ProductoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProductoBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ProductoDataGridView
        '
        Me.ProductoDataGridView.AutoGenerateColumns = False
        Me.ProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ProductoDataGridView.DataSource = Me.ProductoBindingSource
        Me.ProductoDataGridView.Location = New System.Drawing.Point(143, 279)
        Me.ProductoDataGridView.Name = "ProductoDataGridView"
        Me.ProductoDataGridView.Size = New System.Drawing.Size(545, 165)
        Me.ProductoDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Idproducto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Idproducto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "descripcionprod"
        Me.DataGridViewTextBoxColumn2.HeaderText = "descripcionprod"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "precioprod"
        Me.DataGridViewTextBoxColumn3.HeaderText = "precioprod"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Idcategoria"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Idcategoria"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Idproveedor"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Idproveedor"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'IdproductoTextBox
        '
        Me.IdproductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Idproducto", True))
        Me.IdproductoTextBox.Location = New System.Drawing.Point(284, 139)
        Me.IdproductoTextBox.Name = "IdproductoTextBox"
        Me.IdproductoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdproductoTextBox.TabIndex = 3
        '
        'DescripcionprodTextBox
        '
        Me.DescripcionprodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "descripcionprod", True))
        Me.DescripcionprodTextBox.Location = New System.Drawing.Point(284, 165)
        Me.DescripcionprodTextBox.Name = "DescripcionprodTextBox"
        Me.DescripcionprodTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DescripcionprodTextBox.TabIndex = 5
        '
        'PrecioprodTextBox
        '
        Me.PrecioprodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "precioprod", True))
        Me.PrecioprodTextBox.Location = New System.Drawing.Point(284, 191)
        Me.PrecioprodTextBox.Name = "PrecioprodTextBox"
        Me.PrecioprodTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrecioprodTextBox.TabIndex = 7
        '
        'IdcategoriaTextBox
        '
        Me.IdcategoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Idcategoria", True))
        Me.IdcategoriaTextBox.Location = New System.Drawing.Point(284, 217)
        Me.IdcategoriaTextBox.Name = "IdcategoriaTextBox"
        Me.IdcategoriaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdcategoriaTextBox.TabIndex = 9
        '
        'IdproveedorTextBox
        '
        Me.IdproveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Idproveedor", True))
        Me.IdproveedorTextBox.Location = New System.Drawing.Point(284, 243)
        Me.IdproveedorTextBox.Name = "IdproveedorTextBox"
        Me.IdproveedorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdproveedorTextBox.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(277, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 37)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "tabla:producto"
        '
        'frmProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(800, 489)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(IdproductoLabel)
        Me.Controls.Add(Me.IdproductoTextBox)
        Me.Controls.Add(DescripcionprodLabel)
        Me.Controls.Add(Me.DescripcionprodTextBox)
        Me.Controls.Add(PrecioprodLabel)
        Me.Controls.Add(Me.PrecioprodTextBox)
        Me.Controls.Add(IdcategoriaLabel)
        Me.Controls.Add(Me.IdcategoriaTextBox)
        Me.Controls.Add(IdproveedorLabel)
        Me.Controls.Add(Me.IdproveedorTextBox)
        Me.Controls.Add(Me.ProductoDataGridView)
        Me.Controls.Add(Me.ProductoBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProducto"
        Me.Text = "Sistema de transporte systerre"
        CType(Me._system2026_2002_2003_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductoBindingNavigator.ResumeLayout(False)
        Me.ProductoBindingNavigator.PerformLayout()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _system2026_2002_2003_DataSet As _system2026_2002_2003_DataSet
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As _system2026_2002_2003_DataSetTableAdapters.productoTableAdapter
    Friend WithEvents TableAdapterManager As _system2026_2002_2003_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductoBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ProductoBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ProductoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents IdproductoTextBox As TextBox
    Friend WithEvents DescripcionprodTextBox As TextBox
    Friend WithEvents PrecioprodTextBox As TextBox
    Friend WithEvents IdcategoriaTextBox As TextBox
    Friend WithEvents IdproveedorTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class

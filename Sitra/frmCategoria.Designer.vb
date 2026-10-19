<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategoria
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
        Dim IdcategoriaLabel As System.Windows.Forms.Label
        Dim DescripcioncatLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCategoria))
        Me._system2026_2002_2003_DataSet = New Sitra._system2026_2002_2003_DataSet()
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriaTableAdapter = New Sitra._system2026_2002_2003_DataSetTableAdapters.categoriaTableAdapter()
        Me.TableAdapterManager = New Sitra._system2026_2002_2003_DataSetTableAdapters.TableAdapterManager()
        Me.CategoriaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CategoriaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdcategoriaTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcioncatTextBox = New System.Windows.Forms.TextBox()
        Me.CategoriaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        IdcategoriaLabel = New System.Windows.Forms.Label()
        DescripcioncatLabel = New System.Windows.Forms.Label()
        CType(Me._system2026_2002_2003_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CategoriaBindingNavigator.SuspendLayout()
        CType(Me.CategoriaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdcategoriaLabel
        '
        IdcategoriaLabel.AutoSize = True
        IdcategoriaLabel.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdcategoriaLabel.Location = New System.Drawing.Point(189, 149)
        IdcategoriaLabel.Name = "IdcategoriaLabel"
        IdcategoriaLabel.Size = New System.Drawing.Size(93, 16)
        IdcategoriaLabel.TabIndex = 1
        IdcategoriaLabel.Text = "Idcategoria:"
        AddHandler IdcategoriaLabel.Click, AddressOf Me.IdcategoriaLabel_Click
        '
        'DescripcioncatLabel
        '
        DescripcioncatLabel.AutoSize = True
        DescripcioncatLabel.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcioncatLabel.Location = New System.Drawing.Point(173, 182)
        DescripcioncatLabel.Name = "DescripcioncatLabel"
        DescripcioncatLabel.Size = New System.Drawing.Size(116, 16)
        DescripcioncatLabel.TabIndex = 3
        DescripcioncatLabel.Text = "descripcioncat:"
        '
        '_system2026_2002_2003_DataSet
        '
        Me._system2026_2002_2003_DataSet.DataSetName = "_system2026_2002_2003_DataSet"
        Me._system2026_2002_2003_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataMember = "categoria"
        Me.CategoriaBindingSource.DataSource = Me._system2026_2002_2003_DataSet
        '
        'CategoriaTableAdapter
        '
        Me.CategoriaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoriaTableAdapter = Me.CategoriaTableAdapter
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.empleadoTableAdapter = Nothing
        Me.TableAdapterManager.facturaTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sitra._system2026_2002_2003_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        Me.TableAdapterManager.ventaTableAdapter = Nothing
        '
        'CategoriaBindingNavigator
        '
        Me.CategoriaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CategoriaBindingNavigator.BindingSource = Me.CategoriaBindingSource
        Me.CategoriaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CategoriaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CategoriaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CategoriaBindingNavigatorSaveItem})
        Me.CategoriaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CategoriaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CategoriaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CategoriaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CategoriaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CategoriaBindingNavigator.Name = "CategoriaBindingNavigator"
        Me.CategoriaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CategoriaBindingNavigator.Size = New System.Drawing.Size(780, 25)
        Me.CategoriaBindingNavigator.TabIndex = 0
        Me.CategoriaBindingNavigator.Text = "BindingNavigator1"
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
        'CategoriaBindingNavigatorSaveItem
        '
        Me.CategoriaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CategoriaBindingNavigatorSaveItem.Image = CType(resources.GetObject("CategoriaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CategoriaBindingNavigatorSaveItem.Name = "CategoriaBindingNavigatorSaveItem"
        Me.CategoriaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CategoriaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdcategoriaTextBox
        '
        Me.IdcategoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriaBindingSource, "Idcategoria", True))
        Me.IdcategoriaTextBox.Location = New System.Drawing.Point(325, 149)
        Me.IdcategoriaTextBox.Name = "IdcategoriaTextBox"
        Me.IdcategoriaTextBox.Size = New System.Drawing.Size(132, 20)
        Me.IdcategoriaTextBox.TabIndex = 2
        '
        'DescripcioncatTextBox
        '
        Me.DescripcioncatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriaBindingSource, "descripcioncat", True))
        Me.DescripcioncatTextBox.Location = New System.Drawing.Point(325, 182)
        Me.DescripcioncatTextBox.Name = "DescripcioncatTextBox"
        Me.DescripcioncatTextBox.Size = New System.Drawing.Size(132, 20)
        Me.DescripcioncatTextBox.TabIndex = 4
        '
        'CategoriaDataGridView
        '
        Me.CategoriaDataGridView.AutoGenerateColumns = False
        Me.CategoriaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CategoriaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.CategoriaDataGridView.DataSource = Me.CategoriaBindingSource
        Me.CategoriaDataGridView.Location = New System.Drawing.Point(139, 219)
        Me.CategoriaDataGridView.Name = "CategoriaDataGridView"
        Me.CategoriaDataGridView.Size = New System.Drawing.Size(416, 154)
        Me.CategoriaDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Idcategoria"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Idcategoria"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "descripcioncat"
        Me.DataGridViewTextBoxColumn2.HeaderText = "descripcioncat"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(252, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 38)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "tabla:categoria"
        '
        'frmCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(780, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CategoriaDataGridView)
        Me.Controls.Add(IdcategoriaLabel)
        Me.Controls.Add(Me.IdcategoriaTextBox)
        Me.Controls.Add(DescripcioncatLabel)
        Me.Controls.Add(Me.DescripcioncatTextBox)
        Me.Controls.Add(Me.CategoriaBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCategoria"
        Me.Text = "Sistema de transporte systerre"
        CType(Me._system2026_2002_2003_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CategoriaBindingNavigator.ResumeLayout(False)
        Me.CategoriaBindingNavigator.PerformLayout()
        CType(Me.CategoriaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _system2026_2002_2003_DataSet As _system2026_2002_2003_DataSet
    Friend WithEvents CategoriaBindingSource As BindingSource
    Friend WithEvents CategoriaTableAdapter As _system2026_2002_2003_DataSetTableAdapters.categoriaTableAdapter
    Friend WithEvents TableAdapterManager As _system2026_2002_2003_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents CategoriaBindingNavigator As BindingNavigator
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
    Friend WithEvents CategoriaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdcategoriaTextBox As TextBox
    Friend WithEvents DescripcioncatTextBox As TextBox
    Friend WithEvents CategoriaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class

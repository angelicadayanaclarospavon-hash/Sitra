<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleado
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
        Dim IdempleadoLabel As System.Windows.Forms.Label
        Dim NombreempleadoLabel As System.Windows.Forms.Label
        Dim DireccionemplLabel As System.Windows.Forms.Label
        Dim TelefonoemplLabel As System.Windows.Forms.Label
        Dim EdademplLabel As System.Windows.Forms.Label
        Dim DNIemplLabel As System.Windows.Forms.Label
        Dim IdusuarioLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpleado))
        Me._system2026_2002_2003_DataSet = New Sitra._system2026_2002_2003_DataSet()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoTableAdapter = New Sitra._system2026_2002_2003_DataSetTableAdapters.empleadoTableAdapter()
        Me.TableAdapterManager = New Sitra._system2026_2002_2003_DataSetTableAdapters.TableAdapterManager()
        Me.EmpleadoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EmpleadoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.EmpleadoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdempleadoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreempleadoTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionemplTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoemplTextBox = New System.Windows.Forms.TextBox()
        Me.EdademplTextBox = New System.Windows.Forms.TextBox()
        Me.DNIemplTextBox = New System.Windows.Forms.TextBox()
        Me.IdusuarioTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        IdempleadoLabel = New System.Windows.Forms.Label()
        NombreempleadoLabel = New System.Windows.Forms.Label()
        DireccionemplLabel = New System.Windows.Forms.Label()
        TelefonoemplLabel = New System.Windows.Forms.Label()
        EdademplLabel = New System.Windows.Forms.Label()
        DNIemplLabel = New System.Windows.Forms.Label()
        IdusuarioLabel = New System.Windows.Forms.Label()
        CType(Me._system2026_2002_2003_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpleadoBindingNavigator.SuspendLayout()
        CType(Me.EmpleadoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdempleadoLabel
        '
        IdempleadoLabel.AutoSize = True
        IdempleadoLabel.Location = New System.Drawing.Point(118, 127)
        IdempleadoLabel.Name = "IdempleadoLabel"
        IdempleadoLabel.Size = New System.Drawing.Size(65, 13)
        IdempleadoLabel.TabIndex = 2
        IdempleadoLabel.Text = "Idempleado:"
        '
        'NombreempleadoLabel
        '
        NombreempleadoLabel.AutoSize = True
        NombreempleadoLabel.Location = New System.Drawing.Point(118, 153)
        NombreempleadoLabel.Name = "NombreempleadoLabel"
        NombreempleadoLabel.Size = New System.Drawing.Size(91, 13)
        NombreempleadoLabel.TabIndex = 4
        NombreempleadoLabel.Text = "nombreempleado:"
        '
        'DireccionemplLabel
        '
        DireccionemplLabel.AutoSize = True
        DireccionemplLabel.Location = New System.Drawing.Point(118, 179)
        DireccionemplLabel.Name = "DireccionemplLabel"
        DireccionemplLabel.Size = New System.Drawing.Size(75, 13)
        DireccionemplLabel.TabIndex = 6
        DireccionemplLabel.Text = "direccionempl:"
        '
        'TelefonoemplLabel
        '
        TelefonoemplLabel.AutoSize = True
        TelefonoemplLabel.Location = New System.Drawing.Point(118, 205)
        TelefonoemplLabel.Name = "TelefonoemplLabel"
        TelefonoemplLabel.Size = New System.Drawing.Size(70, 13)
        TelefonoemplLabel.TabIndex = 8
        TelefonoemplLabel.Text = "telefonoempl:"
        '
        'EdademplLabel
        '
        EdademplLabel.AutoSize = True
        EdademplLabel.Location = New System.Drawing.Point(381, 157)
        EdademplLabel.Name = "EdademplLabel"
        EdademplLabel.Size = New System.Drawing.Size(56, 13)
        EdademplLabel.TabIndex = 10
        EdademplLabel.Text = "edadempl:"
        '
        'DNIemplLabel
        '
        DNIemplLabel.AutoSize = True
        DNIemplLabel.Location = New System.Drawing.Point(381, 179)
        DNIemplLabel.Name = "DNIemplLabel"
        DNIemplLabel.Size = New System.Drawing.Size(51, 13)
        DNIemplLabel.TabIndex = 12
        DNIemplLabel.Text = "DNIempl:"
        '
        'IdusuarioLabel
        '
        IdusuarioLabel.AutoSize = True
        IdusuarioLabel.Location = New System.Drawing.Point(381, 205)
        IdusuarioLabel.Name = "IdusuarioLabel"
        IdusuarioLabel.Size = New System.Drawing.Size(52, 13)
        IdusuarioLabel.TabIndex = 14
        IdusuarioLabel.Text = "idusuario:"
        '
        '_system2026_2002_2003_DataSet
        '
        Me._system2026_2002_2003_DataSet.DataSetName = "_system2026_2002_2003_DataSet"
        Me._system2026_2002_2003_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "empleado"
        Me.EmpleadoBindingSource.DataSource = Me._system2026_2002_2003_DataSet
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoriaTableAdapter = Nothing
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.empleadoTableAdapter = Me.EmpleadoTableAdapter
        Me.TableAdapterManager.facturaTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sitra._system2026_2002_2003_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        Me.TableAdapterManager.ventaTableAdapter = Nothing
        '
        'EmpleadoBindingNavigator
        '
        Me.EmpleadoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmpleadoBindingNavigator.BindingSource = Me.EmpleadoBindingSource
        Me.EmpleadoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmpleadoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmpleadoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmpleadoBindingNavigatorSaveItem})
        Me.EmpleadoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmpleadoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmpleadoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmpleadoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmpleadoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmpleadoBindingNavigator.Name = "EmpleadoBindingNavigator"
        Me.EmpleadoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmpleadoBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.EmpleadoBindingNavigator.TabIndex = 0
        Me.EmpleadoBindingNavigator.Text = "BindingNavigator1"
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
        'EmpleadoBindingNavigatorSaveItem
        '
        Me.EmpleadoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmpleadoBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmpleadoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmpleadoBindingNavigatorSaveItem.Name = "EmpleadoBindingNavigatorSaveItem"
        Me.EmpleadoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EmpleadoBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'EmpleadoDataGridView
        '
        Me.EmpleadoDataGridView.AutoGenerateColumns = False
        Me.EmpleadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.EmpleadoDataGridView.DataSource = Me.EmpleadoBindingSource
        Me.EmpleadoDataGridView.Location = New System.Drawing.Point(121, 272)
        Me.EmpleadoDataGridView.Name = "EmpleadoDataGridView"
        Me.EmpleadoDataGridView.Size = New System.Drawing.Size(519, 130)
        Me.EmpleadoDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Idempleado"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Idempleado"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombreempleado"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombreempleado"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "direccionempl"
        Me.DataGridViewTextBoxColumn3.HeaderText = "direccionempl"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "telefonoempl"
        Me.DataGridViewTextBoxColumn4.HeaderText = "telefonoempl"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "edadempl"
        Me.DataGridViewTextBoxColumn5.HeaderText = "edadempl"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DNIempl"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DNIempl"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "idusuario"
        Me.DataGridViewTextBoxColumn7.HeaderText = "idusuario"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'IdempleadoTextBox
        '
        Me.IdempleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "Idempleado", True))
        Me.IdempleadoTextBox.Location = New System.Drawing.Point(215, 127)
        Me.IdempleadoTextBox.Name = "IdempleadoTextBox"
        Me.IdempleadoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdempleadoTextBox.TabIndex = 3
        '
        'NombreempleadoTextBox
        '
        Me.NombreempleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "nombreempleado", True))
        Me.NombreempleadoTextBox.Location = New System.Drawing.Point(215, 150)
        Me.NombreempleadoTextBox.Name = "NombreempleadoTextBox"
        Me.NombreempleadoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreempleadoTextBox.TabIndex = 5
        '
        'DireccionemplTextBox
        '
        Me.DireccionemplTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "direccionempl", True))
        Me.DireccionemplTextBox.Location = New System.Drawing.Point(215, 176)
        Me.DireccionemplTextBox.Name = "DireccionemplTextBox"
        Me.DireccionemplTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DireccionemplTextBox.TabIndex = 7
        '
        'TelefonoemplTextBox
        '
        Me.TelefonoemplTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "telefonoempl", True))
        Me.TelefonoemplTextBox.Location = New System.Drawing.Point(215, 202)
        Me.TelefonoemplTextBox.Name = "TelefonoemplTextBox"
        Me.TelefonoemplTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoemplTextBox.TabIndex = 9
        '
        'EdademplTextBox
        '
        Me.EdademplTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "edadempl", True))
        Me.EdademplTextBox.Location = New System.Drawing.Point(478, 150)
        Me.EdademplTextBox.Name = "EdademplTextBox"
        Me.EdademplTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EdademplTextBox.TabIndex = 11
        '
        'DNIemplTextBox
        '
        Me.DNIemplTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "DNIempl", True))
        Me.DNIemplTextBox.Location = New System.Drawing.Point(478, 176)
        Me.DNIemplTextBox.Name = "DNIemplTextBox"
        Me.DNIemplTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DNIemplTextBox.TabIndex = 13
        '
        'IdusuarioTextBox
        '
        Me.IdusuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "idusuario", True))
        Me.IdusuarioTextBox.Location = New System.Drawing.Point(478, 202)
        Me.IdusuarioTextBox.Name = "IdusuarioTextBox"
        Me.IdusuarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdusuarioTextBox.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(255, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 37)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "tabla:empleado"
        '
        'frmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(800, 511)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(IdempleadoLabel)
        Me.Controls.Add(Me.IdempleadoTextBox)
        Me.Controls.Add(NombreempleadoLabel)
        Me.Controls.Add(Me.NombreempleadoTextBox)
        Me.Controls.Add(DireccionemplLabel)
        Me.Controls.Add(Me.DireccionemplTextBox)
        Me.Controls.Add(TelefonoemplLabel)
        Me.Controls.Add(Me.TelefonoemplTextBox)
        Me.Controls.Add(EdademplLabel)
        Me.Controls.Add(Me.EdademplTextBox)
        Me.Controls.Add(DNIemplLabel)
        Me.Controls.Add(Me.DNIemplTextBox)
        Me.Controls.Add(IdusuarioLabel)
        Me.Controls.Add(Me.IdusuarioTextBox)
        Me.Controls.Add(Me.EmpleadoDataGridView)
        Me.Controls.Add(Me.EmpleadoBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEmpleado"
        Me.Text = "Sistema de transporte systerre"
        CType(Me._system2026_2002_2003_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpleadoBindingNavigator.ResumeLayout(False)
        Me.EmpleadoBindingNavigator.PerformLayout()
        CType(Me.EmpleadoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _system2026_2002_2003_DataSet As _system2026_2002_2003_DataSet
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents EmpleadoTableAdapter As _system2026_2002_2003_DataSetTableAdapters.empleadoTableAdapter
    Friend WithEvents TableAdapterManager As _system2026_2002_2003_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpleadoBindingNavigator As BindingNavigator
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
    Friend WithEvents EmpleadoBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents EmpleadoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents IdempleadoTextBox As TextBox
    Friend WithEvents NombreempleadoTextBox As TextBox
    Friend WithEvents DireccionemplTextBox As TextBox
    Friend WithEvents TelefonoemplTextBox As TextBox
    Friend WithEvents EdademplTextBox As TextBox
    Friend WithEvents DNIemplTextBox As TextBox
    Friend WithEvents IdusuarioTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class

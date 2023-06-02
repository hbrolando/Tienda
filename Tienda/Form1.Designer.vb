<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim CODIGO_CILabel As System.Windows.Forms.Label
        Dim NOMBRE_COMPLETOLabel As System.Windows.Forms.Label
        Dim APELLIDO_PATERNOLabel As System.Windows.Forms.Label
        Dim APELLIDO_MATERNOLabel As System.Windows.Forms.Label
        Dim FECHA_NACIMIENTOLabel As System.Windows.Forms.Label
        Dim CELULARLabel As System.Windows.Forms.Label
        Dim CORREOLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CLIENTESBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CLIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TIENDADataSet = New Tienda.TIENDADataSet()
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
        Me.CLIENTESBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CODIGO_CITextBox = New System.Windows.Forms.TextBox()
        Me.NOMBRE_COMPLETOTextBox = New System.Windows.Forms.TextBox()
        Me.APELLIDO_PATERNOTextBox = New System.Windows.Forms.TextBox()
        Me.APELLIDO_MATERNOTextBox = New System.Windows.Forms.TextBox()
        Me.FECHA_NACIMIENTODateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CELULARTextBox = New System.Windows.Forms.TextBox()
        Me.CORREOTextBox = New System.Windows.Forms.TextBox()
        Me.CLIENTESTableAdapter = New Tienda.TIENDADataSetTableAdapters.CLIENTESTableAdapter()
        Me.TableAdapterManager = New Tienda.TIENDADataSetTableAdapters.TableAdapterManager()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CODIGO_CILabel = New System.Windows.Forms.Label()
        NOMBRE_COMPLETOLabel = New System.Windows.Forms.Label()
        APELLIDO_PATERNOLabel = New System.Windows.Forms.Label()
        APELLIDO_MATERNOLabel = New System.Windows.Forms.Label()
        FECHA_NACIMIENTOLabel = New System.Windows.Forms.Label()
        CELULARLabel = New System.Windows.Forms.Label()
        CORREOLabel = New System.Windows.Forms.Label()
        CType(Me.CLIENTESBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CLIENTESBindingNavigator.SuspendLayout()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIENDADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CODIGO_CILabel
        '
        CODIGO_CILabel.AutoSize = True
        CODIGO_CILabel.Location = New System.Drawing.Point(9, 45)
        CODIGO_CILabel.Name = "CODIGO_CILabel"
        CODIGO_CILabel.Size = New System.Drawing.Size(65, 13)
        CODIGO_CILabel.TabIndex = 1
        CODIGO_CILabel.Text = "CODIGO CI:"
        '
        'NOMBRE_COMPLETOLabel
        '
        NOMBRE_COMPLETOLabel.AutoSize = True
        NOMBRE_COMPLETOLabel.Location = New System.Drawing.Point(9, 71)
        NOMBRE_COMPLETOLabel.Name = "NOMBRE_COMPLETOLabel"
        NOMBRE_COMPLETOLabel.Size = New System.Drawing.Size(119, 13)
        NOMBRE_COMPLETOLabel.TabIndex = 3
        NOMBRE_COMPLETOLabel.Text = "NOMBRE COMPLETO:"
        '
        'APELLIDO_PATERNOLabel
        '
        APELLIDO_PATERNOLabel.AutoSize = True
        APELLIDO_PATERNOLabel.Location = New System.Drawing.Point(9, 97)
        APELLIDO_PATERNOLabel.Name = "APELLIDO_PATERNOLabel"
        APELLIDO_PATERNOLabel.Size = New System.Drawing.Size(117, 13)
        APELLIDO_PATERNOLabel.TabIndex = 5
        APELLIDO_PATERNOLabel.Text = "APELLIDO PATERNO:"
        '
        'APELLIDO_MATERNOLabel
        '
        APELLIDO_MATERNOLabel.AutoSize = True
        APELLIDO_MATERNOLabel.Location = New System.Drawing.Point(9, 123)
        APELLIDO_MATERNOLabel.Name = "APELLIDO_MATERNOLabel"
        APELLIDO_MATERNOLabel.Size = New System.Drawing.Size(119, 13)
        APELLIDO_MATERNOLabel.TabIndex = 7
        APELLIDO_MATERNOLabel.Text = "APELLIDO MATERNO:"
        '
        'FECHA_NACIMIENTOLabel
        '
        FECHA_NACIMIENTOLabel.AutoSize = True
        FECHA_NACIMIENTOLabel.Location = New System.Drawing.Point(9, 150)
        FECHA_NACIMIENTOLabel.Name = "FECHA_NACIMIENTOLabel"
        FECHA_NACIMIENTOLabel.Size = New System.Drawing.Size(115, 13)
        FECHA_NACIMIENTOLabel.TabIndex = 9
        FECHA_NACIMIENTOLabel.Text = "FECHA NACIMIENTO:"
        '
        'CELULARLabel
        '
        CELULARLabel.AutoSize = True
        CELULARLabel.Location = New System.Drawing.Point(9, 175)
        CELULARLabel.Name = "CELULARLabel"
        CELULARLabel.Size = New System.Drawing.Size(59, 13)
        CELULARLabel.TabIndex = 11
        CELULARLabel.Text = "CELULAR:"
        '
        'CORREOLabel
        '
        CORREOLabel.AutoSize = True
        CORREOLabel.Location = New System.Drawing.Point(9, 201)
        CORREOLabel.Name = "CORREOLabel"
        CORREOLabel.Size = New System.Drawing.Size(56, 13)
        CORREOLabel.TabIndex = 13
        CORREOLabel.Text = "CORREO:"
        '
        'CLIENTESBindingNavigator
        '
        Me.CLIENTESBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CLIENTESBindingNavigator.BindingSource = Me.CLIENTESBindingSource
        Me.CLIENTESBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CLIENTESBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CLIENTESBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CLIENTESBindingNavigatorSaveItem})
        Me.CLIENTESBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CLIENTESBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CLIENTESBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CLIENTESBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CLIENTESBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CLIENTESBindingNavigator.Name = "CLIENTESBindingNavigator"
        Me.CLIENTESBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CLIENTESBindingNavigator.Size = New System.Drawing.Size(761, 25)
        Me.CLIENTESBindingNavigator.TabIndex = 0
        Me.CLIENTESBindingNavigator.Text = "BindingNavigator1"
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
        'CLIENTESBindingSource
        '
        Me.CLIENTESBindingSource.DataMember = "CLIENTES"
        Me.CLIENTESBindingSource.DataSource = Me.TIENDADataSet
        '
        'TIENDADataSet
        '
        Me.TIENDADataSet.DataSetName = "TIENDADataSet"
        Me.TIENDADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'CLIENTESBindingNavigatorSaveItem
        '
        Me.CLIENTESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CLIENTESBindingNavigatorSaveItem.Image = CType(resources.GetObject("CLIENTESBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CLIENTESBindingNavigatorSaveItem.Name = "CLIENTESBindingNavigatorSaveItem"
        Me.CLIENTESBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CLIENTESBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CODIGO_CITextBox
        '
        Me.CODIGO_CITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "CODIGO_CI", True))
        Me.CODIGO_CITextBox.Location = New System.Drawing.Point(134, 42)
        Me.CODIGO_CITextBox.Name = "CODIGO_CITextBox"
        Me.CODIGO_CITextBox.Size = New System.Drawing.Size(603, 20)
        Me.CODIGO_CITextBox.TabIndex = 2
        '
        'NOMBRE_COMPLETOTextBox
        '
        Me.NOMBRE_COMPLETOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "NOMBRE_COMPLETO", True))
        Me.NOMBRE_COMPLETOTextBox.Location = New System.Drawing.Point(134, 68)
        Me.NOMBRE_COMPLETOTextBox.Name = "NOMBRE_COMPLETOTextBox"
        Me.NOMBRE_COMPLETOTextBox.Size = New System.Drawing.Size(603, 20)
        Me.NOMBRE_COMPLETOTextBox.TabIndex = 4
        '
        'APELLIDO_PATERNOTextBox
        '
        Me.APELLIDO_PATERNOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "APELLIDO_PATERNO", True))
        Me.APELLIDO_PATERNOTextBox.Location = New System.Drawing.Point(134, 94)
        Me.APELLIDO_PATERNOTextBox.Name = "APELLIDO_PATERNOTextBox"
        Me.APELLIDO_PATERNOTextBox.Size = New System.Drawing.Size(603, 20)
        Me.APELLIDO_PATERNOTextBox.TabIndex = 6
        '
        'APELLIDO_MATERNOTextBox
        '
        Me.APELLIDO_MATERNOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "APELLIDO_MATERNO", True))
        Me.APELLIDO_MATERNOTextBox.Location = New System.Drawing.Point(134, 120)
        Me.APELLIDO_MATERNOTextBox.Name = "APELLIDO_MATERNOTextBox"
        Me.APELLIDO_MATERNOTextBox.Size = New System.Drawing.Size(603, 20)
        Me.APELLIDO_MATERNOTextBox.TabIndex = 8
        '
        'FECHA_NACIMIENTODateTimePicker
        '
        Me.FECHA_NACIMIENTODateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CLIENTESBindingSource, "FECHA_NACIMIENTO", True))
        Me.FECHA_NACIMIENTODateTimePicker.Location = New System.Drawing.Point(134, 146)
        Me.FECHA_NACIMIENTODateTimePicker.Name = "FECHA_NACIMIENTODateTimePicker"
        Me.FECHA_NACIMIENTODateTimePicker.Size = New System.Drawing.Size(603, 20)
        Me.FECHA_NACIMIENTODateTimePicker.TabIndex = 10
        '
        'CELULARTextBox
        '
        Me.CELULARTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "CELULAR", True))
        Me.CELULARTextBox.Location = New System.Drawing.Point(134, 172)
        Me.CELULARTextBox.Name = "CELULARTextBox"
        Me.CELULARTextBox.Size = New System.Drawing.Size(603, 20)
        Me.CELULARTextBox.TabIndex = 12
        '
        'CORREOTextBox
        '
        Me.CORREOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "CORREO", True))
        Me.CORREOTextBox.Location = New System.Drawing.Point(134, 198)
        Me.CORREOTextBox.Name = "CORREOTextBox"
        Me.CORREOTextBox.Size = New System.Drawing.Size(603, 20)
        Me.CORREOTextBox.TabIndex = 14
        '
        'CLIENTESTableAdapter
        '
        Me.CLIENTESTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLIENTESTableAdapter = Me.CLIENTESTableAdapter
        Me.TableAdapterManager.UpdateOrder = Tienda.TIENDADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 259)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(725, 176)
        Me.DataGridView1.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(761, 458)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(CODIGO_CILabel)
        Me.Controls.Add(Me.CODIGO_CITextBox)
        Me.Controls.Add(NOMBRE_COMPLETOLabel)
        Me.Controls.Add(Me.NOMBRE_COMPLETOTextBox)
        Me.Controls.Add(APELLIDO_PATERNOLabel)
        Me.Controls.Add(Me.APELLIDO_PATERNOTextBox)
        Me.Controls.Add(APELLIDO_MATERNOLabel)
        Me.Controls.Add(Me.APELLIDO_MATERNOTextBox)
        Me.Controls.Add(FECHA_NACIMIENTOLabel)
        Me.Controls.Add(Me.FECHA_NACIMIENTODateTimePicker)
        Me.Controls.Add(CELULARLabel)
        Me.Controls.Add(Me.CELULARTextBox)
        Me.Controls.Add(CORREOLabel)
        Me.Controls.Add(Me.CORREOTextBox)
        Me.Controls.Add(Me.CLIENTESBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TIENDA"
        CType(Me.CLIENTESBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CLIENTESBindingNavigator.ResumeLayout(False)
        Me.CLIENTESBindingNavigator.PerformLayout()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIENDADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TIENDADataSet As Tienda.TIENDADataSet
    Friend WithEvents CLIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CLIENTESTableAdapter As Tienda.TIENDADataSetTableAdapters.CLIENTESTableAdapter
    Friend WithEvents TableAdapterManager As Tienda.TIENDADataSetTableAdapters.TableAdapterManager
    Friend WithEvents CLIENTESBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents CLIENTESBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CODIGO_CITextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRE_COMPLETOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents APELLIDO_PATERNOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents APELLIDO_MATERNOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FECHA_NACIMIENTODateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CELULARTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CORREOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

End Class

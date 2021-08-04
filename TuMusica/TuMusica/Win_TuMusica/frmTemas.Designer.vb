Imports TuMusica.BL_TuMusica

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemas
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
        Dim IdArtistaLabel As System.Windows.Forms.Label
        Dim IdAlbumLabel As System.Windows.Forms.Label
        Dim NumeroTemaLabel As System.Windows.Forms.Label
        Dim TemaLabel As System.Windows.Forms.Label
        Dim DuracionLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTemas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ListaTemasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListaTemasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.DuracionTextBox = New System.Windows.Forms.TextBox()
        Me.TemaTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroTemaTextBox = New System.Windows.Forms.TextBox()
        Me.IdAlbumComboBox = New System.Windows.Forms.ComboBox()
        Me.ListaAlbunesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdArtistaComboBox = New System.Windows.Forms.ComboBox()
        Me.ListaArtistasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaTemasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ListaTemasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdArtistaLabel = New System.Windows.Forms.Label()
        IdAlbumLabel = New System.Windows.Forms.Label()
        NumeroTemaLabel = New System.Windows.Forms.Label()
        TemaLabel = New System.Windows.Forms.Label()
        DuracionLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.ListaTemasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaTemasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaAlbunesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaArtistasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaTemasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ListaTemasBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdArtistaLabel
        '
        IdArtistaLabel.AutoSize = True
        IdArtistaLabel.ForeColor = System.Drawing.Color.DimGray
        IdArtistaLabel.Location = New System.Drawing.Point(88, 60)
        IdArtistaLabel.Name = "IdArtistaLabel"
        IdArtistaLabel.Size = New System.Drawing.Size(51, 13)
        IdArtistaLabel.TabIndex = 3
        IdArtistaLabel.Text = "Id Artista:"
        '
        'IdAlbumLabel
        '
        IdAlbumLabel.AutoSize = True
        IdAlbumLabel.ForeColor = System.Drawing.Color.DimGray
        IdAlbumLabel.Location = New System.Drawing.Point(287, 60)
        IdAlbumLabel.Name = "IdAlbumLabel"
        IdAlbumLabel.Size = New System.Drawing.Size(51, 13)
        IdAlbumLabel.TabIndex = 5
        IdAlbumLabel.Text = "Id Album:"
        '
        'NumeroTemaLabel
        '
        NumeroTemaLabel.AutoSize = True
        NumeroTemaLabel.ForeColor = System.Drawing.Color.DimGray
        NumeroTemaLabel.Location = New System.Drawing.Point(12, 60)
        NumeroTemaLabel.Name = "NumeroTemaLabel"
        NumeroTemaLabel.Size = New System.Drawing.Size(77, 13)
        NumeroTemaLabel.TabIndex = 7
        NumeroTemaLabel.Text = "Numero Tema:"
        '
        'TemaLabel
        '
        TemaLabel.AutoSize = True
        TemaLabel.ForeColor = System.Drawing.Color.DimGray
        TemaLabel.Location = New System.Drawing.Point(412, 61)
        TemaLabel.Name = "TemaLabel"
        TemaLabel.Size = New System.Drawing.Size(94, 13)
        TemaLabel.TabIndex = 9
        TemaLabel.Text = "Nombre del Tema:"
        '
        'DuracionLabel
        '
        DuracionLabel.AutoSize = True
        DuracionLabel.ForeColor = System.Drawing.Color.DimGray
        DuracionLabel.Location = New System.Drawing.Point(684, 61)
        DuracionLabel.Name = "DuracionLabel"
        DuracionLabel.Size = New System.Drawing.Size(53, 13)
        DuracionLabel.TabIndex = 11
        DuracionLabel.Text = "Duracion:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.ForeColor = System.Drawing.Color.DimGray
        IdLabel.Location = New System.Drawing.Point(12, 33)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 12
        IdLabel.Text = "Id:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(755, 5)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 435)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MediumPurple
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.btnCerrar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(5, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(750, 35)
        Me.Panel3.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.MediumPurple
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(2, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(29, 35)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Jokerman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.Label1.Location = New System.Drawing.Point(322, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(388, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Mantenimiento de Temas Musicales"
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(716, 2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(30, 30)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Pink
        Me.Panel4.Controls.Add(Me.ListaTemasDataGridView)
        Me.Panel4.Controls.Add(IdLabel)
        Me.Panel4.Controls.Add(Me.IdTextBox)
        Me.Panel4.Controls.Add(DuracionLabel)
        Me.Panel4.Controls.Add(Me.DuracionTextBox)
        Me.Panel4.Controls.Add(TemaLabel)
        Me.Panel4.Controls.Add(Me.TemaTextBox)
        Me.Panel4.Controls.Add(NumeroTemaLabel)
        Me.Panel4.Controls.Add(Me.NumeroTemaTextBox)
        Me.Panel4.Controls.Add(IdAlbumLabel)
        Me.Panel4.Controls.Add(Me.IdAlbumComboBox)
        Me.Panel4.Controls.Add(IdArtistaLabel)
        Me.Panel4.Controls.Add(Me.IdArtistaComboBox)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(5, 40)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(750, 400)
        Me.Panel4.TabIndex = 3
        '
        'ListaTemasDataGridView
        '
        Me.ListaTemasDataGridView.AutoGenerateColumns = False
        Me.ListaTemasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListaTemasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.ListaTemasDataGridView.DataSource = Me.ListaTemasBindingSource
        Me.ListaTemasDataGridView.Location = New System.Drawing.Point(11, 103)
        Me.ListaTemasDataGridView.Name = "ListaTemasDataGridView"
        Me.ListaTemasDataGridView.Size = New System.Drawing.Size(726, 285)
        Me.ListaTemasDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NumeroTema"
        Me.DataGridViewTextBoxColumn6.HeaderText = "# Tema"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Cancion"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Nombre de Tema"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Duracion"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Duracion"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 60
        '
        'ListaTemasBindingSource
        '
        Me.ListaTemasBindingSource.DataSource = GetType(TuMusica.BL_TuMusica.Tema)
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaTemasBindingSource, "Id", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "00000"))
        Me.IdTextBox.Location = New System.Drawing.Point(37, 30)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(46, 20)
        Me.IdTextBox.TabIndex = 13
        '
        'DuracionTextBox
        '
        Me.DuracionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaTemasBindingSource, "Duracion", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "00:00"))
        Me.DuracionTextBox.Location = New System.Drawing.Point(681, 77)
        Me.DuracionTextBox.Name = "DuracionTextBox"
        Me.DuracionTextBox.Size = New System.Drawing.Size(56, 20)
        Me.DuracionTextBox.TabIndex = 4
        Me.DuracionTextBox.Text = "00:00"
        Me.DuracionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TemaTextBox
        '
        Me.TemaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaTemasBindingSource, "Cancion", True))
        Me.TemaTextBox.Location = New System.Drawing.Point(415, 77)
        Me.TemaTextBox.Name = "TemaTextBox"
        Me.TemaTextBox.Size = New System.Drawing.Size(262, 20)
        Me.TemaTextBox.TabIndex = 3
        '
        'NumeroTemaTextBox
        '
        Me.NumeroTemaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaTemasBindingSource, "NumeroTema", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "000"))
        Me.NumeroTemaTextBox.Location = New System.Drawing.Point(12, 77)
        Me.NumeroTemaTextBox.Name = "NumeroTemaTextBox"
        Me.NumeroTemaTextBox.Size = New System.Drawing.Size(75, 20)
        Me.NumeroTemaTextBox.TabIndex = 0
        '
        'IdAlbumComboBox
        '
        Me.IdAlbumComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaTemasBindingSource, "IdAlbum", True))
        Me.IdAlbumComboBox.DataSource = Me.ListaAlbunesBindingSource
        Me.IdAlbumComboBox.DisplayMember = "NombreAlbum"
        Me.IdAlbumComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdAlbumComboBox.FormattingEnabled = True
        Me.IdAlbumComboBox.Location = New System.Drawing.Point(290, 76)
        Me.IdAlbumComboBox.Name = "IdAlbumComboBox"
        Me.IdAlbumComboBox.Size = New System.Drawing.Size(121, 21)
        Me.IdAlbumComboBox.TabIndex = 2
        Me.IdAlbumComboBox.ValueMember = "Id"
        '
        'ListaAlbunesBindingSource
        '
        Me.ListaAlbunesBindingSource.DataSource = GetType(TuMusica.BL_TuMusica.Album)
        '
        'IdArtistaComboBox
        '
        Me.IdArtistaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaTemasBindingSource, "IdArtista", True))
        Me.IdArtistaComboBox.DataSource = Me.ListaArtistasBindingSource
        Me.IdArtistaComboBox.DisplayMember = "NombreArtista"
        Me.IdArtistaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdArtistaComboBox.FormattingEnabled = True
        Me.IdArtistaComboBox.Location = New System.Drawing.Point(89, 76)
        Me.IdArtistaComboBox.Name = "IdArtistaComboBox"
        Me.IdArtistaComboBox.Size = New System.Drawing.Size(196, 21)
        Me.IdArtistaComboBox.TabIndex = 1
        Me.IdArtistaComboBox.ValueMember = "Id"
        '
        'ListaArtistasBindingSource
        '
        Me.ListaArtistasBindingSource.DataSource = GetType(TuMusica.BL_TuMusica.Artistas)
        '
        'ListaTemasBindingNavigator
        '
        Me.ListaTemasBindingNavigator.AddNewItem = Nothing
        Me.ListaTemasBindingNavigator.BindingSource = Me.ListaTemasBindingSource
        Me.ListaTemasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ListaTemasBindingNavigator.DeleteItem = Nothing
        Me.ListaTemasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ListaTemasBindingNavigatorSaveItem, Me.ToolStripButtonCancelar})
        Me.ListaTemasBindingNavigator.Location = New System.Drawing.Point(5, 40)
        Me.ListaTemasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ListaTemasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ListaTemasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ListaTemasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ListaTemasBindingNavigator.Name = "ListaTemasBindingNavigator"
        Me.ListaTemasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ListaTemasBindingNavigator.Size = New System.Drawing.Size(750, 25)
        Me.ListaTemasBindingNavigator.TabIndex = 5
        Me.ListaTemasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
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
        'ListaTemasBindingNavigatorSaveItem
        '
        Me.ListaTemasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ListaTemasBindingNavigatorSaveItem.Image = CType(resources.GetObject("ListaTemasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ListaTemasBindingNavigatorSaveItem.Name = "ListaTemasBindingNavigatorSaveItem"
        Me.ListaTemasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ListaTemasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ToolStripButtonCancelar
        '
        Me.ToolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonCancelar.Image = CType(resources.GetObject("ToolStripButtonCancelar.Image"), System.Drawing.Image)
        Me.ToolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonCancelar.Name = "ToolStripButtonCancelar"
        Me.ToolStripButtonCancelar.Size = New System.Drawing.Size(57, 22)
        Me.ToolStripButtonCancelar.Text = "Cancelar"
        Me.ToolStripButtonCancelar.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NombreAlbum"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre Album"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'frmTemas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(755, 440)
        Me.Controls.Add(Me.ListaTemasBindingNavigator)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(755, 440)
        Me.MinimumSize = New System.Drawing.Size(755, 440)
        Me.Name = "frmTemas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Artistas"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.ListaTemasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaTemasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaAlbunesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaArtistasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaTemasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ListaTemasBindingNavigator.ResumeLayout(False)
        Me.ListaTemasBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnCerrar As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ListaTemasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaTemasBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ListaTemasBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ListaArtistasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IdAlbumComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents IdArtistaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NumeroTemaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DuracionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TemaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButtonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ListaAlbunesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaTemasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

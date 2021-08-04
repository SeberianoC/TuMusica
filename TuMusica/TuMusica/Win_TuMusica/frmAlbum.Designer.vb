Imports TuMusica.BL_TuMusica
Imports TuMusica.BL_TuMusica.BL_Album

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlbum
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim IdArtistaLabel As System.Windows.Forms.Label
        Dim AlbumLabel As System.Windows.Forms.Label
        Dim PublicacionLabel As System.Windows.Forms.Label
        Dim GeneroLabel As System.Windows.Forms.Label
        Dim PistasLabel As System.Windows.Forms.Label
        Dim FotoLabel As System.Windows.Forms.Label
        Dim ExistenciaLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlbum))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnQuitarImagen = New System.Windows.Forms.Button()
        Me.btnAgregarImagen = New System.Windows.Forms.Button()
        Me.ListaArtistasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FotoPictureBox = New System.Windows.Forms.PictureBox()
        Me.PistasTextBox = New System.Windows.Forms.TextBox()
        Me.GeneroTextBox = New System.Windows.Forms.TextBox()
        Me.PublicacionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AlbumTextBox = New System.Windows.Forms.TextBox()
        Me.IdArtistaComboBox = New System.Windows.Forms.ComboBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.ListaAlbunesDataGridView = New System.Windows.Forms.DataGridView()
        Me.ListaAlbunesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ListaAlbunesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.OpenFileDialogImagen = New System.Windows.Forms.OpenFileDialog()
        Me.ListaAlbunesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrecioTextBox1 = New System.Windows.Forms.TextBox()
        Me.ExistenciaTextBox = New System.Windows.Forms.TextBox()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreAlbumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PistasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdLabel = New System.Windows.Forms.Label()
        IdArtistaLabel = New System.Windows.Forms.Label()
        AlbumLabel = New System.Windows.Forms.Label()
        PublicacionLabel = New System.Windows.Forms.Label()
        GeneroLabel = New System.Windows.Forms.Label()
        PistasLabel = New System.Windows.Forms.Label()
        FotoLabel = New System.Windows.Forms.Label()
        ExistenciaLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.ListaArtistasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaAlbunesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaAlbunesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ListaAlbunesBindingNavigator.SuspendLayout()
        CType(Me.ListaAlbunesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.ForeColor = System.Drawing.SystemColors.Info
        IdLabel.Location = New System.Drawing.Point(12, 35)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(22, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Id:"
        '
        'IdArtistaLabel
        '
        IdArtistaLabel.AutoSize = True
        IdArtistaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdArtistaLabel.ForeColor = System.Drawing.SystemColors.Info
        IdArtistaLabel.Location = New System.Drawing.Point(81, 35)
        IdArtistaLabel.Name = "IdArtistaLabel"
        IdArtistaLabel.Size = New System.Drawing.Size(62, 13)
        IdArtistaLabel.TabIndex = 3
        IdArtistaLabel.Text = "Id Artista:"
        '
        'AlbumLabel
        '
        AlbumLabel.AutoSize = True
        AlbumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AlbumLabel.ForeColor = System.Drawing.SystemColors.Info
        AlbumLabel.Location = New System.Drawing.Point(261, 35)
        AlbumLabel.Name = "AlbumLabel"
        AlbumLabel.Size = New System.Drawing.Size(45, 13)
        AlbumLabel.TabIndex = 5
        AlbumLabel.Text = "Album:"
        '
        'PublicacionLabel
        '
        PublicacionLabel.AutoSize = True
        PublicacionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PublicacionLabel.ForeColor = System.Drawing.SystemColors.Info
        PublicacionLabel.Location = New System.Drawing.Point(13, 75)
        PublicacionLabel.Name = "PublicacionLabel"
        PublicacionLabel.Size = New System.Drawing.Size(77, 13)
        PublicacionLabel.TabIndex = 7
        PublicacionLabel.Text = "Publicacion:"
        '
        'GeneroLabel
        '
        GeneroLabel.AutoSize = True
        GeneroLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GeneroLabel.ForeColor = System.Drawing.SystemColors.Info
        GeneroLabel.Location = New System.Drawing.Point(221, 75)
        GeneroLabel.Name = "GeneroLabel"
        GeneroLabel.Size = New System.Drawing.Size(52, 13)
        GeneroLabel.TabIndex = 9
        GeneroLabel.Text = "Genero:"
        '
        'PistasLabel
        '
        PistasLabel.AutoSize = True
        PistasLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PistasLabel.ForeColor = System.Drawing.SystemColors.Info
        PistasLabel.Location = New System.Drawing.Point(379, 75)
        PistasLabel.Name = "PistasLabel"
        PistasLabel.Size = New System.Drawing.Size(45, 13)
        PistasLabel.TabIndex = 11
        PistasLabel.Text = "Pistas:"
        '
        'FotoLabel
        '
        FotoLabel.AutoSize = True
        FotoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FotoLabel.ForeColor = System.Drawing.SystemColors.Info
        FotoLabel.Location = New System.Drawing.Point(467, 35)
        FotoLabel.Name = "FotoLabel"
        FotoLabel.Size = New System.Drawing.Size(36, 13)
        FotoLabel.TabIndex = 13
        FotoLabel.Text = "Foto:"
        '
        'ExistenciaLabel
        '
        ExistenciaLabel.AutoSize = True
        ExistenciaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ExistenciaLabel.ForeColor = System.Drawing.SystemColors.Info
        ExistenciaLabel.Location = New System.Drawing.Point(13, 114)
        ExistenciaLabel.Name = "ExistenciaLabel"
        ExistenciaLabel.Size = New System.Drawing.Size(69, 13)
        ExistenciaLabel.TabIndex = 15
        ExistenciaLabel.Text = "Existencia:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrecioLabel.ForeColor = System.Drawing.SystemColors.Info
        PrecioLabel.Location = New System.Drawing.Point(84, 114)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(47, 13)
        PrecioLabel.TabIndex = 17
        PrecioLabel.Text = "Precio:"
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
        Me.Panel3.BackColor = System.Drawing.Color.Indigo
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
        Me.PictureBox2.BackColor = System.Drawing.Color.Thistle
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
        Me.Label1.Location = New System.Drawing.Point(417, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Mantenimiento de Album"
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
        Me.Panel4.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Panel4.Controls.Add(Me.ExistenciaTextBox)
        Me.Panel4.Controls.Add(Me.PrecioTextBox1)
        Me.Panel4.Controls.Add(Me.btnQuitarImagen)
        Me.Panel4.Controls.Add(Me.btnAgregarImagen)
        Me.Panel4.Controls.Add(PrecioLabel)
        Me.Panel4.Controls.Add(ExistenciaLabel)
        Me.Panel4.Controls.Add(FotoLabel)
        Me.Panel4.Controls.Add(Me.FotoPictureBox)
        Me.Panel4.Controls.Add(PistasLabel)
        Me.Panel4.Controls.Add(Me.PistasTextBox)
        Me.Panel4.Controls.Add(GeneroLabel)
        Me.Panel4.Controls.Add(Me.GeneroTextBox)
        Me.Panel4.Controls.Add(PublicacionLabel)
        Me.Panel4.Controls.Add(Me.PublicacionDateTimePicker)
        Me.Panel4.Controls.Add(AlbumLabel)
        Me.Panel4.Controls.Add(Me.AlbumTextBox)
        Me.Panel4.Controls.Add(IdArtistaLabel)
        Me.Panel4.Controls.Add(Me.IdArtistaComboBox)
        Me.Panel4.Controls.Add(IdLabel)
        Me.Panel4.Controls.Add(Me.IdTextBox)
        Me.Panel4.Controls.Add(Me.ListaAlbunesDataGridView)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(5, 40)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(750, 400)
        Me.Panel4.TabIndex = 3
        '
        'btnQuitarImagen
        '
        Me.btnQuitarImagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarImagen.Location = New System.Drawing.Point(467, 91)
        Me.btnQuitarImagen.Name = "btnQuitarImagen"
        Me.btnQuitarImagen.Size = New System.Drawing.Size(36, 34)
        Me.btnQuitarImagen.TabIndex = 22
        Me.btnQuitarImagen.Text = "-"
        Me.btnQuitarImagen.UseVisualStyleBackColor = True
        '
        'btnAgregarImagen
        '
        Me.btnAgregarImagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarImagen.Location = New System.Drawing.Point(467, 52)
        Me.btnAgregarImagen.Name = "btnAgregarImagen"
        Me.btnAgregarImagen.Size = New System.Drawing.Size(36, 34)
        Me.btnAgregarImagen.TabIndex = 21
        Me.btnAgregarImagen.Text = "+"
        Me.btnAgregarImagen.UseVisualStyleBackColor = True
        '
        'ListaArtistasBindingSource
        '
        Me.ListaArtistasBindingSource.DataSource = GetType(TuMusica.BL_TuMusica.Artistas)
        '
        'FotoPictureBox
        '
        Me.FotoPictureBox.BackColor = System.Drawing.Color.SlateBlue
        Me.FotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FotoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ListaAlbunesBindingSource, "Foto", True))
        Me.FotoPictureBox.Location = New System.Drawing.Point(504, 35)
        Me.FotoPictureBox.Name = "FotoPictureBox"
        Me.FotoPictureBox.Size = New System.Drawing.Size(234, 182)
        Me.FotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FotoPictureBox.TabIndex = 14
        Me.FotoPictureBox.TabStop = False
        '
        'PistasTextBox
        '
        Me.PistasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaAlbunesBindingSource, "Precio", True))
        Me.PistasTextBox.Location = New System.Drawing.Point(382, 91)
        Me.PistasTextBox.Name = "PistasTextBox"
        Me.PistasTextBox.Size = New System.Drawing.Size(79, 20)
        Me.PistasTextBox.TabIndex = 12
        Me.PistasTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GeneroTextBox
        '
        Me.GeneroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaAlbunesBindingSource, "Genero", True))
        Me.GeneroTextBox.Location = New System.Drawing.Point(224, 91)
        Me.GeneroTextBox.Name = "GeneroTextBox"
        Me.GeneroTextBox.Size = New System.Drawing.Size(152, 20)
        Me.GeneroTextBox.TabIndex = 10
        '
        'PublicacionDateTimePicker
        '
        Me.PublicacionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaAlbunesBindingSource, "Publicacion", True))
        Me.PublicacionDateTimePicker.Location = New System.Drawing.Point(15, 91)
        Me.PublicacionDateTimePicker.Name = "PublicacionDateTimePicker"
        Me.PublicacionDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.PublicacionDateTimePicker.TabIndex = 8
        '
        'AlbumTextBox
        '
        Me.AlbumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaAlbunesBindingSource, "NombreAlbum", True))
        Me.AlbumTextBox.Location = New System.Drawing.Point(264, 52)
        Me.AlbumTextBox.Name = "AlbumTextBox"
        Me.AlbumTextBox.Size = New System.Drawing.Size(197, 20)
        Me.AlbumTextBox.TabIndex = 6
        '
        'IdArtistaComboBox
        '
        Me.IdArtistaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaAlbunesBindingSource, "IdArtista", True))
        Me.IdArtistaComboBox.DataSource = Me.ListaArtistasBindingSource
        Me.IdArtistaComboBox.DisplayMember = "NombreArtista"
        Me.IdArtistaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdArtistaComboBox.FormattingEnabled = True
        Me.IdArtistaComboBox.Location = New System.Drawing.Point(84, 51)
        Me.IdArtistaComboBox.Name = "IdArtistaComboBox"
        Me.IdArtistaComboBox.Size = New System.Drawing.Size(171, 21)
        Me.IdArtistaComboBox.TabIndex = 4
        Me.IdArtistaComboBox.ValueMember = "Id"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaAlbunesBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(15, 51)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(63, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'ListaAlbunesDataGridView
        '
        Me.ListaAlbunesDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Purple
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ListaAlbunesDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.ListaAlbunesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListaAlbunesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NombreAlbumDataGridViewTextBoxColumn, Me.PistasDataGridViewTextBoxColumn, Me.ExistenciaDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn})
        Me.ListaAlbunesDataGridView.DataSource = Me.ListaAlbunesBindingSource
        Me.ListaAlbunesDataGridView.Location = New System.Drawing.Point(5, 223)
        Me.ListaAlbunesDataGridView.Name = "ListaAlbunesDataGridView"
        Me.ListaAlbunesDataGridView.Size = New System.Drawing.Size(739, 172)
        Me.ListaAlbunesDataGridView.TabIndex = 0
        '
        'ListaAlbunesBindingNavigator
        '
        Me.ListaAlbunesBindingNavigator.AddNewItem = Nothing
        Me.ListaAlbunesBindingNavigator.BindingSource = Me.ListaAlbunesBindingSource
        Me.ListaAlbunesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ListaAlbunesBindingNavigator.DeleteItem = Nothing
        Me.ListaAlbunesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ListaAlbunesBindingNavigatorSaveItem, Me.ToolStripButtonCancelar})
        Me.ListaAlbunesBindingNavigator.Location = New System.Drawing.Point(5, 40)
        Me.ListaAlbunesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ListaAlbunesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ListaAlbunesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ListaAlbunesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ListaAlbunesBindingNavigator.Name = "ListaAlbunesBindingNavigator"
        Me.ListaAlbunesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ListaAlbunesBindingNavigator.Size = New System.Drawing.Size(750, 25)
        Me.ListaAlbunesBindingNavigator.TabIndex = 4
        Me.ListaAlbunesBindingNavigator.Text = "BindingNavigator1"
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
        'ListaAlbunesBindingNavigatorSaveItem
        '
        Me.ListaAlbunesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ListaAlbunesBindingNavigatorSaveItem.Image = CType(resources.GetObject("ListaAlbunesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ListaAlbunesBindingNavigatorSaveItem.Name = "ListaAlbunesBindingNavigatorSaveItem"
        Me.ListaAlbunesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ListaAlbunesBindingNavigatorSaveItem.Text = "Guardar datos"
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
        'OpenFileDialogImagen
        '
        Me.OpenFileDialogImagen.FileName = "OpenFileDialog1"
        Me.OpenFileDialogImagen.Filter = "(Image Files)|*.jpg;*.png;*.bmp"
        '
        'ListaAlbunesBindingSource
        '
        Me.ListaAlbunesBindingSource.DataSource = GetType(Album)
        '
        'PrecioTextBox1
        '
        Me.PrecioTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaAlbunesBindingSource, "Precio", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.PrecioTextBox1.Location = New System.Drawing.Point(87, 130)
        Me.PrecioTextBox1.Name = "PrecioTextBox1"
        Me.PrecioTextBox1.Size = New System.Drawing.Size(78, 20)
        Me.PrecioTextBox1.TabIndex = 23
        '
        'ExistenciaTextBox
        '
        Me.ExistenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaAlbunesBindingSource, "Existencia", True))
        Me.ExistenciaTextBox.Location = New System.Drawing.Point(15, 130)
        Me.ExistenciaTextBox.Name = "ExistenciaTextBox"
        Me.ExistenciaTextBox.Size = New System.Drawing.Size(66, 20)
        Me.ExistenciaTextBox.TabIndex = 24
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'NombreAlbumDataGridViewTextBoxColumn
        '
        Me.NombreAlbumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreAlbumDataGridViewTextBoxColumn.DataPropertyName = "NombreAlbum"
        Me.NombreAlbumDataGridViewTextBoxColumn.HeaderText = "NombreAlbum"
        Me.NombreAlbumDataGridViewTextBoxColumn.Name = "NombreAlbumDataGridViewTextBoxColumn"
        '
        'PistasDataGridViewTextBoxColumn
        '
        Me.PistasDataGridViewTextBoxColumn.DataPropertyName = "Pistas"
        Me.PistasDataGridViewTextBoxColumn.HeaderText = "Pistas"
        Me.PistasDataGridViewTextBoxColumn.Name = "PistasDataGridViewTextBoxColumn"
        '
        'ExistenciaDataGridViewTextBoxColumn
        '
        Me.ExistenciaDataGridViewTextBoxColumn.DataPropertyName = "Existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.HeaderText = "Existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.Name = "ExistenciaDataGridViewTextBoxColumn"
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        '
        'frmAlbum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(755, 440)
        Me.Controls.Add(Me.ListaAlbunesBindingNavigator)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(755, 440)
        Me.MinimumSize = New System.Drawing.Size(755, 440)
        Me.Name = "frmAlbum"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Artistas"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.ListaArtistasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaAlbunesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaAlbunesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ListaAlbunesBindingNavigator.ResumeLayout(False)
        Me.ListaAlbunesBindingNavigator.PerformLayout()
        CType(Me.ListaAlbunesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ListaAlbunesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ListaAlbunesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ListaAlbunesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FotoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents PistasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GeneroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PublicacionDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AlbumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdArtistaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ListaArtistasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnQuitarImagen As System.Windows.Forms.Button
    Friend WithEvents btnAgregarImagen As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialogImagen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolStripButtonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ListaAlbunesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ExistenciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreAlbumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PistasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

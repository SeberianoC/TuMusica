Imports TuMusica.BL_TuMusica

Namespace Win_TuMusica
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmArtistas
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
            Dim NombreArtistaLabel As System.Windows.Forms.Label
            Dim NombreNaciemientoLabel As System.Windows.Forms.Label
            Dim OtrosNombresLabel As System.Windows.Forms.Label
            Dim NacionalidadLabel As System.Windows.Forms.Label
            Dim GeneroLabel As System.Windows.Forms.Label
            Dim DiscografiaLabel As System.Windows.Forms.Label
            Dim MiembrosLabel As System.Windows.Forms.Label
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArtistas))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.PictureBox2 = New System.Windows.Forms.PictureBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.btnCerrar = New System.Windows.Forms.PictureBox()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.FotoPictureBox = New System.Windows.Forms.PictureBox()
            Me.ListaArtistasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.btnQuitarImagen = New System.Windows.Forms.Button()
            Me.btnAgregarImagen = New System.Windows.Forms.Button()
            Me.IdPaisComboBox = New System.Windows.Forms.ComboBox()
            Me.ListaPaisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.MiembrosTextBox = New System.Windows.Forms.TextBox()
            Me.DiscografiaTextBox = New System.Windows.Forms.TextBox()
            Me.GeneroTextBox = New System.Windows.Forms.TextBox()
            Me.OtrosNombresTextBox = New System.Windows.Forms.TextBox()
            Me.NombreNaciemientoTextBox = New System.Windows.Forms.TextBox()
            Me.NombreArtistaTextBox = New System.Windows.Forms.TextBox()
            Me.IdTextBox = New System.Windows.Forms.TextBox()
            Me.ListaArtistasDataGridView = New System.Windows.Forms.DataGridView()
            Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ListaArtistasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
            Me.ListaArtistasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripButtonCancelar = New System.Windows.Forms.ToolStripButton()
            Me.OpenFileDialogImagen = New System.Windows.Forms.OpenFileDialog()
            IdLabel = New System.Windows.Forms.Label()
            NombreArtistaLabel = New System.Windows.Forms.Label()
            NombreNaciemientoLabel = New System.Windows.Forms.Label()
            OtrosNombresLabel = New System.Windows.Forms.Label()
            NacionalidadLabel = New System.Windows.Forms.Label()
            GeneroLabel = New System.Windows.Forms.Label()
            DiscografiaLabel = New System.Windows.Forms.Label()
            MiembrosLabel = New System.Windows.Forms.Label()
            Me.Panel3.SuspendLayout()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel4.SuspendLayout()
            CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ListaArtistasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ListaPaisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ListaArtistasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ListaArtistasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ListaArtistasBindingNavigator.SuspendLayout()
            Me.SuspendLayout()
            '
            'IdLabel
            '
            IdLabel.AutoSize = True
            IdLabel.BackColor = System.Drawing.Color.SteelBlue
            IdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            IdLabel.ForeColor = System.Drawing.Color.Bisque
            IdLabel.Location = New System.Drawing.Point(7, 29)
            IdLabel.Name = "IdLabel"
            IdLabel.Size = New System.Drawing.Size(22, 13)
            IdLabel.TabIndex = 1
            IdLabel.Text = "Id:"
            '
            'NombreArtistaLabel
            '
            NombreArtistaLabel.AutoSize = True
            NombreArtistaLabel.BackColor = System.Drawing.Color.SteelBlue
            NombreArtistaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            NombreArtistaLabel.ForeColor = System.Drawing.Color.Bisque
            NombreArtistaLabel.Location = New System.Drawing.Point(54, 29)
            NombreArtistaLabel.Name = "NombreArtistaLabel"
            NombreArtistaLabel.Size = New System.Drawing.Size(94, 13)
            NombreArtistaLabel.TabIndex = 3
            NombreArtistaLabel.Text = "Nombre Artista:"
            '
            'NombreNaciemientoLabel
            '
            NombreNaciemientoLabel.AutoSize = True
            NombreNaciemientoLabel.BackColor = System.Drawing.Color.SteelBlue
            NombreNaciemientoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            NombreNaciemientoLabel.ForeColor = System.Drawing.Color.Bisque
            NombreNaciemientoLabel.Location = New System.Drawing.Point(317, 29)
            NombreNaciemientoLabel.Name = "NombreNaciemientoLabel"
            NombreNaciemientoLabel.Size = New System.Drawing.Size(128, 13)
            NombreNaciemientoLabel.TabIndex = 5
            NombreNaciemientoLabel.Text = "Nombre Naciemiento:"
            '
            'OtrosNombresLabel
            '
            OtrosNombresLabel.AutoSize = True
            OtrosNombresLabel.BackColor = System.Drawing.Color.SteelBlue
            OtrosNombresLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            OtrosNombresLabel.ForeColor = System.Drawing.Color.Bisque
            OtrosNombresLabel.Location = New System.Drawing.Point(8, 68)
            OtrosNombresLabel.Name = "OtrosNombresLabel"
            OtrosNombresLabel.Size = New System.Drawing.Size(94, 13)
            OtrosNombresLabel.TabIndex = 7
            OtrosNombresLabel.Text = "Otros Nombres:"
            '
            'NacionalidadLabel
            '
            NacionalidadLabel.AutoSize = True
            NacionalidadLabel.BackColor = System.Drawing.Color.SteelBlue
            NacionalidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            NacionalidadLabel.ForeColor = System.Drawing.Color.Bisque
            NacionalidadLabel.Location = New System.Drawing.Point(217, 68)
            NacionalidadLabel.Name = "NacionalidadLabel"
            NacionalidadLabel.Size = New System.Drawing.Size(85, 13)
            NacionalidadLabel.TabIndex = 9
            NacionalidadLabel.Text = "Nacionalidad:"
            '
            'GeneroLabel
            '
            GeneroLabel.AutoSize = True
            GeneroLabel.BackColor = System.Drawing.Color.SteelBlue
            GeneroLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            GeneroLabel.ForeColor = System.Drawing.Color.Bisque
            GeneroLabel.Location = New System.Drawing.Point(404, 67)
            GeneroLabel.Name = "GeneroLabel"
            GeneroLabel.Size = New System.Drawing.Size(99, 13)
            GeneroLabel.TabIndex = 11
            GeneroLabel.Text = "Genero Musical:"
            '
            'DiscografiaLabel
            '
            DiscografiaLabel.AutoSize = True
            DiscografiaLabel.BackColor = System.Drawing.Color.SteelBlue
            DiscografiaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DiscografiaLabel.ForeColor = System.Drawing.Color.Bisque
            DiscografiaLabel.Location = New System.Drawing.Point(8, 107)
            DiscografiaLabel.Name = "DiscografiaLabel"
            DiscografiaLabel.Size = New System.Drawing.Size(75, 13)
            DiscografiaLabel.TabIndex = 13
            DiscografiaLabel.Text = "Discografia:"
            '
            'MiembrosLabel
            '
            MiembrosLabel.AutoSize = True
            MiembrosLabel.BackColor = System.Drawing.Color.SteelBlue
            MiembrosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            MiembrosLabel.ForeColor = System.Drawing.Color.Bisque
            MiembrosLabel.Location = New System.Drawing.Point(288, 108)
            MiembrosLabel.Name = "MiembrosLabel"
            MiembrosLabel.Size = New System.Drawing.Size(64, 13)
            MiembrosLabel.TabIndex = 15
            MiembrosLabel.Text = "Miembros:"
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
            Me.Panel3.BackColor = System.Drawing.Color.CadetBlue
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
            Me.Label1.Size = New System.Drawing.Size(296, 29)
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "Mantenimiento de Artístas"
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
            Me.Panel4.BackColor = System.Drawing.Color.SteelBlue
            Me.Panel4.Controls.Add(Me.FotoPictureBox)
            Me.Panel4.Controls.Add(Me.btnQuitarImagen)
            Me.Panel4.Controls.Add(Me.btnAgregarImagen)
            Me.Panel4.Controls.Add(Me.IdPaisComboBox)
            Me.Panel4.Controls.Add(MiembrosLabel)
            Me.Panel4.Controls.Add(Me.MiembrosTextBox)
            Me.Panel4.Controls.Add(DiscografiaLabel)
            Me.Panel4.Controls.Add(Me.DiscografiaTextBox)
            Me.Panel4.Controls.Add(GeneroLabel)
            Me.Panel4.Controls.Add(Me.GeneroTextBox)
            Me.Panel4.Controls.Add(NacionalidadLabel)
            Me.Panel4.Controls.Add(OtrosNombresLabel)
            Me.Panel4.Controls.Add(Me.OtrosNombresTextBox)
            Me.Panel4.Controls.Add(NombreNaciemientoLabel)
            Me.Panel4.Controls.Add(Me.NombreNaciemientoTextBox)
            Me.Panel4.Controls.Add(NombreArtistaLabel)
            Me.Panel4.Controls.Add(Me.NombreArtistaTextBox)
            Me.Panel4.Controls.Add(IdLabel)
            Me.Panel4.Controls.Add(Me.IdTextBox)
            Me.Panel4.Controls.Add(Me.ListaArtistasDataGridView)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel4.Location = New System.Drawing.Point(5, 40)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(750, 400)
            Me.Panel4.TabIndex = 3
            '
            'FotoPictureBox
            '
            Me.FotoPictureBox.BackColor = System.Drawing.Color.LightSkyBlue
            Me.FotoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ListaArtistasBindingSource, "Foto", True))
            Me.FotoPictureBox.Location = New System.Drawing.Point(536, 45)
            Me.FotoPictureBox.Name = "FotoPictureBox"
            Me.FotoPictureBox.Size = New System.Drawing.Size(165, 129)
            Me.FotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.FotoPictureBox.TabIndex = 21
            Me.FotoPictureBox.TabStop = False
            '
            'ListaArtistasBindingSource
            '
            Me.ListaArtistasBindingSource.DataSource = GetType(Artistas)
            '
            'btnQuitarImagen
            '
            Me.btnQuitarImagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnQuitarImagen.Location = New System.Drawing.Point(707, 84)
            Me.btnQuitarImagen.Name = "btnQuitarImagen"
            Me.btnQuitarImagen.Size = New System.Drawing.Size(36, 34)
            Me.btnQuitarImagen.TabIndex = 20
            Me.btnQuitarImagen.Text = "-"
            Me.btnQuitarImagen.UseVisualStyleBackColor = True
            '
            'btnAgregarImagen
            '
            Me.btnAgregarImagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregarImagen.Location = New System.Drawing.Point(707, 45)
            Me.btnAgregarImagen.Name = "btnAgregarImagen"
            Me.btnAgregarImagen.Size = New System.Drawing.Size(36, 34)
            Me.btnAgregarImagen.TabIndex = 19
            Me.btnAgregarImagen.Text = "+"
            Me.btnAgregarImagen.UseVisualStyleBackColor = True
            '
            'IdPaisComboBox
            '
            Me.IdPaisComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaArtistasBindingSource, "IdPais", True))
            Me.IdPaisComboBox.DataSource = Me.ListaPaisBindingSource
            Me.IdPaisComboBox.DisplayMember = "NombrePais"
            Me.IdPaisComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.IdPaisComboBox.FormattingEnabled = True
            Me.IdPaisComboBox.Location = New System.Drawing.Point(219, 84)
            Me.IdPaisComboBox.Name = "IdPaisComboBox"
            Me.IdPaisComboBox.Size = New System.Drawing.Size(182, 21)
            Me.IdPaisComboBox.TabIndex = 4
            Me.IdPaisComboBox.ValueMember = "Id"
            '
            'ListaPaisBindingSource
            '
            Me.ListaPaisBindingSource.DataSource = GetType(Pais)
            '
            'MiembrosTextBox
            '
            Me.MiembrosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaArtistasBindingSource, "Miembros", True))
            Me.MiembrosTextBox.Location = New System.Drawing.Point(291, 123)
            Me.MiembrosTextBox.Multiline = True
            Me.MiembrosTextBox.Name = "MiembrosTextBox"
            Me.MiembrosTextBox.Size = New System.Drawing.Size(239, 51)
            Me.MiembrosTextBox.TabIndex = 7
            '
            'DiscografiaTextBox
            '
            Me.DiscografiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaArtistasBindingSource, "Discografia", True))
            Me.DiscografiaTextBox.Location = New System.Drawing.Point(11, 122)
            Me.DiscografiaTextBox.Multiline = True
            Me.DiscografiaTextBox.Name = "DiscografiaTextBox"
            Me.DiscografiaTextBox.Size = New System.Drawing.Size(274, 52)
            Me.DiscografiaTextBox.TabIndex = 6
            '
            'GeneroTextBox
            '
            Me.GeneroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaArtistasBindingSource, "Genero", True))
            Me.GeneroTextBox.Location = New System.Drawing.Point(407, 84)
            Me.GeneroTextBox.Name = "GeneroTextBox"
            Me.GeneroTextBox.Size = New System.Drawing.Size(123, 20)
            Me.GeneroTextBox.TabIndex = 5
            '
            'OtrosNombresTextBox
            '
            Me.OtrosNombresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaArtistasBindingSource, "OtrosNombres", True))
            Me.OtrosNombresTextBox.Location = New System.Drawing.Point(11, 84)
            Me.OtrosNombresTextBox.Name = "OtrosNombresTextBox"
            Me.OtrosNombresTextBox.Size = New System.Drawing.Size(202, 20)
            Me.OtrosNombresTextBox.TabIndex = 3
            '
            'NombreNaciemientoTextBox
            '
            Me.NombreNaciemientoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaArtistasBindingSource, "NombreNaciemiento", True))
            Me.NombreNaciemientoTextBox.Location = New System.Drawing.Point(317, 45)
            Me.NombreNaciemientoTextBox.Name = "NombreNaciemientoTextBox"
            Me.NombreNaciemientoTextBox.Size = New System.Drawing.Size(213, 20)
            Me.NombreNaciemientoTextBox.TabIndex = 2
            '
            'NombreArtistaTextBox
            '
            Me.NombreArtistaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaArtistasBindingSource, "NombreArtista", True))
            Me.NombreArtistaTextBox.Location = New System.Drawing.Point(57, 45)
            Me.NombreArtistaTextBox.Name = "NombreArtistaTextBox"
            Me.NombreArtistaTextBox.Size = New System.Drawing.Size(254, 20)
            Me.NombreArtistaTextBox.TabIndex = 1
            '
            'IdTextBox
            '
            Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaArtistasBindingSource, "Id", True))
            Me.IdTextBox.Enabled = False
            Me.IdTextBox.Location = New System.Drawing.Point(10, 45)
            Me.IdTextBox.Name = "IdTextBox"
            Me.IdTextBox.Size = New System.Drawing.Size(38, 20)
            Me.IdTextBox.TabIndex = 0
            '
            'ListaArtistasDataGridView
            '
            Me.ListaArtistasDataGridView.AllowUserToAddRows = False
            Me.ListaArtistasDataGridView.AllowUserToDeleteRows = False
            Me.ListaArtistasDataGridView.AllowUserToResizeColumns = False
            Me.ListaArtistasDataGridView.AllowUserToResizeRows = False
            Me.ListaArtistasDataGridView.AutoGenerateColumns = False
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.ListaArtistasDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.ListaArtistasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.ListaArtistasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn8})
            Me.ListaArtistasDataGridView.DataSource = Me.ListaArtistasBindingSource
            Me.ListaArtistasDataGridView.Location = New System.Drawing.Point(6, 180)
            Me.ListaArtistasDataGridView.Name = "ListaArtistasDataGridView"
            Me.ListaArtistasDataGridView.Size = New System.Drawing.Size(737, 213)
            Me.ListaArtistasDataGridView.TabIndex = 0
            '
            'DataGridViewTextBoxColumn1
            '
            Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
            Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
            Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
            Me.DataGridViewTextBoxColumn1.Width = 50
            '
            'DataGridViewTextBoxColumn2
            '
            Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.DataGridViewTextBoxColumn2.DataPropertyName = "NombreArtista"
            Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre de Artista"
            Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
            '
            'DataGridViewTextBoxColumn4
            '
            Me.DataGridViewTextBoxColumn4.DataPropertyName = "OtrosNombres"
            Me.DataGridViewTextBoxColumn4.HeaderText = "OtrosNombres"
            Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
            '
            'DataGridViewTextBoxColumn8
            '
            Me.DataGridViewTextBoxColumn8.DataPropertyName = "Miembros"
            Me.DataGridViewTextBoxColumn8.HeaderText = "Miembros"
            Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
            '
            'ListaArtistasBindingNavigator
            '
            Me.ListaArtistasBindingNavigator.AddNewItem = Nothing
            Me.ListaArtistasBindingNavigator.BindingSource = Me.ListaArtistasBindingSource
            Me.ListaArtistasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
            Me.ListaArtistasBindingNavigator.DeleteItem = Nothing
            Me.ListaArtistasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ListaArtistasBindingNavigatorSaveItem, Me.ToolStripButtonCancelar})
            Me.ListaArtistasBindingNavigator.Location = New System.Drawing.Point(5, 40)
            Me.ListaArtistasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
            Me.ListaArtistasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
            Me.ListaArtistasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
            Me.ListaArtistasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
            Me.ListaArtistasBindingNavigator.Name = "ListaArtistasBindingNavigator"
            Me.ListaArtistasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
            Me.ListaArtistasBindingNavigator.Size = New System.Drawing.Size(750, 25)
            Me.ListaArtistasBindingNavigator.TabIndex = 8
            Me.ListaArtistasBindingNavigator.Text = "BindingNavigator1"
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
            'ListaArtistasBindingNavigatorSaveItem
            '
            Me.ListaArtistasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ListaArtistasBindingNavigatorSaveItem.Image = CType(resources.GetObject("ListaArtistasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
            Me.ListaArtistasBindingNavigatorSaveItem.Name = "ListaArtistasBindingNavigatorSaveItem"
            Me.ListaArtistasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
            Me.ListaArtistasBindingNavigatorSaveItem.Text = "Guardar datos"
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
            Me.OpenFileDialogImagen.Filter = "(Image Files)|*.jpg;*.png;*.bmp"
            '
            'frmArtistas
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoScroll = True
            Me.ClientSize = New System.Drawing.Size(755, 440)
            Me.Controls.Add(Me.ListaArtistasBindingNavigator)
            Me.Controls.Add(Me.Panel4)
            Me.Controls.Add(Me.Panel3)
            Me.Controls.Add(Me.Panel2)
            Me.Controls.Add(Me.Panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.MaximumSize = New System.Drawing.Size(755, 440)
            Me.MinimumSize = New System.Drawing.Size(755, 440)
            Me.Name = "frmArtistas"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Mantenimiento de Artistas"
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel4.ResumeLayout(False)
            Me.Panel4.PerformLayout()
            CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ListaArtistasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ListaPaisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ListaArtistasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ListaArtistasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ListaArtistasBindingNavigator.ResumeLayout(False)
            Me.ListaArtistasBindingNavigator.PerformLayout()
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
        Friend WithEvents ListaArtistasDataGridView As System.Windows.Forms.DataGridView
        Friend WithEvents ListaArtistasBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents ListaArtistasBindingNavigator As System.Windows.Forms.BindingNavigator
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
        Friend WithEvents ListaArtistasBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
        Friend WithEvents MiembrosTextBox As System.Windows.Forms.TextBox
        Friend WithEvents DiscografiaTextBox As System.Windows.Forms.TextBox
        Friend WithEvents GeneroTextBox As System.Windows.Forms.TextBox
        Friend WithEvents OtrosNombresTextBox As System.Windows.Forms.TextBox
        Friend WithEvents NombreNaciemientoTextBox As System.Windows.Forms.TextBox
        Friend WithEvents NombreArtistaTextBox As System.Windows.Forms.TextBox
        Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
        Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ToolStripButtonCancelar As System.Windows.Forms.ToolStripButton
        Friend WithEvents ListaPaisBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents IdPaisComboBox As System.Windows.Forms.ComboBox
        Friend WithEvents btnQuitarImagen As System.Windows.Forms.Button
        Friend WithEvents btnAgregarImagen As System.Windows.Forms.Button
        Friend WithEvents OpenFileDialogImagen As System.Windows.Forms.OpenFileDialog
        Friend WithEvents FotoPictureBox As System.Windows.Forms.PictureBox
    End Class
End Namespace
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuPrincipal))
        Me.panelTitulo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.panelBotones = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.btnReproductor = New System.Windows.Forms.Button()
        Me.btnFacturar = New System.Windows.Forms.Button()
        Me.btnInventario = New System.Windows.Forms.Button()
        Me.btnTemas = New System.Windows.Forms.Button()
        Me.btnAlbum = New System.Windows.Forms.Button()
        Me.btnArtistas = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.panelPrincipal = New System.Windows.Forms.Panel()
        Me.panelTitulo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBotones.SuspendLayout()
        Me.panelMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelTitulo
        '
        Me.panelTitulo.BackColor = System.Drawing.Color.Teal
        Me.panelTitulo.Controls.Add(Me.PictureBox1)
        Me.panelTitulo.Controls.Add(Me.Label1)
        Me.panelTitulo.Controls.Add(Me.btnMinimizar)
        Me.panelTitulo.Controls.Add(Me.btnCerrar)
        Me.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.panelTitulo.Name = "panelTitulo"
        Me.panelTitulo.Size = New System.Drawing.Size(960, 60)
        Me.panelTitulo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Jokerman", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label1.Location = New System.Drawing.Point(60, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 55)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tú Música"
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(842, 5)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(50, 50)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMinimizar.TabIndex = 1
        Me.btnMinimizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(902, 5)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(50, 50)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TabStop = False
        '
        'panelBotones
        '
        Me.panelBotones.BackColor = System.Drawing.Color.Teal
        Me.panelBotones.Controls.Add(Me.Panel6)
        Me.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelBotones.Location = New System.Drawing.Point(0, 500)
        Me.panelBotones.Name = "panelBotones"
        Me.panelBotones.Size = New System.Drawing.Size(960, 100)
        Me.panelBotones.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 95)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(960, 5)
        Me.Panel6.TabIndex = 0
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.DarkCyan
        Me.panelMenu.Controls.Add(Me.btnReproductor)
        Me.panelMenu.Controls.Add(Me.btnFacturar)
        Me.panelMenu.Controls.Add(Me.btnInventario)
        Me.panelMenu.Controls.Add(Me.btnTemas)
        Me.panelMenu.Controls.Add(Me.btnAlbum)
        Me.panelMenu.Controls.Add(Me.btnArtistas)
        Me.panelMenu.Controls.Add(Me.Panel5)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 60)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(200, 440)
        Me.panelMenu.TabIndex = 2
        '
        'btnReproductor
        '
        Me.btnReproductor.FlatAppearance.BorderSize = 0
        Me.btnReproductor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.btnReproductor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReproductor.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReproductor.ForeColor = System.Drawing.Color.DarkOrange
        Me.btnReproductor.Location = New System.Drawing.Point(5, 397)
        Me.btnReproductor.Name = "btnReproductor"
        Me.btnReproductor.Size = New System.Drawing.Size(196, 37)
        Me.btnReproductor.TabIndex = 6
        Me.btnReproductor.Text = "Reproductor"
        Me.btnReproductor.UseVisualStyleBackColor = True
        '
        'btnFacturar
        '
        Me.btnFacturar.FlatAppearance.BorderSize = 0
        Me.btnFacturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFacturar.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacturar.ForeColor = System.Drawing.Color.DarkOrange
        Me.btnFacturar.Location = New System.Drawing.Point(5, 169)
        Me.btnFacturar.Name = "btnFacturar"
        Me.btnFacturar.Size = New System.Drawing.Size(196, 37)
        Me.btnFacturar.TabIndex = 5
        Me.btnFacturar.Text = "Facturar"
        Me.btnFacturar.UseVisualStyleBackColor = True
        '
        'btnInventario
        '
        Me.btnInventario.FlatAppearance.BorderSize = 0
        Me.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventario.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventario.ForeColor = System.Drawing.Color.DarkOrange
        Me.btnInventario.Location = New System.Drawing.Point(5, 130)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(196, 37)
        Me.btnInventario.TabIndex = 4
        Me.btnInventario.Text = "Inventario"
        Me.btnInventario.UseVisualStyleBackColor = True
        '
        'btnTemas
        '
        Me.btnTemas.FlatAppearance.BorderSize = 0
        Me.btnTemas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.btnTemas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTemas.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTemas.ForeColor = System.Drawing.Color.DarkOrange
        Me.btnTemas.Location = New System.Drawing.Point(5, 91)
        Me.btnTemas.Name = "btnTemas"
        Me.btnTemas.Size = New System.Drawing.Size(196, 37)
        Me.btnTemas.TabIndex = 3
        Me.btnTemas.Text = "Temas"
        Me.btnTemas.UseVisualStyleBackColor = True
        '
        'btnAlbum
        '
        Me.btnAlbum.FlatAppearance.BorderSize = 0
        Me.btnAlbum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.btnAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlbum.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlbum.ForeColor = System.Drawing.Color.DarkOrange
        Me.btnAlbum.Location = New System.Drawing.Point(5, 52)
        Me.btnAlbum.Name = "btnAlbum"
        Me.btnAlbum.Size = New System.Drawing.Size(196, 37)
        Me.btnAlbum.TabIndex = 2
        Me.btnAlbum.Text = "Album"
        Me.btnAlbum.UseVisualStyleBackColor = True
        '
        'btnArtistas
        '
        Me.btnArtistas.FlatAppearance.BorderSize = 0
        Me.btnArtistas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.btnArtistas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArtistas.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArtistas.ForeColor = System.Drawing.Color.DarkOrange
        Me.btnArtistas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArtistas.Location = New System.Drawing.Point(5, 13)
        Me.btnArtistas.Name = "btnArtistas"
        Me.btnArtistas.Size = New System.Drawing.Size(196, 37)
        Me.btnArtistas.TabIndex = 1
        Me.btnArtistas.Text = "Artistas"
        Me.btnArtistas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnArtistas.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 440)
        Me.Panel5.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(955, 60)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 440)
        Me.Panel4.TabIndex = 3
        '
        'panelPrincipal
        '
        Me.panelPrincipal.BackColor = System.Drawing.Color.DarkSlateGray
        Me.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelPrincipal.ForeColor = System.Drawing.Color.Orange
        Me.panelPrincipal.Location = New System.Drawing.Point(200, 60)
        Me.panelPrincipal.Name = "panelPrincipal"
        Me.panelPrincipal.Size = New System.Drawing.Size(755, 440)
        Me.panelPrincipal.TabIndex = 4
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 600)
        Me.Controls.Add(Me.panelPrincipal)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.panelBotones)
        Me.Controls.Add(Me.panelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tu Música"
        Me.panelTitulo.ResumeLayout(False)
        Me.panelTitulo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBotones.ResumeLayout(False)
        Me.panelMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelTitulo As System.Windows.Forms.Panel
    Friend WithEvents panelBotones As System.Windows.Forms.Panel
    Friend WithEvents panelMenu As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents panelPrincipal As System.Windows.Forms.Panel
    Friend WithEvents btnMinimizar As System.Windows.Forms.PictureBox
    Friend WithEvents btnCerrar As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnFacturar As System.Windows.Forms.Button
    Friend WithEvents btnInventario As System.Windows.Forms.Button
    Friend WithEvents btnTemas As System.Windows.Forms.Button
    Friend WithEvents btnAlbum As System.Windows.Forms.Button
    Friend WithEvents btnArtistas As System.Windows.Forms.Button
    Friend WithEvents btnReproductor As System.Windows.Forms.Button

End Class

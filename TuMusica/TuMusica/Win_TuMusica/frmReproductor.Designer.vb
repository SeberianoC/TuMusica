Namespace Win_TuMusica
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmReproductor
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReproductor))
            Me.panelTitulo = New System.Windows.Forms.Panel()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnMinimizar = New System.Windows.Forms.PictureBox()
            Me.btnCerrar = New System.Windows.Forms.PictureBox()
            Me.panelBotones = New System.Windows.Forms.Panel()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.btnAnterior = New System.Windows.Forms.PictureBox()
            Me.btnStop = New System.Windows.Forms.PictureBox()
            Me.lblTiempo = New System.Windows.Forms.Label()
            Me.lblPista = New System.Windows.Forms.Label()
            Me.ProgressBarDuracion = New System.Windows.Forms.ProgressBar()
            Me.brnCancion = New System.Windows.Forms.PictureBox()
            Me.TrackBarVolumen = New System.Windows.Forms.TrackBar()
            Me.btnSonido = New System.Windows.Forms.PictureBox()
            Me.btnSiguiente = New System.Windows.Forms.PictureBox()
            Me.pictureBtnPlay = New System.Windows.Forms.PictureBox()
            Me.panelCentro = New System.Windows.Forms.Panel()
            Me.MediaPlayer = New AxWMPLib.AxWindowsMediaPlayer()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.ListaPistas = New System.Windows.Forms.ListBox()
            Me.OpenFileDialogPista = New System.Windows.Forms.OpenFileDialog()
            Me.TimerDuracion = New System.Windows.Forms.Timer(Me.components)
            Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.QuitarPistaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.panelTitulo.SuspendLayout()
            Me.Panel1.SuspendLayout()
            CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelBotones.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnAnterior, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnStop, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.brnCancion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TrackBarVolumen, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnSonido, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnSiguiente, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBtnPlay, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelCentro.SuspendLayout()
            CType(Me.MediaPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            Me.ContextMenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'panelTitulo
            '
            Me.panelTitulo.BackColor = System.Drawing.Color.SlateGray
            Me.panelTitulo.Controls.Add(Me.PictureBox1)
            Me.panelTitulo.Controls.Add(Me.Panel1)
            Me.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelTitulo.Location = New System.Drawing.Point(0, 0)
            Me.panelTitulo.Name = "panelTitulo"
            Me.panelTitulo.Size = New System.Drawing.Size(755, 55)
            Me.panelTitulo.TabIndex = 0
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnMinimizar)
            Me.Panel1.Controls.Add(Me.btnCerrar)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel1.Location = New System.Drawing.Point(650, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(105, 55)
            Me.Panel1.TabIndex = 0
            '
            'btnMinimizar
            '
            Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
            Me.btnMinimizar.Location = New System.Drawing.Point(3, 2)
            Me.btnMinimizar.Name = "btnMinimizar"
            Me.btnMinimizar.Size = New System.Drawing.Size(48, 48)
            Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.btnMinimizar.TabIndex = 1
            Me.btnMinimizar.TabStop = False
            '
            'btnCerrar
            '
            Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
            Me.btnCerrar.Location = New System.Drawing.Point(54, 2)
            Me.btnCerrar.Name = "btnCerrar"
            Me.btnCerrar.Size = New System.Drawing.Size(48, 48)
            Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.btnCerrar.TabIndex = 0
            Me.btnCerrar.TabStop = False
            '
            'panelBotones
            '
            Me.panelBotones.BackColor = System.Drawing.Color.SlateGray
            Me.panelBotones.Controls.Add(Me.btnAnterior)
            Me.panelBotones.Controls.Add(Me.btnStop)
            Me.panelBotones.Controls.Add(Me.lblTiempo)
            Me.panelBotones.Controls.Add(Me.lblPista)
            Me.panelBotones.Controls.Add(Me.ProgressBarDuracion)
            Me.panelBotones.Controls.Add(Me.brnCancion)
            Me.panelBotones.Controls.Add(Me.TrackBarVolumen)
            Me.panelBotones.Controls.Add(Me.btnSonido)
            Me.panelBotones.Controls.Add(Me.btnSiguiente)
            Me.panelBotones.Controls.Add(Me.pictureBtnPlay)
            Me.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelBotones.Location = New System.Drawing.Point(0, 346)
            Me.panelBotones.Name = "panelBotones"
            Me.panelBotones.Size = New System.Drawing.Size(755, 94)
            Me.panelBotones.TabIndex = 1
            '
            'PictureBox1
            '
            Me.PictureBox1.BackColor = System.Drawing.SystemColors.Info
            Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
            Me.PictureBox1.Image = Global.TuMusica.My.Resources.Resources.InfoBackground
            Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(119, 55)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox1.TabIndex = 18
            Me.PictureBox1.TabStop = False
            '
            'btnAnterior
            '
            Me.btnAnterior.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAnterior.Image = Global.TuMusica.My.Resources.Resources.Back
            Me.btnAnterior.Location = New System.Drawing.Point(276, 32)
            Me.btnAnterior.Name = "btnAnterior"
            Me.btnAnterior.Size = New System.Drawing.Size(50, 30)
            Me.btnAnterior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.btnAnterior.TabIndex = 17
            Me.btnAnterior.TabStop = False
            '
            'btnStop
            '
            Me.btnStop.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnStop.Image = Global.TuMusica.My.Resources.Resources.Media_Stop
            Me.btnStop.Location = New System.Drawing.Point(399, 28)
            Me.btnStop.Name = "btnStop"
            Me.btnStop.Size = New System.Drawing.Size(35, 35)
            Me.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.btnStop.TabIndex = 16
            Me.btnStop.TabStop = False
            '
            'lblTiempo
            '
            Me.lblTiempo.BackColor = System.Drawing.Color.Black
            Me.lblTiempo.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTiempo.ForeColor = System.Drawing.Color.Bisque
            Me.lblTiempo.Location = New System.Drawing.Point(715, 77)
            Me.lblTiempo.Name = "lblTiempo"
            Me.lblTiempo.Size = New System.Drawing.Size(39, 18)
            Me.lblTiempo.TabIndex = 15
            Me.lblTiempo.Text = "00:00"
            Me.lblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblPista
            '
            Me.lblPista.BackColor = System.Drawing.Color.Black
            Me.lblPista.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPista.ForeColor = System.Drawing.Color.Bisque
            Me.lblPista.Location = New System.Drawing.Point(0, 77)
            Me.lblPista.Name = "lblPista"
            Me.lblPista.Size = New System.Drawing.Size(718, 18)
            Me.lblPista.TabIndex = 14
            Me.lblPista.Text = "..."
            Me.lblPista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'ProgressBarDuracion
            '
            Me.ProgressBarDuracion.Dock = System.Windows.Forms.DockStyle.Top
            Me.ProgressBarDuracion.Location = New System.Drawing.Point(0, 0)
            Me.ProgressBarDuracion.Name = "ProgressBarDuracion"
            Me.ProgressBarDuracion.Size = New System.Drawing.Size(755, 8)
            Me.ProgressBarDuracion.Step = 1
            Me.ProgressBarDuracion.TabIndex = 13
            '
            'brnCancion
            '
            Me.brnCancion.BackColor = System.Drawing.Color.Transparent
            Me.brnCancion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.brnCancion.Cursor = System.Windows.Forms.Cursors.Hand
            Me.brnCancion.Image = Global.TuMusica.My.Resources.Resources.Music
            Me.brnCancion.Location = New System.Drawing.Point(3, 24)
            Me.brnCancion.Name = "brnCancion"
            Me.brnCancion.Size = New System.Drawing.Size(40, 38)
            Me.brnCancion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.brnCancion.TabIndex = 11
            Me.brnCancion.TabStop = False
            '
            'TrackBarVolumen
            '
            Me.TrackBarVolumen.LargeChange = 10
            Me.TrackBarVolumen.Location = New System.Drawing.Point(558, 32)
            Me.TrackBarVolumen.Maximum = 100
            Me.TrackBarVolumen.Name = "TrackBarVolumen"
            Me.TrackBarVolumen.Size = New System.Drawing.Size(185, 45)
            Me.TrackBarVolumen.TabIndex = 10
            Me.TrackBarVolumen.TickFrequency = 5
            Me.TrackBarVolumen.Value = 50
            '
            'btnSonido
            '
            Me.btnSonido.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSonido.Image = Global.TuMusica.My.Resources.Resources.Volume_Speaker_02
            Me.btnSonido.Location = New System.Drawing.Point(527, 32)
            Me.btnSonido.Name = "btnSonido"
            Me.btnSonido.Size = New System.Drawing.Size(25, 25)
            Me.btnSonido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.btnSonido.TabIndex = 5
            Me.btnSonido.TabStop = False
            '
            'btnSiguiente
            '
            Me.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSiguiente.Image = Global.TuMusica.My.Resources.Resources.Forward
            Me.btnSiguiente.Location = New System.Drawing.Point(438, 31)
            Me.btnSiguiente.Name = "btnSiguiente"
            Me.btnSiguiente.Size = New System.Drawing.Size(50, 30)
            Me.btnSiguiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.btnSiguiente.TabIndex = 4
            Me.btnSiguiente.TabStop = False
            '
            'pictureBtnPlay
            '
            Me.pictureBtnPlay.Cursor = System.Windows.Forms.Cursors.Hand
            Me.pictureBtnPlay.Image = Global.TuMusica.My.Resources.Resources.Media_Play
            Me.pictureBtnPlay.Location = New System.Drawing.Point(330, 11)
            Me.pictureBtnPlay.Name = "pictureBtnPlay"
            Me.pictureBtnPlay.Size = New System.Drawing.Size(65, 61)
            Me.pictureBtnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pictureBtnPlay.TabIndex = 3
            Me.pictureBtnPlay.TabStop = False
            '
            'panelCentro
            '
            Me.panelCentro.BackColor = System.Drawing.Color.Lavender
            Me.panelCentro.Controls.Add(Me.MediaPlayer)
            Me.panelCentro.Controls.Add(Me.Panel2)
            Me.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelCentro.Location = New System.Drawing.Point(0, 55)
            Me.panelCentro.Name = "panelCentro"
            Me.panelCentro.Size = New System.Drawing.Size(755, 291)
            Me.panelCentro.TabIndex = 2
            '
            'MediaPlayer
            '
            Me.MediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MediaPlayer.Enabled = True
            Me.MediaPlayer.Location = New System.Drawing.Point(332, 0)
            Me.MediaPlayer.Name = "MediaPlayer"
            Me.MediaPlayer.OcxState = CType(resources.GetObject("MediaPlayer.OcxState"), System.Windows.Forms.AxHost.State)
            Me.MediaPlayer.Size = New System.Drawing.Size(423, 291)
            Me.MediaPlayer.TabIndex = 0
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.ListaPistas)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(332, 291)
            Me.Panel2.TabIndex = 1
            '
            'ListaPistas
            '
            Me.ListaPistas.BackColor = System.Drawing.SystemColors.Info
            Me.ListaPistas.ContextMenuStrip = Me.ContextMenuStrip1
            Me.ListaPistas.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ListaPistas.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ListaPistas.ForeColor = System.Drawing.Color.DimGray
            Me.ListaPistas.FormattingEnabled = True
            Me.ListaPistas.HorizontalScrollbar = True
            Me.ListaPistas.Location = New System.Drawing.Point(0, 0)
            Me.ListaPistas.Name = "ListaPistas"
            Me.ListaPistas.ScrollAlwaysVisible = True
            Me.ListaPistas.Size = New System.Drawing.Size(332, 291)
            Me.ListaPistas.TabIndex = 1
            '
            'OpenFileDialogPista
            '
            Me.OpenFileDialogPista.FileName = "OpenFileDialog1"
            Me.OpenFileDialogPista.Filter = "(Archivos de Audio)|*.mp3;*.wpm;*.mp4"
            Me.OpenFileDialogPista.Multiselect = True
            '
            'TimerDuracion
            '
            Me.TimerDuracion.Enabled = True
            '
            'ContextMenuStrip1
            '
            Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitarPistaToolStripMenuItem})
            Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
            Me.ContextMenuStrip1.Size = New System.Drawing.Size(136, 26)
            '
            'QuitarPistaToolStripMenuItem
            '
            Me.QuitarPistaToolStripMenuItem.Name = "QuitarPistaToolStripMenuItem"
            Me.QuitarPistaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
            Me.QuitarPistaToolStripMenuItem.Text = "Quitar Pista"
            '
            'frmReproductor
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(755, 440)
            Me.Controls.Add(Me.panelCentro)
            Me.Controls.Add(Me.panelBotones)
            Me.Controls.Add(Me.panelTitulo)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximumSize = New System.Drawing.Size(755, 440)
            Me.MinimumSize = New System.Drawing.Size(755, 440)
            Me.Name = "frmReproductor"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Reproductor Tu Música"
            Me.panelTitulo.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelBotones.ResumeLayout(False)
            Me.panelBotones.PerformLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnAnterior, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnStop, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.brnCancion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TrackBarVolumen, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnSonido, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnSiguiente, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBtnPlay, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelCentro.ResumeLayout(False)
            CType(Me.MediaPlayer, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.ContextMenuStrip1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents panelTitulo As System.Windows.Forms.Panel
        Friend WithEvents panelBotones As System.Windows.Forms.Panel
        Friend WithEvents panelCentro As System.Windows.Forms.Panel
        Friend WithEvents btnMinimizar As System.Windows.Forms.PictureBox
        Friend WithEvents btnCerrar As System.Windows.Forms.PictureBox
        Friend WithEvents MediaPlayer As AxWMPLib.AxWindowsMediaPlayer
        Friend WithEvents OpenFileDialogPista As System.Windows.Forms.OpenFileDialog
        Friend WithEvents pictureBtnPlay As System.Windows.Forms.PictureBox
        Friend WithEvents btnSiguiente As System.Windows.Forms.PictureBox
        Friend WithEvents btnSonido As System.Windows.Forms.PictureBox
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents TrackBarVolumen As System.Windows.Forms.TrackBar
        Friend WithEvents brnCancion As System.Windows.Forms.PictureBox
        Friend WithEvents ProgressBarDuracion As System.Windows.Forms.ProgressBar
        Friend WithEvents lblPista As System.Windows.Forms.Label
        Friend WithEvents TimerDuracion As System.Windows.Forms.Timer
        Friend WithEvents lblTiempo As System.Windows.Forms.Label
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents ListaPistas As System.Windows.Forms.ListBox
        Friend WithEvents btnAnterior As System.Windows.Forms.PictureBox
        Friend WithEvents btnStop As System.Windows.Forms.PictureBox
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents QuitarPistaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace
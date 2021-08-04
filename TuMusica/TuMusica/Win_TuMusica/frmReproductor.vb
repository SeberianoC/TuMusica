Imports WMPLib

Namespace Win_TuMusica
    Public Class frmReproductor
        Dim ListPistas As New List(Of String)
        
        Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
            Close()
        End Sub

        Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
            WindowState = FormWindowState.Minimized
        End Sub

        Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
            MediaPlayer.Ctlcontrols.stop()
            pictureBtnPlay.Image = My.Resources.Media_Play
        End Sub

        Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles pictureBtnPlay.Click
            If MediaPlayer.playState = WMPPlayState.wmppsPlaying Then
                MediaPlayer.Ctlcontrols.pause()
                pictureBtnPlay.Image = My.Resources.Media_Play ''Nombre de imagen de reproducir
            Else
                MediaPlayer.Ctlcontrols.play()
                pictureBtnPlay.Image = My.Resources.Media_Pause 'nombre imagen para pausar
            End If
        End Sub

        Private Sub btnCancion_Click(sender As Object, e As EventArgs) Handles brnCancion.Click
            Dim archivo = ""

            If OpenFileDialogPista.ShowDialog() = DialogResult.OK Then
                archivo = OpenFileDialogPista.FileName

                For Each pista As String In OpenFileDialogPista.FileNames
                    ListPistas.Add(pista)
                Next

                For Each pista As String In OpenFileDialogPista.SafeFileNames
                    ListaPistas.Items.Add((ListaPistas.Items.Count + 1).ToString() + " - " + pista)
                Next
                ListaPistas.SelectedIndex = 0
            End If

            Reproducir(archivo, False)
        End Sub

        Private Sub Reproducir(archivo As String, play As Boolean)
            If archivo <> "" And MediaPlayer.playState <> WMPPlayState.wmppsPlaying Then
                MediaPlayer.URL = archivo
                MediaPlayer.Ctlcontrols.play()
                pictureBtnPlay.Image = My.Resources.Media_Pause
                lblPista.Text = ListaPistas.SelectedItem
            End If
            If play = True Then
                MediaPlayer.URL = archivo
                MediaPlayer.Ctlcontrols.play()
                pictureBtnPlay.Image = My.Resources.Media_Pause
                lblPista.Text = ListaPistas.SelectedItem
            End If

            AsignarTiempo()
        End Sub

        Private Sub AsignarTiempo()
            Dim tiempo = MediaPlayer.currentMedia.durationString

            Dim m = tiempo.Substring(0, 2)
            Dim s = tiempo.Substring(3, 2)
            Dim t As Int32

            t = (m * 60) + s

            ProgressBarDuracion.Maximum = t
        End Sub

        Private Sub btnSonido_Click(sender As Object, e As EventArgs) Handles btnSonido.Click
            If MediaPlayer.settings.mute = True Then
                MediaPlayer.settings.mute = False
                btnSonido.Image = My.Resources.Volume_Speaker_02
            Else
                MediaPlayer.settings.mute = True
                btnSonido.Image = My.Resources.Volume_Mute
            End If
        End Sub

        Private Sub frmReproductor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            TrackBarVolumen.Value = MediaPlayer.settings.volume
            MediaPlayer.URL = "D:\Datos_PC\Documents\Visual Studio 2012\Projects\TuMusica\TuMusica\inicio.mp3"
            MediaPlayer.Ctlcontrols.play()
            lblPista.Text = "Pista Inicio.mp3"
            AsignarTiempo()
        End Sub

        Private Sub TrackBarVolumen_Scroll(sender As Object, e As EventArgs) Handles TrackBarVolumen.Scroll
            MediaPlayer.settings.volume = TrackBarVolumen.Value
        End Sub

        Private Sub TimerDuracion_Tick(sender As Object, e As EventArgs) Handles TimerDuracion.Tick
            If MediaPlayer.currentMedia.duration >= 30.0 Then
                ProgressBarDuracion.Value = MediaPlayer.Ctlcontrols.currentPosition
            End If

            If MediaPlayer.playState = WMPPlayState.wmppsStopped Then
                pictureBtnPlay.Image = My.Resources.Media_Play
            End If
            lblTiempo.Text = MediaPlayer.Ctlcontrols.currentPositionString

        End Sub

        Private Sub ListaPistas_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListaPistas.MouseDoubleClick
            '        MessageBox.Show(ListaPistas.SelectedItem)
            '        MessageBox.Show(ListPistas.Item(ListaPistas.SelectedIndex))

            Reproducir(ListPistas.Item(ListaPistas.SelectedIndex), True)
        End Sub

        Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
            If ListaPistas.SelectedIndex = ListaPistas.Items.Count - 1 Then
                ListaPistas.SelectedIndex = 0
            Else
                Dim n = ListaPistas.SelectedIndex + 1
                ListaPistas.SelectedIndex = n
            End If

            Reproducir(ListPistas.Item(ListaPistas.SelectedIndex), True)

        End Sub

        Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
            If ListaPistas.SelectedIndex = 0 Then
                ListaPistas.SelectedIndex = ListaPistas.Items.Count - 1
            Else
                Dim n = ListaPistas.SelectedIndex - 1
                ListaPistas.SelectedIndex = n
            End If

            Reproducir(ListPistas.Item(ListaPistas.SelectedIndex), True)
        End Sub

        Private Sub QuitarPistaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitarPistaToolStripMenuItem.Click
            '        MessageBox.Show(ListaPistas.SelectedItem)
            '        MessageBox.Show(ListPistas.Item(ListaPistas.SelectedIndex))        
            Dim n = ListaPistas.SelectedIndex
            ListPistas.RemoveAt(n)
            ListaPistas.Items.RemoveAt(n)
        End Sub
    End Class
End Namespace
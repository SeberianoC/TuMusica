Imports System.IO
Imports TuMusica
Imports TuMusica.BL_TuMusica

Namespace Win_TuMusica

    Public Class frmArtistas
#Region "Config"
        Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
            Me.Close()
        End Sub

        Private Sub btnCerrar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnCerrar.MouseMove
            btnCerrar.BorderStyle = BorderStyle.FixedSingle
        End Sub

        Private Sub btnCerrar_MouseLeave(sender As Object, e As EventArgs) Handles btnCerrar.MouseLeave
            btnCerrar.BorderStyle = BorderStyle.None
        End Sub

        '' Deshabilitar botones
        Private Sub DeshabilitarHabilitarBotones(valor As Boolean)
            BindingNavigatorMoveFirstItem.Enabled = valor
            BindingNavigatorMoveLastItem.Enabled = valor
            BindingNavigatorMovePreviousItem.Enabled = valor
            BindingNavigatorMoveNextItem.Enabled = valor
            BindingNavigatorPositionItem.Enabled = valor
            BindingNavigatorAddNewItem.Enabled = valor
            BindingNavigatorDeleteItem.Enabled = valor
            'BindingNavigatorSaveItem.Enabled = Not valor
            ToolStripButtonCancelar.Visible = Not valor
        End Sub

        'Instancia para cargar los datos
        Private _artistas As BL_Artistas
        Private _paises As BL_Paises

        Private Sub frmArtistas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            _artistas = New BL_Artistas
            ListaArtistasBindingSource.DataSource = _artistas.ObtenerArtistas

            _paises = New BL_Paises
            ListaPaisBindingSource.DataSource = _paises.ObtenerPais
        End Sub

        Private Sub Eliminar(id As Integer)
            Dim resultado = _artistas.EliminarArtista(id)
            If resultado = True Then
                ListaArtistasBindingSource.ResetBindings(False)
            Else
                MessageBox.Show("Error al Eliminar alumno")
            End If
        End Sub
#End Region

        Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
            _artistas.AgregarArtista()
            ListaArtistasBindingSource.MoveLast()
            DeshabilitarHabilitarBotones(False)
        End Sub

        Private Sub ToolStripButtonCancelar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonCancelar.Click
            DeshabilitarHabilitarBotones(True)
            Eliminar(0)
        End Sub

        Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
            If IdTextBox.Text <> "" Then
                Dim resultado = MessageBox.Show("¿Desea Eliminar Artista?", "Eliminar Artista", MessageBoxButtons.YesNo)
                If resultado = DialogResult.Yes Then
                    Eliminar(Convert.ToInt32(IdTextBox.Text))
                End If
            End If
        End Sub

        Private Sub ListaArtistasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ListaArtistasBindingNavigatorSaveItem.Click
            ListaArtistasBindingSource.EndEdit()

            Dim artista = CType(ListaArtistasBindingSource.Current, Artistas)
            Dim resultado = _artistas.GuardarArtista(artista)

            'Controlar la imagen'
            If FotoPictureBox.Image IsNot Nothing Then
                artista.Foto = ConvertirImagen.imagenToByteArray(FotoPictureBox.Image)
            Else
                artista.Foto = Nothing
            End If
            ''


            If resultado.Correcto = True Then
                ListaArtistasBindingSource.ResetBindings(False)
                DeshabilitarHabilitarBotones(True)
            Else
                MessageBox.Show(resultado.Mensaje)
            End If
        End Sub

        Private Sub btnAgregarImagen_Click(sender As Object, e As EventArgs) Handles btnAgregarImagen.Click
            'OpenFileDialogImagen.ShowDialog()
            'FotoPictureBox.ImageLocation = OpenFileDialogImagen.FileName

            Dim artista = CType(ListaArtistasBindingSource.Current, Artistas)

            If artista IsNot Nothing Then
                OpenFileDialogImagen.ShowDialog()
                Dim archivo = OpenFileDialogImagen.FileName

                If archivo <> Nothing Then
                    If archivo <> "" Then
                        Dim fileInfo = New FileInfo(archivo)
                        Dim fileStream = fileInfo.OpenRead()
                        FotoPictureBox.Image = Image.FromStream(fileStream)
                    End If
                Else
                    MessageBox.Show("Cree un doctor antes de asignar la imagen")
                End If
            End If
        End Sub

        Private Sub btnQuitarImagen_Click(sender As Object, e As EventArgs) Handles btnQuitarImagen.Click
            FotoPictureBox.Image = Nothing
        End Sub
    End Class
End Namespace
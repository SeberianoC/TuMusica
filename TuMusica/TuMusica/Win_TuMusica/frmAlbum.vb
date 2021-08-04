Imports System.IO
Imports TuMusica.BL_TuMusica.BL_Album
Imports TuMusica.BL_TuMusica
Imports TuMusica.BL_TuMusica.BL_Artistas

Public Class frmAlbum
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnCerrar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnCerrar.MouseMove
        btnCerrar.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub btnCerrar_MouseLeave(sender As Object, e As EventArgs) Handles btnCerrar.MouseLeave
        btnCerrar.BorderStyle = BorderStyle.None
    End Sub


    Private _album As BL_Album
    Private _artista As BL_Artistas
    Private Sub frmAlbum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _album = New BL_Album()
        ListaAlbunesBindingSource.DataSource = _album.ObtenerAlbum()

        _artista = New BL_Artistas()
        ListaArtistasBindingSource.DataSource = _artista.ObtenerArtistas()

    End Sub

    Private Sub btnAgregarImagen_Click(sender As Object, e As EventArgs) Handles btnAgregarImagen.Click
        Dim album = CType(ListaAlbunesBindingSource.Current, Album)

        If album IsNot Nothing Then
            OpenFileDialogImagen.ShowDialog()
            Dim archivo = OpenFileDialogImagen.FileName

            If archivo <> Nothing Then
                If archivo <> "" Then
                    Dim fileInfo = New FileInfo(archivo)
                    Dim fileStream = fileInfo.OpenRead()
                    FotoPictureBox.Image = Image.FromStream(fileStream)
                End If
            Else
                MessageBox.Show("Cree un Album antes de asignar la imagen")
            End If
        End If
    End Sub

    Private Sub btnQuitarImagen_Click(sender As Object, e As EventArgs) Handles btnQuitarImagen.Click
        FotoPictureBox.Image = Nothing
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        _album.AgregarAlbum()
        ListaAlbunesBindingSource.MoveLast()
        DeshabilitarHabilitarBotones(False)
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

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        If IdTextBox.Text <> "" Then
            Dim resultado = MessageBox.Show("¿Desea Eliminar Album?", "Eliminar Album", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then
                Eliminar(Convert.ToInt32(IdTextBox.Text))
            End If
        End If
    End Sub

    Private Sub Eliminar(id As Integer)
        Dim resultado = _album.EliminarAlbum(id)
        If resultado = True Then
            ListaAlbunesBindingSource.ResetBindings(False)
        Else
            MessageBox.Show("Error al Eliminar album")
        End If
    End Sub

    Private Sub ListaAlbunesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ListaAlbunesBindingNavigatorSaveItem.Click
        ListaAlbunesBindingSource.EndEdit()

        Dim album = CType(ListaAlbunesBindingSource.Current, Album)
        Dim resultado = _album.GuardarAlbum(album)

        'Controlar la imagen'
        If FotoPictureBox.Image IsNot Nothing Then
            album.Foto = ConvertirImagen.imagenToByteArray(FotoPictureBox.Image)
        Else
            album.Foto = Nothing
        End If
        ''
        If resultado.Correcto = True Then
            ListaAlbunesBindingSource.ResetBindings(False)
            DeshabilitarHabilitarBotones(True)
        Else
            MessageBox.Show(resultado.Mensaje)
        End If
    End Sub

    Private Sub ToolStripButtonCancelar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonCancelar.Click
        DeshabilitarHabilitarBotones(True)
        Eliminar(0)
    End Sub
End Class
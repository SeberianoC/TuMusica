Imports TuMusica.BL_TuMusica

Public Class frmTemas
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnCerrar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnCerrar.MouseMove
        btnCerrar.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub btnCerrar_MouseLeave(sender As Object, e As EventArgs) Handles btnCerrar.MouseLeave
        btnCerrar.BorderStyle = BorderStyle.None
    End Sub

    Dim _temas As BL_Temas
    Dim _artista As BL_Artistas
    Dim _album As BL_Album

    Private Sub frmTemas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _temas = New BL_Temas()
        ListaTemasBindingSource.DataSource = _temas.ObtenerTemas()

        _artista = New BL_Artistas()
        ListaArtistasBindingSource.DataSource = _artista.ObtenerArtistas()

        _album = New BL_Album()
        ListaAlbunesBindingSource.DataSource = _album.ObtenerAlbum()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        _temas.AgregarTema()
        ListaTemasBindingSource.MoveLast()
        DeshabilitarHabilitarBotones(False)
        NumeroTemaTextBox.Focus()
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
            Dim resultado = MessageBox.Show("¿Desea Eliminar Tema?", "Eliminar Tema", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then
                Eliminar(Convert.ToInt32(IdTextBox.Text))
            End If
        End If
    End Sub

    Private Sub Eliminar(id As Integer)
        Dim resultado = _temas.EliminarTema(id)
        If resultado = True Then
            ListaTemasBindingSource.ResetBindings(False)
        Else
            MessageBox.Show("Error al Eliminar temas")
        End If
    End Sub

    Private Sub ListaTemasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ListaTemasBindingNavigatorSaveItem.Click
        ListaTemasBindingSource.EndEdit()

        Dim tema = CType(ListaTemasBindingSource.Current, Tema)
        Dim resultado = _temas.GuardarTema(tema)

        If resultado.Correcto = True Then
            ListaTemasBindingSource.ResetBindings(False)
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
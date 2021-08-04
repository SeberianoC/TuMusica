Imports System.ComponentModel
Imports System.Data.Entity

Namespace BL_TuMusica
    Public Class Album
        Public Property Id() As Integer
        Public Property IdArtista() As Integer
        Public Property NombreAlbum() As String
        Public Property Publicacion() As String
        Public Property Genero() As String
        Public Property Pistas() As Integer
        Public Property Foto() As Byte()
        Public Property Existencia() As Integer
        Public Property Precio() As Double
    End Class
    Public Class BL_Album
        Dim _contexto As Contexto

        Public Property ListaAlbunes As BindingList(Of Album)

        Public Sub New()
            _contexto = New Contexto()
            ListaAlbunes = New BindingList(Of Album)()
        End Sub


        Public Function ObtenerAlbum() As BindingList(Of Album)
            _contexto.tAlbumes.Load()
            ListaAlbunes = _contexto.tAlbumes.Local.ToBindingList()

            Return ListaAlbunes
        End Function

        Public Sub AgregarAlbum()
            Dim nuevoAlbum As New Album
            ListaAlbunes.Add(nuevoAlbum)
        End Sub

        Public Function GuardarAlbum(album As Album) As Resultado
            Dim resultado = Validar(album)

            If resultado.Correcto = False Then
                Return resultado
            End If
            If album.Id = 0 Then
                album.Id = ListaAlbunes.Max(Function(item) item.Id) + 1
            End If
            'Para guardar en la base de datos'
            _contexto.SaveChanges()
            ''''
            resultado.Correcto = True
            Return resultado
        End Function

        ''Agregamos la clase cancelar cambios
        Public Sub CancelarCambios()
            For Each item In _contexto.ChangeTracker.Entries()
                item.State = EntityState.Unchanged
                item.Reload()
            Next
        End Sub

        Public Function EliminarAlbum(id As Integer) As Boolean
            For Each album In ListaAlbunes
                If album.Id = id Then
                    ListaAlbunes.Remove(album)
                    Return True
                End If
            Next
            Return False
        End Function

        Private Function Validar(album As Album) As Resultado
            Dim resultado As New Resultado()
            resultado.Correcto = True

            If album.Precio = 0 Then
                resultado.Correcto = False
                resultado.Mensaje = "Debe ingresar un precio"
            End If
            If album.Existencia = 0 Then
                resultado.Correcto = False
                resultado.Mensaje = "Debe ingresar una existencia"
            End If

            If String.IsNullOrEmpty(album.NombreAlbum) = True Then
                resultado.Correcto = False
                resultado.Mensaje = "Debe ingresar el Nombre del Album"
            End If
            If album.IdArtista = 0 Then
                resultado.Correcto = False
                resultado.Mensaje = "Debe ingresar un Artista para el Album"
            End If

            Return resultado
        End Function

    End Class
End Namespace
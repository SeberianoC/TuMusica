Imports System.ComponentModel
Imports System.Data.Entity

Namespace BL_TuMusica
    Public Class Tema
        Public Property Id() As Integer
        Public Property IdAlbum() As Integer
        Public Property NombreAlbum() As Album()
        Public Property IdArtista() As Integer
        Public Property NombreArtista() As Artistas()
        Public Property NumeroTema() As Integer
        Public Property Cancion() As String
        Public Property Duracion() As String
        Public Property Pista() As String
    End Class

    Public Class BL_Temas
        Dim _contexto As Contexto
        Public Property ListaTemas As BindingList(Of Tema)

        Public Sub New()
            _contexto = New Contexto()
            ListaTemas = New BindingList(Of Tema)()
        End Sub

        Public Function ObtenerTemas() As BindingList(Of Tema)
            _contexto.tTemas.Load()
            ListaTemas = _contexto.tTemas.Local.ToBindingList()

            Return ListaTemas
        End Function

        Public Sub AgregarTema()
            Dim nuevoTema = New Tema()
            ListaTemas.Add(nuevoTema)
        End Sub

        Public Function GuardarTema(tema As Tema) As Resultado
            Dim resultado = Validar(tema)

            If resultado.Correcto = False Then
                Return resultado
            End If

            _contexto.SaveChanges()

            resultado.Correcto = True
            Return resultado
        End Function

        Public Function EliminarTema(id As Integer) As Boolean
            For Each tema In ListaTemas
                If tema.Id = id Then
                    ListaTemas.Remove(tema)

                    _contexto.SaveChanges()
                    Return True
                End If
            Next
            Return False
        End Function

        Public Sub CancelarCambios()
            For Each item In _contexto.ChangeTracker.Entries()
                item.State = EntityState.Unchanged
                item.Reload()
            Next
        End Sub

        Private Function Validar(tema As Tema) As Resultado
            Dim resultado As New Resultado()
            resultado.Correcto = True

            If String.IsNullOrEmpty(tema.Duracion) = True Then
                resultado.Correcto = False
                resultado.Mensaje = "Ingrese duración del Tema"
            End If
            If String.IsNullOrEmpty(tema.Cancion) = True Then
                resultado.Correcto = False
                resultado.Mensaje = "Ingrese nombre del Tema"
            End If
            If tema.NumeroTema = 0 Then
                resultado.Correcto = False
                resultado.Mensaje = "Ingrese número de tema"
            End If

            If tema.IdAlbum = 0 Then
                resultado.Correcto = False
                resultado.Mensaje = "La pista necesita un album"
            End If

            Return resultado
        End Function

    End Class
End Namespace
Imports System.ComponentModel
Imports System.Data.Entity

Namespace BL_TuMusica
    Public Class Artistas
        Public Property Id() As Integer
        Public Property NombreArtista() As String
        Public Property NombreNaciemiento() As String
        Public Property OtrosNombres() As String
        Public Property IdPais As Integer
        Public Property PaisOrigen As Pais
        Public Property Genero() As String
        Public Property Discografia() As String
        Public Property Miembros() As String
        Public Property Foto As Byte()
    End Class

    Public Class BL_Artistas
        '''Agregamos el contexto
        Dim _contexto As Contexto
        Public Property ListaArtistas As BindingList(Of Artistas)

        Public Sub New()
            _contexto = New Contexto()
            ListaArtistas = New BindingList(Of Artistas)()
        End Sub

        Public Function ObtenerArtistas() As BindingList(Of Artistas)
            _contexto.tArtista.Load()
            ListaArtistas = _contexto.tArtista.Local.ToBindingList()

            Return ListaArtistas
        End Function

        Public Sub AgregarArtista()
            Dim nuevoArtista = New Artistas()
            ListaArtistas.Add(nuevoArtista)
        End Sub

        Public Function GuardarArtista(artista As Artistas) As Resultado
            Dim resultado = Validar(artista)

            If resultado.Correcto = False Then
                Return resultado
            End If

            _contexto.SaveChanges()

            resultado.Correcto = True
            Return resultado

        End Function

        Public Function EliminarArtista(id As Integer) As Boolean
            For Each artista In ListaArtistas
                If artista.Id = id Then
                    ListaArtistas.Remove(artista)
                    ''Agregamos la line de salvar cambios en el contexto
                    _contexto.SaveChanges()
                    Return True
                End If
            Next
            Return False
        End Function

        ''Agregamos la clase cancelar cambios

        Public Sub CancelarCambios()
            For Each item In _contexto.ChangeTracker.Entries()
                item.State = EntityState.Unchanged
                item.Reload()
            Next
        End Sub
        Private Function Validar(artista As Artistas) As Resultado
            Dim resultado As New Resultado()
            resultado.Correcto = True

            If String.IsNullOrEmpty(artista.Discografia) = True Then
                resultado.Correcto = False
                resultado.Mensaje = "Ingrese un Disco al menos"
            End If
            If String.IsNullOrEmpty(artista.Genero) = True Then
                resultado.Correcto = False
                resultado.Mensaje = "Ingrese un Género musical al menos"
            End If
            If String.IsNullOrEmpty(artista.NombreArtista) = True Then
                resultado.Correcto = False
                resultado.Mensaje = "Ingrese Nombre de Artista"
            End If
            Return resultado
        End Function

    End Class

    Public Class Resultado
        Public Property Correcto As Boolean
        Public Property Mensaje As String
    End Class
End Namespace
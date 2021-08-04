Imports System.Data.Entity

Namespace BL_TuMusica
    Public Class DatosInicio
        Inherits CreateDatabaseIfNotExists(Of Contexto)

        Protected Overrides Sub Seed(contexto As Contexto)
            ''Datos Inicio Artista
            Dim artista1 = New Artistas()
            artista1.Id = 1
            artista1.NombreArtista = "Vangelis"
            artista1.Genero = "New Age"
            artista1.Discografia = "Chariots of Fire"
            contexto.tArtista.Add(artista1)

            Dim artista2 = New Artistas()
            artista2.Id = 2
            artista2.NombreArtista = "BTS"
            artista2.Genero = "K-Pop"
            contexto.tArtista.Add(artista2)

            Dim artista3 = New Artistas()
            artista3.Id = 3
            artista3.NombreArtista = "LOS ESTERNOCLEIDOMASTOIDEOS"
            artista3.Genero = "ROCK"
            contexto.tArtista.Add(artista3)

            'Datos inicio de album'
            Dim album1 = New Album()
            album1.Id = 1
            album1.IdArtista = 1
            album1.NombreAlbum = "Chariots of Fire"
            album1.Existencia = 1
            album1.Precio = 250
            contexto.tAlbumes.Add(album1)

            Dim album2 = New Album()
            album2.Id = 2
            album2.IdArtista = 2
            album2.NombreAlbum = "Love Yourself: Tear"
            album2.Existencia = 5
            album2.Precio = 300
            contexto.tAlbumes.Add(album2)

            ''Datos inicio Temas
            Dim tema1 = New Tema()
            tema1.Id = 1
            tema1.IdAlbum = 1
            tema1.NumeroTema = 1
            tema1.Cancion = "Titles"
            tema1.Duracion = "03:25"
            contexto.tTemas.Add(tema1)

            Dim tema2 = New Tema()
            tema2.Id = 2
            tema2.IdAlbum = 2
            tema2.NumeroTema = 6
            tema2.Cancion = "Love Maze"
            tema2.Duracion = "03:40"
            contexto.tTemas.Add(tema2)

            ''Datos Inicio Paies
            Dim pais1 = New Pais()
            pais1.Id = 1
            pais1.NombrePais = "Grecia"
            contexto.tPaises.Add(pais1)

            Dim pais2 = New Pais()
            pais2.Id = 2
            pais2.NombrePais = "Puelto Lico"
            contexto.tPaises.Add(pais2)

            Dim pais3 = New Pais()
            pais3.Id = 3
            pais3.NombrePais = "México"
            contexto.tPaises.Add(pais3)

            Dim pais4 = New Pais()
            pais4.Id = 4
            pais4.NombrePais = "Corea del Sur"
            contexto.tPaises.Add(pais4)

            MyBase.Seed(contexto)
        End Sub
    End Class
End Namespace
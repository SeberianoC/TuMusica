Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration.Conventions

Namespace BL_TuMusica
    Public Class Contexto
        Inherits DbContext

        Public Sub New()
            MyBase.New("StoreTuMusica")
        End Sub

        Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
            modelBuilder.Conventions.Remove(Of PluralizingTableNameConvention)()
            Database.SetInitializer(New DatosInicio())
        End Sub

        Public Property tArtista As DbSet(Of Artistas)
        Public Property tAlbumes As DbSet(Of Album)
        Public Property tPaises As DbSet(Of Pais)
        Public Property tTemas As DbSet(Of Tema)

    End Class
End Namespace
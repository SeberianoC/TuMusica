Imports System.ComponentModel
Imports System.Data.Entity

Namespace BL_TuMusica
    Public Class Pais
        Public Property Id() As Integer
        Public Property NombrePais() As String
    End Class

    Public Class BL_Paises

        Dim _contexto As Contexto
        Public Property ListaPais As BindingList(Of Pais)

        Public Sub New()
            _contexto = New Contexto()
            ListaPais = New BindingList(Of Pais)()
        End Sub

        Public Function ObtenerPais() As BindingList(Of Pais)
            _contexto.tPaises.Load()
            ListaPais = _contexto.tPaises.Local.ToBindingList()

            Return ListaPais
        End Function

        Public Sub AgregarPais()
            Dim nuevoPais As New Pais
            ListaPais.Add(nuevoPais)
        End Sub

        Public Function GuardarPais(pais As Pais) As Resultado
            Dim resultado = Validar(pais)

            If resultado.Correcto = False Then
                Return resultado
            End If

            _contexto.SaveChanges()

            resultado.Correcto = True
            Return resultado
        End Function

        Public Function EliminarPais(id As Integer) As Boolean
            For Each pais In ListaPais
                If pais.Id = id Then
                    ListaPais.Remove(pais)
                    ''Agregamos la line de salvar cambios en el contexto
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

        Private Function Validar(pais As Pais) As Resultado
            Dim resultado As New Resultado()
            resultado.Correcto = True

            If String.IsNullOrEmpty(pais.NombrePais) = True Then
                resultado.Correcto = False
                resultado.Mensaje = "Debe ingresar el Nombre de un País"
            End If
            Return resultado
        End Function
    End Class
End Namespace
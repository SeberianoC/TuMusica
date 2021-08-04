Imports System.IO

Public Class ConvertirImagen
    Public Shared Function imagenToByteArray(imageIn As Image) As Byte()
        Dim ms = New MemoryStream()
        imageIn.Save(ms, imageIn.RawFormat)
        Return ms.ToArray()
    End Function
End Class

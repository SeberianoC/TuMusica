Imports System.Runtime.InteropServices
Imports TuMusica.Win_TuMusica

Public Class frmMenuPrincipal

#Region "Configuración"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCaptrue()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If MessageBox.Show("¿Desea cerrar Aplicación?", "Tu Música", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub panelTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown, panelTitulo.MouseDown, Label1.MouseDown
        ReleaseCaptrue()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub AbrirFromulario(Of miForm As {Form, New})()
        Dim formulario As Form
        formulario = panelPrincipal.Controls.OfType(Of miForm)().FirstOrDefault()
        If formulario Is Nothing Then
            formulario = New miForm()
            formulario.TopLevel = False
            formulario.FormBorderStyle = FormBorderStyle.None
            formulario.Dock = DockStyle.Fill
            panelPrincipal.Controls.Add(formulario)
            panelPrincipal.Tag = formulario
            formulario.Show()
            formulario.BringToFront()
        Else
            formulario.BringToFront()
        End If
    End Sub
#End Region


    Private Sub btnArtistas_Click(sender As Object, e As EventArgs) Handles btnArtistas.Click
        AbrirFromulario(Of frmArtistas)()
    End Sub

    Private Sub btnMinimizar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnMinimizar.MouseMove
        btnMinimizar.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub btnMinimizar_MouseLeave(sender As Object, e As EventArgs) Handles btnMinimizar.MouseLeave
        btnMinimizar.BorderStyle = BorderStyle.None
    End Sub

    Private Sub btnCerrar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnCerrar.MouseMove
        btnCerrar.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub btnCerrar_MouseLeave(sender As Object, e As EventArgs) Handles btnCerrar.MouseLeave
        btnCerrar.BorderStyle = BorderStyle.None
    End Sub

    Private Sub btnAlbum_Click(sender As Object, e As EventArgs) Handles btnAlbum.Click
        AbrirFromulario(Of frmAlbum)()
    End Sub

    Private Sub btnTemas_Click(sender As Object, e As EventArgs) Handles btnTemas.Click
        AbrirFromulario(Of frmTemas)()
    End Sub

    Private Sub btnReproductor_Click(sender As Object, e As EventArgs) Handles btnReproductor.Click
        AbrirFromulario(Of frmReproductor)()
    End Sub
End Class

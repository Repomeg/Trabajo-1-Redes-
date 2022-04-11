Imports Cliente.Servicios

Public Class Home
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnComprobar_Click(sender As Object, e As EventArgs) Handles btnComprobar.Click
        Dim servicio As Service1Client = New Service1Client()
        lblResultado.Text = servicio.ComprobarRut(Val(txtRut.Text), txtDigito.Text)
    End Sub

    Protected Sub btnDesplegar_Click(sender As Object, e As EventArgs) Handles btnDesplegar.Click
        Dim servicio As Service1Client = New Service1Client()
        Dim auxNombre() As String = servicio.MostrarNombre(txtNombre.Text)
        Dim nombres As String = ""
        Dim apellidos As String = ""

        For i = 0 To auxNombre.Length - 3
            nombres &= auxNombre(i)
            nombres &= " "
        Next
        lblNombres.Text = nombres

        For i = (auxNombre.Length - 2) To (auxNombre.Length - 1)
            apellidos &= auxNombre(i)
            apellidos &= " "
        Next
        lblApellidos.Text = apellidos
    End Sub
End Class
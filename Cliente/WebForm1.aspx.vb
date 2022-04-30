Imports Cliente.Servicios


Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub ButtonComprobar_Click(sender As Object, e As EventArgs) Handles ButtonComprobar.Click
        Dim servicios As ServicioSoapClient = New ServicioSoapClient()
        LabelResultado.Text = servicios.ComprobarRut(Val(TextBoxRut.Text), TextBoxDigito.Text)
    End Sub

    Protected Sub ButtonDesplegar_Click(sender As Object, e As EventArgs) Handles ButtonDesplegar.Click
        Dim servicios As ServicioSoapClient = New ServicioSoapClient()
        Dim listaNombre As List(Of String) = servicios.MostrarNombre(TextBoxNombre.Text)
        Dim auxNombre() As String = listaNombre.ToArray()
        Dim nombres As String = ""
        Dim apellidos As String = ""

        For i = 0 To auxNombre.Length - 3
            nombres &= auxNombre(i)
            nombres &= " "
        Next
        LabelNombres.Text = nombres

        For i = (auxNombre.Length - 2) To (auxNombre.Length - 1)
            apellidos &= auxNombre(i)
            apellidos &= " "
        Next
        LabelApellidos.Text = apellidos
    End Sub
End Class
Imports Cliente.Servicios


Public Class Principal
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub ButtonComprobar_Click(sender As Object, e As EventArgs) Handles ButtonComprobar.Click
        Dim servicios As ServicioSoapClient = New ServicioSoapClient()
        If servicios.ComprobarRut(Val(TextBoxRut.Text), TextBoxDigito.Text) Then
            LabelResultado.Text = "Rut Valido"
        Else
            LabelResultado.Text = "Rut No Valido"
        End If
    End Sub

    Protected Sub ButtonDesplegar_Click(sender As Object, e As EventArgs) Handles ButtonDesplegar.Click
        Dim servicios As ServicioSoapClient = New ServicioSoapClient()
        Dim listaNombre As List(Of String) = servicios.MostrarNombre(TextBoxNombre.Text)
        Dim auxNombre() As String = listaNombre.ToArray()
        Dim nombres As String = "Nombres: "
        Dim apellidos As String = "Apellidos: "
        If auxNombre.Length = 1 Then
            LabelNombres.Text = nombres + auxNombre(0)
            LabelApellidos.Text = ""
        Else
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
        End If

    End Sub
End Class
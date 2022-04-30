<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="Cliente.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1> Prueba metodo Comprobar Rut</h1>
            <asp:Label ID="LabelRut" runat="server" Text="Rut: "></asp:Label>
            <asp:TextBox ID="TextBoxRut" runat="server"></asp:TextBox>
            <hr />
            <asp:Label ID="LabelDigito" runat="server" Text="Digito: "></asp:Label>
            <asp:TextBox ID="TextBoxDigito" runat="server"></asp:TextBox>
            <hr />
            <asp:Button ID="ButtonComprobar" runat="server" Text="Comprobar" />
            <hr />
            <asp:Label ID="LabelResultadoComprobar" runat="server" Text="Resultado: "></asp:Label>
            <asp:Label ID="LabelResultado" runat="server"></asp:Label>
            <hr />
            <h1>Prueba Metodo Nombre</h1>
            <asp:Label ID="LabelNombreCompleto" runat="server" Text="Ingrese su nombre completo: "></asp:Label>
            <asp:TextBox ID="TextBoxNombre" runat="server" Width="440px"></asp:TextBox>
            <asp:Button ID="ButtonDesplegar" runat="server" Text="Desplegar" />
            <hr />
            <asp:Label ID="LabelResultadoNombres" runat="server" Text="Nombres: "></asp:Label>
            <asp:Label ID="LabelNombres" runat="server"></asp:Label>
            <hr />
            <asp:Label ID="LabelResultadoApellidos" runat="server" Text="Apellidos: "></asp:Label>
            <asp:Label ID="LabelApellidos" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>

<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Home.aspx.vb" Inherits="Cliente.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <h1> Prueba metodo comprobar rut</h1>
            <asp:Label ID="lblRut" Text="Rut: " runat="server" />
            <asp:TextBox ID="txtRut" runat="server" />
            <hr />
            <asp:Label ID="lblDigito" Text="Digito: " runat="server" />
            <asp:TextBox ID="txtDigito" runat="server" />
            <hr />
            <asp:Button ID="btnComprobar" Text="Comprobar" runat="server" />
            <hr />
            <asp:Label ID="lblResultado" runat="server" />
            <hr />
            <h1>Prueba metodo nombre</h1>
            <asp:Label ID="lblNombre" Text="Ingrese su nombre completo: " runat="server" />
            <asp:TextBox ID="txtNombre" runat="server" Width="440px" />
            <asp:Button ID="btnDesplegar" Text="Desplegar" runat="server" />
            <hr />
            <asp:Label ID="lblNombres" Text="Nombres: " runat="server" ></asp:Label>
            <hr />
            <asp:Label ID="lblApellidos" Text="Apellidos: " runat="server" ></asp:Label>

        </div>
    </form>
</body>
</html>

<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Principal.aspx.vb" Inherits="Cliente.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="en-us">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cliente SOAP</title>
    <link href="Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="sec2">
            <div class="container">
                <div class ="content">  
                    <h2>Metodo Comprobar Rut</h2>
                    <asp:TextBox ID="TextBoxRut" placeholder="Ingrese su Rut:" runat="server"></asp:TextBox><br />
                    <asp:TextBox ID="TextBoxDigito" placeholder="Ingrese su digito verificador:" runat="server"></asp:TextBox><br />
                    <asp:Button ID="ButtonComprobar" runat="server" Text="Comprobar" />
                    <asp:Label ID="LabelResultado" runat="server" CssClass="resultados"></asp:Label><br />

                    <h2>Metodo Desplegar Nombre</h2>
                    <asp:TextBox ID="TextBoxNombre" placeholder="Ingrese su nombre completo: " runat="server"></asp:TextBox><br />
                    <asp:Button ID="ButtonDesplegar" runat="server" Text="Desplegar" /><br /><br />
                    <asp:Label ID="LabelNombres" runat="server" CssClass="resultados"></asp:Label><br />
                    <asp:Label ID="LabelApellidos" runat="server" CssClass="resultados"></asp:Label>
                </div>
            </div>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Productores.Interface.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lvlId" runat="server" Text="Identificación"> </asp:Label>
        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Nombre"> </asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Teléfono"> </asp:Label>
        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Correo Electrónico"> </asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Fincas" OnClick="Button2_Click" />
        <br />
    

    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listarFincas.aspx.cs" Inherits="Productores.Interface.listarFincas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Listar Fincas</title>
</head>
<body>
    Listar Fincas
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" Width="630px">
        </asp:GridView>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Crear Productores" OnClick="Button1_Click" />
    
    </div>
    </form>
</body>
</html>

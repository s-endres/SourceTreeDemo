<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listarProductores.aspx.cs" Inherits="Productores.Interface.listarProductores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Listar productores</title>
</head>
<body>
    Productores
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="600px">
        </asp:GridView>
    
    </div>
        <asp:Button ID="Button1" runat="server" Text="Nueva Finca" OnClick="Button1_Click" />
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="agregarFinca.aspx.cs" Inherits="Productores.Interface.agregarFinca" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Agregar Finca</title>
</head>
<body>
    Agregar Finca!
    <form id="form1" runat="server">
    <div>
    

        <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox> <br />

        <asp:Label ID="lblArea" runat="server" Text="Area"></asp:Label>
        <asp:TextBox ID="txtArea" runat="server"></asp:TextBox> <br />

        <asp:Label ID="lblIdProductor" runat="server" Text="Id del Productor"></asp:Label>
        <asp:TextBox ID="txtIdProductor" runat="server"></asp:TextBox> 
        <br />
        <asp:Button ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Fincas" OnClick="Button2_Click" />
        <br />

    
    </div>
    </form>
</body>
</html>

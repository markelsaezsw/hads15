<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Inicio.aspx.vb" Inherits="WebApplication2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Correo:<br />
        <asp:TextBox ID="correo" runat="server"></asp:TextBox>
        <br />
        Contraseña:<br />
        <asp:TextBox ID="pass" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Login" />
        <br />
        <br />
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Timer ID="Timer1" runat="server" Interval="1000">
                </asp:Timer>
                <br />
                <br />
                <asp:Label ID="Label4" runat="server" Text="Alumnos:"></asp:Label>
                <br />
                <asp:Label ID="Label2" runat="server"></asp:Label>
                <br />
                <asp:Label ID="Label6" runat="server"></asp:Label>
                <br />
                <asp:Label ID="Label5" runat="server" Text="Profesores:"></asp:Label>
                <br />
                <asp:Label ID="Label3" runat="server"></asp:Label>
                <br />
                <asp:Label ID="Label7" runat="server"></asp:Label>
                <br />
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <a href="Registro.aspx">Registro</a><br />
    
    </div>
    </form>
</body>
</html>

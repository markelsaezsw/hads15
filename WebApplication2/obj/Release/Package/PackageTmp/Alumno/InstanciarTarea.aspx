<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="InstanciarTarea.aspx.vb" Inherits="WebApplication2.InstanciarTarea" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        ALUMNOS<br />
        INSTANCIAS TAREA GENÉRICA<br />
        <br />
        Usuario&nbsp;
        <asp:TextBox ID="Usuario" runat="server"></asp:TextBox>
        <br />
        <br />
        Tarea&nbsp;
        <asp:TextBox ID="Tarea" runat="server"></asp:TextBox>
        <br />
        <br />
        Horas Estimadas&nbsp;
        <asp:TextBox ID="HEstimadas" runat="server"></asp:TextBox>
        <br />
        <br />
        Horas Reales&nbsp;
        <asp:TextBox ID="HReales" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Crear Tarea" />
        <br />
        <br />
        <asp:Label ID="Mensaje" runat="server"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="Tabla" runat="server">
        </asp:GridView>
        <br />
        <br />
        <a href="TareasAlumno.aspx">Página Anterior</a></div>
    </form>
</body>
</html>

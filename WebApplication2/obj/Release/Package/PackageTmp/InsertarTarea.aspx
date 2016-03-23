<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="InsertarTarea.aspx.vb" Inherits="WebApplication2.InsertarTarea" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            PROFESOR<br />
            <br />
            Gestión de Tareas Genéricas</p>
        <p>
            &nbsp;</p>
        <p>
            Código:&nbsp;
            <asp:Label ID="Codigo" runat="server"></asp:Label>
        </p>
        <p>
            Descripción:
            <asp:Label ID="Descripcion" runat="server"></asp:Label>
        </p>
        <p>
            Asignatura:&nbsp;
            <asp:DropDownList ID="asignatura" runat="server">
            </asp:DropDownList>
        </p>
        <p>
            Horas estimadas: <asp:Label ID="Horas" runat="server"></asp:Label>
        </p>
        <p>
            Tipo tarea:&nbsp;
            <asp:DropDownList ID="Tipo" runat="server">
            </asp:DropDownList>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Añadir Tarea" />
        </p>
    </form>
</body>
</html>

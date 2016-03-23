<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TareasProfesor.aspx.vb" Inherits="WebApplication2.TareasProfesor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        PROFESOR<br />
        <br />
        Gestión de Tareas Genéricas<br />
        <br />
        Seleccionar Asignatura:</div>
        <asp:DropDownList ID="asignaturas" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Insertar Nueva Tarea" />
        <br />
        <br />
        <br />
        Cierra Sesión</form>
</body>
</html>

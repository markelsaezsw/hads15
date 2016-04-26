<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Profesor.aspx.vb" Inherits="WebApplication2.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Gestión Web de Tareas-Dedicación<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Profesores<br />
        <br />
        Asignaturas<br />
        <br />
        <a href="TareasProfesor.aspx">Tareas</a><br />
        <br />
        Grupos<br />
        <br />
        <a href="ImportarTareasXMLDocument.aspx">Importar y XMLDocument</a><br />
        <br />
        <a href="../Vadillo/ExportarTareasXML.aspx">Exportar</a><br />
        <br />
        <a href="../Vadillo/coordinador.aspx">Coordinar</a><br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Logout" />
        </div>
    </form>
</body>
</html>

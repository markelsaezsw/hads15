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
            <asp:TextBox ID="Codigo" runat="server"></asp:TextBox>
        </p>
        <p>
            Descripción:
            <asp:TextBox ID="Descripcion" runat="server"></asp:TextBox>
        </p>
        <p>
            Asignatura:&nbsp;
            <asp:DropDownList ID="asignatura" runat="server" DataSourceID="SqlDataSource1" DataTextField="codigoasig" DataValueField="codigoasig">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Hads15ConnectionString %>" SelectCommand="SELECT GruposClase.codigoasig FROM ProfesoresGrupo INNER JOIN GruposClase ON ProfesoresGrupo.codigogrupo = GruposClase.codigo WHERE ProfesoresGrupo.email = @email">
                <SelectParameters>
                    <asp:SessionParameter Name="email" SessionField="email" />
                </SelectParameters>
            </asp:SqlDataSource>
        </p>
        <p>
            Horas estimadas: 
            <asp:TextBox ID="Horas" runat="server"></asp:TextBox>
        </p>
        <p>
            Tipo tarea:&nbsp;
            <asp:DropDownList ID="Tipo" runat="server">
                <asp:ListItem>Examen</asp:ListItem>
                <asp:ListItem>Trabajo</asp:ListItem>
                <asp:ListItem>Laboratorio</asp:ListItem>
                <asp:ListItem>Ejercicio</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Añadir Tarea" />
        </p>
        <p>
            <asp:Label ID="Mensaje" runat="server"></asp:Label>
        </p>
        <p>
            <a href="TareasProfesor.aspx">Ver Tareas</a></p>
    </form>
</body>
</html>

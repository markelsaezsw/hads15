<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Registro.aspx.vb" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Email:<br />
        <asp:TextBox ID="email" runat="server" Height="26px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="email" ErrorMessage="¡Escribe un email correcto!" ValidationExpression="^[a-zA-Z]+\d{3}@ikasle.ehu(.es|.eus)"></asp:RegularExpressionValidator>
        <br />
        <br />
        Nombre y apellidos:<br />
        <asp:TextBox ID="nombre" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="nombre" ErrorMessage="¡Escribe tu nombre y apellidos!"></asp:RequiredFieldValidator>
        <br />
        <br />
        DNI:<br />
        <asp:TextBox ID="dni" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="dni" ErrorMessage="¡Escribe un DNI correcto! " ValidationExpression="(\d{8})"></asp:RegularExpressionValidator>
        <br />
        <br />
        Contraseña:<br />
        <asp:TextBox ID="pass" runat="server" Width="135px" TextMode="Password"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="pass" ErrorMessage="¡Introduce una contraseña correcta! (Al menos 6 caracteres y al menos 1 número)" ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$"></asp:RegularExpressionValidator>
        <br />
        <br />
        ¿No se te ocurre una buena contraseña? ¡Genera una!<br />
        <asp:Button ID="Button2" runat="server" CausesValidation="False" Text="Generar" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server">l</asp:Label>
        <br />
        <br />
        Repetir contraseña:<br />
        <asp:TextBox ID="pass2" runat="server" TextMode="Password"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="pass" ControlToValidate="pass2" ErrorMessage="¡Vuelve a introducir la contraseña!"></asp:CompareValidator>
        <br />
        <br />
        Tipo de Usuario:<asp:RadioButtonList ID="Tipo" runat="server">
            <asp:ListItem Selected="True">Alumno</asp:ListItem>
            <asp:ListItem>Profesor</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        Pregunta secreta:<br />
        <asp:TextBox ID="pregunta" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="pregunta" ErrorMessage="¡Escribe una pregunta secreta!"></asp:RequiredFieldValidator>
        <br />
        <br />
        Respuesta a la pregunta secreta:<br />
        <asp:TextBox ID="respuesta" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="respuesta" ErrorMessage="¡Escribe una respuesta!"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Registrar" />
        <br />
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <br />
        <a href="Inicio.aspx">Inicio</a></form>
</body>
</html>

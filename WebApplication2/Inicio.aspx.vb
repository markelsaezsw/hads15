Imports WebApplication2.accesoDatosSQL

Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = conectar()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As String
        Dim wrapper As New encriptar("contrasenamuycomplicada")
        Dim cipherText As String = wrapper.EncryptData(pass.Text)

        result = contar(correo.Text, cipherText)

        If result = "null" Then
            Label1.Text = result
        Else
            Label1.Text = result
            Session("email") = correo.Text

            If result = "P" Then
                System.Web.Security.FormsAuthentication.SetAuthCookie("Profesor", False)
                Response.Redirect("http://localhost:50943/Profesor/Profesor.aspx")
            ElseIf result = "A" Then
                System.Web.Security.FormsAuthentication.SetAuthCookie("Alumno", False)
                Response.Redirect("http://localhost:50943/Alumno/Alumno.aspx")
            ElseIf result = "V" Then
                System.Web.Security.FormsAuthentication.SetAuthCookie("Vadillo", False)
                Response.Redirect("http://localhost:50943/Profesor/Profesor.aspx")
            End If

        End If
    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub
End Class
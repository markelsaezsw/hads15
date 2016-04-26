Imports WebApplication2.accesoDatosSQL

Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = conectar()
        Label2.Text = Application("alumnos").ToString
        Label3.Text = Application("profesores").ToString
        Label6.Text = Application("lalumnos")
        Label7.Text = Application("lprofesores")

      
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As String
        Dim wrapper As New encriptar("contrasenamuycomplicada")
        Dim cipherText As String = wrapper.EncryptData(pass.Text)

        result = contar(correo.Text, pass.Text)

        If result = "null" Then
            Label1.Text = result
        Else
            Label1.Text = result
            Session("email") = correo.Text
            Dim mmail = Session("email")
            If result = "P" Then
                System.Web.Security.FormsAuthentication.SetAuthCookie("Profesor", False)

                Application.Lock()

                Application("profesores") = Application("profesores") + 1
                Application("lprofesores") = Application("lprofesores") & mmail & " "
                Application.UnLock()

                Response.Redirect("~/Profesor/Profesor.aspx")
            ElseIf result = "A" Then
                System.Web.Security.FormsAuthentication.SetAuthCookie("Alumno", False)

                Application.Lock()

                Application("alumnos") = Application("alumnos") + 1
                Application("lalumnos") = Application("lalumnos") & mmail & " "
                Application.UnLock()

                Response.Redirect("~/Alumno/Alumno.aspx")
            ElseIf result = "V" Then
                System.Web.Security.FormsAuthentication.SetAuthCookie("Vadillo", False)
                Application.Lock()

                Application("profesores") = Application("profesores") + 1
                Application("lprofesores") = Application("lprofesores") & mmail & " "
                Application.UnLock()
                Response.Redirect("~/Profesor/Profesor.aspx")
            End If

        End If
    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub

    Protected Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = Application("alumnos").ToString
        Label3.Text = Application("profesores").ToString
        Label6.Text = Application("lalumnos")
        Label7.Text = Application("lprofesores")
    End Sub
End Class
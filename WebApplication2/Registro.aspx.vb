Imports WebApplication2.accesoDatosSQL




Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim result As String
        result = conectar()
        Label1.Text = result
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim comp As New matriculas.Matriculas

        If comp.comprobar(email.Text).ToString = "SI" Then
            Dim NumConf As Integer
            Randomize()
            NumConf = CLng(Rnd() * 9000000) + 1000000

            Dim wrapper As New encriptar("contrasenamuycomplicada")
            Dim cipherText As String = wrapper.EncryptData(pass.Text)
            Dim tip As String

            If Tipo.SelectedIndex = 0 Then
                tip = "A"
            Else
                tip = "P"

            End If
            Label1.Text = insertar(email.Text, nombre.Text, pregunta.Text, respuesta.Text, dni.Text, 1, tip, Tipo.Text, cipherText)
            Dim enlace As String
            enlace = "http://localhost:50943/Confirmar.aspx?mbr=" & email.Text & "&numconf=" & NumConf

            Literal1.Text = "Clicka <a href=" & enlace & "> AQUI <a/> para verificar la cuenta"
        Else
            Label2.Text = "El correo no está matriculado."

        End If

    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub

  
    Protected Sub Tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tipo.SelectedIndexChanged

    End Sub

    Protected Sub dni_TextChanged(sender As Object, e As EventArgs) Handles dni.TextChanged

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim gen As New generarpass
        Label3.Text = gen.randompass.ToString

    End Sub
End Class
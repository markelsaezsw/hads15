﻿Imports WebApplication2.accesoDatosSQL

Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim result As String
        result = conectar()
        Label1.Text = result
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NumConf As Integer
        Randomize()
        NumConf = CLng(Rnd() * 9000000) + 1000000
        Label1.Text = insertar(email.Text, nombre.Text, dni.Text, pass.Text, pregunta.Text, respuesta.Text, NumConf)
        Dim enlace As String
        enlace = "http://localhost:50943/Confirmar.aspx?mbr=" & email.Text & "&numconf=" & NumConf

        Literal1.Text = "Clicka <a href=" & enlace & "> AQUI <a/> para verificar la cuenta"

    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub

  
    Protected Sub Tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tipo.SelectedIndexChanged

    End Sub
End Class
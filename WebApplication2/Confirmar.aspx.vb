Imports WebApplication2.accesoDatosSQL

Public Class WebForm3
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conectar()
        Dim correo As String
        Dim num As Integer
        correo = Request.QueryString("mbr")
        num = Request.QueryString("NumConf")
        Label1.Text = verificar(correo, num)
    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub


End Class
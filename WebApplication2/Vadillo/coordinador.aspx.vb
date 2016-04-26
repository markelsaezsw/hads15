Imports WebApplication2.accesoDatosSQL
Imports System.Data.OleDb
Imports System.Xml
Imports System.Data.SqlClient


Public Class coordinador
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conectar()
        Dim med As New mediadedicacion
        If med.media(DropDownList1.SelectedValue).ToString = "Null" Then
            Label1.Text = "0"
        Else
            Label1.Text = med.media(DropDownList1.SelectedValue).ToString
        End If


    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Dim med As New mediadedicacion
        If med.media(DropDownList1.SelectedValue).ToString = "Null" Then
            Label1.Text = "0"
        Else
            Label1.Text = med.media(DropDownList1.SelectedValue).ToString
        End If

    End Sub

    Protected Sub SqlDataSource1_Selecting(sender As Object, e As SqlDataSourceSelectingEventArgs) Handles SqlDataSource1.Selecting

    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub

   
End Class
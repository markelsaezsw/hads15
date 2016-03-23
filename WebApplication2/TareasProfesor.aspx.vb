Imports WebApplication2.accesoDatosSQL
Imports System.Data.OleDb

Public Class TareasProfesor
    Inherits System.Web.UI.Page
    'Dim conClsf As OleDbConnection = New OleDbConnection("Provider=SQLNCLI11;Password=MJimenez035;User ID=hads15@hads15;Initial Catalog=Hads15;Data Source=tcp:hads15.database.windows.net;")

    Dim dapMbrs As New OleDbDataAdapter
    Dim dstMbrs As New DataSet
    Dim tblMbrs As New DataTable
    Dim rowMbrs As DataRow


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conectar()
    End Sub


    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("InsertarTarea.aspx")
    End Sub


    
    Protected Sub SqlDataSource2_Selecting(sender As Object, e As SqlDataSourceSelectingEventArgs) Handles SqlDataSource2.Selecting
        Dim email As String = Session("email")
        SqlDataSource2.SelectCommand = "SELECT codigoasig FROM GruposClase INNER JOIN ProfesoresGrupo ON GruposClase.codigo = ProfesoresGrupo.codigogrupo WHERE (email = ' " & email & " ')"

    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub


End Class
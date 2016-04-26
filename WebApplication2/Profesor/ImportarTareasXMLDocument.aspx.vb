Imports WebApplication2.accesoDatosSQL

Imports System.Xml
Imports System.Data.SqlClient

Public Class ImportarTareasXMLDocument
    Inherits System.Web.UI.Page
    'Dim conClsf As OleDbConnection = New OleDbConnection("Provider=SQLNCLI11;Password=MJimenez035;User ID=hads15@hads15;Initial Catalog=Hads15;Data Source=tcp:hads15.database.windows.net;")


    Dim dstMbrs As New DataSet
    Dim tblMbrs As New DataTable
    Dim rowMbrs As DataRow


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conectar()


    End Sub


    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim docxml As New XmlDocument
        Dim fileName = Server.MapPath("~/App_Data/" & DropDownList1.SelectedValue & ".xml")
        docxml.Load(fileName)
        Dim LasTareas As XmlNodeList
        LasTareas = docxml.GetElementsByTagName("tarea")

        Dim dapMbrs As New SqlDataAdapter
        dapMbrs = New SqlDataAdapter("select * from TareasGenericas", getconexion())
        Dim bldMbrs As New SqlCommandBuilder(dapMbrs)
        dapMbrs.Fill(dstMbrs, "LasTareas")
        tblMbrs = dstMbrs.Tables("LasTareas")

        Dim i As Integer
        For i = 0 To LasTareas.Count - 1
            Dim rowMbrs As DataRow = tblMbrs.NewRow()
            rowMbrs("Codigo") = LasTareas(i).ChildNodes(0).ChildNodes(0).Value
            rowMbrs("Descripcion") = LasTareas(i).ChildNodes(1).ChildNodes(0).Value
            rowMbrs("CodAsig") = DropDownList1.SelectedValue
            rowMbrs("HEstimadas") = CInt(LasTareas(i).ChildNodes(2).ChildNodes(0).Value)
            rowMbrs("Explotacion") = LasTareas(i).ChildNodes(3).ChildNodes(0).Value
            rowMbrs("TipoTarea") = LasTareas(i).ChildNodes(4).ChildNodes(0).Value
            tblMbrs.Rows.Add(rowMbrs)
        Next
        dapMbrs.Update(dstMbrs, "LasTareas")
        Label1.Text = "Importado!"

    End Sub



    Protected Sub SqlDataSource2_Selecting(sender As Object, e As SqlDataSourceSelectingEventArgs) Handles SqlDataSource2.Selecting
        Dim email As String = Session("email")
        SqlDataSource2.SelectCommand = "SELECT codigoasig FROM GruposClase INNER JOIN ProfesoresGrupo ON GruposClase.codigo = ProfesoresGrupo.codigogrupo WHERE (email = ' " & email & " ')"

    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub


    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Try
            Dim filename = "App_Data/" & DropDownList1.SelectedValue & ".xml"
            Xml1.DocumentSource = Server.MapPath(filename)
            Xml1.TransformSource = Server.MapPath("App_Data/XSLTFile.xsl")
        Catch fileNotFound As System.IO.FileNotFoundException
            Response.Redirect("ImportarTareasXMLDocument.aspx")
            Label1.Text = "El .XML no ha sido encontrado"
        End Try


    End Sub

End Class
Imports WebApplication2.accesoDatosSQL

Imports System.Data.SqlClient

Public Class InsertarTarea
    Inherits System.Web.UI.Page

    'Dim conClsf As OleDbConnection = New OleDbConnection("Provider=SQLNCLI11;Password=MJimenez035;User ID=hads15@hads15;Initial Catalog=Hads15;Data Source=tcp:hads15.database.windows.net;")

    Dim dapMbrs As New SqlDataAdapter
    Dim dstMbrs As New DataSet
    Dim tblMbrs As New DataTable
    Dim rowMbrs As DataRow

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conectar()
        Mensaje.Text = Session("email")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            dapMbrs = New SqlDataAdapter("select * from TareasGenericas", getconexion())
            Dim bldMbrs As New SqlCommandBuilder(dapMbrs)
            dapMbrs.Fill(dstMbrs, "TareasGenericas")
            tblMbrs = dstMbrs.Tables("TareasGenericas")
            rowMbrs = tblMbrs.NewRow
            rowMbrs("Codigo") = Codigo.Text
            rowMbrs("Descripcion") = Descripcion.Text
            rowMbrs("CodAsig") = asignatura.SelectedItem.Text
            rowMbrs("HEstimadas") = Horas.Text
            rowMbrs("Explotacion") = 0
            rowMbrs("TipoTarea") = Tipo.SelectedItem.Text
            tblMbrs.Rows.Add(rowMbrs)
            dapMbrs.Update(dstMbrs, "TareasGenericas")
        Catch ex As Exception
            Mensaje.Text = ex.Message
        End Try
    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub

End Class
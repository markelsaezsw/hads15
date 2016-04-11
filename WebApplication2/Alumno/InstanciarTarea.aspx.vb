Imports System.Data.SqlClient
Imports WebApplication2.accesoDatosSQL

Public Class InstanciarTarea
    Inherits System.Web.UI.Page

    Dim dapMbrs As New SqlDataAdapter
    Dim dstMbrs As New DataSet
    Dim tblMbrs As New DataTable
    Dim rowMbrs As DataRow

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conectar()
        Dim email As String = Session("email")
        dapMbrs = New SqlDataAdapter("Select * from EstudiantesTareas Where EstudiantesTareas.Email = '" & email & "' ", getconexion())
        Dim bldMbrs As New SqlCommandBuilder(dapMbrs)
        dapMbrs.Fill(dstMbrs, "tareasinstanciadas")

        Usuario.Text = email
        Tarea.Text = Request.QueryString("codigo")

        Tabla.DataSource = dstMbrs.Tables("tareasinstanciadas")
        Tabla.DataBind()

        Session("adaptador") = dapMbrs
        Session("dataset") = dstMbrs


    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim email As String = Session("email")
        Dim codigo As String = Request.QueryString("codigo")
        Dim cant As Integer = estaInstanciada(email, codigo)

        If cant = 0 Then
            Try
                dstMbrs = Session("dataset")
                tblMbrs = dstMbrs.Tables("tareasinstanciadas")
                dapMbrs = Session("adaptador")

                rowMbrs = tblMbrs.NewRow
                rowMbrs("Email") = Usuario.Text
                rowMbrs("CodTarea") = Tarea.Text
                rowMbrs("HEstimadas") = Integer.Parse(HEstimadas.Text)
                rowMbrs("HReales") = Integer.Parse(HReales.Text)

                tblMbrs.Rows.Add(rowMbrs)


                dapMbrs.Update(dstMbrs, "tareasinstanciadas")
                dstMbrs.AcceptChanges()
                Mensaje.Text = "Tarea instanciada correctamente"

            Catch ex As Exception
                Mensaje.Text = ex.Message
                tblMbrs.Rows.Remove(rowMbrs)
            End Try

            Tabla.DataSource = tblMbrs
            Tabla.DataBind()
            Session("dataset") = dstMbrs
            Session("tabla") = tblMbrs

        Else
            Mensaje.Text = "Esta tarea ya estaba instanciada"
        End If

    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub

End Class
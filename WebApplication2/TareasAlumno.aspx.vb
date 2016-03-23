Imports System.Data.SqlClient
Imports WebApplication2.accesoDatosSQL


Public Class TareasAlumno
    Inherits System.Web.UI.Page

    Dim dapMbrs As New SqlDataAdapter
    Dim dstMbrs As New DataSet
    Dim tblMbrs As New DataTable
    Dim rowMbrs As DataRow

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conectar()

        If Not Page.IsPostBack Then
            
            Dim email As String = Session("email")

            dapMbrs = New SqlDataAdapter("select GruposClase.codigoasig from GruposClase, EstudiantesGrupo where EstudiantesGrupo.Grupo=GruposClase.codigo and EstudiantesGrupo.email='" & email & "'", getconexion())
            dapMbrs.Fill(dstMbrs, "AsignaturasAlumno")
            asignaturas.DataTextField = "codigoasig"
            asignaturas.DataSource = dstMbrs.Tables("AsignaturasAlumno")
            asignaturas.DataBind()

        End If
    End Sub

   
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim asig As String = asignaturas.SelectedValue

        dapMbrs = New SqlDataAdapter("select TareasGenericas.Codigo, TareasGenericas.Descripcion, TareasGenericas.HEstimadas, TareasGenericas.TipoTarea  from TareasGenericas where TareasGenericas.CodAsig='" & asig & "'", getconexion())
        dapMbrs.Fill(dstMbrs, "TareasAsignatura")
        tblMbrs = dstMbrs.Tables("TareasAsignatura")
        Session("tareas") = tblMbrs
        Tabla.DataSource = tblMbrs
        Tabla.DataBind()
        Tabla.AllowSorting = True
       
    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub

    Protected Sub Opciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Opciones.SelectedIndexChanged

        'No lo consigo

    End Sub

    Protected Sub Tabla_Sorting(sender As Object, e As GridViewSortEventArgs) Handles Tabla.Sorting
        tblMbrs = Session("tareas")
        Dim vista As DataView = tblMbrs.DefaultView
        vista.Sort = e.SortExpression
        Tabla.DataSource = vista
        Tabla.DataBind()

        'No lo hace

    End Sub

    Protected Sub Tabla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tabla.SelectedIndexChanged
        Response.Redirect("InstanciarTarea.aspx?codigo=" & Tabla.SelectedRow().Cells(1).Text)

    End Sub
  
End Class





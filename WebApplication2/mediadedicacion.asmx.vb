Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports WebApplication2.accesoDatosSQL
Imports System.Data.OleDb
Imports System.Data.SqlClient

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class mediadedicacion
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function media(x As String) As String
        Dim cmd As New SqlCommand("Select AVG(HReales) From EstudiantesTareas inner join TareasGenericas ON EstudiantesTareas.CodTarea= TareasGenericas.Codigo WHERE (TareasGenericas.CodAsig= '" & x & "')", getconexion())
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim result As String
        result = dr.GetSqlValue(0).ToString()
        dr.Close()
        Return result



    End Function

End Class
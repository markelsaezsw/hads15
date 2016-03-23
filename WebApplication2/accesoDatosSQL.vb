Imports System.Data.SqlClient

Public Class accesoDatosSQL

    Private Shared conexion As New SqlConnection
    Private Shared comando As New SqlCommand

    Public Shared Function conectar() As String
        Try
           
            'conexion.ConnectionString = "Data Source=158.227.106.20;Initial Catalog=HADS15-usuarios;User ID=HADS15;Password=buitre"
            conexion.ConnectionString = "Data Source=tcp:hads15.database.windows.net,1433;Initial Catalog=Hads15;Persist Security Info=True;User ID=hads15@hads15;Password=MJimenez035"
            conexion.Open()

        Catch ex As Exception
            Return "ERROR DE CONEXIÓN: " + ex.Message
        End Try
        Return "CONEXION OK"
    End Function

    Public Shared Function getconexion() As SqlConnection
        Return conexion
    End Function

    Public Shared Sub cerrarconexion()
        conexion.Close()
    End Sub

    Public Shared Function insertar(ByVal email As String, nombre As String, dni As String, contra As String, pregunta As String, respuesta As String, codigo As Integer) As String

        Dim st = "insert into Users (Correo,nombreyapellidos,DNI,Password,Pregunta,Respuesta,Confirmado,Codigo) values ('" & email & "', '" & nombre & "', '" & dni & "', '" & contra & "', '" & pregunta & "', '" & respuesta & "', '" & 0 & "', '" & codigo & "')"

        Dim numregs As Integer
        comando = New SqlCommand(st, conexion)
        Try
            numregs = comando.ExecuteNonQuery
        Catch ex As Exception
            Return ex.Message
        End Try
        Return (numregs & " registro(s) insertado(s) en la BD")
    End Function



    Public Shared Function contar(ByVal correo As String, ByVal pass As String) As String

        Dim st = "select count(*) from Usuarios where email = '" & correo & "' AND pass = '" & pass & "' AND confirmado = '" & 1 & "' "
        comando = New SqlCommand(st, conexion)

        Dim cant As Integer = Convert.ToInt32(comando.ExecuteScalar())
        If cant = 1 Then
            If correo.Contains("ikasle") Then
                Return "A"
            Else
                Return "P"
            End If
        Else
            Return "null"
        End If

    End Function

    Public Shared Function verificar(ByVal correo As String, ByVal num As Integer) As String
        Dim st = "select count(*) from Users Where Correo = '" & correo & "' AND Codigo = '" & num & "' "
        comando = New SqlCommand(st, conexion)
        Dim cant As Integer = Convert.ToInt32(comando.ExecuteScalar())
        If cant = 1 Then
            Dim verf = "UPDATE Users SET Confirmado = '" & True & "' Where Correo = '" & correo & "' "
            comando = New SqlCommand(verf, conexion)
            comando.ExecuteNonQuery()
            Return "Correo Verificado"
        Else
            Return "No se ha podido verificar porque el codigo no coincide"
        End If

    End Function

    Public Shared Function estaInstanciada(ByVal email As String, ByVal codigo As String) As Integer
        Dim st = "select count (*) from EstudiantesTareas Where EstudiantesTareas.Email = '" & email & "' AND EstudiantesTareas.CodTarea= '" & codigo & "'"
        comando = New SqlCommand(st, conexion)
        Dim cant As Integer = Convert.ToInt32(comando.ExecuteScalar)
        Return cant
    End Function




End Class




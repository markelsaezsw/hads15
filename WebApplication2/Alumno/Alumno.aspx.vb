Public Class Alumno
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Lock()

        Dim email As String = Session("email")
        If Application("alumnos") > 0 Then
            Application("alumnos") = Application("alumnos") - 1
            Application("lalumnos") = Replace(Application("lalumnos"), email & " ", "")
        End If


        Application.UnLock()




        Session.Clear()
    End Sub
End Class
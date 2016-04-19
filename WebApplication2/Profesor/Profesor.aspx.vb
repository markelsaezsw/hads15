Public Class WebForm4
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Lock()

        Dim email As String = Session("email")
        If Application("profesores") > 0 Then
            Application("profesores") = Application("profesores") - 1
            Application("lprofesores") = Replace(Application("lprofesores"), email & " ", "")
        End If


        Application.UnLock()




        Session.Clear()
    End Sub
End Class
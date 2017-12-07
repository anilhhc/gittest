Imports betatesting.hhcTableAdapters
Public Class stockistprofile
    Inherits System.Web.UI.MasterPage
    Dim DsCPIP As New hhcControlPanelIPStatsTableAdapter
    Dim Permissions As String
    Dim i As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            lblname.Text = Session("hsfullname")
        End If

    End Sub

    Protected Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Response.Redirect("~/admin-stockist/profile/")
    End Sub

    Protected Sub btnchangepassword_Click(sender As Object, e As EventArgs) Handles btnchangepassword.Click
        Response.Redirect("~/admin-stockist/change-password/")
    End Sub

    Protected Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        DsCPIP.updatecplogout(Now(), DsCPIP.getcpipldbyloginid(Session("name")))
        FormsAuthentication.SignOut()
        Session.Abandon()

        ' clear authentication cookie
        Dim cookie1 As New HttpCookie(FormsAuthentication.FormsCookieName, "")
        cookie1.Expires = DateTime.Now.AddYears(-1)
        Response.Cookies.Add(cookie1)
        Response.Redirect("~/admin-stockist/sign-in/")
    End Sub
End Class
Imports betatesting.DataSetCareTableAdapters
Imports System.Data.SqlClient
Imports System.IO
Imports betatesting.newseventsTableAdapters
Imports betatesting.HeaderBannerTableAdapters
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web.UI.WebControls
Public Class second_opinion_profile
    Inherits System.Web.UI.MasterPage
    Dim ObjCPIP As New ControlPanelIPStatsTableAdapter

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        ObjCPIP.UpdateCPLogout(Now(), ObjCPIP.GetCpIpIdbyLoginid(HttpContext.Current.User.Identity.Name))
        FormsAuthentication.SignOut()
        Session.Abandon()

        ' clear authentication cookie
        Dim cookie1 As New HttpCookie(FormsAuthentication.FormsCookieName, "")
        cookie1.Expires = DateTime.Now.AddYears(-1)
        Response.Cookies.Add(cookie1)
        Response.Redirect("~/second-opinion/sign-in/")
    End Sub
End Class
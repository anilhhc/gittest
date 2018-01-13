Imports betatesting.DataSetCareTableAdapters
Imports betatesting.HeaderBannerTableAdapters

Public Class second_opinion_signin
    Inherits System.Web.UI.UserControl
    Dim ObjUsers As New USERSTableAdapter
    Dim ObjCPIP As New ControlPanelIPStatsTableAdapter
    Dim DsUsers As New PrevilegecardloginTableAdapter
    Dim Permissions As String

    Dim i As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim dt As New Data.DataTable
        Dim dr As Data.DataRow
        dt = DsUsers.GetDataByIdPwd(TxtEmailId.Text, txtpassword.Text)

        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            Session("UserId") = dr("PrevilegecardloginId")

            HttpContext.Current.Session.Add("UserName", dr("FirstName") & dr("LastName"))
            Session.Timeout = 3600

            'FormsAuthentication.Initialize()
            'FormsAuthentication.HashPasswordForStoringInConfigFile(TxtPwd.Text, "sha1")
            Dim ticket As New FormsAuthenticationTicket(1, TxtEmailId.Text, DateTime.Now, DateTime.Now.AddMinutes(180), False, "RegisteredMember")
            Dim hash As String = FormsAuthentication.Encrypt(ticket)
            Dim cookie As New HttpCookie(FormsAuthentication.FormsCookieName, hash)
            Response.Cookies.Add(cookie)
            ObjCPIP.Insert(Request.ServerVariables("REMOTE_ADDR"), Now(), Now(), TxtEmailId.Text)
            Response.Redirect("~/second-opinion/profile/")
        Else
            LblMsg.Text = "Invalid User ID / Password, Please Try Again !!"
            Exit Sub
        End If


    End Sub
End Class
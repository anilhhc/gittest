Imports betatesting.DataSetCareTableAdapters
Imports System.Data.SqlClient
Public Class second_opinion_forgot_password
    Inherits System.Web.UI.UserControl
    Dim dsuser As New PrevilegecardloginTableAdapter
    Dim CF As New CommonFunctions

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub ImgSubmit_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgSubmit.Click
        If dsuser.CheckPrimaryCount(TxtEmail.Text) > 0 Then
            Dim mail As New CommonFunctions
            Dim pwd = dsuser.getpasswordbyemailid(TxtEmail.Text)
            Dim msg = "<html><strong>Dear Customer,</strong><p></p>In response to your request to recover your password, KimsHospitals.com has reset your password." _
                    & "<p>Your New Password is: " & pwd & "</p><p>Click hear to login www.kimshospitals.com/second-opinion/sign-in/ </p><p>Best Regards,<br>Kims Hospitals.</p></html>"

            mail.SendMail(msg, TxtEmail.Text, "Your Second Opinion  login in details")
            Panel1.Visible = False
            Label1.Visible = True
        Else
            Panel1.Visible = False
            Label1.Visible = True
            Label1.Text = "The E-Mail Address  [" & TxtEmail.Text & "]  Doesn't Exist"
        End If
    End Sub
End Class
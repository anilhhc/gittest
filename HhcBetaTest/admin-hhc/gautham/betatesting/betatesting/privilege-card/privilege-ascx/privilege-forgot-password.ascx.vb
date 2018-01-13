Imports betatesting.DataSetCareTableAdapters
Imports System.Data.SqlClient

Public Class privilege_forgot_password
    Inherits System.Web.UI.UserControl
    Dim dsuser As New PrevilegecardloginTableAdapter
    Dim CF As New CommonFunctions
    Dim Message, subject, sendto As String
    Protected Sub ImgSubmit_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgSubmit.Click
        If dsuser.CheckPrimaryCount(TxtEmail.Text) > 0 Then
            Dim mail As New CommonFunctions
            Dim pwd = dsuser.getpasswordbyemailid(TxtEmail.Text)
            Dim firstname = dsuser.getfirstnamebyemailid(TxtEmail.Text)
            Dim lastname = dsuser.Getlastnamebyemailid(TxtEmail.Text)
            Dim mobile = dsuser.getmobilenumberbyemailid(TxtEmail.Text)

            Dim mobilenumber As String



            mobilenumber = 91 & mobile
            Message = ""
            If TxtEmail.Text <> "" Then
                Message = "<font face='Verdana' size='2'>Dear " & firstname & lastname & ", <br /><br />" & _
                        "<br /><br /></font>" & _
                        " Welcome to KIMS Hospitals Network. Following are the details to access the .<br /><br />" & _
                        "<br />URL '" & System.Configuration.ConfigurationManager.AppSettings("WebsiteURL") & "privilege-card/sign-in/'<br />" & _
                        "<br />User Name(Login Id) : " & TxtEmail.Text & _
                        "<br />Password : " & pwd & _
                        "<br /><br /><font face='Verdana' size='2'>Thanks & Regards,<br />" & _
                        "Website Support Team,<br />" & _
                        "KIMS Hospitals. </font>"

                subject = "Password Details -- www.KimsHospitals.com"
                sendto = TxtEmail.Text

                Dim CF As New CommonFunctions
                CF.SendMail(Message, sendto, subject)
                Panel1.Visible = False
                Label1.Visible = True
            End If
        Else
            Panel1.Visible = False
            Label1.Visible = True
            Label1.Text = "The E-Mail Address  [" & TxtEmail.Text & "]  Doesn't Exist"
        End If




      
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

End Class
Imports betatesting.DataSetCareTableAdapters
Imports betatesting.HeaderBannerTableAdapters
Imports System.Data.SqlClient
Imports System.IO
Imports betatesting.newseventsTableAdapters
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web.UI.WebControls
Public Class add_details
    Inherits System.Web.UI.UserControl
    Dim ObjCPIP As New ControlPanelIPStatsTableAdapter
    Dim DsIdentity As New CurrentIdentity
    Dim Dsspec As New SPECIALIZATIONTableAdapter
    Dim dspecilisation As New SPECIALITIESTableAdapter
    Dim dsfamily As New SecondopinionmembersdetailsTableAdapter
    Dim dsrelation As New CORPRELATIONSHIPTableAdapter
    Dim dssex As New GenderTableAdapter
    Dim dsgender As New GenderTableAdapter
    Dim DoctorId, i As Integer
    Dim PhotoName As String
    Dim message, subject, sendto, ReportName, ThumbnailImageName As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ddlrelation.DataSource = dsrelation.GetData()
            ddlrelation.DataTextField = "PATIENTSTATUSNAME"
            ddlrelation.DataValueField = "CORPRELATIONSHIPID"
            ddlrelation.DataBind()

            DDLSpecialisation.DataSource = Dsspec.GetAllActiveData()
            DDLSpecialisation.DataValueField = "SPECIALIZATIONID"
            DDLSpecialisation.DataTextField = "SPECIALIZATIONNAME"
            DDLSpecialisation.DataBind()


            ddlgender.DataSource = dssex.GetData()
            ddlgender.DataValueField = "GenderID"
            ddlgender.DataTextField = "GenderNAME"
            ddlgender.DataBind()



            'ddlfamilmembernames.DataSource = dsfamily.GetDataBysessionid(Session("UserId"))
            'ddlfamilmembernames.DataTextField = "FirstName"
            'ddlfamilmembernames.DataValueField = "PrevilegecardFamilymembersdetailsID"
            'ddlfamilmembernames.DataBind()

            gvprofile.DataSource = dsfamily.GetDataBysessionid(Session("UserId"))
            gvprofile.DataBind()
            If IsNothing(Session("UserId")) Then
                Response.Redirect("~/second-opinion/sign-in/", True)
            End If

            'If CInt(dsfamily.getcountofallfamilymemberbysessionid(Session("UserId")) < 1) Then
            '    trsamedetails.Visible = False
            'End If

        End If

    End Sub
    Private Function GenerateRandomCode() As String
        Dim Random As New Random
        Dim s As String
        s = ""
        Dim i As Integer
        For i = 0 To 6
            s = String.Concat(s, Random.Next(10).ToString())
        Next i
        Return s
    End Function
    Protected Sub ImgBtnLogOut_Click(sender As Object, e As ImageClickEventArgs) Handles ImgBtnLogOut.Click
        ObjCPIP.UpdateCPLogout(Now(), ObjCPIP.GetCpIpIdbyLoginid(HttpContext.Current.User.Identity.Name))
        FormsAuthentication.SignOut()
        Session.Abandon()

        ' clear authentication cookie
        Dim cookie1 As New HttpCookie(FormsAuthentication.FormsCookieName, "")
        cookie1.Expires = DateTime.Now.AddYears(-1)
        Response.Cookies.Add(cookie1)
        Response.Redirect("~/second-opinion/sign-in/")
    End Sub

    Protected Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        LblMsg.Text = ""







        ThumbnailImageName = ""
        If FUNewsImage.HasFile Then
            If FUNewsImage.PostedFile.ContentType <> "image/jpeg" And FUNewsImage.PostedFile.ContentType <> "image/pjpeg" And FUNewsImage.PostedFile.ContentType <> "image/gif" Then
                LblMsg.Text = "Files Of Type [" & FUNewsImage.PostedFile.ContentType & "] Not Allowed"
                Exit Sub
            ElseIf btnSave.Text = "Save" Then
                ThumbnailImageName = CStr(DsIdentity.GetCurrentIdentityByTableName("Secondopinionmembersdetails") + 1) & Path.GetExtension(FUNewsImage.PostedFile.FileName)
                FUNewsImage.PostedFile.SaveAs(Server.MapPath("~/second-opinon/reports") & "/" & ThumbnailImageName)
            Else
                If btnSave.Text = "Update" Then
                    If FUNewsImage.PostedFile.ContentType <> "image/jpeg" And FUNewsImage.PostedFile.ContentType <> "image/pjpeg" And FUNewsImage.PostedFile.ContentType <> "image/gif" Then
                        LblMsg.Text = "Files Of Type [" & FUNewsImage.PostedFile.ContentType & "] Not Allowed"

                    Else
                        ThumbnailImageName = CStr(ViewState("ophid")) & "." & Path.GetExtension(FUNewsImage.PostedFile.FileName)
                        FUNewsImage.PostedFile.SaveAs(Server.MapPath("~/second-opinon/reports") & "/" & ThumbnailImageName)
                    End If
                End If

            End If
        End If

        If (btnSave.Text = "save") Then


            dsfamily.Insert(txtQuery.Text, "General Enquiry", 0, 0, "1/1/1999", "", 0, Now(), "1/1/1999", "Received", Session("UserId"), ddlrelation.SelectedItem.Value, TxtName.Text, txtlastname.Text, txtmarritalstatus.Text, txtoccupation.Text, txtEmailId.Text, txtTelephone.Text, TxtMobile.Text, ddlrelation.SelectedItem.Text, ddlgender.SelectedItem.Value, txtAge.Text, txtAddress.Text, txtCity.Text, txtState.Text, txtcountry.Text, txtZipcode.Text, txtnationality.Text, txtreligion.Text, txtbloodgroup.Text, txtYourDoctor.Text, DDLSpecialisation.SelectedItem.Value, txtDiagnosis.Text, ThumbnailImageName, "1/1/1999", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "Web Based Enquiry", "", "", "", "")

            LblMsg.Text = "Family Details Added Successfully "
        End If


        Page.ClientScript.RegisterStartupScript(Me.GetType(), "EnquiryAlert", "alert('Thanks for your interest in KIMS Hospitals, we will get back to you as soon as possible.');", True)

        message = "<font face='Verdana' size='2'>Dear " & TxtName.Text & ", <br /><br />" & _
                   "Thanks for visiting our website and giving the following details, we will get back to you as soon as possible.<br /><br /></font>" & _
                   "<TABLE cellSpacing=5 cellPadding=0>" & _
                   "<tr><td><font face='Verdana' size='2'>Telephone #</td><td>:</td><td><font face='Verdana' size='2'>" & txtTelephone.Text & "</font></td></tr>" & _
                   "<tr><td colspan=3>&nbsp;<br /><br /></td></tr>" & _
                   "<tr><td ><font face='Verdana' size='2'>Question category</font></td><td>:</td><td><font face='Verdana' size='2'>General Enquiry</font></td></tr>" & _
                   "<tr><td colspan=3><font face='Verdana' size='2'>Information Required</font></td></tr>" & _
                   "<tr><td colspan=3><font face='Verdana' size='2'>" & txtQuery.Text & "</font></td></tr></TABLE><br /><br />" & _
                   "<font face='Verdana' size='2'>Thanks & Regards,<br />" & _
                   "Website Support Team,<br />" & _
                   "KIMS Hospitals. </font>"

        subject = "Second Opinion -- www.KimsHospitals.com"
        sendto = txtEmailId.Text

        Dim CF As New CommonFunctions
        CF.SendMail(message, sendto, subject)


        message = "<font face='Verdana' size='2'>Dear " & TxtName.Text & ", <br /><br />" & _
                        "Thanks for visiting our website and giving the following details, we will get back to you as soon as possible.<br /><br /></font>" & _
                        "<TABLE cellSpacing=5 cellPadding=0>" & _
                        "<tr><td><font face='Verdana' size='2'>Gender</td><td>:</td><td><font face='Verdana' size='2'>" & ddlgender.SelectedItem.Text & "</font></td></tr>" & _
                        "<tr><td><font face='Verdana' size='2'>Age</td><td>:</td><td><font face='Verdana' size='2'>" & txtAge.Text & "</font></td></tr>" & _
                        "<tr><td><font face='Verdana' size='2'>Address</td><td>:</td><td><font face='Verdana' size='2'>" & txtAddress.Text & "</font></td></tr>" & _
                        "<tr><td><font face='Verdana' size='2'>City</td><td>:</td><td><font face='Verdana' size='2'>" & txtCity.Text & "</font></td></tr>" & _
                        "<tr><td><font face='Verdana' size='2'>State</td><td>:</td><td><font face='Verdana' size='2'>" & txtState.Text & "</font></td></tr>" & _
                        "<tr><td><font face='Verdana' size='2'>Zip Code</td><td>:</td><td><font face='Verdana' size='2'>" & txtZipcode.Text & "</font></td></tr>" & _
                        "<tr><td><font face='Verdana' size='2'>Telephone #</td><td>:</td><td><font face='Verdana' size='2'>" & txtTelephone.Text & "</font></td></tr>" & _
                        "<tr><td><font face='Verdana' size='2'>Mobile No.</td><td>:</td><td><font face='Verdana' size='2'>" & TxtMobile.Text & "</font></td></tr>" & _
                        "<tr><td><font face='Verdana' size='2'>E-mail ID</td><td>:</td><td><font face='Verdana' size='2'>" & txtEmailId.Text & "</font></td></tr>" & _
                         "<tr><td colspan=3>PAST MEDICAL DETAILS<br /><br /></td></tr>" & _
                        "<tr><td><font face='Verdana' size='2'>Speciality</td><td>:</td><td><font face='Verdana' size='2'>" & DDLSpecialisation.SelectedItem.Text & "</font></td></tr>" & _
                        "<tr><td><font face='Verdana' size='2'>Your doctor</td><td>:</td><td><font face='Verdana' size='2'>" & txtYourDoctor.Text & "</font></td></tr>" & _
                        "<tr><td><font face='Verdana' size='2'>Diagnosis (if any) Treated till now</td><td>:</td><td><font face='Verdana' size='2'>" & txtDiagnosis.Text & "</font></td></tr>" & _
                        "<tr><td colspan=3>&nbsp;<br /><br /></td></tr>" & _
                        "<tr><td ><font face='Verdana' size='2'>Question category</font></td><td>:</td><td><font face='Verdana' size='2'>General Enquiry</font></td></tr>" & _
                        "<tr><td colspan=3><font face='Verdana' size='2'>Information Required</font></td></tr>" & _
                        "<tr><td colspan=3><font face='Verdana' size='2'>" & txtQuery.Text & "</font></td></tr></TABLE><br /><br />" & PhotoName & _
                        "<font face='Verdana' size='2'>Thanks & Regards,<br />" & _
                        "Website Support Team,<br />" & _
                        "KIMS Hospitals. </font>"

        subject = "Second Opinion -- www.KimsHospitals.com"


        sendto = System.Configuration.ConfigurationManager.AppSettings("AskEmailID")

        CF.SendMail(message, sendto, subject)











        ClearAll()
        BindData()

    End Sub
    Private Sub BindData()
        gvprofile.DataSource = dsfamily.GetDataBysessionid((Session("UserId")))
        gvprofile.DataBind()

        'If CInt(dsfamily.getcountofallfamilymemberbysessionid(Session("UserId")) < 1) Then
        '    trsamedetails.Visible = False
        'End If

    End Sub

    Protected Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearAll()
    End Sub
    Private Sub ClearAll()
        txtemailid.Text = ""
        TxtName.Text = ""
        txtCity.Text = ""
        txtAge.Text = ""
        txtTelephone.Text = ""
        TxtMobile.Text = ""
        txtcountry.Text = ""
        txtAddress.Text = ""
        txtCity.Text = ""
        txtnationality.Text = ""
        txtreligion.Text = ""
        txtbloodgroup.Text = ""
        txtcountry.Text = ""
        txtZipcode.Text = ""
        txtreligion.Text = ""
        txtbloodgroup.Text = ""
        txtnationality.Text = ""
        txtYourDoctor.Text = ""
        txtQuery.Text = ""


        filename.Text = ""
        fileId.Text = ""
        ddlgender.SelectedIndex = -1
        ddlrelation.SelectedIndex = -1
        btnSave.Text = "Save"

    End Sub
End Class
Imports betatesting.DataSetCareTableAdapters
Imports betatesting.HeaderBannerTableAdapters
Imports System.Data.SqlClient
Imports System.IO
Imports betatesting.newseventsTableAdapters
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web.UI.WebControls
Public Class second_opinion_profile1
    Inherits System.Web.UI.UserControl
    Dim ThumbnailImageName As String
    Dim ObjCPIP As New ControlPanelIPStatsTableAdapter
    Dim DsIdentity As New CurrentIdentity
    Dim Dsspec As New SPECIALIZATIONTableAdapter
    Dim dsfamily As New SecondopinionmembersdetailsTableAdapter
    Dim dsrelation As New secondopinionRELATIONSHIPTableAdapter
    Dim dssex As New GenderTableAdapter
    Dim DsState As New STATETableAdapter
    Dim dscity As New CITY1TableAdapter
    Dim DsCountry As New COUNTRYTableAdapter
    Dim dsmail As New PrevilegecardloginTableAdapter
    Dim message, subject, sendto, ReportName As String
    Dim email As String
    Dim dateofbirth As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            ddlrelation.DataSource = dsrelation.GetData()
            ddlrelation.DataTextField = "PATIENTSTATUSNAME"
            ddlrelation.DataValueField = "secondopinionRELATIONSHIPID"
            ddlrelation.DataBind()

            'DDLEnquiry_Country.DataSource = DsCountry.GetActiveData
            'DDLEnquiry_Country.DataTextField = "COUNTRYNAME"
            'DDLEnquiry_Country.DataValueField = "COUNTRYID"
            'DDLEnquiry_Country.DataBind()


            'ddlnationality.DataSource = DsCountry.GetActiveData
            'ddlnationality.DataTextField = "COUNTRYNAME"
            'ddlnationality.DataValueField = "COUNTRYID"
            'ddlnationality.DataBind()

            'DDLEnquiry_Country.Items.Insert(0, "")
            'DDLEnquiry_Country.Items(0).Value = "0"

            'DDLSpecialisation.DataSource = Dsspec.GetAllActiveData()
            'DDLSpecialisation.DataValueField = "SPECIALIZATIONID"
            'DDLSpecialisation.DataTextField = "SPECIALIZATIONNAME"
            'DDLSpecialisation.DataBind()


            'ddlgender.DataSource = dssex.GetData()
            'ddlgender.DataValueField = "GenderID"
            'ddlgender.DataTextField = "GenderNAME"
            'ddlgender.DataBind()


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
   
    Protected Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        LblMsg.Text = ""

        If btnSave.Text = "Save" Then

        End If

        dateofbirth = ddlmonth.SelectedItem.Value & "/" & Ddldate.SelectedItem.Value & "/" & txtyear.Text


        ThumbnailImageName = "no_img.jpg"
        'If FUNewsImage.HasFile Then
        '    If FUNewsImage.PostedFile.ContentType <> "application/pdf" And FUNewsImage.PostedFile.ContentType <> "application/zip" And FUNewsImage.PostedFile.ContentType <> "application/octet-stream" And FUNewsImage.PostedFile.ContentType <> "application/msword" And FUNewsImage.PostedFile.ContentType <> "application/txt" And FUNewsImage.PostedFile.ContentType <> "application/vnd.openxmlformats-officedocument.wordprocessingml.document" And FUNewsImage.PostedFile.ContentType <> "image/jpeg" And FUNewsImage.PostedFile.ContentType <> "image/pjpeg" And FUNewsImage.PostedFile.ContentType <> "image/gif" Then
        '        LblMsg.Text = "Files Of Type [" & FUNewsImage.PostedFile.ContentType & "] Not Allowed"
        '        Exit Sub

        '    ElseIf FUNewsImage.PostedFile.ContentLength > "31457280" Then
        '        Page.ClientScript.RegisterStartupScript(Me.GetType(), "EnquiryAlert", "alert('Report File size should not exceed 30 MB');", True)
        '        Exit Sub
        '    ElseIf btnSave.Text = "Save" Then
        '        ThumbnailImageName = CStr(DsIdentity.GetCurrentIdentityByTableName("Secondopinionmembersdetails") + 1) & Path.GetExtension(FUNewsImage.PostedFile.FileName)
        '        FUNewsImage.PostedFile.SaveAs(Server.MapPath("~/second-opinion/reports") & "/" & ThumbnailImageName)
        '        ReportName = "<a href='" & System.Configuration.ConfigurationManager.AppSettings("WebsiteURL") & "second-opinion/reports/" & ThumbnailImageName & "'>Click Here to see the reports</a><br />"
        '    Else
        '        If btnSave.Text = "Update" Then
        '            If FUNewsImage.PostedFile.ContentType <> "image/jpeg" And FUNewsImage.PostedFile.ContentType <> "image/pjpeg" And FUNewsImage.PostedFile.ContentType <> "image/gif" Then
        '                LblMsg.Text = "Files Of Type [" & FUNewsImage.PostedFile.ContentType & "] Not Allowed"

        '            Else
        '                ThumbnailImageName = CStr(ViewState("ophid")) & "." & Path.GetExtension(FUNewsImage.PostedFile.FileName)
        '                FUNewsImage.PostedFile.SaveAs(Server.MapPath("~/second-opinion/reports") & "/" & ThumbnailImageName)
        '            End If
        '        End If

        '    End If
        'End If

        'If (btnSave.Text = "Update") Then

        '    If (Not FUNewsImage.HasFile) Then
        '        dsfamily.UpdateData(txtemailid.Text, txtfirstname.Text, txtlastname.Text, txtphonenumber.Text, txtmobilenumber.Text, DDLBranch.SelectedItem.Value, Now(), DDLrelation.SelectedItem.Value, txtoccupation.Text, txtadress.Text, AppointmentDate.Text, txtsex.Text, txtmaritalstatus.Text, txtnationality.Text, txtreligion.Text, txtbloodgroup.Text, ViewState("imageurl"), fileId.Text)
        '        btnSave.Text = "Save"
        '    Else

        '        dsfamily.UpdateData(txtemailid.Text, txtfirstname.Text, txtlastname.Text, txtphonenumber.Text, txtmobilenumber.Text, DDLBranch.SelectedItem.Value, Now(), DDLrelation.SelectedItem.Value, txtoccupation.Text, txtadress.Text, AppointmentDate.Text, txtsex.Text, txtmaritalstatus.Text, txtnationality.Text, txtreligion.Text, txtbloodgroup.Text, ThumbnailImageName, fileId.Text)
        '        btnSave.Text = "Save"
        '    End If


        'Else
        '    dsfamily.Insert(txtemailid.Text, txtfirstname.Text, txtlastname.Text, txtphonenumber.Text, txtmobilenumber.Text, DDLBranch.SelectedItem.Value, Session("UserId"), Now(), DDLrelation.SelectedItem.Value, txtoccupation.Text, txtadress.Text, AppointmentDate.Text, txtsex.Text, txtmaritalstatus.Text, txtnationality.Text, txtreligion.Text, txtbloodgroup.Text, ThumbnailImageName, "Y", "400", False)
        'End If

        If (btnSave.Text = "Update") Then

            'If (Not FUNewsImage.HasFile) Then

            '    'dsfamily.Updatedata(txtQuery.Text, "General Enquiry", 0, 0, "1/1/1999", "", 0, Now(), "1/1/1999", "Received", ddlrelation.SelectedItem.Value, TxtName.Text, txtlastname.Text, txtmarritalstatus.Text, txtoccupation.Text, txtEmailId.Text, txtTelephone.Text, TxtMobile.Text, ddlrelation.SelectedItem.Text, ddlgender.SelectedItem.Value, txtAge.Text, txtAddress.Text, txtCity.Text, txtState.Text, txtcountry.Text, txtZipcode.Text, txtnationality.Text, txtreligion.Text, txtbloodgroup.Text, txtYourDoctor.Text, DDLSpecialisation.SelectedItem.Value, txtDiagnosis.Text, ViewState("imageurl"), "1/1/1999", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "Web Based Enquiry", fileId.Text)
            '    'btnSave.Text = "Save"
            'Else
            '    'dsfamily.Updatedata(txtQuery.Text, "General Enquiry", 0, 0, "1/1/1999", "", 0, Now(), "1/1/1999", "Received", ddlrelation.SelectedItem.Value, TxtName.Text, txtlastname.Text, txtmarritalstatus.Text, txtoccupation.Text, txtEmailId.Text, txtTelephone.Text, TxtMobile.Text, ddlrelation.SelectedItem.Text, ddlgender.SelectedItem.Value, txtAge.Text, txtAddress.Text, txtCity.Text, txtState.Text, txtcountry.Text, txtZipcode.Text, txtnationality.Text, txtreligion.Text, txtbloodgroup.Text, txtYourDoctor.Text, DDLSpecialisation.SelectedItem.Value, txtDiagnosis.Text, ThumbnailImageName, "1/1/1999", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "Web Based Enquiry", fileId.Text)
            '    'btnSave.Text = "Save"
            'End If

        Else
            If IsNothing(Session("UserId")) Then
                Response.Redirect("~/second-opinion/sign-in/", True)
            End If
            dsfamily.Insert(txtQuery.Text, "General Enquiry", 0, 0, "1/1/1999", "", 0, Now(), "1/1/1999", "Received", Session("UserId"), ddlrelation.SelectedItem.Value, TxtName.Text, TxtName.Text, RBLGender.SelectedItem.Text, txtoccupation.Text, email, txtmobilenumber.Text, txtmobilenumber.Text, ddlrelation.SelectedItem.Text, RBLGender.SelectedItem.Text, dateofbirth, TxtName.Text, ddlrelation.SelectedItem.Text, ddlrelation.SelectedItem.Text, ddlrelation.SelectedItem.Text, TxtName.Text, ddlrelation.SelectedItem.Text, TxtName.Text, TxtName.Text, TxtName.Text, DDLSpecialisation.SelectedItem.Value, TxtName.Text, ThumbnailImageName, "1/1/1999", RBLGender.SelectedItem.Value, RBLGender.SelectedItem.Value, DDLSpecialisation.SelectedItem.Text, ddlrelation.SelectedItem.Value, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "Web Based Enquiry", TxtName.Text, TxtName.Text, TxtName.Text, TxtName.Text)

            LblMsg.Text = "Family Details Added Successfully "
        End If
        Page.ClientScript.RegisterStartupScript(Me.GetType(), "EnquiryAlert", "alert('Thanks for your interest in KIMS Hospitals, we will get back to you as soon as possible.');", True)

        'message = "<font face='Verdana' size='2'>Dear " & TxtName.Text & ", <br /><br />" & _
        '           "We thank you so much for posting your Query , we will have all your reports evaluated by KIMs Secunderabad  - consultants and we will be sending the advice to you by e-mail.<br /><br /></font>" & _
        '           "If the Doctor advises to bring the patient we will fix the appointment on mutually convenient date and timings.<br /><br /></font>" & _
        '           "<TABLE cellSpacing=5 cellPadding=0>" & _
        '            "<tr><td colspan=3>&nbsp;<br /><br /></td></tr>" & _
        '           "<tr><td colspan=3><font face='Verdana' size='2'>" & txtQuery.Text & "</font></td></tr></TABLE><br /><br />" & _
        '           "<font face='Verdana' size='2'>Thanks & Regards,<br />" & _
        '           "For any further quires: <br />" & _
        '           "Your SPOC (Single Point Of Contact) @ KIMs Hospitals,<br />" & _
        '           "Naresh Darga,<br />" & _
        '           "(M) : 98490 11841, 98660 79831,<br />" & _
        '           "e-mail – naresh.da@kimshospitals.co.in , naresh_darga@yahoo.com,,<br />" & _
        '           "Website Support Team,<br />" & _
        '           "KIMS Hospitals. </font>"

        'subject = "Second Opinion -- www.KimsHospitals.com"

        'email = dsmail.getpasswordbyemailid(Session("UserId"))

        'sendto = email

        'Dim CF As New CommonFunctions
        'CF.SendMail(message, sendto, subject)


        message = "<font face='Verdana' size='2'>Dear Admin , <br /><br />" & _
                       "<TABLE cellSpacing=5 cellPadding=0>" & _
                       "<tr><td><font face='Verdana' size='2'>Name</td><td>:</td><td><font face='Verdana' size='2'>" & TxtName.Text & "</font></td></tr>" & _
                        "<tr><td><font face='Verdana' size='2'>Gender</td><td>:</td><td><font face='Verdana' size='2'>" & RBLGender.SelectedItem.Text & "</font></td></tr>" & _
                        "<tr><td><font face='Verdana' size='2'>Number</td><td>:</td><td><font face='Verdana' size='2'>" & txtmobilenumber.Text & "</font></td></tr>" & _
                        "<tr><td><font face='Verdana' size='2'>Age</td><td>:</td><td><font face='Verdana' size='2'>" & dateofbirth & "</font></td></tr>" & _
                        "<tr><td><font face='Verdana' size='2'>Speciality</td><td>:</td><td><font face='Verdana' size='2'>" & DDLSpecialisation.SelectedItem.Text & "</font></td></tr>" & _
                        "<tr><td colspan=3><font face='Verdana' size='2'>Information Required</font></td></tr>" & _
                        "<tr><td colspan=3><font face='Verdana' size='2'>" & txtQuery.Text & "</font></td></tr></TABLE><br /><br />" & _
                        "<font face='Verdana' size='2'>Thanks & Regards,<br />" & _
                        "Website Support Team,<br />" & _
                        "KIMS Hospitals. </font>"

        subject = "Second Opinion -- www.KimsHospitals.com"

        Dim CF As New CommonFunctions
        sendto = System.Configuration.ConfigurationManager.AppSettings("secondemailid")

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

        TxtName.Text = ""



        DDLSpecialisation.SelectedIndex = -1

        txtQuery.Text = ""

        RBLGender.SelectedIndex = -1
        filename.Text = ""
        fileId.Text = ""

        ddlrelation.SelectedIndex = -1
        btnSave.Text = "Save"


    End Sub
    Protected Sub gvprofile_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles gvprofile.PageIndexChanging
        gvprofile.PageIndex = e.NewPageIndex

        BindData()

    End Sub

    Protected Sub gvprofile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gvprofile.SelectedIndexChanged

    End Sub


    Protected Sub ddlrelation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlrelation.SelectedIndexChanged


        If (ddlrelation.SelectedItem.Value = "1") Then

            RequiredFieldValidator7.Enabled = True
            RFVMobile.Enabled = True
        Else
            RequiredFieldValidator7.Enabled = False
            RFVMobile.Enabled = False


        End If
    End Sub
End Class
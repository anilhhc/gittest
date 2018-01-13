Imports betatesting.DataSetCareTableAdapters
Imports System.Data.SqlClient
Imports System.IO
Imports betatesting.newseventsTableAdapters
Imports betatesting.HeaderBannerTableAdapters
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web.UI.WebControls

Public Class privilege_add_details
    Inherits System.Web.UI.UserControl
    Dim ThumbnailImageName As String
    Dim ObjCPIP As New ControlPanelIPStatsTableAdapter
    Dim DsIdentity As New CurrentIdentity
    Dim DsState As New STATETableAdapter
    Dim dsfamily As New PrevilegecardFamilymembersdetailsTableAdapter
    Dim dsrelation As New CORPRELATIONSHIPTableAdapter

    Dim dscity As New CITY1TableAdapter
    Dim DsCountry As New COUNTRYTableAdapter
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ddlrelation.DataSource = dsrelation.GetData()
            ddlrelation.DataTextField = "PATIENTSTATUSNAME"
            ddlrelation.DataValueField = "CORPRELATIONSHIPID"
            ddlrelation.DataBind()

            ddlnationality.DataSource = DsCountry.GetActiveData
            ddlnationality.DataTextField = "COUNTRYNAME"
            ddlnationality.DataValueField = "COUNTRYID"
            ddlnationality.DataBind()


            DDLEnquiry_Country.DataSource = DsCountry.GetActiveData
            DDLEnquiry_Country.DataTextField = "COUNTRYNAME"
            DDLEnquiry_Country.DataValueField = "COUNTRYID"
            DDLEnquiry_Country.DataBind()


            'ddlfamilmembernames.DataSource = dsfamily.GetDataBysessionid(Session("UserId"))
            'ddlfamilmembernames.DataTextField = "FirstName"
            'ddlfamilmembernames.DataValueField = "PrevilegecardFamilymembersdetailsID"
            'ddlfamilmembernames.DataBind()

            gvprofile.DataSource = dsfamily.GetDataBysessionid(Session("UserId"))
            gvprofile.DataBind()
            If IsNothing(Session("UserId")) Then
                Response.Redirect("~/privilege-card/sign-in/", True)
            End If

            'If CInt(dsfamily.getcountofallfamilymemberbysessionid(Session("UserId")) < 1) Then
            '    trsamedetails.Visible = False
            'End If

        End If

    End Sub
    Protected Sub lnkprintall_Click(sender As Object, e As EventArgs) Handles lnkprintall.Click
        Dim doci As String
        doci = (Session("UserId"))
        Response.Redirect("http://kimshospitals.com/privilege-card/add-details/print-all.aspx?ID=" + doci + "")

    End Sub
    Protected Sub DDLEnquiry_Country_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DDLEnquiry_Country.SelectedIndexChanged
        If (DDLEnquiry_Country.SelectedIndex > 0) Then
            ddlstate.DataSource = DsState.GetAllData(DDLEnquiry_Country.SelectedItem.Value)
            ddlstate.DataTextField = "STATENAME"
            ddlstate.DataValueField = "STATEID"
            ddlstate.DataBind()
            '    RFVState.Enabled = True

            '    If (DDLEnquiry_Country.SelectedItem.Value = "98") Then
            '        'ddlstate.Items.Insert(0, "  *")
            '        'DDLState.Items(0).Value = ""
            '        Rfvstate.Enabled = True

            '    Else
            '        RFVState.Enabled = False
            '        ddlstate.Items.Insert(0, " ")
            '        DDLState.Items(0).Value = ""

            '    End If

            'Else
            '    DDLState.Items.Clear()
            '    RFVState.Enabled = False

            '    ddlstate.Items.Insert(0, "")
            '    DDLState.Items(0).Value = ""

        End If
    End Sub
    Protected Sub ddlstate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlstate.SelectedIndexChanged
        If (ddlstate.SelectedIndex > 0) Then
            DDLCITY.DataSource = dscity.GetDataBystateid(ddlstate.SelectedItem.Value)
            DDLCITY.DataTextField = "CITYNAME"
            DDLCITY.DataValueField = "CITYID"
            DDLCITY.DataBind()






        End If

    End Sub


    Protected Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        LblMsg.Text = ""

        If btnSave.Text = "Save" Then

            If (Not FUNewsImage.HasFile) Then
                LblMsg.Text = "Upload Any Id proof And Try Again !"
                Exit Sub
            End If
        End If



        ThumbnailImageName = ""
        If FUNewsImage.HasFile Then
            If FUNewsImage.PostedFile.ContentType <> "image/jpeg" And FUNewsImage.PostedFile.ContentType <> "image/pjpeg" And FUNewsImage.PostedFile.ContentType <> "image/gif" Then
                LblMsg.Text = "Files Of Type [" & FUNewsImage.PostedFile.ContentType & "] Not Allowed"
                Exit Sub
            ElseIf btnSave.Text = "Save" Then
                ThumbnailImageName = CStr(DsIdentity.GetCurrentIdentityByTableName("PrevilegecardFamilymembersdetails") + 1) & Path.GetExtension(FUNewsImage.PostedFile.FileName)
                FUNewsImage.PostedFile.SaveAs(Server.MapPath("~/privilege-card/proofs") & "/" & ThumbnailImageName)
            Else
                If btnSave.Text = "Update" Then
                    If FUNewsImage.PostedFile.ContentType <> "image/jpeg" And FUNewsImage.PostedFile.ContentType <> "image/pjpeg" And FUNewsImage.PostedFile.ContentType <> "image/gif" Then
                        LblMsg.Text = "Files Of Type [" & FUNewsImage.PostedFile.ContentType & "] Not Allowed"

                    Else
                        ThumbnailImageName = CStr(ViewState("ophid")) & "." & Path.GetExtension(FUNewsImage.PostedFile.FileName)
                        FUNewsImage.PostedFile.SaveAs(Server.MapPath("~/privilege-card/proofs") & "/" & ThumbnailImageName)
                    End If
                End If

            End If
        End If

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

            If (Not FUNewsImage.HasFile) Then

                dsfamily.UpdateData(txtEmailId.Text, txtfirstname.Text, txtlastname.Text, txtZipcode.Text, txtmobilenumber.Text, Now(), ddlrelation.SelectedItem.Value, ddlrelation.SelectedItem.Text, txtadress.Text, RBLGender.SelectedItem.Value, RBLmarriage.SelectedItem.Value, DDLEnquiry_Country.SelectedItem.Text, txtreligion.Text, txtbloodgroup.Text, ThumbnailImageName, TxtPatientDOB.Text, txtgardianname.Text, txtoccupation.Text, txtDesignation.Text, txtmothername.Text, DDLCITY.SelectedItem.Text, ddlstate.SelectedItem.Text, ddlnationality.SelectedItem.Value, ddlnationality.SelectedItem.Text, fileId.Text)
                btnSave.Text = "Save"
            Else
                dsfamily.UpdateData(txtEmailId.Text, txtfirstname.Text, txtlastname.Text, txtZipcode.Text, txtmobilenumber.Text, Now(), ddlrelation.SelectedItem.Value, ddlrelation.SelectedItem.Text, txtadress.Text, RBLGender.SelectedItem.Value, RBLmarriage.SelectedItem.Value, DDLEnquiry_Country.SelectedItem.Text, txtreligion.Text, txtbloodgroup.Text, ViewState("imageurl"), TxtPatientDOB.Text, txtgardianname.Text, txtoccupation.Text, txtDesignation.Text, txtmothername.Text, DDLCITY.SelectedItem.Text, ddlstate.SelectedItem.Text, ddlnationality.SelectedItem.Value, ddlnationality.SelectedItem.Text, fileId.Text)
                btnSave.Text = "Save"
            End If

        Else
            If IsNothing(Session("UserId")) Then
                Response.Redirect("~/privilege-card/sign-in/", True)
            End If
            dsfamily.Insert(txtEmailId.Text, txtfirstname.Text, txtlastname.Text, txtZipcode.Text, txtmobilenumber.Text, 0, Session("UserId"), Now(), ddlrelation.SelectedItem.Value, ddlrelation.SelectedItem.Text, txtadress.Text, TxtPatientDOB.Text, RBLGender.SelectedItem.Value, RBLmarriage.SelectedItem.Value, DDLEnquiry_Country.SelectedItem.Text, txtreligion.Text, txtbloodgroup.Text, ThumbnailImageName, "Y", "400", False, txtgardianname.Text, txtoccupation.Text, txtDesignation.Text, txtmothername.Text, DDLCITY.SelectedItem.Text, ddlstate.SelectedItem.Text, ddlnationality.SelectedItem.Value, ddlnationality.SelectedItem.Text)

            LblMsg.Text = "Family Details Added Successfully "
        End If



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
        txtEmailId.Text = ""
        txtfirstname.Text = ""
        txtlastname.Text = ""
        txtmobilenumber.Text = ""
        DDLEnquiry_Country.SelectedIndex = -1
        ddlrelation.SelectedIndex = -1
        ddlstate.SelectedIndex = -1
        DDLCITY.SelectedIndex = -1
        TxtPatientDOB.Text = ""
        txtoccupation.Text = ""
        txtoccupation.Text = ""
        txtadress.Text = ""

        txtmothername.Text = ""
        txtDesignation.Text = ""
        txtgardianname.Text = ""
        txtZipcode.Text = ""
        txtbloodgroup.Text = ""
        txtreligion.Text = ""
        txtbloodgroup.Text = ""
        filename.Text = ""
        fileId.Text = ""

        btnSave.Text = "Save"
        RFVImage.Enabled = True
    End Sub
    Protected Sub gvprofile_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles gvprofile.PageIndexChanging
        gvprofile.PageIndex = e.NewPageIndex

        BindData()

    End Sub

    Protected Sub gvprofile_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles gvprofile.RowCommand
        If e.CommandName = "CmdEdit" Then
            ClearAll()
            Dim DtImages As DataTable = dsfamily.GetValueById(e.CommandArgument)
            Dim dtrow As DataRow

            If DtImages.Rows.Count > 0 Then
                dtrow = DtImages.Rows(0)

                'Hlimage.NavigateUrl = "~/corp/proofs" & "/" & dtrow("Idproof")
                'Hlimage.Text = "View Image"
                ViewState("imageurl") = dtrow("Idproof")




                txtEmailId.Text = dtrow("LastName")
                txtfirstname.Text = dtrow("FirstName")
                txtlastname.Text = dtrow("lastname")

                TxtPatientDOB.Text = dtrow("PhoneNumber")
                txtgardianname.Text = dtrow("gardianname")
                txtmothername.Text = dtrow("mothername")

                txtmobilenumber.Text = dtrow("MobileNumber")
                txtoccupation.Text = dtrow("occupation")
                txtDesignation.Text = dtrow("designation")
                txtadress.Text = dtrow("adress")

                If Not IsDBNull(dtrow("relationship")) Then
                    ddlrelation.Items.FindByValue(dtrow("relationship")).Selected = True
                End If
                If Not IsDBNull(dtrow("nationalityid")) Then
                    ddlnationality.Items.FindByValue(dtrow("nationalityid")).Selected = True
                End If
                'If Not IsDBNull(dtrow("relationship")) Then
                '    DDLEnquiry_Country.Items.FindByValue(dtrow("relationship")).Selected = True
                'End If
                'If Not IsDBNull(dtrow("relationship")) Then
                '    DDLCITY.Items.FindByValue(dtrow("relationship")).Selected = True
                'End If
                'If Not IsDBNull(dtrow("relationship")) Then
                '    ddlstate.Items.FindByValue(dtrow("relationship")).Selected = True
                'End If

                txtreligion.Text = dtrow("religion")
                txtbloodgroup.Text = dtrow("Bloodgroup")
                filename.Text = dtrow("Idproof")
                fileId.Text = dtrow("PrevilegecardFamilymembersdetailsID")
                RFVImage.Enabled = False
                btnSave.Text = "Update"
                ViewState("ophid") = dtrow("PrevilegecardFamilymembersdetailsID")
            End If
        ElseIf e.CommandName = "CmdDelete" Then
            dsfamily.Delete(e.CommandArgument)
            BindData()
        End If
    End Sub
    Protected Sub gvprofile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gvprofile.SelectedIndexChanged

    End Sub

End Class
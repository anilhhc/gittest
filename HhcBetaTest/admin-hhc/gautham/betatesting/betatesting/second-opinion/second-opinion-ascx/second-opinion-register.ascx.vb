Imports betatesting.DataSetCareTableAdapters
Imports betatesting.HeaderBannerTableAdapters
Imports System.Data.SqlClient

Public Class second_opinion_register
    Inherits System.Web.UI.UserControl
    Dim i As Integer
    Dim Permissions, Password As String
    Dim Message, subject, sendto As String
    Dim dsadmins As New PrevilegecardloginTableAdapter
    Dim strsql As String
    Dim oracmd As SqlCommand
    Dim connString As String
    Public objConn As SqlConnection
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        LblMsg.Text = ""
        If txtEmailId.Text = "" Then
            LblMsg.Text = "Please enter Corporate Email Id"
        Else
            If txtfirstname.Text = "" Then
                LblMsg.Text = "Please Enter First Name"
            Else
                If txtlastname.Text = "" Then
                    LblMsg.Text = "Please Enter Last Name"
                Else
                    If txtmobilenumber.Text = "" Then
                        LblMsg.Text = "Please Enter Mobile Number"
                    Else

                        If (dsadmins.CheckPrimaryCount(txtEmailId.Text) > 0) Then
                            LblMsg.Text = "<br /><br /> Corporate Login Id -- [" & txtEmailId.Text & "] Already Exists, Please Try With Other !<br /><br />"
                        Else

                            Permissions = GetPermissions()

                            Password = RandomPassword.Generate(6)
                            dsadmins.Insert(txtEmailId.Text, Password, txtfirstname.Text, txtlastname.Text, txtmobilenumber.Text, "Y")
                            LblMsg.Text = "<br /><br />User Added Successfully !<br /><br />Login Id(" & txtEmailId.Text & ") /  "

                            Message = ""
                            If txtEmailId.Text <> "" Then
                                Message = "<font face='Verdana' size='2'>Dear " & txtfirstname.Text & ", <br /><br />" & _
                                        "<br /><br /></font>" & _
                                        " Welcome to KIMS Hospitals Network. Following are the details to access the administrator control panel.<br /><br />" & _
                                        "<br />URL '" & System.Configuration.ConfigurationManager.AppSettings("WebsiteURL") & "second-opinion/sign-in/'<br />" & _
                                        "<br />User Name(Login Id) : " & txtEmailId.Text & _
                                        "<br />Password : " & Password & _
                                        "<br /><br /><font face='Verdana' size='2'>Thanks & Regards,<br />" & _
                                        "Website Support Team,<br />" & _
                                        "KIMS Hospitals. </font>"

                                subject = "Second Opinion -- www.KimsHospitals.com"
                                sendto = txtEmailId.Text


                                Dim CF As New CommonFunctions
                                CF.SendMail(Message, sendto, subject)
                                LblMsg.Text = "<br /><br />User Added Successfully ! Login Details Emailed.<br /><br />"

                                Response.Redirect("~/second-opinion/sign-in/")
                            End If
                        End If

                        ClearAll()
                    End If
                End If
            End If
        End If
    End Sub

    Protected Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        ClearAll()
        btnSubmit.Text = "Submit"
        BtnCancel.Visible = True

        LblMsg.Text = ""



    End Sub

    Private Sub ClearAll()
        TxtEmailId.Text = ""
        txtlastname.Text = ""
        txtfirstname.Text = ""
        txtlastname.Text = ""
        txtmobilenumber.Text = ""



    End Sub
    Private Function GetPermissions() As String
        Permissions = ""



        Return Permissions
    End Function
End Class
Imports betatesting.DataSetCareTableAdapters
Imports System.Data.SqlClient


Public Class privilege_register
    Inherits System.Web.UI.UserControl
    Dim dsfamily As New PrevilegecardFamilymembersdetailsTableAdapter
    Dim ThumbnailImageName As String
    Dim i As Integer
    Dim Permissions, Password As String
    Dim Message, subject, sendto As String
    Dim dsadmins As New PrevilegecardloginTableAdapter
    Dim strsql As String
    Dim oracmd As SqlCommand
    Dim connString As String
    Dim loginid As String
    Public objConn As SqlConnection
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        LblMsg.Text = ""
        If txtEmailId.Text = "" Then
            LblMsg.Text = "Please enter Corporate Email Id"
        Else
            If txtfirstname.Text = "" Then
                LblMsg.Text = "Please Enter  Name"
            Else
                If txtcorporatename.Text = "" Then
                    LblMsg.Text = "Please Enter Corporate Name"
                Else
                    If txtmobilenumber.Text = "" Then
                        LblMsg.Text = "Please Enter Mobile Number"
                    Else
                        If txtcorporatename.Text = "" Then
                            LblMsg.Text = "Please Enter Corporate Name"
                        Else

                            If (dsadmins.CheckPrimaryCount(txtEmailId.Text) > 0) Then
                                LblMsg.Text = "<br /><br /> Corporate Login Id -- [" & txtEmailId.Text & "] Already Exists, Please Try With Other !<br /><br />"
                            Else

                                Permissions = GetPermissions()

                                Password = RandomPassword.Generate(6)
                                dsadmins.Insert(txtEmailId.Text, Password, txtfirstname.Text, txtcorporatename.Text, txtmobilenumber.Text, "Y")
                                LblMsg.Text = "<br /><br />User Added Successfully !<br /><br />Login Id(" & txtEmailId.Text & ") /  "

                                'loginid = dsadmins.getloginidbyemailid(txtEmailId.Text)

                                'ThumbnailImageName = "no_img.jpg"
                                'dsfamily.Insert(txtfirstname.Text, txtfirstname.Text, txtfirstname.Text, txtmobilenumber.Text, txtmobilenumber.Text, 0, loginid, Now(), "1", "Self", txtfirstname.Text, "01/01/1999", "1", "1", "Self", "01/01/1999", "01/01/1999", ThumbnailImageName, "Y", "400", False, "01/01/1999", txtcorporatename.Text, "01/01/1999", "01/01/1999", "Self", "Self", "1", "Self")
                                Dim mobilenumber As String

                                mobilenumber = 91 & txtmobilenumber.Text
                                'Dim obj As New SmsReseller
                                'If obj.CheckLogin("info@mokshamedia.co.in", "12345678") = "OK" Then
                                '    obj.User = "info@mokshamedia.co.in" 'username
                                '    obj.Pass = "12345678" 'password
                                '    obj.Sender_id = "KIMSWB" 'senderid'senderid
                                '    obj.MSISDN = mobilenumber ' mobilenumber
                                '    obj.Message = "Your Password For Privilege Card Login " & Password 'message
                                '    obj.MsgType = SmsReseller.MessageType.Msg_Text 'messagetype
                                '    obj.SendSingle()


                                '    ' method to send SMS
                                'End If

                                Message = ""
                                If txtEmailId.Text <> "" Then
                                    Message = "<font face='Verdana' size='2'>Dear " & txtfirstname.Text & ", <br /><br />" & _
                                            "<br /><br /></font>" & _
                                            " Welcome to KIMS Hospitals Network. Following are the details to access the administrator control panel.<br /><br />" & _
                                            "<br />URL '" & System.Configuration.ConfigurationManager.AppSettings("WebsiteURL") & "privilege-card/sign-in/'<br />" & _
                                            "<br />User Name(Login Id) : " & txtEmailId.Text & _
                                            "<br />Password : " & Password & _
                                            "<br /><br /><font face='Verdana' size='2'>Thanks & Regards,<br />" & _
                                            "Website Support Team,<br />" & _
                                            "KIMS Hospitals. </font>"

                                    subject = "Privilege Card Login Details -- www.KimsHospitals.com"
                                    sendto = txtEmailId.Text


                                    Dim CF As New CommonFunctions
                                    CF.SendMail(Message, sendto, subject)
                                    LblMsg.Text = "<br /><br />User Added Successfully ! Login Details Emailed.<br /><br />"

                                    Response.Redirect("~/privilege-card/sign-in/")
                                End If
                            End If

                            ClearAll()
                        End If
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
        txtcorporatename.Text = ""
        txtfirstname.Text = ""

        txtmobilenumber.Text = ""



    End Sub
    Private Function GetPermissions() As String
        Permissions = ""



        Return Permissions
    End Function
End Class
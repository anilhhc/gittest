Imports betatesting.DataSetCareTableAdapters
Imports System.Data.SqlClient

Public Class second_opinion_change_password
    Inherits System.Web.UI.UserControl
    Dim DsAdmins As New PrevilegecardloginTableAdapter
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub BtnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        If TxtNewPassword.Text = TxtConfirmPassword.Text Then

            If CInt(DsAdmins.getcounttoupdatepassword(Session("UserId"), TxtOldPassword.Text)) > 0 Then
                DsAdmins.Updatepassword(TxtNewPassword.Text, Session("UserId"))
                LblMsg.Text = "<br /><br />Password Changed Successfully !<br /><br />"
            Else
                LblMsg.Text = "<br /><br />Invalid Password !, Please Try With The Other !<br /><br />"
            End If
        Else
            LblMsg.TabIndex = " <br /><br />Password is not equal !, Please re enter password correctly !<br /><br />"
        End If
        TxtConfirmPassword.Text = ""
        TxtNewPassword.Text = ""
        TxtOldPassword.Text = ""
    End Sub

    Private Sub default4_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If IsNothing(Session("UserId")) Then
                Response.Redirect("~/privilege-card/sign-in/", True)
            End If
        End If
    End Sub
End Class
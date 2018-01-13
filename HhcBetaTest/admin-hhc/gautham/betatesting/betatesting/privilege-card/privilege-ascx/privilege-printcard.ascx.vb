Imports System.Data.SqlClient
Imports betatesting.DataSetCareTableAdapters
Imports System.IO
Imports betatesting.newseventsTableAdapters
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web.UI.WebControls
Public Class privilege_printcard
    Inherits System.Web.UI.UserControl
    Dim DsSpecialities As New SPECIALITIESTableAdapter
    Dim DsSpec As New SPECIALIZATIONTableAdapter
    Dim DsOhPrintMedia As New OHPrintMedia_newsTableAdapter
    Dim DsBranch As New BRANCH1TableAdapter
    Dim branchDepts As New getDeptsByBranchTableAdapter
    Dim spArr, deptArr, doctorArr, institutesArr, qualArr, firstbranchArr, brancharr, SecondBranchTimmingsArr As Array
    Dim strsql, strCondition, strJoin, FirstBranch, SecondBranchTimmings As String
    Dim oracmd As SqlCommand
    Dim connString As String
    Public objConn As SqlConnection
    Dim objdata As SqlDataReader
    Dim Dsdoctor As New DOCTORSTableAdapter
    Dim OHPrintMediaID As String
    Dim DsDoc As New mediaTableAdapter
    Dim dscard As New PrevilegecardFamilymembersdetailsTableAdapter
    Dim dsemployee As New PrevilegecardloginTableAdapter
    Dim dt As DataTable
    Dim fromdate As String
    Dim todate As String
    Dim companyname As String
    Dim empid As String
    Dim count As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then

            Dim DtDoc As New Data.DataTable
            dt = dscard.GetDataBysessionidorderbyrelationship(Request("ID"))
            RptDoctors.DataSource = dt
            RptDoctors.DataBind()

            Dim dtcard As New Data.DataTable
            dt = dsemployee.GetDataByPrevilegecardloginId(Request("id"))
            rptcorp.DataSource = dt
            rptcorp.DataBind()

            If IsNothing(Session("UserId")) Then
                Response.Redirect("~/privilege-card/sign-in/", True)
            End If



            count = dscard.getcountofallfamilymemberbysessionid((Request("ID")))

            If count > 0 Then
                fromdate = dscard.previlagecardfromdate(Request("ID"))
                If IsNothing(fromdate) Then
                Else
                    'lblfromdate.Text = dscard.previlagecardfromdate(Request("ID"))
                    lblfromdate.Text = FormatDateTime(fromdate, DateFormat.ShortDate)
                End If
                todate = dscard.previlagecardtodate(Request("ID"))
                If IsNothing(todate) Then
                Else
                    'lbltodate.Text = dscard.previlagecardtodate(Request("ID"))
                    lbltodate.Text = FormatDateTime(todate, DateFormat.ShortDate)
                End If

            Else
            End If


            empid = Request("ID")
            If empid > 1696 Then
                companyname = dsemployee.getcompanynamebyloginid(Request("ID"))
                lblcompanyname.Text = companyname
            Else
                If count > 0 Then
                    companyname = dscard.getcompanyname(Request("ID"))
                    If IsNothing(companyname) Then
                    Else
                        lblcompanyname.Text = dscard.getcompanyname(Request("ID"))
                    End If
                Else
                End If
            End If
            'companyname = dscard.getcompanyname(Request("ID"))
            'If IsNothing(companyname) Then
            'Else
            '    lblcompanyname.Text = dscard.getcompanyname(Request("ID"))
            'End If

            'fromdate = dscard.getcompanyname(Request("ID"))
            'lblcompanyname.Text = dscard.getcompanyname(Request("ID"))
            'lblfromdate.Text = dscard.previlagecardfromdate(Request("ID"))
            'lbltodate.Text = dscard.previlagecardtodate(Request("ID"))
        End If

    End Sub

End Class
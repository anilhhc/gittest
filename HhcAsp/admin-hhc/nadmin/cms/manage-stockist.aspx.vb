Imports betatesting.hhcTableAdapters
Imports System.Data.SqlClient
Imports betatesting.CorporatesTableAdapters
Imports betatesting.DataSetCareTableAdapters
Public Class manage_stockist
    Inherits System.Web.UI.Page
    Dim i As Integer
    Dim Permissions, Password As String
    Dim Message, subject, sendto As String
    Dim dsadmins As New HstockistdetailsnewTableAdapter
    Dim strsql As String
    Dim oracmd As SqlCommand
    Dim connString As String
    Public objConn As SqlConnection
    Dim dsregister As New HstockistdetailsnewTableAdapter
    Dim dsstckist As New HstockistdetailsnewTableAdapter
    Dim DsCountry As New COUNTRYTableAdapter
    Dim DsState As New STATETableAdapter
    Dim dscity As New CITYTableAdapter
    ' Dim dssubcity As subareaCITY2TableAdapter
    Dim dsdivision As New HdivisionTableAdapter
    Dim dstherapatic As New HtherapaticTableAdapter

    Dim dssubarea As New subareaCITY2TableAdapter

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then


            gvstockist.DataSource = dsadmins.GetData()
            gvstockist.DataBind()
        End If

    End Sub

 
End Class
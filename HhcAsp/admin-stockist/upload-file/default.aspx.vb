
Imports System.IO
Imports System.Data
Imports System.Collections.Generic
Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Spreadsheet

Imports System.Data.SqlClient
Imports System.Configuration
Imports betatesting.DataSetCareTableAdapters
Imports betatesting.hhcTableAdapters
Imports betatesting.CorporatesTableAdapters

Imports System

Imports System.Web.UI.WebControls
Imports betatesting.avanaTableAdapters
Imports betatesting.HeaderBannerTableAdapters

Imports betatesting.newseventsTableAdapters

Public Class _default39
    Inherits System.Web.UI.Page
    Dim dsstockistupload As New hstockistuploadTableAdapter
    Dim DsIdentity As New CurrentIdentity

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        GVPrintNews.DataSource = dsstockistupload.GetDataBystockistid(Session("HstockistdetailsID"))
        GVPrintNews.DataBind()

    End Sub
    Protected Sub ImportExcel(sender As Object, e As EventArgs)
        'Save the uploaded Excel file.
        Dim FileName As String = Path.GetFileName(FileUpload1.PostedFile.FileName)
        Dim Extension As String = Path.GetExtension(FileUpload1.PostedFile.FileName)
        Dim FolderPath As String = ConfigurationManager.AppSettings("FolderPath")




        Dim filenum As String
        filenum = dsstockistupload.getstockistcount(Session("HstockistdetailsID"))
        filenum = (filenum + 1)
        FileName = CStr(DsIdentity.GetCurrentIdentityByTableName("hstockistupload") + 1) & "-" & ddlyears.SelectedItem.Value & "-" & ddlmonth.SelectedItem.Text & "-" & filenum & "-" & Session("HstockistdetailsID") & Path.GetExtension(FileUpload1.PostedFile.FileName)
        FileUpload1.PostedFile.SaveAs(Server.MapPath("~/files") & "/" & FileName)
        Dim FilePath As String = Server.MapPath(FolderPath + FileName)
        'FileUpload1.SaveAs(FilePath)

        dsstockistupload.Insert(TxtComments.Text, ddlmonth.SelectedItem.Value, ddlyears.SelectedItem.Value, filenum, Now(), FilePath, ddlmonth.SelectedItem.Text, Session("HstockistdetailsID"), "File Uploaded")



        'Open the Excel file in Read Mode using OpenXml.
        Using doc As SpreadsheetDocument = SpreadsheetDocument.Open(filePath, False)
            'Read the first Sheets from Excel file.
            Dim sheet As Sheet = doc.WorkbookPart.Workbook.Sheets.GetFirstChild(Of Sheet)()

            'Get the Worksheet instance.
            Dim worksheet As Worksheet = TryCast(doc.WorkbookPart.GetPartById(sheet.Id.Value), WorksheetPart).Worksheet

            'Fetch all the rows present in the Worksheet.
            Dim rows As IEnumerable(Of Row) = worksheet.GetFirstChild(Of SheetData)().Descendants(Of Row)()

            'Create a new DataTable.
            Dim dt As New DataTable()

            'Loop through the Worksheet rows.
            For Each row As Row In rows
                'Use the first row to add columns to DataTable
                If row.RowIndex.Value = 1 Then
                    For Each cell As Cell In row.Descendants(Of Cell)()
                        dt.Columns.Add(GetValue(doc, cell))
                    Next
                Else
                    'Add rows to DataTable.
                    dt.Rows.Add()
                    Dim i As Integer = 0
                    For Each cell As Cell In row.Descendants(Of Cell)()
                        dt.Rows(dt.Rows.Count - 1)(i) = GetValue(doc, cell)
                        i += 1
                    Next
                End If
            Next
            GvBannerImages.DataSource = dt
            GvBannerImages.DataBind()
            GVPrintNews.DataSource = dsstockistupload.GetDataBystockistid(Session("HstockistdetailsID"))
            GVPrintNews.DataBind()
        End Using
    End Sub

    Private Function GetValue(doc As SpreadsheetDocument, cell As Cell) As String
        Dim value As String = cell.CellValue.InnerText
        If cell.DataType IsNot Nothing AndAlso cell.DataType.Value = CellValues.SharedString Then
            Return doc.WorkbookPart.SharedStringTablePart.SharedStringTable.ChildElements.GetItem(Integer.Parse(value)).InnerText
        End If
        Return value
    End Function
    Protected Sub GVPrintNews_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVPrintNews.RowCommand
        If e.CommandName = "CmdEdit" Then
            'ClearAll()
            Dim DtImages As DataTable = dsstockistupload.GetDataByid(e.CommandArgument)
            Dim dtrow As DataRow

            If DtImages.Rows.Count > 0 Then
                dtrow = DtImages.Rows(0)
              

            End If
        ElseIf e.CommandName = "CmdDelete" Then

           
        ElseIf e.CommandName = "Cmdview" Then

            Dim filepathold As String
            filepathold = e.CommandArgument
            Using doc As SpreadsheetDocument = SpreadsheetDocument.Open(filepathold, False)
                'Read the first Sheets from Excel file.
                Dim sheet As Sheet = doc.WorkbookPart.Workbook.Sheets.GetFirstChild(Of Sheet)()

                'Get the Worksheet instance.
                Dim worksheet As Worksheet = TryCast(doc.WorkbookPart.GetPartById(sheet.Id.Value), WorksheetPart).Worksheet

                'Fetch all the rows present in the Worksheet.
                Dim rows As IEnumerable(Of Row) = worksheet.GetFirstChild(Of SheetData)().Descendants(Of Row)()

                'Create a new DataTable.
                Dim dt As New DataTable()

                'Loop through the Worksheet rows.
                For Each row As Row In rows
                    'Use the first row to add columns to DataTable
                    If row.RowIndex.Value = 1 Then
                        For Each cell As Cell In row.Descendants(Of Cell)()
                            dt.Columns.Add(GetValue(doc, cell))
                        Next
                    Else
                        'Add rows to DataTable.
                        dt.Rows.Add()
                        Dim i As Integer = 0
                        For Each cell As Cell In row.Descendants(Of Cell)()
                            dt.Rows(dt.Rows.Count - 1)(i) = GetValue(doc, cell)
                            i += 1
                        Next
                    End If
                Next
                GvBannerImages.DataSource = dt
                GvBannerImages.DataBind()
            End Using
        End If


    End Sub


End Class
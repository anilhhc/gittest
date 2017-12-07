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
Public Class upload_primary_sales
    Inherits System.Web.UI.Page
    Dim dsstockits As New HstockistdetailsnewTableAdapter
    Dim dshprodcusts As New HproductslistTableAdapter

    Dim dsstockistupload As New hstockistuploadnew2TableAdapter
    Dim dsstockistupload2 As New hstockistuploadnewTableAdapter
    Dim DsIdentity As New CurrentIdentity
    Dim dsvendorproducts As New HvproductslistnewTableAdapter
    Dim dssales As New secondarysalesTableAdapter
    Dim dssecondarysales As New hhcsecondarysalesTableAdapter

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then


            ddlstockist.DataSource = dsstockits.GetData
            ddlstockist.DataTextField = "hssapcustomerid"
            ddlstockist.DataValueField = "HstockistdetailsID"
            ddlstockist.DataBind()



            GVPrintNews.DataSource = dsstockistupload2.GetData
            GVPrintNews.DataBind()
        End If
    End Sub
    Protected Sub ImportExcel(sender As Object, e As EventArgs)
        'Save the uploaded Excel file.


        lblanalysemsg.Text = "upload"
        Dim FileName As String = Path.GetFileName(FileUpload1.PostedFile.FileName)
        Dim Extension As String = Path.GetExtension(FileUpload1.PostedFile.FileName)
        Dim FolderPath As String = ConfigurationManager.AppSettings("FolderPath")





        Dim filenum As String
        filenum = dsstockistupload.getstockistcount(ddlstockist.SelectedItem.Value)
        filenum = (filenum + 1)
        FileName = CStr(DsIdentity.GetCurrentIdentityByTableName("hstockistupload") + 1) & "-" & ddlyears.SelectedItem.Value & "-" & ddlmonth.SelectedItem.Text & "-" & filenum & "-" & ddlstockist.SelectedItem.Value & Path.GetExtension(FileUpload1.PostedFile.FileName)
        FileUpload1.PostedFile.SaveAs(Server.MapPath("~/files") & "/" & FileName)
        Dim FilePath As String = Server.MapPath(FolderPath + FileName)
        'FileUpload1.SaveAs(FilePath)

        'dsstockistupload.Insert(TxtComments.Text, ddlmonth.SelectedItem.Value, ddlyears.SelectedItem.Value, filenum, Now(), FilePath, ddlmonth.SelectedItem.Text, ddlstockist.SelectedItem.Value, "File Uploaded")

        lblfilepath.Text = FilePath
        'lblstockist.Text = ddlstockist.SelectedItem.Value
        'lblyear.Text = ddlyears.SelectedItem.Value
        'lblmonth.Text = ddlmonth.SelectedItem.Value

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
            GVPrintNews.DataSource = dsstockistupload2.GetData
            GVPrintNews.DataBind()

            btnanalyse.Visible = True
            'btnanalyse.Text = "Analyse"
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

            lblfilepath.Text = e.CommandArgument

            lblstockist.Text = dsstockistupload.getstockistbyfilepath(e.CommandArgument)
            lblyear.Text = dsstockistupload.getyearbyfilepath(e.CommandArgument)
            lblmonth.Text = dsstockistupload.getmonthnamebyfilepath(e.CommandArgument)


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
                btnanalyse.Visible = True
            End Using
        End If


    End Sub


    Protected Sub btnanalyse_Click(sender As Object, e As EventArgs) Handles btnanalyse.Click




        'If btnanalyse.Text = "btnanalyse" Then

        'End If

        GvBannerImages.Visible = False

        gvfulldata.Visible = True







        Using doc As SpreadsheetDocument = SpreadsheetDocument.Open(lblfilepath.Text, False)
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
            gvfulldata.DataSource = dt
            gvfulldata.DataBind()
        End Using
    End Sub

    Protected Sub gvfulldata_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvfulldata.DataBound





        For i = 0 To gvfulldata.Rows.Count - 1





            If gvfulldata.Rows(i).Cells(6).Text = "" Then

                gvfulldata.Rows(i).Cells(6).Text = "Product Not Found"

                'lblanalysemsg.Text = "Products Mapping should be done"
            Else
                gvfulldata.Rows(i).Cells(15).Text = dsvendorproducts.getidbystockitname(gvfulldata.Rows(i).Cells(6).Text, gvfulldata.Rows(i).Cells(1).Text)

                If gvfulldata.Rows(i).Cells(15).Text = "" Then
                    gvfulldata.Rows(i).Cells(15).Text = "Product Not Mapped"
                    lblanalysemsg.Text = "Product Not Mapped"
                Else

                    gvfulldata.Rows(i).Cells(4).Text = gvfulldata.Rows(i).Cells(15).Text
                    gvfulldata.Rows(i).Cells(15).Text = dshprodcusts.getnamebyid(gvfulldata.Rows(i).Cells(15).Text)
                End If


            End If



        Next

        If lblanalysemsg.Text = "Product Not Mapped" Then


        Else
            btnanalyse.Text = "Upload to DB"
        End If

        If btnanalyse.Text = "Upload to DB" Then


            For i = 0 To gvfulldata.Rows.Count - 1





                If gvfulldata.Rows(i).Cells(6).Text = "" Then

                    gvfulldata.Rows(i).Cells(6).Text = "Product Not Found"

                    'lblanalysemsg.Text = "Products Mapping should be done"
                Else
                    gvfulldata.Rows(i).Cells(15).Text = dsvendorproducts.getidbystockitname(gvfulldata.Rows(i).Cells(6).Text, gvfulldata.Rows(i).Cells(1).Text)

                    If gvfulldata.Rows(i).Cells(15).Text = "" Then
                        gvfulldata.Rows(i).Cells(15).Text = "Product Not Mapped"
                        lblanalysemsg.Text = "Product Not Mapped"
                    Else
                        gvfulldata.Rows(i).Cells(4).Text = gvfulldata.Rows(i).Cells(15).Text
                        gvfulldata.Rows(i).Cells(15).Text = dshprodcusts.getnamebyid(gvfulldata.Rows(i).Cells(15).Text)
                    End If


                End If

                'dssales.Insert(lblmonth.Text, lblyear.Text, lblfilepath.Text, lblstockist.Text, gvfulldata.Rows(i).Cells(0).Text, gvfulldata.Rows(i).Cells(1).Text, gvfulldata.Rows(i).Cells(2).Text, gvfulldata.Rows(i).Cells(3).Text, gvfulldata.Rows(i).Cells(4).Text, gvfulldata.Rows(i).Cells(5).Text, gvfulldata.Rows(i).Cells(6).Text, gvfulldata.Rows(i).Cells(7).Text, gvfulldata.Rows(i).Cells(8).Text, gvfulldata.Rows(i).Cells(9).Text)
                dssecondarysales.Insert(gvfulldata.Rows(i).Cells(0).Text, gvfulldata.Rows(i).Cells(1).Text, gvfulldata.Rows(i).Cells(2).Text, gvfulldata.Rows(i).Cells(3).Text, gvfulldata.Rows(i).Cells(4).Text, gvfulldata.Rows(i).Cells(6).Text, gvfulldata.Rows(i).Cells(7).Text, gvfulldata.Rows(i).Cells(8).Text, gvfulldata.Rows(i).Cells(9).Text, gvfulldata.Rows(i).Cells(10).Text, gvfulldata.Rows(i).Cells(11).Text, gvfulldata.Rows(i).Cells(12).Text, gvfulldata.Rows(i).Cells(13).Text, "", "", "", gvfulldata.Rows(i).Cells(14).Text, "", "")
                btnanalyse.Visible = False
                lblanalysemsg.Text = "Data Added Successfully"

            Next


        End If


    End Sub
End Class
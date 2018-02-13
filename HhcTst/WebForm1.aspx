﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HhcTst.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataKeyNames="CITYID" DataSourceID="ObjectDataSource1" ForeColor="Black" GridLines="None">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <Columns>
                <asp:BoundField DataField="CITYID" HeaderText="CITYID" InsertVisible="False" ReadOnly="True" SortExpression="CITYID" />
                <asp:BoundField DataField="CITYNAME" HeaderText="CITYNAME" SortExpression="CITYNAME" />
                <asp:BoundField DataField="STATEID" HeaderText="STATEID" SortExpression="STATEID" />
                <asp:BoundField DataField="ACTIVE" HeaderText="ACTIVE" SortExpression="ACTIVE" />
            </Columns>
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="HhcTst.xsds.datacareTableAdapters.CITiesTableAdapter" UpdateMethod="Update">
            <DeleteParameters>
                <asp:Parameter Name="Original_CITYID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="CITYNAME" Type="String" />
                <asp:Parameter Name="STATEID" Type="Int32" />
                <asp:Parameter Name="ACTIVE" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="CITYNAME" Type="String" />
                <asp:Parameter Name="STATEID" Type="Int32" />
                <asp:Parameter Name="ACTIVE" Type="String" />
                <asp:Parameter Name="Original_CITYID" Type="Int32" />
            </UpdateParameters>
        </asp:ObjectDataSource>
    </form>
</body>
</html>

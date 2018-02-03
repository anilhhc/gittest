<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HhcTst.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server"
             DataSourceID="SqlDataSource1" DataTextField="purshcasequantity" DataValueField="purshcasequantity"
             Height="30px" Width="180px" AutoPostBack="true">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HhcDbConnectionString %>" SelectCommand="SELECT [purshcasequantity] FROM [hhcsecondarysales]"></asp:SqlDataSource>
        <br />
        <asp:DropDownList ID="DropDownList2" runat="server" Height="16px" Width="195px">
            <%--<asp:ListItem Text="static item 1" Value="1" />
     <asp:ListItem Text="static item 2" Value="2" />
     <asp:ListItem Text="static item 3" Value="3" />--%>
        </asp:DropDownList>
        <br />
        <asp:DropDownList ID="DropDownList3" runat="server" Height="16px" Width="195px">
            <asp:ListItem Text="static item 1" Value="1" />
     <asp:ListItem Text="static item 2" Value="2" />
     <asp:ListItem Text="static item 3" Value="3" />
        </asp:DropDownList>
    
        <asp:GridView ID="GridView1" runat="server" BackColor="White" AutoGenerateColumns="true" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
    </form>
</body>
</html>

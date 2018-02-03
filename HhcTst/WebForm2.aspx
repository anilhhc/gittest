<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="HhcTst.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="ddl1" runat="server"></asp:DropDownList>
        <asp:DropDownList ID="ddl2" runat="server"></asp:DropDownList>
        <asp:DropDownList ID="ddl3" runat="server"></asp:DropDownList>
        <asp:DropDownList ID="ddl4" runat="server"></asp:DropDownList>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:Label ID="lbl1" runat="server"></asp:Label>
    </form>
</body>
</html>

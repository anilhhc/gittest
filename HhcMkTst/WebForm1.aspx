<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HhcMkTst.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" Text="Button" />
    
    </div>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <asp:Label ID="lblmsg" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>

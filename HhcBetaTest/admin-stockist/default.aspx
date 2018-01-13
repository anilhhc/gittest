<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/admin-stockist/innebasepage.master" CodeBehind="default.aspx.vb" Inherits="betatesting._default3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="NavigationPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

<div class="col-xs-12 col-sm-12 col-md-12"><asp:Label ID="LblMsg" runat="server" ></asp:Label></div>

<div class="col-xs-12 col-sm-12 col-md-12"> <h3>Stockist's Login</h3></div>
  
<div class="col-xs-12 col-sm-12 col-md-12" style="margin:1% 0;"><asp:TextBox ID="TxtLoginID" runat="server" placeholder="Enter Login Id" CssClass="form-control"></asp:TextBox>
 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" Display="None" runat="server" ControlToValidate="TxtLoginID" ValidationGroup="vgcatlog" ErrorMessage="Enter Name"></asp:RequiredFieldValidator>
</div>
<div class="col-xs-12 col-sm-12 col-md-12" style="margin:1% 0;"><asp:TextBox ID="TxtPwd" runat="server" TextMode="Password" placeholder="Enter Password" CssClass="form-control"></asp:TextBox>
 <asp:RequiredFieldValidator ID="RequiredFieldValidator2" Display="None" runat="server" ControlToValidate="TxtPwd" ValidationGroup="vgcatlog" ErrorMessage="Enter Name"></asp:RequiredFieldValidator>
</div>
<div class="col-xs-12 col-sm-12 col-md-12" style="margin:1% 0;"><asp:Button ID="Button1" runat="server" Text="Sign In" /></div>
</ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

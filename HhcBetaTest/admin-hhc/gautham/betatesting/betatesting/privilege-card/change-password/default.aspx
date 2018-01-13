<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/privilege-card/privilege-card-profile.Master" CodeBehind="default.aspx.vb" Inherits="betatesting._default55" %>

<%@ Register Src="~/privilege-card/privilege-ascx/privilege-change-password.ascx" TagPrefix="uc1" TagName="privilegechangepassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:privilegechangepassword runat="server" ID="privilegechangepassword" />
</asp:Content>

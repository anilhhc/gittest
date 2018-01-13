<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/privilege-card/privilege-card-profile.Master" CodeBehind="default.aspx.vb" Inherits="betatesting._default54" %>

<%@ Register Src="~/privilege-card/privilege-ascx/privilege-add-details.ascx" TagPrefix="uc1" TagName="privilegeadddetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:privilegeadddetails runat="server" ID="privilegeadddetails" />
</asp:Content>

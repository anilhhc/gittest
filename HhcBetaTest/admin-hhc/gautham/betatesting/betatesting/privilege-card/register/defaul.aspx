<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/privilege-card/privilege-card-inner.Master" CodeBehind="defaul.aspx.vb" Inherits="betatesting.defaul" %>

<%@ Register Src="~/privilege-card/privilege-ascx/privilege-register.ascx" TagPrefix="uc1" TagName="privilegeregister" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:privilegeregister runat="server" ID="privilegeregister" />
</asp:Content>

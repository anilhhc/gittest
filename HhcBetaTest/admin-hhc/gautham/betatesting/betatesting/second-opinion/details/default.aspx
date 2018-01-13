<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/second-opinion/second-opinion-profile.Master" CodeBehind="default.aspx.vb" Inherits="betatesting._default63" %>

<%@ Register Src="~/second-opinion/second-opinion-ascx/second-opinion-details.ascx" TagPrefix="uc1" TagName="secondopiniondetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:secondopiniondetails runat="server" ID="secondopiniondetails" />
</asp:Content>

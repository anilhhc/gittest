<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/second-opinion/second-opinion-profile.Master" CodeBehind="default.aspx.vb" Inherits="betatesting._default65" %>

<%@ Register Src="~/second-opinion/second-opinion-ascx/second-opinion-profile.ascx" TagPrefix="uc1" TagName="secondopinionprofile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:secondopinionprofile runat="server" ID="secondopinionprofile" />
</asp:Content>

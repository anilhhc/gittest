<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/second-opinion/second-opinion-profile.Master" CodeBehind="default.aspx.vb" Inherits="betatesting._default61" %>

<%@ Register Src="~/second-opinion/second-opinion-ascx/second-opinion-add-details.ascx" TagPrefix="uc1" TagName="secondopinionadddetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:secondopinionadddetails runat="server" id="secondopinionadddetails" />
</asp:Content>

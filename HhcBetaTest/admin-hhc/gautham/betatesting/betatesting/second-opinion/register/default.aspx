<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/second-opinion/second-opinion-inner.Master" CodeBehind="default.aspx.vb" Inherits="betatesting._default66" %>

<%@ Register Src="~/second-opinion/second-opinion-ascx/second-opinion-register.ascx" TagPrefix="uc1" TagName="secondopinionregister" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:secondopinionregister runat="server" ID="secondopinionregister" />
</asp:Content>

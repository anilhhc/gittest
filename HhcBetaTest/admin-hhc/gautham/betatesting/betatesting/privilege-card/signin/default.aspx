<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/privilege-card/privilege-card-inner.Master" CodeBehind="default.aspx.vb" Inherits="betatesting._default59" %>

<%@ Register Src="~/privilege-card/privilege-ascx/privilege-signin.ascx" TagPrefix="uc1" TagName="privilegesignin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:privilegesignin runat="server" ID="privilegesignin" />
</asp:Content>

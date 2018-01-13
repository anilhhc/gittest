<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="second-opinion-forgot-password.ascx.vb" Inherits="betatesting.second_opinion_forgot_password" %>


<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
                	<img src="../../images/kims_logo.jpg" style="float:left; padding-right:20px;"></a>
<img src="../resources/images/sign-in.jpg" style="float:left; margin-right:3px;">
             	<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:Panel ID="Panel1" runat="server"  Width="600px">
    <asp:TextBox ID="TxtEmail" runat="server" CssClass="textbox" Width="190" Placeholder="Enter Your Email Id"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RFVEmail" runat="server" 
                ControlToValidate="TxtEmail" Display="None" 
                ErrorMessage="Should Enter Email Address" ValidationGroup="VG"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="REVEmail" runat="server" 
                ControlToValidate="TxtEmail" Display="None" 
                ErrorMessage="Should enter Valid Email Address" 
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                ValidationGroup="VG"></asp:RegularExpressionValidator>
            <asp:ImageButton ID="ImgSubmit" runat="server" 
              ImageUrl="~/images/submit.jpg" ValidationGroup="VG" />
  <ajaxToolkit:ValidatorCalloutExtender ID="VRFVEmail" runat="server" TargetControlID="RFVEmail"></ajaxToolkit:ValidatorCalloutExtender>
  <ajaxToolkit:ValidatorCalloutExtender ID="VREVEmail" runat="server" TargetControlID="REVEmail"></ajaxToolkit:ValidatorCalloutExtender>
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="lnkfont" 
                        NavigateUrl="~/second-opinion/sign-in/">Create a new Kims Privilege Account</asp:HyperLink>
    </asp:Panel>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#6D7192" Text="We have emailed your password to the email id you provided.
" Visible="False"></asp:Label>

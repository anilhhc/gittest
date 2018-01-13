<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="privilege-forgot-password.ascx.vb" Inherits="betatesting.privilege_forgot_password" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

             
    <asp:Panel ID="Panel1" runat="server" Width="395px">
              <asp:TextBox ID="TxtEmail" runat="server" CssClass="textbox" Width="190" Placeholder="Enter Your Email Id"></asp:TextBox>
 
   
            <asp:RequiredFieldValidator ID="RFVEmail" runat="server" 
                ControlToValidate="TxtEmail" Display="None" 
                ErrorMessage="Should Enter Email Address" ValidationGroup="VG"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="REVEmail" runat="server" 
                ControlToValidate="TxtEmail" Display="None" 
                ErrorMessage="Should enter Valid Email Address" 
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                ValidationGroup="VG"></asp:RegularExpressionValidator></td>
            
            	<asp:ImageButton ID="ImgSubmit" runat="server" 
                ImageUrl="~/images/submit.jpg" ValidationGroup="VG" />
 
  <ajaxToolkit:ValidatorCalloutExtender ID="VRFVEmail" runat="server" TargetControlID="RFVEmail"></ajaxToolkit:ValidatorCalloutExtender>
  <ajaxToolkit:ValidatorCalloutExtender ID="VREVEmail" runat="server" TargetControlID="REVEmail"></ajaxToolkit:ValidatorCalloutExtender>
    
                   <asp:HyperLink ID="HyperLink1" runat="server" CssClass="lnkfont" 
                        NavigateUrl="~/privilege-card/register/">Create a new KIMS Privilege Account</asp:HyperLink>
    </asp:Panel>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#6D7192" Text="We have emailed your password to the email id you provided.
" Visible="False"></asp:Label>
             

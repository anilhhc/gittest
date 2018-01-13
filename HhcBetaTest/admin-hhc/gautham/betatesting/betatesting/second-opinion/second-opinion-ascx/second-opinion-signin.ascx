<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="second-opinion-signin.ascx.vb" Inherits="betatesting.second_opinion_signin" %>

        

<asp:Label ID="LblMsg" runat="server" Font-Bold="True" 
        Font-Size="Medium"></asp:Label>
               	  <asp:TextBox ID="TxtEmailId" runat="server" placeholder="Enter existing email-id" CssClass="form-control"></asp:TextBox>
            		<asp:RegularExpressionValidator ID="REVEmailID" runat="server" 
                	ControlToValidate="TxtEmailId" Display="None" ErrorMessage="Invalid Email ID" 
                	ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        	<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="TxtEmailId" Display="None" ErrorMessage="Email Id Required!"></asp:RequiredFieldValidator>
    
                  <asp:TextBox ID="txtpassword" type="password" runat="server" placeholder="Enter password" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="txtpassword" Display="None" ErrorMessage="Password Required!"></asp:RequiredFieldValidator>
         
                	<asp:Button ID="BtnSave" runat="server" Text="SIGN IN" style="background-color: #03abd4; color:#fff;width: 100px; height: 35px; font-family: 'allerregular'; margin-right:5px; border:1px solid #ccc;" />
        			<asp:ValidationSummary ID="ValidationSummary1" runat="server" 
            		ShowMessageBox="True" ShowSummary="False" />
<p>
    g</p>


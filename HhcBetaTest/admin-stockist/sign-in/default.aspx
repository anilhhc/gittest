<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/admin-stockist/innebasepage.master" CodeBehind="Default.aspx.vb" Inherits="betatesting._Default38" %>
<asp:Content ID="Content1" ContentPlaceHolderID="NavigationPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">


<div class="col-md-12 col-sm-12 col-xs-12">
 <h3>Login to your account</h3>
        <asp:Label ID="LblMsg" runat="server" Font-Bold="True" 
        Font-Size="Medium" style="color:#f00;"></asp:Label>
<br>
    <asp:TextBox ID="TxtEmailId" runat="server" placeholder="Enter existing email-id" CssClass="form-control"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="TxtEmailId" Display="None" ErrorMessage="Enter emailid/mobile/sapid!"></asp:RequiredFieldValidator>

    <br>
         <asp:TextBox ID="txtpassword" type="password" runat="server" placeholder="Enter password" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="txtpassword" Display="None" ErrorMessage="Password Required!"></asp:RequiredFieldValidator>
        
<br>



        	<asp:Button ID="BtnSave" runat="server" Text="SIGN IN" style="background-color:#0072bc; border:1px #0072bc solid; color:#fff; width: 100px; padding:10px;" />
        			
        			<asp:ValidationSummary ID="ValidationSummary1" runat="server" 
            		ShowMessageBox="True" ShowSummary="False" />
    </div>
  
</asp:Content>

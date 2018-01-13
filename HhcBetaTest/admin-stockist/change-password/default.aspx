<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/admin-stockist/innebasepage.master" CodeBehind="default.aspx.vb" Inherits="betatesting._default33" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    
      <div class="col-md-12 col-sm-12 col-xs-12"><h3>Change Your Password</h3></div>
      <div class="col-md-12 col-sm-12 col-xs-12">
        <asp:TextBox ID="TxtOldPassword" TextMode="password" runat="server" CssClass="form-control" placeholder="Old Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFVOldPwd" runat="server" 
                        ControlToValidate="TxtOldPassword" Display="None" 
                        ErrorMessage="Enter Old Password"></asp:RequiredFieldValidator>

<br>
        <asp:TextBox ID="TxtNewPassword" TextMode="password" runat="server" CssClass="form-control" placeholder="New Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFVNewPassword" runat="server" 
                        ControlToValidate="TxtNewPassword" Display="None" 
                        ErrorMessage="Enter New Password"></asp:RequiredFieldValidator>

<br>
        <asp:Label ID="lblmsg" runat="server" Text="Label"></asp:Label>
<br>

        <asp:TextBox ID="TxtConfirmPassword" TextMode="password" runat="server" CssClass="form-control" placeholder="Confirm New Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFVConfPassword" runat="server" 
                        ControlToValidate="TxtConfirmPassword" Display="None" 
                        ErrorMessage="Enter Confirm Password"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CVPassword" runat="server" 
                        ControlToCompare="TxtNewPassword" ControlToValidate="TxtConfirmPassword" 
                        Display="None" ErrorMessage="Confirm Password Should Be Same As New Password"></asp:CompareValidator>
    

<br>
         <asp:Button ID="BtnSave" runat="server" Text="SAVE" style="background-color:#0072bc; border:1px #0072bc solid; color:#fff; width: 100px; padding:10px;"/> 
                <br />
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                    ShowMessageBox="True" ShowSummary="False" />


    </div>
</asp:Content>

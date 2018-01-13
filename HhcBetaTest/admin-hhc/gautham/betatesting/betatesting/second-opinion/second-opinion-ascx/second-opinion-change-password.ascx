<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="second-opinion-change-password.ascx.vb" Inherits="betatesting.second_opinion_change_password" %>
        
             	<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
         <asp:Label ID="LblMsg" runat="server"> 
         </asp:Label>
        <asp:TextBox ID="TxtOldPassword" runat="server" CssClass="form-control" placeholder="Old Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFVOldPwd" runat="server" 
                        ControlToValidate="TxtOldPassword" Display="None" 
                        ErrorMessage="Enter Old Password"></asp:RequiredFieldValidator>
        <asp:TextBox ID="TxtNewPassword" runat="server" CssClass="form-control" placeholder="New Password"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RFVNewPassword" runat="server" 
                      ControlToValidate="TxtNewPassword" Display="None" 
                    ErrorMessage="Enter New Password"></asp:RequiredFieldValidator>
                <asp:TextBox ID="TxtConfirmPassword" runat="server" CssClass="form-control" placeholder="Confirm New Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFVConfPassword" runat="server" 
                ControlToValidate="TxtConfirmPassword" Display="None" 
                ErrorMessage="Enter Confirm Password"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CVPassword" runat="server" 
                ControlToCompare="TxtNewPassword" ControlToValidate="TxtConfirmPassword" 
                Display="None" ErrorMessage="Confirm Password Should Be Same As New Password"></asp:CompareValidator>
                <asp:Button ID="BtnSave" runat="server" Text="SAVE" /> 
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                    ShowMessageBox="True" ShowSummary="False" />




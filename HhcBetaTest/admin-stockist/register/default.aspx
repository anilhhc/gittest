﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/admin-stockist/innebasepage.master" CodeBehind="Default.aspx.vb" Inherits="betatesting._Default37" %>
<asp:Content ID="Content1" ContentPlaceHolderID="NavigationPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">

    
      <div class="col-md-12 col-sm-12 col-xs-12"><h3>Register Your Account</h3></div>

      <div class="col-md-12 col-sm-12 col-xs-12">

         <asp:TextBox ID="txtfirstname" runat="server"  placeholder="Stockist  First Name" CssClass="form-control"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RFVName" runat="server" 
                        ControlToValidate="txtfirstname" ErrorMessage="Enter First  Name" 
                        Display="None" ValidationGroup="VGEnquiry" > </asp:RequiredFieldValidator>
<br>

           <asp:TextBox ID="txtlastname" runat="server"  placeholder="Stockist Last Name"  CssClass="form-control"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="Rfvlastname" runat="server" 
                        ControlToValidate="txtlastname" ErrorMessage="Enter Last Name" 
                        Display="None" ValidationGroup="VGEnquiry" > </asp:RequiredFieldValidator>

<br>
          <a href="../sign-in/"></a>
           <asp:TextBox ID="txtEmailId" name="txtEmailId" runat="server"  placeholder="Official Email id" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RFVEmailId" runat="server" 
                    ControlToValidate="txtEmailId" Display="None" ErrorMessage="Enter  Email Id" ValidationGroup="VGEnquiry" ></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="REVEmailId" runat="server" 
                    ControlToValidate="txtEmailId" Display="None" 
                    ErrorMessage="Invalid Email ID" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="VGEnquiry"> </asp:RegularExpressionValidator>

<br>
             <asp:TextBox ID="txtmobilenumber" runat="server" Width="100%" placeholder="Mobile Number" CssClass="form-control"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RFVTelephone" runat="server" Display="None"  ErrorMessage="Enter Telephone Number" ControlToValidate="txtmobilenumber" ValidationGroup="VGEnquiry" InitialValue="Type Telephone*"></asp:RequiredFieldValidator>

<br>

        <asp:Button ID="btnSubmit" runat="server" Text="Submit" ValidationGroup="VGEnquiry" style="background-color:#0072bc; border:1px #0072bc solid; color:#fff; width: 100px; padding:10px;"/> &nbsp;&nbsp;
                    <asp:Button ID="BtnCancel" runat="server" Text="Cancel" style="background-color:#0072bc; border:1px #0072bc solid; color:#fff; width: 100px; padding:10px;"/> &nbsp;&nbsp;
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ShowSummary="False" ValidationGroup="VGEnquiry" />
           <asp:ValidationSummary ID="ValidationSummary2" runat="server" ShowMessageBox="True" ShowSummary="False" ValidationGroup="VGEnquiry" />

<br><br>
        <asp:Label ID="lblmsg" runat="server" Text="" style="color:#f00;"></asp:Label>
    </div>

</asp:Content>

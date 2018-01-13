<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="second-opinion-register.ascx.vb" Inherits="betatesting.second_opinion_register" %>

        	<img src="/privilege-card/files/_images/logo.png" class="img-responsive logo_img">
          <img src="_images/tumblr.png" class="img-responsive social_img">
          <img src="_images/facebook.png" class="img-responsive social_img">
          <img src="/privilege-card/files/_images/banner-one.jpg" alt="Slide1">
       <img src="../images/scond-opinion-banner.jpg" width="100%" >
<a href="/second-opinion/sign-in/">Already Registed Click here to sign in</a>
<asp:Label ID="LblMsg" runat="server" Text=""></asp:Label>
    <asp:TextBox ID="txtEmailId" name="txtEmailId" runat="server" placeholder="Email Id" Width="200"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RFVEmailId" runat="server" 
        ControlToValidate="txtEmailId" Display="None" ErrorMessage="Enter Email Id" ValidationGroup="VGEnquiry" InitialValue="Type Email*"></asp:RequiredFieldValidator>
       <asp:RegularExpressionValidator ID="REVEmailId" runat="server" 
                    ControlToValidate="txtEmailId" Display="None" 
                    ErrorMessage="Invalid Email ID" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="VGEnquiry"> </asp:RegularExpressionValidator>
     <asp:TextBox ID="txtfirstname" placeholder="First Name" runat="server" Width="200"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RFVName" runat="server" placeholder=" Name"
                   ControlToValidate="txtfirstname" ErrorMessage="Enter First Name" 
                  Display="None" ValidationGroup="VGEnquiry" InitialValue="Type Name*"> </asp:RequiredFieldValidator></>
                <asp:TextBox ID="txtmobilenumber"  placeholder="Mobile Number" runat="server" Width="200"></asp:TextBox>
           <asp:RequiredFieldValidator ID="RFVTelephone" runat="server" Display="None"  ErrorMessage="Enter Telephone Number" ControlToValidate="txtmobilenumber" ValidationGroup="VGEnquiry" InitialValue="Type Telephone*"></asp:RequiredFieldValidator>

                     <asp:TextBox ID="txtlastname" placeholder="Corporate Name" runat="server" Width="200"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="Rfvlastname" runat="server" 
                        ControlToValidate="txtlastname" ErrorMessage="Enter Corporate Name" 
                        Display="None" ValidationGroup="VGEnquiry" InitialValue="Type Name*"> </asp:RequiredFieldValidator>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" ValidationGroup="VGEnquiry" />
                    <asp:Button ID="BtnCancel" runat="server" Text="Cancel" /> &nbsp;&nbsp;
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ShowSummary="False" ValidationGroup="VGEnquiry" />
           <asp:ValidationSummary ID="ValidationSummary2" runat="server" ShowMessageBox="True" ShowSummary="False" ValidationGroup="VGEnquiry" />
  
             <img src="../images/StepsPhoto.jpg" width="100%" alt=""/>

<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="privilege-register.ascx.vb" Inherits="betatesting.privilege_register" %>

         
         <img src="/privilege-card/files/_images/banner.jpg" alt="Slide1">
       <img src="../images/cardiac-banner.jpg" width="100%" >
      <asp:Label ID="LblMsg" runat="server" Text=""></asp:Label>
    <asp:TextBox ID="txtEmailId" name="txtEmailId" runat="server" placeholder="Email Id" Width="200">


    </asp:TextBox>
                        <asp:RequiredFieldValidator ID="RFVEmailId" runat="server" 
                    ControlToValidate="txtEmailId" Display="None" ErrorMessage="Enter Email Id" ValidationGroup="VGEnquiry" InitialValue="Type Email*"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="REVEmailId" runat="server" 
                    ControlToValidate="txtEmailId" Display="None" 
                    ErrorMessage="Invalid Email ID" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="VGEnquiry"> </asp:RegularExpressionValidator>
  <asp:TextBox ID="txtfirstname" placeholder=" Name" runat="server" Width="200"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RFVName" runat="server" 
                        ControlToValidate="txtfirstname" ErrorMessage="Enter  Name" 
                        Display="None" ValidationGroup="VGEnquiry" InitialValue="Type Name*"> </asp:RequiredFieldValidator>
                            <asp:TextBox ID="txtmobilenumber"  placeholder="Mobile Number" runat="server" Width="200"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RFVTelephone" runat="server" Display="None"  ErrorMessage="Enter Telephone Number" ControlToValidate="txtmobilenumber" ValidationGroup="VGEnquiry" InitialValue="Type Telephone*"></asp:RequiredFieldValidator>

                     <asp:TextBox ID="txtcorporatename" placeholder="Corporate Name" runat="server" Width="200"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtcorporatename" ErrorMessage="Enter Corporate Name" 
                        Display="None" ValidationGroup="VGEnquiry" InitialValue="Type Name*"> </asp:RequiredFieldValidator>
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" ValidationGroup="VGEnquiry" />
                    <asp:Button ID="BtnCancel" runat="server" Text="Cancel" /> 
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ShowSummary="False" ValidationGroup="VGEnquiry" />
           <asp:ValidationSummary ID="ValidationSummary2" runat="server" ShowMessageBox="True" ShowSummary="False" ValidationGroup="VGEnquiry" />
                       <img src="../images/f-box.jpg" width="32" height="32" alt=""/>
                          <img src="../images/s-box.jpg" width="32" height="32" alt=""/>
                      <img src="../images/t-box.jpg" width="32" height="32" alt=""/>
                      <img src="../images/f4-box.jpg" width="32" height="32" alt=""/>
                      <img src="../images/f5-box.jpg" width="32" height="32" alt=""/>
            
            
  

      <a href="#">KIMS Hospitals&#8482;: Secunderabad</a> | <a href="#">Nellore</a> | <a href="#">Rajahmundry</a> | <a href="#">Srikakulam</a> | <a href="#">Kondapur</a><br>
  
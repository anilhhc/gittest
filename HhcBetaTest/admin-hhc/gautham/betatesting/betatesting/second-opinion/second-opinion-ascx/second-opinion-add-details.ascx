<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="second-opinion-add-details.ascx.vb" Inherits="betatesting.add_details" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<%@ Register TagName="Right" TagPrefix="R" Src="~/secondopinion.ascx" %>

                          <a  href="/second-opinion/change-password" title="Payment"><img src="../images/changepassword2.jpg" style="float:left; margin-right:3px;" ></a>
                         <asp:ImageButton ID="ImgBtnLogOut" runat="server" ImageUrl="../images/logou1.jpg" CausesValidation="False" style="float:left;"/> 
                           
             	<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
       <ContentTemplate>
                  <asp:DropDownList ID="ddlrelation" runat="server" AppendDataBoundItems="true" AutoPostBack="true" Width="198" Height="30">
                     <asp:ListItem Value="0">Relation</asp:ListItem>
                     </asp:DropDownList>
                <asp:RequiredFieldValidator ID="Rfvrelation" runat="server" ControlToValidate="ddlrelation" Display="None" ErrorMessage="Please Select Relation" InitialValue="0" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator>
<asp:TextBox ID="TxtName" runat="server"  placeholder="Enter First Name" Width="230"></asp:TextBox>
 <asp:RequiredFieldValidator ID="RFVName" runat="server" ControlToValidate="TxtName" Display="None" ErrorMessage="Please Enter First Name" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator>
           <asp:TextBox ID="txtlastname" runat="server"  placeholder="Enter Last Name" Width="230"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtlastname" Display="None" ErrorMessage="Please EnterLast  Name" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator>
            <asp:DropDownList ID="ddlgender" runat="server" AppendDataBoundItems="True" Width="230">
                              <asp:ListItem Value="0">-- Select Gender --</asp:ListItem>
                          </asp:DropDownList>
           
            <asp:TextBox ID="txtmarritalstatus" runat="server" placeholder="Age" Width="230"></asp:TextBox>
            <asp:TextBox ID="txtoccupation" runat="server" placeholder="Age" Width="230"></asp:TextBox></td>           
            <asp:TextBox ID="txtAge" runat="server" placeholder="Age" Width="230"></asp:TextBox></td>           
           <asp:TextBox ID="txtTelephone" runat="server" placeholder="Enter Telephone Number" Width="230"></asp:TextBox>
           <asp:TextBox ID="TxtMobile" runat="server"  placeholder="Enter Mobile Number" Width="230"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RFVMobile" runat="server" ControlToValidate="TxtMobile" Display="None" ErrorMessage="Please Enter Mobile Number" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator>
          <asp:RegularExpressionValidator ID="REVMobile" runat="server" ControlToValidate="TxtMobile" Display="None" ErrorMessage="Invalid Mobile Number" ValidationExpression="[0-9]*" ValidationGroup="Appointmentinner"></asp:RegularExpressionValidator>
          <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" placeholder="Enter Address" Width="230"></asp:TextBox>
           
           <asp:TextBox ID="txtCity" runat="server" placeholder="Enter Your City" Width="230"></asp:TextBox>
           <asp:TextBox ID="txtState" runat="server" placeholder="Enter Your State" Width="230"></asp:TextBox>
           <asp:TextBox ID="txtcountry" runat="server" placeholder="Enter Country" Width="230"></asp:TextBox>
           <asp:TextBox ID="txtZipcode" runat="server" placeholder="Enter Pin Code" Width="230"></asp:TextBox>
           
         <asp:TextBox ID="txtreligion" runat="server" placeholder="Enter Telephone Number" Width="230"></asp:TextBox>
           <asp:TextBox ID="txtnationality" runat="server" placeholder="Enter Telephone Number" Width="230"></asp:TextBox>
           <asp:TextBox ID="txtbloodgroup" runat="server" placeholder="Enter Telephone Number" Width="230"></asp:TextBox>
           <asp:TextBox ID="txtEmailId" runat="server"  placeholder="Enter Email Id" Width="230"></asp:TextBox>
           <asp:RequiredFieldValidator ID="RFVEmailId" runat="server" ControlToValidate="txtEmailId" Display="None" ErrorMessage="Please Enter Email Id" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator>
           <asp:RegularExpressionValidator ID="REVEmailId" runat="server" ControlToValidate="txtEmailId" Display="None" ErrorMessage="Invalid Email Id" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="Appointmentinner"></asp:RegularExpressionValidator>
           
                                  <asp:DropDownList ID="DDLSpecialisation" runat="server" AppendDataBoundItems="true" AutoPostBack="true" Width="230">
                                      <asp:ListItem Value="0">Specialisation</asp:ListItem>
                                  </asp:DropDownList>
                          <asp:RequiredFieldValidator ID="RFVLocation" runat="server" ControlToValidate="DDLSpecialisation" Display="None" ErrorMessage="Please Select specilisation" InitialValue="0" ValidationGroup="Appointmentinner" ></asp:RequiredFieldValidator>
           <asp:TextBox ID="txtYourDoctor" runat="server" Columns="35" Rows="2" TextMode="MultiLine" placeholder="Enter Your Doctor Name" Width="230"></asp:TextBox>
           <asp:TextBox ID="txtDiagnosis" runat="server" Width="230"></asp:TextBox>
           <asp:FileUpload ID="FUNewsImage" runat="server" />
           <asp:TextBox ID="txtQuery" runat="server" Columns="65" Height="75px" Rows="5" TextMode="MultiLine" placeholder="Enter Your Query" Width="230"></asp:TextBox>
           <asp:RequiredFieldValidator ID="RFVComments" runat="server" ControlToValidate="txtQuery" Display="None" ErrorMessage="Enter Query" InitialValue="Type Message" ValidationGroup="VGEnquiry"></asp:RequiredFieldValidator>
            <asp:TextBox ID="TxtKeyValue" runat="server" autocomplete="off" class="inputtextfield" placeholder="Enter Key Value" Width="230"></asp:TextBox>
            <asp:Label ID="LblMsg" runat="server" Text=""></asp:Label></td>
                <asp:Button ID="btnSave" runat="server" Text="Save" ValidationGroup="Appointmentinner" />
                   <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ShowSummary="False" ValidationGroup="Appointmentinner" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
                    <asp:GridView ID="gvprofile" runat="server" AllowPaging="True"  style="border-color:#ADADAD;"
                    AutoGenerateColumns="False"  CellPadding="10" PagerSettings-PageButtonCount="20"  >
                        <RowStyle CssClass="GridRowStyle" />
                        <AlternatingRowStyle CssClass="GridAlternateRowStyle"   />
                        <HeaderStyle CssClass="GridHeaderStyle" />
                    <Columns>
                        <asp:TemplateField ShowHeader="False"  >
                            <ItemTemplate>
                                            <%# Eval("FirstName")%> <%# Eval("LastName")%>
                            </ItemTemplate>
                        </asp:TemplateField>  
                    </Columns>
                </asp:GridView>    
            
</center>
     <asp:Label ID="filename" runat="server" Text="" Visible="False"></asp:Label>
      <asp:Label ID="fileId" runat="server" Text="" Visible="False"></asp:Label>
    <asp:Label ID="LblSearchStr" runat="server" Text="" Visible="False"></asp:Label>
    <asp:Label ID="LblGridDataSource" runat="server" Text="" Visible="False"></asp:Label>
  
  </ContentTemplate>
   </asp:UpdatePanel>

<script language="javascript" type="text/javascript">
    function ValidateKeyValue(source, args)
    {
        if(document.getElementById('<%= TxtKeyValue.ClientID %>').value == <%= Session("CaptchaImageText") %>)
        {
            args.IsValid = true; 
    }
    else
    {
            args.IsValid = false;
    }
        
    } 
</script> 

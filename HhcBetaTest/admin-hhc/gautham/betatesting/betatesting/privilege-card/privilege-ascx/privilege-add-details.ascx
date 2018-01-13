<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="privilege-add-details.ascx.vb" Inherits="betatesting.privilege_add_details" %>




<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

    
          <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
          <Triggers>
            <asp:PostBackTrigger ControlID="btnSave" />
          </Triggers>
          <ContentTemplate>



              <asp:Label ID="Label1" runat="server"></asp:Label>
              <asp:Label ID="LblMsg" runat="server"></asp:Label>

                <asp:DropDownList ID="ddlrelation" runat="server" AppendDataBoundItems="true" AutoPostBack="true" Width="198" Height="30">
                        <asp:ListItem Value="0">Relation</asp:ListItem>
                      </asp:DropDownList>


               <asp:RequiredFieldValidator ID="Rfvrelation" runat="server" ControlToValidate="ddlrelation" Display="None" ErrorMessage="Please Select Relation" InitialValue="0" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator>


                <asp:TextBox ID="txtEmailId" runat="server" CssClass="forminputtextfieldapp3" placeholder="Enter Email Id" Width="198"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RFVEmailId" runat="server" ControlToValidate="txtEmailId" Display="None" ErrorMessage="Please Enter Email Id" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="REVEmailId" runat="server" ControlToValidate="txtEmailId" Display="None" ErrorMessage="Invalid Email Id" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="Appointmentinner"></asp:RegularExpressionValidator>


        
                    <asp:TextBox ID="txtfirstname" runat="server" MaxLength="25" CssClass="forminputtextfieldapp3" placeholder="Enter First Name" Width="198"></asp:TextBox>
                 
                  <asp:RequiredFieldValidator ID="RFVName" runat="server" ControlToValidate="txtfirstname" Display="None" ErrorMessage="Please Enter First Name" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator></td>
             
                    <asp:TextBox ID="txtlastname" runat="server" MaxLength="25" CssClass="forminputtextfieldapp3" placeholder="Enter Last Name" Width="198"></asp:TextBox>
                 
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtlastname" Display="None" ErrorMessage="Please Enter Last Name" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator></td>
            <asp:RadioButtonList ID="RBLGender" CssClass="Space" runat="server" 
                         RepeatDirection="Horizontal" CellPadding="10" CellSpacing="10">
                    <asp:ListItem Value="Male" Text=" Male &nbsp;&nbsp;&nbsp;&nbsp;" ></asp:ListItem>
                    <asp:ListItem Value="Female" Text=" Female " ></asp:ListItem>
                  </asp:RadioButtonList>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="RBLGender" Display="None" ErrorMessage="Please Enter Gender" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator></td>
             <asp:TextBox ID="TxtPatientDOB" CssClass="date-bt" runat="server"></asp:TextBox>
                  <asp:ImageButton id="Image1" runat="Server" ImageUrl="~/images/Calendar_scheduleHS.png" AlternateText="Click to show calendar" CausesValidation="False"></asp:ImageButton>
                  <asp:RequiredFieldValidator ID="RFVDate" runat="server"
           ControlToValidate="TxtPatientDOB" Display="None" ErrorMessage="Enter Date of Birth"
           ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator>
                 
            
                    <asp:TextBox ID="txtgardianname" runat="server" MaxLength="25" CssClass="forminputtextfieldapp3" placeholder="Enter Husband /Father Name" Width="198"></asp:TextBox>
                 
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtgardianname" Display="None" ErrorMessage="Please Enter Husband /Father Name" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator></td>
             
                    <asp:TextBox ID="txtmothername" runat="server" MaxLength="25" CssClass="forminputtextfieldapp3" placeholder="Enter Mother Name" Width="198"></asp:TextBox>
                 
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtmothername" Display="None" ErrorMessage="Please Enter Mother Name" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator></td>
             <asp:RadioButtonList ID="RBLmarriage" CssClass="Space" runat="server" 
                         RepeatDirection="Horizontal" CellPadding="10" CellSpacing="10">
                    <asp:ListItem Value="Married" Text=" Married " ></asp:ListItem>
                    <asp:ListItem Value="Unmarried" Text=" Un-married " ></asp:ListItem>
                  </asp:RadioButtonList>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator210" runat="server" ControlToValidate="RBLmarriage" Display="None" ErrorMessage="Choos anyone" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator></td>
             <asp:TextBox ID="txtmobilenumber" runat="server"  MaxLength="15" CssClass="forminputtextfieldapp3" placeholder="Enter Mobile Number" Width="198" ></asp:TextBox>
                 
                  <asp:RequiredFieldValidator ID="RFVMobile" runat="server" ControlToValidate="txtmobilenumber" Display="None" ErrorMessage="Please Enter Mobile Number" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="REVMobile" runat="server" ControlToValidate="txtmobilenumber" Display="None" ErrorMessage="Invalid Mobile Number" ValidationExpression="[0-9]*" ValidationGroup="Appointmentinner"></asp:RegularExpressionValidator></td>
             <asp:TextBox ID="txtoccupation" runat="server" MaxLength="35" CssClass="forminputtextfieldapp3" placeholder="Enter Company Name" Width="198"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtoccupation" Display="None" ErrorMessage="Please Enter Company Name" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator></td>
             <asp:TextBox ID="txtDesignation" runat="server" MaxLength="25" CssClass="forminputtextfieldapp3" placeholder="Enter Designation" Width="198"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtDesignation" Display="None" ErrorMessage="Please Enter Designation" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator></td>
           
                      <asp:DropDownList ID="ddlnationality" runat="server" AppendDataBoundItems="true" AutoPostBack="true" Width="198" >
                        <asp:ListItem Value="0">Select Nationality</asp:ListItem>
                      </asp:DropDownList>
                  
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator99" runat="server" ControlToValidate="ddlnationality" Display="None" ErrorMessage="Please Select Country" InitialValue="0" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator></td>
             <asp:TextBox ID="txtreligion" runat="server" MaxLength="15" CssClass="forminputtextfieldapp3" placeholder="Enter Religion" Width="198"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="txtreligion" Display="None" ErrorMessage="Please Enter Religion" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator></td>
             <asp:TextBox ID="txtbloodgroup" MaxLength="15" runat="server"  TextMode="MultiLine" Rows="1" Columns="25"></asp:TextBox>
            <asp:TextBox ID="txtadress" runat="server" Rows="2" TextMode="MultiLine" Columns="25" CssClass="forminputtextfieldapp3" placeholder="Enter Adress" Width="198"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtadress" Display="None" ErrorMessage="Please Enter Address" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator></td>
              
                      <asp:DropDownList ID="DDLEnquiry_Country" runat="server" AppendDataBoundItems="true" AutoPostBack="true" Width="198" Height="30">
                        <asp:ListItem Value="0">Select Country</asp:ListItem>
                      </asp:DropDownList>
                 
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="DDLEnquiry_Country" Display="None" ErrorMessage="Please Select Country" InitialValue="0" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator></td>
           
                      <asp:DropDownList ID="ddlstate" runat="server" AppendDataBoundItems="true" AutoPostBack="true" Width="198" Height="30">
                        <asp:ListItem Value="0">Select State</asp:ListItem>
                      </asp:DropDownList>
                  
                  <asp:RequiredFieldValidator ID="Rfvstate" runat="server" ControlToValidate="ddlstate" Display="None" ErrorMessage="Please Select State" InitialValue="0" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator></td>
           
                      <asp:DropDownList ID="DDLCITY" runat="server" AppendDataBoundItems="true" AutoPostBack="true" Width="198" Height="30">
                        <asp:ListItem Value="0">Select City</asp:ListItem>
                      </asp:DropDownList>
                   
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="DDLCITY" Display="None" ErrorMessage="Please Select City" InitialValue="0" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator></td>
             <asp:TextBox ID="txtZipcode" runat="server" MaxLength="15" placeholder="Enter Pin Code" Width="230"></asp:TextBox>
             <asp:FileUpload ID="FUNewsImage" runat="server" />
                  <asp:RequiredFieldValidator ID="RFVImage" runat="server" 
                ControlToValidate="FUNewsImage" Display="None" 
                ErrorMessage="Upload Proof" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator>
            <asp:Button ID="btnSave" runat="server" Text="Save" ValidationGroup="Appointmentinner" />
                  &nbsp;&nbsp;
                  <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ShowSummary="False" ValidationGroup="Appointmentinner" />
                  <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
                  &nbsp;&nbsp;
            </ContentTemplate>
            </asp:UpdatePanel>
       
          <asp:GridView ID="gvprofile" runat="server" AllowPaging="True"  style="border-color:#ADADAD;"
                    AutoGenerateColumns="False"  CellPadding="10" PagerSettings-PageButtonCount="20"  >
            <RowStyle CssClass="GridRowStyle" />
            <AlternatingRowStyle CssClass="GridAlternateRowStyle"   />
            <HeaderStyle CssClass="GridHeaderStyle" />
            <Columns>
            <asp:TemplateField ShowHeader="False"  >
              <ItemTemplate>
            <%# Eval("FirstName")%> <%# Eval("LastName")%>
                     
                   <asp:LinkButton ID="LnkBtnEdit" runat="server" CausesValidation="false" 
                                    CommandName="CmdEdit" CommandArgument='<%# Eval("PrevilegecardFamilymembersdetailsID")%>'
                                    Text="Edit"></asp:LinkButton>
                     
                      <asp:LinkButton ID="LnkBtnDelete" runat="server" CausesValidation="false" 
                                    CommandName="CmdDelete" CommandArgument='<%# Eval("PrevilegecardFamilymembersdetailsID")%>'
                                    onclientclick="return confirm('Are You Sure You Want To Delete');" 
                                    Text="Delete"></asp:LinkButton>
                      <a href='/privilege-card/proofs/<%# Eval("Idproof")%>'  target="_blank">View Proof</a>
                    
              </ItemTemplate>
            </asp:TemplateField>
            </Columns>
          </asp:GridView>
         
        <asp:Label ID="filename" runat="server" Text="" Visible="False"></asp:Label>
        <asp:Label ID="fileId" runat="server" Text="" Visible="False"></asp:Label>
        <asp:Label ID="LblSearchStr" runat="server" Text="" Visible="False"></asp:Label>
        <asp:Label ID="LblGridDataSource" runat="server" Text="" Visible="False"></asp:Label>
       
          <asp:LinkButton ID="lnkprintall" runat="server" Text="Print Family Card" Font-Size="15" OnClientClick="return PostToNewWindow();" style="color:#fff;"></asp:LinkButton>
        
<script type="text/javascript">
    function PostToNewWindow() {
        originalTarget = document.forms[0].target;
        document.forms[0].target = '_blank';
        window.setTimeout("document.forms[0].target=originalTarget;", 300);
        return true;
    }
</script>

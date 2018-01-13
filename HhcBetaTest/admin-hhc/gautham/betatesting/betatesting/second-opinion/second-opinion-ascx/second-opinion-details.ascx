<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="second-opinion-details.ascx.vb" Inherits="betatesting.second_opinion_details" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
            <asp:ImageButton ID="ImgBtnLogOut" runat="server" ImageUrl="../resources/images/logou1.jpg" CausesValidation="False" style="float:left;"/>
          <a  href="/corp/sign-in.aspx" class="login-bg" title="Sign Out">Sign In</a>
      <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
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
     <asp:TextBox ID="TxtName" runat="server"  MaxLength="25" placeholder="Enter First Name" Width="230"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RFVName" runat="server" ControlToValidate="TxtName" Display="None" ErrorMessage="Please Enter First Name" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator>
     <asp:TextBox ID="txtlastname" runat="server"  MaxLength="25" placeholder="Enter Last Name" Width="230"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtlastname" Display="None" ErrorMessage="Please EnterLast  Name" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator>
          <asp:RadioButtonList ID="RBLGender" CssClass="Space" runat="server">
            <asp:ListItem Value="Male" Text=" Male &nbsp;&nbsp;&nbsp;&nbsp;" ></asp:ListItem>
           <asp:ListItem Value="Female" Text=" Female " ></asp:ListItem>
           </asp:RadioButtonList>
           <asp:RequiredFieldValidator ID="rfvmother" runat="server" ControlToValidate="RBLGender" Display="None" ErrorMessage="Please Enter Gender" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator>
                <asp:TextBox ID="TxtPatientDOB" CssClass="date-bt" runat="server"></asp:TextBox>
            <asp:ImageButton ID="Image1" runat="Server" ImageUrl="~/images/Calendar_scheduleHS.png" AlternateText="Click to show calendar" CausesValidation="False"></asp:ImageButton>
                  <asp:RequiredFieldValidator ID="RFVDate" runat="server"
           ControlToValidate="TxtPatientDOB" Display="None" ErrorMessage="Enter Date of Birth"
           ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator>
                  <cc1:calendarextender id="CalendarExtender1" runat="server" PopupButtonID="Image1" TargetControlID="TxtPatientDOB"></cc1:calendarextender>
                 <asp:TextBox ID="txtgardianname" runat="server" MaxLength="25" CssClass="forminputtextfieldapp3" placeholder="Enter Husband /Father Name" Width="198"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtgardianname" Display="None" ErrorMessage="Please Enter Husband /Father Name" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator></td>
                    <asp:TextBox ID="txtmothername" runat="server" MaxLength="25" CssClass="forminputtextfieldapp3" placeholder="Enter Mother Name" Width="198"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtmothername" Display="None" ErrorMessage="Please Enter Mother Name" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator></td>
                <asp:RadioButtonList ID="RBLmarriage" CssClass="Space" runat="server" 
                 RepeatDirection="Horizontal" CellPadding="10" CellSpacing="10">
                   <asp:ListItem Value="Married" Text=" Married " ></asp:ListItem>
                   <asp:ListItem Value="Unmarried" Text=" Un-married " ></asp:ListItem>
                 </asp:RadioButtonList>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator210" runat="server" ControlToValidate="RBLmarriage" Display="None" ErrorMessage="Choos anyone" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator>
                    <asp:TextBox ID="txtmobilenumber" runat="server" MaxLength="15" CssClass="forminputtextfieldapp3" placeholder="Enter Mobile Number" Width="198" ></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RFVMobile" runat="server" ControlToValidate="txtmobilenumber" Display="None" ErrorMessage="Please Enter Mobile Number" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="REVMobile" runat="server" ControlToValidate="txtmobilenumber" Display="None" ErrorMessage="Invalid Mobile Number" ValidationExpression="[0-9]*" ValidationGroup="Appointmentinner"></asp:RegularExpressionValidator></td>
                <asp:TextBox ID="txtoccupation" runat="server" MaxLength="35"  CssClass="forminputtextfieldapp3" placeholder="Enter Company Name" Width="198"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtoccupation" Display="None" ErrorMessage="Please Enter Company Name" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator>
                <asp:TextBox ID="txtDesignation" runat="server" MaxLength="25" CssClass="forminputtextfieldapp3" placeholder="Enter Designation" Width="198"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtDesignation" Display="None" ErrorMessage="Please Enter Designation" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator>
                <asp:TextBox ID="txtadress" runat="server" Rows="2" TextMode="MultiLine" Columns="25" TCssClass="forminputtextfieldapp3" placeholder="Enter Adress" Width="198"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtadress" Display="None" ErrorMessage="Please Enter Address" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator>
                      <asp:DropDownList ID="DDLEnquiry_Country" runat="server" AppendDataBoundItems="true" AutoPostBack="true" Width="198" >
                        <asp:ListItem Value="0">Select Country</asp:ListItem>
                      </asp:DropDownList>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="DDLEnquiry_Country" Display="None" ErrorMessage="Please Select Country" InitialValue="0" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator>
                      <asp:DropDownList ID="ddlstate" runat="server" AppendDataBoundItems="true" AutoPostBack="true" Width="198" Height="30">
                        <asp:ListItem Value="0">Select State</asp:ListItem>
                      </asp:DropDownList>
                  <asp:RequiredFieldValidator ID="Rfvstate" runat="server" ControlToValidate="ddlstate" Display="None" ErrorMessage="Please Select State" InitialValue="0" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator>
                      <asp:DropDownList ID="DDLCITY" runat="server" AppendDataBoundItems="true" AutoPostBack="true" Width="198" Height="30">
                        <asp:ListItem Value="0">Select City</asp:ListItem>
                      </asp:DropDownList>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="DDLCITY" Display="None" ErrorMessage="Please Select City" InitialValue="0" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator>
              <asp:TextBox ID="txtZipcode" MaxLength="10" runat="server" placeholder="Enter Pin Code" Width="230"></asp:TextBox>
             <asp:TextBox ID="txtreligion" MaxLength="15" runat="server" placeholder="Enter Religion" Width="230"> </asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="txtreligion" Display="None" ErrorMessage="Please Enter Religion" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator></td>
                      <asp:DropDownList ID="ddlnationality" runat="server" MaxLength="15" AppendDataBoundItems="true" AutoPostBack="true" Width="198" >
                        <asp:ListItem Value="0">Select Nationality</asp:ListItem>
                      </asp:DropDownList>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator99" runat="server" ControlToValidate="ddlnationality" Display="None" ErrorMessage="Please Select Country" InitialValue="0" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator>
                <asp:TextBox ID="txtbloodgroup" runat="server" MaxLength="15" placeholder="Enter Blood Group" Width="230"></asp:TextBox>
                <asp:TextBox ID="txtEmailId" runat="server"  placeholder="Enter Email Id" Width="230"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RFVEmailId" runat="server" ControlToValidate="txtEmailId" Display="None" ErrorMessage="Please Enter Email Id" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="REVEmailId" runat="server" ControlToValidate="txtEmailId" Display="None" ErrorMessage="Invalid Email Id" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="Appointmentinner"></asp:RegularExpressionValidator></td>
                      <asp:DropDownList ID="DDLSpecialisation" runat="server" AppendDataBoundItems="true" AutoPostBack="true" Width="230">
                        <asp:ListItem Value="0">Specialisation</asp:ListItem>
                      </asp:DropDownList>
                  <asp:RequiredFieldValidator ID="RFVLocation" runat="server" ControlToValidate="DDLSpecialisation" Display="None" ErrorMessage="Please Select specilisation" InitialValue="0" ValidationGroup="Appointmentinner" ></asp:RequiredFieldValidator></td>
                <asp:TextBox ID="txtYourDoctor" runat="server" MaxLength="25" Columns="35" Rows="2" TextMode="MultiLine" placeholder="Enter Your Doctor Name" Width="230"></asp:TextBox></td>
                <asp:TextBox ID="txtDiagnosis" MaxLength="50" runat="server" Width="230"></asp:TextBox></td>
                <asp:TextBox ID="txtQuery" runat="server" Columns="65" Height="75px" Rows="5" TextMode="MultiLine" placeholder="Enter Your Query" Width="230"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RFVComments" runat="server" ControlToValidate="txtQuery" Display="None" ErrorMessage="Enter Query" InitialValue="Type Message" ValidationGroup="VGEnquiry"></asp:RequiredFieldValidator></td>
              <asp:Button ID="btnSave" runat="server" Text="Save" ValidationGroup="Appointmentinner" />
               <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ShowSummary="False" ValidationGroup="Appointmentinner" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
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
                <table border="0" cellspacing="0" cellpadding="0"   class="member"  >
                  <tr>
                  <tbody>
                  <td  align="left" valign="top" style="font-size:15px;" width="350"><%# Eval("FirstName")%> <%# Eval("LastName")%>
                      <%-- <%# Eval("EmailID")%>--%></td>
                      <a href='/second-opinion/details/upload-reports.aspx?id=<%# Eval("SecondopinionmembersdetailsId")%>'  target="_blank">Upload reports</a>&nbsp;|&nbsp;
              </ItemTemplate>
            </asp:TemplateField>
            </Columns>
          </asp:GridView>
        <asp:Label ID="filename" runat="server" Text="" Visible="False"></asp:Label>
        <asp:Label ID="fileId" runat="server" Text="" Visible="False"></asp:Label>
        <asp:Label ID="LblSearchStr" runat="server" Text="" Visible="False"></asp:Label>
        <asp:Label ID="LblGridDataSource" runat="server" Text="" Visible="False"></asp:Label>
      <div class="major-services"> </div>
    <a href="/privilege-card/"><img src="../images/logo.jpg" style="margin-top:50px;" ></a>
<script type="text/javascript">
    function PostToNewWindow() {
        originalTarget = document.forms[0].target;
        document.forms[0].target = '_blank';
        window.setTimeout("document.forms[0].target=originalTarget;", 300);
        return true;
    }
</script>

<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="second-opinion-profile.ascx.vb" Inherits="betatesting.second_opinion_profile1" %>

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
                <asp:TextBox ID="TxtName" runat="server"  MaxLength="25" placeholder="Enter First Name" Width="230"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RFVName" runat="server" ControlToValidate="TxtName" Display="None" ErrorMessage="Please Enter First Name" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator></>
                      <asp:DropDownList ID="Ddldate" runat="server" AppendDataBoundItems="true"   CssClass="box-a" >
                        <asp:ListItem Value="0">DATE</asp:ListItem>
                          <asp:ListItem Value="01">01</asp:ListItem>
                          <asp:ListItem Value="02">02</asp:ListItem>
                          <asp:ListItem Value="03">03</asp:ListItem>
                          <asp:ListItem Value="04">04</asp:ListItem>
                          <asp:ListItem Value="05">05</asp:ListItem>
                          <asp:ListItem Value="06">06</asp:ListItem>
                          <asp:ListItem Value="07">07</asp:ListItem>
                           <asp:ListItem Value="08">08</asp:ListItem>
                          <asp:ListItem Value="09">09</asp:ListItem>
                          <asp:ListItem Value="10">10</asp:ListItem>
                          <asp:ListItem Value="11">11</asp:ListItem>
                          <asp:ListItem Value="12">12</asp:ListItem>
                          <asp:ListItem Value="13">13</asp:ListItem>
                          <asp:ListItem Value="14">14</asp:ListItem>
                           <asp:ListItem Value="15">15</asp:ListItem>
                          <asp:ListItem Value="16">16</asp:ListItem>
                          <asp:ListItem Value="17">17</asp:ListItem>
                          <asp:ListItem Value="18">18</asp:ListItem>
                          <asp:ListItem Value="19">19</asp:ListItem>
                          <asp:ListItem Value="20">20</asp:ListItem>
                          <asp:ListItem Value="21">21</asp:ListItem>
                           <asp:ListItem Value="22">22</asp:ListItem>
                          <asp:ListItem Value="23">23</asp:ListItem>
                          <asp:ListItem Value="24">24</asp:ListItem>
                          <asp:ListItem Value="25">25</asp:ListItem>
                          <asp:ListItem Value="26">26</asp:ListItem>
                          <asp:ListItem Value="27">27</asp:ListItem>
                          <asp:ListItem Value="28">28</asp:ListItem>
                       <asp:ListItem Value="29">29</asp:ListItem>
                          <asp:ListItem Value="30">30</asp:ListItem>
                          <asp:ListItem Value="31">31</asp:ListItem>
                      </asp:DropDownList>
                  
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Ddldate" Display="None" ErrorMessage="Please Select Date" InitialValue="0" ValidationGroup="Appointmentinner" ></asp:RequiredFieldValidator>
 
                      <asp:DropDownList ID="ddlmonth" runat="server" AppendDataBoundItems="true"   CssClass="box-a" >
                        <asp:ListItem Value="0">Month</asp:ListItem>
                          <asp:ListItem Value="January">January</asp:ListItem>
                           <asp:ListItem Value="February ">February</asp:ListItem>
                          <asp:ListItem Value="March">March</asp:ListItem>
                          <asp:ListItem Value="April">April</asp:ListItem>
                          <asp:ListItem Value="May">May</asp:ListItem>
                           <asp:ListItem Value="June">June</asp:ListItem>
                          <asp:ListItem Value="July">July</asp:ListItem>
                          <asp:ListItem Value="August">August</asp:ListItem>
                            <asp:ListItem Value="September">September</asp:ListItem>
                          <asp:ListItem Value="October">October</asp:ListItem>
                           <asp:ListItem Value="November">Novembe</asp:ListItem>
                          <asp:ListItem Value="December">December</asp:ListItem>
                         
                      </asp:DropDownList>
                   
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddlmonth" Display="None" ErrorMessage="Please Select Month" InitialValue="0" ValidationGroup="Appointmentinner" ></asp:RequiredFieldValidator>


                <asp:TextBox ID="txtyear" runat="server" MaxLength="4" CssClass="box" placeholder="Year" ></asp:TextBox>
                 
                  <asp:RequiredFieldValidator ID="rfvyear" runat="server" ControlToValidate="txtyear" Display="None" ErrorMessage="Please Year" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="revyear" runat="server" ControlToValidate="txtyear" Display="None" ErrorMessage="Invalid Year" ValidationExpression="[0-9]*" ValidationGroup="Appointmentinner"></asp:RegularExpressionValidator>
                  
            <asp:RadioButtonList ID="RBLGender" CssClass="Space" runat="server" 
                         RepeatDirection="Horizontal" CellPadding="10" CellSpacing="10">
                    <asp:ListItem Value="Male" Text=" Male &nbsp;&nbsp;&nbsp;&nbsp;" ></asp:ListItem>
                    <asp:ListItem Value="Female" Text=" Female " ></asp:ListItem>
                  </asp:RadioButtonList>
                  <asp:RequiredFieldValidator ID="rfvmother" runat="server" ControlToValidate="RBLGender" Display="None" ErrorMessage="Please Enter Gender" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator></td>
          

          <asp:TextBox ID="txtoccupation" runat="server" MaxLength="35" CssClass="forminputtextfieldapp3" placeholder="Enter Company Name" Width="198"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" Enabled="false"  ControlToValidate="txtoccupation" Display="None" ErrorMessage="Please Enter Company Name" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator>
                    <asp:TextBox ID="txtmobilenumber" runat="server" MaxLength="15" CssClass="forminputtextfieldapp3" placeholder="Enter Mobile Number" Width="198" ></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RFVMobile" runat="server" ControlToValidate="txtmobilenumber" Display="None" ErrorMessage="Please Enter Mobile Number" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="REVMobile" runat="server" ControlToValidate="txtmobilenumber" Display="None" ErrorMessage="Invalid Mobile Number" ValidationExpression="[0-9]*" ValidationGroup="Appointmentinner"></asp:RegularExpressionValidator>
                     <asp:DropDownList ID="DDLSpecialisation" runat="server" AppendDataBoundItems="true"   CssClass="box-a" >
                        <asp:ListItem Value="0">Select Speciality</asp:ListItem>
                          <asp:ListItem Value="1">specality 1</asp:ListItem>
                           <asp:ListItem Value="2 ">speciality 2</asp:ListItem>
                          <asp:ListItem Value="Ma3rch">March</asp:ListItem>
                          <asp:ListItem Value="April">April</asp:ListItem>
                          <asp:ListItem Value="May">May</asp:ListItem>
                           <asp:ListItem Value="June">June</asp:ListItem>
                          <asp:ListItem Value="July">July</asp:ListItem>
                          <asp:ListItem Value="August">August</asp:ListItem>
                            <asp:ListItem Value="September">September</asp:ListItem>
                          <asp:ListItem Value="October">October</asp:ListItem>
                           <asp:ListItem Value="November">Novembe</asp:ListItem>
                          <asp:ListItem Value="December">December</asp:ListItem>
                         
                      </asp:DropDownList>
                  <asp:RequiredFieldValidator ID="RFVLocation" runat="server" ControlToValidate="DDLSpecialisation" Display="None" ErrorMessage="Please Select specilisation" InitialValue="0" ValidationGroup="Appointmentinner" ></asp:RequiredFieldValidator></td>
            <asp:TextBox ID="txtQuery" runat="server" Columns="65" Height="75px" Rows="5" TextMode="MultiLine" placeholder="Enter Your Query" Width="230"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFVComments" runat="server" ControlToValidate="txtQuery" Display="None" ErrorMessage="Enter Query" InitialValue="Type Message" ValidationGroup="VGEnquiry"></asp:RequiredFieldValidator>
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
                <%# Eval("FirstName")%> 
              </ItemTemplate>
            </asp:TemplateField>
            </Columns>
          </asp:GridView>
          
        <asp:Label ID="filename" runat="server" Text="" Visible="False"></asp:Label>
        <asp:Label ID="fileId" runat="server" Text="" Visible="False"></asp:Label>
        <asp:Label ID="LblSearchStr" runat="server" Text="" Visible="False"></asp:Label>
        <asp:Label ID="LblGridDataSource" runat="server" Text="" Visible="False"></asp:Label>
<script type="text/javascript">
    function PostToNewWindow() {
        originalTarget = document.forms[0].target;
        document.forms[0].target = '_blank';
        window.setTimeout("document.forms[0].target=originalTarget;", 300);
        return true;
    }
</script>

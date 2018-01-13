<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="privilege-profile.ascx.vb" Inherits="betatesting.privilege_profile" %>



<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

          
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
                      
                    <asp:TextBox ID="txtfirstname" runat="server" MaxLength="25" CssClass="forminputtextfieldapp3" placeholder="Enter  Name" Width="198"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RFVName" runat="server" ControlToValidate="txtfirstname" Display="None" ErrorMessage="Please Enter First Name" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator></td>
              commented also delete ok
                <asp:RadioButtonList ID="RBLGender" CssClass="Space" runat="server" 
                         RepeatDirection="Horizontal" CellPadding="10" CellSpacing="10">
                    <asp:ListItem Value="Male" Text=" Male &nbsp;&nbsp;&nbsp;&nbsp;" ></asp:ListItem>
                    <asp:ListItem Value="Female" Text=" Female " ></asp:ListItem>
                  </asp:RadioButtonList>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="RBLGender" Display="None" ErrorMessage="Please Enter Gender" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator></td>
                <asp:TextBox ID="txtoccupation" runat="server" MaxLength="35" CssClass="forminputtextfieldapp3" placeholder="Enter Company Name" Width="198"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" Enabled="false"  ControlToValidate="txtoccupation" Display="None" ErrorMessage="Please Enter Company Name" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator>
              

                    <asp:TextBox ID="txtmobilenumber" runat="server"  MaxLength="15" CssClass="forminputtextfieldapp3" placeholder="Enter Mobile Number" Width="198" ></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RFVMobile" runat="server"  Enabled="false" ControlToValidate="txtmobilenumber" Display="None" ErrorMessage="Please Enter Mobile Number" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="REVMobile" runat="server" ControlToValidate="txtmobilenumber" Display="None" ErrorMessage="Invalid Mobile Number" ValidationExpression="[0-9]*" ValidationGroup="Appointmentinner"></asp:RegularExpressionValidator>
              

                  
                      <asp:DropDownList ID="Ddldate" runat="server" AppendDataBoundItems="true"   CssClass="box-a" >
                        <asp:ListItem Value="0">DATE</asp:ListItem>
                          <asp:ListItem Value="1">DATE</asp:ListItem>
                          <asp:ListItem Value="2">DATE</asp:ListItem>
                          <asp:ListItem Value="3">DATE</asp:ListItem>
                          <asp:ListItem Value="4">DATE</asp:ListItem>
                          <asp:ListItem Value="5">DATE</asp:ListItem>
                          <asp:ListItem Value="6">DATE</asp:ListItem>
                          <asp:ListItem Value="7">DATE</asp:ListItem>
                           <asp:ListItem Value="8">DATE</asp:ListItem>
                          <asp:ListItem Value="9">DATE</asp:ListItem>
                          <asp:ListItem Value="10">DATE</asp:ListItem>
                          <asp:ListItem Value="11">DATE</asp:ListItem>
                          <asp:ListItem Value="12">DATE</asp:ListItem>
                          <asp:ListItem Value="13">DATE</asp:ListItem>
                          <asp:ListItem Value="14">DATE</asp:ListItem>
                           <asp:ListItem Value="15">DATE</asp:ListItem>
                          <asp:ListItem Value="16">DATE</asp:ListItem>
                          <asp:ListItem Value="17">DATE</asp:ListItem>
                          <asp:ListItem Value="18">DATE</asp:ListItem>
                          <asp:ListItem Value="19">DATE</asp:ListItem>
                          <asp:ListItem Value="20">DATE</asp:ListItem>
                          <asp:ListItem Value="21">DATE</asp:ListItem>
                           <asp:ListItem Value="22">DATE</asp:ListItem>
                          <asp:ListItem Value="23">DATE</asp:ListItem>
                          <asp:ListItem Value="24">DATE</asp:ListItem>
                          <asp:ListItem Value="25">DATE</asp:ListItem>
                          <asp:ListItem Value="26">DATE</asp:ListItem>
                          <asp:ListItem Value="27">DATE</asp:ListItem>
                          <asp:ListItem Value="28">DATE</asp:ListItem>
                      </asp:DropDownList>
                  
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Ddldate" Display="None" ErrorMessage="Please Select Date" InitialValue="0" ValidationGroup="Appointmentinner" ></asp:RequiredFieldValidator>
 
                      <asp:DropDownList ID="ddlmonth" runat="server" AppendDataBoundItems="true"   CssClass="box-a" >
                        <asp:ListItem Value="0">Month</asp:ListItem>
                          <asp:ListItem Value="1">Month</asp:ListItem>
                           <asp:ListItem Value="0">Month</asp:ListItem>
                          <asp:ListItem Value="0">Month</asp:ListItem>
                          <asp:ListItem Value="0">Month</asp:ListItem>
                          <asp:ListItem Value="0">Month</asp:ListItem>
                           <asp:ListItem Value="0">Month</asp:ListItem>
                          <asp:ListItem Value="0">Month</asp:ListItem>
                          <asp:ListItem Value="0">Month</asp:ListItem>
                          <asp:ListItem Value="0">Month</asp:ListItem>
                           <asp:ListItem Value="0">Month</asp:ListItem>
                          <asp:ListItem Value="0">Month</asp:ListItem>
                           <asp:ListItem Value="0">Month</asp:ListItem>
                      </asp:DropDownList>
                   
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddlmonth" Display="None" ErrorMessage="Please Select Month" InitialValue="0" ValidationGroup="Appointmentinner" ></asp:RequiredFieldValidator>


                <asp:TextBox ID="txtyear" runat="server" MaxLength="4" CssClass="box" placeholder="Year" ></asp:TextBox>
                 
                  <asp:RequiredFieldValidator ID="rfvyear" runat="server" ControlToValidate="txtyear" Display="None" ErrorMessage="Please Year" ValidationGroup="Appointmentinner"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="revyear" runat="server" ControlToValidate="txtyear" Display="None" ErrorMessage="Invalid Year" ValidationExpression="[0-9]*" ValidationGroup="Appointmentinner"></asp:RegularExpressionValidator>
                  
                <asp:FileUpload ID="FUNewsImage" runat="server" />
                  <asp:RequiredFieldValidator ID="RFVImage" runat="server" 
                ControlToValidate="FUNewsImage" Display="None" 
                ErrorMessage="Upload Proof" ValidationGroup="Appointmentinner" Enabled="false"></asp:RequiredFieldValidator></td>
             
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
                    <asp:LinkButton ID="LnkBtnEdit" runat="server" CausesValidation="false" 
                                    CommandName="CmdEdit" CommandArgument='<%# Eval("PrevilegecardFamilymembersdetailsID")%>'
                                    Text="Edit"></asp:LinkButton>
                      <asp:LinkButton ID="LnkBtnDelete" runat="server" CausesValidation="false" 
                                    CommandName="CmdDelete" CommandArgument='<%# Eval("PrevilegecardFamilymembersdetailsID")%>'
                                    onclientclick="return confirm('Are You Sure You Want To Delete');" 
                                    Text="Delete"></asp:LinkButton>
              </ItemTemplate>
            </asp:TemplateField>
            </Columns>
          </asp:GridView>
        <asp:Label ID="filename" runat="server" Text="" Visible="False"></asp:Label>
        <asp:Label ID="fileId" runat="server" Text="" Visible="False"></asp:Label>
        <asp:Label ID="LblSearchStr" runat="server" Text="" Visible="False"></asp:Label>
        <asp:Label ID="LblGridDataSource" runat="server" Text="" Visible="False"></asp:Label>
              <asp:LinkButton ID="lnkprintall" runat="server" Text="Print Family Card" Font-Size="15" OnClientClick="return PostToNewWindow();" style="color:#fff;"></asp:LinkButton>
      

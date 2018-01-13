<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/admin-hhc/adminbasepage.master" CodeBehind="upload-primary-sales.aspx.vb" Inherits="betatesting.upload_primary_sales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


       <asp:UpdatePanel ID="UpdatePanel1" runat="server">

        <Triggers>
                        <asp:PostBackTrigger ControlID="btnImport" />
                    </Triggers>
       <ContentTemplate>
   <div >
        Stockist
   
    <div>
        <asp:DropDownList ID="ddlstockist" runat="server"   AppendDataBoundItems="true" AutoPostBack="true" Width="198" Height="30">
                        <asp:ListItem Value="">Select Stockist</asp:ListItem>
                      </asp:DropDownList>

        
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator5" Display="None" runat="server" ControlToValidate="ddlstockist" ValidationGroup="vgcatlog" ErrorMessage="Select Any HHC Stockist"></asp:RequiredFieldValidator>
</div>
   
        <asp:DropDownList ID="ddlyears" runat="server">
            <asp:ListItem Text="Select a Year" Value="">         Select a Year</asp:ListItem>
            <asp:ListItem  Value="2017">2017</asp:ListItem>
            <asp:ListItem  Value="2018">2018</asp:ListItem>
            <asp:ListItem  Value="2019">2019</asp:ListItem>
            <asp:ListItem  Value="2020">2020</asp:ListItem>
            <asp:ListItem  Value="2021">2021</asp:ListItem>
            <asp:ListItem  Value="2022">2022</asp:ListItem>
            <asp:ListItem  Value="2023">2023</asp:ListItem>
            <asp:ListItem  Value="2024">2024</asp:ListItem>
            <asp:ListItem  Value="2025">2025</asp:ListItem>
            <asp:ListItem  Value="2026">2026</asp:ListItem>
        </asp:DropDownList>


        <asp:DropDownList ID="ddlmonth" runat="server">
            <asp:ListItem Text="Select a Month" Value="">         Select a Year</asp:ListItem>
            <asp:ListItem  Value="1">Janunary</asp:ListItem>
            <asp:ListItem  Value="2">February</asp:ListItem>
            <asp:ListItem  Value="3">March</asp:ListItem>
            <asp:ListItem  Value="4">April</asp:ListItem>
            <asp:ListItem  Value="5">May</asp:ListItem>
            <asp:ListItem  Value="6">June</asp:ListItem>
            <asp:ListItem  Value="7">July</asp:ListItem>
            <asp:ListItem  Value="8">August</asp:ListItem>
            <asp:ListItem  Value="9">September</asp:ListItem>
            <asp:ListItem  Value="10">October</asp:ListItem>
            <asp:ListItem  Value="11">November</asp:ListItem>
            <asp:ListItem  Value="12">December</asp:ListItem>

        </asp:DropDownList>

         </div>


        <asp:TextBox ID="TxtComments" runat="server" Rows="2" TextMode="MultiLine" Columns="25" placeholder="Description"></asp:TextBox >
    </div>
     <div>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="btnImport" runat="server" Text="Import" OnClick="ImportExcel" />
        <hr />
       


         <asp:GridView ID="GvBannerImages" runat="server"  AllowPaging = "true" pagesize="10000" >






        </asp:GridView>

           <asp:GridView ID="gvfulldata" runat="server"  AllowPaging = "true" visible="false"  AutoGenerateColumns="False" pagesize="10000">



                <Columns>
                          
                         <asp:BoundField DataField="BillingDoc" HeaderText="Billing Document" 
                            SortExpression="0" />
                       <asp:BoundField DataField="BillingDate" HeaderText="Billing Date" 
                            SortExpression="1" />
                     <asp:BoundField DataField="BillingDate" HeaderText="Month" 
                            SortExpression="2" />
                     <asp:BoundField DataField="BillingDate" HeaderText="Year" 
                            SortExpression="3" />
                     <asp:BoundField DataField="BuyerCode" HeaderText="Stockist Sap id" 
                            SortExpression="4" />
                     <asp:BoundField DataField="BuyerCode" HeaderText="Stockist Name" 
                            SortExpression="5" />
                     <asp:BoundField DataField="BuyerCode" HeaderText="Stockist HQ" 
                            SortExpression="6" />
                    <asp:BoundField DataField="BuyerCode" HeaderText="Stockist state" 
                            SortExpression="7" />
                    <asp:BoundField DataField="BuyerCode" HeaderText="stockist zone" 
                            SortExpression="8" />
                    <asp:BoundField DataField="Product" HeaderText="Sap Product Id" 
                            SortExpression="9" />
                     <asp:BoundField DataField="Product" HeaderText="Product Name" 
                            SortExpression="10" />
                     <asp:BoundField DataField="Qty" HeaderText="Qty" 
                            SortExpression="11" />
                     <asp:BoundField DataField="SpecialRate" HeaderText="SpecialRate" 
                            SortExpression="12" />
                     <asp:BoundField DataField="value" HeaderText="Value" 
                            SortExpression="13" />
                     <asp:BoundField DataField="BillingDoc" HeaderText="division" 
                            SortExpression="14" />


                      <asp:BoundField DataField="BillingDoc" HeaderText="Remark" 
                            SortExpression="15" />
                    </Columns>

        </asp:GridView>

         <asp:Button ID="btnanalyse" runat="server" Text="Analyse" Visible="false" />


         <asp:Label ID="lblfilepath" runat="server" Text="" Visible="false"></asp:Label>
         <asp:Label ID="lblstockist" runat="server" Text="" Visible="false"></asp:Label>
         <asp:Label ID="lblyear" runat="server" Text="" Visible="false"></asp:Label>
         <asp:Label ID="lblmonth" runat="server" Text="" Visible="false"></asp:Label>
<asp:Label ID="lblanalysemsg" runat="server" Text="" Visible="false"></asp:Label>
         <asp:Label ID="lblstockistproduct" runat="server" Text="" Visible="false"></asp:Label>
          <asp:GridView ID="GVPrintNews" runat="server" showheader="false" gridlines="none" BorderStyle="None" AlternatingRowStyle-BorderStyle="None" FooterStyle-BorderStyle="None" AllowPaging="True"  PageSize="10000"
        AutoGenerateColumns="False" >
        <HeaderStyle CssClass="GridHeaderStyle" />
        <RowStyle CssClass="GridRowStyle" />
        <AlternatingRowStyle CssClass="GridAlternateRowStyle"  />
        <Columns>
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
 <div class="col-md-12">
 <div class="col-md-2" style="margin:1% 0;  border: 1px #ccc solid; padding: 1%;">                   
                    <asp:LinkButton ID="LnkBtnEdit" runat="server" CausesValidation="false" 
                        CommandName="CmdEdit" CommandArgument='<%# Eval("hhcprimarysaleuploadID")%>'
                        Text="Edit"></asp:LinkButton> &nbsp;|&nbsp;
     <asp:LinkButton ID="LnkBtnview" runat="server" CausesValidation="false" 
                        CommandName="Cmdview" CommandArgument='<%# Eval("filepath")%>'
                        Text="View"></asp:LinkButton> &nbsp;|&nbsp;
                    <asp:LinkButton ID="LnkBtnDelete" runat="server" CausesValidation="false" 
                        CommandName="CmdDelete" CommandArgument='<%# Eval("hhcprimarysaleuploadID")%>'
                        onclientclick="return confirm('Are You Sure You Want To Delete');" 
                        Text="Delete"></asp:LinkButton>
                        </div>


 <div class="col-md-2" style="margin:1% 0;  border: 1px #ccc solid; padding: 1%;"> <%# Eval("filedescription")%></div>
 <div class="col-md-2" style="margin:1% 0;  border: 1px #ccc solid; padding: 1%;"><%# Eval("monthname")%></div>
 <div class="col-md-2" style="margin:1% 0;  border: 1px #ccc solid; padding: 1%;"><%# Eval("year")%></div>
 <div class="col-md-2" style="margin:1% 0;  border: 1px #ccc solid; padding: 1%;"><%# Eval("fileuploaddate")%></div>
     <div class="col-md-2" style="margin:1% 0;  border: 1px #ccc solid; padding: 1%;"><%# Eval("filepath")%></div>
     <div class="col-md-2" style="margin:1% 0;  border: 1px #ccc solid; padding: 1%;"><%# Eval("Status")%></div>
 
 </div>

                </ItemTemplate>
            </asp:TemplateField>  
        
               
        </Columns>
    </asp:GridView>
   
</ContentTemplate>
   </asp:UpdatePanel>


</asp:Content>

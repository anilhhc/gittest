<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/admin-hhc/adminbasepage.master" CodeBehind="manage-vendor-products.aspx.vb" Inherits="betatesting.manage_vendor_products" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
       <ContentTemplate>







    <div>

        Manage Products
    </div>

    <div>
        Product Name
    </div>

    <div>
        <asp:TextBox ID="txtproductname" runat="server"></asp:TextBox>

       
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" Display="None" runat="server" ControlToValidate="txtproductname" ValidationGroup="vgcatlog" ErrorMessage="Enter Stockist Product Name"></asp:RequiredFieldValidator>
</div>
      


      <div>
        Product Description
    </div>

    <div>
        <asp:TextBox ID="txtproductdescription" runat="server"></asp:TextBox>
        
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" Display="None" runat="server" ControlToValidate="txtproductdescription" ValidationGroup="vgcatlog" ErrorMessage="Enter Stockist Product Description"></asp:RequiredFieldValidator>
</div>


    
      <div>
       Comapny Code
    </div>

    <div>
        <asp:TextBox ID="txtcompanycode" runat="server"></asp:TextBox>

       
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" Display="None" runat="server" ControlToValidate="txtcompanycode" ValidationGroup="vgcatlog" ErrorMessage="Enter Stockist Product Company Code"></asp:RequiredFieldValidator>
</div>

    <div>

        HHC Product
    </div>
    <div>
        <asp:DropDownList ID="ddlproducts" runat="server"   AppendDataBoundItems="true" AutoPostBack="true" Width="198" Height="30">
                        <asp:ListItem Value="">Select Product</asp:ListItem>
                      </asp:DropDownList>


        
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator4" Display="None" runat="server" ControlToValidate="ddlproducts" ValidationGroup="vgcatlog" ErrorMessage="Select Any HHC Product"></asp:RequiredFieldValidator>
</div>

   

    <div>
        Stockist
    </div>
    <div>
        <asp:DropDownList ID="ddlstockist" runat="server"   AppendDataBoundItems="true" AutoPostBack="true" Width="198" Height="30">
                        <asp:ListItem Value="">Select Stockist</asp:ListItem>
                      </asp:DropDownList>

        
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator5" Display="None" runat="server" ControlToValidate="ddlstockist" ValidationGroup="vgcatlog" ErrorMessage="Select Any HHC Stockist"></asp:RequiredFieldValidator>
</div>
     <div>
        Stockist Initial Closing Stock
    </div>
    <div>
        <asp:TextBox ID="txtstockistclosing" runat="server"></asp:TextBox>

       
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator6" Display="None" runat="server" ControlToValidate="txtstockistclosing" ValidationGroup="vgcatlog" ErrorMessage="Enter Stockist Closing Stock"></asp:RequiredFieldValidator>
</div>
        <div>
        System Initial Closing Stock
    </div>    
    <div>
        <asp:TextBox ID="txtsystemclosing" runat="server"></asp:TextBox>

       
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator7" Display="None" runat="server" ControlToValidate="txtsystemclosing" ValidationGroup="vgcatlog" ErrorMessage="Enter System Closing Stock "></asp:RequiredFieldValidator>
</div>


           <div>
               Closing Date

           </div>
           <div>

                 <asp:TextBox ID="TxtDate" runat="server"></asp:TextBox><asp:ImageButton id="Image1" runat="Server" ImageUrl="~/images/Calendar_scheduleHS.png" AlternateText="Click to show calendar" CausesValidation="False"></asp:ImageButton>
        <asp:RequiredFieldValidator ID="RFVDate" runat="server" 
            ControlToValidate="TxtDate" Display="None" ErrorMessage="Enter News Date" 
            ValidationGroup="VGSave"></asp:RequiredFieldValidator>
        <BR /><cc1:calendarextender id="CalendarExtender1" runat="server" PopupButtonID="Image1" TargetControlID="TxtDate"></cc1:calendarextender>

           </div>
    <div>
            &nbsp;<asp:Button ID="BtnSave" runat="server" Text="Save" 
                ValidationGroup="vgcatlog" />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ShowSummary="False" ValidationGroup="vgcatlog" />
                </div>
           
       
   
    <div>

          <asp:Label ID="LblMsg" runat="server"></asp:Label>
    </div>
   
  
   <div>
                  <asp:Label ID="filename" runat="server" Text="" Visible="False"></asp:Label>
      <asp:Label ID="fileId" runat="server" Text="" Visible="False"></asp:Label>
       <asp:Label ID="lblstockist" runat="server" Text="" Visible="False"></asp:Label>
    <asp:Label ID="LblSearchStr" runat="server" Text="" Visible="False"></asp:Label>
    <asp:Label ID="LblGridDataSource" runat="server" Text="" Visible="False"></asp:Label>
           </div>
           


    <asp:GridView ID="GVPrintNews" runat="server" AllowPaging="True"  PageSize="1000"
        AutoGenerateColumns="False" >
        <HeaderStyle CssClass="GridHeaderStyle" />
        <RowStyle CssClass="GridRowStyle" />
        <AlternatingRowStyle CssClass="GridAlternateRowStyle" />
        <Columns>
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                   
                    <asp:LinkButton ID="LnkBtnEdit" runat="server" CausesValidation="false" 
                        CommandName="CmdEdit" CommandArgument='<%# Eval("HvproductslistID")%>'
                        Text="Edit"></asp:LinkButton> &nbsp;|&nbsp;
                    <asp:LinkButton ID="LnkBtnDelete" runat="server" CausesValidation="false" 
                        CommandName="CmdDelete" CommandArgument='<%# Eval("HvproductslistID")%>'
                        onclientclick="return confirm('Are You Sure You Want To Delete');" 
                        Text="Delete"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>  
          <asp:BoundField DataField="HvproductslistID" HeaderText="ID" 
                            SortExpression="1" />
            <asp:BoundField DataField="Hproductslistcompanyid" HeaderText="Hetero Sap Id" 
                            SortExpression="2" />
            <asp:BoundField DataField="hvstockistid" HeaderText="Stockist Sap id" 
                            SortExpression="3" />
             <asp:BoundField DataField="HvproductslistNAME" HeaderText="Stockist Product Name" 
                            SortExpression="4" />
             <asp:BoundField DataField="HvproductslistDESC" HeaderText="Stockist Product Description" 
                            SortExpression="5" />
             <asp:BoundField DataField="Hvproductslistcompanyid" HeaderText="Stockist Company Id" 
                            SortExpression="6" />
             <asp:BoundField DataField="Hproductslistcompanyname" HeaderText="Hetero Product Name" 
                            SortExpression="7" />
             <asp:BoundField DataField="hvstockistname" HeaderText="Stockist Sap id" 
                            SortExpression="8" />

            <asp:BoundField DataField="date" HeaderText="Opening Date " 
                            SortExpression="9" />
             <asp:BoundField DataField="stockistclosingstock" HeaderText="Stockist Initial Opening Stock" 
                            SortExpression="10" />

             <asp:BoundField DataField="systemclosingstock" HeaderText="System Intital Opening Stock" 
                            SortExpression="11" />

            
             <asp:BoundField DataField="HvproductslistID" HeaderText="Stockist Purchases" 
                            SortExpression="12" />

            
             <asp:BoundField DataField="HvproductslistID" HeaderText="System Purchases" 
                            SortExpression="13" />

            <asp:BoundField DataField="HvproductslistID" HeaderText="Stockist Sales" 
                            SortExpression="14" />

            
             <asp:BoundField DataField="HvproductslistID" HeaderText="System sales" 
                            SortExpression="15" />
             
              <asp:BoundField DataField="HvproductslistID" HeaderText="Stockist Closing" 
                            SortExpression="16" />

            
             <asp:BoundField DataField="HvproductslistID" HeaderText="System Closing" 
                            SortExpression="17" />
             
            
             <asp:BoundField DataField="HvproductslistID" HeaderText="Varience " 
                            SortExpression="18" />
               
        </Columns>
    </asp:GridView>


                     
</ContentTemplate>
   </asp:UpdatePanel>
</asp:Content>
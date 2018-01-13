<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/admin-stockist/stockistprofile.master" CodeBehind="Default.aspx.vb" Inherits="betatesting._Default35" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>

        Manage Products
    </div>

    <div>
        Product Name
    </div>

    <div>
        <asp:TextBox ID="txtproductname" runat="server"></asp:TextBox>

         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="txtproductname" Display="Dynamic" 
                ErrorMessage="Enter Country Name" ValidationGroup="VGSave"></asp:RequiredFieldValidator>

        </div>


      <div>
        Product Description
    </div>

    <div>
        <asp:TextBox ID="txtproductdescription" runat="server"></asp:TextBox>

         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="txtproductdescription" Display="Dynamic" 
                ErrorMessage="Enter Product Name" ValidationGroup="VGSave"></asp:RequiredFieldValidator>

        </div>


    
      <div>
       Comapny Code
    </div>

    <div>
        <asp:TextBox ID="txtcompanycode" runat="server"></asp:TextBox>

         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="txtcompanycode" Display="Dynamic" 
                ErrorMessage="Enter company code" ValidationGroup="VGSave"></asp:RequiredFieldValidator>

        </div>
    <div>

        Product Closing Stock
    </div>
      <div>
        <asp:TextBox ID="txtclosingstock" runat="server"></asp:TextBox>

         <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                ControlToValidate="txtclosingstock" Display="Dynamic" 
                ErrorMessage="Enter closing stock" ValidationGroup="VGSave"></asp:RequiredFieldValidator>

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
                ValidationGroup="VGSave" />
           
       
    </div>
    <div>

          <asp:Label ID="LblMsg" runat="server"></asp:Label>
    </div>
   
  
   <div>
                  <asp:Label ID="filename" runat="server" Text="" Visible="False"></asp:Label>
      <asp:Label ID="fileId" runat="server" Text="" Visible="False"></asp:Label>
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

            <asp:BoundField DataField="HvproductslistID" HeaderText="Delivered Count" 
                            SortExpression="19" />
            <asp:BoundField DataField="HvproductslistID" HeaderText="In Transit Count" 
                            SortExpression="20" />
             
             <asp:HyperLinkField DataNavigateUrlFields="HvproductslistID" Target="_blank" DataNavigateUrlFormatString="invoice.aspx?Productid={0}"
                Text="View Invoice" />
               
        </Columns>
    </asp:GridView>



</asp:Content>

<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/admin-hhc/adminbasepage.master" CodeBehind="manage-product-division.aspx.vb" Inherits="betatesting.manage_product_division" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
       <ContentTemplate>
      
 <div class="col-xs-12 col-sm-12 col-md-12">
<h1>Manage Products</h1>
    </div>


 <div class="col-xs-12 col-sm-12 col-md-12">
  <div class="col-xs-12 col-sm-12 col-md-6"  style="padding:1% 0;">
        <asp:TextBox ID="txtproducts" runat="server" placeholder="Product Name" CssClass="form-control"></asp:TextBox>

       <asp:RequiredFieldValidator ID="rfvzone" Display="None" runat="server" ControlToValidate="txtproducts" ValidationGroup="vgmanagecity" ErrorMessage="Enter Product Name"></asp:RequiredFieldValidator>
</div>

  <div class="col-xs-12 col-sm-12 col-md-6"  style="padding:1% 0;">
          <asp:TextBox ID="txtproductdescription" runat="server" placeholder="Product Description" CssClass="form-control"></asp:TextBox>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator1" Display="None" runat="server" ControlToValidate="txtproductdescription" ValidationGroup="vgmanagecity" ErrorMessage="Enter Product Description"></asp:RequiredFieldValidator>
  </div>  
  
    <div class="col-xs-12 col-sm-12 col-md-6"  style="padding:1% 0;">
 <asp:TextBox ID="txtsapid" runat="server" placeholder="Hetro Sap Id" CssClass="form-control"></asp:TextBox>
         
              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" Display="None" runat="server" ControlToValidate="txtsapid" ValidationGroup="vgmanagecity" ErrorMessage="Enter Product Sap Id"></asp:RequiredFieldValidator>
    </div>

       <div class="col-xs-12 col-sm-12 col-md-6"  style="padding:1% 0;">
    <asp:DropDownList ID="ddldivision" runat="server" AppendDataBoundItems="true"    CssClass="form-control" AutoPostBack="true" Width="100%" Height="30">
                        <asp:ListItem Value="">Select Division</asp:ListItem>
                      </asp:DropDownList>
         
              <asp:RequiredFieldValidator ID="RequiredFieldValidator3" Display="None" runat="server" ControlToValidate="ddldivision" ValidationGroup="vgmanagecity" ErrorMessage="Select Divison"></asp:RequiredFieldValidator>
    </div>
    
</div>    
    
  <div class="col-xs-12 col-sm-12 col-md-12"  style="padding:1% 0;">

          <asp:Label ID="LblMsg" runat="server"></asp:Label>
    </div>
      

    <div style="text-align:center;">
        <asp:Button ID="btnsave" runat="server" Text="Save" style="background: #0072bc;  color: white; border:1px #0072bc solid; margin:2% 0; text-align:center;"
                ValidationGroup="vgmanagecity" />

     <asp:ValidationSummary ID="ValidationSummary2" runat="server" ShowMessageBox="True" ShowSummary="False" ValidationGroup="vgmanagecity"  />
           </div>
  
      </ContentTemplate>
        </asp:UpdatePanel>
    
    <asp:GridView ID="gvcity" runat="server" AllowPaging="True" 
                    AutoGenerateColumns="False" DataKeyNames="HproductslistID" CellPadding="10" PageSize="1000">
                        <RowStyle CssClass="GridRowStyle" />
                        <AlternatingRowStyle CssClass="GridAlternateRowStyle" />
                        <HeaderStyle CssClass="GridHeaderStyle" />
                    <Columns>
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
                                
                               <asp:LinkButton ID="LnkBtnEdit" runat="server" CausesValidation="false" 
                                    CommandName="CmdEdit" CommandArgument='<%# Eval("HproductslistID")%>'
                                    Text="Edit"></asp:LinkButton> &nbsp;|&nbsp;
                                <asp:LinkButton ID="LnkBtnDelete" runat="server" CausesValidation="false" 
                                    CommandName="CmdDelete" CommandArgument='<%# Eval("HproductslistID")%>'
                                    onclientclick="return confirm('Are You Sure You Want To Delete');" 
                                    Text="Delete" Visible="false"></asp:LinkButton>
                                
                            </ItemTemplate>
                        </asp:TemplateField>  
                        <asp:BoundField DataField="HproductslistNAME" HeaderText="Product Name" 
                            SortExpression="PageUrl" />
                        <asp:BoundField DataField="HproductslistDESC" HeaderText="Product Description" 
                            SortExpression="ImagePath" />
                         <asp:BoundField DataField="Hproductslistcompanyid" HeaderText="Product Sap Id" 
                        SortExpression="sap"  />
                         <asp:BoundField DataField="hdivisionname" HeaderText="Division Name" 
                        SortExpression="hdivisionname"  />
                 
                        
                    </Columns>
                </asp:GridView>

      <asp:Label ID="filename" runat="server" Text="" Visible="False"></asp:Label>
      <asp:Label ID="fileId" runat="server" Text="" Visible="False"></asp:Label>
    <asp:Label ID="LblSearchStr" runat="server" Text="" Visible="False"></asp:Label>
    <asp:Label ID="LblGridDataSource" runat="server" Text="" Visible="False"></asp:Label>
         
    
</asp:Content>

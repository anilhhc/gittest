﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/admin-hhc/adminbasepage.master" CodeBehind="manage-product-description.aspx.vb" Inherits="betatesting.manage_product_description1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
   <div class="col-xs-12 col-sm-12 col-md-12">
   <h1>Heading Name</h1>
   </div>
    
<div class="col-xs-12 col-sm-12 col-md-12" style="margin:1% 0;">
                <asp:TextBox ID="TxtHproductslistdescriptionDESC" runat="server" Rows="2" TextMode="MultiLine" Columns="25" Text="Type Message" placeholder="HproductslistdescriptionDESC" CssClass="form-control" ></asp:TextBox >
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" Display="None" runat="server" ControlToValidate="TxtHproductslistdescriptionDESC" ValidationGroup="vgmanagecity" ErrorMessage="Select Any Zone"></asp:RequiredFieldValidator>
</div>
           
           
<div class="col-xs-12 col-sm-12 col-md-12" style="margin:1% 0;">
                <asp:TextBox ID="txthpdquantityperpack" runat="server" placeholder="hpdquantityperpack" CssClass="form-control"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator2" Display="None" runat="server" ControlToValidate="txthpdquantityperpack" ValidationGroup="vgmanagecity" ErrorMessage="Select Any Zone"></asp:RequiredFieldValidator>
            </div>
          
<div class="col-xs-12 col-sm-12 col-md-12" style="margin:1% 0;">
                <asp:TextBox ID="txthpdquantityperstrip" runat="server" placeholder="hpdquantityperstrip" CssClass="form-control"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator3" Display="None" runat="server" ControlToValidate="txthpdquantityperstrip" ValidationGroup="vgmanagecity" ErrorMessage="Select Any Zone"></asp:RequiredFieldValidator>
            </div>
          
<div class="col-xs-12 col-sm-12 col-md-12" style="margin:1% 0;">
                 <asp:TextBox ID="txthpdratevalidform" runat="server" placeholder="hpdratevalidform" CssClass="form-control"></asp:TextBox>
                <asp:ImageButton id="Image1" runat="Server" ImageUrl="~/images/Calendar_scheduleHS.png" AlternateText="Click to show calendar" CausesValidation="False"></asp:ImageButton>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator4" Display="None" runat="server" ControlToValidate="txthpdratevalidform" ValidationGroup="vgmanagecity" ErrorMessage="Select Any Zone"></asp:RequiredFieldValidator>
        <br/>
                <cc1:CalendarExtender ID="CalendarExtender1" runat="server" PopupButtonID="Image1" TargetControlID="txthpdratevalidform"></cc1:CalendarExtender>

            </div>

            
<div class="col-xs-12 col-sm-12 col-md-12" style="margin:1% 0;">
                 <asp:TextBox ID="txthpdpricetoretailer" runat="server" placeholder="hpdpricetoretailer" CssClass="form-control"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator5" Display="None" runat="server" ControlToValidate="txthpdpricetoretailer" ValidationGroup="vgmanagecity" ErrorMessage="Select Any Zone"></asp:RequiredFieldValidator>
            </div>

            
<div class="col-xs-12 col-sm-12 col-md-12" style="margin:1% 0;">
                 <asp:TextBox ID="txthpdmrp" runat="server" placeholder="hpdmrp" CssClass="form-control"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator7" Display="None" runat="server" ControlToValidate="txthpdmrp" ValidationGroup="vgmanagecity" ErrorMessage="Select Any Zone"></asp:RequiredFieldValidator>
            </div>
            
<div class="col-xs-12 col-sm-12 col-md-12" style="margin:1% 0;">
                 <asp:TextBox ID="txthpdstandardrate" runat="server" placeholder="hpdstandardrate" CssClass="form-control"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator8" Display="None" runat="server" ControlToValidate="txthpdstandardrate" ValidationGroup="vgmanagecity" ErrorMessage="Select Any Zone"></asp:RequiredFieldValidator>
            </div>
            
            
<div class="col-xs-12 col-sm-12 col-md-12" style="margin:1% 0;">
                 <asp:TextBox ID="txthpdpricetostockist" runat="server" placeholder="hpdpricetostockist" CssClass="form-control"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator9" Display="None" runat="server" ControlToValidate="txthpdpricetostockist" ValidationGroup="vgmanagecity" ErrorMessage="Select Any Zone"></asp:RequiredFieldValidator>
            </div>

           
<div class="col-xs-12 col-sm-12 col-md-12" style="margin:1% 0;">
                 <asp:TextBox ID="txthpdbrandname" runat="server" placeholder="hpdbrandname" CssClass="form-control"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator10" Display="None" runat="server" ControlToValidate="txthpdbrandname" ValidationGroup="vgmanagecity" ErrorMessage="Select Any Zone"></asp:RequiredFieldValidator>
            </div>
           
          
<div class="col-xs-12 col-sm-12 col-md-12" style="margin:1% 0;">
                <asp:DropDownList ID="ddlhdpcategoryname" runat="server" CssClass="form-control">

                 <asp:ListItem Value="">Select Caterogy</asp:ListItem>
                    <asp:ListItem Value="1">cat1</asp:ListItem>
                     <asp:ListItem Value="2">cat2</asp:ListItem>
                </asp:DropDownList>

                 <asp:RequiredFieldValidator ID="RequiredFieldValidator11" Display="None" runat="server" ControlToValidate="ddlhdpcategoryname" ValidationGroup="vgmanagecity" ErrorMessage="Select Any Zone"></asp:RequiredFieldValidator>

            </div>
            
           
                
<div class="col-xs-12 col-sm-12 col-md-12" style="margin:1% 0;">
              <asp:ListBox ID="lbBranch" runat="server" SelectionMode="Multiple"  CssClass="form-control"></asp:ListBox></div>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator6" Display="None" runat="server" ControlToValidate="lbBranch" ValidationGroup="vgmanagecity" ErrorMessage="Select Any Division"></asp:RequiredFieldValidator>
   
 
            
<div class="col-xs-12 col-sm-12 col-md-12" style="margin:1% 0;">
                 <asp:TextBox ID="txthdpmanfacturename" runat="server"  CssClass="form-control"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator13" Display="None" runat="server" ControlToValidate="txthdpmanfacturename" ValidationGroup="vgmanagecity" ErrorMessage="Select Any Zone"></asp:RequiredFieldValidator>
            </div>

       
                 <div style="margin:1% 0; text-align:center;">
                      <asp:Button ID="btnSearch" runat="server" Text="Search" />
                  
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" /> &nbsp;&nbsp;
            &nbsp;<asp:Button ID="BtnSave" runat="server" Text="Save" 
                ValidationGroup="vgcatlog" />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ShowSummary="False" ValidationGroup="vgcatlog" />
                </div>

    <div>


        <asp:GridView ID="GVAddVideo" runat="server" AllowPaging="True" 
                    AutoGenerateColumns="False" DataKeyNames="HproductslistdescriptionID" CellPadding="10">
                        <RowStyle CssClass="GridRowStyle" />
                        <AlternatingRowStyle CssClass="GridAlternateRowStyle" />
                        <HeaderStyle CssClass="GridHeaderStyle" />
                  <Columns>
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
            <%--                    <a href='/BannerImages/<%# Eval("ImagePath") %>'  target="_blank">View Image</a> &nbsp;|--%>
                               <asp:LinkButton ID="LnkBtnEdit" runat="server" CausesValidation="false" 
                                    CommandName="CmdEdit" CommandArgument='<%# Eval("HproductslistdescriptionID")%>'
                                    Text="Edit"></asp:LinkButton> &nbsp;|&nbsp;
                                <asp:LinkButton ID="LnkBtnDelete" runat="server" CausesValidation="false" 
                                    CommandName="CmdDelete" CommandArgument='<%# Eval("HproductslistdescriptionID") %>'
                                    onclientclick="return confirm('Are You Sure You Want To Delete');" 
                                    Text="Delete"></asp:LinkButton>
                                ;
                            </ItemTemplate>
                        </asp:TemplateField>  
                        <asp:BoundField DataField="HproductslistdescriptionDESC" HeaderText="Desc" 
                            SortExpression="HproductslistdescriptionDESC" />


                       <asp:BoundField DataField="STATUS" HeaderText="Status" 
                            SortExpression="STATUS" />

                       <asp:BoundField DataField="Hproductslistcompanyid" HeaderText="Product Id" 
                            SortExpression="Hproductslistcompanyid" />


                       <asp:BoundField DataField="hpdquantityperpack" HeaderText="QuatityPerPack" 
                            SortExpression="hpdquantityperpack" />
                        
                       <asp:BoundField DataField="hpdquantityperstrip" HeaderText="QuantityPerStrip" 
                            SortExpression="hpdquantityperstrip" />


                       <asp:BoundField DataField="hpdratevalidform" HeaderText="RateValidForm" 
                            SortExpression="hpdratevalidform" />

                       <asp:BoundField DataField="hpdpricetoretailer" HeaderText="PriceToRetailer" 
                            SortExpression="hpdpricetoretailer" />


                       <asp:BoundField DataField="hpdmrp" HeaderText="Mrp" 
                            SortExpression="hpdmrp" />
                        

                       <asp:BoundField DataField="hpdstandardrate" HeaderText="StandardRate" 
                            SortExpression="hpdstandardrate" />
                        
                       <asp:BoundField DataField="hpdpricetostockist" HeaderText="Price To Stocklist" 
                            SortExpression="hpdpricetostockist	" />


                       <asp:BoundField DataField="hpdbrandname" HeaderText="BrandName" 
                            SortExpression="hpdbrandname" />

                       <asp:BoundField DataField="hdpcategoryname" HeaderText="CategoryName" 
                            SortExpression="hdpcategoryname" />


                       <asp:BoundField DataField="hpddivisionname" HeaderText="DivisionName" 
                            SortExpression="hpddivisionname" />
                        
                       <asp:BoundField DataField="hdpmanfacturename" HeaderText="hdpmanfacturename" 
                            SortExpression="hdpmanfacturename" />
                        
                    </Columns>
                </asp:GridView>
    </div>
    
     <asp:Label ID="filename" runat="server" Text="" Visible="False"></asp:Label>
      <asp:Label ID="fileId" runat="server" Text="" Visible="False"></asp:Label>
    <asp:Label ID="LblSearchStr" runat="server" Text="" Visible="False"></asp:Label>
    <asp:Label ID="LblGridDataSource" runat="server" Text="" Visible="False"></asp:Label>
</asp:Content>


       


    

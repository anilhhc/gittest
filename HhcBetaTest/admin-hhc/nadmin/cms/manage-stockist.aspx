<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/admin-hhc/adminbasepage.master" CodeBehind="manage-stockist.aspx.vb" Inherits="betatesting.manage_stockist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
  
<div>
    
    <asp:GridView ID="gvstockist" runat="server" AllowPaging="True" 
                    AutoGenerateColumns="False" DataKeyNames="HstockistdetailsID" CellPadding="10" PageSize="1000">
                        <RowStyle CssClass="GridRowStyle" />
                        <AlternatingRowStyle CssClass="GridAlternateRowStyle" />
                        <HeaderStyle CssClass="GridHeaderStyle" />
                    <Columns>
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
                                
                               <asp:LinkButton ID="LnkBtnEdit" Visible="false" runat="server" CausesValidation="false" 
                                    CommandName="CmdEdit" CommandArgument='<%# Eval("HstockistdetailsID")%>'
                                    Text="Edit"></asp:LinkButton> &nbsp;|&nbsp;

                            </ItemTemplate>
                        </asp:TemplateField>  
                        <asp:HyperLinkField DataNavigateUrlFields="HstockistdetailsID" DataNavigateUrlFormatString="manage-stockist-details.aspx?stockistid={0}"
                Text="Edit" />
                        <asp:BoundField DataField="hsfullname" HeaderText="Stockist Name" 
                            SortExpression="1" />
                        <asp:BoundField DataField="hslastname" HeaderText="Stockist Last Name" 
                            SortExpression="2" />
                         <asp:BoundField DataField="hsemailid" HeaderText="Email Id" 
                            SortExpression="3" />
                        <asp:BoundField DataField="hsmobile" HeaderText="Mobile Num" 
                            SortExpression="4" />
                        <asp:BoundField DataField="hspwd" HeaderText="Password" 
                            SortExpression="5" />
                         <asp:BoundField DataField="hssapcustomerid" HeaderText="Sap Stockist Id" 
                            SortExpression="6" />
                         <asp:BoundField DataField="hsplotno" HeaderText="Plot Number" 
                            SortExpression="7" />
                        <asp:BoundField DataField="hsadressone" HeaderText="Adress" 
                            SortExpression="8" />
                         <asp:BoundField DataField="hsadresstwo" HeaderText="Adress" 
                            SortExpression="9" />
                        <asp:BoundField DataField="hscountry" HeaderText="Zone" 
                            SortExpression="10" />
                        <asp:BoundField DataField="hsstate" HeaderText="State" 
                            SortExpression="11" />
                         <asp:BoundField DataField="hsheadquater" HeaderText="Head Quarter" 
                            SortExpression="12" />
                         <asp:BoundField DataField="hssubarea" HeaderText="Sub Area" 
                            SortExpression="13" />
                        <asp:BoundField DataField="hsdivision" HeaderText="Division" 
                            SortExpression="14" />
                         <asp:BoundField DataField="hscnf" HeaderText="Cnf" 
                            SortExpression="15" />
                        <asp:BoundField DataField="hstherapatic" HeaderText="Therapatic" 
                            SortExpression="16" />
                        <asp:BoundField DataField="hspincode" HeaderText="Pincode" 
                            SortExpression="17" />
                         <asp:BoundField DataField="hstelephone" HeaderText="Telephone" 
                            SortExpression="18" />
                         <asp:BoundField DataField="hsfax" HeaderText="Fax" 
                            SortExpression="19" />
                        <asp:BoundField DataField="hsgstprovisionalid" HeaderText="GST" 
                            SortExpression="20" />
                         <asp:BoundField DataField="hspan" HeaderText="Pan Card" 
                            SortExpression="21" />
                        <asp:BoundField DataField="hsspocname" HeaderText="Spoc Name" 
                            SortExpression="22" />
                        <asp:BoundField DataField="hsspocmobile" HeaderText="Spoc Number" 
                            SortExpression="23" />
                         <asp:BoundField DataField="hsssistatus" HeaderText="Ssis Status" 
                            SortExpression="24" />
                        <asp:BoundField DataField="hsdruglicenceno" HeaderText="Licence No" 
                            SortExpression="25" />
                         <%--<asp:BoundField DataField="hszone" HeaderText="ACTIVE Status" 
                        SortExpression="ACTIVE" ReadOnly="True" />--%>
                    <%--<asp:TemplateField ShowHeader="False">
                        <ItemTemplate>
                            <asp:LinkButton ID="LnkBtnActiveStatus" runat="server" CausesValidation="false" 
                                CommandName="CmdActive" Text='<%# Eval("ACTIVE") %>' 
                                 ></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>--%>
                        
                    </Columns>
                </asp:GridView>

      <asp:Label ID="filename" runat="server" Text="" Visible="False"></asp:Label>
      <asp:Label ID="fileId" runat="server" Text="" Visible="False"></asp:Label>
    <asp:Label ID="LblSearchStr" runat="server" Text="" Visible="False"></asp:Label>
    <asp:Label ID="LblGridDataSource" runat="server" Text="" Visible="False"></asp:Label>
      </div>


</asp:Content>

<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/admin-stockist/stockistprofile.master" CodeBehind="invoice.aspx.vb" Inherits="betatesting.invoice" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="GVPrintNews" runat="server" AllowPaging="True"  PageSize="1000"
        AutoGenerateColumns="False" >
        <HeaderStyle CssClass="GridHeaderStyle" />
        <RowStyle CssClass="GridRowStyle" />
        <AlternatingRowStyle CssClass="GridAlternateRowStyle" />
        <Columns>
            <asp:BoundField DataField="hhcprimarysalesID" HeaderText="ID" 
                            SortExpression="0" />
          <asp:BoundField DataField="hhcprimarysalesID" HeaderText="ID" 
                            SortExpression="1" />
            <asp:BoundField DataField="billingdocument" HeaderText="Billing Document" 
                            SortExpression="2" />
            <asp:BoundField DataField="billingdate" HeaderText="Billing  Date" 
                            SortExpression="3" />
            
             <asp:BoundField DataField="stockistsapid" HeaderText="Stockist Id" 
                            SortExpression="4" />
            
             <asp:BoundField DataField="stockistname" HeaderText="Stockist Name" 
                            SortExpression="5" />

            <asp:BoundField DataField="heterosapproductname" HeaderText="Product Name" 
                            SortExpression="6" />
             <asp:BoundField DataField="quantity" HeaderText="Quantity" 
                            SortExpression="7" />

             <asp:BoundField DataField="rate" HeaderText="Rate" 
                            SortExpression="8" />

            
             <asp:BoundField DataField="value" HeaderText="Value" 
                            SortExpression="9" />

            
             <asp:BoundField DataField="deliverystatus" HeaderText="Delivery Status" 
                            SortExpression="10" />
  <asp:TemplateField ShowHeader="False">
                        <ItemTemplate>
                            <asp:LinkButton ID="LnkBtnActiveStatus" runat="server" CausesValidation="false" 
                                CommandName="CmdActive" Text='<%# Eval("deliverystatus")  %>' ></asp:LinkButton>
                           
                        </ItemTemplate>
                    </asp:TemplateField>
               
        </Columns>
    </asp:GridView>

</asp:Content>

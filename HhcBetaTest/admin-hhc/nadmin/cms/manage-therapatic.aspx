<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/admin-hhc/adminbasepage.master" CodeBehind="manage-therapatic.aspx.vb" Inherits="betatesting.manage_therapatic" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="col-xs-12 col-sm-12 col-md-12">

        <h1>Manage Therapatic</h1>
    </div>
    
    
     <div>
    
      
    <div class="col-xs-12 col-sm-12 col-md-12" style="margin:1% 0;">           
             <asp:TextBox ID="txtHtherapaticDESC" runat="server" placeholder="Therapatic Description" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" Display="None" runat="server" ControlToValidate="txtHtherapaticDESC" ValidationGroup="vgmanagecity" ErrorMessage="Select Any Zone"></asp:RequiredFieldValidator>
        </div>
      
     

    <div class="col-xs-12 col-sm-12 col-md-12" style="margin:1% 0;">           
                    <asp:TextBox ID="txththeterocode" runat="server" placeholder="Therepatic Hetero Code" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" Display="None" runat="server" ControlToValidate="txththeterocode" ValidationGroup="vgmanagecity" ErrorMessage="Enter Therapatic code"></asp:RequiredFieldValidator>
        </div>
        
       
            
    <div class="col-xs-12 col-sm-12 col-md-12" style="margin:1% 0;">           
            <asp:TextBox ID="txththetroname" runat="server" placeholder="Therapatic Name" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" Display="None" runat="server" ControlToValidate="txththetroname" ValidationGroup="vgmanagecity" ErrorMessage="Enter Therapatic Name"></asp:RequiredFieldValidator>
        </div>
    
    <div class="col-xs-12 col-sm-12 col-md-12" style="margin:1% 0;">          
                   <asp:ListBox ID="lbBranch" runat="server" SelectionMode="Multiple" CssClass="form-control"></asp:ListBox></div>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator6" Display="None" runat="server" ControlToValidate="lbBranch" ValidationGroup="vgmanagecity" ErrorMessage="Select Any Division"></asp:RequiredFieldValidator>
    </div>



    


    <div class="col-xs-12 col-sm-12 col-md-12" style="margin:1% 0; text-align:center;">  
       <asp:Button ID="btnSearch" runat="server" Text="Search" />
                 &nbsp;   &nbsp;
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" />&nbsp;  &nbsp;
                   <asp:Button ID="BtnSave" runat="server" Text="Save" 
                ValidationGroup="vgmanagecity" />


     <asp:ValidationSummary ID="ValidationSummary2" runat="server" ShowMessageBox="True" ShowSummary="False" ValidationGroup="vgmanagecity"  /></div>
           

    <div>
        <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>


        <asp:GridView ID="GVAddVideo" runat="server" AllowPaging="True" 
                    AutoGenerateColumns="False" DataKeyNames="HtherapaticID" CellPadding="10" PageSize="1000" >
                        <RowStyle CssClass="GridRowStyle" />
                        <AlternatingRowStyle CssClass="GridAlternateRowStyle" />
                        <HeaderStyle CssClass="GridHeaderStyle" />
                  <Columns>
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
            <%--                    <a href='/BannerImages/<%# Eval("ImagePath") %>'  target="_blank">View Image</a> &nbsp;|--%>
                               <asp:LinkButton ID="LnkBtnEdit" runat="server" CausesValidation="false" 
                                    CommandName="CmdEdit" CommandArgument='<%# Eval("HtherapaticID")%>'
                                    Text="Edit"></asp:LinkButton> &nbsp;|&nbsp;
                                <asp:LinkButton ID="LnkBtnDelete" runat="server" CausesValidation="false" 
                                    CommandName="CmdDelete" CommandArgument='<%# Eval("HtherapaticID") %>'
                                    onclientclick="return confirm('Are You Sure You Want To Delete');" 
                                    Text="Delete"></asp:LinkButton>
                                ;
                            </ItemTemplate>
                        </asp:TemplateField>  
                        <asp:BoundField DataField="HtherapaticDESC" HeaderText="Descriptions" 
                            SortExpression="HtherapaticDESC" />


                       <asp:BoundField DataField="HtherapaticSTATUS" HeaderText="Status" 
                            SortExpression="HtherapaticSTATUS" />

                       <asp:BoundField DataField="htheterocode" HeaderText="Code" 
                            SortExpression="htheterocode" />


                       <asp:BoundField DataField="hthetroname" HeaderText="Name" 
                            SortExpression="hthetroname" />
                        
                       <asp:BoundField DataField="htdivisionid" HeaderText="Division Id" 
                            SortExpression="htdivisionid" />


                        
                    </Columns>
                </asp:GridView>
    </div>


     <asp:Label ID="filename" runat="server" Text="" Visible="False"></asp:Label>
      <asp:Label ID="fileId" runat="server" Text="" Visible="False"></asp:Label>
    <asp:Label ID="LblSearchStr" runat="server" Text="" Visible="False"></asp:Label>
    <asp:Label ID="LblGridDataSource" runat="server" Text="" Visible="False"></asp:Label>
</asp:Content>

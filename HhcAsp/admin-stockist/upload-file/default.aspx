<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/admin-stockist/stockistprofile.master" CodeBehind="default.aspx.vb" Inherits="betatesting._default39" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div>

    </div>
    <div>
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
        <asp:TextBox ID="TxtComments" runat="server" Rows="2" TextMode="MultiLine" Columns="25" placeholder="Description"></asp:TextBox >
    </div>
     <div>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="btnImport" runat="server" Text="Import" OnClick="ImportExcel" />
        <hr />
       

         <asp:GridView ID="GvBannerImages" runat="server"  AllowPaging = "true"  >
        </asp:GridView>






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
                        CommandName="CmdEdit" CommandArgument='<%# Eval("hstockistuploadID")%>'
                        Text="Edit"></asp:LinkButton> &nbsp;|&nbsp;
     <asp:LinkButton ID="LnkBtnview" runat="server" CausesValidation="false" 
                        CommandName="Cmdview" CommandArgument='<%# Eval("filepath")%>'
                        Text="View"></asp:LinkButton> &nbsp;|&nbsp;
                    <asp:LinkButton ID="LnkBtnDelete" runat="server" CausesValidation="false" 
                        CommandName="CmdDelete" CommandArgument='<%# Eval("hstockistuploadID")%>'
                        onclientclick="return confirm('Are You Sure You Want To Delete');" 
                        Text="Delete"></asp:LinkButton>
                        </div>


 <div class="col-md-2" style="margin:1% 0;  border: 1px #ccc solid; padding: 1%;"> <%# Eval("filedescription")%></div>
 <div class="col-md-2" style="margin:1% 0;  border: 1px #ccc solid; padding: 1%;"><%# Eval("monthname")%></div>
 <div class="col-md-2" style="margin:1% 0;  border: 1px #ccc solid; padding: 1%;"><%# Eval("year")%></div>
 <div class="col-md-2" style="margin:1% 0;  border: 1px #ccc solid; padding: 1%;"><%# Eval("fileuploaddate")%></div>
     <div class="col-md-2" style="margin:1% 0;  border: 1px #ccc solid; padding: 1%;"><%# Eval("filepath")%></div>
     <div class="col-md-2" style="margin:1% 0;  border: 1px #ccc solid; padding: 1%;"><%# Eval("Status")%></div>
 <div class="col-md-2" style="margin:1% 0;  border: 1px #ccc solid; padding: 1%;"><a href='/avana-single.aspx?catlogid=<%# Eval("hstockistuploadID")%>' target="_blank">Edit</a></div>
 </div>

                </ItemTemplate>
            </asp:TemplateField>  
        
               
        </Columns>
    </asp:GridView>
   
</asp:Content>
   
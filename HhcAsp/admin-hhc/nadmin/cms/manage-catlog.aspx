<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Admin-avana/AdminBasePage.master" CodeBehind="manage-catlog.aspx.vb" Inherits="betatesting.manage_catlog" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



       <asp:UpdatePanel ID="UpdatePanel1" runat="server">


           <Triggers>
                        <asp:PostBackTrigger ControlID="btnsave" />
                    </Triggers>

       <ContentTemplate>

           <asp:Label ID="Label1" runat="server" Text="Add New" Visible="false" Cssclass="btn btn-success update-pro"></asp:Label>
       
           <div id="CATLOG" runat="server" >
       
    <div>
        <h3>Manage Catlog</h3>
    </div>
 <div class="col-md-6">

 <div class="col-md-12" style="margin:1% 0;">
       <asp:TextBox ID="txtname" runat="server" placeholder="Enter Name" CssClass="form-control"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" Display="None" runat="server" ControlToValidate="txtname" ValidationGroup="vgcatlog" ErrorMessage="Enter Name"></asp:RequiredFieldValidator>
    </div>


    


 <div class="col-md-12" style="margin:1% 0;">
        <asp:TextBox ID="txtsku" runat="server" placeholder="Enter SKU ID Eg:AVAD10001" CssClass="form-control"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" Display="None" runat="server" ControlToValidate="txtsku" ValidationGroup="vgcatlog" ErrorMessage="Enter SKU ID"></asp:RequiredFieldValidator>
    </div>

 <div class="col-md-12" style="margin:1% 0;">
        <asp:DropDownList ID="ddlcolour" runat="server" AutoPostBack="true" CssClass="form-control" >
            <asp:ListItem Text="Select a Colour" Value="">        Select a Colour</asp:ListItem>
            </asp:DropDownList>
          <asp:RequiredFieldValidator ID="RFVCountry" runat="server" ErrorMessage="Select Colour" ControlToValidate="ddlcolour" Display="None"   ValidationGroup="vgcatlog"></asp:RequiredFieldValidator>
    </div>


    
      <div class="col-md-12" style="margin:1% 0;">
<h3>Long Description</h3>
        <FCKeditorV2:FCKeditor ID="txtlongdescriptiontext" runat="server" Height="400" Width="100%">
                        </FCKeditorV2:FCKeditor>

     </div>
    
     <div class="col-md-12" style="margin:1% 0;">
<h3> Short Description</h3>
      <FCKeditorV2:FCKeditor ID="txtshortdescriptiontext" runat="server" Height="400" Width="100%">
                        </FCKeditorV2:FCKeditor>
      
    </div>
 
 <div class="col-md-12" style="margin:1% 0;">
         <h3>Material</h3>
        <FCKeditorV2:FCKeditor ID="txtmaerial" runat="server" Height="400" Width="100%">
                        </FCKeditorV2:FCKeditor>
       
    </div>

    
</div>

 <div class="col-md-6">
 
  <div class="col-md-12" style="margin:1% 0;">
        <asp:TextBox ID="txtweight" runat="server" placeholder="Enter Weight "  CssClass="form-control"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" Display="None" runat="server" ControlToValidate="txtweight" ValidationGroup="vgcatlog" ErrorMessage="Enter Weight"></asp:RequiredFieldValidator>
    </div>
    
 <div class="col-md-12" style="margin:1% 0;">

        <asp:TextBox ID="txtshipping" runat="server" placeholder="Enter Shipping Details" CssClass="form-control"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" Display="None" runat="server" ControlToValidate="txtshipping" ValidationGroup="vgcatlog" ErrorMessage="Enter Shipping Details"></asp:RequiredFieldValidator>
    </div>

 <div class="col-md-12" style="margin:1% 0;">
        <asp:TextBox ID="txtprice" runat="server" placeholder="Enter Price Details" CssClass="form-control"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" Display="None" runat="server" ControlToValidate="txtprice" ValidationGroup="vgcatlog" ErrorMessage="Enter Price Details"></asp:RequiredFieldValidator>
    </div>

 <div class="col-md-12" style="margin:1% 0;">
        <h3>Measurments</h3>
        <FCKeditorV2:FCKeditor ID="txtmeasurments" runat="server" Height="400" Width="100%">
                        </FCKeditorV2:FCKeditor>
      
    </div>

 <div class="col-md-12" style="margin:1% 0;">
<h3>Care</h3>
        <FCKeditorV2:FCKeditor ID="txtcare" runat="server" Height="400" Width="100%">
                        </FCKeditorV2:FCKeditor>
       
    </div>



 <div class="col-md-12" style="margin:1% 0;">
<h3>Note</h3>
        <FCKeditorV2:FCKeditor ID="txtnote" runat="server" Height="400" Width="100%">
                        </FCKeditorV2:FCKeditor>
     
    </div>



 

</div>

<div class="col-md-12" style="margin:1% 0;">
 <div class="col-md-6" style="margin:1% 0;">
 <div class="col-md-12"><h4>Upload Image 1</h4></div>
<div class="col-md-12" style="margin:1% 0;">

               <asp:Image ID="Image1" runat="server" Visible="false" style="margin:1% 0; width:100%; border:1px #ccc solid; padding:1%"/>
               <asp:Label ID="lblimage1" runat="server" Text=""></asp:Label>

               <asp:FileUpload ID="FUNewsImage"  runat="server" />
              
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator6" Display="None" runat="server" ControlToValidate="FUNewsImage" ValidationGroup="vgcatlog" ErrorMessage="Select Image 1"></asp:RequiredFieldValidator>
           </div>
     </div>
     
 <div class="col-md-6" style="margin:1% 0;">
 <div class="col-md-12"><h4>Upload Image 2</h4></div>
 <div class="col-md-12" style="margin:1% 0;">
               <asp:Image ID="Image2" runat="server" Visible="false"  style="margin:1% 0; width:100%; border:1px #ccc solid; padding:1%" />
               <asp:Label ID="lblimage2" runat="server" Text=""></asp:Label>
               <asp:FileUpload ID="FUNewsImage1"  runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" Display="None" runat="server" ControlToValidate="FUNewsImage1" ValidationGroup="vgcatlog" ErrorMessage="Select Image 2"></asp:RequiredFieldValidator>
           
           </div>
     </div>


 <div class="col-md-6" style="margin:1% 0;">
 <div class="col-md-12"><h4>Upload Image 3</h4></div>
 <div class="col-md-12" style="margin:1% 0;">
               <asp:Image ID="Image3" runat="server" Visible="false"  style="margin:1% 0; width:100%; border:1px #ccc solid; padding:1%"/>
                 <asp:Label ID="lblimage3" runat="server" Text=""></asp:Label>
               <asp:FileUpload ID="FUNewsImage2"  runat="server" />
             
                
           </div>
     </div>


 <div class="col-md-6" style="margin:1% 0;">
 <div class="col-md-12"><h4>Upload Image 4</h4></div>
 <div class="col-md-12" style="margin:1% 0;">
              <asp:Image ID="Image4" runat="server" Visible="false"  style="margin:1% 0; width:100%; border:1px #ccc solid; padding:1%"/>
 <asp:Label ID="lblimage4" runat="server" Text=""></asp:Label>
              <asp:FileUpload ID="FUNewsImage3"  runat="server"  />
              
           </div>
     </div>

 <div class="col-md-6" style="margin:1% 0;">
 <div class="col-md-12"><h4>Upload Image 5</h4></div>
 <div class="col-md-12" style="margin:1% 0;">
             <asp:Image ID="Image5" runat="server" Visible="false"  style="margin:1% 0; width:100%; border:1px #ccc solid; padding:1%"/>
                  <asp:Label ID="lblimage5" runat="server" Text=""></asp:Label>
               <asp:FileUpload ID="FUNewsImage4"  runat="server" />
           </div>
     </div>
     
     </div>

</div>

 <div class="col-md-12" style="margin:1% 0; text-align:center;">
    <asp:Button ID="btnsave" runat="server" Text="Add New" ValidationGroup="vgcatlog" Cssclass="btn btn-success update-pro" />
     <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ShowSummary="False" ValidationGroup="vgcatlog" />
</div>


           <div>
               <asp:Label ID="LblMsg" runat="server" Text=""></asp:Label>

           </div>
           <div>
                  <asp:Label ID="filename" runat="server" Text="" Visible="False"></asp:Label>
      <asp:Label ID="fileId" runat="server" Text="" Visible="False"></asp:Label>
    <asp:Label ID="LblSearchStr" runat="server" Text="" Visible="False"></asp:Label>
    <asp:Label ID="LblGridDataSource" runat="server" Text="" Visible="False"></asp:Label>
           </div>
           
      


    




</ContentTemplate>
   </asp:UpdatePanel>

    <asp:GridView ID="GVPrintNews" runat="server" showheader="false" gridlines="none" BorderStyle="None" AlternatingRowStyle-BorderStyle="None" FooterStyle-BorderStyle="None" AllowPaging="True" 
        AutoGenerateColumns="False" >
        <HeaderStyle CssClass="GridHeaderStyle" />
        <RowStyle CssClass="GridRowStyle" />
        <AlternatingRowStyle CssClass="GridAlternateRowStyle"  />
        <Columns>
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
 <div class="col-md-12">
 <div class="col-md-2" style="margin:1% 0;  border: 1px #ccc solid; padding: 1%; text-align:center;">                   
                   <asp:LinkButton ID="LnkBtnEdit" runat="server" CausesValidation="false" 
                        CommandName="CmdEdit" CssClass="lnr lnr-pencil" CommandArgument='<%# Eval("avanacatlogID")%>'
                        Text=" " style="color:#c11d59;"></asp:LinkButton>
                        &nbsp;|&nbsp; 
                        <a href='/avana-single.aspx?catlogid=<%# Eval("avanacatlogID")%>' target="_blank" style="color:#c11d59;"><i class="lnr lnr-eye"></i> </a>
                        
                      
                   
                        </div>


 <div class="col-md-2" style="margin:1% 0;  border: 1px #ccc solid; padding: 1%;"> <%# Eval("name")%></div>
 <div class="col-md-2" style="margin:1% 0;  border: 1px #ccc solid; padding: 1%;"><%# Eval("sku")%></div>
 <div class="col-md-2" style="margin:1% 0;  border: 1px #ccc solid; padding: 1%;"><%# Eval("weight")%></div>
 <div class="col-md-2" style="margin:1% 0;  border: 1px #ccc solid; padding: 1%;"><%# Eval("price")%></div>
 <div class="col-md-2" style="margin:1% 0;  border: 1px #ccc solid; padding: 1%; text-align:center; background:#c11d59; color:#fff;"> 
  <asp:LinkButton ID="LnkBtnDelete" runat="server" CausesValidation="false" 
                        CommandName="CmdDelete" CssClass="lnr lnr-trash" CommandArgument='<%# Eval("avanacatlogID")%>'
                        onclientclick="return confirm('Are You Sure You Want To Delete');" 
                        Text=" Delete" style="color:#fff;"></asp:LinkButton> </div>
 </div>

                </ItemTemplate>
            </asp:TemplateField>  
        
               
        </Columns>
    </asp:GridView>
   
</asp:Content>




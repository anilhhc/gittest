<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/admin-stockist/stockistprofile.master" CodeBehind="default.aspx.vb" Inherits="betatesting._default36" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

            <div class="col-md-12 col-sm-12 col-xs-12" style="padding:2% 0;">    
            <div class="col-md-4 col-sm-4 col-xs-12">
                <b>FullName</b>
            </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:Label ID="lblhsfullname" runat="server" Text="FullName"></asp:Label>
            </div>
            
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:TextBox ID="txthsfullname" runat="server" Visible="false" CssClass="form-control"></asp:TextBox>
            </div>
            </div>
            
            
<div class="col-md-12 col-sm-12 col-xs-12" style="padding:2% 0;">  
            <div class="col-md-4 col-sm-4 col-xs-12"><b>LastName</b></div>
            <div class="col-md-4 col-sm-4 col-xs-12">   
                <asp:Label ID="lblhslastname" runat="server" Text="LastName"></asp:Label>
            </div>
            <div class="col-md-4 col-sm-4 col-xs-12">  
                <asp:TextBox ID="txthslastname" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

</div>

            <div class="col-md-12 col-sm-12 col-xs-12" style="padding:2% 0;">  
            <div class="col-md-4 col-sm-4 col-xs-12">
                <b>Email Id</b>

            </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:Label ID="lblhsemailid" runat="server" Text="EmailId"></asp:Label>
            </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:TextBox ID="txthsemailid" runat="server"   CssClass="form-control"></asp:TextBox>
            </div>
            </div>



            <div class="col-md-12 col-sm-12 col-xs-12" style="padding:2% 0;">  
            <div class="col-md-4 col-sm-4 col-xs-12">
                <b>Mobile No</b>

            </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:Label ID="lblhsmobile" runat="server" Text="Mobile"></asp:Label>
            </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:TextBox ID="txthsmobile" runat="server"   CssClass="form-control"></asp:TextBox>
            </div>
</div>



            <div class="col-md-12 col-sm-12 col-xs-12" style="padding:2% 0;">  
            <div class="col-md-4 col-sm-4 col-xs-12"><b>Plot No</b>     </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:Label ID="lblhsplotno" runat="server" Text="PlotNo"></asp:Label>
            </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:TextBox ID="txthsplotno" runat="server"   CssClass="form-control"></asp:TextBox>
            </div>
            </div>
            


            <div class="col-md-12 col-sm-12 col-xs-12" style="padding:2% 0;">  
            <div class="col-md-4 col-sm-4 col-xs-12"> <b>Address1</b> </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:Label ID="lblhsadressone" runat="server" Text="Address1"></asp:Label>
            </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:TextBox ID="txthsadressone" runat="server"   CssClass="form-control"></asp:TextBox>
            </div>
            </div>
            
            <div class="col-md-12 col-sm-12 col-xs-12" style="padding:2% 0;">              
            <div class="col-md-4 col-sm-4 col-xs-12"> <b>Address2</b> </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:Label ID="lblhsadresstwo" runat="server" Text="Address2"></asp:Label>
            </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:TextBox ID="txthsadresstwo" runat="server"   CssClass="form-control"></asp:TextBox>
            </div>
</div>


            <div class="col-md-12 col-sm-12 col-xs-12" style="padding:2% 0;">  
            <div class="col-md-4 col-sm-4 col-xs-12"><b>Country</b>   </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:Label ID="lblhscountry" runat="server" Text="Country"></asp:Label>
            </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:DropDownList ID="DDLEnquiry_Country" runat="server" AppendDataBoundItems="true"    CssClass="form-control" AutoPostBack="true" Width="100%" >
                        <asp:ListItem Value="0">Select Country</asp:ListItem>
                      </asp:DropDownList>
            </div>
            </div>
            
            
                 <div class="col-md-12 col-sm-12 col-xs-12" style="padding:2% 0;">         
            <div class="col-md-4 col-sm-4 col-xs-12"><b>State</b></div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:Label ID="lblhsstate" runat="server" Text="State"></asp:Label>
            </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
      <asp:DropDownList ID="ddlstate" runat="server"    CssClass="form-control" AppendDataBoundItems="true" AutoPostBack="true" Width="100%" Height="30">
                                              <asp:ListItem Value="0">Select State</asp:ListItem>
                      </asp:DropDownList>
       
            </div>
            </div>


            <div class="col-md-12 col-sm-12 col-xs-12" style="padding:2% 0;">  
            <div class="col-md-4 col-sm-4 col-xs-12"><b>Head Quarter</b></div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                            <asp:Label ID="lblhsheadquater" runat="server" Text="HeadQuarter"></asp:Label>
            </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
               <asp:DropDownList ID="DDLCITY" runat="server"    CssClass="form-control" AppendDataBoundItems="true" AutoPostBack="true" Width="100%" Height="30">
                        <asp:ListItem Value="0">Select City</asp:ListItem>
                      </asp:DropDownList>
            </div>
</div>


            <div class="col-md-12 col-sm-12 col-xs-12" style="padding:2% 0;">  
            <div class="col-md-4 col-sm-4 col-xs-12"><b>Sub Area</b></div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:Label ID="lblhssubarea" runat="server" Text="SubArea"></asp:Label>
            </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
              <asp:DropDownList ID="ddlsubcity" runat="server"    CssClass="form-control" AppendDataBoundItems="true" AutoPostBack="true" Width="100%" Height="30">
                        <asp:ListItem Value="0">Select Sub City</asp:ListItem>
                      </asp:DropDownList>
            </div>
            </div>
            
            
                        <div class="col-md-12 col-sm-12 col-xs-12" style="padding:2% 0;">  
            <div class="col-md-4 col-sm-4 col-xs-12"><b>Division</b></div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:Label ID="lblhsdivision" runat="server" Text="Division"></asp:Label>
            </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:DropDownList ID="ddldivision" runat="server" AppendDataBoundItems="true"    CssClass="form-control" AutoPostBack="true" Width="100%" Height="30">
                        <asp:ListItem Value="0">Select Division</asp:ListItem>
                      </asp:DropDownList>
            </div>
</div>


            <div class="col-md-12 col-sm-12 col-xs-12" style="padding:2% 0;">  
            <div class="col-md-4 col-sm-4 col-xs-12"><b>Cnf</b></div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:Label ID="lblhscnf" runat="server" Text="Cnf"></asp:Label>
            </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:TextBox ID="txthscnf" runat="server"   CssClass="form-control"></asp:TextBox>
            </div>

</div>


            <div class="col-md-12 col-sm-12 col-xs-12" style="padding:2% 0;">  
            <div class="col-md-4 col-sm-4 col-xs-12"><b>Therapatic</b></div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:Label ID="lblhstherapatic" runat="server" Text="Therapatic"></asp:Label>
            </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                 <asp:DropDownList ID="ddltherapatic" runat="server"    CssClass="form-control" AppendDataBoundItems="true" AutoPostBack="true" Width="100%" Height="30">
                        <asp:ListItem Value="0">Select Division</asp:ListItem>
                      </asp:DropDownList>
            </div>
            </div>
            
            
            
            
                        <div class="col-md-12 col-sm-12 col-xs-12" style="padding:2% 0;">  
            <div class="col-md-4 col-sm-4 col-xs-12"><b>PinCode</b></div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:Label ID="lblhspincode" runat="server" Text="PinCode"></asp:Label>
            </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:TextBox ID="txthspincode" runat="server"   CssClass="form-control"></asp:TextBox>
            </div>
            </div>
            
            <div class="col-md-12 col-sm-12 col-xs-12" style="padding:2% 0;">              
            <div class="col-md-4 col-sm-4 col-xs-12"><b>Telephone</b></div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:Label ID="lblhstelephone" runat="server" Text="Telephone"></asp:Label>
            </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:TextBox ID="txthstelephone" runat="server"   CssClass="form-control"></asp:TextBox>
            </div>
            </div>
            
            
            
                        <div class="col-md-12 col-sm-12 col-xs-12" style="padding:2% 0;">  
            <div class="col-md-4 col-sm-4 col-xs-12"><b>Fax</b></div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:Label ID="lblhsfax" runat="server" Text="Fax"></asp:Label>
            </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:TextBox ID="txthsfax" runat="server"   CssClass="form-control"></asp:TextBox>
            </div>
            </div>
            
            
            
                        <div class="col-md-12 col-sm-12 col-xs-12" style="padding:2% 0;">  
            <div class="col-md-4 col-sm-4 col-xs-12"><b>GstProvisionalId</b></div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:Label ID="lblhsgstprovisionalid" runat="server" Text="GstProvisionalId"></asp:Label>
            </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:TextBox ID="txthsgstprovisionalid" runat="server"   CssClass="form-control"></asp:TextBox>
            </div>
            </div>
            
            
            
                        <div class="col-md-12 col-sm-12 col-xs-12" style="padding:2% 0;">  
            <div class="col-md-4 col-sm-4 col-xs-12"><b>Pan</b></div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:Label ID="lblhspan" runat="server" Text="Pan"></asp:Label>
            </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:TextBox ID="txthspan" runat="server"   CssClass="form-control"></asp:TextBox>
            </div>
            </div>


            <div class="col-md-12 col-sm-12 col-xs-12" style="padding:2% 0;">  
            <div class="col-md-4 col-sm-4 col-xs-12"><b>SpocName</b></div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:Label ID="lblhsspocname" runat="server" Text="SpocName"></asp:Label>
            </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:TextBox ID="txthsspocname" runat="server"   CssClass="form-control"></asp:TextBox>
            </div>
            </div>




            <div class="col-md-12 col-sm-12 col-xs-12" style="padding:2% 0;">  
            <div class="col-md-4 col-sm-4 col-xs-12"><b>SpocMobile</b></div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:Label ID="lblhsspocmobile" runat="server" Text="SpocMobile"></asp:Label>
            </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:TextBox ID="txthsspocmobile" runat="server"   CssClass="form-control"></asp:TextBox>
            </div>
            </div>
            
            
            <div class="col-md-12 col-sm-12 col-xs-12" style="padding:2% 0;">              
            <div class="col-md-4 col-sm-4 col-xs-12"><b>SsisStatus</b></div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:Label ID="lblhsssistatus" runat="server" Text="SsisStatus"></asp:Label>
            </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:TextBox ID="txthsssistatus" runat="server"   CssClass="form-control"></asp:TextBox>
            </div>
            </div>


            <div class="col-md-12 col-sm-12 col-xs-12" style="padding:2% 0;">  
            <div class="col-md-4 col-sm-4 col-xs-12"><b>DrugLicenseNo</b></div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:Label ID="lblhsdruglicenceno" runat="server" Text="DrugLicenseNo"></asp:Label>
            </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:TextBox ID="txthsdruglicenceno" runat="server"   CssClass="form-control"></asp:TextBox>
            </div>
            </div>



            <div class="col-md-12 col-sm-12 col-xs-12" style="padding:2% 0;">  
            <div class="col-md-4 col-sm-4 col-xs-12"><b>Zone</b></div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <asp:Label ID="lblhszone" runat="server" Text="Zone"></asp:Label>
            </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
       
                <asp:TextBox ID="txthszone" runat="server"   CssClass="form-control"></asp:TextBox>
                </div>
                </div>
                
 

            <div style="text-align:center" >
                <asp:Button ID="btnedit" runat="server" Text="Edit" style="background-color:#0072bc; border:1px #0072bc solid; color:#fff; width: 100px; padding:10px;"/>


            </div>
      
</asp:Content>

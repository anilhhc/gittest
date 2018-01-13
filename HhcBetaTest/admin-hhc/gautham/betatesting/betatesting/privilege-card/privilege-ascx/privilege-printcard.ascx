<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="privilege-printcard.ascx.vb" Inherits="betatesting.privilege_printcard" %>

<div id="printarea">
   
                  
                        <asp:Repeater ID="rptcorp" runat="server">
                        <ItemTemplate>
     						 <%# Eval("FirstName")%> 
                     		<%# Eval("PrevilegecardloginId")%> 
                        </ItemTemplate>
                        </asp:Repeater>
                        <asp:Label ID="lblcompanyname" runat="server"></asp:Label>
                        <asp:Label ID="lblfromdate" runat="server"></asp:Label>
                     <asp:Label ID="lbltodate" runat="server" Text='<%# FormatDateTime(Eval("displayhrefto"), 1)%>'></asp:Label>
                          <asp:Repeater ID="RptDoctors" runat="server">
                        	<ItemTemplate>
                                <%# Eval("occupation")%> 
                                <%# Eval("FirstName")%>
                    		</ItemTemplate>
     						</asp:Repeater>


     </div>
<div><input id="btnprint" type="button" onclick="PrintDiv()" value="Print" style="margin-top:50px; border:1px solid #ccc; background:#03ABD4; color:#fff; font-size:13px; width:150px; height:30px;font-family: 'allerregular';" /></div>

<script type="text/javascript">

    function PrintDiv() {
        var divToPrint = document.getElementById('printarea');
        var popupWin = window.open('', '_blank', 'width=auto,height=auto,location=no,left=200px');
        popupWin.document.open();
        popupWin.document.write('<html><body onload="window.print()">' + divToPrint.innerHTML + '</html>');
        popupWin.document.close();
    }
</script>  
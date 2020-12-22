
<%@ Page Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="false" CodeFile="Welcome.aspx.vb" Inherits="Welcome" title="Welcome" EnableSessionState="True" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:Button ID="ButTransPosting" runat="server" style="z-index: 1; left: 148px; top: 392px; position: absolute; height: 35px; width: 118px; font-weight: 700;" Text="Transaction Posting" Font-Size="8pt" ForeColor="Red" />
<br />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
<asp:Button ID="ButBalEnquiry" runat="server" style="z-index: 1; left: 285px; top: 392px; position: absolute; height: 35px; font-weight: 700;" Text="Balance Enquiry" width="118px" Font-Size="8pt" ForeColor="Red" />
&nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<br />
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;
    &nbsp; &nbsp;<asp:Button ID="ButCustStatement" runat="server" style="z-index: 1; left: 420px; top: 392px; position: absolute; height: 35px; font-weight: 700;" Text="Customer Statement " width="118px" Font-Size="8pt" ForeColor="Red" />
<asp:Button ID="ButOpenBranch" runat="server" style="z-index: 1; left: 3px; top: 348px; position: absolute; height: 26px; font-weight: 700; color: #0000CC; width: 195px;" Text="Open Branch Operation" Font-Size="12pt" ForeColor="#0000CC" Font-Bold="True" Font-Italic="True" />
<br />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp;
    &nbsp;&nbsp;<asp:Button ID="ButRunEOD" runat="server" style="z-index: 1; left: 421px; top: 348px; position: absolute; height: 26px; font-weight: 700; color: #0000CC; width: 195px;" Text="Run End Of Day" Font-Size="12pt" ForeColor="#0000CC" Font-Bold="True" Font-Italic="True" />
    <br />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp;&nbsp;
    <asp:Label ID="LblBankName" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Larger"
        ForeColor="#0000C0" Text=" "></asp:Label>
<asp:Button ID="ButAcctOpen" runat="server" style="z-index: 1; left: 15px; top: 391px; position: absolute; height: 35px; width: 118px; font-weight: 700;" Text="Account Opening" Font-Size="8pt" ForeColor="Red" />
<br />
    &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<br />
<asp:Button ID="ButPostAuthorize" runat="server" style="z-index: 1; left: 212px; top: 348px; position: absolute; height: 26px; font-weight: 700; color: #0000CC; width: 195px;" Text="Posting Authorization" Font-Size="12pt" ForeColor="#0000CC" Font-Bold="True" Font-Italic="True" />
    <br />
    <br />
    &nbsp; &nbsp; &nbsp; &nbsp;
    <br />
    <br />
    <br />
    <br />
<asp:Button ID="ButSMSControl" runat="server" style="z-index: -1; left: 633px; top: 348px; position: absolute; height: 26px; font-weight: 700; color: #0000CC; width: 195px;" Text="SMS Control" Font-Size="12pt" ForeColor="#0000CC" Font-Bold="True" Font-Italic="True" />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>


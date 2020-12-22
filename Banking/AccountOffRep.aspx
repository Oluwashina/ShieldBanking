<%@ Page Language="VB" AutoEventWireup="false" CodeFile="AccountOffRep.aspx.vb" Inherits="AccountOffRep" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Account Officer Report Summary</title>
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <cr:crystalreportviewer id="CrystalReportViewer1" runat="server" autodatabind="True"
            grouptreeimagesfolderurl="" height="1268px" reportsourceid="CrystalReportSource1"
            toolbarimagesfolderurl="" toolpanelwidth="200px" width="1082px"></cr:crystalreportviewer>
        <asp:Button ID="ButClose" runat="server" BorderColor="#00C000" Font-Bold="True" ForeColor="Brown"
            Style="z-index: 101; left: 772px; position: absolute; top: 17px" Text="Close"
            Width="84px" />
        <cr:crystalreportsource id="CrystalReportSource1" runat="server">
<Report FileName="AccountOfficer.rpt"></Report>
</cr:crystalreportsource>
    
    </div>
    </form>
</body>
</html>


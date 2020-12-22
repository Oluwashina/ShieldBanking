<%@ Page Language="VB" AutoEventWireup="false" CodeFile="COTTable.aspx.vb" Inherits="COTTable" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>COT Table</title>
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="True"
            Height="1039px" ReportSourceID="CryRepDailyTrans" Width="901px" />
        <asp:Button ID="ButClose" runat="server" Height="28px" Style="z-index: 101; left: 733px;
            color: #ff0000; font-family: 'Arial Black'; position: absolute; top: 14px" Text="Close"
            Width="108px" />
        <CR:CrystalReportSource ID="CryRepDailyTrans" runat="server">
            <Report FileName="COTTable.rpt">
            </Report>
        </CR:CrystalReportSource>
    
    </div>
    </form>
</body>
</html>


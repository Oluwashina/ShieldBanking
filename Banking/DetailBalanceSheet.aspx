﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="DetailBalanceSheet.aspx.vb" Inherits="DetailBalanceSheet" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <a href="DetailBalanceSheet.aspx">DetailBalanceSheet.aspx</a><CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="True"
            Height="1060px" ReportSourceID="CrystalReportSource1" Width="925px" />
        <asp:Button ID="ButClose" runat="server" BorderColor="#00C000" Font-Bold="True" ForeColor="Brown"
            Style="z-index: 101; left: 772px; position: absolute; top: 17px" Text="Close"
            Width="84px" />
        <CR:CrystalReportSource ID="CrystalReportSource1" runat="server">
            <Report FileName="DetailBalanceSheet.rpt">
            </Report>
        </CR:CrystalReportSource>
    
    </div>
    </form>

</body>
</html>
<%@ Page Language="VB" AutoEventWireup="false" CodeFile="DetailBalanceSheet.aspx.vb" Inherits="Default2" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Detail Balance Sheet</title>
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form2" runat="server">
    <div>
        <a href="DetailBalanceSheet.aspx">DetailBalanceSheet.aspx</a><CR:CrystalReportViewer ID="CrystalReportViewer2" runat="server" AutoDataBind="True"
            Height="1060px" ReportSourceID="CrystalReportSource1" Width="925px" />
        <asp:Button ID="Button1" runat="server" BorderColor="#00C000" Font-Bold="True" ForeColor="Brown"
            Style="z-index: 101; left: 772px; position: absolute; top: 17px" Text="Close"
            Width="84px" />
        <CR:CrystalReportSource ID="CrystalReportSource2" runat="server">
            <Report FileName="DetailBalanceSheet.rpt">
            </Report>
        </CR:CrystalReportSource>
    
    </div>
    </form>

</body>
</html>

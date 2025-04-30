<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DemoReport.aspx.cs" Inherits="DemoReport" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Report</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            
            <rsweb:ReportViewer ID="ReportViewer1" runat="server" Height="1500px" Width="100%" ></rsweb:ReportViewer>
        </div>
    </form>
</body>
</html>

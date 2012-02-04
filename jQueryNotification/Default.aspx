<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="jQueryNotification.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>jQuery notification</title>
    <link href="Styles/jquery.jnotify.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/jquery-1.4.2.min.js" type="text/javascript"></script>
    <script src="Scripts/jquery.jnotify.js" type="text/javascript"></script>
</head>

<body>
    <form id="form" runat="server">
        <asp:ScriptManager runat="server" EnablePartialRendering="True"></asp:ScriptManager>
    <div>
    <asp:UpdatePanel runat="server" UpdateMode="Conditional">
        <ContentTemplate>
        <asp:Button ID="btnSuccess" runat="server" Text="Successful Notification" 
            onclick="btnSuccess_Click" />
        <asp:Button ID="btnWraning" runat="server" Text="Warning Notification" 
            onclick="btnWraning_Click" />
        <asp:Button ID="btnError" runat="server" Text="Error Notification" 
            onclick="btnError_Click" />
        </ContentTemplate>
    </asp:UpdatePanel>
    </div>
    <div>
        
        <asp:Button ID="btnDelayedSuccess" runat="server" 
            Text="Delayed Successful Notification" onclick="btnDelayedSuccess_Click" />
        <asp:Button ID="btnDelayedWarning" runat="server" 
            Text="Delayed Warning Notification" onclick="btnDelayedWarning_Click" />
        <asp:Button ID="btnDelayedError" runat="server" 
            Text="Delayed Error Notification" onclick="btnDelayedError_Click" />

    </div>
    </form>
</body>
</html>

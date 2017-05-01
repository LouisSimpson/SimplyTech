<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteOrders.aspx.cs" Inherits="DeleteOrders" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <title></title>
    <link rel="stylesheet" type="text/css" href="../StyleSheetSimply.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Are you sure you want to delete this Order?<br />
        <asp:Button ID="BtnYes" runat="server" OnClick="BtnYes_Click" Text="Yes" CssClass="btn" />
        <asp:Button ID="BtnNo" runat="server" Text="No" CssClass="btn" OnClick="BtnNo_Click" />
    
    </div>
    </form>
</body>
</html>

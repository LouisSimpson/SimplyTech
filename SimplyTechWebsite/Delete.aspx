﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Are you sure you want to delete this Item?<br />
        <asp:Button ID="BtnYes" runat="server" OnClick="BtnYes_Click" Text="Yes" />
        <asp:Button ID="BtnNo" runat="server" Text="No" />
    
    </div>
    </form>
</body>
</html>
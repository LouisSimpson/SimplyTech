<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerLogin.aspx.cs" Inherits="Secure_CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>SimplyTech</title>
    <link rel="stylesheet" type="text/css" href="../StyleSheetSimply.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="TxtUserName" runat="server" Text="UserName"></asp:Label>
&nbsp;<asp:TextBox ID="TxtLogin" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="password" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="TxtPassword" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="confirm" runat="server" Text="CONFIRM" OnClick="BtnConfirm_Click"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </form>
    </body>
</html>

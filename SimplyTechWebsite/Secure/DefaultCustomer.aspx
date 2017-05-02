<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DefaultCustomer.aspx.cs" Inherits="DefaultCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SimplyTech</title>
    <link rel="stylesheet" type="text/css" href="../StyleSheetSimply.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <h1>SimplyTech Customer Page&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</h1>
        <p>WELCOME to our tech website. Here you can find all the technology you need and want.</p>
        <p>Below are two buttons for each customer to follow</p>
        <p>Click the LogIn button if you are already a customer for our site, or click Register to add your details and become a customer.</p>
        <p>&nbsp;</p>
        <p>&nbsp;
            <asp:Button ID="LogIn" runat="server" Text="LogIn" OnClick="BtnLogIn_Click"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Register" runat="server" Text="Register" OnClick="BtnRegister_Click"/>
        </p>
    <div>
    
    </div>
    </form>
        <img src="../simplyTech.png" />
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerSignUp.aspx.cs" Inherits="Secure_CustomerSignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SimplyTech</title>
    <link rel="stylesheet" type="text/css" href="../StyleSheetSimply.css"/>
   
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-left: 280px">
        
    
        <asp:Label ID="Label1" runat="server" Text="FirstName"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" Width="166px"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="LastName"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" Width="166px" ></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="EmailAddress"></asp:Label>
        <asp:TextBox ID="txtEmailAddress" runat="server" Width="166px"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="ContactMobileNumber"></asp:Label>
        <asp:TextBox ID="txtContactMobileNumber" runat="server" Width="166px"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="House DoorNumber"></asp:Label>
        <asp:TextBox ID="txtHouseDoorNumber" runat="server" Width="166px"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Street Name"></asp:Label>
        <asp:TextBox ID="txtStreetName" runat="server" Width="166px"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="City Name"></asp:Label>
        <asp:TextBox ID="txtCityName" runat="server" Width="166px"></asp:TextBox>
        <br />
        <asp:Label ID="Label8" runat="server" Text="PostCode"></asp:Label>
        <asp:TextBox ID="txtPostCode" runat="server" Width="166px"></asp:TextBox>
        <br />
        <asp:Label ID="Label9" runat="server" Text="Card Number"></asp:Label>
        <asp:TextBox ID="txtCardNumber" runat="server" Width="166px"></asp:TextBox>
        <br />
        <asp:Label ID="Label10" runat="server" Text="ExpiryDate"></asp:Label>
        <asp:TextBox ID="txtExpiryDate" runat="server" Width="166px"></asp:TextBox>
        <br />
        <asp:Label ID="Label11" runat="server" Text="SecurityCode"></asp:Label>
        <asp:TextBox ID="txtSecurityCode" runat="server" Width="166px"></asp:TextBox>
        <br />
        <asp:Label ID="Label13" runat="server" Text="UserName"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label15" runat="server" Text= "Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        
   
        <br />
        <
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="CONFIRM" OnClick="Button1_Click" />
        
    
        <br />
        <br />
        <asp:Label ID="Label12" runat="server" Text="lblError"></asp:Label>
        <br />
        
    
    </div>
    </form>
    <img src="../simplyTech.png" />
</body>
</html>

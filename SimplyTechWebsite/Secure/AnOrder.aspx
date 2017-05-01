<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="../StyleSheetSimply.css"/>
   
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblDateOrdered" runat="server" Text="Order Date"></asp:Label>
        <asp:TextBox ID="txtDateOrdered" runat="server" style="margin-bottom: 0px"></asp:TextBox>
    
    </div>
        <asp:Label ID="lblProductName" runat="server" EnableTheming="True" Text="Product Name"></asp:Label>
        <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblQuantityNo" runat="server" Text="Quantity"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblOrderPrice" runat="server" Text="Order Total"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="BtnOk" runat="server" Text="OK" Width="87px" OnClick="BtnOK_Click" CssClass="btn" />
            <asp:Button ID="BtnCancel" runat="server" Text="Cancel" Width="83px" OnClick="BtnCancel_Click" CssClass="btn" />
        </p>
    </form>
</body>
</html>

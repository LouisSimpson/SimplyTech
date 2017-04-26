<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnStock.aspx.cs" Inherits="AnStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="StyleSheetSimply.css"/>
   
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="LabelName" runat="server" Text="Item Name"></asp:Label>
        <asp:TextBox ID="TextBoxName" runat="server" style="margin-bottom: 0px"></asp:TextBox>
    
    </div>
        <asp:Label ID="LabelDesc" runat="server" EnableTheming="True" Text="Stock Description"></asp:Label>
        <asp:TextBox ID="TextBoxDesc" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="LabelLevel" runat="server" Text="Stock Level"></asp:Label>
        <asp:TextBox ID="TextBoxLevel" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="LabelPrice" runat="server" Text="Stock Price"></asp:Label>
        <asp:TextBox ID="TextBoxPrice" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="ButtonOK" runat="server" Text="OK" Width="87px" OnClick="ButtonOK_Click" CssClass="btn" />
            <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" Width="83px" OnClick="ButtonCancel_Click" CssClass="btn" />
        </p>
    </form>
</body>
</html>

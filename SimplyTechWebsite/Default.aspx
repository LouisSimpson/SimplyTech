<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ListBox ID="ListBoxStock" runat="server" Height="159px" OnSelectedIndexChanged="ListBoxStock_SelectedIndexChanged" Width="425px"></asp:ListBox>
    
        <br />
        <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
        <br />
    
    </div>
        <asp:Button ID="BtnAdd" runat="server" OnClick="BtnAdd_Click" Text="Add" Width="141px" />
        <asp:Button ID="BtnDelete" runat="server" OnClick="BtnDelete_Click" Text="Delete" Width="143px" />
        <asp:Button ID="BtnEdit" runat="server" OnClick="BtnEdit_Click" Text="Edit" Width="136px" />
    </form>
</body>
</html>

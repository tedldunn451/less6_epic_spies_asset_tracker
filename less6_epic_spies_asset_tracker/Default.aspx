<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="less6_epic_spies_asset_tracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="spyLogoImage" runat="server" Height="150px" ImageUrl="epic-spies-logo.jpg" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="X-Large" Text="Asset Performance Tracker"></asp:Label>
            <br />
            <br />
            Asset Name:
            <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Elections Rigged:
            <asp:TextBox ID="riggedTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Acts of Subterfuge Performed:
            <asp:TextBox ID="actsTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="Add Asset" />
            <br />
            <br />
            <asp:Label ID="riggedLabel" runat="server"></asp:Label>
            <br />
            <asp:Label ID="averageActsLabel" runat="server"></asp:Label>
            <br />
            <asp:Label ID="assetNameLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

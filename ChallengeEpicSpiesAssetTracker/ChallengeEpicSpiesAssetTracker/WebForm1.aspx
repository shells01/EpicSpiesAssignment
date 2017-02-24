<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ChallengeEpicSpiesAssetTracker.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 150px;
            height: 185px;
        }
        .newStyle1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <img alt="" class="auto-style1" src="epic-spies-logo.jpg" />
        <br />
        <h3><span class="newStyle1">Asset Performance Tracker</span></h3>
    
    </div>
        <p>
            Asset Name:&nbsp;
            <asp:TextBox ID="assetsTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Elections Rigged:&nbsp;&nbsp;
            <asp:TextBox ID="electionsTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Acts of Subterfuge Performed:&nbsp;&nbsp;
            <asp:TextBox ID="actsTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="Add Asset" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>

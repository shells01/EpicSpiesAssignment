<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssignment.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 190px;
            height: 235px;
        }
        .newStyle1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <img alt="" class="auto-style1" src="epic-spies-logo.jpg" /><br />
        <h3><span class="newStyle1">Spy New Assignment Form</span></h3>
    
    </div>
        <p>
            Spy Code Name:&nbsp;
            <asp:TextBox ID="codeNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            New Assignment Name:&nbsp;
            <asp:TextBox ID="assignmentNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            End Date of Previous Assignment:<br />
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        </p>
        <p>
            Start Date of New Assignment:<br />
            <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
        </p>
        <p>
            Projected End Date of New Assignment:<br />
            <asp:Calendar ID="Calendar3" runat="server"></asp:Calendar>
        </p>
        <p>
            <asp:Button ID="assignButton" runat="server" OnClick="assignButton_Click" Text="Assign Spy" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="ToolTracker.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login To ToolTracker</title>
    <link href="CSS/loginPage.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="user_name" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="cancel_button" runat="server" Text="Cancel" />
        <asp:Button ID="login_button" runat="server" Text="Login" />


    </div>
    </form>
</body>
</html>

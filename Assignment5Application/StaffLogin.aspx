<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffLogin.aspx.cs" Inherits="Assignment5Application.StaffLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Staff login</h1>
            <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate1">
            </asp:Login>
            <br />
        </div>
    </form>
</body>
</html>

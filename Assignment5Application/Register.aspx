<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Assignment5Application.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
            Register for a new account!<br />
            In order to sign up, you need an username and a password.
            <table>
                <tr>
                    <td>

                        <asp:Label ID="Username" runat="server" Text="Username"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="UsernameTextbox" runat="server"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td>

                        <asp:Label ID="OriginalPasswordLabel" runat="server" Text="Password"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="PasswordTextbox" runat="server" TextMode="Password"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td>

                        <asp:Label ID="PasswordConfirmationLabel" runat="server" Text="Confirm your password"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="PasswordConfirmationTextbox" runat="server" TextMode="Password"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td>

                        <asp:Label ID="ImageVerifierLabel" runat="server" Text="Enter the text below:"></asp:Label>
                        <br />
                        <asp:Image ID="Image1" runat="server" style="justify-content: center" Height="68px" Width="131px"/>
                    </td>
                    <td>
                        <asp:TextBox ID="ImageVerifierTextbox" runat="server"></asp:TextBox>
                    </td>

                </tr>
            </table>
            <br />
            <asp:Button ID="CreateAccountButton" runat="server" Text="Create New Account!" OnClick="CreateAccountButton_Click" />
            <br />
            <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>

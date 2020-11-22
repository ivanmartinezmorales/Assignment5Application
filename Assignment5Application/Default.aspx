<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment5Application._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Day Starter</h1>
        <p class="lead">Day starter allows members to get their day started by allowing them to look up weather data, look up stock prices, find news articles and more. Register today</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Member Page</a> <a href="http://www.asp.net" class="btn btn-primary btn-lg">Member Login</a> </p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Staff Page</a> <a href="http://www.asp.net" class="btn btn-primary btn-lg">Staff Login</a> </p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Table of Components</h2>
            <p>
                &nbsp;<table class="nav-justified">
                    <tr>
                        <td>Provider Name</td>
                        <td>Page and Component</td>
                        <td>Component Description</td>
                        <td>Actual resources and methods used to implement this component</td>
                    </tr>
                    <tr>
                        <td>Ivan Martinez Morales</td>
                        <td>ASPX Page and Server Control</td>
                        <td>The public default page that calls and links to all of the other pages</td>
                        <td>GUI design and C# code behind GUI</td>
                    </tr>
                    <tr>
                        <td>Ivan Martinez Morales</td>
                        <td>User Control</td>
                        <td>Login pages and authentication verification</td>
                        <td>C# Code behind GUI. Linked to the default page</td>
                    </tr>
                    <tr>
                        <td>Ivan Martinez Morales</td>
                        <td>XML File</td>
                        <td>Stores usernames and passwords</td>
                        <td>Linked login page and the hashing function</td>
                    </tr>
                    <tr>
                        <td>Ivan Martinez Morales</td>
                        <td>DLL</td>
                        <td>Hashing function: Input string: Output: String</td>
                        <td>Use library class and local component to iplement this library function.It is also used to save data to an XML file.</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </p>
        </div>
    </div>

</asp:Content>

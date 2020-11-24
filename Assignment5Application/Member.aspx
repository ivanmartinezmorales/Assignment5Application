<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="Assignment5Application.Member" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class ="container">
        <div class ="row">
            <div class="jumbotron col-lg-12">
                
                Welcome to the member page!</div>
        </div>
        <div class ="row">
            <div class="col-lg-4">
                <h1>Finance</h1>
                <h3>Search your stocks below</h3>
                <br />
                
                <div class="row">
                    <asp:TextBox ID="StockName" runat="server" class="form-control col-xs-10"></asp:TextBox>
                    <asp:Button ID="SubmitButton" runat="server" OnClick="SubmitButton_Click" Text="Search" class="btn btn-info col-xs-2" />
                </div>
                
                <h4>
                    <asp:label ID="StockResponse" runat="server"></asp:label>
                </h4>
            </div>
            <div class="col-lg-4">
                <h1>Currency Conversion</h1>
                <h3>Check what your USD is worth!</h3>
                <br />
                
                <div class="row">
                    <asp:TextBox ID="amountTextBox" runat="server" class="form-control col-xs-12"></asp:TextBox>
                </div>
                <div class="row">
                    <br />
                    <asp:Button ID="JPY" runat="server" OnClick="SubmitButton_Click3" Text="Yen" class="btn btn-info col-xs-3" />  
                    <asp:Button ID="EUR" runat="server" OnClick="SubmitButton_Click3" Text="Eero" class="btn btn-info col-xs-3" />  
                    <asp:Button ID="MXN" runat="server" OnClick="SubmitButton_Click3" Text="Peso" class="btn btn-info col-xs-3" />
                </div>
                <h3>
                    <asp:label ID="conversionLabel" runat="server"></asp:label>
                </h3>
            </div>
            <div class="col-lg-4">
                <h1>Word of the Day</h1>
                <h3>Search your own word below</h3>
                <br />
                
                <div class="row">
                    <asp:TextBox ID="aWordTextBox" runat="server" class="form-control col-xs-10"></asp:TextBox>
                    <asp:Button ID="Button2" runat="server" OnClick="SubmitButton_Click2" Text="Search" class="btn btn-info col-xs-2" />
                </div>
                
                <h4>
                    <asp:label ID="wordDef" runat="server"></asp:label>
                </h4>
            </div>
        </div>
        <div class="row">
            <div class ="text-center col-xs-12">
                <h1>News</h1>
                <h3>Search News Based on your preference!</h3>
                <br />                
                    <asp:TextBox ID="TopicTextBox" runat="server" class="form-control center-block"></asp:TextBox>
                <br /> 
                    <asp:Button ID="getLocalNews" runat="server" OnClick="SubmitButton_Click4" Text="Search" class="btn btn-info  " />
                <h4>
                    <asp:label ID="theNewsLabel" runat="server"></asp:label>
                </h4>
            </div>
        </div>
        <div class="row">
            <div class ="text-center col-xs-12">
                <h1>Encryption/Decryption</h1>
                <h3>Encrypt and decrypt passwords!</h3>
                <br />                
                    <asp:TextBox ID="EncryptionTextbox" runat="server" class="form-control center-block"></asp:TextBox>
                <br /> 
                    <asp:Button ID="EncryptText" runat="server" OnClick="handleEncrypt" Text="Encrpyt" class="btn btn-info  " />
                    <asp:Button ID="DecryptText" runat="server" OnClick="handleDecrypt" Text="Decrypt" class="btn btn-info  " />
                <h4>
                    <asp:label ID="EncryptionResultsText" runat="server"></asp:label>
                </h4>
            </div>
        </div>
    </div>
    
</asp:Content>
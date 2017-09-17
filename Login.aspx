<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Login</title>
<style type="text/css">
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
        <div class="section">
            <fieldset class="z-depth-2">
                <legend>Login to Libri</legend>
                <asp:Label ID="Label1" runat="server" ForeColor="Red">Username: admin Password: admin</asp:Label>
                <table style="width:100%;" class="highlight centered bordered">
                    <tr>
                        <td>
                            <div class="input-field">
                                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                                <label for="txtEmail">Email</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div class="input-field">
                                <asp:TextBox ID="txtPass1" runat="server" TextMode="Password"></asp:TextBox>
                                <label for="txtPass1">Password</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtPass1" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>
                        </td>
                    </tr>
                    </table>
                <asp:LinkButton CausesValidation ="true" CssClass="btn waves-effect waves-light green" ID="btnLogin" runat="server" Text="Login!" OnClick="btnLogin_Click"></asp:LinkButton>
                <asp:Label ID="lblErrors" runat="server" ForeColor="Red"></asp:Label>
            </fieldset>
        </div>
    </div>
    <div id="index-banner" class="parallax-container">
        <div class="section no-pad-bot">
            <div class="container">
                <br/>
                <br/>
                <h1 class="header center teal-text text-lighten-2">Login Page</h1>
                <div class="row center">
                    <h5 class="header col s12 light">Login to your Account!</h5>
                </div>
                <div class="row center">
                    <a href="Register.aspx" class="btn-large waves-effect waves-light teal lighten-1">No account? Create one!</a>
                </div>
                <br/>
                <br/>
            </div>
        </div>
        <div class="parallax"><img src="Images/bg1.jpg" alt="Background 1"/></div>
    </div>
</asp:Content>


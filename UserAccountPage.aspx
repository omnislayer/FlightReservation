<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="UserAccountPage.aspx.cs" Inherits="UserAccountPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>
        Edit Account!
    </title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
        <div class="section">
            <fieldset class="z-depth-2">
                <legend>Edit your account!</legend>
                <table style="width:100%;" class="highlight centered bordered">
                    <tr>
                        <td class="auto-style3">
                            <div class="input-field">
                                <asp:TextBox ID="txtFName" runat="server"></asp:TextBox>
                                <label for="txtFName">First Name:</label>
                            </div>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFName" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div class="input-field">
                            <asp:TextBox ID="txtLName" runat="server"></asp:TextBox>
                                <label for="txtLName">Last Name:</label>
                            </div>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLName" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <div class="input-field">
                                <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
                                <label for="txtEmail">Email:</label>
                            </div>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <div class="input-field">
                                <asp:TextBox ID="txtPass1" runat="server" TextMode="Password"></asp:TextBox>
                                <label for="txtPass1">Password:</label>
                            </div>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtPass1" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div class="input-field">
                                <asp:TextBox ID="txtPass2" runat="server" TextMode="Password"></asp:TextBox>
                                <label for="txtPass2">Repeat Password:</label>
                            </div>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtPass2" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPass1" ControlToValidate="txtPass2" Display="Dynamic" ErrorMessage="Passwords do not match."></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div class="input-field">
                                <asp:TextBox ID="txtAddress" runat="server" TextMode="SingleLine"></asp:TextBox>
                                <label for="txtAddress">Address:</label>
                            </div>
                        </td>
                    </tr>
                    </table>
                <asp:LinkButton CausesValidation ="true" CssClass="btn waves-effect waves-light green" ID="btnUpdate" runat="server" Text="Commit Changes!" OnClick="btnUpdate_Click"/>
            </fieldset>
        </div>
    </div>
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="AdminPage.aspx.cs" Inherits="AdminPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>
        Admin's Page
    </title>
    <style type="text/css">
        .auto-style1 {
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="parallax-container">
        <div class="section no-pad-bot">
            <div class="container">
                <br/>
                <br/>
                <h1 class="header center teal-text text-lighten-2">Admin Page</h1>
                <div class="row center">
                    <h5 class="header col s12 light white-text">This was made by Glynn Llywyllyn M. Bacanto</h5>
                </div>
                <div class="row center">
                    <a href="https://theomnislayer.wordpress.com" class="btn-large waves-effect waves-light teal lighten-1">Go to his portfolio</a>
                </div>
                <br/>
                <br/>
            </div>
        </div>
        <div class="parallax"><img src="Images/bg1.jpg" alt="Background 1"/></div>
    </div>
    <div class="container">
        <div class="section"> 
          <div class="row">
            <div class="col s12 m4">
              <div class="icon-block">
                <h2 class="center brown-text"><i class="material-icons">perm_identity</i></h2>
                <h5 class="center">View Users</h5>
                <p class="light">View Users and their information!</p>
              </div>
            </div>

            <div class="col s12 m4">
              <div class="icon-block">
                <h2 class="center brown-text"><i class="material-icons">work</i></h2>
                <h5 class="center">Categories</h5>
                <p class="light">Add categories and assign stuff!</p>
              </div>
            </div>

            <div class="col s12 m4">
              <div class="icon-block">
                <h2 class="center brown-text"><i class="material-icons">settings</i></h2>
                <h5 class="center">Items</h5>
                <p class="light">Add items, edit them and stuff!!!</p>
              </div>
            </div>
          </div>
        </div>
    </div>
    <div class="parallax-container">
        <div class="section no-pad-bot">
            <div class="container">
                <br/>
                <br/>
                <h1 class="header center teal-text text-lighten-2">View Users</h1>
                <div class="row center">
                    <h5 class="header col s12 light white-text">View user Details.</h5>
                </div>
                <div class="row center">
                    <a href="AdminUsersPage.aspx" class="btn-large waves-effect waves-light teal lighten-1">View Users</a>
                </div>
                <br/>
                <br/>
            </div>
        </div>
        <div class="parallax"><img src="Images/bg2.jpg" alt="Background 2"/></div>
    </div>
</asp:Content>


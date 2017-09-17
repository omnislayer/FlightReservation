using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//For Database
using System.Data;
using System.Data.SqlClient;
//using GlynnClassLibrary;
public partial class AdminMasterPage : System.Web.UI.MasterPage
{
    //Bacanto_Class bcl = new Bacanto_Class();
    protected void Page_Load(object sender, EventArgs e)
    {
        String bottomSideNavText = "";
        String goHere = "";
        String name = "";
        String email = "";
        String accountType = "";
        try
        {
            String userType = Session["userType"].ToString();
            ulNavBar.InnerHtml =
                "<li><a href='Login.aspx' class ='white-text'>Logout</a></li>";
            if (userType.Equals("user"))
            {// User
                name = Session["firstName"].ToString() + " " + Session["lastName"].ToString();
                email = Session["email"].ToString();
                accountType = "User Account";
                goHere = "UserAccountPage.aspx";
            
                
                bottomSideNavText = 
                    "<li class='bold'><a href='Frontpage.aspx' class='waves-effect waves-teal'>Book a flight!</a></li>";
                /*
                sideNav.InnerHtml =
                    "<li class='bold'><a href='Frontpage.aspx' class='waves-effect waves-teal'>Buy books!</a></li>"+
                    "<li class='bold'><a href='UserAccountPage.aspx' class='waves-effect waves-teal'>Edit Account!</a></li>";
                */
            }
            else if (userType.Equals("admin"))
            {//Admin
                name = "Mr. Admin McAdministrator";
                email = "TheAdmin@administration.com";
                accountType = "Admin Account";
                goHere = "AdminPage.aspx";

                bottomSideNavText =
                    "<li class='bold'><a href='AdminUsersPage.aspx' class='waves-effect waves-teal'>View Registered Users</a></li>"+
                    "<li class='bold'><a href='AdminCategoriesPage.aspx' class='waves-effect waves-teal'>View Categories</a></li>" +
                    "<li class='bold'><a href='AdminItemsPage.aspx' class='waves-effect waves-teal'>View Items</a></li>" +
                    "<li class='bold'><a href='AdminTransactionsPage.aspx' class='waves-effect waves-teal'>View Transactions</a></li>";
            }

            sideNav.InnerHtml =
                    "<link href='css/materialize.min.css' rel='stylesheet' />" +
                    "<li>" +
                    "    <div class='userView'>" +
                    "        <div class='background'>" +
                    "            <img src='images/office.jpg'/>" +
                    "        </div>" +
                    "        <a href='" + goHere + "'><img class='circle' src='images/face.png'/></a>" +
                    "        <a href='" + goHere + "'><span class='white-text'>" + accountType + "</span></a>" +
                    "        <a href='" + goHere + "'><span class='white-text name'>" + name + "</span></a>" +
                    "        <a href='" + goHere + "'><span class='white-text email'>" + email + "</span></a>" +
                    "    </div>" +
                    "</li>" +
                    bottomSideNavText;
        }
        catch (Exception ex)
        {//Not Instantiated
            sideNav.InnerHtml =
                "<link href='css/materialize_glynn.min.css' rel='stylesheet' />"+
                "<li class='logo'><a id='logo-container' href='Frontpage.aspx' class='brand-logo' style='height:100px;'>"+
                "<object id='front-page-logo' type='image/svg+xml' data='images/logo.svg'>Your browser does not support SVG</object></a></li>"+
                "<li><a href='Register.aspx'>Register</a></li>" +
                "<li><a href='Login.aspx'>Login</a></li>";
            ulNavBar.InnerHtml =
                "<li><a href='Register.aspx' class ='white-text'>Register</a></li>" +
                "<li><a href='Login.aspx' class ='white-text'>Login</a></li>";
        }
    }
    private void setSidenav()
    {
        /* Categories
        DataTable dt = bcl.getCategories();
        String sideText = "";
        foreach (DataRow row in dt.Rows)
        {
            sideText += "<li class='bold'><a href='#" + row["Name"].ToString() + "' class='waves-effect waves-teal'>" + row["Name"].ToString() + "</a></li>";
        }
        sideNav.InnerHtml = sideText;
         * */
        /* Cards
        DataTable dt2 = bcl.getItems();
        String sideText2 = "";

        sideText2 +="<div class='container centered'>";
        int count = 3;
        foreach (DataRow row in dt2.Rows)
        {
            if(count>=3) sideText2 += "<div class='row'>";

            sideText2 += "<div class='col s12 m4'><div class='card hoverable blue'><div class='card-image'>" +
                        "<img src='UploadedImages/"+ row["ImageName"].ToString() + "'>" +
                        "<span class='card-title'>" + row["Name"].ToString() + "</span></div>" +
                        "<div class='card-content blue lighten-5 black-text'><span class='card-title activator text-darken-4'>" + row["Name"].ToString() + "<i class='material-icons right'>more_vert</i></span>" +
                        "<p>" +row["Price"].ToString() + "</p></div>"+
                        "<div class='card-reveal'><span class='card-title grey-text text-darken-4'>" + row["Name"].ToString() + "<i class='material-icons right'>close</i></span>" +
                        "<p>" +row["Description"].ToString() + "</p>"+
                        "<a class='btn' onclick='Materialize.toast('Added to cart!', 4000)'>Add to Cart</a></div></div></div>";
            //sideText2 += "<a href='#" + row["Name"].ToString() + "'>" + row["Name"].ToString() + "</a>";

            if (count >= 3)
            {
                sideText2 += "</div>";
                count = 0;
            }
            count += 1;
        }
        sideText2 += "</div>";
        frontPageContent.InnerHtml = sideText2;
         * */
    }
}
/*
        String sideNavText = "";
        String bottomSideNavText = "";
        String name = "";
        String email = "";
        String accountType = "";
        try
        {
            int userType = int.Parse(Session["userType"].ToString());
            navMobile.InnerHtml =
            ulNavBar.InnerHtml =
                "<li><a href='Login.aspx' class ='white-text'>Logout</a></li>";
            
            if (userType == 0)//Student
            {
                name = Session["firstName"].ToString() + " " + Session["lastName"].ToString();
                email = Session["email"].ToString();
                sideNavText = "Student";
                accountType = "Student Account";
                bottomSideNavText =
                    "<li><a href='StudentGradePage.aspx'>View Grades</a></li>" +
                    "<li><a href='StudentEditAccountPage.aspx'>Edit Account Details</a></li>";
            }
            else if (userType == 1)//Faculty
            {
                name = Session["firstName"].ToString() + " " + Session["lastName"].ToString();
                email = Session["email"].ToString();
                sideNavText = "Faculty";
                accountType = "Faculty Account";
                bottomSideNavText =
                    "<li><a href='FacultyGradePage.aspx'>Assign Grades</a></li>" +
                    "<li><a href='FacultySectionPage.aspx'>Adviser Section Details</a></li>" +
                    "<li><a href='FacultyEditAccountPage.aspx'>Edit Account Details</a></li>";
            }
            else if (userType == 3)//Admin
            {
                sideNavText = "Admin";
                accountType = "Admin Account";
                name = "Mr. Admin McAdministrator";
                email = "admin@administrator.com";
                bottomSideNavText =
                    "<li><a href='AdminFacultyPage.aspx'>Faculty Details</a></li>" +
                    "<li><a href='AdminStudentPage.aspx'>Student Details</a></li>" +
                    "<li><a href='AdminSectionPage.aspx'>Section Details</a></li>";
            }
            else//None of the Above
            {
                Response.Write("<script>alert('"+userType+"');</script>");
                Response.Redirect("Login.aspx");
            }
            sideNav.InnerHtml =
                    "<li>" +
                    "    <div class='userView'>" +
                    "        <div class='background'>" +
                    "            <img src='images/office.jpg'/>" +
                    "        </div>" +
                    "        <a href='" + sideNavText + "Page.aspx'><img class='circle' src='images/face.png'/></a>" +
                    "        <a href='" + sideNavText + "Page.aspx'><span class='white-text'>" + accountType + "</span></a>" +
                    "        <a href='" + sideNavText + "Page.aspx'><span class='white-text name'>" + name + "</span></a>" +
                    "        <a href='" + sideNavText + "Page.aspx'><span class='white-text email'>" + email + "</span></a>" +
                    "    </div>" +
                    "</li>" +
                    bottomSideNavText;
        }
        catch (Exception ex)
        {
            Response.Redirect("Login.aspx");
        }
 */

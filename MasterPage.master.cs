using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
    navMobile.InnerHtml =
    ulNavBar.InnerHtml =
        "<li><a href='Register.aspx' class ='white-text'>Register</a></li>" +
        "<li><a href='Login.aspx' class ='white-text'>Login</a></li>";
    }
}
/*
 
        try {
            String userType = Session["userType"].ToString();
            if (userType.Equals("admin"))
            {//Admin
                navMobile.InnerHtml =
                ulNavBar.InnerHtml =//CHANGE MOE
                "<li><a class='dropdown-button btn' href='#' data-activates='drpAdmin'>Drop Me!</a>"+
                "<ul id='drpAdmin' class='dropdown-content'>"+
                    "<li><a href='#!'>one</a></li>"+
                    "<li><a href='#!'>two</a></li>"+
                    "<li class='divider'></li>"+
                    "<li><a href='#!'>three</a></li>"+
                    "<li><a href='#!'><i class='material-icons'>view_module</i>four</a></li>"+
                    "<li><a href='#!'><i class='material-icons'>cloud</i>five</a></li>"+
                "</ul></li>"+
                "<li><a href='AdminPage.aspx' class ='white-text'>Admin Tools</a></li>" +
                "<li><a href='MemberPage.aspx' class ='white-text'>Buy</a></li>" +
                "<li><a href='Login.aspx' class ='white-text'>Logout</a></li>";
            }
            else
            { //Member
                navMobile.InnerHtml =
                ulNavBar.InnerHtml =
                "<li><a href='MemberPage.aspx' class ='white-text'>Cart</a></li>" +
                "<li><a href='Login.aspx' class ='white-text'>Logout</a></li>";
            }
        }
        catch (Exception ex) {//Not Logged in
            navMobile.InnerHtml =
            ulNavBar.InnerHtml =
                "<li><a href='Register.aspx' class ='white-text'>Register</a></li>"+
                "<li><a href='Login.aspx' class ='white-text'>Login</a></li>";
        }
 */

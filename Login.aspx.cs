using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using GlynnClassLibrary;
public partial class Login : System.Web.UI.Page
{
    Bacanto_Class bcl = new Bacanto_Class();
    protected void Page_Load(object sender, EventArgs e)
    {
        Session.RemoveAll();
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {
            String pass = txtPass1.Text.ToString();
            String email = txtEmail.Text.ToString();
            if (pass.Equals("admin") && email.Equals("admin"))
            {
                Session["userType"] = "admin"; //
                Response.Redirect("AdminPage.aspx");
            }
            else
            {
                Boolean checkLogin = false;
                checkLogin = bcl.checkLogin(email, pass);
                if (checkLogin)
                {
                    bcl.getUserInfo(email);
                    Session["email"] = email;
                    Session["userID"] = bcl.UserID;
                    Session["firstName"] = bcl.FirstName;
                    Session["lastName"] = bcl.LastName;
                    Session["birthday"] = bcl.Birthday;
                    Session["userType"] = "user";//

                    Response.Redirect("Frontpage.aspx");
                }
                else Response.Write("<script>alert('Invalid Login.')</script>");
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('The data is incomplete. A field is empty.');</script>");
        }
    }
}
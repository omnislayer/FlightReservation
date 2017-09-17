using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//using GlynnClassLibrary;
public partial class UserAccountPage : System.Web.UI.Page
{
    //kBacanto_Class bcl = new Bacanto_Class();
    protected void Page_Load(object sender, EventArgs e)
    {
        //try
        //{
        //    if (!IsPostBack)
        //    {
        //        txtEmail.Text = Session["email"].ToString();
        //        txtFName.Text = Session["firstName"].ToString();
        //        txtLName.Text = Session["lastName"].ToString();
        //        txtAddress.Text = Session["address"].ToString();
        //    }
        //}
        //catch (Exception ex)
        //{
        //    Response.Redirect("Login.aspx");
        //}
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        
        //if (bcl.updateUserData(int.Parse(Session["id"].ToString()), txtEmail.Text.ToString(), txtFName.Text.ToString(), txtLName.Text.ToString(), txtPass1.Text.ToString(), txtAddress.Text.ToString()))
        //{
        //    bcl.getUserData(txtEmail.Text.ToString());
        //    Session["id"] = bcl.Id;
        //    Session["email"] = txtEmail.Text.ToString();
        //    Session["firstName"] = bcl.FirstName;
        //    Session["lastName"] = bcl.LastName;
        //    Session["address"] = bcl.Address;
        //    Session["userType"] = "user";//
        //    //Response.Write("<script>alert('" + Session["id"].ToString() + " " + txtEmail.Text.ToString() + " " + txtFName.Text.ToString() + " " + txtLName.Text.ToString() + " " + txtPass1.Text.ToString() + " " + txtAddress.Text.ToString() + "');</script>");
        //    Response.Write("<script>alert('Updated!');</script>");
        //}
        //else
        //{
        //    Response.Write("<script>alert('Check Inputs!');</script>");
        //}
    }
}
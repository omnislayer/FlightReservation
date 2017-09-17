using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using GlynnClassLibrary;

public partial class Register : System.Web.UI.Page
{
    Bacanto_Class bcl = new Bacanto_Class();

    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        try
        {
            if (bcl.checkEmailExists(txtEmail.Text.ToString())) Response.Write("<script> alert('Email has already been used.'); </script>");
            else
            {
                bcl.addUser(
                    txtEmail.Text.ToString(),
                    txtFName.Text.ToString(),
                    txtLName.Text.ToString(),
                    txtPass1.Text.ToString(),
                    DateTime.Parse(txtBirthday.Text.ToString())
                    );
                Response.Redirect("Login.aspx");
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('The data is incomplete. A field is empty.');</script>");
        }
    }
}
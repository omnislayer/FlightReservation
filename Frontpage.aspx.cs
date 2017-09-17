using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//For Database
using System.Data;
using System.Data.SqlClient;
using GlynnClassLibrary;

public partial class Frontpage : System.Web.UI.Page
{
    Bacanto_Class bcl = new Bacanto_Class();
    static DataTable myData = new DataTable();
    static DataTable myTicketData = new DataTable();

    int userID = 0, flightID = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            String userType = Session["userType"].ToString();
            userID = int.Parse(Session["userID"].ToString());
            if (!userType.Equals("user")) Response.Redirect("Login.aspx");
            //Response.Write("<script>alert('" + Session["email"] + Session["firstName"] + "');</script>");
        }
        catch (Exception ex)
        {
            Response.Redirect("Login.aspx");
        }
        if(!IsPostBack){
            setGridView();
        }
    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        setGridView();
    }
    private void setTickets()
    {
        myTicketData = bcl.getTicketsByUser(userID);
        gvTickets.DataSource = myTicketData;
        gvTickets.DataBind();
    }
    private void setGridView(String txt = "")
    {
        myData = bcl.getFlightsByCode(txt);
        gvFlights.DataSource = myData;
        gvFlights.DataBind();

        setTickets();
    }
    private void setGridViewOriginDestination(string origin="", string destination="")
    {
        myData = bcl.getFlightsByOriginDestination(origin,destination);
        gvFlights.DataSource = myData;
        gvFlights.DataBind();

        setTickets();
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        setGridView(txtSearchCode.Text);
    }
    protected void btnSearchOrigin_Click(object sender, EventArgs e)
    {
        setGridViewOriginDestination(txtSearchOrigin.Text,txtSearchDestination.Text);
    }
    protected void gvRowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "BuyTicket")
        {
            flightID = Convert.ToInt32(e.CommandArgument);
            
            if(bcl.getFlightAvailability(flightID)){
                if (bcl.addTicket(flightID, userID))
                {
                    Response.Write("<script>alert('Ticket has been added!');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('The flight is full. No more seats are available.');</script>");
            }
            //Response.Write("<script>alert("+index+");</script>");
        }
        setGridView();
    }
}
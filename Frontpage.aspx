<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Frontpage.aspx.cs" Inherits="Frontpage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>
        Libri - Books and Stuff
    </title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
        <div class="section"> 
            <div class="row">
                <fieldset>
                    <legend>Search by Flight Code</legend>
                    <div class="input-field">
                        <asp:TextBox ID="txtSearchCode" runat="server"></asp:TextBox>
                        <label for="txtSearchCode">Search Code</label>
                        <asp:LinkButton CausesValidation ="true" CssClass="btn waves-effect waves-light green" ID="btnSearchCode" runat="server" OnClick="btnSearch_Click">Search!</asp:LinkButton>
                    </div>
                </fieldset>
            </div>
        </div>
    </div>
    <div class="container">
        <div class="section"> 
            <div class="row">
                <fieldset>
                    <legend>Search by Origin and Destination</legend>
                    <div class="input-field">
                        <asp:TextBox ID="txtSearchOrigin" runat="server"></asp:TextBox>
                        <label for="txtSearchOrigin">Origin</label>
                    </div>
                    <div class="input-field">
                        <asp:TextBox ID="txtSearchDestination" runat="server"></asp:TextBox>
                        <label for="txtSearchDestination">Destination</label>
                    </div>
                        <asp:LinkButton CausesValidation ="true" CssClass="btn waves-effect waves-light green" ID="btnSearchOrigin" runat="server" OnClick="btnSearchOrigin_Click">Search!</asp:LinkButton>
                </fieldset>
            </div>
        </div>
    </div>
    <div class="container">
        <div class="row">
            <fieldset>
                <legend>Flights Table</legend>
                <asp:GridView ID="gvFlights" runat="server" AutoGenerateColumns="False" CssClass="bordered highlight center"  OnRowCommand="gvRowCommand" runat="server">
                    <Columns>
                        <asp:BoundField DataField="AirlineCode" HeaderText="Airline Code"/>
                        <asp:BoundField DataField="FlightNumber" HeaderText="Flight Number"/>
                        <asp:BoundField DataField="Origin" HeaderText="Origin"/>
                        <asp:BoundField DataField="Destination" HeaderText="Destination"/>
                        <asp:BoundField DataField="MaxPassengers" HeaderText="Seats Remaining"/>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="Reserve" runat="server" CausesValidation="false" CommandName="BuyTicket" Text="Buy Ticket" CommandArgument='<%# Eval("FlightID") %>' />
                                <asp:Label ID="FlightID" runat="server" Value='<%# Eval("FlightID") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <EmptyDataTemplate>
                        <div>
                            Nothing found sorry! Try Searching Again!
                        </div>
                    </EmptyDataTemplate>
                </asp:GridView>
            </fieldset>
        </div>
    </div>
    
    <div class="container">
        <div class="row">
            <fieldset>
                <legend>Your Tickets</legend>
                <asp:GridView ID="gvTickets" runat="server" AutoGenerateColumns="False" CssClass="bordered highlight center"  OnRowCommand="gvRowCommand" runat="server">
                    <Columns>
                        <asp:BoundField DataField="FlightID" HeaderText="Flight ID"/>
                        <asp:BoundField DataField="ReservationNumber" HeaderText="Reservation Number"/>
                    </Columns>
                    <EmptyDataTemplate>
                        <div>
                            Nothing found sorry! Buy a ticket NOW! pls
                        </div>
                    </EmptyDataTemplate>
                </asp:GridView>
            </fieldset>
        </div>
    </div>
</asp:Content>


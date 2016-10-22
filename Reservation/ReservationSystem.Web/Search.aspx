<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="ReservationSystem.Web.Search" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reservation System</title>
    <%: Styles.Render("~/bundles/searchPageStyle") %>

    <%: Scripts.Render("~/bundles/JQuery") %>
    <%: Scripts.Render("~/bundles/BootStrapJs") %>
    <%: Scripts.Render("~/bundles/datepicker") %>
    <%: Scripts.Render("~/bundles/typehead") %>
    <%: Scripts.Render("~/bundles/searchPage") %>
</head>
<body>
    <form id="form" runat="server">
        <br />
        <div class="container">
            <div class="row">
                <nav class="navbar navbar-default">
                    <div class="container-fluid">
                        <div class="navbar-header">
                            <p class="navbar-text"><strong>Search Site</strong></p>
                        </div>
                    </div>
                </nav>
                <div class="col-md-3"></div>
                <div class="col-md-6">
                    <asp:Label ID="SuccessMessageLabl" class="success" runat="server" Text=""></asp:Label><p id="DataText" class="validation" runat="server"></p>
                </div>
                <div class="col-md-3"></div>
                <div class="clearfix"></div>
                <br />
                <div class="col-md-2">
                </div>
                <div class="col-md-8">

                    <div class="col-md-6">
                        <div class="input-group">
                            <span class="input-group-addon" id="sizing-addon2"><strong>Location</strong></span>
                            <asp:TextBox ID="Location" class="form-control typeahead" aria-describedby="sizing-addon2" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-6"></div>
                    <div class="clearfix"></div>
                    <br />
                    <div class="col-md-6">
                        <div class="input-group">
                            <span class="input-group-addon" id="sizing-addon3"><strong>Check-in</strong></span>
                            <asp:TextBox ID="Checkin" autocomplete="off" ReadOnly="true" class="form-control" aria-describedby="sizing-addon3" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-6"></div>
                    <div class="clearfix"></div>
                    <br />
                    <div class="col-md-6">
                        <div class="input-group">
                            <span class="input-group-addon" id="sizing-addon4"><strong>Check-out</strong></span>
                            <asp:TextBox ID="Checkout" autocomplete="off" ReadOnly="true" class="form-control" aria-describedby="sizing-addon4" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-6"></div>
                    <div class="clearfix"></div>
                    <br />
                    <div class="col-md-6">
                        <div class="input-group">
                            <span class="input-group-addon" id="sizing-addon5"><strong>Room</strong></span>
                            <asp:DropDownList class="form-control" aria-describedby="sizing-addon5" ID="SelectRoomDropdown" runat="server">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-md-6"></div>
                    <div class="clearfix"></div>
                    <br />
                </div>
                <div class="col-md-2"></div>
                <div class="clearfix"></div>
                <div id="reservation">
                    <asp:Panel ID="SearchPanel" runat="server">
                        <div class="col-md-2"></div>
                        <div class="col-md-7 well well-sm">
                            <div class="col-md-4">
                                <label class="form-control" id="RoomId">Room 1</label>
                            </div>
                            <div class="col-md-4">
                                <div class="input-group">
                                    <span class="input-group-addon"><strong>Adult</strong></span>
                                    <asp:DropDownList ID="Adult" class="form-control" runat="server">
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="input-group">
                                    <span class="input-group-addon"><strong>Children</strong></span>
                                    <asp:DropDownList ID="Children" Class="form-control" runat="server">
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-3"></div>
                        <div class="clearfix"></div>

                    </asp:Panel>
                </div>
                <div class="col-md-8"></div>
                <div class="col-md-2">
                    <asp:Button ID="SubmitButton" CssClass="btn btn-primary" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
                </div>
                <div class="col-md-2"></div>
                <div class="clearfix"></div>
                <br />
                <br />
                <asp:TextBox ID="adultList" runat="server"></asp:TextBox>
                <asp:TextBox ID="childrenList" runat="server"></asp:TextBox>
                <br />
                <br />
            </div>
        </div>
    </form>
</body>
</html>

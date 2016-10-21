<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="ReservationSystem.Web.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.10.2.js" type="text/javascript"></script>
    <script src="Scripts/ReservationScripts/search.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/reservation.css" rel="stylesheet" />
</head>
<body>
    <form id="form" runat="server">
        <br />
        <div class="container">
            <div class="row">
                <nav class="navbar navbar-default">
                    <div class="container-fluid">
                        <div class="navbar-header">
                            <p class="navbar-text">Reservation Form</p>
                        </div>
                    </div>
                </nav>
                   <div class="col-md-3"></div>
                 <div class="col-md-6">   <asp:Label ID="SuccessMessageLabel" class="success" runat="server" Text=""></asp:Label><p id="DataText" class="validation" runat="server"></p></div>
                 <div class="col-md-3"></div>
                   <div class="clearfix"></div>
                <br />
                <div class="col-md-2">
                </div>
                <div class="col-md-8">

                    <div class="col-md-6">
                        <div class="input-group">
                            <span class="input-group-addon" id="sizing-addon2">Location</span>
                            <asp:TextBox ID="Location" class="form-control" aria-describedby="sizing-addon2" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-6"></div>
                    <div class="clearfix"></div>
                    <br />
                    <div class="col-md-6">
                        <div class="input-group">
                            <span class="input-group-addon" id="sizing-addon3">Checkin</span>
                            <asp:TextBox ID="Checkin" class="form-control" aria-describedby="sizing-addon3" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-6"></div>
                    <div class="clearfix"></div>
                    <br />
                    <div class="col-md-6">
                        <div class="input-group">
                            <span class="input-group-addon" id="sizing-addon4">Checkout</span>
                            <asp:TextBox ID="Checkout" class="form-control" aria-describedby="sizing-addon4" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-6"></div>
                    <div class="clearfix"></div>
                    <br />
                    <div class="col-md-6">
                        <div class="input-group">
                            <span class="input-group-addon" id="sizing-addon5">Room</span>
                            <asp:DropDownList class="form-control" aria-describedby="sizing-addon5" ID="SelectRoomDropdown" runat="server">
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                                <asp:ListItem>5</asp:ListItem>
                                <asp:ListItem>6</asp:ListItem>
                                <asp:ListItem>7</asp:ListItem>
                                <asp:ListItem>8</asp:ListItem>
                                <asp:ListItem>9</asp:ListItem>
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
                                <label class="form-control">Room 10</label>
                            </div>
                            <div class="col-md-4">
                                <div class="input-group">
                                    <span class="input-group-addon">Adult</span>
                                    <asp:DropDownList ID="Adult" class="form-control" runat="server">
                                        <asp:ListItem>1</asp:ListItem>
                                        <asp:ListItem>2</asp:ListItem>
                                        <asp:ListItem>3</asp:ListItem>
                                        <asp:ListItem>4</asp:ListItem>
                                        <asp:ListItem>5</asp:ListItem>
                                        <asp:ListItem>6</asp:ListItem>
                                        <asp:ListItem>7</asp:ListItem>
                                        <asp:ListItem>8</asp:ListItem>
                                        <asp:ListItem>9</asp:ListItem>
                                        <asp:ListItem>10</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="input-group">
                                    <span class="input-group-addon">Children</span>
                                    <asp:DropDownList ID="Children" Class="form-control" runat="server">
                                        <asp:ListItem>1</asp:ListItem>
                                        <asp:ListItem>2</asp:ListItem>
                                        <asp:ListItem>3</asp:ListItem>
                                        <asp:ListItem>4</asp:ListItem>
                                        <asp:ListItem>5</asp:ListItem>
                                        <asp:ListItem>6</asp:ListItem>
                                        <asp:ListItem>7</asp:ListItem>
                                        <asp:ListItem>8</asp:ListItem>
                                        <asp:ListItem>9</asp:ListItem>
                                        <asp:ListItem>10</asp:ListItem>
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
             <%--   <p id="DataText" runat="server"></p>--%>
                <br />
                <br />
                <br />

            </div>

        </div>


    </form>
</body>
</html>

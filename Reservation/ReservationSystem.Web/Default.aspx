<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ReservationSystem.Web._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="StyleSection" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentSection" runat="server">
    <!-- Main component for a primary marketing message or call to action -->
    <form id="form1" runat="server">
        <div class="row">
            <div class="col-md-4">
            </div>
            <div class="col-md-4">
                Location
        <br />
                <asp:TextBox ID="Location" runat="server"></asp:TextBox>
                <br />
                <br />
                Checkin
        <br />
                <asp:TextBox ID="Checkin" runat="server"></asp:TextBox>
                <br />
                <br />
                Checkout
        <br />
                <asp:TextBox ID="Checkout" runat="server"></asp:TextBox>
                <br />
                <br />
                Room
        <br />
                <asp:DropDownList ID="SelectRoomDropdown" runat="server">
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
                <br />
                <div id="reservation">
                    <asp:Panel ID="SearchPanel" runat="server" Height="156px" Style="margin-bottom: 62px" Width="1178px">
                        <br />
                        Room Adult Children
            <br />
                        <br />
                        <asp:DropDownList ID="Adult" runat="server">
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

                        <asp:DropDownList ID="Children" runat="server">
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
                        <br />
                    </asp:Panel>
                    <br />
                </div>
                <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
                <p id="DataText" runat="server"></p>
                <br />


            </div>
            <div class="col-md-4">
            </div>
        </div>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptSection" runat="server">

    <script type="text/javascript">
        $(document).ready(function () {

         
                $('#SelectRoomDropdown').on('change', function() {
                    var roomToBook = document.getElementById("SelectRoomDropdown").val();

                var numberOfClonedClass = $(".clonedClass").length + 1;
                if (numberOfClonedClass > roomToBook) {
                    $(".clonedClass").each(function (index) {
                        if (index + 2 > roomToBook) {
                            $(this).remove();
                        }
                    });
                    return false
                };

                for (var index = 0; index < roomToBook - numberOfClonedClass; index++) {
                    $("#SearchPanel").clone().addClass("clonedClass").appendTo("#reservation");
                }
            });
        });
    </script>

</asp:Content>




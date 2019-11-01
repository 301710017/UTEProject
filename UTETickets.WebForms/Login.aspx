<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UTETickets.WebForms.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Principal-->

    <div class="container">
        <div class="row">

            <!--Inicia Login-->

            <div class="col">

                <div class="row">
                    <div class="col-lg">
                        <h1 class="centrar">Manager Login</h1>
                        <div class="row">
                            <div class="col">
                                <p class="centrar">
                                    <img src="images/Admin.PNG" width="150" height="150">
                                </p>
                            </div>
                            <!--Inicia Text-box-->
                            <div class="col">
                                <div class="row">
                                    <div class="col">
                                        <br />
                                        <asp:TextBox ID="TxtManagerID" runat="server" placeholder="ManagerID"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <br />
                                        <asp:TextBox ID="TxtPasswor" runat="server" placeholder="Password" Type="password"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <br />
                                        <asp:ImageButton ID="btnLogin" runat="server" ImageAlign="Right" ImageUrl="~/Image/UserLogin.png" />
                                    </div>
                                </div>
                            </div>
                            <!--Termina text-box-->
                        </div>
                    </div>
                </div>


                <br />
            </div>

            <!--Termina Login-->



            <div class="col-sm-1">
                .........
            </div>
            <!--inicia formulario compra-->
            <div class="col-lg">
                <div class="row">
                    <div class="col">
                        <h1 class="centrar">Tickets</h1>
                    </div>
                    <div class="col">
                        <img src="images/Ticket.PNG" width="93" height="78">
                    </div>
                </div>
                <div class="col">
                    <div class="row">
                        <!--Comienza text-box Tickets-->
                        <div class="col">
                            <div class="col">
                                <div class="row">
                                    <div class="col">
                                        <br />
                                        <asp:TextBox ID="txtIdCustomer" runat="server" placeholder="CustomerID/StudentID" Width="100%"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <br />
                                        <asp:TextBox ID="txtNameCustomer" runat="server" placeholder="Name" Width="100%"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <br />
                                        <asp:TextBox ID="txtLastName" runat="server" placeholder="LastName" Width="100%"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <br />
                                        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <br />
                                        <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
                                    </div>
                                    <div class="col">
                                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Image/ruta.png" />
                                    </div>

                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                     <p class="centrar">Service:</p>
                                </div>
                                <div class="col">
                                    <asp:CheckBox ID="chkIn" runat="server" Text="In" />
                                </div>
                                <div class="col">
                                    <asp:CheckBox ID="chkOut" runat="server" Text="Out" />
                                </div>
                            </div>


                            <div class="row">
                                <div class="col">
                                    <asp:ImageButton ID="btnShop" runat="server" ImageUrl="~/Image/anadir-a-la-cesta.png" ImageAlign="Left" />
                                </div>
                                <div class="col">
                                    <asp:ImageButton ID="btnCancel" runat="server" ImageUrl="~/Image/quitar-del-carro.png" ImageAlign="Right" />
                                </div>
                                <br />
                            </div>
                        </div>
                    </div>
                    <!--Termina text-box tickets-->

                </div>
            </div>
        </div>
    </div>
    </div>
    <!--termina formulario compra-->

    <!--Termina principal-->
</asp:Content>

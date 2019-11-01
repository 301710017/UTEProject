<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Comprobation.aspx.cs" Inherits="UTETickets.WebForms.Comprobation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <!--Verificar datos-->
        <div class="row">
            <div class="col-lg">
                <!--Encabezado-->
                <div class="row">
                    <div class="col">Imagen</div>
                    <div class="col">Mensaje</div>
                    <div class="col">Imagen</div>
                </div>
                <!--Termina encabezado-->
                <!--Formulario-->
                <div class="row">
                    
                     <div class="col" style="left: 0px; top: 0px">
                         <div class="row">
                             <div class="col"><asp:Label ID="LblId" runat="server" Text="Id:"></asp:Label></div>
                         </div>
                         <div class="row">
                             <div class="col"><asp:Label ID="LblName" runat="server" Text="Name:"></asp:Label> </div>
                         </div>
                         <div class="row">
                             <div class="col"><asp:Label ID="LblLName" runat="server" Text="LastName:"></asp:Label> </ div>
                             </div>
                         </div>
                     </div>
                <!--Inician textbox 1c-->
                    <div class="col">TextBox</div>
                <!--Finalizan textbox 1c-->
                <!--Inician textbox 2c-->
                    <div class="col">TextBox</div>
                <!--Finalizan textbox 1c-->
                </div>
                <!--Termina formulario-->
            </div>
            <div class="col-sm-1">
                <!--Termina verficar datos-->
                <!--Realizar pago-->
            </div>
            <div class="col-lg">
                One of three columns
                 
            </div>
            <!--Termina realizar pago-->
        </div>
    </div>
</asp:Content>

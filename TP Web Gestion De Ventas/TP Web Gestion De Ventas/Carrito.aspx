<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="TP_Web_Gestion_De_Ventas.Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>




<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Repeater runat="server" ID="repCarrito">
        <ItemTemplate>
            <div class="row">
                <div class="col-md-3 mb-4">
                    <div class="card border border-dark font-weight-bold mx-auto h-100" style="width: 18rem;">
                        <div class="card-body">
                            <h5 class="card-title"><%# Eval("Nombre") %></h5>
                            <p class="card-text"><%# Eval("Descripcion") %></p>
                            <p class="card-text">Precio: $ <%# string.Format("{0:0.00}", Eval("Precio")) %></p>
                           
                        </div>
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>


    <asp:Label runat="server" ID="lblTotalCarrito" Text="Total del Carrito: $ 0.00" />
    <asp:Button ID="btnConfirmarCompra" runat="server" Text="Confirmar compra" OnClick="btnConfirmarCompra_Click" CssClass="btn btn-success" />

    <p>
        <asp:Label ID="lblMensajeCompra" runat="server" Text="" Visible="false"></asp:Label>
    </p>

</asp:Content>


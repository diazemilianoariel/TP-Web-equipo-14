<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="TP_Web_Gestion_De_Ventas.Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>




<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<<<<<<< HEAD
    <asp:Label runat="server" ID="lblTotalCarrito" Text="Total del Carrito: $ 0.00" />
    <asp:Button ID="btnConfirmarCompra" runat="server" Text="Confirmar compra" OnClick="btnConfirmarCompra_Click" CssClass="btn btn-success" />
=======
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

>>>>>>> c0ed065279347bf81f8f41d028a49b88e9f14cb0
    <p>
        <asp:Label ID="lblMensajeCompra" runat="server" Visible="false"></asp:Label>
    </p>
<<<<<<< HEAD


    <asp:GridView ID="listaTotal" CssClass="table" runat="server"></asp:GridView>


    <div>
        <div>
            <asp:Button Text="+" runat="server" OnClick="btnSumar_Click" ID="btnSumar"  CssClass="btn btn-primary bi bi-plus " />
            <asp:TextBox runat="server" id="txtCantidad" CssClass="txt"/>
            <%--<asp:Label runat="server" ID="lblCantidad" CssClass="label" />--%>
            <asp:Button Text="-" runat="server" OnClick="btnRestar_Click" ID="btnRestar"  CssClass="btn btn-primary bi bi-minus" />
            <asp:Button runat="server" OnClick="btnBorrar_Click" ID="btnBorrar"  CssClass="btn btn-danger btn-close" />
        </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>



=======
>>>>>>> c0ed065279347bf81f8f41d028a49b88e9f14cb0

</asp:Content>


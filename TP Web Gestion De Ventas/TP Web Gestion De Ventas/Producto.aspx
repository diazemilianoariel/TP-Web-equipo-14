<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Producto.aspx.cs" Inherits="TP_Web_Gestion_De_Ventas.Producto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Mochiy+Pop+One&display=swap">
    <link href="estilos1.css" rel="stylesheet" />

    <section class="body-def">
        <div class="container">
            <div class="row">
                <asp:Repeater runat="server" ID="repRepetidor">
                    <ItemTemplate>
                        <div class="col-md-3 mb-4 article-card">
                            <div class="card border border-dark font-weight-bold mx-auto h-100" style="width: 18rem;">
                                <img class="card-img-top " src='<%# Eval("ImagenUrl") %>' alt="Card image cap" />
                                <div class="card-body d-flex flex-column">
                                    <h5 class="card-title"><%# Eval("Nombre") %></h5>
                                    <p class="card-text"><%# Eval("Descripcion") %></p>
                                    <p class="card-text flex-grow-1"></p>
                                    <p class="card-text">Precio: $ <%# string.Format("{0:0.00}", Eval("Precio")) %></p>
                                    <div class="mt-auto">
                                        <asp:Button ID="btnAgregarAlCarrito" runat="server" Text="Agregar al carrito" OnClick="btnAgregarAlCarrito_Click" CssClass="btn btn-primary mb-2" CommandArgument='<%# Eval("Id") %>' Style="background-color: #007bff; color: white;" onmouseover="this.style.backgroundColor = '#a732da';" onmouseout="this.style.backgroundColor = '#007bff';" />
                                        <button class="btn-Ver-Detalle">
                                            <a href='<%# "DetalleProducto.aspx?id=" + Eval("Id") %>'>Detalle</a>
                                        </button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </section>


<%--    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script>
        function actualizarContador() {
            $.ajax({
                url: 'Default.aspx/ObtenerCantidadCarrito',
                type: 'POST',
                contentType: 'application/json; charset=utf-8',
                dataType: 'json',
                success: function (data) {

                    contadorCarrito.textContent = data.d;
                },

            });
        }
    </script>--%>

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="TP_Web_Gestion_De_Ventas.Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label runat="server" ID="lblTotalCarrito" Text="Total del Carrito: $ 0.00" />
    <asp:Button ID="btnConfirmarCompra" runat="server" Text="Confirmar compra" OnClick="btnConfirmarCompra_Click" CssClass="btn btn-success" />
    <p>
        <asp:Label ID="lblMensajeCompra" runat="server" Visible="false"></asp:Label>
    </p>


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




</asp:Content>


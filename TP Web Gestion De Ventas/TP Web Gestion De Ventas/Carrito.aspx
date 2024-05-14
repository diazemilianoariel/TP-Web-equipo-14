<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="TP_Web_Gestion_De_Ventas.Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label runat="server" ID="lblTotalCarrito" Text="Total del Carrito: $ 0.00" />
    <asp:Button ID="btnConfirmarCompra" runat="server" Text="Confirmar compra" OnClick="btnConfirmarCompra_Click" CssClass="btn btn-success" />
    <p>
        <asp:Label ID="lblMensajeCompra" runat="server" Text="" Visible="false"></asp:Label>
    </p>

    
    <asp:GridView ID="listaTotal" CssClass="table" runat="server"></asp:GridView>






</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="TP_Web_Gestion_De_Ventas.Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Aca se van a ver los productos agregados al carrito</h1>
    <asp:GridView runat="server" ID="gridViewArticulos" CssClass="table table-bordered table-responsive table-secondary" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="ID" DataField="id"/>
            <asp:BoundField HeaderText="Codigo" DataField="codigo"/>
            <asp:BoundField HeaderText="Nombre" DataField="nombre"/>
            <asp:BoundField HeaderText="Precio" DataField="precio"/>
        </Columns>
    </asp:GridView>
</asp:Content>

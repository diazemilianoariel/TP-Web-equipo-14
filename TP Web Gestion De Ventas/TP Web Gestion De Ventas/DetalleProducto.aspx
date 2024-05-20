<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="DetalleProducto.aspx.cs" Inherits="TP_Web_Gestion_De_Ventas.DetalleProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <h1>DETALLE DE PRODUCTO: </h1>
    <div class="container col-7">
        <div class="form-group">
            <asp:Label ID="lblNombre" runat="server" Text="ID:" CssClass="control-label"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control mx-auto"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="lblDescripcion" runat="server" Text="categoria:" CssClass="control-label"></asp:Label>
            <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine" CssClass="form-control mx-auto"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="lblImporte" runat="server" Text="precio:" CssClass="control-label"></asp:Label>
            <asp:TextBox ID="txtImporte" runat="server" CssClass="form-control mx-auto"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="marca:" CssClass="control-label"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control mx-auto"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="codigo:" CssClass="control-label"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control mx-auto"></asp:TextBox>
        </div>
    </div>


    <div class="imagen-container">
        <asp:Repeater runat="server" ID="repRepetidor">
            <ItemTemplate>
                <img src='<%# Container.DataItem %>' alt="Imagen" />
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>


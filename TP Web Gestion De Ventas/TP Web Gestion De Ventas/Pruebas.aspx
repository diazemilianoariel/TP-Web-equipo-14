<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Pruebas.aspx.cs" Inherits="TP_Web_Gestion_De_Ventas.Pruebas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <asp:Button Text="Restar" CssClass="btn-primary" runat="server" id="btnRestar" OnClick="btnRestar_Click"/>
        <asp:Label Text="5" runat="server" ID="lblPrueba"/>
        <asp:Button Text="Sumar" CssClass="btn-primary" runat="server" id="btnSumar" OnClick="btnSumar_Click"/>
    </div>
    <div>
        <asp:GridView runat="server" ID="grdListaCompleta"></asp:GridView>
    </div>
</asp:Content>

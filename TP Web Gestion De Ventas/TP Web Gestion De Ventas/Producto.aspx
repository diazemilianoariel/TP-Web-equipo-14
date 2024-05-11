<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Producto.aspx.cs" Inherits="TP_Web_Gestion_De_Ventas.Producto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>




<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Menu Productos </h1>
    <h2>aca van los productos.....</h2>

    <div class="row row-cols-1 row-cols-md-3 g-4">
        <%--<div class="col">
            <div class="card">
                <img src="..." class="card-img-top" alt="...">
                <div class="card-body">
                    <h5 class="card-title">Card title</h5>
                    <p class="card-text">This is a longer card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                </div>
            </div>
        </div>--%>
        <asp:Repeater runat="server" ID="repRepetidor">
            <ItemTemplate>
                <div class="col">
            <div class="card">
                <img src="<%#Eval("ImagenUrl") %>" class="card-img-top" alt="...">
                <div class="card-body">
                    <h5 class="card-title"><%#Eval("nombre") %></h5>
                    <p class="card-text"><%#Eval("descripcion") %></p>
                    <%--<a href=""></a>--%> <!--ACA VA UN LINK!!! -->
                </div>
            </div>
        </div>
            </ItemTemplate> 
        </asp:Repeater>
    </div>
</asp:Content>

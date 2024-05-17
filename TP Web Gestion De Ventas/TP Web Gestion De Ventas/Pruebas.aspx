<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Pruebas.aspx.cs" Inherits="TP_Web_Gestion_De_Ventas.Pruebas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!-- Prueba grilla con botones-->
    <table class="table table-bordered">
        <thead>
            <tr>
                <th>Artículo</th>
                <th>Precio Unitario</th>
                <th>Subtotal</th>
                <th>Cantidad</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Id") %></td>
                        <td><%# Eval("Nombre") %></td>
                        <td><%# Eval("Precio") %></td>
                        <td><%#Eval("Cantidad") %></td>
                        <td>
                            <div class="btn-group" role="group">
                                <asp:Button Text="restar" CssClass="btn-primary" runat="server" ID="btnRestar" OnClick="btnRestar_Click1" CommandArgument='<%#Eval("Id") %>' CommandName="restar" />
                                <asp:Label Text='<%#Eval("Cantidad") %>' runat="server" ID="lblprueba1" />
                                <asp:Button Text="sumar" CssClass="btn-primary" runat="server" ID="btnSumar" OnClick="btnSumar_Click1" CommandArgument='<%#Eval("Id") %>' CommandName="sumar" />
                            </div>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>

    <%--<div>
        <asp:Button Text="Restar" CssClass="btn-primary" runat="server" ID="btnRestar" OnClick="btnRestar_Click" />
        <asp:Label Text="5" runat="server" ID="lblPrueba" />
        <asp:Button Text="Sumar" CssClass="btn-primary" runat="server" ID="btnSumar" OnClick="btnSumar_Click" />
    </div>--%>



</asp:Content>

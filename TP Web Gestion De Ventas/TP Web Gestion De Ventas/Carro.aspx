<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Carro.aspx.cs" Inherits="TP_Web_Gestion_De_Ventas.Carro" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!-- Prueba grilla con botones-->
    <table class="table table-bordered">
        <thead>
            <tr>
                <th>ID</th>
                <th>Articulo</th>
                <th>Precio Unitario</th>
                <th>Cantidad</th>
                <th>Subtotal</th>
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
                        <td><%#Eval("subtotal") %></td>
                        <td>
                            <div>
                                <asp:Button Text="-" CssClass="btn btn-primary mb-2" runat="server" ID="btnRestar" OnClick="btnRestar_Click" CommandArgument='<%#Eval("Id") %>' CommandName="restar" />
                                <asp:Label Text='<%#Eval("Cantidad") %>' runat="server" ID="lblprueba1" class="display-6" />
                                <asp:Button Text="+" CssClass="btn btn-primary mb-2" runat="server" ID="btnSumar" OnClick="btnSumar_Click" CommandArgument='<%#Eval("Id") %>' CommandName="sumar" />
                            </div>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>

        </tbody>
    </table>

    <asp:Label runat="server" Text="Total de la compra :"></asp:Label>
    <asp:label runat="server" ID="lblMontoTotal" ></asp:label>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ConfirmaEliminar.aspx.cs" Inherits="controlClientes.ConfirmaEliminar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-3"></div>
        <div class="col-6 flex-column">
            <h2>¿Seguro que desea eliminar?</h2>
            <div class="m-3">
                <asp:Label Text="text" ID="lblEliminar" runat="server" />
            </div>
            <div class="m-3">
                <asp:Button Text="Confirma" ID="btnConfirmaEliminar" CssClass="btn btn-danger" runat="server" OnClick="btnConfirmaEliminar_Click" />
                <a href="Default.aspx" class="btn-outline-danger">Cancelar</a>
            </div>
        </div>
    </div>

</asp:Content>

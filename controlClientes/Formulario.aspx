<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="controlClientes.Formulario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-3"></div>
        <div class="col-6">
            <div class="mb-2">
                <label for="txtNombre" class="form-label">Nombre</label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-2">
                <label for="txtArticulos" class="form-label">Descripcion</label>
                <asp:TextBox ID="txtArticulos" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
            </div>
            <div class="mb-2">
                <label for="txtPrecio" class="form-label">Precio</label>
                <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-2 mt-3">
                <asp:CheckBox Text="Pagado" ID="cbxPago" runat="server" />
            </div>
            <div class="mb-2 mt-3">
                <asp:Button ID="btnAceptar" runat="server" CssClass="btn btn-primary" Text="Aceptar" OnClick="btnAceptar_Click" />
                <a href="Default.aspx">Cancelar</a>
            </div>
        </div>
    </div>
</asp:Content>

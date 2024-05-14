<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="controlClientes.Formulario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="row">
        <div class="col-3"></div>
        <div class="col-6">
            <div class="mb-2">
                <label for="txtNombre" class="form-label">Nombre</label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-2">
                <label for="txtArticulos" class="form-label">Articulos</label>
                <asp:TextBox ID="txtArticulos" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
            </div>
            <div class="mb-2">
                <label for="txtPrecio" class="form-label">Precio</label>
                <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <div class="flex-row">
                        <div class="form-check form-check-inline">
                            <asp:CheckBox ID="cbxPagado" CssClass="form-check-input bg-transparent m-0" AutoPostBack="true" OnCheckedChanged="cbxPagado_CheckedChanged" runat="server" />
                            <asp:Label Text="Pagado" CssClass="form-check-label  link-success badge " runat="server" />
                        </div>
                        <div class="form-check form-check-inline">
                            <asp:CheckBox ID="cbxFaltaPagar" CssClass="form-check-input bg-transparent m-0" AutoPostBack="true" OnCheckedChanged="cbxFaltaPagar_CheckedChanged" runat="server" />
                            <asp:Label Text="Falta Pagar" CssClass="form-check-label badge link-danger" runat="server" />
                        </div>
                    </div>

                    <%if (faltaPagar)

                        {%>
                    <div class="mb-2">
                        <label for="txtNoPago" class="form-label">Falta Pagar</label>
                        <asp:TextBox ID="txNoPago" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <% } %>
                    <div class="mb-2 mt-3">
                        <asp:Button ID="btnAceptar" runat="server" CssClass="btn btn-primary" Text="Aceptar" OnClick="btnAceptar_Click" />
                        <a href="Default.aspx">Cancelar</a>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>

        </div>
    </div>
</asp:Content>

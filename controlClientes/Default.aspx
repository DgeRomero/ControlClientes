<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="controlClientes.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:GridView runat="server" ID="dgvLista" DataKeyNames="Id"
                CssClass="table table-bordered table-hover" AutoGenerateColumns="false"
                OnSelectedIndexChanged="dgvLista_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                    <asp:BoundField HeaderText="Articulos" DataField="Articulos" />
                    <asp:BoundField HeaderText="Precio" DataField="Precio" />
                    <asp:BoundField HeaderText="Nombre" DataField="Pagado" />
                    <asp:CommandField HeaderText="Editar" ShowSelectButton="true" ItemStyle-CssClass="text-center" SelectText="🔥" />
                </Columns>
            </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>
    <a href="Formulario.aspx" class="btn btn-primary">Agregar</a>
</asp:Content>

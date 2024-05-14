<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="controlClientes.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <h1>Control de clientes</h1>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:GridView runat="server" ID="dgvLista" DataKeyNames="Id"
                CssClass="table table-bordered table-hover m-3" AutoGenerateColumns="false"
                OnSelectedIndexChanged="dgvLista_SelectedIndexChanged"
                OnRowCommand="dgvLista_RowCommand">
                <Columns>
                    <asp:BoundField HeaderText="Id" DataField="Id" Visible="false" />
                    <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                    <asp:BoundField HeaderText="Articulos" DataField="Articulos" />
                    <asp:BoundField HeaderText="Precio" DataField="Precio" DataFormatString="${0:F2}" />
                    <asp:BoundField HeaderText="Falta Pagar" DataField="FaltaPagar" DataFormatString="${0:F2}" />
                    <asp:CheckBoxField HeaderText="Pagado" DataField="Pagado" ItemStyle-CssClass="text-center"/>
                    <asp:CommandField HeaderText="Editar" ShowSelectButton="true" ItemStyle-CssClass="text-center" SelectText="✍" />
                    <asp:buttonfield headertext="Eliminar" buttontype="button" controlstyle-cssclass="btn btn-danger" itemstyle-cssclass="text-center" text="❌" commandname="btnEliminar" />   
                </Columns>
            </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>
    <div class="row">
        <div col="3">
            <a href="Formulario.aspx" class="btn btn-primary">Agregar</a>
        </div>
    </div>
</asp:Content>

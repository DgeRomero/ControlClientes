using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace controlClientes
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClienteNegocio negocio = new ClienteNegocio();
                Session.Add("clientes", negocio.listar());
                dgvLista.DataSource = Session["clientes"];
                dgvLista.DataBind();
            }
        }

        protected void dgvLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = dgvLista.SelectedDataKey.Value.ToString();
            Response.Redirect("Formulario.aspx?id=" + id);
        }

        protected void dgvLista_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            ClienteNegocio negocio = new ClienteNegocio();

            if(e.CommandName == "btnEliminar")
            {
                int index = int.Parse(e.CommandArgument.ToString());
                Cliente seleccionado = negocio.listar()[index];
                int id = seleccionado.Id;
                //negocio.eliminar(id);
                //Response.Redirect("Default.aspx", false);
                Response.Redirect("ConfirmaEliminar.aspx?id=" + id, false);
            }
        }


    }
}
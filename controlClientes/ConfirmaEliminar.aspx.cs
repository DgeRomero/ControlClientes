using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace controlClientes
{
    public partial class ConfirmaEliminar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClienteNegocio negocio = new ClienteNegocio();
            string id = Request.QueryString["id"];
            Cliente seleccionado = negocio.listar(id)[0];
            Session.Add("seleccionado", seleccionado);
            lblEliminar.Text = seleccionado.Articulos;
        }

        protected void btnConfirmaEliminar_Click(object sender, EventArgs e)
        {
            Cliente select = (Cliente)Session["seleccionado"];
            ClienteNegocio negocio = new ClienteNegocio();
            negocio.eliminar(select.Id);
            Response.Redirect("Default.aspx", false);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
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

        }
    }
}
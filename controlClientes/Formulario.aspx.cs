using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace controlClientes
{
    public partial class Formulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string id = Request.QueryString["id"] != null ? Request.QueryString["id"] : "";
                if (id != "" && !IsPostBack)
                {
                    ClienteNegocio negocio = new ClienteNegocio();
                    Cliente seleccionado = negocio.listar(id)[0];
                    Session.Add("seleccionado", seleccionado);

                    txtNombre.Text = seleccionado.Nombre;
                    txtPrecio.Text = seleccionado.Precio.ToString();
                    txtArticulos.Text = seleccionado.Articulos;
                    cbxPago.Checked = seleccionado.Pagado;
                }
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
            }
            
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente nuevo = new Cliente();
                ClienteNegocio negocio = new ClienteNegocio();
                nuevo.Nombre = txtNombre.Text;
                nuevo.Precio = decimal.Parse(txtPrecio.Text);
                nuevo.Articulos = txtArticulos.Text;
                nuevo.Pagado = cbxPago.Checked;
                if (Request.QueryString["id"] != null)
                {
                    nuevo.Id = int.Parse(Request.QueryString["id"]);
                    negocio.modificar(nuevo);
                }
                else
                    negocio.agregar(nuevo);
    
                Response.Redirect("Default.aspx", false);
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
            }
        }
    }
}
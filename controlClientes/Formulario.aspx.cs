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
        public bool faltaPagar = false;
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
                    txtArticulos.Text = seleccionado.Articulos;
                    txtPrecio.Text = seleccionado.Precio.ToString();
                    txNoPago.Text = seleccionado.FaltaPagar.ToString();
                    cbxPagado.Checked = seleccionado.Pagado;
                    cbxFaltaPagar.Checked = !seleccionado.Pagado;
                    faltaPagar = cbxFaltaPagar.Checked;
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
                nuevo.Pagado = cbxPagado.Checked;
                if (txNoPago.Text != "")
                    nuevo.FaltaPagar = decimal.Parse(txNoPago.Text);
                else
                {
                    nuevo.FaltaPagar = 0;
                }

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

        protected void cbxFaltaPagar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxFaltaPagar.Checked)
            {
                faltaPagar = true;
                cbxPagado.Checked = false;
            }
            else
            {
                faltaPagar = false;
                txNoPago.Text = "";
            }
        }

        protected void cbxPagado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPagado.Checked)
            {
                cbxFaltaPagar.Checked = false;
                txNoPago.Text = "";
                faltaPagar = false;
            }
            
        }
    }
}
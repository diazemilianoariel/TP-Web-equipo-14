using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataManager;
using Dominio;

namespace TP_Web_Gestion_De_Ventas
{
    public partial class Carrito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //prueba datos en session...
            //listaTotal.DataSource = Session["listaArticulos"];
            //listaTotal.DataBind();
            if (!IsPostBack)
            {
                // Cargar la cantidad inicial en el Label solo en la primera carga de la página
                txtCantidad.Text = "primera carga...";
                //lblCantidad.Text = "0";
            }
            //else
            //{
            //    txtCantidad.Text = "porqueria...";
            //}
            //int cantidad = 1;
            //lblCantidad.Text = cantidad.ToString();
        }


        /*
        protected void btnConfirmarCompra_Click(object sender, EventArgs e)
        {

            Session.Remove("Seleccionados");

            lblMensajeCompra.Text = "Muchas Gracias por su compra";
            lblMensajeCompra.Visible = true;
        }
        */
        protected void btnSumar_Click(object sender, EventArgs e)
        {
            int cant = int.Parse(txtCantidad.Text);
            //int cant = int.Parse(lblCantidad.Text);
            cant = cant + 1;
            txtCantidad.Text = cant.ToString();
            //lblCantidad.Text = cant.ToString();
            Response.Redirect(Request.RawUrl);
            Label1.Text = "Cambiooooo ++++";
        }

        protected void btnRestar_Click(object sender, EventArgs e)
        {
            int cant = int.Parse(txtCantidad.Text);
            //int cant = int.Parse(lblCantidad.Text);
            cant = cant - 1;

            txtCantidad.Text = "Prueba";
            //txtCantidad.Text = cant.ToString();
            //lblCantidad.Text = cant.ToString();
            //lblCantidad.Text = "perroooo";
            Response.Redirect(Request.RawUrl);
            Label1.Text = "Cambiooooo ----";
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            ;
        }
    }
}
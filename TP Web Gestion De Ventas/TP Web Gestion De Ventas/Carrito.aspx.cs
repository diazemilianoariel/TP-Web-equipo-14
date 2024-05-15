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
            if (Session["Seleccionados"] != null)
            {
                List<Articulo> seleccionados = (List<Articulo>)Session["Seleccionados"];

                if (!IsPostBack)
                {
                    repCarrito.DataSource = seleccionados;
                    repCarrito.DataBind();


                    
                }

            }




        }

        

        protected void btnConfirmarCompra_Click(object sender, EventArgs e)
        {

            Session.Remove("Seleccionados");

            lblMensajeCompra.Text = "Muchas Gracias por su compra";
            lblMensajeCompra.Visible = true;
        }



        
    }
}
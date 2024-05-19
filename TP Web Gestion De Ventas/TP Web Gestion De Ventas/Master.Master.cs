using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace TP_Web_Gestion_De_Ventas
{
    public partial class Master : System.Web.UI.MasterPage
    {
        Carrito carritox;
        protected void Page_Load(object sender, EventArgs e)
        {
            //funciona codigo en master?
            if (!IsPostBack)
            {
                if (Session["carrito"] == null)
                {
                    LabelCarro.Text = "0";
                }
                else
                {
                    carritox = (Carrito)Session["carrito"];
                    LabelCarro.Text = carritox.cantidadTotal().ToString();
                }
            }
        }
    }
}
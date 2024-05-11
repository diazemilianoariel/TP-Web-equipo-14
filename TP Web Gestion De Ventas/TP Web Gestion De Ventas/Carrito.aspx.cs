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
            ArticuloManager articuloManager = new ArticuloManager();

            gridViewArticulos.DataSource = articuloManager.Listar();
            gridViewArticulos.DataBind();
        }
    }
}
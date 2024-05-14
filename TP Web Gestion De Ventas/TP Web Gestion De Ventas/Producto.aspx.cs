using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using DataManager;


namespace TP_Web_Gestion_De_Ventas
{
    public partial class Producto : System.Web.UI.Page
    {
        public List<Articulo> listaArticulos {  get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloManager articuloManager = new ArticuloManager();
            listaArticulos = articuloManager.Listar();
            repRepetidor.DataSource = listaArticulos;
            repRepetidor.DataBind();

            Session.Add("listaArticulos", listaArticulos);
        }
    }
}
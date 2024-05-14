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

            if (!IsPostBack)
            {
                repRepetidor.DataSource = listaArticulos;
                repRepetidor.DataBind();
            }
            
        }

        protected void btnAgregarAlCarrito_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int articuloId = Convert.ToInt32(btn.CommandArgument);

            ArticuloManager articuloManager = new ArticuloManager();
            listaArticulos = articuloManager.Listar();


            List<Articulo> seleccionados;
            if (Session["Seleccionados"] == null)
            {
                seleccionados = new List<Articulo>();
            }
            else
            {
                seleccionados = (List<Articulo>)Session["Seleccionados"];
            }

            foreach (Articulo item in listaArticulos)
            {
                if (articuloId == item.id)
                {
                    seleccionados.Add(item);
                }
            }

            Session["Seleccionados"] = seleccionados;
            Response.Redirect(Request.RawUrl);
        }

    }
}
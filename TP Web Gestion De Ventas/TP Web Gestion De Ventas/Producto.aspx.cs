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
        public List<Articulo> listaArticulos { get; set; }
        public Carrito carrito { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["listaArticulo"] != null)   //pregunto si hay algo en el objeto sesion
            {
                listaArticulos = (List<Articulo>)Session["listaArticulos"];
            }
            else
            {
                ArticuloManager articuloManager = new ArticuloManager();
                listaArticulos = articuloManager.Listar();
                Session.Add("listaArticulos", listaArticulos);
            }

            if (Session["carrito"]!=null)   //pregunta si hay algo en el objeto session
            {
                carrito = (Carrito)Session["carrito"];
            }
            else
            {
                carrito=new Carrito();
                Session.Add("carrito", carrito);
            } 
            
            repRepetidor.DataSource = listaArticulos;
            repRepetidor.DataBind();
        }

        //todo...
        //sumar cantidad al articulo en cuestion(le pasamos el id por url)
        //refrescar la cantidad en el dibujo del carrito
        //GUARDAR LA INFO EN LA SESION!
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